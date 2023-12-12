using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIMS
{
    public partial class CashierForm : Form
    {
        public CashierForm()
        {
            InitializeComponent();
        }

        private void btmUf_Click(object sender, EventArgs e)
        {
            CustomerManage cmf = new CustomerManage();
            cmf.Show();
        }

        private void btmOf_Click(object sender, EventArgs e)
        {
            OderManage omf = new OderManage();
            omf.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRept_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            rf.Show();
        }
    }
}
