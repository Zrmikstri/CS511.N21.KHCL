using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MoMo
{
    public partial class ReceivedMessage : UserControl, IMessage
    {
        private DateTime date;
        public ReceivedMessage()
        {
            InitializeComponent();
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                label2.Text = value.ToString("HH:mm");
            }
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
    }
}
