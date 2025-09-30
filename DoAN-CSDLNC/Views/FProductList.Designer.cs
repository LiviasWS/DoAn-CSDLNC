namespace DoAN_CSDLNC.Views
{
    partial class FProductList
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
            this.pFunction = new System.Windows.Forms.Panel();
            this.cbReserved = new System.Windows.Forms.CheckBox();
            this.cbOccupied = new System.Windows.Forms.CheckBox();
            this.cbFree = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.flpProductList = new System.Windows.Forms.FlowLayoutPanel();
            this.pFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pFunction
            // 
            this.pFunction.BackColor = System.Drawing.Color.White;
            this.pFunction.Controls.Add(this.cbReserved);
            this.pFunction.Controls.Add(this.cbOccupied);
            this.pFunction.Controls.Add(this.cbFree);
            this.pFunction.Controls.Add(this.label4);
            this.pFunction.Controls.Add(this.txtSearch);
            this.pFunction.Controls.Add(this.label1);
            this.pFunction.Location = new System.Drawing.Point(1128, 99);
            this.pFunction.Name = "pFunction";
            this.pFunction.Size = new System.Drawing.Size(313, 619);
            this.pFunction.TabIndex = 4;
            // 
            // cbReserved
            // 
            this.cbReserved.AutoSize = true;
            this.cbReserved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbReserved.Location = new System.Drawing.Point(39, 211);
            this.cbReserved.Name = "cbReserved";
            this.cbReserved.Size = new System.Drawing.Size(89, 22);
            this.cbReserved.TabIndex = 16;
            this.cbReserved.Text = "Reserved";
            this.cbReserved.UseVisualStyleBackColor = true;
            // 
            // cbOccupied
            // 
            this.cbOccupied.AutoSize = true;
            this.cbOccupied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOccupied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbOccupied.Location = new System.Drawing.Point(39, 185);
            this.cbOccupied.Name = "cbOccupied";
            this.cbOccupied.Size = new System.Drawing.Size(89, 22);
            this.cbOccupied.TabIndex = 15;
            this.cbOccupied.Text = "Occupied";
            this.cbOccupied.UseVisualStyleBackColor = true;
            // 
            // cbFree
            // 
            this.cbFree.AutoSize = true;
            this.cbFree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbFree.Location = new System.Drawing.Point(39, 159);
            this.cbFree.Name = "cbFree";
            this.cbFree.Size = new System.Drawing.Size(56, 22);
            this.cbFree.TabIndex = 14;
            this.cbFree.Text = "Free";
            this.cbFree.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Peru;
            this.label4.Location = new System.Drawing.Point(35, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Status:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(39, 75);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 22);
            this.txtSearch.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lName.ForeColor = System.Drawing.Color.Peru;
            this.lName.Location = new System.Drawing.Point(37, 54);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(457, 42);
            this.lName.TabIndex = 2;
            this.lName.Text = "Choose product for order";
            // 
            // flpProductList
            // 
            this.flpProductList.AutoScroll = true;
            this.flpProductList.Location = new System.Drawing.Point(34, 99);
            this.flpProductList.Name = "flpProductList";
            this.flpProductList.Size = new System.Drawing.Size(1088, 619);
            this.flpProductList.TabIndex = 5;
            // 
            // FProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.flpProductList);
            this.Controls.Add(this.pFunction);
            this.Controls.Add(this.lName);
            this.Name = "FProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FProductList";
            this.Load += new System.EventHandler(this.FProductList_Load);
            this.pFunction.ResumeLayout(false);
            this.pFunction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pFunction;
        private System.Windows.Forms.CheckBox cbReserved;
        private System.Windows.Forms.CheckBox cbOccupied;
        private System.Windows.Forms.CheckBox cbFree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.FlowLayoutPanel flpProductList;
    }
}