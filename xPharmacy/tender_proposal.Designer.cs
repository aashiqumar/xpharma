namespace xPharmacy
{
    partial class tender_proposal
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
            this.label6 = new System.Windows.Forms.Label();
            this.datagridview_tender = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tpID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_reject = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pQuantity = new System.Windows.Forms.TextBox();
            this.pMg = new System.Windows.Forms.TextBox();
            this.pID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sCompany = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sContactNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_return_supplier = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_tender)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(37, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 28);
            this.label6.TabIndex = 52;
            this.label6.Text = "Tender Proposal";
            // 
            // datagridview_tender
            // 
            this.datagridview_tender.AllowUserToAddRows = false;
            this.datagridview_tender.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview_tender.BackgroundColor = System.Drawing.Color.White;
            this.datagridview_tender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview_tender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_tender.DefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview_tender.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridview_tender.Location = new System.Drawing.Point(12, 248);
            this.datagridview_tender.Name = "datagridview_tender";
            this.datagridview_tender.Size = new System.Drawing.Size(845, 284);
            this.datagridview_tender.TabIndex = 54;
            this.datagridview_tender.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_tender_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(15, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 1);
            this.panel2.TabIndex = 55;
            // 
            // tpID
            // 
            this.tpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpID.Location = new System.Drawing.Point(15, 81);
            this.tpID.Multiline = true;
            this.tpID.Name = "tpID";
            this.tpID.Size = new System.Drawing.Size(115, 29);
            this.tpID.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tender Proposal ID";
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_accept.FlatAppearance.BorderSize = 0;
            this.btn_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accept.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accept.ForeColor = System.Drawing.Color.White;
            this.btn_accept.Location = new System.Drawing.Point(15, 118);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(230, 43);
            this.btn_accept.TabIndex = 72;
            this.btn_accept.Text = "Accept Proposal";
            this.btn_accept.UseVisualStyleBackColor = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_s_search_Click);
            // 
            // btn_reject
            // 
            this.btn_reject.BackColor = System.Drawing.Color.Crimson;
            this.btn_reject.FlatAppearance.BorderSize = 0;
            this.btn_reject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reject.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reject.ForeColor = System.Drawing.Color.White;
            this.btn_reject.Location = new System.Drawing.Point(15, 167);
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.Size = new System.Drawing.Size(230, 45);
            this.btn_reject.TabIndex = 73;
            this.btn_reject.Text = "Reject Proposal";
            this.btn_reject.UseVisualStyleBackColor = false;
            this.btn_reject.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(136, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 29);
            this.button2.TabIndex = 74;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(350, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 15);
            this.label13.TabIndex = 86;
            this.label13.Text = "Product Title";
            // 
            // pTitle
            // 
            this.pTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTitle.Enabled = false;
            this.pTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTitle.Location = new System.Drawing.Point(350, 31);
            this.pTitle.Multiline = true;
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(198, 29);
            this.pTitle.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(278, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 83;
            this.label5.Text = "Description";
            // 
            // pDescription
            // 
            this.pDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDescription.Enabled = false;
            this.pDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pDescription.Location = new System.Drawing.Point(277, 136);
            this.pDescription.Multiline = true;
            this.pDescription.Name = "pDescription";
            this.pDescription.Size = new System.Drawing.Size(271, 77);
            this.pDescription.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(411, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 81;
            this.label3.Text = "Product Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(277, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 80;
            this.label2.Text = "Product Mg";
            // 
            // pQuantity
            // 
            this.pQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pQuantity.Enabled = false;
            this.pQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pQuantity.Location = new System.Drawing.Point(413, 81);
            this.pQuantity.Multiline = true;
            this.pQuantity.Name = "pQuantity";
            this.pQuantity.Size = new System.Drawing.Size(135, 29);
            this.pQuantity.TabIndex = 79;
            // 
            // pMg
            // 
            this.pMg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMg.Enabled = false;
            this.pMg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pMg.Location = new System.Drawing.Point(277, 81);
            this.pMg.Multiline = true;
            this.pMg.Name = "pMg";
            this.pMg.Size = new System.Drawing.Size(130, 29);
            this.pMg.TabIndex = 78;
            // 
            // pID
            // 
            this.pID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pID.Enabled = false;
            this.pID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pID.Location = new System.Drawing.Point(277, 31);
            this.pID.Multiline = true;
            this.pID.Name = "pID";
            this.pID.Size = new System.Drawing.Size(67, 29);
            this.pID.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(277, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 76;
            this.label4.Text = "Product ID";
            // 
            // sId
            // 
            this.sId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sId.Enabled = false;
            this.sId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sId.Location = new System.Drawing.Point(570, 31);
            this.sId.Multiline = true;
            this.sId.Name = "sId";
            this.sId.Size = new System.Drawing.Size(69, 29);
            this.sId.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(569, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 88;
            this.label7.Text = "Supplier ID";
            // 
            // sName
            // 
            this.sName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sName.Enabled = false;
            this.sName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sName.Location = new System.Drawing.Point(645, 31);
            this.sName.Multiline = true;
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(212, 29);
            this.sName.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(642, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 90;
            this.label9.Text = "Your Name";
            // 
            // sCompany
            // 
            this.sCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sCompany.Enabled = false;
            this.sCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sCompany.Location = new System.Drawing.Point(570, 81);
            this.sCompany.Multiline = true;
            this.sCompany.Name = "sCompany";
            this.sCompany.Size = new System.Drawing.Size(287, 29);
            this.sCompany.TabIndex = 91;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(571, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 92;
            this.label10.Text = "Company";
            // 
            // sContactNo
            // 
            this.sContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sContactNo.Enabled = false;
            this.sContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sContactNo.Location = new System.Drawing.Point(570, 134);
            this.sContactNo.Multiline = true;
            this.sContactNo.Name = "sContactNo";
            this.sContactNo.Size = new System.Drawing.Size(287, 29);
            this.sContactNo.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(571, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 94;
            this.label11.Text = "Contact No.";
            // 
            // sEmail
            // 
            this.sEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sEmail.Enabled = false;
            this.sEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sEmail.Location = new System.Drawing.Point(570, 183);
            this.sEmail.Multiline = true;
            this.sEmail.Name = "sEmail";
            this.sEmail.Size = new System.Drawing.Size(287, 29);
            this.sEmail.TabIndex = 95;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(572, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 15);
            this.label12.TabIndex = 96;
            this.label12.Text = "Email";
            // 
            // btn_return_supplier
            // 
            this.btn_return_supplier.BackColor = System.Drawing.Color.Transparent;
            this.btn_return_supplier.BackgroundImage = global::xPharmacy.Properties.Resources.next;
            this.btn_return_supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_return_supplier.FlatAppearance.BorderSize = 0;
            this.btn_return_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return_supplier.Location = new System.Drawing.Point(0, 2);
            this.btn_return_supplier.Name = "btn_return_supplier";
            this.btn_return_supplier.Size = new System.Drawing.Size(40, 37);
            this.btn_return_supplier.TabIndex = 22;
            this.btn_return_supplier.UseVisualStyleBackColor = false;
            this.btn_return_supplier.Click += new System.EventHandler(this.btn_return_supplier_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 21);
            this.label8.TabIndex = 97;
            this.label8.Text = "Current Proposals";
            // 
            // tender_proposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 544);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sContactNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sCompany);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pQuantity);
            this.Controls.Add(this.pMg);
            this.Controls.Add(this.pID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_reject);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tpID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datagridview_tender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_return_supplier);
            this.Name = "tender_proposal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tender_proposal";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_tender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_return_supplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView datagridview_tender;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tpID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_reject;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox pTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pQuantity;
        private System.Windows.Forms.TextBox pMg;
        private System.Windows.Forms.TextBox pID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sCompany;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sContactNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
    }
}