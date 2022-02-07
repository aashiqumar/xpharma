namespace xPharmacy
{
    partial class supplier_dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.datagridview_pending_products = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_s_send = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_p_id = new System.Windows.Forms.TextBox();
            this.txt_s_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_p_mg = new System.Windows.Forms.TextBox();
            this.txt_p_quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_p_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1_suppliers = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_s_search = new System.Windows.Forms.Button();
            this.txt_p_title = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_s_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_s_company = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_s_no = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_s_email = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_return_supplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_pending_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_suppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(309, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 54;
            this.label8.Text = "Suppliers";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // datagridview_pending_products
            // 
            this.datagridview_pending_products.AllowUserToAddRows = false;
            this.datagridview_pending_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview_pending_products.BackgroundColor = System.Drawing.Color.White;
            this.datagridview_pending_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview_pending_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_pending_products.DefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview_pending_products.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridview_pending_products.Location = new System.Drawing.Point(309, 67);
            this.datagridview_pending_products.Name = "datagridview_pending_products";
            this.datagridview_pending_products.Size = new System.Drawing.Size(545, 189);
            this.datagridview_pending_products.TabIndex = 53;
            this.datagridview_pending_products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_pending_products_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(38, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 28);
            this.label6.TabIndex = 51;
            this.label6.Text = "Supplier Dashboard";
            // 
            // btn_s_send
            // 
            this.btn_s_send.BackColor = System.Drawing.Color.Orange;
            this.btn_s_send.FlatAppearance.BorderSize = 0;
            this.btn_s_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_s_send.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_s_send.ForeColor = System.Drawing.Color.White;
            this.btn_s_send.Location = new System.Drawing.Point(12, 501);
            this.btn_s_send.Name = "btn_s_send";
            this.btn_s_send.Size = new System.Drawing.Size(271, 29);
            this.btn_s_send.TabIndex = 49;
            this.btn_s_send.Text = "Send Request";
            this.btn_s_send.UseVisualStyleBackColor = false;
            this.btn_s_send.Click += new System.EventHandler(this.btn_s_send_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Product ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_p_id
            // 
            this.txt_p_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_id.Location = new System.Drawing.Point(12, 65);
            this.txt_p_id.Multiline = true;
            this.txt_p_id.Name = "txt_p_id";
            this.txt_p_id.Size = new System.Drawing.Size(88, 29);
            this.txt_p_id.TabIndex = 56;
            // 
            // txt_s_id
            // 
            this.txt_s_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_s_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_s_id.Location = new System.Drawing.Point(12, 300);
            this.txt_s_id.Multiline = true;
            this.txt_s_id.Name = "txt_s_id";
            this.txt_s_id.Size = new System.Drawing.Size(88, 29);
            this.txt_s_id.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "Your ID";
            // 
            // txt_p_mg
            // 
            this.txt_p_mg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_mg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_mg.Location = new System.Drawing.Point(12, 172);
            this.txt_p_mg.Multiline = true;
            this.txt_p_mg.Name = "txt_p_mg";
            this.txt_p_mg.Size = new System.Drawing.Size(130, 29);
            this.txt_p_mg.TabIndex = 59;
            // 
            // txt_p_quantity
            // 
            this.txt_p_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_quantity.Location = new System.Drawing.Point(148, 172);
            this.txt_p_quantity.Multiline = true;
            this.txt_p_quantity.Name = "txt_p_quantity";
            this.txt_p_quantity.Size = new System.Drawing.Size(135, 29);
            this.txt_p_quantity.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "Product Mg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(146, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 62;
            this.label3.Text = "Product Quantity";
            // 
            // txt_p_description
            // 
            this.txt_p_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_description.Location = new System.Drawing.Point(12, 227);
            this.txt_p_description.Multiline = true;
            this.txt_p_description.Name = "txt_p_description";
            this.txt_p_description.Size = new System.Drawing.Size(271, 42);
            this.txt_p_description.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 64;
            this.label5.Text = "Description";
            // 
            // dataGridView1_suppliers
            // 
            this.dataGridView1_suppliers.AllowUserToAddRows = false;
            this.dataGridView1_suppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_suppliers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1_suppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_suppliers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1_suppliers.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1_suppliers.Location = new System.Drawing.Point(313, 281);
            this.dataGridView1_suppliers.Name = "dataGridView1_suppliers";
            this.dataGridView1_suppliers.Size = new System.Drawing.Size(545, 249);
            this.dataGridView1_suppliers.TabIndex = 65;
            this.dataGridView1_suppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_suppliers_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(309, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 19);
            this.label7.TabIndex = 66;
            this.label7.Text = "Product Tender Requests";
            // 
            // btn_s_search
            // 
            this.btn_s_search.BackColor = System.Drawing.Color.Orange;
            this.btn_s_search.FlatAppearance.BorderSize = 0;
            this.btn_s_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_s_search.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_s_search.ForeColor = System.Drawing.Color.White;
            this.btn_s_search.Location = new System.Drawing.Point(106, 65);
            this.btn_s_search.Name = "btn_s_search";
            this.btn_s_search.Size = new System.Drawing.Size(177, 29);
            this.btn_s_search.TabIndex = 71;
            this.btn_s_search.Text = "Read";
            this.btn_s_search.UseVisualStyleBackColor = false;
            this.btn_s_search.Click += new System.EventHandler(this.btn_s_search_Click);
            // 
            // txt_p_title
            // 
            this.txt_p_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_title.Location = new System.Drawing.Point(12, 117);
            this.txt_p_title.Multiline = true;
            this.txt_p_title.Name = "txt_p_title";
            this.txt_p_title.Size = new System.Drawing.Size(271, 29);
            this.txt_p_title.TabIndex = 72;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(12, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 15);
            this.label13.TabIndex = 73;
            this.label13.Text = "Product Title";
            // 
            // txt_s_name
            // 
            this.txt_s_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_s_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_s_name.Location = new System.Drawing.Point(12, 351);
            this.txt_s_name.Multiline = true;
            this.txt_s_name.Name = "txt_s_name";
            this.txt_s_name.Size = new System.Drawing.Size(271, 29);
            this.txt_s_name.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 77;
            this.label9.Text = "Your Name";
            // 
            // txt_s_company
            // 
            this.txt_s_company.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_s_company.Enabled = false;
            this.txt_s_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_s_company.Location = new System.Drawing.Point(12, 401);
            this.txt_s_company.Multiline = true;
            this.txt_s_company.Name = "txt_s_company";
            this.txt_s_company.Size = new System.Drawing.Size(271, 29);
            this.txt_s_company.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 79;
            this.label10.Text = "Company";
            // 
            // txt_s_no
            // 
            this.txt_s_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_s_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_s_no.Location = new System.Drawing.Point(12, 458);
            this.txt_s_no.Multiline = true;
            this.txt_s_no.Name = "txt_s_no";
            this.txt_s_no.Size = new System.Drawing.Size(130, 29);
            this.txt_s_no.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(13, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 81;
            this.label11.Text = "Contact No.";
            // 
            // txt_s_email
            // 
            this.txt_s_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_s_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_s_email.Location = new System.Drawing.Point(153, 458);
            this.txt_s_email.Multiline = true;
            this.txt_s_email.Name = "txt_s_email";
            this.txt_s_email.Size = new System.Drawing.Size(130, 29);
            this.txt_s_email.TabIndex = 82;
            this.txt_s_email.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(152, 442);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 15);
            this.label12.TabIndex = 83;
            this.label12.Text = "Email";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(106, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 29);
            this.button1.TabIndex = 84;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(305, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 29);
            this.button2.TabIndex = 85;
            this.button2.Text = "Approved Proposals";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(584, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(274, 29);
            this.button3.TabIndex = 86;
            this.button3.Text = "Rejected Proposals";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_return_supplier
            // 
            this.btn_return_supplier.BackColor = System.Drawing.Color.Transparent;
            this.btn_return_supplier.BackgroundImage = global::xPharmacy.Properties.Resources.next;
            this.btn_return_supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_return_supplier.FlatAppearance.BorderSize = 0;
            this.btn_return_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return_supplier.Location = new System.Drawing.Point(2, 6);
            this.btn_return_supplier.Name = "btn_return_supplier";
            this.btn_return_supplier.Size = new System.Drawing.Size(40, 37);
            this.btn_return_supplier.TabIndex = 55;
            this.btn_return_supplier.UseVisualStyleBackColor = false;
            this.btn_return_supplier.Click += new System.EventHandler(this.btn_return_supplier_Click);
            // 
            // supplier_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 544);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_s_email);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_s_no);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_s_company);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_s_name);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_p_title);
            this.Controls.Add(this.btn_s_search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1_suppliers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_p_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_p_quantity);
            this.Controls.Add(this.txt_p_mg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_s_id);
            this.Controls.Add(this.txt_p_id);
            this.Controls.Add(this.btn_return_supplier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datagridview_pending_products);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_s_send);
            this.Controls.Add(this.label4);
            this.Name = "supplier_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "supplier_dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_pending_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_suppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView datagridview_pending_products;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_s_send;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_return_supplier;
        private System.Windows.Forms.TextBox txt_p_id;
        private System.Windows.Forms.TextBox txt_s_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_p_mg;
        private System.Windows.Forms.TextBox txt_p_quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_p_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1_suppliers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_s_search;
        private System.Windows.Forms.TextBox txt_p_title;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_s_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_s_company;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_s_no;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_s_email;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}