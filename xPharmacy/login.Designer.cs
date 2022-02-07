namespace xPharmacy
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_passcode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_l_passcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_return_supplier = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(596, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 66);
            this.label2.TabIndex = 13;
            this.label2.Text = "SPC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(547, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "State Pharmacutecial Cooperation";
            // 
            // txt_passcode
            // 
            this.txt_passcode.BackColor = System.Drawing.Color.Orange;
            this.txt_passcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_passcode.Enabled = false;
            this.txt_passcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passcode.ForeColor = System.Drawing.Color.Black;
            this.txt_passcode.Location = new System.Drawing.Point(446, 245);
            this.txt_passcode.Multiline = true;
            this.txt_passcode.Name = "txt_passcode";
            this.txt_passcode.Size = new System.Drawing.Size(405, 42);
            this.txt_passcode.TabIndex = 14;
            this.txt_passcode.TextChanged += new System.EventHandler(this.txt_s_fullname_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Orange;
            this.pictureBox1.BackgroundImage = global::xPharmacy.Properties.Resources.taxi_veterinar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 544);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txt_l_passcode
            // 
            this.txt_l_passcode.BackColor = System.Drawing.Color.White;
            this.txt_l_passcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_l_passcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_l_passcode.ForeColor = System.Drawing.Color.Black;
            this.txt_l_passcode.Location = new System.Drawing.Point(0, 9);
            this.txt_l_passcode.Multiline = true;
            this.txt_l_passcode.Name = "txt_l_passcode";
            this.txt_l_passcode.PasswordChar = '*';
            this.txt_l_passcode.Size = new System.Drawing.Size(401, 24);
            this.txt_l_passcode.TabIndex = 16;
            this.txt_l_passcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_l_passcode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(617, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Enter Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Orange;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(446, 304);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(405, 32);
            this.btn_login.TabIndex = 20;
            this.btn_login.Text = "   LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_return_supplier
            // 
            this.btn_return_supplier.BackColor = System.Drawing.Color.Transparent;
            this.btn_return_supplier.BackgroundImage = global::xPharmacy.Properties.Resources.next;
            this.btn_return_supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_return_supplier.FlatAppearance.BorderSize = 0;
            this.btn_return_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return_supplier.Location = new System.Drawing.Point(428, 4);
            this.btn_return_supplier.Name = "btn_return_supplier";
            this.btn_return_supplier.Size = new System.Drawing.Size(40, 37);
            this.btn_return_supplier.TabIndex = 21;
            this.btn_return_supplier.UseVisualStyleBackColor = false;
            this.btn_return_supplier.Click += new System.EventHandler(this.btn_return_supplier_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(565, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "V 1.0 and Powered by KD/HDCSE/50/22";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_l_passcode);
            this.panel1.Location = new System.Drawing.Point(448, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 38);
            this.panel1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(465, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 33);
            this.label5.TabIndex = 24;
            this.label5.Text = "Login";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 544);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_return_supplier);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_passcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "singup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_passcode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_l_passcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_return_supplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}