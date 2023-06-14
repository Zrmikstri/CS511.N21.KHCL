using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //// Load list of user that has message with current user
            //List<int> recommendIdList = Session.UserDbContext!.ChatMessages
            //    .Where(msg => msg.SenderId == Session.LoggedInUserInfo!.Id || msg.ReceiverId == Session.LoggedInUserInfo!.Id)
            //    .Select(msg => msg.SenderId == Session.LoggedInUserInfo!.Id ? msg.ReceiverId : msg.SenderId)
            //    .Distinct()
            //    .ToList();

            //List<User> recommendList = Session.UserDbContext.Users
            //    .Where(user => recommendIdList.Contains(user.Id))
            //    .ToList();

            //ImageList imageList = new ImageList();
            //imageList.ImageSize = new Size(250, 250);
            //imageList.ColorDepth = ColorDepth.Depth32Bit;

            //foreach (User user in recommendList)
            //{
            //    Image image = Utils.BytesArrayToImage(user.AvatarImage);
            //    imageList.Images.Add("image" + user.Id, image);

            //    ListViewItem item = new ListViewItem();
            //    item.ImageKey = "image" + user.Id;
            //    item.Text = user.FullName;
            //    listView1.Items.Add(item);
            //}

            //listView1.LargeImageList = imageList;

            using (var db = new UserDbContext())
            {
                //List<int> recommendIdList = db.ChatMessages
                //    .Where(msg => msg.SenderId == 1 || msg.ReceiverId == 1)
                //    .Select(msg => msg.SenderId == 1 ? msg.ReceiverId : msg.SenderId)
                //    .Distinct()
                //    .ToList();

                //List<User> recommendList = db.Users
                //    .Where(user => recommendIdList.Contains(user.Id))
                //    .ToList();

                List<User> recommendList = db.Users.ToList();

                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(50, 50);
                imageList.ColorDepth = ColorDepth.Depth32Bit;

                foreach (User user in recommendList)
                {
                    Image image = Utils.BytesArrayToImage(user.AvatarImage);
                    imageList.Images.Add("image" + user.Id, image);
                }
                listView1.LargeImageList = imageList;

                foreach (User user in recommendList)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageKey = "image" + user.Id;
                    item.Text = user.FullName;
                    listView1.Items.Add(item);
                }
            }
        }
    }
}
