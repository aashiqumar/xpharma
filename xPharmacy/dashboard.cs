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

namespace xPharmacy
{
    public partial class dashboard : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=AASHIQUMAR748C\\SQLEXPRESS;Initial Catalog=AppDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public dashboard()
        {
            InitializeComponent();
            supplierCount();
            populate();
            stockCount();
            allRows();
            populateProducts();
            populateRequests();

        }

        private void supplierCount()
        {
            Con.Open();

            String query = "select Count(*) from supplierTable";
            cmd = new SqlCommand(query, Con);
            int count = (int)cmd.ExecuteScalar();
            txt_s_count.Text = "" + count + "";

            Con.Close();
        }

        private void populate()
        {
            adpt = new SqlDataAdapter("select * from supplierTable", Con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            supplierCount();
        }

        private void populateProducts()
        {
            adpt = new SqlDataAdapter("select * from productsTable", Con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView2_pr.DataSource = dt;
            stockCount();
        }

        private void populateRequests()
        {
            adpt = new SqlDataAdapter("select * from tenderProposal", Con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView2_pr.DataSource = dt;
            allRows();
        }

        private void stockCount()
        {
            Con.Open();

            String query = "select Count(*) from productsTable";
            cmd = new SqlCommand(query, Con);
            int count = (int)cmd.ExecuteScalar();
            txt_s_count.Text = "" + count + "";

            Con.Close();
        }

        private void allRows()
        {

            Con.Open();

            String query = "select Count(*) from tenderProposal";
            cmd = new SqlCommand(query, Con);
            int count = (int)cmd.ExecuteScalar();
            txt_profit_count.Text = "" + count + "";

            Con.Close();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            supplier sp = new supplier();
            sp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            products pd = new products();
            pd.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            order_products op = new order_products();
            op.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Logout?", "Yes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                login lg = new login();
                lg.Show();
                this.Hide();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_profit_count_Click(object sender, EventArgs e)
        {

        }
    }
}
