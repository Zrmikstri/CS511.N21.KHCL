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
    public partial class Banking : Form
    {
        public Banking()
        {
            InitializeComponent();
            // Add click event handlers to buttons using a for loop
            for (int i = 1; i <= 12; i++)
            {
                // Get the button control using the control's name
                PictureBox button = panel1.Controls.Find("bank" + i, true).FirstOrDefault() as PictureBox;

                // Check if the button was found
                if (button != null)
                {
                    button.Click += PictureBox_Click;
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedButton = (PictureBox)sender;
            string text = clickedButton.Name.Substring(4);
            Label label = panel1.Controls.Find("name" + text, true).FirstOrDefault() as Label;
            StackNavigation.Push(new BankingDetail(label.Text));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StackNavigation.Pop();
        }
    }
}
