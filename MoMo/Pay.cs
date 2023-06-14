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
    public partial class Pay : Form
    {
        private Home home;
        public Pay()
        {
            InitializeComponent();
        }

        public Pay(object home)
        {
            InitializeComponent();
            this.home = home as Home;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void Pay_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
