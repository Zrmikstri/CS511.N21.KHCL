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
            timer1.Start();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StackNavigation.Pop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imageIndex == 3)
                imageIndex = 0;
            pictureBox16.Image = Image.FromFile(imageList[imageIndex]);
            imageIndex++;
        }
    }
}
