﻿using System;
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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            StackNavigation.Push(new AccountModify());
        }
    }
}
