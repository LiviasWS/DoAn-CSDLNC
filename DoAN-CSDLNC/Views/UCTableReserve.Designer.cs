namespace DoAN_CSDLNC.Views
{
    partial class UCTableReserve
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
            this.lStatus = new System.Windows.Forms.Label();
            this.lStart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pHighlight = new System.Windows.Forms.Panel();
            this.lName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lStatus.Location = new System.Drawing.Point(198, 118);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(57, 18);
            this.lStatus.TabIndex = 9;
            this.lStatus.Text = "Details ";
            // 
            // lStart
            // 
            this.lStart.AutoSize = true;
            this.lStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lStart.Location = new System.Drawing.Point(80, 71);
            this.lStart.Name = "lStart";
            this.lStart.Size = new System.Drawing.Size(46, 18);
            this.lStart.TabIndex = 8;
            this.lStart.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Start:";
            // 
            // pHighlight
            // 
            this.pHighlight.BackColor = System.Drawing.Color.Black;
            this.pHighlight.Location = new System.Drawing.Point(32, 49);
            this.pHighlight.Name = "pHighlight";
            this.pHighlight.Size = new System.Drawing.Size(250, 5);
            this.pHighlight.TabIndex = 6;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lName.Location = new System.Drawing.Point(27, 21);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(129, 25);
            this.lName.TabIndex = 5;
            this.lName.Text = "Table Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "End:";
            // 
            // lEnd
            // 
            this.lEnd.AutoSize = true;
            this.lEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lEnd.Location = new System.Drawing.Point(80, 87);
            this.lEnd.Name = "lEnd";
            this.lEnd.Size = new System.Drawing.Size(46, 18);
            this.lEnd.TabIndex = 11;
            this.lEnd.Text = "label2";
            // 
            // UCTableReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.lStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pHighlight);
            this.Controls.Add(this.lName);
            this.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.Name = "UCTableReserve";
            this.Size = new System.Drawing.Size(308, 158);
            this.Load += new System.EventHandler(this.UCTableReserve_Load);
            this.Click += new System.EventHandler(this.UCTableReserve_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label lStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pHighlight;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lEnd;
    }
}
