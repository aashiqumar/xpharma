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
    public partial class supplier : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=AASHIQUMAR748C\\SQLEXPRESS;Initial Catalog=AppDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public supplier()
        {
            InitializeComponent();
            populate();
            FillDataGridView();
            
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

        private void supplier_Load(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
         

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Con.Open();

            cmd = new SqlCommand("Insert into supplierTable values('" + txt_s_fullname.Text + "','" + txt_s_mobile.Text + "','" + txt_s_email.Text + "','" + txt_s_address.Text + "')", Con);
        
            int i = cmd.ExecuteNonQuery();

            if(i!=0)
            {
                MessageBox.Show("Supplier Created");

                
                txt_s_fullname.Text = String.Empty;
                txt_s_email.Text = String.Empty;
                txt_s_mobile.Text = String.Empty;
                txt_s_address.Text = String.Empty;

            }
            else
            {
                MessageBox.Show("Supplier Failed To Create! Try Again.");
            }

            Con.Close();
            populate();

           
        }

        private void populate()
        {
            adpt = new SqlDataAdapter("select * from supplierTable", Con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            supplierCount();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate();
        }

        private void btn_save_supplier_Click(object sender, EventArgs e)
        {
            edit_supplier f1 = new edit_supplier();
            f1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dashboard dh = new dashboard();
            dh.Show();
            this.Hide();
        }

        private void btn_s_search_Click(object sender, EventArgs e)
        {
            

        }

        private void FillDataGridView()
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_s_search_sups_Click(object sender, EventArgs e)
        {
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

        private void txt_s_count_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
