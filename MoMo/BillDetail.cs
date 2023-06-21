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
    public partial class BillDetail : Form
    {
        private Transaction transaction = null!;
        public BillDetail()
        {
            InitializeComponent();
        }

        public BillDetail(Transaction transaction)
        {
            InitializeComponent();
            this.transaction = transaction;
        }

        private void BillDetail_Load(object sender, EventArgs e)
        {
            LoadBillDetail();
        }

        private void LoadBillDetail()
        {

        }
    }
}
