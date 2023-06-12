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
    public partial class SentMessage : UserControl
    {
        public SentMessage()
        {
            InitializeComponent();
        }

        public string Message
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        public string TimeAndSender
        {
            get
            {
                return label2.Text;
            }
            set
            {
                label2.Text = value;
            }
        }
    }
}
