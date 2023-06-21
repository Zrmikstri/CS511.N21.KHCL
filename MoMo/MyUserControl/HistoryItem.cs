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
    public partial class HistoryItem : UserControl
    {
        public HistoryItem()
        {
            InitializeComponent();
        }

        public string Description
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string TransactionDate
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        public string Amount
        {
            get { return label4.Text; }
            set 
            {
                label4.Text = value;
                // Align label4 horizontally center in panel1
                label4.Location = new Point((panel1.Width - label4.Width), label4.Location.Y);
            }
        }

        public Image Avatar
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
    }
}
