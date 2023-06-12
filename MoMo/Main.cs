using Microsoft.EntityFrameworkCore;
using MoMo;
using System.ComponentModel;

namespace MoMo
{
    public partial class Main : Form
    {
        public Form? activeForm;
        public UserDbContext? userDbContext;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Properties.Settings.Default.isRememberUsername == false)
            {
                Properties.Settings.Default.SavedUsername = "";
            }
            Properties.Settings.Default.Save();
        }


        public void OpenChildForm(Form form)
        {
            // The new form is of the same partial class as the currently active form, do nothing
            if (activeForm != null && activeForm.GetType().Name == form.GetType().Name)
                return;

            if (activeForm != null)
                activeForm.Close();

            form.Owner = this;
            activeForm = form;

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            panel1.Controls.Add(form);
            form.Show();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.userDbContext = new UserDbContext();

            // Uncomment the line below to start fresh with a new database.
            this.userDbContext.Database.EnsureDeleted();
            this.userDbContext.Database.EnsureCreated();
            this.userDbContext.Users.Load();

            Session.UserDbContext = this.userDbContext;

            OpenChildForm(new Login());
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            Utils.SaveUserInfo();

            this.userDbContext?.Dispose();
            this.userDbContext = null;
        }

        public void Onload(EventArgs e)
        {
            this.OnLoad(e);
        }
    }
}
