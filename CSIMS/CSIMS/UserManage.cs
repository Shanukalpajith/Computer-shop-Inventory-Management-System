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
    public partial class UserManage : Form
    {
        public UserManage()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shanuka\Documents\PcgInventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserManage_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Clear()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtRole.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    txtId.Text = dgvUser.SelectedRows[0].Cells[0].Value.ToString();
            //    txtName.Text = dgvUser.SelectedRows[0].Cells[1].Value.ToString();
            //    txtPassword.Text = dgvUser.SelectedRows[0].Cells[2].Value.ToString();
            //    txtRole.Text = dgvUser.SelectedRows[0].Cells[3].Value.ToString();
            //}
            //catch 
            //{
            
            //}

        }

        public void disp_data() 
        {
            try
            {
                Con.Open();
                string Myrecord = "select * from UserTable";
                SqlDataAdapter da = new SqlDataAdapter(Myrecord, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgvUser.DataSource = ds.Tables[0];
                Con.Close();
                //Con.Open();
                ////string Myrecord = "select * from UserTable";
                ////SqlDataAdapter sqlDa = new SqlDataAdapter(Myrecord, Con);
                //sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                //DataTable dtb1 = new DataTable();
                //sqlDa.Fill(dtb1);
                //dgvUser.AutoGenerateColumns = false;
                //dgvUser.DataSource = dtb1;
                //// Con.Close();
            }

            catch
            {

            }


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from UserTable where UserId ='" + txtId.Text + "'", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Invalid ID");

            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTable values('" + txtId.Text + "','" + txtName.Text + "','" + txtPassword.Text + "','" + txtRole.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("record inserted successfully ");
                Con.Close();
                disp_data();
                Clear();


            }

            //try
            //{
            //    Con.Open();
            //    SqlCommand cmd = new SqlCommand("insert into UserTable values('" + txtId.Text + "','" + txtName.Text + "','" + txtPassword.Text + "','" + txtRole.Text + "')", Con);
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
            if(txtId.Text == "") 
            {
                MessageBox.Show("Insert The User ID");
            
            }
            else 
            {
                Con.Open();
                string myrecord = "delete from UserTable where UserId='" + txtId.Text + "'; ";
                SqlCommand cmd = new SqlCommand(myrecord, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("record deleted successfully");
                Con.Close();
                disp_data();
                Clear();



            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    txtId.Text = dgvUser.SelectedRows[0].Cells[0].Value.ToString();
            //    txtName.Text = dgvUser.SelectedRows[0].Cells[1].Value.ToString();
            //    txtPassword.Text = dgvUser.SelectedRows[0].Cells[2].Value.ToString();
            //    txtRole.Text = dgvUser.SelectedRows[0].Cells[3].Value.ToString();
            //}
            //catch
            //{

            //}
            if(e.RowIndex != -1) 
            {
                DataGridViewRow dgvRow = dgvUser.Rows[e.RowIndex];
                txtId.Text = dgvRow.Cells[0].Value.ToString();
                txtName.Text = dgvRow.Cells[1].Value.ToString();
                txtPassword.Text = dgvRow.Cells[2].Value.ToString();
                txtRole.Text = dgvRow.Cells[3].Value.ToString();

            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTable set UserName='" +txtName.Text+ "',UserPassword='" + txtPassword.Text + "',UserRole='" + txtRole.Text + "' where UserId='" + txtId.Text + "'", Con);
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
        
    }
    //123
}
