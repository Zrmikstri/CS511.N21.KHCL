using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MoMo.Model;
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
    public partial class AccountModify : Form
    {
        public AccountModify()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StackNavigation.Pop();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            bool isChanged = false;

            // If the user want to change the password
            // Check the password entered is the same with the password in database
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (textBox1.Text == Session.LoggedInUserInfo!.Password
                    && !string.IsNullOrEmpty(textBox2.Text)
                    && !string.IsNullOrEmpty(textBox3.Text))
                {
                    // Check the new password and confirm password is the same
                    if (textBox2.Text == textBox3.Text)
                    {
                        // Update the password in database
                        Session.LoggedInUserInfo!.Password = textBox2.Text;
                        using (UserDbContext db = new())
                        {
                            db.Users.Update(Session.LoggedInUserInfo!);
                            db.SaveChanges();
                        }
                        isChanged = true;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại mật khẩu mới!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại mật khẩu hiện tại!");
                }
            }

            // If the user want to change the email
            if (!string.IsNullOrEmpty(textBox5.Text))
            {
                // Check the email entered is the correct format using regex
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                {
                    // Update the email in database
                    Session.LoggedInUserInfo!.Email = textBox5.Text;
                    using (UserDbContext db = new())
                    {
                        db.Users.Update(Session.LoggedInUserInfo!);
                        db.SaveChanges();
                    }
                    isChanged = true;
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại định dạng email!");
                }
            }

            // If the user want to change the linked bank 
            if (comboBox1.SelectedIndex >= 0)
            {
                // Find the bank id based on the selected bank name
                using (UserDbContext db = new())
                {
                    Bank bank = db.Banks.Where(b => b.Name.Contains(comboBox1.SelectedItem.ToString()!)).FirstOrDefault()!;

                    Session.LoggedInUserInfo!.LinkedBankId = bank.Id;
                    db.Users.Update(Session.LoggedInUserInfo!);
                    db.SaveChanges();
                }
                isChanged = true;
            }

            if (isChanged)
            {
                MessageBox.Show("Cập nhật thành công!");
                StackNavigation.Pop();
            }
        }

        private void AccountModify_Load(object sender, EventArgs e)
        {
            // Set the text of the textbox to the email of the logged in user
            textBox4.Text = Session.LoggedInUserInfo!.Email;

            // Set the current linked bank of the user
            using (UserDbContext db = new())
            {
                Bank bank = db.Banks.Where(b => b.Id == Session.LoggedInUserInfo!.LinkedBankId).FirstOrDefault()!;
                string bankName = bank.Name.Replace("Ngân hàng ", "");

                label23.Text = bankName;

                pictureBox8.Image = Image.FromFile($@"../../../Images/BankLogo/{bankName}.png");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            // Get the selected item in the combobox
            string? bankName = comboBox.SelectedItem.ToString();

            if (string.IsNullOrEmpty(bankName))
                return;

            pictureBox1.Image = Image.FromFile(@"../../../Images/BankLogo/" + bankName + ".png");
        }
    }
}
