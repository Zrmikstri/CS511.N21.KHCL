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
        private Screen screen;
        public QRReceive()
        {
            InitializeComponent();
            createDefaultQRCode();
        }

        public QRReceive(object e)
        {
            InitializeComponent();
            createDefaultQRCode();
            this.screen = (Screen)e;

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
            screen.Show();
            this.Close();
        }
    }
}
