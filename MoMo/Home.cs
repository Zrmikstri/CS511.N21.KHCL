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
    public partial class Home : Form
    {
        public event EventHandler PayClicked;
        public event EventHandler WithdrawClicked;
        public event EventHandler QRReceiveClicked;
        public event EventHandler QRScanClicked;
        public event EventHandler PayPhoneMoneyClicked;
        public event EventHandler TransferMoneyCliked;

        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // pay click
            PayClicked?.Invoke(this, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // withdraw click
            WithdrawClicked?.Invoke(this, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //  qr receive click
            QRReceiveClicked?.Invoke(this, e);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // pay phone money click

            PayPhoneMoneyClicked?.Invoke(this, e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // qr scan click
            QRScanClicked?.Invoke(this, e);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TransferMoneyCliked?.Invoke(this, e);
        }
    }
}
