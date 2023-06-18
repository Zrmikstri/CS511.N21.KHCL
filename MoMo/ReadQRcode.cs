using ZXing;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing.Common;
using ZXing.Windows.Compatibility;

namespace MoMo
{
    public partial class ReadQRcode : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private bool isCameraCapturing = false;
        private bool isCameraStart = false;

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

        private void startCamera()
        {
            // scan qr from camera
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video devices found.");
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += VideoSource_NewFrame;
            videoSource.Start();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel1.Visible = true;
            startCamera();
            isCameraStart = true;
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (isCameraCapturing)
                return;
            // Convert the current frame to a bitmap
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            // Create a barcode reader instance
            BarcodeReader reader = new BarcodeReader();

            // Set the reader's options for QR codes
            reader.Options = new DecodingOptions
            {
                PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.QR_CODE },
                TryHarder = true
            };

            // Read the QR code from the bitmap
            Result result = reader.Decode(bitmap);

            if (result != null)
            {
                // QR code was successfully decoded
                string qrCodeText = result.Text;
                UpdateQRCodeResult(qrCodeText);
                isCameraCapturing = true;
                // Perform any necessary actions with the QR code text
                // For example, display it in a label or textbox
            }

            // Update the PictureBox control with the new frame
            pictureBox1.Image = bitmap;
        }

        private void StopCameraCapture()
        {
            if (isCameraStart)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }
        }

        private void UpdateQRCodeResult(string qrCodeTextInput)
        {
            // This method can be used to update a label or textbox with the QR code text
            // You can modify it according to your specific application's needs
            // For example, if you have a label called lblQRCodeResult, you can update it as follows:
            //label2.Invoke((MethodInvoker)(() => label2.Text = qrCodeText));
            string[] qrCodeText = qrCodeTextInput.Split('|');
            label2.Text = qrCodeText[0];
            label3.Text = qrCodeText[1];
            textBox1.Text = qrCodeText[2];
            textBox2.Text = qrCodeText[3];
        }

        private void ReadQRcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCameraCapture();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            isCameraCapturing = false;
            if (!isCameraStart)
            {
                startCamera();
                isCameraStart = true;
            }
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
