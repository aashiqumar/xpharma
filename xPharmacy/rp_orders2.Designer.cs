namespace xPharmacy
{
    partial class rp_orders2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1_rejected = new System.Windows.Forms.DataGridView();
            this.btn_return_supplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_rejected)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 28);
            this.label2.TabIndex = 30;
            this.label2.Text = "Rejected Tender Proposals";
            // 
            // dataGridView1_rejected
            // 
            this.dataGridView1_rejected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_rejected.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1_rejected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1_rejected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_rejected.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1_rejected.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1_rejected.Location = new System.Drawing.Point(11, 54);
            this.dataGridView1_rejected.Name = "dataGridView1_rejected";
            this.dataGridView1_rejected.Size = new System.Drawing.Size(845, 467);
            this.dataGridView1_rejected.TabIndex = 29;
            this.dataGridView1_rejected.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_rejected_CellContentClick);
            // 
            // btn_return_supplier
            // 
            this.btn_return_supplier.BackColor = System.Drawing.Color.Transparent;
            this.btn_return_supplier.BackgroundImage = global::xPharmacy.Properties.Resources.next;
            this.btn_return_supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_return_supplier.FlatAppearance.BorderSize = 0;
            this.btn_return_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return_supplier.Location = new System.Drawing.Point(1, 2);
            this.btn_return_supplier.Name = "btn_return_supplier";
            this.btn_return_supplier.Size = new System.Drawing.Size(40, 37);
            this.btn_return_supplier.TabIndex = 28;
            this.btn_return_supplier.UseVisualStyleBackColor = false;
            this.btn_return_supplier.Click += new System.EventHandler(this.btn_return_supplier_Click);
            // 
            // rp_orders2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1_rejected);
            this.Controls.Add(this.btn_return_supplier);
            this.Name = "rp_orders2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rp_orders2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_rejected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1_rejected;
        private System.Windows.Forms.Button btn_return_supplier;
    }
}