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
using System.Net;
using System.Web.Script.Serialization;

namespace xPharmacy
{
    public partial class supplier_dashboard : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=AASHIQUMAR748C\\SQLEXPRESS;Initial Catalog=AppDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public supplier_dashboard()
        {
            InitializeComponent();
            populateSupplierTable();
            populateProductsTable();
            populateTenderProposal();

            altTextLock();
        }

        private void btn_return_supplier_Click(object sender, EventArgs e)
        {
            first_page fp = new first_page();
            fp.Show();
            this.Hide();
        }

        private void populateSupplierTable()
        {
            try
            {
                string url = "http://localhost:49274/api/supplierTables";
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString(url);
                dataGridView1_suppliers.DataSource = (new JavaScriptSerializer()).Deserialize<List<MyClass>>(json);

                adpt = new SqlDataAdapter("select * from supplierTable", Con);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1_suppliers.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            


        }

        private void populateTenderProposal()
        {
            adpt = new SqlDataAdapter("select * from tenderProposal", Con);
            dt = new DataTable();
            adpt.Fill(dt);
            
        }

        private void populateProductsTable()
        {
            adpt = new SqlDataAdapter("select * from requestProduct", Con);
            dt = new DataTable();
            adpt.Fill(dt);
            datagridview_pending_products.DataSource = dt;
            
        }

        private void productTextLock()
        {
            txt_p_title.Enabled = false;
            txt_p_quantity.Enabled = false;
            txt_p_mg.Enabled = false;
            txt_p_description.Enabled = false;
        }

        private void altTextLock()
        {
            txt_p_title.Enabled = false;
            txt_p_quantity.Enabled = false;
            txt_p_mg.Enabled = false;
            txt_p_description.Enabled = false;
            txt_s_name.Enabled = false;
            txt_s_email.Enabled = false;
            txt_s_company.Enabled = false;
            txt_s_no.Enabled = false;
        }

        private void altTextFreeLock()
        {
            txt_s_name.Enabled = true;
            txt_s_email.Enabled = true;
            txt_s_company.Enabled = true;
            txt_s_no.Enabled = true;
        }

        private void clearText()
        {
            txt_p_description.Text = String.Empty;
            txt_p_id.Text = String.Empty;
            txt_p_mg.Text = String.Empty;
            txt_p_quantity.Text = String.Empty;
            txt_p_title.Text = String.Empty;
            txt_s_company.Text = String.Empty;
            txt_s_email.Text = String.Empty;
            txt_s_id.Text = String.Empty;
            txt_s_name.Text = String.Empty;
            txt_s_no.Text = String.Empty;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_suppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populateSupplierTable();
        }

        private void btn_s_send_Click(object sender, EventArgs e)
        {
            try
            {
                

                Con.Open();

                cmd = new SqlCommand("Insert into tenderProposal values('" + txt_p_id.Text + "','" + txt_s_id.Text + "','" + txt_p_title.Text + "','" + txt_p_mg.Text + "','" + txt_p_quantity.Text + "','" + txt_p_description.Text + "','" + txt_s_name.Text+ "','" + txt_s_company.Text + "','" + txt_s_email.Text + "','" +txt_s_no+ "')", Con);

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Tender Proposal Sent! Will reach back with in 24 Hours");


                    txt_p_id.Text = String.Empty;
                    txt_s_id.Text = String.Empty;
                    txt_p_title.Text = String.Empty;
                    txt_p_mg.Text = String.Empty;
                    txt_p_quantity.Text = String.Empty;
                    txt_p_description.Text = String.Empty;
                    txt_s_name.Text = String.Empty;
                    txt_s_company.Text = String.Empty;
                    txt_s_email.Text = String.Empty;
                    txt_s_no.Text = String.Empty;

                    

                }
                else
                {
                    MessageBox.Show("Supplier Failed To Create! Try Again.");
                }

                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
  
        }

        private void datagridview_pending_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populateProductsTable();
        }

        private void btn_s_search_Click(object sender, EventArgs e)
        {
            Con.Open();

            cmd = new SqlCommand("select Id, pTitle, pMg, pQuantity, pDescription from requestProduct where Id=@Id", Con);
            cmd.Parameters.AddWithValue("Id", txt_p_id.Text);

            productTextLock();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                txt_p_id.Text = dr["Id"].ToString();
                txt_p_title.Text = dr["pTitle"].ToString();
                txt_p_mg.Text = dr["pMg"].ToString();
                txt_p_quantity.Text = dr["pQuantity"].ToString();
                txt_p_description.Text = dr["pDescription"].ToString();

                productTextLock();
             
            }
            else
            {
                MessageBox.Show("Please Check Product Id! And Try again");
            }

            Con.Close();
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            Con.Open();

            cmd = new SqlCommand("select sID, sName, sEmail, sMobile, sCompany from supplierTable where sID=@sID", Con);
            cmd.Parameters.AddWithValue("sID", txt_s_id.Text);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
 
                txt_s_id.Text = dr["sID"].ToString();
                txt_s_name.Text = dr["sName"].ToString();
                txt_s_no.Text = dr["sEmail"].ToString();
                txt_s_company.Text = dr["sCompany"].ToString();
                txt_s_email.Text = dr["sMobile"].ToString();

                altTextFreeLock();

            }
            else
            {
                MessageBox.Show("Please Check Product Id! And Try again");
            }

            Con.Close();
        }

        private void dataGridView1_approved_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populateTenderProposal();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            approved_proposal ap = new approved_proposal();
            ap.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rejected_proposals rp = new rejected_proposals();
            rp.Show();
            this.Hide();
        }
    }
}
