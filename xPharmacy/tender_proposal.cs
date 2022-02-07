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
    public partial class tender_proposal : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=AASHIQUMAR748C\\SQLEXPRESS;Initial Catalog=AppDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public tender_proposal()
        {
            InitializeComponent();
            populateTenderProposal();

            btn_accept.Enabled = false;
            btn_reject.Enabled = false;

        }

        private void populateTenderProposal()
        {
            adpt = new SqlDataAdapter("Select * from tenderProposal", Con);
            dt = new DataTable();
            adpt.Fill(dt);
            datagridview_tender.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();

            cmd = new SqlCommand("select TenderID, ProductID, SupplierID, ProductTitle, Mg, Quantity, Description, SupplierName, Company, ContactNo, Email from tenderProposal where TenderID=@TenderID", Con);
            cmd.Parameters.AddWithValue("TenderID", tpID.Text);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                pID.Text = dr["ProductID"].ToString();
                sId.Text = dr["SupplierID"].ToString();
                pTitle.Text = dr["ProductTitle"].ToString();
                pMg.Text = dr["Mg"].ToString();
                pQuantity.Text = dr["Quantity"].ToString();
                pDescription.Text = dr["Description"].ToString();
                sName.Text = dr["SupplierName"].ToString();
                sCompany.Text = dr["Company"].ToString();
                sContactNo.Text = dr["ContactNo"].ToString();
                sEmail.Text = dr["Email"].ToString();

                btn_accept.Enabled = true;
                btn_reject.Enabled = true;
            }

            else
            {
                MessageBox.Show("Failed to read Tender Proposal!");
            }

            Con.Close();
        }

        private void datagridview_tender_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populateTenderProposal();
        }

        private void btn_s_search_Click(object sender, EventArgs e)
        {
            if(tpID.Text != "")
            {
                Con.Open();
                cmd = new SqlCommand("Delete tenderProposal where TenderID = '" + int.Parse(tpID.Text) + "'", Con);
                cmd.ExecuteNonQuery();
                Con.Close();
  

            }

            Con.Open();

            cmd = new SqlCommand("insert into approvedTender values('"+tpID.Text+ "','" +pID.Text + "','" + sId.Text + "','" + pTitle.Text + "','" + pMg.Text + "','" + pQuantity.Text + "','" + pDescription.Text + "','" + sName.Text + "','" + sCompany.Text + "','" + sContactNo.Text + "','" + sEmail.Text + "')", Con);

            int i = cmd.ExecuteNonQuery();

            if(i!=0)
            {
                MessageBox.Show("Tender Proposal Accepted");
                populateTenderProposal();
            }

            Con.Close();
        }

        private void btn_return_supplier_Click(object sender, EventArgs e)
        {
            order_products op = new order_products();
            op.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tpID.Text != "")
            {
                Con.Open();
                cmd = new SqlCommand("Delete tenderProposal where TenderID = '" + int.Parse(tpID.Text) + "'", Con);
                cmd.ExecuteNonQuery();
                Con.Close();


            }

            Con.Open();

            cmd = new SqlCommand("insert into rejectedTender values('" + tpID.Text + "','" + pID.Text + "','" + sId.Text + "','" + pTitle.Text + "','" + pMg.Text + "','" + pQuantity.Text + "','" + pDescription.Text + "','" + sName.Text + "','" + sCompany.Text + "','" + sContactNo.Text + "','" + sEmail.Text + "')", Con);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
            {
                MessageBox.Show("Tender Proposal Rejected!");
            }

            Con.Close();
        }
    }
}
