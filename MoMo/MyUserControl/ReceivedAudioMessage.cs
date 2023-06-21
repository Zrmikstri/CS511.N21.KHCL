﻿using Microsoft.VisualBasic;
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
    public partial class ReceivedAudioMessage : UserControl, IMessage
    {
        private DateTime date;
        public ReceivedAudioMessage()
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
            }
        }

    }
}
