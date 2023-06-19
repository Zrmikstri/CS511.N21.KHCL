using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoMo.Model;

namespace MoMo
{
    public partial class TransferMoneyDetail : Form
    {
        private User userToBeTransferMoneyTo = null!;
        private int money = 0;

        public TransferMoneyDetail()
        {
            InitializeComponent();
        }

        public TransferMoneyDetail(User user)
        {
            InitializeComponent();
            userToBeTransferMoneyTo = user;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

            textBox.TextChanged -= textBox2_TextChanged!;
            textBox.Text = Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(text), isCurrencyHidden: true);
            textBox.TextChanged += textBox2_TextChanged!;

            //Move the caret to the end of the text box
            textBox.SelectionStart = textBox.Text.Length;
            textBox.SelectionLength = 0;


            // Enable the button if the amount of money is greater than 0
            pictureBox5.Image = Image.FromFile(@"../../../Images/chuyentien.png");
            pictureBox5.Enabled = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Transfer money from current user to userToBeTransferMoneyTo
            using (UserDbContext db = new())
            {
                // Update the balance of the logged in user
                Session.LoggedInUserInfo!.Balance -= Utils.VNCurrencyToDouble(textBox2.Text);
                db.Users.Update(Session.LoggedInUserInfo!);

                // Update the balance of the user to be transfer money to
                userToBeTransferMoneyTo.Balance += Utils.VNCurrencyToDouble(textBox2.Text);
                db.Users.Update(userToBeTransferMoneyTo);

                // Add a new transaction
                Transaction transaction = new()
                {
                    Amount = Utils.VNCurrencyToDouble(textBox2.Text),
                    Type = Transaction.TransactionType.Transfer,
                    Date = DateTime.Now,
                    Message = textBox1.Text,
                    SenderId = Session.LoggedInUserInfo!.Id,
                    ReceiverId = userToBeTransferMoneyTo.Id
                };
                db.Transactions.Add(transaction);

                db.SaveChanges();
            }

            MessageBox.Show(
                "Chuyển khoản thành công số tiền: " + Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(textBox2.Text)),
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            textBox1.Clear();
            textBox2.Clear();

            StackNavigation.Pop();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StackNavigation.Pop();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;  // Prevent the character from being entered
            }
        }

        private void TransferMoneyDetail_Load(object sender, EventArgs e)
        {
            // Set the avatar image, full name and phone number of the user to be transfer money to
            pictureBox1.Image = Utils.BytesArrayToImage(userToBeTransferMoneyTo!.AvatarImage);
            label1.Text = userToBeTransferMoneyTo.FullName;
            label2.Text = userToBeTransferMoneyTo.PhoneNumber;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label5.Text = "Lời nhắn (" + textBox1.Text.Length + "/160)";
        }
    }
}
