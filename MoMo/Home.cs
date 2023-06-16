using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace MoMo
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.HorizontalScroll.Maximum = 0;
            this.VerticalScroll.Maximum = 0;
            this.AutoScroll = false;
            this.VerticalScroll.Visible = false;
            this.HorizontalScroll.Visible = false;
            this.AutoScroll = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // pay click
            StackNavigation.Push(new Pay());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // withdraw click
            StackNavigation.Push(new Withdraw());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //  qr receive click
            StackNavigation.Push(new QRReceive());
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // pay phone money click
            StackNavigation.Push(new PayPhoneMoney());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // qr scan click
            StackNavigation.Push(new ReadQRcode());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            StackNavigation.Push(new TransferMoney());
        }
    }
}
