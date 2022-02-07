namespace xPharmacy
{
    partial class edit_products
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
            this.btn_p_search = new System.Windows.Forms.Button();
            this.btn_p_delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_p_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_p_edit_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_p_edit_profit = new System.Windows.Forms.TextBox();
            this.txt_p_edit_bp = new System.Windows.Forms.TextBox();
            this.txt_p_edit_quantity = new System.Windows.Forms.TextBox();
            this.txt_p_edit_mandate = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_return_supplier = new System.Windows.Forms.Button();
            this.txt_p_edit_expdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_p_edit_title = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_p_edit_sp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_p_edit_mg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_p_search
            // 
            this.btn_p_search.BackColor = System.Drawing.Color.Orange;
            this.btn_p_search.FlatAppearance.BorderSize = 0;
            this.btn_p_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_p_search.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_p_search.ForeColor = System.Drawing.Color.White;
            this.btn_p_search.Location = new System.Drawing.Point(96, 192);
            this.btn_p_search.Name = "btn_p_search";
            this.btn_p_search.Size = new System.Drawing.Size(110, 29);
            this.btn_p_search.TabIndex = 43;
            this.btn_p_search.Text = "Search";
            this.btn_p_search.UseVisualStyleBackColor = false;
            this.btn_p_search.Click += new System.EventHandler(this.btn_s_search_Click);
            // 
            // btn_p_delete
            // 
            this.btn_p_delete.BackColor = System.Drawing.Color.Orange;
            this.btn_p_delete.FlatAppearance.BorderSize = 0;
            this.btn_p_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_p_delete.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_p_delete.ForeColor = System.Drawing.Color.White;
            this.btn_p_delete.Location = new System.Drawing.Point(149, 503);
            this.btn_p_delete.Name = "btn_p_delete";
            this.btn_p_delete.Size = new System.Drawing.Size(122, 29);
            this.btn_p_delete.TabIndex = 42;
            this.btn_p_delete.Text = "Delete";
            this.btn_p_delete.UseVisualStyleBackColor = false;
            this.btn_p_delete.Click += new System.EventHandler(this.btn_p_delete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(45, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Edit Products";
            // 
            // btn_p_save
            // 
            this.btn_p_save.BackColor = System.Drawing.Color.Orange;
            this.btn_p_save.FlatAppearance.BorderSize = 0;
            this.btn_p_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_p_save.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_p_save.ForeColor = System.Drawing.Color.White;
            this.btn_p_save.Location = new System.Drawing.Point(12, 503);
            this.btn_p_save.Name = "btn_p_save";
            this.btn_p_save.Size = new System.Drawing.Size(122, 29);
            this.btn_p_save.TabIndex = 40;
            this.btn_p_save.Text = "Save";
            this.btn_p_save.UseVisualStyleBackColor = false;
            this.btn_p_save.Click += new System.EventHandler(this.btn_p_save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(55, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 14);
            this.label7.TabIndex = 39;
            this.label7.Text = "*Please Provide SID and Click Search!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Buying Price";
            // 
            // txt_p_edit_id
            // 
            this.txt_p_edit_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_edit_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_edit_id.Location = new System.Drawing.Point(12, 192);
            this.txt_p_edit_id.Multiline = true;
            this.txt_p_edit_id.Name = "txt_p_edit_id";
            this.txt_p_edit_id.Size = new System.Drawing.Size(78, 29);
            this.txt_p_edit_id.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "ID No.";
            // 
            // txt_p_edit_profit
            // 
            this.txt_p_edit_profit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_edit_profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_edit_profit.Location = new System.Drawing.Point(149, 457);
            this.txt_p_edit_profit.Multiline = true;
            this.txt_p_edit_profit.Name = "txt_p_edit_profit";
            this.txt_p_edit_profit.Size = new System.Drawing.Size(122, 29);
            this.txt_p_edit_profit.TabIndex = 32;
            this.txt_p_edit_profit.TextChanged += new System.EventHandler(this.txt_p_edit_profit_TextChanged);
            // 
            // txt_p_edit_bp
            // 
            this.txt_p_edit_bp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_edit_bp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_edit_bp.Location = new System.Drawing.Point(12, 408);
            this.txt_p_edit_bp.Multiline = true;
            this.txt_p_edit_bp.Name = "txt_p_edit_bp";
            this.txt_p_edit_bp.Size = new System.Drawing.Size(122, 29);
            this.txt_p_edit_bp.TabIndex = 31;
            this.txt_p_edit_bp.TextChanged += new System.EventHandler(this.txt_p_edit_bp_TextChanged);
            // 
            // txt_p_edit_quantity
            // 
            this.txt_p_edit_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_edit_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_edit_quantity.Location = new System.Drawing.Point(12, 349);
            this.txt_p_edit_quantity.Multiline = true;
            this.txt_p_edit_quantity.Name = "txt_p_edit_quantity";
            this.txt_p_edit_quantity.Size = new System.Drawing.Size(122, 29);
            this.txt_p_edit_quantity.TabIndex = 30;
            this.txt_p_edit_quantity.TextChanged += new System.EventHandler(this.txt_s_edit_mobile_TextChanged);
            // 
            // txt_p_edit_mandate
            // 
            this.txt_p_edit_mandate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_edit_mandate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_edit_mandate.Location = new System.Drawing.Point(12, 297);
            this.txt_p_edit_mandate.Multiline = true;
            this.txt_p_edit_mandate.Name = "txt_p_edit_mandate";
            this.txt_p_edit_mandate.Size = new System.Drawing.Size(122, 29);
            this.txt_p_edit_mandate.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::xPharmacy.Properties.Resources.shopping_cart;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = global::xPharmacy.Properties.Resources.shopping_cart;
            this.pictureBox1.Location = new System.Drawing.Point(67, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 110);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btn_return_supplier
            // 
            this.btn_return_supplier.BackColor = System.Drawing.Color.Transparent;
            this.btn_return_supplier.BackgroundImage = global::xPharmacy.Properties.Resources.next;
            this.btn_return_supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_return_supplier.FlatAppearance.BorderSize = 0;
            this.btn_return_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return_supplier.Location = new System.Drawing.Point(7, 8);
            this.btn_return_supplier.Name = "btn_return_supplier";
            this.btn_return_supplier.Size = new System.Drawing.Size(40, 37);
            this.btn_return_supplier.TabIndex = 28;
            this.btn_return_supplier.UseVisualStyleBackColor = false;
            this.btn_return_supplier.Click += new System.EventHandler(this.btn_return_supplier_Click);
            // 
            // txt_p_edit_expdate
            // 
            this.txt_p_edit_expdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_edit_expdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_edit_expdate.Location = new System.Drawing.Point(149, 297);
            this.txt_p_edit_expdate.Multiline = true;
            this.txt_p_edit_expdate.Name = "txt_p_edit_expdate";
            this.txt_p_edit_expdate.Size = new System.Drawing.Size(122, 29);
            this.txt_p_edit_expdate.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "Man. Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(146, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "Exp. Date";
            // 
            // txt_p_edit_title
            // 
            this.txt_p_edit_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_edit_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_edit_title.Location = new System.Drawing.Point(12, 244);
            this.txt_p_edit_title.Multiline = true;
            this.txt_p_edit_title.Name = "txt_p_edit_title";
            this.txt_p_edit_title.Size = new System.Drawing.Size(259, 29);
            this.txt_p_edit_title.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 48;
            this.label9.Text = "Title";
            // 
            // txt_p_edit_sp
            // 
            this.txt_p_edit_sp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_edit_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_edit_sp.Location = new System.Drawing.Point(149, 408);
            this.txt_p_edit_sp.Multiline = true;
            this.txt_p_edit_sp.Name = "txt_p_edit_sp";
            this.txt_p_edit_sp.Size = new System.Drawing.Size(122, 29);
            this.txt_p_edit_sp.TabIndex = 49;
            this.txt_p_edit_sp.TextChanged += new System.EventHandler(this.txt_p_edit_sp_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(149, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 50;
            this.label10.Text = "Selling Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(85, 461);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 21);
            this.label11.TabIndex = 51;
            this.label11.Text = "Profit";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(284, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(578, 481);
            this.dataGridView2.TabIndex = 52;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(212, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 29);
            this.button1.TabIndex = 53;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "Quantity";
            // 
            // txt_p_edit_mg
            // 
            this.txt_p_edit_mg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_p_edit_mg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_edit_mg.Location = new System.Drawing.Point(149, 349);
            this.txt_p_edit_mg.Multiline = true;
            this.txt_p_edit_mg.Name = "txt_p_edit_mg";
            this.txt_p_edit_mg.Size = new System.Drawing.Size(122, 29);
            this.txt_p_edit_mg.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(151, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 56;
            this.label6.Text = "Milligrams";
            // 
            // edit_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 544);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_p_edit_mg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_p_edit_sp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_p_edit_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_p_edit_expdate);
            this.Controls.Add(this.btn_p_search);
            this.Controls.Add(this.btn_p_delete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_p_save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_p_edit_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_p_edit_profit);
            this.Controls.Add(this.txt_p_edit_bp);
            this.Controls.Add(this.txt_p_edit_quantity);
            this.Controls.Add(this.txt_p_edit_mandate);
            this.Controls.Add(this.btn_return_supplier);
            this.Name = "edit_products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edit_products";
            this.Load += new System.EventHandler(this.edit_products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_p_search;
        private System.Windows.Forms.Button btn_p_delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_p_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_p_edit_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_p_edit_profit;
        private System.Windows.Forms.TextBox txt_p_edit_bp;
        private System.Windows.Forms.TextBox txt_p_edit_quantity;
        private System.Windows.Forms.TextBox txt_p_edit_mandate;
        private System.Windows.Forms.Button btn_return_supplier;
        private System.Windows.Forms.TextBox txt_p_edit_expdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_p_edit_title;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_p_edit_sp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_p_edit_mg;
        private System.Windows.Forms.Label label6;
    }
}