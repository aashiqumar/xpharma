using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xPharmacy
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_s_fullname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btn_login;

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            

            if(txt_l_passcode.Text == "spc123")
            {
                dashboard db = new dashboard();
                db.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }

           
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_return_supplier_Click(object sender, EventArgs e)
        {
            first_page fp = new first_page();
            fp.Show();
            this.Hide();
        }
    }
}
