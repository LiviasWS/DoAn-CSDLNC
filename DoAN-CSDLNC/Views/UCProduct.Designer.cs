namespace DoAN_CSDLNC.Views
{
    partial class UCProduct
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lName = new System.Windows.Forms.Label();
            this.pHighLight = new System.Windows.Forms.Panel();
            this.lChoose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(23, 21);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(92, 75);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // lName
            // 
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lName.ForeColor = System.Drawing.Color.Peru;
            this.lName.Location = new System.Drawing.Point(121, 21);
            this.lName.MaximumSize = new System.Drawing.Size(200, 22);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(200, 22);
            this.lName.TabIndex = 1;
            this.lName.Text = "Name";
            // 
            // pHighLight
            // 
            this.pHighLight.BackColor = System.Drawing.Color.BurlyWood;
            this.pHighLight.Location = new System.Drawing.Point(125, 46);
            this.pHighLight.Name = "pHighLight";
            this.pHighLight.Size = new System.Drawing.Size(190, 3);
            this.pHighLight.TabIndex = 2;
            // 
            // lChoose
            // 
            this.lChoose.AutoSize = true;
            this.lChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lChoose.ForeColor = System.Drawing.Color.Tan;
            this.lChoose.Location = new System.Drawing.Point(248, 78);
            this.lChoose.Name = "lChoose";
            this.lChoose.Size = new System.Drawing.Size(67, 18);
            this.lChoose.TabIndex = 3;
            this.lChoose.Text = "Choose";
            this.lChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lChoose);
            this.Controls.Add(this.pHighLight);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.pbImage);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCProduct";
            this.Size = new System.Drawing.Size(341, 114);
            this.Load += new System.EventHandler(this.UCProduct_Load);
            this.Click += new System.EventHandler(this.UCProduct_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Panel pHighLight;
        private System.Windows.Forms.Label lChoose;
    }
}
