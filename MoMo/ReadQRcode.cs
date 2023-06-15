using ZXing;

namespace MoMo
{
    public partial class ReadQRcode : Form
    {
        public ReadQRcode()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap image = new Bitmap(openFileDialog.FileName);

                    var barcodeReader = new ZXing.Windows.Compatibility.BarcodeReader();

                    Result result = barcodeReader.Decode(image);

                    if (result != null)
                    {
                        string[] qrCodeText = result.Text.Split('|');
                        panel5.Visible = false;
                        panel1.Visible = true;
                        label2.Text = qrCodeText[0];
                        label3.Text = qrCodeText[1];
                        textBox1.Text = qrCodeText[2];
                        textBox2.Text = qrCodeText[3];
                        pictureBox1.Image = image;
                    }
                    else
                    {
                        MessageBox.Show("No QR Code found in the image.");
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                pictureBox5.Enabled = false;
                pictureBox5.Image = Image.FromFile(@"../../../Images/chuyentiengray.png");
            }
            else
            {
                pictureBox5.Enabled = true;
                pictureBox5.Image = Image.FromFile(@"../../../Images/chuyentien.png");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chuyển khoản thành công số tiền: " + Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(textBox1.Text)),
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StackNavigation.Pop();
        }
    }
}
