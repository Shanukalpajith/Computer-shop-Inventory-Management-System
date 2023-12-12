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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shanuka\Documents\PcgInventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                Con.Open();
                SqlCommand cmd = new SqlCommand("select * from UserTable where UserName='" + txtUname.Text + "' and UserPassword='" + txtPassword.Text + "'", Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

            
               string cmbIV = cmbRole.SelectedItem.ToString();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["UserRole"].ToString() == cmbIV)
                        {
                            MessageBox.Show("Login " + dt.Rows[i][3]);
                            if (cmbRole.SelectedIndex == 0)
                            {
                                UserManage Umf = new UserManage();
                                Umf.Show();
                                this.Hide();
                            }
                            else if (cmbRole.SelectedIndex == 1)
                            {
                                Stok_Manager smf = new Stok_Manager();
                                smf.Show();
                                this.Hide();
                            }
                            else
                            {
                                CashierForm cf = new CashierForm();
                                cf.Show();
                                this.Hide();
                            }

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
                Con.Close();
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
