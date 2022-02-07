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
    public partial class order_products : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=AASHIQUMAR748C\\SQLEXPRESS;Initial Catalog=AppDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public order_products()
        {
            InitializeComponent();
            populate();
            populateTender();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Hide();
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

        private void clearText()
        {
            txt_o_description.Text = String.Empty;
            txt_o_mg.Text = String.Empty;
            txt_o_quantity.Text = String.Empty;
            txt_o_title.Text = String.Empty;
            
        }

        private void populate()
        {
            adpt = new SqlDataAdapter("Select * from requestProduct", Con);
            dt = new DataTable();
            adpt.Fill(dt);
            datagridview_order_products.DataSource = dt;
        }

        private void populateTender()
        {
            adpt = new SqlDataAdapter("Select * from approvedTender", Con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1_accepted_tender.DataSource = dt;
        }

        private void txt_s_mobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_o_send_Click(object sender, EventArgs e)
        {
            
                Con.Open();

                cmd = new SqlCommand("Insert into requestProduct values('" + txt_o_title.Text + "','" + txt_o_mg.Text + "','" + txt_o_quantity.Text + "','" + txt_o_description.Text + "')", Con);

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Order Request Sent!");

                    clearText();
                    populate();

                }

                else
                {
                    MessageBox.Show("Failed to send order request! Try Again");
                }

                Con.Close();
            
            
            
        }

        private void datagridview_order_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate();
        }

        private void order_products_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tender_proposal tp = new tender_proposal();
            tp.Show();
            this.Hide();
        }

        private void dataGridView1_accepted_tender_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populateTender();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Logout?", "Yes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                login lg = new login();
                lg.Show();
                this.Hide();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rp_orders2 rp = new rp_orders2();
            rp.Show();
            this.Hide();
        }
    }
}
