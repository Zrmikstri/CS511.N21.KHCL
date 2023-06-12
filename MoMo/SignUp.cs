using Microsoft.VisualBasic.FileIO;
using System.Security.RightsManagement;
using System.ComponentModel;

namespace MoMo
{
    public partial class SignUp : Form
    {
        private bool passwordHidden = true;
        private bool requiredPasswordHidden = true;
        private UserDbContext _userDbContext;

        public SignUp()
        {
            InitializeComponent();
            _userDbContext = Session.UserDbContext!;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                string email = emailTextBox.Text.Trim();
                string citizenId = citizenIdTextBox.Text.Trim();
                string phone = phoneTextBox.Text.Trim();
                string address = addressTextBox.Text.Trim();
                string password = passTextBox.Text.Trim();

                User user = new User
                {
                    Email = email,
                    CitizenId = citizenId,
                    PhoneNumber = phone,
                    Address = address,
                    Password = password
                };

                _userDbContext.Users.Add(user);
                _userDbContext.SaveChanges();

                Session.LoggedInUserInfo = user;

                this.Hide();
                ((Main)this.Owner!).OpenChildForm(new Screen());
            }
        }

        private void iconPictureBox7_Click(object sender, EventArgs e)
        {
            passwordHidden = !passwordHidden;
            if (passwordHidden)
            {
                passTextBox.UseSystemPasswordChar = true;
                iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                passTextBox.UseSystemPasswordChar = false;
                iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void iconPictureBox8_Click(object sender, EventArgs e)
        {
            requiredPasswordHidden = !requiredPasswordHidden;
            if (requiredPasswordHidden)
            {
                requiredPassTextBox.UseSystemPasswordChar = true;
                iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                requiredPassTextBox.UseSystemPasswordChar = false;
                iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ((Main)this.Owner!).OpenChildForm(new Login());
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(emailTextBox.Text.Trim()))
            {
                // Cancel the event and select the text to be corrected by the user
                e.Cancel = true;
                emailTextBox.Select(0, emailTextBox.Text.Length);

                // Set the ErrorProvider error with the text to display
                this.errorProvider1.SetError(emailTextBox, "Thông tin không được để trống!");
            }
            else
            {
                bool isEmailDuplicated = _userDbContext.Users.Any(user => user.Email == emailTextBox.Text.Trim());

                if (isEmailDuplicated)
                {
                    // Cancel the event and select the text to be corrected by the user
                    e.Cancel = true;
                    emailTextBox.Select(0, emailTextBox.Text.Length);

                    // Set the ErrorProvider error with the text to display
                    this.errorProvider1.SetError(emailTextBox, "Email này đã được sử dụng!");
                }
            }
        }

        private void emailTextBox_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors
            errorProvider1.SetError(emailTextBox, "");
        }

        private void citizenIdTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(citizenIdTextBox.Text.Trim()))
            {
                // Cancel the event and select the text to be corrected by the user
                e.Cancel = true;
                citizenIdTextBox.Select(0, citizenIdTextBox.Text.Length);
                // Set the ErrorProvider error with the text to display
                this.errorProvider1.SetError(citizenIdTextBox, "Thông tin không được để trống!");
            }
            else
            {
                bool isCitizenIdDuplicated = _userDbContext.Users.Any(user => user.CitizenId == citizenIdTextBox.Text.Trim());
                if (isCitizenIdDuplicated)
                {
                    // Cancel the event and select the text to be corrected by the user
                    e.Cancel = true;
                    citizenIdTextBox.Select(0, citizenIdTextBox.Text.Length);
                    // Set the ErrorProvider error with the text to display
                    this.errorProvider1.SetError(citizenIdTextBox, "CCCD đã được đăng ký!");
                }
            }
        }

        private void citizenIdTextBox_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors
            errorProvider1.SetError(citizenIdTextBox, "");
        }

        private void phoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(phoneTextBox.Text.Trim()))
            {
                // Cancel the event and select the text to be corrected by the user
                e.Cancel = true;
                phoneTextBox.Select(0, phoneTextBox.Text.Length);
                // Set the ErrorProvider error with the text to display
                this.errorProvider1.SetError(phoneTextBox, "Thông tin không được để trống!");
            }
            else
            {
                bool isPhoneDuplicated = _userDbContext.Users.Any(user => user.PhoneNumber == phoneTextBox.Text.Trim());
                if (isPhoneDuplicated)
                {
                    // Cancel the event and select the text to be corrected by the user
                    e.Cancel = true;
                    phoneTextBox.Select(0, phoneTextBox.Text.Length);
                    // Set the ErrorProvider error with the text to display
                    this.errorProvider1.SetError(phoneTextBox, "Số điện thoại này đã được sử dụng!");
                }
            }
        }

        private void phoneTextBox_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors
            errorProvider1.SetError(phoneTextBox, "");
        }

        private void addressTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(addressTextBox.Text.Trim()))
            {
                // Cancel the event and select the text to be corrected by the user
                e.Cancel = true;
                addressTextBox.Select(0, addressTextBox.Text.Length);
                // Set the ErrorProvider error with the text to display
                this.errorProvider1.SetError(addressTextBox, "Thông tin không được để trống!");
            }
        }

        private void addressTextBox_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors
            errorProvider1.SetError(addressTextBox, "");
        }

        private void passTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(passTextBox.Text.Trim()))
            {
                // Cancel the event and select the text to be corrected by the user
                e.Cancel = true;
                passTextBox.Select(0, passTextBox.Text.Length);
                // Set the ErrorProvider error with the text to display
                this.errorProvider1.SetError(passTextBox, "Thông tin không được để trống!");
            }
        }

        private void passTextBox_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors
            errorProvider1.SetError(passTextBox, "");
        }

        private void requiredPassTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(requiredPassTextBox.Text.Trim()))
            {
                // Cancel the event and select the text to be corrected by the user
                e.Cancel = true;
                requiredPassTextBox.Select(0, requiredPassTextBox.Text.Length);
                // Set the ErrorProvider error with the text to display
                this.errorProvider1.SetError(requiredPassTextBox, "Thông tin không được để trống!");
            }

            if (requiredPassTextBox.Text.Trim() != passTextBox.Text.Trim())
            {
                // Cancel the event and select the text to be corrected by the user
                e.Cancel = true;
                requiredPassTextBox.Select(0, requiredPassTextBox.Text.Length);
                // Set the ErrorProvider error with the text to display
                this.errorProvider1.SetError(requiredPassTextBox, "Mật khẩu không khớp!");
            }
        }

        private void requiredPassTextBox_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors
            errorProvider1.SetError(requiredPassTextBox, "");
        }
    }
}
