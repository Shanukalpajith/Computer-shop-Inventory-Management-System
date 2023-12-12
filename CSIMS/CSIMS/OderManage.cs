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
    public partial class OderManage : Form
    {
        public OderManage()
        {
            InitializeComponent();
        }
        DataTable Odtable = new DataTable();
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shanuka\Documents\PcgInventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvCstm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCId.Text = dgvCstm.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCName.Text = dgvCstm.Rows[e.RowIndex].Cells[1].Value.ToString();

        }


        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void disp_dataCust()
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
        public void disp_dataItem()
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
        int nub, sum = 0;
        int uprice, ttlprice, qty;
        String item;

        private void OderManage_Load(object sender, EventArgs e)
        {
            disp_dataCust();
            disp_dataItem();
            disp_dataViOder();
            dgvOder.DataSource = Odtable;
            Odtable.Columns.Add("Oder ID", typeof(int));
            Odtable.Columns.Add("Item", typeof(string));
            Odtable.Columns.Add("UPrice", typeof(int));
            Odtable.Columns.Add("Quntity", typeof(int));
            Odtable.Columns.Add("TtlPrice", typeof(int));


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        int round = 0;
        int stok;



        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtqty.Text == "")
                MessageBox.Show("Please Enter quantity");
            else if (round == 0)
                MessageBox.Show("Please Select Item");
            else if (Convert.ToInt32(txtqty.Text) > stok)
                MessageBox.Show("Not Enough Stok");

            else
            {

                nub = nub + 1;
                qty = Convert.ToInt32(txtqty.Text);
                ttlprice = uprice * qty;
                Odtable.Rows.Add(nub, item, uprice, qty, ttlprice);
                dgvOder.DataSource = Odtable;
                round = 0;

            }
            sum = sum + ttlprice;
            txbTtl.Text = "Rs :" + sum.ToString();
        }

        //private void btnOdrinsert_Click(object sender, EventArgs e)
        //{
        //    if (txtOid.Text == "" || txtCId.Text == "" || txtCName.Text == "" || txbTtl.Text == "")
        //    {
        //        MessageBox.Show("Please fill All");

        //    }
        //    else
        //    {
        //        try
        //        {
        //            Con.Open();
        //            SqlCommand cmd = new SqlCommand("insert into OderTable values('" + txtOid.Text + "','" + txtCId.Text + "','" + txtCName.Text + "','" + dtOd.Text + "','" + txbTtl.Text + "')", Con);
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Oder inserted successfully ");
        //            Con.Close();
        //        }
        //        catch
        //        {

        //        }
        //    }
        //}

        private void dgvItem_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            item = dgvItem.Rows[e.RowIndex].Cells[1].Value.ToString();
            uprice = Convert.ToInt32(dgvItem.Rows[e.RowIndex].Cells[2].Value.ToString());
            stok = Convert.ToInt32(dgvItem.Rows[e.RowIndex].Cells[3].Value.ToString());
            round = 1;
        }

        private void dgvCstm_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCId.Text = dgvCstm.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCName.Text = dgvCstm.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            if (txtqty.Text == "")
                MessageBox.Show("Please Enter quantity");
            else if (round == 0)
                MessageBox.Show("Please Select Item");
            else if (Convert.ToInt32(txtqty.Text) > stok)
                MessageBox.Show("Not Enough Stok");

            else
            {

                nub = nub + 1;
                qty = Convert.ToInt32(txtqty.Text);
                ttlprice = uprice * qty;
                Odtable.Rows.Add(nub, item, uprice, qty, ttlprice);
                dgvOder.DataSource = Odtable;
                round = 0;

            }
            sum = sum + ttlprice;
            txbTtl.Text = "Rs:" + sum.ToString();
        }

        private void btnOdrinsert_Click_1(object sender, EventArgs e)
        {
            if (txtOid.Text == "" || txtCId.Text == "" || txtCName.Text == "" || txbTtl.Text == "")
            {
                MessageBox.Show("Please fill All");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into OTable values('" + txtOid.Text + "','" + txtCId.Text + "','" + txtCName.Text + "','" + dtOd.Text + "','" + txbTtl.Text + "')", Con);
                    //SqlCommand cmd = new SqlCommand("insert into OTable values('" + txtOid.Text + "','" + txtCId.Text + "','" + txtCName.Text + "')", Con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Oder inserted successfully ");
                    Con.Close();
                    disp_dataViOder();

                }
                catch
                {

                }


            }

        }
        //viwe oder Tab1
        public void disp_dataViOder()
        {
            try
            {
                Con.Open();
                string Myrecord = "select * from OTable";
                SqlDataAdapter da = new SqlDataAdapter(Myrecord, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgvVioder.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }

        }

        private void lblExit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvOder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dgvVioder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PPDOder.ShowDialog() == DialogResult.OK)
            {
                PDOder.Print();
            }

        }
       

        private void PDOder_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {          
           
            e.Graphics.DrawString("ODER SUMMERY", new Font("brltannic", 35, FontStyle.Bold), Brushes.Blue, new Point(230));
            e.Graphics.DrawString("*******************************************************", new Font("brltannic", 35, FontStyle.Bold), Brushes.Blue, new Point(0, 50));
            e.Graphics.DrawString("ODER ID                   :" + dgvVioder.Rows[0].Cells[0].Value.ToString(), new Font("brltannic", 20, FontStyle.Bold), Brushes.Black, new Point(0,150));
            e.Graphics.DrawString("CUSTOMER ID        :" + dgvVioder.Rows[0].Cells[1].Value.ToString(), new Font("brltannic", 20, FontStyle.Bold), Brushes.Black, new Point(0, 200));
            e.Graphics.DrawString("CUSTOMER NAME :" + dgvVioder.Rows[0].Cells[2].Value.ToString(), new Font("brltannic", 20, FontStyle.Bold), Brushes.Black, new Point(0, 250));
            e.Graphics.DrawString("ODER DATE                 :" + dgvVioder.Rows[0].Cells[3].Value.ToString(), new Font("brltannic", 20, FontStyle.Bold), Brushes.Black, new Point(0, 300));
            e.Graphics.DrawString("TOTAL                       :" + dgvVioder.Rows[0].Cells[4].Value.ToString(), new Font("brltannic", 20, FontStyle.Bold), Brushes.Black, new Point(0, 350));

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }

}
