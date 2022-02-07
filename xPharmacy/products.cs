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
    public partial class products : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=AASHIQUMAR748C\\SQLEXPRESS;Initial Catalog=AppDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;


        public products()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            adpt = new SqlDataAdapter("select * from productsTable", Con);
            dt = new DataTable();
            adpt.Fill(dt);
            datagridview_products.DataSource = dt;

            stockCount();


            for (int i = 0; i < datagridview_products.Rows.Count; i++)
            {
                datagridview_products.Rows[i].Cells[1].Value.ToString();
            }

            for (int i = 0; i < datagridview_products.Rows.Count; i++)
            {
                datagridview_products.Rows[i].Cells[1].Value.ToString();
            }

            allRows();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            supplier sp = new supplier();
            sp.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Hide();
        }

        private void clearText()
        {
            txt_p_title.Text = String.Empty;
            txt_p_totalprofit.Text = String.Empty;
            txt_p_sp.Text = String.Empty;
            txt_p_quantity.Text = String.Empty;
            txt_p_profit.Text = String.Empty;
            txt_p_expdate.Text = String.Empty;
            txt_p_bp.Text = String.Empty;
            txt_p_mg.Text = String.Empty;
            txt_p_mandate.Text = String.Empty;

        }


        private void allRows()
        {
            int sum = 0;

            for (int i = 0; i < datagridview_products.Rows.Count; i++)
            {
                if (Convert.ToBoolean(datagridview_products.Rows[i].Cells[0].Value) == true)
                {
                    sum += int.Parse(datagridview_products.Rows[i].Cells[5].Value.ToString());
                }
            }

            txt_p_totalprofit.Text = sum.ToString();
        }

        private void stockCount()
        {
            Con.Open();

            String query = "select Count(*) from productsTable";
            cmd = new SqlCommand(query, Con);
            int count = (int)cmd.ExecuteScalar();
            txt_stock_count.Text = " "+count+" ";

            Con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void writeProducts()
        {
            try
            {
                Con.Open();

                cmd = new SqlCommand("insert into productsTable values('" + int.Parse(txt_p_mg.Text) + "','" + txt_p_title.Text + "','" + txt_p_quantity.Text + "','" + txt_p_bp.Text + "','" + txt_p_sp.Text + "','" + txt_p_profit.Text + "','" + txt_p_mandate + "','" + txt_p_expdate + "')", Con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("data saved!");
                populate();

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("");
            }
        }

        private void txt_p_addproduct_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO productsTable VALUES (@pTitle, @pQuantity, @pBuyingPrice, @pSellingPrice, @pProfit, @pManDate, @pExpDate, @pMilligrams)", Con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@pTitle", txt_p_title.Text);
                cmd.Parameters.AddWithValue("@pQuantity", txt_p_quantity.Text);
                cmd.Parameters.AddWithValue("@pBuyingPrice", txt_p_bp.Text);
                cmd.Parameters.AddWithValue("@pSellingPrice", txt_p_sp.Text);
                cmd.Parameters.AddWithValue("@pProfit", txt_p_profit.Text);
                cmd.Parameters.AddWithValue("@pManDate", txt_p_mandate.Text);
                cmd.Parameters.AddWithValue("@pExpDate", txt_p_expdate.Text);
                cmd.Parameters.AddWithValue("@pMilligrams", txt_p_mg.Text);

                Con.Open();
                cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Product Record Saved");
                clearText();

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Restarting!" + ex);
            }
            

            
        }

        private void btn_edit_products_Click(object sender, EventArgs e)
        {
            edit_products ep = new edit_products();
            ep.Show();
            this.Hide();
        }

        private void calculateProfit()
        {
            
        }

        private void txt_p_profit_TextChanged(object sender, EventArgs e)
        {
            


        }


        private void txt_p_bp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int bp = int.Parse(txt_p_bp.Text);
                int sp = int.Parse(txt_p_sp.Text);
                int qt = int.Parse(txt_p_quantity.Text);
                int bpTotal = 0;
                int spTotal = 0;
                int profit = 0;

                bpTotal = bp * qt;
                spTotal = sp * qt;

                profit = spTotal - bpTotal;

                String y = profit.ToString();

                txt_p_profit.Text = y;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Buying Price");
            }
            
        }

        private void txt_p_sp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void datagridview_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txt_p_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_p_totalprofit_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_total_profit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < datagridview_products.Rows.Count; i++)
            {
                datagridview_products.Rows[i].Cells[1].Value.ToString();
            }

            allRows();

        }


        private void txt_p_totalprofit_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            order_products op = new order_products();
            op.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Are You Sure You Want To Logout?", "Yes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                login lg = new login();
                lg.Show();
                this.Hide();
            }
        }

        private void txt_stock_count_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
