namespace DoAN_CSDLNC
{
    partial class StockHistoryForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSku = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cboAction = new System.Windows.Forms.ComboBox();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txt_Sku = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.Label();
            this.txt_Action = new System.Windows.Forms.Label();
            this.txt_From = new System.Windows.Forms.Label();
            this.txt_To = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(379, 14);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.Size = new System.Drawing.Size(571, 310);
            this.dgvHistory.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSku
            // 
            this.txtSku.Location = new System.Drawing.Point(114, 54);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(100, 22);
            this.txtSku.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(114, 100);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 22);
            this.txtUser.TabIndex = 3;
            // 
            // cboAction
            // 
            this.cboAction.FormattingEnabled = true;
            this.cboAction.Location = new System.Drawing.Point(114, 146);
            this.cboAction.Name = "cboAction";
            this.cboAction.Size = new System.Drawing.Size(121, 24);
            this.cboAction.TabIndex = 4;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(114, 204);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 22);
            this.dtFrom.TabIndex = 5;
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(114, 251);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 22);
            this.dtTo.TabIndex = 6;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(114, 313);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(859, 512);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txt_Sku
            // 
            this.txt_Sku.AutoSize = true;
            this.txt_Sku.Location = new System.Drawing.Point(13, 54);
            this.txt_Sku.Name = "txt_Sku";
            this.txt_Sku.Size = new System.Drawing.Size(88, 16);
            this.txt_Sku.TabIndex = 9;
            this.txt_Sku.Text = "Mã sản phẩm";
            // 
            // txt_User
            // 
            this.txt_User.AutoSize = true;
            this.txt_User.Location = new System.Drawing.Point(13, 100);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(65, 16);
            this.txt_User.TabIndex = 10;
            this.txt_User.Text = "Người lập";
            // 
            // txt_Action
            // 
            this.txt_Action.AutoSize = true;
            this.txt_Action.Location = new System.Drawing.Point(13, 149);
            this.txt_Action.Name = "txt_Action";
            this.txt_Action.Size = new System.Drawing.Size(60, 16);
            this.txt_Action.TabIndex = 11;
            this.txt_Action.Text = "Thao tác";
            // 
            // txt_From
            // 
            this.txt_From.AutoSize = true;
            this.txt_From.Location = new System.Drawing.Point(13, 204);
            this.txt_From.Name = "txt_From";
            this.txt_From.Size = new System.Drawing.Size(56, 16);
            this.txt_From.TabIndex = 12;
            this.txt_From.Text = "Từ ngày";
            // 
            // txt_To
            // 
            this.txt_To.AutoSize = true;
            this.txt_To.Location = new System.Drawing.Point(13, 251);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(64, 16);
            this.txt_To.TabIndex = 13;
            this.txt_To.Text = "Đến ngày";
            // 
            // StockHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 558);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.txt_From);
            this.Controls.Add(this.txt_Action);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.txt_Sku);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.cboAction);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtSku);
            this.Controls.Add(this.dgvHistory);
            this.Name = "StockHistoryForm";
            this.Text = "Lịch sử";
            this.Load += new System.EventHandler(this.StockHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ComboBox cboAction;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label txt_Sku;
        private System.Windows.Forms.Label txt_User;
        private System.Windows.Forms.Label txt_Action;
        private System.Windows.Forms.Label txt_From;
        private System.Windows.Forms.Label txt_To;
    }
}