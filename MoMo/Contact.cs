using Microsoft.EntityFrameworkCore;
using MoMo.Model;
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

        private void Contact_Load(object sender, EventArgs e)
        {
            LoadChattedProfiles();
        }

        private void LoadChattedProfiles()
        {
            // Load list of user
            using (UserDbContext dbContext = new())
            {
                // Load list of user that has message with current user
                List<int> contactsId = dbContext.ChatMessages
                    .Where(msg => msg.SenderId == Session.LoggedInUserInfo!.Id || msg.ReceiverId == Session.LoggedInUserInfo!.Id)
                    .Select(msg => msg.SenderId == Session.LoggedInUserInfo!.Id ? msg.ReceiverId : msg.SenderId)
                    .Distinct()
                    .ToList();

                List<User> contacts = dbContext.Users
                    .Where(user => contactsId.Contains(user.Id))
                    .ToList();


                // Load list of latest message with each contact
                foreach (User contact in contacts)
                {
                    ChatMessage latestMessage = dbContext.ChatMessages
                        .Where(msg =>
                            (msg.SenderId == Session.LoggedInUserInfo!.Id && msg.ReceiverId == contact.Id)
                            || (msg.SenderId == contact.Id && msg.ReceiverId == Session.LoggedInUserInfo!.Id))
                        .OrderByDescending(msg => msg.Date)
                        .FirstOrDefault()!;

                    ContactItem contactItem = new()
                    {
                        User = contact,
                        ContactName = contact.FullName,
                        ContactAvatar = Utils.BytesArrayToImage(contact.AvatarImage),
                        LatestMessage = latestMessage.Image is not null?
                             "[Ảnh]"
                            : latestMessage.Message,
                    };

                    if (latestMessage.Date.Year != DateTime.Now.Year)
                    {
                        contactItem.SetDateLabelPosition("dd/MM/yyyy");
                        contactItem.LatestMessageDate = latestMessage.Date.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        contactItem.SetDateLabelPosition("dd/MM");
                        contactItem.LatestMessageDate = latestMessage.Date.ToString("dd/MM");
                    }

                    if (latestMessage.Image != null)
                    {
                        contactItem.LatestMessage = "[Ảnh]";
                    }

                    contactItem.Click += (sender, e) => ContactItem_Click(contactItem, e);

                    flowLayoutPanel1.Controls.Add(contactItem);
                }
            }
        }

        private void ContactItem_Click(object sender, EventArgs e)
        {
            User receiver = (sender as ContactItem)!.User;

            ChatTab message_sender = new(Session.LoggedInUserInfo!.Id, receiver.Id)
            {
                Text = Session.LoggedInUserInfo.FullName
            };

            StackNavigation.Push(message_sender);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            RichTextBox richTextBox = (RichTextBox)sender;

            if (richTextBox.Text == "")
            {
                flowLayoutPanel1.Controls.Clear();
                LoadChattedProfiles();
                return;
            }
            else
            {
                // Search database for user that has name or has phone number like the text in textbox
                using(UserDbContext db = new())
                {
                    List<User> users = db.Users
                        .Where(user => user.Id != Session.LoggedInUserInfo!.Id)
                        .ToList()
                        .Where(user => 
                            user.FullName.Contains(richTextBox.Text, StringComparison.InvariantCultureIgnoreCase) || user.PhoneNumber.Contains(richTextBox.Text))
                        .ToList();

                    flowLayoutPanel1.Controls.Clear();

                    foreach (User user in users)
                    {
                        ContactItem contactItem = new()
                        {
                            User = user,
                            ContactName = user.FullName,
                            ContactAvatar = Utils.BytesArrayToImage(user.AvatarImage),
                            LatestMessage = user.PhoneNumber
                        };

                        contactItem.SetDateLabelVisible(false);
                        contactItem.Click += (sender, e) => ContactItem_Click(contactItem, e);
                        flowLayoutPanel1.Controls.Add(contactItem);
                    }
                }
            }
        }
    }
}
