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
    public partial class ItemManage : Form
    {
        public ItemManage()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shanuka\Documents\PcgInventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void ItemManage_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvItem.Rows[e.RowIndex];
                txtIid.Text = dgvRow.Cells[0].Value.ToString();
                txtIname.Text = dgvRow.Cells[1].Value.ToString();
                txtIprice.Text = dgvRow.Cells[2].Value.ToString();
                txtIqty.Text = dgvRow.Cells[3].Value.ToString();
                txtIctg.Text = dgvRow.Cells[4].Value.ToString();
            }
        }
        private void Clear()
        {
            txtIid.Text = "";
            txtIname.Text = "";
            txtIprice.Text = "";
            txtIqty.Text = "";
            txtIctg.Text = "";
        }

        public void disp_data()
        {
            try
            {
                Con.Open();
                string Myrecord = "select * from ItemTable";
                SqlDataAdapter da = new SqlDataAdapter(Myrecord, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgvItem.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from ItemTable where IId ='" + txtIid.Text + "'", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Invalid ID");

            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ItemTable values('" + txtIid.Text + "','" + txtIname.Text + "','" + txtIprice.Text + "','" + txtIqty.Text + "','" + txtIctg.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("record inserted successfully ");
                Con.Close();
                disp_data();
                Clear();
            }

                //try
                //{
                //    Con.Open();
                //    SqlCommand cmd = new SqlCommand("insert into ItemTable values('" + txtIid.Text + "','" + txtIname.Text + "','" + txtIprice.Text + "','" + txtIqty.Text + "','" + txtIctg.Text + "')", Con);
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

            private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIid.Text == "")
            {
                MessageBox.Show("Insert The Item ID");

            }
            else
            {
                Con.Open();
                string myrecord = "delete from ItemTable where Iid='" + txtIid.Text + "'; ";
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
                SqlCommand cmd = new SqlCommand("update ItemTable set IName='" +txtIname.Text+ "',IPrice='" + txtIprice.Text + "',IQuntity='" + txtIqty.Text + "' where Iid='" + txtIid.Text + "'", Con);
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

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
