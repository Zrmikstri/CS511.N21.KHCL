using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoMo.Model;
using MoMo.MyUserControl;
using NAudio.Utils;
using NAudio.Wave;
using ZXing;

namespace MoMo
{
    public partial class ChatTab : Form
    {
        private int senderId;
        private int receiverId;

        private bool isRecording = false;
        private bool isClosing = false;
        private WaveInEvent? waveIn = null;
        private WaveFileWriter? waveFileWriter = null;
        private MemoryStream? memoryStream = null;

        public ChatTab(int senderId, int receiverId)
        {
            InitializeComponent();

            this.flowLayoutPanel1.AutoScroll = false;
            this.flowLayoutPanel1.VerticalScroll.Maximum = 0;
            this.flowLayoutPanel1.VerticalScroll.Enabled = false;
            this.flowLayoutPanel1.HorizontalScroll.Maximum = 0;
            this.flowLayoutPanel1.HorizontalScroll.Enabled = false;
            this.flowLayoutPanel1.AutoScroll = true;

            this.senderId = senderId;
            this.receiverId = receiverId;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Send button
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
                return;

            // Add time label if the last message is sent more than 10 minutes ago
            // Get the last message, not the time label

            var lastMessage = flowLayoutPanel1.Controls.OfType<IMessage>().LastOrDefault();

            if (lastMessage != null) // There is at least one message in the conversation
            {
                DateTime lastMessageTime = lastMessage.Date;
                if (DateTime.Now.Subtract(lastMessageTime).TotalMinutes > 10)
                    AddTimeLabel(DateTime.Now);
            }
            else
                AddTimeLabel(DateTime.Now);

            SentMessage sentMessage = new()
            {
                Message = richTextBox1.Text,
                Date = DateTime.Now
            };

            flowLayoutPanel1.Controls.Add(sentMessage);

            using (UserDbContext dbContext = new())
            {
                dbContext.ChatMessages.Add(new ChatMessage()
                {
                    Message = richTextBox1.Text.Trim(),
                    SenderId = senderId,
                    ReceiverId = receiverId
                });

                dbContext.SaveChanges();
            }

            flowLayoutPanel1.ScrollControlIntoView(flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1]);
            richTextBox1.Clear();
        }

        private void AddSentMessage(ChatMessage message)
        {
            if (message == null) return;

            SentMessage sentMessage = new()
            {
                Message = message.Message,
                Date = message.Date
            };

            flowLayoutPanel1.Controls.Add(sentMessage);
        }

        private void AddSentImageMessage(ChatMessage message)
        {
            if (message == null) return;

            SentImageMessage sentMessageImage = new SentImageMessage
            {
                SentImage = Utils.BytesArrayToImage(message.Image!),
                Date = message.Date
            };

            flowLayoutPanel1.Controls.Add(sentMessageImage);
        }

        private void AddSentAudioMessage(ChatMessage message)
        {
            if (message == null) return;

            SentAudioMessage sentAudioMessage = new()
            {
                SentAudio = message.Audio!,
                Date = message.Date
            };
            flowLayoutPanel1.Controls.Add(sentAudioMessage);
        }

        private void AddReceivedMessage(ChatMessage message)
        {
            if (message == null) return;

            ReceivedMessage receivedMessage = new ReceivedMessage
            {
                Message = message.Message,
                Date = message.Date
            };

            flowLayoutPanel1.Controls.Add(receivedMessage);
        }

        private void AddReceivedImageMessage(ChatMessage message)
        {
            if (message == null) return;

            ReceivedImageMessage receivedMessageImage = new()
            {
                ReceivedImage = Utils.BytesArrayToImage(message.Image!),
                Date = message.Date
            };

            flowLayoutPanel1.Controls.Add(receivedMessageImage);
        }

        private void AddReceivedAudioMessage(ChatMessage message)
        {
            if (message == null) return;

            ReceivedAudioMessage receivedAudioMessage = new()
            {
                ReceivedAudio = message.Audio!,
                Date = message.Date
            };

            flowLayoutPanel1.Controls.Add(receivedAudioMessage);
        }

        private Label CreateTimeLabel(string time)
        {
            Label timeLabel = new()
            {
                Text = time,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Size = new Size(453, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Margin = new Padding(0, 10, 0, 10),
                Name = "timeLabel" + flowLayoutPanel1.Controls.Count,
                ForeColor = Color.DimGray
            };
            return timeLabel;
        }

        private void AddTimeLabel(DateTime time)
        {
            Label timeLabel = CreateTimeLabel(time.ToString("HH:mm dd/MM/yyyy"));
            flowLayoutPanel1.Controls.Add(timeLabel);
        }

        private void AddMessageToScreen(ChatMessage message)
        {
            if (message.SenderId == senderId)
            {
                if (message.Image != null)
                    AddSentImageMessage(message);
                else if (message.Audio != null)
                    AddSentAudioMessage(message);
                else
                    AddSentMessage(message);
            }
            else
            {
                if (message.Image != null)
                    AddReceivedImageMessage(message);
                else if (message.Audio != null)
                    AddReceivedAudioMessage(message);
                else
                    AddReceivedMessage(message);
            }
        }

        private void LoadMessageHistory()
        {
            List<ChatMessage> messagesHistory;
            using (UserDbContext dbContext = new())
            {
                // Seperate the messages into group of time windows
                // Each group contain messages that are sent within 10 minutes of each other
                // Each group is seperated by a time label
                // The time label is the time of the first message in the group
                // The time label is displayed in the middle of the flow layout panel

                messagesHistory = dbContext.ChatMessages
                    .Where(m =>
                        (m.SenderId == senderId && m.ReceiverId == receiverId)
                        || (m.SenderId == receiverId && m.ReceiverId == senderId))
                    .OrderBy(m => m.Date)
                    .ToList();

                if (messagesHistory.Count == 0)
                    return;

                // Set all unread messages to read using LINQ
                messagesHistory
                    .Where(m => m.ReceiverId == Session.LoggedInUserInfo!.Id)
                    .ToList()
                    .ForEach(m => m.IsRead = true);

                dbContext.SaveChanges();
            }

            DateTime lastMessageTime = messagesHistory[0].Date;

            AddTimeLabel(lastMessageTime);

            foreach (var message in messagesHistory)
            {
                if (message.Date.Subtract(lastMessageTime).TotalMinutes > 10)
                {
                    lastMessageTime = message.Date;
                    AddTimeLabel(lastMessageTime);
                }

                AddMessageToScreen(message);
            }

            flowLayoutPanel1.ScrollControlIntoView(flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1]);
        }

