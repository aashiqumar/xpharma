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
    public partial class edit_supplier : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=AASHIQUMAR748C\\SQLEXPRESS;Initial Catalog=AppDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public edit_supplier()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            adpt = new SqlDataAdapter("select * from supplierTable", Con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate();
        }

        private void btn_return_supplier_Click(object sender, EventArgs e)
        {
            supplier f1 = new supplier();
            f1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_s_save_Click(object sender, EventArgs e)
        {
            Con.Open();


            
            cmd = new SqlCommand("Update supplierTable set sName=@sName, sEmail=@sEmail, sMobile=@sMobile, sCompany=@sCompany where sID=@sID", Con);
            cmd.Parameters.AddWithValue("@sName", txt_s_edit_name.Text);
            cmd.Parameters.AddWithValue("@sMobile", txt_s_edit_mobile.Text);
            cmd.Parameters.AddWithValue("@sCompany", txt_s_edit_company.Text);
            cmd.Parameters.AddWithValue("@sEmail", txt_s_edit_email.Text);
            cmd.Parameters.AddWithValue("@sID", int.Parse(txt_s_edit_id.Text));
                

            int i = cmd.ExecuteNonQuery();

            if(i!=0)
            {
                MessageBox.Show("Sucesfully Updated!");

                txt_s_edit_company.Text = String.Empty;
                txt_s_edit_email.Text = String.Empty;
                txt_s_edit_mobile.Text = String.Empty;
                txt_s_edit_name.Text = String.Empty;
                txt_s_edit_id.Text = String.Empty;

            }
            else
            {
                MessageBox.Show("Failed To Update Record! Try Again.");
            }

            Con.Close();
           
            populate();
        }

        private void btn_s_delete_Click(object sender, EventArgs e)
        {

            if(txt_s_edit_id.Text != "")
            {
                if(MessageBox.Show("Are You Sure You Want To Delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Con.Open();
                    cmd = new SqlCommand("Delete supplierTable where sID = '" + int.Parse(txt_s_edit_id.Text) + "'", Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Sucessfully Deleted!");
                }
                
                populate();
            }
            else
            {
                MessageBox.Show("Enter Product Id!!!");
            }
            
        }

        private void btn_s_search_Click(object sender, EventArgs e)
        {
            Con.Open();

            cmd = new SqlCommand("Select sID, sName, sMobile, sEmail, sCompany from supplierTable where sID=@sID", Con);
            cmd.Parameters.AddWithValue("sID", txt_s_edit_id.Text);

            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();

            if(reader1.Read())
            {
                txt_s_edit_name.Text = reader1["sName"].ToString();
                txt_s_edit_mobile.Text = reader1["sMobile"].ToString();
                txt_s_edit_email.Text = reader1["sEmail"].ToString();
                txt_s_edit_company.Text = reader1["sCompany"].ToString();
            }
            else
            {
                MessageBox.Show("No Record Found!");
            }

            Con.Close();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_s_edit_company.Text = String.Empty;
            txt_s_edit_email.Text = String.Empty;
            txt_s_edit_mobile.Text = String.Empty;
            txt_s_edit_name.Text = String.Empty;
            txt_s_edit_id.Text = String.Empty;
        }

        private void txt_s_edit_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
