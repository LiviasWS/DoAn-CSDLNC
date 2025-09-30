namespace DoAN_CSDLNC.Views
{
    partial class UCCategoryLabel
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
            this.lTittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lTittle
            // 
            this.lTittle.AutoSize = true;
            this.lTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lTittle.ForeColor = System.Drawing.Color.Peru;
            this.lTittle.Location = new System.Drawing.Point(3, 28);
            this.lTittle.Name = "lTittle";
            this.lTittle.Size = new System.Drawing.Size(149, 29);
            this.lTittle.TabIndex = 0;
            this.lTittle.Text = "Titile Name";
            // 
            // UCCategoryLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lTittle);
            this.Name = "UCCategoryLabel";
            this.Size = new System.Drawing.Size(905, 71);
            this.Load += new System.EventHandler(this.UCCategoryLabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTittle;
    }
}
