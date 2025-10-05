namespace DoAN_CSDLNC
{
    partial class UCOrderItem
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
            this.lTotalPrice = new System.Windows.Forms.Label();
            this.lQuantity = new System.Windows.Forms.Label();
            this.lSize = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lTotalPrice
            // 
            this.lTotalPrice.AutoSize = true;
            this.lTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lTotalPrice.Location = new System.Drawing.Point(745, 10);
            this.lTotalPrice.Name = "lTotalPrice";
            this.lTotalPrice.Size = new System.Drawing.Size(77, 18);
            this.lTotalPrice.TabIndex = 8;
            this.lTotalPrice.Text = "Total price";
            this.lTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lQuantity
            // 
            this.lQuantity.AutoSize = true;
            this.lQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lQuantity.Location = new System.Drawing.Point(591, 10);
            this.lQuantity.Name = "lQuantity";
            this.lQuantity.Size = new System.Drawing.Size(62, 18);
            this.lQuantity.TabIndex = 7;
            this.lQuantity.Text = "Quantity";
            this.lQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lSize.Location = new System.Drawing.Point(455, 10);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(37, 18);
            this.lSize.TabIndex = 6;
            this.lSize.Text = "Size";
            this.lSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lName.Location = new System.Drawing.Point(30, 10);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(48, 18);
            this.lName.TabIndex = 5;
            this.lName.Text = "Name";
            // 
            // UCOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lTotalPrice);
            this.Controls.Add(this.lQuantity);
            this.Controls.Add(this.lSize);
            this.Controls.Add(this.lName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCOrderItem";
            this.Size = new System.Drawing.Size(878, 41);
            this.Load += new System.EventHandler(this.UCOrderItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lTotalPrice;
        private System.Windows.Forms.Label lQuantity;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.Label lName;
    }
}
