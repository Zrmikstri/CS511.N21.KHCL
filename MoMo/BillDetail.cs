using Microsoft.EntityFrameworkCore;
using MoMo.Model;
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
    public partial class BillDetail : Form
    {
        private Transaction transaction = null!;
        public BillDetail()
        {
            InitializeComponent();
        }

        public BillDetail(Transaction transaction)
        {
            InitializeComponent();

            // Retrieve all information about the transaction
            using (UserDbContext dbContext = new())
            {
                this.transaction = dbContext.Transactions
                    .Include(t => t.Sender)
                    .Include(t => t.Receiver)
                    .Include(t => t.Bank)
                    .Include(t => t.Service)
                    .Where(t => t.Id == transaction.Id)
                    .FirstOrDefault()!;
            }
        }

        private void BillDetail_Load(object sender, EventArgs e)
        {
            LoadBillDetail();
        }

        private void LoadBillDetail()
        {
            // Bill description
            label2.Text = transaction.GenerateDescription();

            // Bill amount
            label3.Text = transaction.GetAmount();

            // Transaction status
            label8.Text = transaction.Status == 0 ? "Thất bại" : "Thành công";

            // Transaction date
            label9.Text = transaction.Date.ToString(" HH:mm - dd/MM/yyyy");

            // Transaction id
            label10.Text = transaction.Id.ToString();

            if (transaction.Type == Transaction.TransactionType.Transfer)
            {
                if (transaction.SenderId == Session.LoggedInUserInfo!.Id)
                {
                    // Bill logo
                    pictureBox1.Image = Image.FromFile(@"..\..\..\Images\BillLogo\SendMoney.jpg");

                    // Name of the receiver's wallet 
                    label15.Text = "Tên ví MoMo";
                    label13.Text = transaction.Sender!.FullName;
           
                    // Receiver's phone number
                    label14.Text = "Số điện thoại";
                    label12.Text = transaction.Receiver!.PhoneNumber;
                }
                else
                {
                    // Bill logo
                    pictureBox1.Image = Image.FromFile(@"..\..\..\Images\BillLogo\ReceivedMoney.jpg");

                    // Name of the receiver's wallet 
                    label15.Text = "Tên ví MoMo";
                    label13.Text = transaction.Receiver!.FullName;

                    // Receiver's phone number
                    label14.Text = "Số điện thoại";
                    label12.Text = transaction.Sender!.PhoneNumber;
                }    
            }
            else if (transaction.Type == Transaction.TransactionType.Service)
            {
                pictureBox1.Image = Image.FromFile(@"..\..\..\Images\BillLogo\Recharge.jpg");

                panel3.Visible = false;
            }
            else if(transaction.Type == Transaction.TransactionType.Bank)
            {
                if(!string.IsNullOrEmpty(transaction.Description))
                {
                    // Bill logo
                    pictureBox1.Image = Image.FromFile(@"..\..\..\Images\BillLogo\SendThroughBank.jpg");
                }    
                else if (transaction.SenderId == Session.LoggedInUserInfo!.Id)
                {
                    // Bill logo
                    pictureBox1.Image = Image.FromFile(@"..\..\..\Images\BillLogo\SendMoney.jpg");

                    // Name of the receiver's wallet 
                    label15.Text = "Tên ngân hàng";
                    label13.Text = transaction.Bank!.Name;

                    label14.Visible = false;
                    label12.Visible = false;
                }
                else
                {
                    // Bill logo
                    pictureBox1.Image = Image.FromFile(@"..\..\..\Images\BillLogo\ReceivedMoney.jpg");

                    // Name of the receiver's wallet 
                    label15.Text = "Tên ngân hàng";
                    label13.Text = transaction.Bank!.Name;

                    label14.Visible = false;
                    label12.Visible = false;
                }
            }    
        }
    }
}
