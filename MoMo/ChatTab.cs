using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            SentMessage sentMessage = new SentMessage();
            sentMessage.Message = richTextBox1.Text;
            sentMessage.TimeAndSender = $"{DateTime.Now.ToString("HH:mm")}";
            flowLayoutPanel1.Controls.Add(sentMessage);

            Session.UserDbContext!.ChatMessages.Add(new ChatMessage()
            {
                Message = richTextBox1.Text.Trim(),
                SenderId = senderId,
                ReceiverId = receiverId
            });

            Session.UserDbContext!.SaveChanges();

            flowLayoutPanel1.ScrollControlIntoView(flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1]);
            richTextBox1.Clear();
        }

        private void AddSentMessage(ChatMessage message)
        {
            if (message == null) return;

            SentMessage sentMessage = new SentMessage();
            sentMessage.Message = message.Message;
            sentMessage.TimeAndSender = $"{message.Date.ToString("HH:mm")}";

            flowLayoutPanel1.Controls.Add(sentMessage);
        }

        private void AddSentMessageImage(ChatMessage message)
        {
            if (message == null) return;

            SentMessageImage sentMessageImage = new SentMessageImage();
            sentMessageImage.TimeAndSender = $"{message.Date.ToString("HH:mm")}";
            sentMessageImage.SentImage = Utils.BytesArrayToImage(message.Image!);

            flowLayoutPanel1.Controls.Add(sentMessageImage);
        }

        private void AddReceivedMessage(ChatMessage message)
        {
            if (message == null) return;

            ReceivedMessage receivedMessage = new ReceivedMessage();
            receivedMessage.Message = message.Message;
            receivedMessage.TimeAndSender = $"{message.Date.ToString("HH:mm")}";

            flowLayoutPanel1.Controls.Add(receivedMessage);
        }

        private void AddReceivedMessageImage(ChatMessage message)
        {
            if (message == null) return;

            ReceivedMessageImage receivedMessageImage = new ReceivedMessageImage();
            receivedMessageImage.TimeAndSender = $"{message.Date.ToString("HH:mm")}";
            receivedMessageImage.ReceivedImage = Utils.BytesArrayToImage(message.Image!);

            flowLayoutPanel1.Controls.Add(receivedMessageImage);
        }

        private void LoadMessageHistory()
        {
            List<ChatMessage> messagesHistory = Session.UserDbContext!.ChatMessages
                .Where(m => (m.SenderId == senderId && m.ReceiverId == receiverId) || (m.SenderId == receiverId && m.ReceiverId == senderId))
                .OrderBy(m => m.Date)
                .ToList();

            foreach (ChatMessage message in messagesHistory)
            {
                if (message.SenderId == senderId)
                {
                    if (string.IsNullOrEmpty(message.Message) && message.Image != null)
                        AddSentMessageImage(message);
                    else
                        AddSentMessage(message);
                }
                else
                {
                    if (string.IsNullOrEmpty(message.Message) && message.Image != null)
                        AddReceivedMessageImage(message);
                    else
                        AddReceivedMessage(message);
                }
            }

            flowLayoutPanel1.ScrollControlIntoView(flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1]);
        }


        private void CheckForNewMessage()
        {
            // Check for new message
            // If there is a new message, add it to the flow layout panel
            // If the new message is from the current receiver, mark it as read

            List<ChatMessage> messages = Session.UserDbContext!.ChatMessages
                .Where(m => m.SenderId == receiverId && m.ReceiverId == senderId && !m.IsRead)
                .ToList();

            if (messages.Count == 0)
                return;

            foreach (ChatMessage message in messages)
            {
                if (string.IsNullOrEmpty(message.Message) && message.Image != null)
                    AddReceivedMessageImage(message);
                else
                    AddReceivedMessage(message);

                message.IsRead = true;
            }

            Session.UserDbContext!.SaveChanges();
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ChatMessage sentMessageImage = new ChatMessage
                {
                    Image = Utils.ImageToBytesArray(Image.FromFile(openFileDialog.FileName)),
                    SenderId = senderId,
                    ReceiverId = receiverId
                };

                AddSentMessageImage(sentMessageImage);

                Session.UserDbContext!.ChatMessages.Add(sentMessageImage);
                Session.UserDbContext!.SaveChanges();

                flowLayoutPanel1.ScrollControlIntoView(flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1]);
            }
        }

        private void ChatTab_Load(object sender, EventArgs e)
        {
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
    }
}
