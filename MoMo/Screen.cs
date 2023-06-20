using FontAwesome.Sharp;
using MoMo;

namespace MoMo
{
    public partial class Screen : Form
    {
        private IconButton? currentButton;
        private Form? activeForm;
        private Main? mainForm;
        private bool isLogOutPressed = false;

        public Screen()
        {
            InitializeComponent();
        }

        public Screen(object e)
        {
            InitializeComponent();
            this.mainForm = (Main)e;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            HighlightButton(iconButton1);
            OpenTab(new Home());
        }

        private void HighlightButton(object senderButton)
        {
            if (senderButton != null)
            {
                DisableHighlightButton();
                currentButton = (IconButton)senderButton;
                currentButton.BackColor = Color.FromArgb(255, 111, 97);
                currentButton.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                currentButton.ForeColor = Color.White;
                currentButton.IconColor = Color.White;
            }
        }

        private void DisableHighlightButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(243, 233, 237);
                currentButton.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
                currentButton.ForeColor = Color.Black;
                currentButton.IconColor = Color.Black;
            }
        }

        private void OpenTab(Form form)
        {
            if (activeForm != null && activeForm.GetType().Name == form.GetType().Name)
                // The new form is of the same partial class as the currently active form, do nothing
                return;

            if (activeForm != null)
                activeForm.Close();

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel2.Controls.Add(form);
            panel2.Tag = form;

            form.BringToFront();
            form.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            HighlightButton(sender);
            pictureBox1.Visible = true;
            OpenTab(new Home());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            HighlightButton(sender);
            pictureBox1.Visible = false;
            OpenTab(new History());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            HighlightButton(sender);
            pictureBox1.Visible = false;
            OpenTab(new Contact());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            HighlightButton(sender);
            pictureBox1.Visible = false;
            OpenTab(new Account());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogOutPressed)
            {
                Utils.SaveUserInfo();

                Session.LoggedInUserInfo = null;

                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Sigout link
            Utils.SaveUserInfo();

            Session.LoggedInUserInfo = null;

            mainForm!.Onload(e);
            isLogOutPressed = true;
            StackNavigation.Pop();
        }
    }
}
