using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoMo
{
    public partial class ChatTab : Form
    {
        public ChatTab()
        {
            InitializeComponent();
            this.flowLayoutPanel1.AutoScroll = false;
            this.flowLayoutPanel1.VerticalScroll.Maximum = 0;
            this.flowLayoutPanel1.VerticalScroll.Enabled = false;
            this.flowLayoutPanel1.HorizontalScroll.Maximum = 0;
            this.flowLayoutPanel1.HorizontalScroll.Enabled = false;
            this.flowLayoutPanel1.AutoScroll = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Send button
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
                return;

            SentMessage sentMessage = new SentMessage();
            sentMessage.Message = richTextBox1.Text;
            sentMessage.TimeAndSender = $"{DateTime.Now.ToString("HH:mm")} - You";
            flowLayoutPanel1.Controls.Add(sentMessage);

            FakeRecievedMessage(richTextBox1.Text);

            richTextBox1.Clear();
        }

        private void FakeRecievedMessage(string customerMessage)
        {
            ReceivedMessage receivedMessage = new ReceivedMessage();

            // Generate some bot messages in buying selling chat
            customerMessage = customerMessage.Trim().ToLower();
            if (customerMessage.Contains("chào") || customerMessage.Contains("hi") || customerMessage.Contains("alo"))
            {
                receivedMessage.Message = "Xin chào, tôi có thể giúp gì cho bạn?";
            }
            else if (customerMessage.Contains("lễ"))
            {
                receivedMessage.Message = "Vào ngày lễ, người giúp việc vẫn làm nhưng bạn cần đặt lịch sớm.";
            }
            else if (customerMessage.Contains("giá") || customerMessage.Contains("bao nhiêu"))
            {
                receivedMessage.Message = "Giá dịch vụ được hiển thị chi tiết trong ứng dung ạ.";
            }
            else if (customerMessage.Contains("thời gian") || customerMessage.Contains("làm việc"))
            {
                receivedMessage.Message = "Thời gian làm việc là 8 tiếng/ngày.";
            }
            else if (customerMessage.Contains("đặt lịch"))
            {
                receivedMessage.Message = "Bạn có thể đặt lịch trong mục dịch vụ ạ.";
            }
            else if (customerMessage.Contains("cảm ơn") || customerMessage.Contains("tạm biệt"))
            {
                receivedMessage.Message = "Cảm ơn bạn, hẹn gặp lại.";
            }
            else
            {
                receivedMessage.Message = "Xin lỗi, tôi không hiểu bạn đang nói gì.";
            }


            receivedMessage.TimeAndSender = $"{DateTime.Now.ToString("HH:mm")} - Linh";
            flowLayoutPanel1.Controls.Add(receivedMessage);
        }
    }
}
