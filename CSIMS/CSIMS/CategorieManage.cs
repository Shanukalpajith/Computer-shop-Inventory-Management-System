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
    public partial class CategorieManage : Form
    {
        public CategorieManage()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shanuka\Documents\PcgInventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void CategorieManage_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvCategory.Rows[e.RowIndex];
                txtCid.Text = dgvRow.Cells[0].Value.ToString();
                txtCname.Text = dgvRow.Cells[1].Value.ToString(); ;

            }
        }
        private void Clear()
        {
            txtCid.Text = "";
            txtCname.Text = "";
        }

        public void disp_data()
        {
            try
            {
                Con.Open();
                string Myrecord = "select * from CategoryTable";
                SqlDataAdapter da = new SqlDataAdapter(Myrecord, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgvCategory.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from CategoryTable where Cid ='" + txtCid.Text + "'", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Invalid ID");

            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CategoryTable values('" + txtCid.Text + "','" + txtCname.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("record inserted successfully ");
                Con.Close();
                disp_data();
                Clear();
            }

                //    try
                //{
                //    Con.Open();
                //    SqlCommand cmd = new SqlCommand("insert into CategoryTable values('" + txtCid.Text + "','" + txtCname.Text + "')", Con);
                //    cmd.ExecuteNonQuery();
                //    MessageBox.Show("record inserted successfully ");
                //    Con.Close();
                //    disp_data();
                //    Clear();
                //}
                //catch
                //{

                //}

            }



            private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCid.Text == "")
            {
                MessageBox.Show("Insert The Category ID");

            }
            else
            {
               
                    Con.Open();
                    string myrecord = "delete from CategoryTable where CId='" + txtCid.Text + "'; ";
                    SqlCommand cmd = new SqlCommand(myrecord, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("record deleted successfully");
                    Con.Close();
                    disp_data();
                    Clear();



            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CategoryTable set CName='" + txtCname.Text + "' where CId='" + txtCid.Text + "'", Con);
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

        private void btnDashb_Click(object sender, EventArgs e)
        {
            Stok_Manager smf = new Stok_Manager();
            smf.Show();
            this.Hide();
        }
    }
}
