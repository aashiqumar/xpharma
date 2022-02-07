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
    public partial class rejected_proposals : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=AASHIQUMAR748C\\SQLEXPRESS;Initial Catalog=AppDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public rejected_proposals()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            adpt = new SqlDataAdapter("Select * from rejectedTender", Con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1_rejected.DataSource = dt;
        }



        private void dataGridView1_approved_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
