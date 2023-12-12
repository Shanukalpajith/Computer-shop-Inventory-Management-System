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
    public partial class CustomerManage : Form
    {
        public CustomerManage()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Shanuka\Documents\PcgInventorydb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void CustomerManage_Load(object sender, EventArgs e)
        {
            disp_data();

        }

        private void dgvCstm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvCstm.Rows[e.RowIndex];
                txtCuid.Text = dgvRow.Cells[0].Value.ToString();
                txtCuname.Text = dgvRow.Cells[1].Value.ToString();
                txtCuphone.Text = dgvRow.Cells[2].Value.ToString();
                
            }
        }

        private void Clear()
        {
            txtCuid.Text = "";
            txtCuname.Text = "";
            txtCuphone.Text = "";
          
        }

        public void disp_data()
        {
            try
            {
                Con.Open();
                string Myrecord = "select * from CustomerTable";
                SqlDataAdapter da = new SqlDataAdapter(Myrecord, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgvCstm.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTable values('" + txtCuid.Text + "','" + txtCuname.Text + "','" + txtCuphone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("record inserted successfully ");
                Con.Close();
                disp_data();
                Clear();


            }
            catch
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTable set CustName='" + txtCuname.Text + "',Phone='" + txtCuphone.Text + "' where CustoId='" + txtCuid.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("record updated successfully ");
                Con.Close();
                disp_data();
                Clear();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCuid.Text == "")
            {
                MessageBox.Show("Insert The Customer ID");

            }
            else
            {
                Con.Open();
                string myrecord = "delete from CustomerTable where CustoId='" + txtCuid.Text + "'; ";
                SqlCommand cmd = new SqlCommand(myrecord, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("record deleted successfully");
                Con.Close();
                disp_data();
                Clear();
            }
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void lblmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
