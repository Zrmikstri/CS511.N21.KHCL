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
    public partial class PayBill : Form
    {
        private string[] imageList = { @"../../../Images/qc1.jpg",
            @"../../../Images/qc2.jpg", @"../../../Images/qc3.jpg" };
        private int imageIndex = 0;
        public PayBill()
        {
            InitializeComponent();
            panel3.HorizontalScroll.Maximum = 0;
            panel3.AutoScroll = false;
            panel3.HorizontalScroll.Visible = false;
            panel3.AutoScroll = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StackNavigation.Pop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StackNavigation.Push(new PayBillDetail("Electricity"));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StackNavigation.Push(new PayBillDetail("Water"));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StackNavigation.Push(new PayBillDetail("Internet"));
        }
    }
}
