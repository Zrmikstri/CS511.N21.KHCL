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
    public partial class BankingDetail : Form
    {
        public string[] BankFullName = { "Agribank|NH Nông nghiệp và PT NT",
                                            "ACB|NH TMCP Á Châu",
                                            "BIDV|NH TMCP Đầu tư và PT VN",
                                            "DongAbank|NH TMCP Đông Á",
                                            "MBBank|NH TMCP Quân đội",
                                            "OCB|NH TMCP Phương Đông",
                                            "Sacombank|NH TMCP Sài Gòn Thương Tín",
                                            "Techcombank|NH TMCP Kỹ Thương VN",
                                            "TPBank|NH TMCP Tiên Phong",
                                            "VIB|NH TMCP Quốc tế VN",
                                            "Vietcombank|NH TMCP Ngoại thương VN",
                                            "Vietinbank|NH TMCP Công thương VN"};
        public int index = -1;
        public string bankName = "";
        public BankingDetail()
        {
            InitializeComponent();
        }

        public BankingDetail(string bankName)
        {
            InitializeComponent();
            this.bankName = bankName;
            showInfo();
        }

        public void showInfo()
        {
            for (int i = 0; i < BankFullName.Length; i++)
            {
                if (BankFullName[i].StartsWith(bankName))
                {
                    index = i;
                    break;
                }
            }
            pictureBox1.Image = Image.FromFile(@"../../../Images/BankLogo/" + bankName + ".png");
            label1.Text = bankName;
            label2.Text = BankFullName[index].Split('|')[1];
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StackNavigation.Pop();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            if (string.IsNullOrEmpty(text))
            {
                pictureBox5.Image = Image.FromFile(@"../../../Images/chuyentiengray.png");
                pictureBox5.Enabled = false;
                return;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
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

            textBox.TextChanged -= textBox3_TextChanged!;
            textBox.Text = Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(text), isCurrencyHidden: true);
            textBox.TextChanged += textBox3_TextChanged!;

            //Move the caret to the end of the text box
            textBox.SelectionStart = textBox.Text.Length;
            textBox.SelectionLength = 0;


            // Enable the button if the amount of money is greater than 0
            pictureBox5.Image = Image.FromFile(@"../../../Images/chuyentien.png");
            pictureBox5.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0 | textBox3.Text.Length == 0)
            {
                pictureBox5.Image = Image.FromFile(@"../../../Images/chuyentiengray.png");
                pictureBox5.Enabled = false;
            }
            if (textBox2.Text.Length > 0 & textBox3.Text.Length > 0)
            {
                pictureBox5.Image = Image.FromFile(@"../../../Images/chuyentien.png");
                pictureBox5.Enabled = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chuyển khoản thành công số tiền: " + Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(textBox3.Text)),
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
