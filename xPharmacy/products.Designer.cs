namespace xPharmacy
{
    partial class products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.txt_p_bp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_p_title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_p_quantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_p_sp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_p_profit = new System.Windows.Forms.TextBox();
            this.datagridview_products = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_p_mg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_p_mandate = new System.Windows.Forms.TextBox();
            this.txt_p_expdate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_edit_products = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_p_totalprofit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_stock_count = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_products)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add_product
            // 
            this.btn_add_product.BackColor = System.Drawing.Color.Orange;
            this.btn_add_product.FlatAppearance.BorderSize = 0;
            this.btn_add_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_product.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_product.ForeColor = System.Drawing.Color.White;
            this.btn_add_product.Location = new System.Drawing.Point(226, 213);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(620, 29);
            this.btn_add_product.TabIndex = 27;
            this.btn_add_product.Text = "Add Product";
            this.btn_add_product.UseVisualStyleBackColor = false;
            this.btn_add_product.Click += new System.EventHandler(this.txt_p_addproduct_Click);
            // 
            // txt_p_bp
            // 
            this.txt_p_bp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_bp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_bp.Location = new System.Drawing.Point(531, 163);
            this.txt_p_bp.Multiline = true;
            this.txt_p_bp.Name = "txt_p_bp";
            this.txt_p_bp.Size = new System.Drawing.Size(132, 29);
            this.txt_p_bp.TabIndex = 26;
            this.txt_p_bp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_p_bp.TextChanged += new System.EventHandler(this.txt_p_bp_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(450, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Buying Price";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_p_title
            // 
            this.txt_p_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_title.Location = new System.Drawing.Point(395, 60);
            this.txt_p_title.Multiline = true;
            this.txt_p_title.Name = "txt_p_title";
            this.txt_p_title.Size = new System.Drawing.Size(450, 29);
            this.txt_p_title.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(357, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(221, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Add Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(229, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Man. Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(425, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "Exp. Date";
            // 
            // txt_p_quantity
            // 
            this.txt_p_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_quantity.Location = new System.Drawing.Point(671, 112);
            this.txt_p_quantity.Multiline = true;
            this.txt_p_quantity.Name = "txt_p_quantity";
            this.txt_p_quantity.Size = new System.Drawing.Size(174, 29);
            this.txt_p_quantity.TabIndex = 32;
            this.txt_p_quantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(613, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Quantity";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(230, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 34;
            this.label10.Text = "Selling Price";
            // 
            // txt_p_sp
            // 
            this.txt_p_sp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_sp.Location = new System.Drawing.Point(307, 162);
            this.txt_p_sp.Multiline = true;
            this.txt_p_sp.Name = "txt_p_sp";
            this.txt_p_sp.Size = new System.Drawing.Size(137, 29);
            this.txt_p_sp.TabIndex = 35;
            this.txt_p_sp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_p_sp.TextChanged += new System.EventHandler(this.txt_p_sp_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(670, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 36;
            this.label11.Text = "Profit";
            // 
            // txt_p_profit
            // 
            this.txt_p_profit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_profit.Location = new System.Drawing.Point(715, 163);
            this.txt_p_profit.Multiline = true;
            this.txt_p_profit.Name = "txt_p_profit";
            this.txt_p_profit.Size = new System.Drawing.Size(129, 29);
            this.txt_p_profit.TabIndex = 37;
            this.txt_p_profit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_p_profit.TextChanged += new System.EventHandler(this.txt_p_profit_TextChanged);
            // 
            // datagridview_products
            // 
            this.datagridview_products.AllowUserToAddRows = false;
            this.datagridview_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview_products.BackgroundColor = System.Drawing.Color.White;
            this.datagridview_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_products.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview_products.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridview_products.Location = new System.Drawing.Point(226, 271);
            this.datagridview_products.Name = "datagridview_products";
            this.datagridview_products.Size = new System.Drawing.Size(614, 215);
            this.datagridview_products.TabIndex = 38;
            this.datagridview_products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_products_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(225, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 28);
            this.label5.TabIndex = 39;
            this.label5.Text = "Available Products";
            // 
            // txt_p_mg
            // 
            this.txt_p_mg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_mg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_mg.Location = new System.Drawing.Point(256, 60);
            this.txt_p_mg.Multiline = true;
            this.txt_p_mg.Name = "txt_p_mg";
            this.txt_p_mg.Size = new System.Drawing.Size(86, 29);
            this.txt_p_mg.TabIndex = 40;
            this.txt_p_mg.TextChanged += new System.EventHandler(this.txt_p_id_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(227, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "Mg.";
            // 
            // txt_p_mandate
            // 
            this.txt_p_mandate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_mandate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_mandate.Location = new System.Drawing.Point(299, 112);
            this.txt_p_mandate.Multiline = true;
            this.txt_p_mandate.Name = "txt_p_mandate";
            this.txt_p_mandate.Size = new System.Drawing.Size(106, 29);
            this.txt_p_mandate.TabIndex = 42;
            // 
            // txt_p_expdate
            // 
            this.txt_p_expdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_expdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_expdate.Location = new System.Drawing.Point(491, 112);
            this.txt_p_expdate.Multiline = true;
            this.txt_p_expdate.Name = "txt_p_expdate";
            this.txt_p_expdate.Size = new System.Drawing.Size(106, 29);
            this.txt_p_expdate.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(301, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 44;
            this.label12.Text = "*Eg. 00/00/0000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(489, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 12);
            this.label13.TabIndex = 45;
            this.label13.Text = "*Eg. 00/00/0000";
            // 
            // btn_edit_products
            // 
            this.btn_edit_products.BackColor = System.Drawing.Color.Red;
            this.btn_edit_products.FlatAppearance.BorderSize = 0;
            this.btn_edit_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_products.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_products.ForeColor = System.Drawing.Color.White;
            this.btn_edit_products.Location = new System.Drawing.Point(684, 494);
            this.btn_edit_products.Name = "btn_edit_products";
            this.btn_edit_products.Size = new System.Drawing.Size(162, 47);
            this.btn_edit_products.TabIndex = 46;
            this.btn_edit_products.Text = "Edit Products";
            this.btn_edit_products.UseVisualStyleBackColor = false;
            this.btn_edit_products.Click += new System.EventHandler(this.btn_edit_products_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.txt_p_totalprofit);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(226, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 47);
            this.panel2.TabIndex = 47;
            // 
            // txt_p_totalprofit
            // 
            this.txt_p_totalprofit.BackColor = System.Drawing.Color.Orange;
            this.txt_p_totalprofit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_p_totalprofit.Enabled = false;
            this.txt_p_totalprofit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_totalprofit.ForeColor = System.Drawing.Color.White;
            this.txt_p_totalprofit.Location = new System.Drawing.Point(103, 10);
            this.txt_p_totalprofit.Multiline = true;
            this.txt_p_totalprofit.Name = "txt_p_totalprofit";
            this.txt_p_totalprofit.Size = new System.Drawing.Size(112, 29);
            this.txt_p_totalprofit.TabIndex = 49;
            this.txt_p_totalprofit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_p_totalprofit.TextChanged += new System.EventHandler(this.txt_p_totalprofit_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(5, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 19);
            this.label14.TabIndex = 48;
            this.label14.Text = "Total Profit =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Products";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 79);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 51);
            this.button5.TabIndex = 11;
            this.button5.Text = "Dashboard";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 51);
            this.button2.TabIndex = 13;
            this.button2.Text = "Supplier";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(28, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 51);
            this.button3.TabIndex = 14;
            this.button3.Text = "Products";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 51);
            this.button4.TabIndex = 15;
            this.button4.Text = "Orders";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 546);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.BackgroundImage = global::xPharmacy.Properties.Resources.shopping_cart;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(19, 318);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 34);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.BackgroundImage = global::xPharmacy.Properties.Resources.delivery_box;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(37, 237);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 34);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BackgroundImage = global::xPharmacy.Properties.Resources.packages;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(23, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 34);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::xPharmacy.Properties.Resources.drugstore;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(19, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Controls.Add(this.txt_stock_count);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(453, 494);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 47);
            this.panel3.TabIndex = 50;
            // 
            // txt_stock_count
            // 
            this.txt_stock_count.BackColor = System.Drawing.Color.Orange;
            this.txt_stock_count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_stock_count.Enabled = false;
            this.txt_stock_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock_count.ForeColor = System.Drawing.Color.White;
            this.txt_stock_count.Location = new System.Drawing.Point(131, 10);
            this.txt_stock_count.Multiline = true;
            this.txt_stock_count.Name = "txt_stock_count";
            this.txt_stock_count.Size = new System.Drawing.Size(84, 29);
            this.txt_stock_count.TabIndex = 50;
            this.txt_stock_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_stock_count.TextChanged += new System.EventHandler(this.txt_stock_count_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(5, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 19);
            this.label15.TabIndex = 48;
            this.label15.Text = "Total Products =";
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 544);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_edit_products);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_p_expdate);
            this.Controls.Add(this.txt_p_mandate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_p_mg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datagridview_products);
            this.Controls.Add(this.txt_p_profit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_p_sp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_p_quantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_add_product);
            this.Controls.Add(this.txt_p_bp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_p_title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "products";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_products)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.TextBox txt_p_bp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_p_title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_p_quantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_p_sp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_p_profit;
        private System.Windows.Forms.DataGridView datagridview_products;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_p_mg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_p_mandate;
        private System.Windows.Forms.TextBox txt_p_expdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_edit_products;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_p_totalprofit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_stock_count;
        private System.Windows.Forms.Label label15;
    }
}