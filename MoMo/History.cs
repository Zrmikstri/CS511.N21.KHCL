using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MoMo.Model;
using MoMo.MyUserControl;

namespace MoMo
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();

            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.VerticalScroll.Maximum = 0;
            flowLayoutPanel1.VerticalScroll.Enabled = false;
            flowLayoutPanel1.HorizontalScroll.Maximum = 0;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.AutoScroll = true;
        }

        private void LoadTransationHistory()
        {
            IEnumerable<IGrouping<string, Transaction>> transactions;
            using (UserDbContext db = new())
            {
                // Retrieve all transaction made and received by current loggedin user 
                // and group them by month and year

                transactions = db.Transactions
                    .Include(t => t.Service)
                    .Include(t => t.Sender)
                    .Include(t => t.Receiver)
                    .Include(t => t.Bank)
                    .Where(t => t.SenderId == Session.LoggedInUserInfo!.Id || t.ReceiverId == Session.LoggedInUserInfo!.Id)
                    .OrderByDescending(t => t.Date)
                    .ToList()
                    .GroupBy(t => t.Date.ToString("MM/yyyy"));
            }

            foreach (var group in transactions)
            {
                HistorySeperator historySeperator = new()
                {
                    Title = group.Key,
                };
                flowLayoutPanel1.Controls.Add(historySeperator);

                foreach (Transaction transaction in group)
                {
                    HistoryItem historyItem = new();

                    historyItem.Description = transaction.GenerateDescription();

                    historyItem.TransactionDate = transaction.Date.ToString("HH:mm dd/MM/yyyy");

                    historyItem.Amount = transaction.SenderId == Session.LoggedInUserInfo!.Id
                        ? "-" + Utils.FormatVNCurrency(transaction.Amount)
                        : "+" + Utils.FormatVNCurrency(transaction.Amount);

                    historyItem.Avatar = transaction.SenderId == Session.LoggedInUserInfo!.Id
                        ? Properties.Resources.send_money
                        : Properties.Resources.receive_money;

                    flowLayoutPanel1.Controls.Add(historyItem);
                }
            }
        }

        private void History_Load(object sender, EventArgs e)
        {
            LoadTransationHistory();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
