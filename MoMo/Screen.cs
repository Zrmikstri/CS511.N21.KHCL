using FontAwesome.Sharp;
using MoMo;

namespace MoMo
{
    public partial class Screen : Form
    {
        private IconButton? currentButton;
        private Form? activeForm;
        public Screen()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            label1.Text = $"Xin Chào {Session.LoggedInUserInfo!.Username}";
            label2.Text = Session.LoggedInUserInfo!.Address;

            Random random = new Random();
            label3.Text = Utils.FormatVNCurrency(random.Next(100, 1000) * 1000);
            label4.Text = random.Next(100, 10000).ToString();

            HighlightButton(iconButton1);
            //OpenTab(new HomeTab());
        }

        private void HighlightButton(object senderButton)
        {
            if (senderButton != null)
            {
                DisableHighlightButton();
                currentButton = (IconButton)senderButton;
                currentButton.BackColor = Color.FromArgb(255, 111, 97);
                currentButton.ForeColor = Color.White;
                currentButton.IconColor = Color.White;
                currentButton.Font = new Font("Times New Roman", 9.5f, FontStyle.Bold);
            }
        }

        private void DisableHighlightButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(243, 233, 237);
                currentButton.ForeColor = Color.Black;
                currentButton.IconColor = Color.Black;
                currentButton.Font = new Font("Times New Roman", 9, FontStyle.Regular);
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
            //OpenTab(new HomeTab());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            HighlightButton(sender);
            //OpenTab(new ServiceTab());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            HighlightButton(sender);
            //OpenTab(new CartTab());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            HighlightButton(sender);
            OpenTab(new ChatTab());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            HighlightButton(sender);
            //OpenTab(new AccountTab());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Sigout link
            Utils.SaveUserInfo();

            Session.LoggedInUserInfo = null;
            Session.UserDbContext?.Dispose();
            Session.UserDbContext = null;

            this.Hide();
            ((Main)this.Owner!).Onload(e);

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            label1.Text = $"Xin Chào {Session.LoggedInUserInfo!.Username}";
            label2.Text = Session.LoggedInUserInfo!.Address;
        }
    }
}
