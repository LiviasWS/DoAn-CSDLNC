namespace DoAN_CSDLNC
{
    partial class ProductManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagementForm));
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStockCount = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.nudLoss = new System.Windows.Forms.NumericUpDown();
            this.lblLoss = new System.Windows.Forms.Label();
            this.chkFEFO = new System.Windows.Forms.CheckBox();
            this.dtpExp = new System.Windows.Forms.DateTimePicker();
            this.lblExp = new System.Windows.Forms.Label();
            this.dtpMfg = new System.Windows.Forms.DateTimePicker();
            this.lblMfg = new System.Windows.Forms.Label();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.lblBatch = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.lblMax = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.lblMin = new System.Windows.Forms.Label();
            this.nudPriceIn = new System.Windows.Forms.NumericUpDown();
            this.lblPriceIn = new System.Windows.Forms.Label();
            this.nudConv = new System.Windows.Forms.NumericUpDown();
            this.lblConv = new System.Windows.Forms.Label();
            this.txtUomAlt = new System.Windows.Forms.TextBox();
            this.lblUomAlt = new System.Windows.Forms.Label();
            this.txtUomBase = new System.Windows.Forms.TextBox();
            this.lblUomBase = new System.Windows.Forms.Label();
            this.cboWarehouse = new System.Windows.Forms.ComboBox();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.lblSKU = new System.Windows.Forms.Label();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lbl_QLNL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(1504, 841);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(127, 55);
            this.btnlogout.TabIndex = 95;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(977, 641);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 64);
            this.btnClear.TabIndex = 94;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStockCount
            // 
            this.btnStockCount.Location = new System.Drawing.Point(841, 640);
            this.btnStockCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStockCount.Name = "btnStockCount";
            this.btnStockCount.Size = new System.Drawing.Size(132, 64);
            this.btnStockCount.TabIndex = 93;
            this.btnStockCount.Text = "Kiểm kê";
            this.btnStockCount.UseVisualStyleBackColor = true;
            this.btnStockCount.Click += new System.EventHandler(this.btnStockCount_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(703, 641);
            this.btnIssue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(132, 64);
            this.btnIssue.TabIndex = 91;
            this.btnIssue.Text = "Xuất kho";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(565, 641);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(132, 64);
            this.btnReceive.TabIndex = 90;
            this.btnReceive.Text = "Nhập kho";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1252, 572);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(132, 64);
            this.btnExport.TabIndex = 89;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1115, 572);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 64);
            this.btnSearch.TabIndex = 88;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(977, 572);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 64);
            this.btnSave.TabIndex = 87;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(840, 572);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 64);
            this.btnDelete.TabIndex = 86;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(703, 572);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 64);
            this.btnEdit.TabIndex = 85;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(565, 572);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 64);
            this.btnAdd.TabIndex = 84;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(257, 773);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(265, 120);
            this.txtNote.TabIndex = 83;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(137, 777);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(54, 16);
            this.lblNote.TabIndex = 82;
            this.lblNote.Text = "Ghi chú:";
            // 
            // nudLoss
            // 
            this.nudLoss.DecimalPlaces = 2;
            this.nudLoss.Location = new System.Drawing.Point(257, 734);
            this.nudLoss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudLoss.Name = "nudLoss";
            this.nudLoss.Size = new System.Drawing.Size(100, 22);
            this.nudLoss.TabIndex = 81;
            // 
            // lblLoss
            // 
            this.lblLoss.AutoSize = true;
            this.lblLoss.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblLoss.ForeColor = System.Drawing.Color.White;
            this.lblLoss.Location = new System.Drawing.Point(137, 737);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(79, 16);
            this.lblLoss.TabIndex = 80;
            this.lblLoss.Text = "Hao hụt (%):";
            // 
            // chkFEFO
            // 
            this.chkFEFO.AutoSize = true;
            this.chkFEFO.BackColor = System.Drawing.Color.SaddleBrown;
            this.chkFEFO.ForeColor = System.Drawing.Color.White;
            this.chkFEFO.Location = new System.Drawing.Point(137, 697);
            this.chkFEFO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFEFO.Name = "chkFEFO";
            this.chkFEFO.Size = new System.Drawing.Size(118, 20);
            this.chkFEFO.TabIndex = 79;
            this.chkFEFO.Text = "Xuất kho FEFO";
            this.chkFEFO.UseVisualStyleBackColor = false;
            // 
            // dtpExp
            // 
            this.dtpExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExp.Location = new System.Drawing.Point(257, 654);
            this.dtpExp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpExp.Name = "dtpExp";
            this.dtpExp.Size = new System.Drawing.Size(120, 22);
            this.dtpExp.TabIndex = 78;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblExp.ForeColor = System.Drawing.Color.White;
            this.lblExp.Location = new System.Drawing.Point(137, 657);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(39, 16);
            this.lblExp.TabIndex = 77;
            this.lblExp.Text = "HSD:";
            // 
            // dtpMfg
            // 
            this.dtpMfg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMfg.Location = new System.Drawing.Point(257, 613);
            this.dtpMfg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpMfg.Name = "dtpMfg";
            this.dtpMfg.Size = new System.Drawing.Size(120, 22);
            this.dtpMfg.TabIndex = 76;
            // 
            // lblMfg
            // 
            this.lblMfg.AutoSize = true;
            this.lblMfg.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblMfg.ForeColor = System.Drawing.Color.White;
            this.lblMfg.Location = new System.Drawing.Point(137, 617);
            this.lblMfg.Name = "lblMfg";
            this.lblMfg.Size = new System.Drawing.Size(37, 16);
            this.lblMfg.TabIndex = 75;
            this.lblMfg.Text = "NSX:";
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(257, 574);
            this.txtBatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(180, 22);
            this.txtBatch.TabIndex = 74;
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblBatch.ForeColor = System.Drawing.Color.White;
            this.lblBatch.Location = new System.Drawing.Point(137, 577);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(58, 16);
            this.lblBatch.TabIndex = 73;
            this.lblBatch.Text = "Lô hàng:";
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(428, 533);
            this.nudMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(109, 22);
            this.nudMax.TabIndex = 72;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblMax.ForeColor = System.Drawing.Color.White;
            this.lblMax.Location = new System.Drawing.Point(357, 537);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(62, 16);
            this.lblMax.TabIndex = 71;
            this.lblMax.Text = "Tồn Max:";
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(257, 533);
            this.nudMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(100, 22);
            this.nudMin.TabIndex = 70;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(137, 537);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(58, 16);
            this.lblMin.TabIndex = 69;
            this.lblMin.Text = "Tồn Min:";
            // 
            // nudPriceIn
            // 
            this.nudPriceIn.Location = new System.Drawing.Point(257, 494);
            this.nudPriceIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPriceIn.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudPriceIn.Name = "nudPriceIn";
            this.nudPriceIn.Size = new System.Drawing.Size(180, 22);
            this.nudPriceIn.TabIndex = 68;
            // 
            // lblPriceIn
            // 
            this.lblPriceIn.AutoSize = true;
            this.lblPriceIn.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblPriceIn.ForeColor = System.Drawing.Color.White;
            this.lblPriceIn.Location = new System.Drawing.Point(137, 497);
            this.lblPriceIn.Name = "lblPriceIn";
            this.lblPriceIn.Size = new System.Drawing.Size(89, 16);
            this.lblPriceIn.TabIndex = 67;
            this.lblPriceIn.Text = "Đơn giá nhập:";
            // 
            // nudConv
            // 
            this.nudConv.Location = new System.Drawing.Point(197, 453);
            this.nudConv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudConv.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudConv.Name = "nudConv";
            this.nudConv.Size = new System.Drawing.Size(80, 22);
            this.nudConv.TabIndex = 66;
            this.nudConv.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblConv
            // 
            this.lblConv.AutoSize = true;
            this.lblConv.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblConv.ForeColor = System.Drawing.Color.White;
            this.lblConv.Location = new System.Drawing.Point(137, 457);
            this.lblConv.Name = "lblConv";
            this.lblConv.Size = new System.Drawing.Size(50, 16);
            this.lblConv.TabIndex = 65;
            this.lblConv.Text = "1 gốc =";
            // 
            // txtUomAlt
            // 
            this.txtUomAlt.Location = new System.Drawing.Point(457, 414);
            this.txtUomAlt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUomAlt.Name = "txtUomAlt";
            this.txtUomAlt.Size = new System.Drawing.Size(80, 22);
            this.txtUomAlt.TabIndex = 64;
            // 
            // lblUomAlt
            // 
            this.lblUomAlt.AutoSize = true;
            this.lblUomAlt.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblUomAlt.ForeColor = System.Drawing.Color.White;
            this.lblUomAlt.Location = new System.Drawing.Point(357, 417);
            this.lblUomAlt.Name = "lblUomAlt";
            this.lblUomAlt.Size = new System.Drawing.Size(84, 16);
            this.lblUomAlt.TabIndex = 63;
            this.lblUomAlt.Text = "ĐVT quy đổi:";
            // 
            // txtUomBase
            // 
            this.txtUomBase.Location = new System.Drawing.Point(257, 414);
            this.txtUomBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUomBase.Name = "txtUomBase";
            this.txtUomBase.Size = new System.Drawing.Size(80, 22);
            this.txtUomBase.TabIndex = 62;
            // 
            // lblUomBase
            // 
            this.lblUomBase.AutoSize = true;
            this.lblUomBase.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblUomBase.ForeColor = System.Drawing.Color.White;
            this.lblUomBase.Location = new System.Drawing.Point(137, 417);
            this.lblUomBase.Name = "lblUomBase";
            this.lblUomBase.Size = new System.Drawing.Size(63, 16);
            this.lblUomBase.TabIndex = 61;
            this.lblUomBase.Text = "ĐVT gốc:";
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWarehouse.FormattingEnabled = true;
            this.cboWarehouse.Items.AddRange(new object[] {
            "Kho Chính",
            "Kho Lạnh",
            "Kho Bar"});
            this.cboWarehouse.Location = new System.Drawing.Point(257, 373);
            this.cboWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Size = new System.Drawing.Size(180, 24);
            this.cboWarehouse.TabIndex = 60;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblWarehouse.ForeColor = System.Drawing.Color.White;
            this.lblWarehouse.Location = new System.Drawing.Point(137, 377);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(33, 16);
            this.lblWarehouse.TabIndex = 59;
            this.lblWarehouse.Text = "Kho:";
            // 
            // cboSupplier
            // 
            this.cboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(257, 334);
            this.cboSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(180, 24);
            this.cboSupplier.TabIndex = 58;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(137, 337);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(93, 16);
            this.lblSupplier.TabIndex = 57;
            this.lblSupplier.Text = "Nhà cung cấp:";
            // 
            // cboGroup
            // 
            this.cboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Items.AddRange(new object[] {
            "Nguyên liệu",
            "Vật tư",
            "Thành phẩm",
            "Bao bì"});
            this.cboGroup.Location = new System.Drawing.Point(257, 293);
            this.cboGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(180, 24);
            this.cboGroup.TabIndex = 56;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblGroup.ForeColor = System.Drawing.Color.White;
            this.lblGroup.Location = new System.Drawing.Point(137, 297);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(79, 16);
            this.lblGroup.TabIndex = 55;
            this.lblGroup.Text = "Nhóm hàng:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(257, 254);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 22);
            this.txtName.TabIndex = 54;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(137, 257);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 16);
            this.lblName.TabIndex = 53;
            this.lblName.Text = "Tên nguyên liệu:";
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(257, 213);
            this.txtSKU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(180, 22);
            this.txtSKU.TabIndex = 52;
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblSKU.ForeColor = System.Drawing.Color.White;
            this.lblSKU.Location = new System.Drawing.Point(137, 217);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(100, 16);
            this.lblSKU.TabIndex = 51;
            this.lblSKU.Text = "Mã nguyên liệu:";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(17, 327);
            this.btnChooseImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(100, 30);
            this.btnChooseImage.TabIndex = 50;
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.SeaShell;
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(17, 217);
            this.picImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(101, 100);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 49;
            this.picImage.TabStop = false;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(555, 105);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1076, 447);
            this.dgvProducts.TabIndex = 48;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick_1);
            // 
            // lbl_QLNL
            // 
            this.lbl_QLNL.AutoSize = true;
            this.lbl_QLNL.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_QLNL.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLNL.ForeColor = System.Drawing.Color.White;
            this.lbl_QLNL.Location = new System.Drawing.Point(916, 11);
            this.lbl_QLNL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_QLNL.Name = "lbl_QLNL";
            this.lbl_QLNL.Size = new System.Drawing.Size(260, 52);
            this.lbl_QLNL.TabIndex = 97;
            this.lbl_QLNL.Text = "Quản Lý Kho";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.picImage);
            this.panel1.Controls.Add(this.btnChooseImage);
            this.panel1.Controls.Add(this.lblSKU);
            this.panel1.Controls.Add(this.txtSKU);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblGroup);
            this.panel1.Controls.Add(this.cboGroup);
            this.panel1.Controls.Add(this.lblSupplier);
            this.panel1.Controls.Add(this.cboSupplier);
            this.panel1.Controls.Add(this.lblWarehouse);
            this.panel1.Controls.Add(this.cboWarehouse);
            this.panel1.Controls.Add(this.lblUomBase);
            this.panel1.Controls.Add(this.lblNote);
            this.panel1.Controls.Add(this.txtUomBase);
            this.panel1.Controls.Add(this.nudLoss);
            this.panel1.Controls.Add(this.lblUomAlt);
            this.panel1.Controls.Add(this.lblLoss);
            this.panel1.Controls.Add(this.txtUomAlt);
            this.panel1.Controls.Add(this.chkFEFO);
            this.panel1.Controls.Add(this.lblConv);
            this.panel1.Controls.Add(this.dtpExp);
            this.panel1.Controls.Add(this.nudConv);
            this.panel1.Controls.Add(this.lblExp);
            this.panel1.Controls.Add(this.lblPriceIn);
            this.panel1.Controls.Add(this.dtpMfg);
            this.panel1.Controls.Add(this.nudPriceIn);
            this.panel1.Controls.Add(this.lblMfg);
            this.panel1.Controls.Add(this.lblMin);
            this.panel1.Controls.Add(this.txtBatch);
            this.panel1.Controls.Add(this.nudMin);
            this.panel1.Controls.Add(this.lblBatch);
            this.panel1.Controls.Add(this.lblMax);
            this.panel1.Controls.Add(this.nudMax);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 923);
            this.panel1.TabIndex = 98;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(559, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1075, 123);
            this.panel2.TabIndex = 99;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel3.Location = new System.Drawing.Point(545, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1104, 76);
            this.panel3.TabIndex = 99;
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(1115, 640);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(132, 64);
            this.btnHistory.TabIndex = 94;
            this.btnHistory.Text = "Lịch sử";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // ProductManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1645, 910);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.lbl_QLNL);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStockCount);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductManagementForm";
            this.Text = "ProductManagementForm";
            this.Load += new System.EventHandler(this.ProductManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStockCount;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.NumericUpDown nudLoss;
        private System.Windows.Forms.Label lblLoss;
        private System.Windows.Forms.CheckBox chkFEFO;
        private System.Windows.Forms.DateTimePicker dtpExp;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.DateTimePicker dtpMfg;
        private System.Windows.Forms.Label lblMfg;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.NumericUpDown nudPriceIn;
        private System.Windows.Forms.Label lblPriceIn;
        private System.Windows.Forms.NumericUpDown nudConv;
        private System.Windows.Forms.Label lblConv;
        private System.Windows.Forms.TextBox txtUomAlt;
        private System.Windows.Forms.Label lblUomAlt;
        private System.Windows.Forms.TextBox txtUomBase;
        private System.Windows.Forms.Label lblUomBase;
        private System.Windows.Forms.ComboBox cboWarehouse;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lbl_QLNL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHistory;
    }
}