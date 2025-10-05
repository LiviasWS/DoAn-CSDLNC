namespace DoAN_CSDLNC
{
    partial class FTableDetail
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
            this.pHighLight = new System.Windows.Forms.Panel();
            this.flpOrderList = new System.Windows.Forms.FlowLayoutPanel();
            this.pFunction = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pHeader = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pFunction.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lName.ForeColor = System.Drawing.Color.Tan;
            this.lName.Location = new System.Drawing.Point(86, 41);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(204, 38);
            this.lName.TabIndex = 0;
            this.lName.Text = "Table Name";
            // 
            // pHighLight
            // 
            this.pHighLight.BackColor = System.Drawing.Color.Tan;
            this.pHighLight.Location = new System.Drawing.Point(93, 91);
            this.pHighLight.Name = "pHighLight";
            this.pHighLight.Size = new System.Drawing.Size(1302, 3);
            this.pHighLight.TabIndex = 1;
            // 
            // flpOrderList
            // 
            this.flpOrderList.AutoScroll = true;
            this.flpOrderList.Location = new System.Drawing.Point(93, 205);
            this.flpOrderList.Name = "flpOrderList";
            this.flpOrderList.Size = new System.Drawing.Size(878, 462);
            this.flpOrderList.TabIndex = 2;
            // 
            // pFunction
            // 
            this.pFunction.BackColor = System.Drawing.Color.White;
            this.pFunction.Controls.Add(this.btnPay);
            this.pFunction.Controls.Add(this.label1);
            this.pFunction.Controls.Add(this.btnAddOrder);
            this.pFunction.Controls.Add(this.label3);
            this.pFunction.Location = new System.Drawing.Point(1025, 149);
            this.pFunction.Name = "pFunction";
            this.pFunction.Size = new System.Drawing.Size(370, 518);
            this.pFunction.TabIndex = 3;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Tan;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(73, 193);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(235, 39);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(21, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Make a payment:";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.Tan;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Location = new System.Drawing.Point(73, 70);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(235, 39);
            this.btnAddOrder.TabIndex = 5;
            this.btnAddOrder.Text = "+";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Order:";
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.Tan;
            this.pHeader.Controls.Add(this.label6);
            this.pHeader.Controls.Add(this.label5);
            this.pHeader.Controls.Add(this.label4);
            this.pHeader.Controls.Add(this.label2);
            this.pHeader.Location = new System.Drawing.Point(93, 149);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(878, 57);
            this.pHeader.TabIndex = 4;
            this.pHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(721, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(556, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(437, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(32, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // FTableDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.pFunction);
            this.Controls.Add(this.flpOrderList);
            this.Controls.Add(this.pHighLight);
            this.Controls.Add(this.lName);
            this.Name = "FTableDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTableDetail";
            this.Load += new System.EventHandler(this.FTableDetail_Load);
            this.pFunction.ResumeLayout(false);
            this.pFunction.PerformLayout();
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Panel pHighLight;
        private System.Windows.Forms.FlowLayoutPanel flpOrderList;
        private System.Windows.Forms.Panel pFunction;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}