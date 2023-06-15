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
    public partial class PayPhoneMoney : Form
    {
        Panel[] panels;
        Label[] labels;
        int flag = 0;
        private Screen screen;
        public PayPhoneMoney()
        {
            InitializeComponent();
        }

        public PayPhoneMoney(object e)
        {
            InitializeComponent();
            panels = new Panel[] { panel1, panel9, panel10, panel4, panel5, panel6, panel7, panel8, panel11 };
            labels = new Label[] { label1, label9, label10, label4, label5, label6, label7, label8, label11 };
            foreach (var panel in panels)
            {
                panel.Click += panel_Click_change_color;
            }
            this.screen = (Screen)e;
        }

        private void panel_Click_change_color(object? sender, EventArgs e)
        {
            var ClickedPanel = (Panel)sender;
            ClickedPanel.BackgroundImage = Image.FromFile(@"../../../Images/rectangle_pink.png");
            for (int i = 0; i < panels.Length; i++)
            {
                if (panels[i] != ClickedPanel)
                {
                    panels[i].BackgroundImage = Image.FromFile(@"../../../Images/round_Bg3.png");
                    labels[i].ForeColor = Color.Black;
                }
                else
                    flag = i;
            }
            labels[flag].ForeColor = Color.MediumVioletRed;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text.Length == 10)
            {
                pictureBox5.Image = Image.FromFile(@"../../../Images/pay_button.png");
                pictureBox5.Enabled = true;
            }
            else
            {
                pictureBox5.Image = Image.FromFile(@"../../../Images/pay_button_gray.png");
                pictureBox5.Enabled = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nạp thành công " + Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(labels[flag].Text.Substring(0, labels[flag].Text.Length - 1)))
                + " cho SĐT " + textBox1.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            screen.Show();
            this.Close();
        }
    }
}
