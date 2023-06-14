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
    public partial class SearchResultList : UserControl
    {
        public SearchResultList()
        {
            InitializeComponent();
        }

        public void UpdateResultList(List<User> result)
        {
            if (result == null)
                return;

            flowLayoutPanel1.Controls.Clear();

            foreach (User user in result)
            {
                ContactItem item = new ContactItem();
                item.User = user;
                item.ContactAvatar = Utils.BytesArrayToImage(user.AvatarImage);
                item.ContactName = user.FullName;
                item.LatestMessage = user.PhoneNumber;
                item.SetDateLabelVisible(false);

                flowLayoutPanel1.Controls.Add(item);
            }
        }
    }
}
