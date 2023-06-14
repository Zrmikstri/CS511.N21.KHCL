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
    public partial class TransferMoneyDetail : Form
    {
        public TransferMoneyDetail()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            //string text = textBox.Text;
            //textBox.Text = Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(text));
            if (textBox.Text.Length == 0)
            {
                pictureBox5.Image = Image.FromFile(@"../../../Images/chuyentiengray.png");
                pictureBox5.Enabled = false;
            }
            else
            {
                pictureBox5.Image = Image.FromFile(@"../../../Images/chuyentien.png");
                pictureBox5.Enabled = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chuyển khoản thành công số tiền: " + Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(textBox2.Text)),
            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
