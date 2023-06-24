using MoMo.Model;
using MoMo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoMo
{
    public partial class Pay : Form
    {
        private Panel[] panels;
        private int ChosenBankId = 1;
        public Pay()
        {
            InitializeComponent();

            panels = new Panel[] { panel7, panel6, panel8 };
            foreach (var panel in panels)
                panel.Click += panel_Click_change_color!;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StackNavigation.Pop();
        }

        private void panel_Click_change_color(object sender, EventArgs e)
        {
            var ClickedPanel = (Panel)sender;
            ClickedPanel.BackgroundImage = Image.FromFile(@"../../../Images/pink_round_line.png");
            int ChosenBankId = 1;
            foreach (var panel in panels)
            {
                if (panel != ClickedPanel)
                {
                    panel.BackgroundImage = Image.FromFile(@"../../../Images/round_line.png");
                    ChosenBankId++;
                }
                else
                    this.ChosenBankId = ChosenBankId;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            if (string.IsNullOrEmpty(text))
            {
                pictureBox5.Image = Image.FromFile(@"../../../Images/pay_button_gray.png");
                pictureBox5.Enabled = false;
                return;
            }

            // Set limit for the amount of money
            if (Utils.VNCurrencyToDouble(textBox.Text) > 50_000_000D)
            {
                MessageBox.Show("Số tiền nạp không được vượt quá 50.000.000đ", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            pictureBox5.Image = Image.FromFile(@"../../../Images/pay_button.png");
            pictureBox5.Enabled = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string ChosenBankName = "";
            if (this.ChosenBankId == 1)
                ChosenBankName = label8.Text;
            else if (this.ChosenBankId == 2)
                ChosenBankName = label10.Text;
            else if (this.ChosenBankId == 3)
                ChosenBankName = "Tiền mặt";

            using (UserDbContext db = new())
            {
                // Update the balance of the logged in user
                Session.LoggedInUserInfo!.Balance += Utils.VNCurrencyToDouble(textBox1.Text);
                db.Users.Update(Session.LoggedInUserInfo!);
                db.SaveChanges();
                // Create a transaction
                Transaction transaction = new()
                {
                    Amount = Utils.VNCurrencyToDouble(textBox1.Text),
                    Date = DateTime.Now,
                    ReceiverId = Session.LoggedInUserInfo!.Id,
                    BankId = db.Banks.Where(b => b.Name.Contains(ChosenBankName)).FirstOrDefault()!.Id,
                    Type = Transaction.TransactionType.Bank
                };
                db.Transactions.Add(transaction);
                db.SaveChanges();
            }

            MessageBox.Show("Thanh toán thành công số tiền: " + Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(textBox1.Text)),
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            StackNavigation.Pop();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;  // Prevent the character from being entered
            }
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            // Show the current balance
            label4.Text = Utils.FormatVNCurrency(Session.LoggedInUserInfo!.Balance);

            using (UserDbContext db = new())
            {
                Bank bank1 = db.Banks.Where(b => b.Id == Session.LoggedInUserInfo!.LinkedBankId[0]).FirstOrDefault()!;
                string bankName1 = bank1.Name.Replace("Ngân hàng ", "");

                label8.Text = bankName1;
                pictureBox2.Image = Image.FromFile($@"../../../Images/BankLogo/{bankName1}.png");

                Bank bank2 = db.Banks.Where(b => b.Id == Session.LoggedInUserInfo!.LinkedBankId[1]).FirstOrDefault()!;
                string bankName2 = bank2.Name.Replace("Ngân hàng ", "");

                label10.Text = bankName2;
                pictureBox3.Image = Image.FromFile($@"../../../Images/BankLogo/{bankName2}.png");
            }
        }
    }
}
