using MoMo.Model;
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
        Panel[] panels = null!;
        Label[] labels = null!;
        int flag = 0;
        string value = "10.000";
        private string[] Viettel = { "086", "096", "097", "098", "032", "033", "034", "035", "036", "037", "038", "039" };
        private string[] Vinaphone = { "088", "091", "094", "081", "082", "086", "084", "085" };
        private string[] Mobifone = { "089", "090", "093", "070", "079", "077", "076", "078" };
        string provider = string.Empty;

        public PayPhoneMoney()
        {
            InitializeComponent();

            panels = new Panel[] { panel1, panel9, panel10, panel4, panel5, panel6, panel7, panel8, panel11, panels1, panels2, panels3, panels4, panels5 };
            labels = new Label[] { label1, label9, label10, label4, label5, label6, label7, label8, label11, labels1, labels2, labels3, labels4, labels5 };

            foreach (var panel in panels)
            {
                panel.Click += panel_Click_change_color!;
            }

            panel14.HorizontalScroll.Maximum = 0;
            panel14.AutoScroll = false;
            panel14.HorizontalScroll.Visible = false;
            panel14.AutoScroll = true;
            checkValue();
            label16.Text = Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(value));
        }

        private void panel_Click_change_color(object sender, EventArgs e)
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
            labels[flag].ForeColor = Color.FromArgb(219, 45, 139);
            checkValue();
            label16.Text = Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(value));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            if (textBox.Text.Length == 10)
            {
                // check phone number
                if (Viettel.Contains(textBox.Text.Substring(0, 3)))
                {
                    pictureBox1.Image = Image.FromFile(@"../../../Images/viettel-logo.png");
                    label2.Visible = false;
                    pictureBox5.Image = Image.FromFile(@"../../../Images/pay_button.png");
                    pictureBox5.Enabled = true;

                    provider = "Viettel";
                }
                else if (Vinaphone.Contains(textBox.Text.Substring(0, 3)))
                {
                    pictureBox1.Image = Image.FromFile(@"../../../Images/vinaphone-logo.png");
                    label2.Visible = false;
                    pictureBox5.Image = Image.FromFile(@"../../../Images/pay_button.png");
                    pictureBox5.Enabled = true;

                    provider = "Vinaphone";
                }
                else if (Mobifone.Contains(textBox.Text.Substring(0, 3)))
                {
                    pictureBox1.Image = Image.FromFile(@"../../../Images/mobifone-logo.jpg");
                    label2.Visible = false;
                    pictureBox5.Image = Image.FromFile(@"../../../Images/pay_button.png");
                    pictureBox5.Enabled = true;

                    provider = "Mobifone";
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(@"../../../Images/momo-logo.png");
                    label2.Visible = true;
                }
            }
            else
            {
                pictureBox5.Image = Image.FromFile(@"../../../Images/pay_button_gray.png");
                pictureBox5.Enabled = false;
                pictureBox1.Image = Image.FromFile(@"../../../Images/momo-logo.png");
                label2.Visible = true;
            }
        }

        private void checkValue()
        {
            if (flag < 9)
                value = labels[flag].Text.Substring(0, labels[flag].Text.Length - 1);
            else
            {
                if (flag == 9)
                    value = "19500";
                else if (flag == 10)
                    value = "49000";
                else if (flag == 11)
                    value = "98500";
                else if (flag == 12)
                    value = "195000";
                else
                    value = "492000";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Session.LoggedInUserInfo!.Balance < Utils.VNCurrencyToDouble(value))
            {
                MessageBox.Show("Số dư không đủ để thực hiện giao dịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (UserDbContext db = new UserDbContext())
            {

                Session.LoggedInUserInfo.Balance -= Utils.VNCurrencyToDouble(value);
                db.Users.Update(Session.LoggedInUserInfo);

                // Create transaction 
                Transaction transaction = new()
                {
                    Amount = Utils.VNCurrencyToDouble(value),
                    Type = Transaction.TransactionType.Service,
                    SenderId = Session.LoggedInUserInfo!.Id,
                    Message = $"{textBox1.Text}|{provider}", // phone number to recharge|provider
                    ServiceId = 1,
                };
                db.Transactions.Add(transaction);

                db.SaveChanges();
            }
            MessageBox.Show("Nạp thành công " + Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(labels[flag].Text.Substring(0, labels[flag].Text.Length - 1)))
                + " cho SĐT " + textBox1.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            StackNavigation.Pop();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StackNavigation.Pop();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;  // Prevent the character from being entered
            }
        }
    }
}
