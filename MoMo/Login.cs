using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.FileIO;
using System.ComponentModel;


namespace MoMo
{
    public partial class Login : Form
    {
        public bool isLoginSucces = false;
        private bool passwordHidden = true;
        private UserDbContext? _userDbContext;

        public Login()
        {
            InitializeComponent();

            this._userDbContext = new UserDbContext();

            if (Properties.Settings.Default.isRememberUsername)
            {
                checkBox1.Checked = Properties.Settings.Default.isRememberUsername;
                txtUsername.Text = Properties.Settings.Default.SavedUsername;
            }
        }

        private User checkCredentials(string username, string password)
        {
            return _userDbContext!.Users
                        .SingleOrDefault(user => (username == user.PhoneNumber) && (password == user.Password));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check for empty username or password
            if (!this.ValidateChildren())
                return;


            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool rememberMe = checkBox1.Checked;

            User user = checkCredentials(username, password);


            if (user == null)
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!\nVui lòng nhập lại.",
                   "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Session.LoggedInUserInfo = user;

            // If remember me is checked, save username the username
            if (rememberMe)
            {
                Properties.Settings.Default.SavedUsername = username;
                Properties.Settings.Default.isRememberUsername = true;
            }
            else
            {
                Properties.Settings.Default.SavedUsername = "";
                Properties.Settings.Default.isRememberUsername = false;
            }


            // If username and password are correct, close the login form and open home form
            Screen screen = new Screen((Main)this.Owner!);
            StackNavigation.Push(screen);
            //((Main)this.Owner!).OpenChildForm(new Screen());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isRememberUsername = checkBox1.Checked;
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            passwordHidden = !passwordHidden;
            if (passwordHidden)
            {
                this.txtPassword.UseSystemPasswordChar = true;
                iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = false;
                iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        // Close login form and open sign up form in the same panel
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ((Main)this.Owner!).OpenChildForm(new SignUp());
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                // Cancel the event and select the text to be corrected by the user
                e.Cancel = true;
                txtUsername.Select(0, txtUsername.Text.Length);

                // Set the ErrorProvider error with the text to display
                this.errorProvider1.SetError(txtUsername, "Thông tin không được để trống!");
            }
        }

        private void txtUsername_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors
            errorProvider1.SetError(txtUsername, "");
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                // Cancel the event and select the text to be corrected by the user
                e.Cancel = true;
                txtPassword.Select(0, txtPassword.Text.Length);

                // Set the ErrorProvider error with the text to display
                this.errorProvider1.SetError(txtPassword, "Thông tin không được để trống!");
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors
            errorProvider1.SetError(txtPassword, "");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

