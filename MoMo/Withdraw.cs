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
    public partial class Withdraw : Form
    {
        private Panel[] panels;
        private Screen screen;
        public Withdraw()
        {
            InitializeComponent();
            panels = new Panel[] { panel6, panel7, panel8 };
            foreach (var panel in panels)
            {
                panel.Click += panel_Click_change_color;
            }
        }

        public Withdraw(object e)
        {
            InitializeComponent();
            panels = new Panel[] { panel6, panel7, panel8 };
            foreach (var panel in panels)
            {
                panel.Click += panel_Click_change_color;
            }
            this.screen = (Screen)e;
        }

        private void panel_Click_change_color(object? sender, EventArgs e)
        {
            var ClickedPanel = (Panel)sender;
            ClickedPanel.BackgroundImage = Image.FromFile(@"../../../Images/pink_round_line.png");

            foreach (var panel in panels)
            {
                if (panel != ClickedPanel)
                {
                    panel.BackgroundImage = Image.FromFile(@"../../../Images/round_line.png");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            //string text = textBox.Text;
            //textBox.Text = Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(text));
            if (textBox.Text.Length == 0)
            {
                pictureBox5.Image = Image.FromFile(@"../../../Images/withdraw_button_gray.png");
                pictureBox5.Enabled = false;
            }
            else
            {
                pictureBox5.Image = Image.FromFile(@"../../../Images/withdraw_button.png");
                pictureBox5.Enabled = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rút thành công số tiền: " + Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(textBox1.Text)),
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            screen.Show();
            this.Close();
        }
    }
}
