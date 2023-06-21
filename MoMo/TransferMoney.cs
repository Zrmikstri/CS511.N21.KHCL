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
using MoMo.MyUserControl;

namespace MoMo
{
    public partial class TransferMoney : Form
    {
        private UserControl currentList = null!;

        public TransferMoney()
        {
            InitializeComponent();

            RecommendProfileList recommendProfileList = new()
            {
                Dock = DockStyle.Fill
            };

            currentList = recommendProfileList;
            panel1.Controls.Add(recommendProfileList);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                RecommendProfileList recommendProfileList = new()
                {
                    Dock = DockStyle.Fill
                };

                currentList = recommendProfileList;

                panel1.Controls.Clear();
                panel1.Controls.Add(recommendProfileList);

                return;
            }

            if (currentList.GetType().Name != "SearchResultList")
            {
                SearchResultList searchResultList = new()
                {
                    Dock = DockStyle.Fill
                };

                searchResultList.UpdateResultList(GetSearchResults());

                currentList = searchResultList;

                panel1.Controls.Clear();
                panel1.Controls.Add(searchResultList);
            }
            else
                ((SearchResultList)currentList).UpdateResultList(GetSearchResults());
        }

        private List<User> GetSearchResults()
        {
            using (UserDbContext dbContext = new())
            {
                List<User> result = dbContext.Users
                    .Where(user => user.Id != Session.LoggedInUserInfo!.Id 
                    && (user.FullName.ToLower().Contains(textBox3.Text.ToLower()) || user.PhoneNumber.Contains(textBox3.Text)))
                    .ToList();

                return result;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StackNavigation.Pop();
        }
    }
}
