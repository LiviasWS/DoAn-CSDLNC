namespace DoAN_CSDLNC.Views
{
    partial class UCTableReserveDashBoard
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
            this.flpTableList = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.pFunction = new System.Windows.Forms.Panel();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMinutes = new System.Windows.Forms.ComboBox();
            this.cbbHour = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTableList
            // 
            this.flpTableList.AutoScroll = true;
            this.flpTableList.Location = new System.Drawing.Point(6, 25);
            this.flpTableList.Name = "flpTableList";
            this.flpTableList.Padding = new System.Windows.Forms.Padding(20);
            this.flpTableList.Size = new System.Drawing.Size(1185, 750);
            this.flpTableList.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 4;
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.Tan;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReserve.ForeColor = System.Drawing.Color.White;
            this.btnReserve.Location = new System.Drawing.Point(163, 477);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(107, 39);
            this.btnReserve.TabIndex = 7;
            this.btnReserve.Text = "Confirm";
            this.btnReserve.UseVisualStyleBackColor = false;
            // 
            // pFunction
            // 
            this.pFunction.BackColor = System.Drawing.Color.White;
            this.pFunction.Controls.Add(this.cbbCustomer);
            this.pFunction.Controls.Add(this.label6);
            this.pFunction.Controls.Add(this.cbbMinutes);
            this.pFunction.Controls.Add(this.cbbHour);
            this.pFunction.Controls.Add(this.dtpDate);
            this.pFunction.Controls.Add(this.txtDuration);
            this.pFunction.Controls.Add(this.label5);
            this.pFunction.Controls.Add(this.label4);
            this.pFunction.Controls.Add(this.label3);
            this.pFunction.Controls.Add(this.label1);
            this.pFunction.Controls.Add(this.btnReserve);
            this.pFunction.Location = new System.Drawing.Point(1192, 61);
            this.pFunction.Name = "pFunction";
            this.pFunction.Size = new System.Drawing.Size(303, 714);
            this.pFunction.TabIndex = 6;
            this.pFunction.Paint += new System.Windows.Forms.PaintEventHandler(this.pFunction_Paint);
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(34, 406);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(235, 24);
            this.cbbCustomer.TabIndex = 29;
            this.cbbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbbCustomer_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Peru;
            this.label6.Location = new System.Drawing.Point(30, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Customers:";
            // 
            // cbbMinutes
            // 
            this.cbbMinutes.FormattingEnabled = true;
            this.cbbMinutes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbbMinutes.Location = new System.Drawing.Point(34, 229);
            this.cbbMinutes.Name = "cbbMinutes";
            this.cbbMinutes.Size = new System.Drawing.Size(235, 24);
            this.cbbMinutes.TabIndex = 27;
            // 
            // cbbHour
            // 
            this.cbbHour.FormattingEnabled = true;
            this.cbbHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbbHour.Location = new System.Drawing.Point(34, 144);
            this.cbbHour.Name = "cbbHour";
            this.cbbHour.Size = new System.Drawing.Size(235, 24);
            this.cbbHour.TabIndex = 26;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(34, 66);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(235, 22);
            this.dtpDate.TabIndex = 25;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(34, 319);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(235, 22);
            this.txtDuration.TabIndex = 24;
            this.txtDuration.TextChanged += new System.EventHandler(this.txtDuration_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Peru;
            this.label5.Location = new System.Drawing.Point(30, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Duration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Peru;
            this.label4.Location = new System.Drawing.Point(30, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Minutes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(30, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(30, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hour:";
            // 
            // UCTableReserveDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pFunction);
            this.Controls.Add(this.flpTableList);
            this.Controls.Add(this.label2);
            this.Name = "UCTableReserveDashBoard";
            this.Size = new System.Drawing.Size(1500, 800);
            this.Load += new System.EventHandler(this.UCTableReserveDashBoardcs_Load);
            this.pFunction.ResumeLayout(false);
            this.pFunction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpTableList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Panel pFunction;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMinutes;
        private System.Windows.Forms.ComboBox cbbHour;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
