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
    public partial class approved_proposal : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=AASHIQUMAR748C\\SQLEXPRESS;Initial Catalog=AppDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public approved_proposal()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            adpt = new SqlDataAdapter("Select * from approvedTender", Con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1_approved.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate();
        }

        private void btn_return_supplier_Click(object sender, EventArgs e)
        {
            supplier_dashboard sd = new supplier_dashboard();
            sd.Show();
            this.Hide();
        }
    }
}
