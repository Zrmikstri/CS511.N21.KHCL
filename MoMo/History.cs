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


            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.HorizontalScroll.Enabled = false;
            panel1.AutoScroll = true;
        }

        private void LoadTransationHistory()
        {
            flowLayoutPanel1.Controls.Clear();
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
                    HistoryItem historyItem = new(transaction);

                    flowLayoutPanel1.Controls.Add(historyItem);
                }
            }
        }

        private void LoadSenderTransationHistory()
        {
            flowLayoutPanel1.Controls.Clear();
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
                    .Where(t => t.SenderId == Session.LoggedInUserInfo!.Id)
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
                    HistoryItem historyItem = new(transaction);

                    flowLayoutPanel1.Controls.Add(historyItem);
                }
            }
        }

        private void LoadReceiverTransationHistory()
        {
            flowLayoutPanel1.Controls.Clear();
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
                    .Where(t => t.ReceiverId == Session.LoggedInUserInfo!.Id)
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
                    HistoryItem historyItem = new(transaction);

                    flowLayoutPanel1.Controls.Add(historyItem);
                }
            }
        }

        private void LoadPayPhoneMoneyTransationHistory()
        {
            flowLayoutPanel1.Controls.Clear();
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
                    .Where(t => t.SenderId == Session.LoggedInUserInfo!.Id && t.ServiceId == 1)
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
                    HistoryItem historyItem = new(transaction);

                    flowLayoutPanel1.Controls.Add(historyItem);
                }
            }
        }


        private void LoadPayBillTransationHistory()
        {
            flowLayoutPanel1.Controls.Clear();
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
                    .Where(t => t.SenderId == Session.LoggedInUserInfo!.Id && t.ServiceId != 1 &&
                    t.Type == Transaction.TransactionType.Service)
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
                    HistoryItem historyItem = new(transaction);

                    flowLayoutPanel1.Controls.Add(historyItem);
                }
            }
        }

        private void LoadBankingTransationHistory()
        {
            flowLayoutPanel1.Controls.Clear();
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
                    .Where(t => (t.SenderId == Session.LoggedInUserInfo!.Id || t.ReceiverId == Session.LoggedInUserInfo!.Id) &&
                    t.Type == Transaction.TransactionType.Bank)
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
                    HistoryItem historyItem = new(transaction);

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void radioButton_Click(object sender, EventArgs e)
        {
            string name = String.Empty;
            foreach (RadioButton radioButton in panel1.Controls.OfType<RadioButton>())
            {
                if (radioButton == sender)
                {
                    radioButton.ForeColor = Color.FromArgb(219, 45, 139);
                    radioButton.FlatAppearance.BorderColor = Color.FromArgb(219, 45, 139);
                    name = radioButton.Name;
                }
                else
                {
                    radioButton.ForeColor = Color.Black;
                    radioButton.FlatAppearance.BorderColor = Color.Black;
                }
            }
            if (name == "radioButton1")
            {
                LoadTransationHistory();
            }
            else if (name == "radioButton2")
            {
                LoadSenderTransationHistory();
            }
            else if (name == "radioButton3")
            {
                LoadReceiverTransationHistory();
            }
            else if (name == "radioButton4")
            {
                LoadPayPhoneMoneyTransationHistory();
            }
            else if (name == "radioButton5")
            {
                LoadPayBillTransationHistory();
            }
            else if (name == "radioButton6")
            {
                LoadBankingTransationHistory();
            }
        }


    }
}
