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
    public partial class ContactItem : UserControl
    {
        public User User { get; set; } = null!;
        public string ContactName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string LatestMessage
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        public string LatestMessageDate
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }

        public Image ContactAvatar
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public ContactItem()
        {
            InitializeComponent();
        }

        public void SetDateLabelPosition(string option)
        {
            if (option == "dd/MM")
            {
                label2.MaximumSize = new Size(280, 23);
                label3.Location = new Point(352, 31);
            }
            else if (option == "dd/MM/yyyy")
            {
                label2.MaximumSize = new Size(260, 23);
                label3.Location = new Point(324, 31);
            }
        }

        public void SetDateLabelVisible(bool visible)
        {
            label3.Visible = visible;
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;

                foreach (Control control in Controls)
                    control.Click += value;
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                    control.Click -= value;
            }
        }
    }
}
