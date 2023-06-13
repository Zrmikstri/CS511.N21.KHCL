using Microsoft.EntityFrameworkCore;
using MoMo.MyUserControl;
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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Load list of user that has message with current user
            List<int> contactsId = Session.UserDbContext!.ChatMessages
                .Where(msg => msg.SenderId == Session.LoggedInUserInfo!.Id || msg.ReceiverId == Session.LoggedInUserInfo!.Id)
                .Select(msg => msg.SenderId == Session.LoggedInUserInfo!.Id ? msg.ReceiverId : msg.SenderId)
                .Distinct()
                .ToList();

            List<User> contacts = Session.UserDbContext.Users
                .Where(user => contactsId.Contains(user.Id))
                .ToList();

            // Load list of latest message with each contact
            foreach (User contact in contacts)
            {
                ChatMessage latestMessage = Session.UserDbContext.ChatMessages
                    .Where(msg => (msg.SenderId == Session.LoggedInUserInfo!.Id && msg.ReceiverId == contact.Id) || (msg.SenderId == contact.Id && msg.ReceiverId == Session.LoggedInUserInfo!.Id))
                    .OrderByDescending(msg => msg.Date)
                    .FirstOrDefault()!;

                ContactItem contactItem = new ContactItem();
                contactItem.ContactName = contact.FullName;
                contactItem.ContactAvatarUrl = Utils.BytesArrayToImage(contact.AvatarImage);
                contactItem.LatestMessage = latestMessage.Message;

                if (latestMessage.Date.Year != DateTime.Now.Year)
                {
                    contactItem.SetLabelPosition("dd/MM/yyyy");
                    contactItem.LatestMessageDate = latestMessage.Date.ToString("dd/MM/yyyy");
                }
                else
                {
                    contactItem.SetLabelPosition("dd/MM");
                    contactItem.LatestMessageDate = latestMessage.Date.ToString("dd/MM");
                }

                contactItem.Click += (sender, e) => ContactItem_Click();

                flowLayoutPanel1.Controls.Add(contactItem);
            }
        }

        private void ContactItem_Click()
        {
            MessageBox.Show("Clicked");
        }
    }
}
