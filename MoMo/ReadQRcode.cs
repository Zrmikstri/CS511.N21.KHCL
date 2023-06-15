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
                        MessageBox.Show("Mã QR không hợp lệ. Vui lòng thử lại", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            if (string.IsNullOrEmpty(text))
            {
                pictureBox5.Image = Image.FromFile(@"../../../Images/chuyentiengray.png");
                pictureBox5.Enabled = false;
                return;
            }

            // Set limit for the amount of money
            if (Utils.VNCurrencyToDouble(textBox.Text) > 50_000_000D)
            {
                MessageBox.Show("Số tiền chuyển không được vượt quá 50.000.000đ", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            pictureBox5.Image = Image.FromFile(@"../../../Images/chuyentien.png");
            pictureBox5.Enabled = true;
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
