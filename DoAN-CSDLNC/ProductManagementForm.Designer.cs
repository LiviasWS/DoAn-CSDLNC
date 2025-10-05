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
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStockCount = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudLoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(1176, 624);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(88, 31);
            this.btnlogout.TabIndex = 95;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(836, 490);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.TabIndex = 94;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStockCount
            // 
            this.btnStockCount.Location = new System.Drawing.Point(746, 490);
            this.btnStockCount.Name = "btnStockCount";
            this.btnStockCount.Size = new System.Drawing.Size(90, 30);
            this.btnStockCount.TabIndex = 93;
            this.btnStockCount.Text = "Kiểm kê";
            this.btnStockCount.UseVisualStyleBackColor = true;
            this.btnStockCount.Click += new System.EventHandler(this.btnStockCount_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(656, 490);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(90, 30);
            this.btnTransfer.TabIndex = 92;
            this.btnTransfer.Text = "Chuyển kho";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(566, 490);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(90, 30);
            this.btnIssue.TabIndex = 91;
            this.btnIssue.Text = "Xuất kho";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(476, 490);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(90, 30);
            this.btnReceive.TabIndex = 90;
            this.btnReceive.Text = "Nhập kho";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnRecieve_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(926, 450);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(90, 30);
            this.btnExport.TabIndex = 89;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(836, 450);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 88;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(746, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 87;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(656, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 86;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(566, 450);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 85;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(476, 450);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 84;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(256, 586);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(200, 60);
            this.txtNote.TabIndex = 83;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(136, 590);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(54, 16);
            this.lblNote.TabIndex = 82;
            this.lblNote.Text = "Ghi chú:";
            // 
            // nudLoss
            // 
            this.nudLoss.DecimalPlaces = 2;
            this.nudLoss.Location = new System.Drawing.Point(256, 546);
            this.nudLoss.Name = "nudLoss";
            this.nudLoss.Size = new System.Drawing.Size(100, 22);
            this.nudLoss.TabIndex = 81;
            // 
            // lblLoss
            // 
            this.lblLoss.AutoSize = true;
            this.lblLoss.Location = new System.Drawing.Point(136, 550);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(79, 16);
            this.lblLoss.TabIndex = 80;
            this.lblLoss.Text = "Hao hụt (%):";
            // 
            // chkFEFO
            // 
            this.chkFEFO.AutoSize = true;
            this.chkFEFO.Location = new System.Drawing.Point(136, 510);
            this.chkFEFO.Name = "chkFEFO";
            this.chkFEFO.Size = new System.Drawing.Size(118, 20);
            this.chkFEFO.TabIndex = 79;
            this.chkFEFO.Text = "Xuất kho FEFO";
            this.chkFEFO.UseVisualStyleBackColor = true;
            // 
            // dtpExp
            // 
            this.dtpExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExp.Location = new System.Drawing.Point(256, 466);
            this.dtpExp.Name = "dtpExp";
            this.dtpExp.Size = new System.Drawing.Size(120, 22);
            this.dtpExp.TabIndex = 78;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(136, 470);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(39, 16);
            this.lblExp.TabIndex = 77;
            this.lblExp.Text = "HSD:";
            // 
            // dtpMfg
            // 
            this.dtpMfg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMfg.Location = new System.Drawing.Point(256, 426);
            this.dtpMfg.Name = "dtpMfg";
            this.dtpMfg.Size = new System.Drawing.Size(120, 22);
            this.dtpMfg.TabIndex = 76;
            // 
            // lblMfg
            // 
            this.lblMfg.AutoSize = true;
            this.lblMfg.Location = new System.Drawing.Point(136, 430);
            this.lblMfg.Name = "lblMfg";
            this.lblMfg.Size = new System.Drawing.Size(37, 16);
            this.lblMfg.TabIndex = 75;
            this.lblMfg.Text = "NSX:";
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(256, 386);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(180, 22);
            this.txtBatch.TabIndex = 74;
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.Location = new System.Drawing.Point(136, 390);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(58, 16);
            this.lblBatch.TabIndex = 73;
            this.lblBatch.Text = "Lô hàng:";
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(426, 346);
            this.nudMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(110, 22);
            this.nudMax.TabIndex = 72;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(356, 350);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(62, 16);
            this.lblMax.TabIndex = 71;
            this.lblMax.Text = "Tồn Max:";
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(256, 346);
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
            this.lblMin.Location = new System.Drawing.Point(136, 350);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(58, 16);
            this.lblMin.TabIndex = 69;
            this.lblMin.Text = "Tồn Min:";
            // 
            // nudPriceIn
            // 
            this.nudPriceIn.Location = new System.Drawing.Point(256, 306);
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
            this.lblPriceIn.Location = new System.Drawing.Point(136, 310);
            this.lblPriceIn.Name = "lblPriceIn";
            this.lblPriceIn.Size = new System.Drawing.Size(89, 16);
            this.lblPriceIn.TabIndex = 67;
            this.lblPriceIn.Text = "Đơn giá nhập:";
            // 
            // nudConv
            // 
            this.nudConv.Location = new System.Drawing.Point(196, 266);
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
            this.lblConv.Location = new System.Drawing.Point(136, 270);
            this.lblConv.Name = "lblConv";
            this.lblConv.Size = new System.Drawing.Size(50, 16);
            this.lblConv.TabIndex = 65;
            this.lblConv.Text = "1 gốc =";
            // 
            // txtUomAlt
            // 
            this.txtUomAlt.Location = new System.Drawing.Point(456, 226);
            this.txtUomAlt.Name = "txtUomAlt";
            this.txtUomAlt.Size = new System.Drawing.Size(80, 22);
            this.txtUomAlt.TabIndex = 64;
            // 
            // lblUomAlt
            // 
            this.lblUomAlt.AutoSize = true;
            this.lblUomAlt.Location = new System.Drawing.Point(356, 230);
            this.lblUomAlt.Name = "lblUomAlt";
            this.lblUomAlt.Size = new System.Drawing.Size(84, 16);
            this.lblUomAlt.TabIndex = 63;
            this.lblUomAlt.Text = "ĐVT quy đổi:";
            // 
            // txtUomBase
            // 
            this.txtUomBase.Location = new System.Drawing.Point(256, 226);
            this.txtUomBase.Name = "txtUomBase";
            this.txtUomBase.Size = new System.Drawing.Size(80, 22);
            this.txtUomBase.TabIndex = 62;
            // 
            // lblUomBase
            // 
            this.lblUomBase.AutoSize = true;
            this.lblUomBase.Location = new System.Drawing.Point(136, 230);
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
            this.cboWarehouse.Location = new System.Drawing.Point(256, 186);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Size = new System.Drawing.Size(180, 24);
            this.cboWarehouse.TabIndex = 60;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Location = new System.Drawing.Point(136, 190);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(33, 16);
            this.lblWarehouse.TabIndex = 59;
            this.lblWarehouse.Text = "Kho:";
            // 
            // cboSupplier
            // 
            this.cboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(256, 146);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(180, 24);
            this.cboSupplier.TabIndex = 58;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(136, 150);
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
            this.cboGroup.Location = new System.Drawing.Point(256, 106);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(180, 24);
            this.cboGroup.TabIndex = 56;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(136, 110);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(79, 16);
            this.lblGroup.TabIndex = 55;
            this.lblGroup.Text = "Nhóm hàng:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(256, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 22);
            this.txtName.TabIndex = 54;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(136, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 16);
            this.lblName.TabIndex = 53;
            this.lblName.Text = "Tên nguyên liệu:";
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(256, 26);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.ReadOnly = true;
            this.txtSKU.Size = new System.Drawing.Size(180, 22);
            this.txtSKU.TabIndex = 52;
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Location = new System.Drawing.Point(136, 30);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(100, 16);
            this.lblSKU.TabIndex = 51;
            this.lblSKU.Text = "Mã nguyên liệu:";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(16, 140);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(100, 30);
            this.btnChooseImage.TabIndex = 50;
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(16, 30);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(100, 100);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 49;
            this.picImage.TabStop = false;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(566, 30);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(684, 400);
            this.dgvProducts.TabIndex = 48;
            // 
            // ProductManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 680);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStockCount);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.nudLoss);
            this.Controls.Add(this.lblLoss);
            this.Controls.Add(this.chkFEFO);
            this.Controls.Add(this.dtpExp);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.dtpMfg);
            this.Controls.Add(this.lblMfg);
            this.Controls.Add(this.txtBatch);
            this.Controls.Add(this.lblBatch);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.nudPriceIn);
            this.Controls.Add(this.lblPriceIn);
            this.Controls.Add(this.nudConv);
            this.Controls.Add(this.lblConv);
            this.Controls.Add(this.txtUomAlt);
            this.Controls.Add(this.lblUomAlt);
            this.Controls.Add(this.txtUomBase);
            this.Controls.Add(this.lblUomBase);
            this.Controls.Add(this.cboWarehouse);
            this.Controls.Add(this.lblWarehouse);
            this.Controls.Add(this.cboSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cboGroup);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.lblSKU);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.dgvProducts);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStockCount;
        private System.Windows.Forms.Button btnTransfer;
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
    }
}