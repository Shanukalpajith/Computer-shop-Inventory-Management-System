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
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();
        }

        private void btnUserf_Click(object sender, EventArgs e)
        {
            UserManage umf = new UserManage();
            umf.Show();
            //this.Hide();
        }

        private void btnCatogryf_Click(object sender, EventArgs e)
        {
            CategorieManage cmf = new CategorieManage();
            cmf.Show();
            //this.Hide();
        }

        private void btnItemf_Click(object sender, EventArgs e)
        {
            ItemManage imf = new ItemManage();
            imf.Show();
            //this.Hide();
        }

        private void btnOderf_Click(object sender, EventArgs e)
        {
            OderManage omf = new OderManage();
            omf.Show();
           // this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
