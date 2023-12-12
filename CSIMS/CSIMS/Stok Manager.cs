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
    public partial class Stok_Manager : Form
    {
        public Stok_Manager()
        {
            InitializeComponent();
        }

        private void btnCm_Click(object sender, EventArgs e)
        {
            CategorieManage cmf = new CategorieManage();
            cmf.Show();
            //this.Hide();
        }

        private void btnIm_Click(object sender, EventArgs e)
        {
            ItemManage imf = new ItemManage();
            imf.Show();
           // this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
