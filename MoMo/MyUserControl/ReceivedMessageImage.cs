using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoMo.MyUserControl
{
    public partial class ReceivedMessageImage : UserControl
    {
        private Image originalImage = null!;
        public ReceivedMessageImage()
        {
            InitializeComponent();
        }

        public string TimeAndSender
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        public Image ReceivedImage
        {
            get
            {
                return originalImage;
            }
            set
            {
                originalImage = value;

                // Check if the image is smaller than the PictureBox's maximum size
                if (value.Width <= pictureBox1.MaximumSize.Width)
                {
                    pictureBox1.Image = value;
                }
                else
                {
                    int desiredWidth = 320; // Set your desired width here

                    int desiredHeight = (int)(((float)desiredWidth / value.Width) * value.Height);

                    Image resizedImage = value.GetThumbnailImage(desiredWidth, desiredHeight, null, IntPtr.Zero);

                    pictureBox1.Image = resizedImage;
                }

            }
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                    if (control is TableLayoutPanel tableLayoutPanel)
                        foreach (Control tableControl in tableLayoutPanel.Controls)
                            tableControl.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                    if (control is TableLayoutPanel tableLayoutPanel)
                        foreach (Control tableControl in tableLayoutPanel.Controls)
                            tableControl.Click -= value;
                }
            }
        }

        private void ReceivedMessageImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.FileName = "download.png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage.Save(saveFileDialog.FileName);
                MessageBox.Show("Tải ảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
