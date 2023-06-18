using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace MoMo
{
    public partial class QRReceive : Form
    {
        public QRReceive()
        {
            InitializeComponent();
            createDefaultQRCode();
        }

        public void createQRCode(string data)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            System.Drawing.Bitmap qrCodeImage = qrCode.GetGraphic(10);

            pictureBox1.Image = qrCodeImage;
        }

        public void createDefaultQRCode()
        {
            string data = label2.Text + "|" + label3.Text + "||";
            createQRCode(data);
        }

        public void createCustomQRcode()
        {
            string data = label2.Text + "|" + label3.Text + "|" + textBox1.Text + "|" + textBox2.Text;
            createQRCode(data);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            createCustomQRcode();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(sfd.FileName);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StackNavigation.Pop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            if (string.IsNullOrEmpty(text))
            {
                pictureBox2.Image = Image.FromFile(@"../../../Images/reset_gray.png");
                pictureBox2.Enabled = false;
                return;
            }

            // Set limit for the amount of money
            if (Utils.VNCurrencyToDouble(textBox.Text) > 50_000_000D)
            {
                MessageBox.Show("Số tiền nhận không được vượt quá 50.000.000đ", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Text = Utils.FormatVNCurrency(50_000_000D, isCurrencyHidden: true);
                return;
            }

            textBox.TextChanged -= textBox1_TextChanged!;
            textBox.Text = Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(text), isCurrencyHidden: true);
            textBox.TextChanged += textBox1_TextChanged!;

            //Move the caret to the end of the text box
            textBox.SelectionStart = textBox.Text.Length;
            textBox.SelectionLength = 0;


            // Enable the button if the amount of money is greater than 0
            pictureBox2.Image = Image.FromFile(@"../../../Images/reset.png");
            pictureBox2.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;  // Prevent the character from being entered
            }
        }
    }
}
