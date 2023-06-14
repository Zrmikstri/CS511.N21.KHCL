using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoMo.MyUserControl;

namespace MoMo
{
    public partial class TransferMoney : Form
    {
        private UserControl currentList = null!;
        public TransferMoney()
        {
            InitializeComponent();

            currentList = new RecommendProfileList();
            currentList.Dock = DockStyle.Fill;
            panel1.Controls.Add(currentList);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //if (currentList != null && currentList.GetType().Name == ) { }
        }
    }
}
