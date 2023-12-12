using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSIMS
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shanuka\Documents\PcgInventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnReport_Click(object sender, EventArgs e)
        {
            Con.Open();
            DateTime fromd = DateTime.Parse(dtp1.Text);
            DateTime tod = DateTime.Parse(dtp2.Text);

            SqlCommand cmd =new SqlCommand ("select * from OTable where OderDate ='"+fromd+ "' and OderDate <= '" + tod+"'",Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvReport.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
