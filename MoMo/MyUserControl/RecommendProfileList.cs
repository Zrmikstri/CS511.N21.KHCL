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
using static System.Windows.Forms.ListView;

namespace MoMo.MyUserControl
{
    public partial class RecommendProfileList : UserControl
    {
        public RecommendProfileList()
        {
            InitializeComponent();
        }

        // Implement recommend list with user avatar and name using list view
        private void RecommendProfileList_Load(object sender, EventArgs e)
        {
            // Load list of user that has message with current user
            List<User> recommendList;
            using (UserDbContext dbContext = new())
            {
                List<int> recommendIdList = dbContext.ChatMessages
                    .Where(msg => msg.SenderId == Session.LoggedInUserInfo!.Id || msg.ReceiverId == Session.LoggedInUserInfo!.Id)
                    .Select(msg => msg.SenderId == Session.LoggedInUserInfo!.Id ? msg.ReceiverId : msg.SenderId)
                    .Distinct()
                    .ToList();

                recommendList = dbContext.Users
                    .Where(user => recommendIdList.Contains(user.Id))
                    .ToList();
            }

            ImageList imageList = new()
            {
                ImageSize = new Size(50, 50),
                ColorDepth = ColorDepth.Depth32Bit
            };

            foreach (User user in recommendList)
            {
                Image image = Utils.BytesArrayToImage(user.AvatarImage);
                imageList.Images.Add("image" + user.Id, image);
            }
            listView1.LargeImageList = imageList;

            foreach (User user in recommendList)
            {
                ListViewItem item = new()
                {
                    ImageKey = "image" + user.Id,
                    Text = user.FullName,
                    Tag = user
                };
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            // Open Transfer money details
            User selectedUser = (User)listView1.SelectedItems[0].Tag;
            TransferMoneyDetail transferMoneyDetails = new (selectedUser);

            StackNavigation.Push(transferMoneyDetails);
        }
    }
}
