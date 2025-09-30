namespace DoAN_CSDLNC.Views
{
    partial class FOrderItem
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
            this.lName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flpTopping = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lName.ForeColor = System.Drawing.Color.Peru;
            this.lName.Location = new System.Drawing.Point(30, 40);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(206, 32);
            this.lName.TabIndex = 0;
            this.lName.Text = "Product Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudQuantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(36, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 45);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(98, 12);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(395, 22);
            this.nudQuantity.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbSize);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(36, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 45);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Tan;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Size:";
            // 
            // cbbSize
            // 
            this.cbbSize.FormattingEnabled = true;
            this.cbbSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cbbSize.Location = new System.Drawing.Point(98, 11);
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.Size = new System.Drawing.Size(395, 24);
            this.cbbSize.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Peru;
            this.label4.Location = new System.Drawing.Point(32, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Topping List:";
            // 
            // flpTopping
            // 
            this.flpTopping.AutoScroll = true;
            this.flpTopping.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTopping.Location = new System.Drawing.Point(36, 250);
            this.flpTopping.Name = "flpTopping";
            this.flpTopping.Size = new System.Drawing.Size(496, 294);
            this.flpTopping.TabIndex = 5;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Tan;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirm.Location = new System.Drawing.Point(427, 559);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(105, 32);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 630);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.flpTopping);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lName);
            this.Name = "FOrderItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOrderItem";
            this.Load += new System.EventHandler(this.FOrderItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flpTopping;
        private System.Windows.Forms.Button btnConfirm;
    }
}