        private void CheckForNewMessage()
        {
            // Check for new message
            // If there is a new message, add it to the flow layout panel
            // If the new message is from the current receiver, mark it as read

            List<ChatMessage> messages;
            using (UserDbContext dbContext = new())
            {

                messages = dbContext.ChatMessages
                .Where(m =>
                    m.SenderId == receiverId && m.ReceiverId == senderId
                    && !m.IsRead)
                .ToList();

                if (messages.Count == 0)
                    return;

                // Set all unread messages to read using LINQ
                messages.ForEach(m => m.IsRead = true);

                dbContext.SaveChanges();
            }

            // Add time label if the last message is sent more than 10 minutes ago
            var lastMessage = flowLayoutPanel1.Controls.OfType<IMessage>().LastOrDefault(); ;

            DateTime lastMessageTime;

            if (lastMessage == null) // There is at least one message in the conversation
                AddTimeLabel(DateTime.Now);

            foreach (var message in messages)
            {
                lastMessageTime = lastMessage!.Date;

                if (message.Date.Subtract(lastMessageTime).TotalMinutes > 10)
                {
                    lastMessageTime = message.Date;
                    AddTimeLabel(lastMessageTime);
                }

                AddMessageToScreen(message);
            }


            flowLayoutPanel1.ScrollControlIntoView(flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckForNewMessage();
        }

        private void ChatTab_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // Send image button
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png",
                Multiselect = false,
                CheckFileExists = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ChatMessage sentMessageImage = new()
                {
                    Image = Utils.ImageToBytesArray(Image.FromFile(openFileDialog.FileName)),
                    SenderId = senderId,
                    ReceiverId = receiverId
                };

                AddSentImageMessage(sentMessageImage);

                using (UserDbContext dbContext = new())
                {
                    dbContext.ChatMessages.Add(sentMessageImage);
                    dbContext.SaveChanges();
                }

                flowLayoutPanel1.ScrollControlIntoView(flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1]);
            }
        }

        private void ChatTab_Load(object sender, EventArgs e)
        {
            // Fetch received user info
            using (UserDbContext dbContext = new())
            {
                User user = dbContext.Users.Find(receiverId)!;
                label1.Text = user.FullName;
                pictureBox1.Image = Utils.BytesArrayToImage(user.AvatarImage);
            }

            LoadMessageHistory();

            // Start timer to check for new message
            timer1.Interval = 2000;
            timer1.Start();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Shift)
                {
                    richTextBox1.AppendText(Environment.NewLine);
                    e.Handled = true;
                }
                else
                {
                    iconButton1_Click(sender, e);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            StackNavigation.Pop();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            // Record voice button using NAudio
            if (isRecording)
            {
                isRecording = false;
                iconButton3.IconColor = Color.DodgerBlue;

                waveIn!.StopRecording();
            }
            else
            {
                // Record voice into a byte array
                isRecording = true;
                iconButton3.IconColor = Color.Red;

                // Init recording
                waveIn = new WaveInEvent();
                memoryStream = new MemoryStream();
                waveFileWriter = new WaveFileWriter(new IgnoreDisposeStream(memoryStream), waveIn.WaveFormat);

                waveIn.RecordingStopped += (s, a) =>
                {
                    waveFileWriter?.Dispose();
                    waveFileWriter = null;

                    ChatMessage sentMessageVoice = new()
                    {
                        Audio = memoryStream!.ToArray(),
                        SenderId = senderId,
                        ReceiverId = receiverId
                    };

                    using (UserDbContext dbContext = new())
                    {
                        dbContext.ChatMessages.Add(sentMessageVoice);
                        dbContext.SaveChanges();
                    }

                    AddMessageToScreen(sentMessageVoice);


                    memoryStream?.Dispose();
                    memoryStream = null;

                    waveIn.Dispose();
                    waveIn = null;

                };

                waveIn.DataAvailable += (s, a) =>
                {
                    // Write buffer to byte array
                    waveFileWriter!.Write(a.Buffer, 0, a.BytesRecorded);
                };

                waveIn.StartRecording();
            }
        }
    }
}
