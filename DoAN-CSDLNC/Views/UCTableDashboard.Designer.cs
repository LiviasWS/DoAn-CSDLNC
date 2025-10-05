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
            this.pFunction = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFree = new System.Windows.Forms.CheckBox();
            this.cbOccupied = new System.Windows.Forms.CheckBox();
            this.cbReserved = new System.Windows.Forms.CheckBox();
            this.pFunction.SuspendLayout();
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
            this.flpTableList.Size = new System.Drawing.Size(1185, 750);
            this.flpTableList.TabIndex = 2;
            // 
            // pFunction
            // 
            this.pFunction.BackColor = System.Drawing.Color.White;
            this.pFunction.Controls.Add(this.cbReserved);
            this.pFunction.Controls.Add(this.cbOccupied);
            this.pFunction.Controls.Add(this.cbFree);
            this.pFunction.Controls.Add(this.btnReserve);
            this.pFunction.Controls.Add(this.label5);
            this.pFunction.Controls.Add(this.label4);
            this.pFunction.Controls.Add(this.btnAddOrder);
            this.pFunction.Controls.Add(this.label3);
            this.pFunction.Controls.Add(this.txtSearch);
            this.pFunction.Controls.Add(this.label1);
            this.pFunction.Location = new System.Drawing.Point(1189, 54);
            this.pFunction.Name = "pFunction";
            this.pFunction.Size = new System.Drawing.Size(303, 714);
            this.pFunction.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(31, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Order:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(35, 177);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(31, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.Tan;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Location = new System.Drawing.Point(35, 67);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(235, 39);
            this.btnAddOrder.TabIndex = 3;
            this.btnAddOrder.Text = "+";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Peru;
            this.label4.Location = new System.Drawing.Point(31, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status:";
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.Tan;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReserve.ForeColor = System.Drawing.Color.White;
            this.btnReserve.Location = new System.Drawing.Point(35, 395);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(235, 39);
            this.btnReserve.TabIndex = 7;
            this.btnReserve.Text = "+";
            this.btnReserve.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Peru;
            this.label5.Location = new System.Drawing.Point(31, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "New Reserve:";
            // 
            // cbFree
            // 
            this.cbFree.AutoSize = true;
            this.cbFree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbFree.Location = new System.Drawing.Point(35, 274);
            this.cbFree.Name = "cbFree";
            this.cbFree.Size = new System.Drawing.Size(56, 22);
            this.cbFree.TabIndex = 8;
            this.cbFree.Text = "Free";
            this.cbFree.UseVisualStyleBackColor = true;
            // 
            // cbOccupied
            // 
            this.cbOccupied.AutoSize = true;
            this.cbOccupied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOccupied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbOccupied.Location = new System.Drawing.Point(35, 300);
            this.cbOccupied.Name = "cbOccupied";
            this.cbOccupied.Size = new System.Drawing.Size(89, 22);
            this.cbOccupied.TabIndex = 9;
            this.cbOccupied.Text = "Occupied";
            this.cbOccupied.UseVisualStyleBackColor = true;
            // 
            // cbReserved
            // 
            this.cbReserved.AutoSize = true;
            this.cbReserved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbReserved.Location = new System.Drawing.Point(35, 326);
            this.cbReserved.Name = "cbReserved";
            this.cbReserved.Size = new System.Drawing.Size(89, 22);
            this.cbReserved.TabIndex = 10;
            this.cbReserved.Text = "Reserved";
            this.cbReserved.UseVisualStyleBackColor = true;
            // 
            // UCTableDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pFunction);
            this.Controls.Add(this.flpTableList);
            this.Controls.Add(this.label2);
            this.Name = "UCTableDashboard";
            this.Size = new System.Drawing.Size(1500, 800);
            this.Load += new System.EventHandler(this.UCTableDashboard_Load);
            this.pFunction.ResumeLayout(false);
            this.pFunction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpTableList;
        private System.Windows.Forms.Panel pFunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbReserved;
        private System.Windows.Forms.CheckBox cbOccupied;
        private System.Windows.Forms.CheckBox cbFree;
    }
}
