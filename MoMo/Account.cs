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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            StackNavigation.Push(new AccountModify());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Select the image to change the avatar
            OpenFileDialog open = new();
            open.Filter = "Image files(*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png"; ;
            open.Multiselect = false;
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            open.Title = "Chọn ảnh đại diện";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox5.Image = Image.FromFile(open.FileName);
                Session.LoggedInUserInfo!.AvatarImage = Utils.ImageToBytesArray(pictureBox5.Image);

                using (UserDbContext db = new())
                {
                    db.Users.Update(Session.LoggedInUserInfo!);
                    db.SaveChanges();
                }
            }
        }

        private void Account_Load(object sender, EventArgs e)
        {
            // Avatar Image
            pictureBox5.Image = Utils.BytesArrayToImage(Session.LoggedInUserInfo!.AvatarImage);

            // Full name
            label11.Text = Session.LoggedInUserInfo!.FullName;

            // Phone number
            label13.Text = Session.LoggedInUserInfo!.PhoneNumber;

            // Birthday
            label4.Text = Session.LoggedInUserInfo!.Birthday.ToString("dd/MM/yyyy");

            // Gender
            if (Session.LoggedInUserInfo!.Gender == 0)
                label5.Text = "Nam";
            else
                label5.Text = "Nữ";

            // Citizen ID
            label7.Text = Session.LoggedInUserInfo!.CitizenId;

            // Email
            label9.Text = Session.LoggedInUserInfo!.Email;

            // Balance
            label25.Text = Utils.FormatVNCurrency(Session.LoggedInUserInfo!.Balance);

            // Linked bank name
            using (UserDbContext db = new())
            {
                if (Session.LoggedInUserInfo!.LinkedBankId[0] == 14)
                {
                    label23.Text = "Chưa liên kết ngân hàng";
                }
                else
                {
                    Bank bank1 = db.Banks.Where(b => b.Id == Session.LoggedInUserInfo!.LinkedBankId[0]).FirstOrDefault()!;
                    string bankName1 = bank1.Name.Replace("Ngân hàng ", "");

                    label23.Text = bankName1;
                    pictureBox8.Image = Image.FromFile($@"../../../Images/BankLogo/{bankName1}.png");
                }

                if (Session.LoggedInUserInfo!.LinkedBankId[1] == 14)
                {
                    label17.Text = "Chưa liên kết ngân hàng";
                }
                else
                {
                    Bank bank2 = db.Banks.Where(b => b.Id == Session.LoggedInUserInfo!.LinkedBankId[1]).FirstOrDefault()!;
                    string bankName2 = bank2.Name.Replace("Ngân hàng ", "");

                    label17.Text = bankName2;
                    pictureBox7.Image = Image.FromFile($@"../../../Images/BankLogo/{bankName2}.png");
                }
            }
        }
    }
}
