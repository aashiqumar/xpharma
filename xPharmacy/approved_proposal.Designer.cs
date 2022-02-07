namespace xPharmacy
{
    partial class approved_proposal
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
            this.btn_return_supplier = new System.Windows.Forms.Button();
            this.dataGridView1_approved = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_approved)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_return_supplier
            // 
            this.btn_return_supplier.BackColor = System.Drawing.Color.Transparent;
            this.btn_return_supplier.BackgroundImage = global::xPharmacy.Properties.Resources.next;
            this.btn_return_supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_return_supplier.FlatAppearance.BorderSize = 0;
            this.btn_return_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return_supplier.Location = new System.Drawing.Point(2, 3);
            this.btn_return_supplier.Name = "btn_return_supplier";
            this.btn_return_supplier.Size = new System.Drawing.Size(40, 37);
            this.btn_return_supplier.TabIndex = 22;
            this.btn_return_supplier.UseVisualStyleBackColor = false;
            this.btn_return_supplier.Click += new System.EventHandler(this.btn_return_supplier_Click);
            // 
            // dataGridView1_approved
            // 
            this.dataGridView1_approved.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_approved.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1_approved.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1_approved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_approved.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1_approved.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1_approved.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1_approved.Name = "dataGridView1_approved";
            this.dataGridView1_approved.Size = new System.Drawing.Size(845, 467);
            this.dataGridView1_approved.TabIndex = 23;
            this.dataGridView1_approved.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Approved Tender Proposals";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // approved_proposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1_approved);
            this.Controls.Add(this.btn_return_supplier);
            this.Name = "approved_proposal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "approved_proposal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_approved)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_return_supplier;
        private System.Windows.Forms.DataGridView dataGridView1_approved;
        private System.Windows.Forms.Label label2;
    }
}