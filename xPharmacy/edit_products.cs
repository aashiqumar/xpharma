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
    public partial class edit_products : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=AASHIQUMAR748C\\SQLEXPRESS;Initial Catalog=AppDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        
        public edit_products()
        {
            InitializeComponent();
            populate();
            disableTextBox();
            
        }

        private void disableTextBox()
        {
            txt_p_edit_bp.Enabled = false;
            txt_p_edit_expdate.Enabled = false;
            txt_p_edit_mandate.Enabled = false;
            txt_p_edit_sp.Enabled = false;
            txt_p_edit_title.Enabled = false;
            txt_p_edit_quantity.Enabled = false;
            txt_p_edit_profit.Enabled = false;
            txt_p_edit_mg.Enabled = false;
            
        }

        private void enableTextBox()
        {
            txt_p_edit_bp.Enabled = true;
            txt_p_edit_expdate.Enabled = true;
            txt_p_edit_mandate.Enabled = true;
            txt_p_edit_sp.Enabled = true;
            txt_p_edit_title.Enabled = true;
            txt_p_edit_quantity.Enabled = true;
            txt_p_edit_profit.Enabled = true;
            txt_p_edit_mg.Enabled = true;
        }

        private void calculateProfit()
        {
            
            
        }

        private void populate()
        {

            cmd = new SqlCommand("select * from productsTable", Con);
            adpt = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void txt_s_edit_mobile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int bp = int.Parse(txt_p_edit_bp.Text);
                int sp = int.Parse(txt_p_edit_sp.Text);
                int qt = int.Parse(txt_p_edit_quantity.Text);
                int bpTotal = 0;
                int spTotal = 0;
                int profit = 0;

                bpTotal = bp * qt;
                spTotal = sp * qt;

                profit = spTotal - bpTotal;

                String y = profit.ToString();

                txt_p_edit_profit.Text = y;

            }
            catch (Exception ex)
            {

            }
        }

        private void btn_s_search_Click(object sender, EventArgs e)
        {
           
            try
            {
                Con.Open();

                cmd = new SqlCommand("Select pID, pTitle, pQuantity, pBuyingPrice, pSellingPrice, pProfit, pManDate, pExpDate, pMilligrams from productsTable where pID=@pID", Con);
                cmd.Parameters.AddWithValue("pID", txt_p_edit_id.Text);

                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();

                enableTextBox();

                if (sdr.Read())
                {
                    txt_p_edit_title.Text = sdr["pTitle"].ToString();
                    txt_p_edit_quantity.Text = sdr["pQuantity"].ToString();
                    txt_p_edit_mandate.Text = sdr["pManDate"].ToString();
                    txt_p_edit_expdate.Text = sdr["pExpDate"].ToString();
                    txt_p_edit_bp.Text = sdr["pBuyingPrice"].ToString();
                    txt_p_edit_sp.Text = sdr["pSellingPrice"].ToString();
                    txt_p_edit_profit.Text = sdr["pProfit"].ToString();
                    txt_p_edit_mg.Text = sdr["pMilligrams"].ToString();

                    Con.Close();
                }
                else
                {
                    MessageBox.Show("No Record Found!");
                }

               

                populate();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

           
            


        }

        private void dView_edit_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate();
        }

        private void btn_return_supplier_Click(object sender, EventArgs e)
        {
            products pd = new products();
            pd.Show();
            this.Hide();
        }

        private void edit_products_Load(object sender, EventArgs e)
        {

        }

        private void btn_p_save_Click(object sender, EventArgs e)
        {
            try
            {
               

                cmd = new SqlCommand("Update productsTable set pTitle=@pTitle, pQuantity=@pQuantity, pBuyingPrice=@pBuyingPrice, pSellingPrice=@pSellingPrice, pProfit=@pProfit, pManDate=@pManDate, pExpDate=@pExpDate, pMilligrams=@pMilligrams where pID=@pID", Con);
                cmd.Parameters.AddWithValue("@pID", int.Parse(txt_p_edit_id.Text));
                cmd.Parameters.AddWithValue("@pQuantity", txt_p_edit_quantity.Text);
                cmd.Parameters.AddWithValue("@pTitle", txt_p_edit_title.Text);
                cmd.Parameters.AddWithValue("@pManDate", txt_p_edit_mandate.Text);
                cmd.Parameters.AddWithValue("@pExpDate", txt_p_edit_expdate.Text);
                cmd.Parameters.AddWithValue("@pBuyingPrice", txt_p_edit_bp.Text);
                cmd.Parameters.AddWithValue("@pSellingPrice", txt_p_edit_sp.Text);
                cmd.Parameters.AddWithValue("@pProfit", txt_p_edit_profit.Text);
                cmd.Parameters.AddWithValue("@pMilligrams", txt_p_edit_mg.Text);

                int i = cmd.ExecuteNonQuery();
                enableTextBox();

                if (i != 0)
                {
                    Con.Open();

                    MessageBox.Show("Product Updated Sucessfully");

                    clearAllText();
                    disableTextBox();

                    Con.Close();

                }
                else
                {
                    MessageBox.Show("Failed To Update! Try Again");
                }

                
                populate();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
           

        }

        private void clearAllText()
        {
            txt_p_edit_id.Text = String.Empty;
            txt_p_edit_title.Text = String.Empty;
            txt_p_edit_quantity.Text = String.Empty;
            txt_p_edit_mandate.Text = String.Empty;
            txt_p_edit_expdate.Text = String.Empty;
            txt_p_edit_bp.Text = String.Empty;
            txt_p_edit_sp.Text = String.Empty;
            txt_p_edit_profit.Text = String.Empty;
            txt_p_edit_mg.Text = String.Empty;
        }

        private void btn_p_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_p_edit_id.Text != "")
                {
                    if (MessageBox.Show("Are You Sure You Want to Delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Con.Open();
                        cmd = new SqlCommand("Delete productsTable where pID = '" + int.Parse(txt_p_edit_id.Text) + "'", Con);
                        cmd.ExecuteNonQuery();

                        enableTextBox();
                        MessageBox.Show("Product Sucessfully Deleted");
                        clearAllText();
                        populate();
                        //disableTextBox();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Product ID as shown in the Table!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
         
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearAllText();
            txt_p_edit_id.Text = String.Empty;
        }

        private void txt_p_edit_profit_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txt_p_edit_sp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int bp = int.Parse(txt_p_edit_bp.Text);
                int sp = int.Parse(txt_p_edit_sp.Text);
                int qt = int.Parse(txt_p_edit_quantity.Text);
                int bpTotal = 0;
                int spTotal = 0;
                int profit = 0;

                bpTotal = bp * qt;
                spTotal = sp * qt;

                profit = spTotal - bpTotal;

                String y = profit.ToString();
                txt_p_edit_profit.Text = y;

                
            }
            catch (Exception ex)
            {
               
            }
        }

        private void txt_p_edit_bp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int bp = int.Parse(txt_p_edit_bp.Text);
                int sp = int.Parse(txt_p_edit_sp.Text);
                int qt = int.Parse(txt_p_edit_quantity.Text);
                int bpTotal = 0;
                int spTotal = 0;
                int profit = 0;

                bpTotal = bp * qt;
                spTotal = sp * qt;

                profit = spTotal - bpTotal;

                String y = profit.ToString();

                txt_p_edit_profit.Text = y;

            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
