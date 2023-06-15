using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoMo.MyUserControl;

namespace MoMo
{
    public partial class TransferMoney : Form
    {
        private UserControl currentList = null!;

        public TransferMoney()
        {
            InitializeComponent();

            RecommendProfileList recommendProfileList = new RecommendProfileList();
            recommendProfileList.Dock = DockStyle.Fill;

            currentList = recommendProfileList;
            panel1.Controls.Add(recommendProfileList);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                RecommendProfileList recommendProfileList = new RecommendProfileList();
                recommendProfileList.Dock = DockStyle.Fill;

                currentList = recommendProfileList;

                panel1.Controls.Clear();
                panel1.Controls.Add(recommendProfileList);

                return;
            }

            if (currentList != null && currentList.GetType().Name != "SearchResultList")
            {
                SearchResultList searchResultList = new SearchResultList();

                searchResultList.Dock = DockStyle.Fill;
                searchResultList.UpdateResultList(GetRecommendProfiles());

                currentList = searchResultList;

                panel1.Controls.Clear();
                panel1.Controls.Add(searchResultList);
            }
            else if (currentList != null && currentList.GetType().Name == "SearchResultList")
            {
                ((SearchResultList)currentList).UpdateResultList(GetRecommendProfiles());
            }
        }

        private List<User> GetRecommendProfiles()
        {
            List<User> result = Session.UserDbContext!.Users
                .Where(user => user.FullName.Contains(textBox3.Text) || user.PhoneNumber.Contains(textBox3.Text))
                .ToList();

            return result;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StackNavigation.Pop();
        }
    }
}
