namespace DoAN_CSDLNC.Views
{
    partial class UCTopping
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
            this.lName = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lName.Location = new System.Drawing.Point(16, 13);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(48, 18);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(314, 13);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(145, 22);
            this.nudQuantity.TabIndex = 2;
            // 
            // UCTopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lName);
            this.Name = "UCTopping";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Size = new System.Drawing.Size(484, 45);
            this.Load += new System.EventHandler(this.UCTopping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.NumericUpDown nudQuantity;
    }
}
