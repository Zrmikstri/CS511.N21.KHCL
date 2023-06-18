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
    public partial class HistorySeperator : UserControl
    {
        public HistorySeperator()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Open statistic form about this month

        }
    }
}
