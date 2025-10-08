namespace DoAN_CSDLNC
{
    partial class UCTableDashboard
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
            this.flpTableList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // flpTableList
            // 
            this.flpTableList.AutoScroll = true;
            this.flpTableList.Location = new System.Drawing.Point(3, 18);
            this.flpTableList.Name = "flpTableList";
            this.flpTableList.Padding = new System.Windows.Forms.Padding(20);
            this.flpTableList.Size = new System.Drawing.Size(1479, 750);
            this.flpTableList.TabIndex = 2;
            // 
            // UCTableDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpTableList);
            this.Controls.Add(this.label2);
            this.Name = "UCTableDashboard";
            this.Size = new System.Drawing.Size(1500, 800);
            this.Load += new System.EventHandler(this.UCTableDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpTableList;
    }
}
