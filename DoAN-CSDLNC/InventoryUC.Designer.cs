namespace DoAN_CSDLNC
{
    partial class InventoryUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSearchCriteria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "KHO HÀNG";
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(3, 99);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(1484, 433);
            this.dgvInventory.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(557, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 23);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cbSearchCriteria
            // 
            this.cbSearchCriteria.FormattingEnabled = true;
            this.cbSearchCriteria.Location = new System.Drawing.Point(188, 50);
            this.cbSearchCriteria.Name = "cbSearchCriteria";
            this.cbSearchCriteria.Size = new System.Drawing.Size(157, 24);
            this.cbSearchCriteria.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tìm kiếm theo tiêu chí:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(351, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(199, 22);
            this.txtSearch.TabIndex = 21;
            // 
            // InventoryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearchCriteria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInventory);
            this.Name = "InventoryUC";
            this.Size = new System.Drawing.Size(1490, 538);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearchCriteria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
