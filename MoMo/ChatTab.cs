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

namespace MoMo
{
    public partial class ChatTab : Form
    {
        private int senderId;
        private int receiverId;

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
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Label? lastTimeLabel = flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1] as Label;
                if (lastTimeLabel != null)
                {
                    DateTime lastMessageTime = DateTime.Parse(lastTimeLabel.Text);
                    if (DateTime.Now.Subtract(lastMessageTime).TotalMinutes > 10)
                        AddTimeLabel(DateTime.Now);
                }
            }
            else
                AddTimeLabel(DateTime.Now);

            SentMessage sentMessage = new()
            {
                Message = richTextBox1.Text,
                TimeAndSender = $"{DateTime.Now.ToString("HH:mm")}"
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
                TimeAndSender = $"{message.Date.ToString("HH:mm")}"
            };

            flowLayoutPanel1.Controls.Add(sentMessage);
        }

        private void AddSentMessageImage(ChatMessage message)
        {
            if (message == null) return;

            SentMessageImage sentMessageImage = new SentMessageImage
            {
                TimeAndSender = $"{message.Date.ToString("HH:mm")}",
                SentImage = Utils.BytesArrayToImage(message.Image!)
            };

            flowLayoutPanel1.Controls.Add(sentMessageImage);
        }

        private void AddReceivedMessage(ChatMessage message)
        {
            if (message == null) return;

            ReceivedMessage receivedMessage = new ReceivedMessage
            {
                Message = message.Message,
                TimeAndSender = $"{message.Date.ToString("HH:mm")}"
            };

            flowLayoutPanel1.Controls.Add(receivedMessage);
        }

        private void AddReceivedMessageImage(ChatMessage message)
        {
            if (message == null) return;

            ReceivedMessageImage receivedMessageImage = new()
            {
                TimeAndSender = $"{message.Date.ToString("HH:mm")}",
                ReceivedImage = Utils.BytesArrayToImage(message.Image!)
            };

            flowLayoutPanel1.Controls.Add(receivedMessageImage);
        }

        private Label CreateTimeLabel(string time)
        {
            Label timeLabel = new()
            {
                Text = time,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Size = new Size(396, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Margin = new Padding(0, 10, 0, 10),
                Name = "timeLabel" + flowLayoutPanel1.Controls.Count
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
                    AddSentMessageImage(message);
                else
                    AddSentMessage(message);
            }
            else
            {
                if (message.Image != null)
                    AddReceivedMessageImage(message);
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
                    .Where(m => (m.SenderId == senderId && m.ReceiverId == receiverId) || (m.SenderId == receiverId && m.ReceiverId == senderId))
                    .OrderBy(m => m.Date)
                    .ToList();

                // Set all unread messages to read using LINQ
                messagesHistory.ForEach(m => m.IsRead = true);

                dbContext.SaveChanges();
            }

            if (messagesHistory.Count == 0)
                return;

            DateTime lastMessageTime = messagesHistory[0].Date;
            int lastMessageSenderId = messagesHistory[0].SenderId;

            AddTimeLabel(lastMessageTime);

            for (int i = 0; i < messagesHistory.Count; i++)
            {
                if (messagesHistory[i].SenderId != lastMessageSenderId || messagesHistory[i].Date.Subtract(lastMessageTime).TotalMinutes > 10)
                {
                    lastMessageTime = messagesHistory[i].Date;
                    lastMessageSenderId = messagesHistory[i].SenderId;

                    // Create time label from label control
                    AddTimeLabel(lastMessageTime);
                }

                AddMessageToScreen(messagesHistory[i]);
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
                .Where(m => m.SenderId == receiverId && m.ReceiverId == senderId && !m.IsRead)
                .ToList();

                // Set all unread messages to read using LINQ
                messages.ForEach(m => m.IsRead = true);

                dbContext.SaveChanges();
            }

            if (messages.Count == 0)
                return;

            DateTime lastMessageTime = messages[0].Date;
            int lastMessageSenderId = messages[0].SenderId;

            AddTimeLabel(lastMessageTime);

            for (int i = 0; i < messages.Count; i++)
            {
                if (messages[i].SenderId != lastMessageSenderId || messages[i].Date.Subtract(lastMessageTime).TotalMinutes > 10)
                {
                    lastMessageTime = messages[i].Date;
                    lastMessageSenderId = messages[i].SenderId;

                    // Create time label from label control
                    AddTimeLabel(lastMessageTime);
                }

                AddMessageToScreen(messages[i]);
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

                AddSentMessageImage(sentMessageImage);

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
            // Send record message button using NAudio
            // Record message and send it to the receiver

        }
    }
}
