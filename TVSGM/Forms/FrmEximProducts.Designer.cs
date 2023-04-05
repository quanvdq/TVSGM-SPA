namespace TVSGM.Forms
{
    partial class FrmEximProducts
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
            this.gridviewBill = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSearchBillID = new System.Windows.Forms.TextBox();
            this.gridviewBillDetail = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchPartner = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateSearchTo = new System.Windows.Forms.DateTimePicker();
            this.dateSearchForm = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtNgayHen = new System.Windows.Forms.DateTimePicker();
            this.cboUserName = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddPartner = new System.Windows.Forms.Button();
            this.dateExim = new System.Windows.Forms.DateTimePicker();
            this.txtDeb = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtPartner = new System.Windows.Forms.TextBox();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.txtTotalPayed = new System.Windows.Forms.TextBox();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.txtPromotionMoney = new System.Windows.Forms.TextBox();
            this.txtPromotionPercent = new System.Windows.Forms.TextBox();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.txtPayed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSCodePrd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewBillDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridviewBill
            // 
            this.gridviewBill.AllowUserToAddRows = false;
            this.gridviewBill.AllowUserToResizeRows = false;
            this.gridviewBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gridviewBill.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridviewBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridviewBill.ColumnHeadersHeight = 28;
            this.gridviewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridviewBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridviewBill.Location = new System.Drawing.Point(12, 150);
            this.gridviewBill.Name = "gridviewBill";
            this.gridviewBill.ReadOnly = true;
            this.gridviewBill.RowHeadersVisible = false;
            this.gridviewBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridviewBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewBill.Size = new System.Drawing.Size(318, 451);
            this.gridviewBill.TabIndex = 0;
            this.gridviewBill.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewBill_CellEnter);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 670);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1349, 670);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(336, 670);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(255, 670);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Ghi nhận";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(174, 670);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 26);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(93, 670);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSearchBillID
            // 
            this.txtSearchBillID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchBillID.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchBillID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBillID.Location = new System.Drawing.Point(101, 47);
            this.txtSearchBillID.Name = "txtSearchBillID";
            this.txtSearchBillID.Size = new System.Drawing.Size(211, 21);
            this.txtSearchBillID.TabIndex = 9;
            this.txtSearchBillID.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // gridviewBillDetail
            // 
            this.gridviewBillDetail.AllowUserToAddRows = false;
            this.gridviewBillDetail.AllowUserToResizeRows = false;
            this.gridviewBillDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewBillDetail.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridviewBillDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridviewBillDetail.ColumnHeadersHeight = 28;
            this.gridviewBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridviewBillDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridviewBillDetail.Location = new System.Drawing.Point(336, 162);
            this.gridviewBillDetail.Name = "gridviewBillDetail";
            this.gridviewBillDetail.RowHeadersVisible = false;
            this.gridviewBillDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridviewBillDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewBillDetail.Size = new System.Drawing.Size(1088, 439);
            this.gridviewBillDetail.TabIndex = 10;
            this.gridviewBillDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewBillDetail_CellValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSearchPartner);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSearchAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateSearchTo);
            this.groupBox1.Controls.Add(this.dateSearchForm);
            this.groupBox1.Controls.Add(this.txtSearchBillID);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 132);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = ">>>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F);
            this.label10.Location = new System.Drawing.Point(18, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 40;
            this.label10.Text = "Khách hàng:";
            // 
            // txtSearchPartner
            // 
            this.txtSearchPartner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchPartner.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchPartner.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPartner.Location = new System.Drawing.Point(101, 74);
            this.txtSearchPartner.Name = "txtSearchPartner";
            this.txtSearchPartner.Size = new System.Drawing.Size(211, 21);
            this.txtSearchPartner.TabIndex = 15;
            this.txtSearchPartner.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F);
            this.label9.Location = new System.Drawing.Point(46, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "Địa chỉ:";
            // 
            // txtSearchAddress
            // 
            this.txtSearchAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAddress.Location = new System.Drawing.Point(101, 101);
            this.txtSearchAddress.Name = "txtSearchAddress";
            this.txtSearchAddress.Size = new System.Drawing.Size(211, 21);
            this.txtSearchAddress.TabIndex = 13;
            this.txtSearchAddress.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Số hóa đơn:";
            // 
            // dateSearchTo
            // 
            this.dateSearchTo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSearchTo.Location = new System.Drawing.Point(177, 20);
            this.dateSearchTo.Name = "dateSearchTo";
            this.dateSearchTo.Size = new System.Drawing.Size(135, 21);
            this.dateSearchTo.TabIndex = 11;
            this.dateSearchTo.ValueChanged += new System.EventHandler(this.dateValueChanged);
            // 
            // dateSearchForm
            // 
            this.dateSearchForm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSearchForm.Location = new System.Drawing.Point(6, 20);
            this.dateSearchForm.Name = "dateSearchForm";
            this.dateSearchForm.Size = new System.Drawing.Size(135, 21);
            this.dateSearchForm.TabIndex = 10;
            this.dateSearchForm.ValueChanged += new System.EventHandler(this.dateValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dtNgayHen);
            this.groupBox2.Controls.Add(this.cboUserName);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAddPartner);
            this.groupBox2.Controls.Add(this.dateExim);
            this.groupBox2.Controls.Add(this.txtDeb);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(this.txtPartner);
            this.groupBox2.Controls.Add(this.txtBillID);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(336, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1088, 107);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đơn hàng";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(798, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 118;
            this.label11.Text = "Ngày hẹn:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F);
            this.label14.Location = new System.Drawing.Point(362, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 15);
            this.label14.TabIndex = 44;
            this.label14.Text = "Ghi chú:";
            // 
            // dtNgayHen
            // 
            this.dtNgayHen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNgayHen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayHen.Location = new System.Drawing.Point(871, 74);
            this.dtNgayHen.Name = "dtNgayHen";
            this.dtNgayHen.Size = new System.Drawing.Size(211, 21);
            this.dtNgayHen.TabIndex = 117;
            // 
            // cboUserName
            // 
            this.cboUserName.Enabled = false;
            this.cboUserName.FormattingEnabled = true;
            this.cboUserName.Location = new System.Drawing.Point(101, 72);
            this.cboUserName.Name = "cboUserName";
            this.cboUserName.Size = new System.Drawing.Size(211, 23);
            this.cboUserName.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F);
            this.label13.Location = new System.Drawing.Point(798, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 43;
            this.label13.Text = "Điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F);
            this.label8.Location = new System.Drawing.Point(21, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "Số hóa đơn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.Location = new System.Drawing.Point(27, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Ngày nhập:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F);
            this.label12.Location = new System.Drawing.Point(807, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 15);
            this.label12.TabIndex = 42;
            this.label12.Text = "Công nợ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F);
            this.label6.Location = new System.Drawing.Point(19, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Người nhập:";
            // 
            // btnAddPartner
            // 
            this.btnAddPartner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPartner.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPartner.Location = new System.Drawing.Point(746, 20);
            this.btnAddPartner.Name = "btnAddPartner";
            this.btnAddPartner.Size = new System.Drawing.Size(24, 21);
            this.btnAddPartner.TabIndex = 21;
            this.btnAddPartner.Text = "+";
            this.btnAddPartner.UseVisualStyleBackColor = true;
            this.btnAddPartner.Click += new System.EventHandler(this.btnAddPartner_Click);
            // 
            // dateExim
            // 
            this.dateExim.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateExim.Location = new System.Drawing.Point(101, 47);
            this.dateExim.Name = "dateExim";
            this.dateExim.Size = new System.Drawing.Size(211, 21);
            this.dateExim.TabIndex = 17;
            // 
            // txtDeb
            // 
            this.txtDeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeb.BackColor = System.Drawing.SystemColors.Window;
            this.txtDeb.Enabled = false;
            this.txtDeb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeb.Location = new System.Drawing.Point(871, 47);
            this.txtDeb.Name = "txtDeb";
            this.txtDeb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDeb.Size = new System.Drawing.Size(211, 21);
            this.txtDeb.TabIndex = 27;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(871, 20);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(211, 21);
            this.txtPhone.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F);
            this.label5.Location = new System.Drawing.Point(364, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Đối tác:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.Location = new System.Drawing.Point(365, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(418, 47);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(352, 21);
            this.txtAddress.TabIndex = 21;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtNote.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(418, 74);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(352, 21);
            this.txtNote.TabIndex = 19;
            // 
            // txtPartner
            // 
            this.txtPartner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPartner.BackColor = System.Drawing.SystemColors.Window;
            this.txtPartner.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartner.Location = new System.Drawing.Point(418, 20);
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.Size = new System.Drawing.Size(322, 21);
            this.txtPartner.TabIndex = 17;
            // 
            // txtBillID
            // 
            this.txtBillID.BackColor = System.Drawing.SystemColors.Window;
            this.txtBillID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillID.Location = new System.Drawing.Point(101, 20);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(211, 21);
            this.txtBillID.TabIndex = 9;
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProducts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProducts.Location = new System.Drawing.Point(1213, 125);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(138, 31);
            this.btnAddProducts.TabIndex = 17;
            this.btnAddProducts.Text = "Chọn sản phẩm";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // txtTotalPayed
            // 
            this.txtTotalPayed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalPayed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTotalPayed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPayed.Location = new System.Drawing.Point(119, 643);
            this.txtTotalPayed.Name = "txtTotalPayed";
            this.txtTotalPayed.ReadOnly = true;
            this.txtTotalPayed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalPayed.Size = new System.Drawing.Size(211, 21);
            this.txtTotalPayed.TabIndex = 21;
            this.txtTotalPayed.Text = "0";
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTotalBill.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBill.Location = new System.Drawing.Point(119, 616);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.ReadOnly = true;
            this.txtTotalBill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalBill.Size = new System.Drawing.Size(211, 21);
            this.txtTotalBill.TabIndex = 19;
            this.txtTotalBill.Text = "0";
            // 
            // txtPromotionMoney
            // 
            this.txtPromotionMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPromotionMoney.BackColor = System.Drawing.SystemColors.Window;
            this.txtPromotionMoney.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromotionMoney.Location = new System.Drawing.Point(532, 643);
            this.txtPromotionMoney.Name = "txtPromotionMoney";
            this.txtPromotionMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPromotionMoney.Size = new System.Drawing.Size(155, 21);
            this.txtPromotionMoney.TabIndex = 25;
            this.txtPromotionMoney.Text = "0";
            this.txtPromotionMoney.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtPromotionPercent
            // 
            this.txtPromotionPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPromotionPercent.BackColor = System.Drawing.SystemColors.Window;
            this.txtPromotionPercent.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromotionPercent.Location = new System.Drawing.Point(476, 643);
            this.txtPromotionPercent.Name = "txtPromotionPercent";
            this.txtPromotionPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPromotionPercent.Size = new System.Drawing.Size(50, 21);
            this.txtPromotionPercent.TabIndex = 23;
            this.txtPromotionPercent.Text = "0";
            this.txtPromotionPercent.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTotalPay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPay.Location = new System.Drawing.Point(1213, 616);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.ReadOnly = true;
            this.txtTotalPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalPay.Size = new System.Drawing.Size(211, 21);
            this.txtTotalPay.TabIndex = 29;
            this.txtTotalPay.Text = "0";
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTotalMoney.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMoney.Location = new System.Drawing.Point(476, 616);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.ReadOnly = true;
            this.txtTotalMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalMoney.Size = new System.Drawing.Size(211, 21);
            this.txtTotalMoney.TabIndex = 27;
            this.txtTotalMoney.Text = "0";
            // 
            // txtPayed
            // 
            this.txtPayed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayed.BackColor = System.Drawing.SystemColors.Window;
            this.txtPayed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayed.Location = new System.Drawing.Point(1213, 643);
            this.txtPayed.Name = "txtPayed";
            this.txtPayed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPayed.Size = new System.Drawing.Size(211, 21);
            this.txtPayed.TabIndex = 31;
            this.txtPayed.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1058, 674);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nhần phím Delete để xóa sản phẩm trong hóa đơn";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1120, 646);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 15);
            this.label17.TabIndex = 44;
            this.label17.Text = "Đã thanh toán:";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1108, 619);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 15);
            this.label18.TabIndex = 45;
            this.label18.Text = "Tổng thanh toán:";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(395, 646);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 15);
            this.label19.TabIndex = 46;
            this.label19.Text = "Khuyến mãi:";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(409, 619);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 15);
            this.label20.TabIndex = 47;
            this.label20.Text = "Tổng tiền:";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(26, 646);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 15);
            this.label21.TabIndex = 48;
            this.label21.Text = "Đã thanh toán:";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(52, 619);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 15);
            this.label22.TabIndex = 49;
            this.label22.Text = "Tổng tiền:";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(417, 670);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 26);
            this.btnPrint.TabIndex = 50;
            this.btnPrint.Text = "Xem và in";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 15F);
            this.textBox1.Location = new System.Drawing.Point(336, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(871, 31);
            this.textBox1.TabIndex = 115;
            this.textBox1.Text = "Mã vạch:";
            // 
            // txtSCodePrd
            // 
            this.txtSCodePrd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSCodePrd.BackColor = System.Drawing.Color.White;
            this.txtSCodePrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSCodePrd.Font = new System.Drawing.Font("Arial", 15F);
            this.txtSCodePrd.Location = new System.Drawing.Point(437, 128);
            this.txtSCodePrd.Multiline = true;
            this.txtSCodePrd.Name = "txtSCodePrd";
            this.txtSCodePrd.Size = new System.Drawing.Size(763, 25);
            this.txtSCodePrd.TabIndex = 116;
            this.txtSCodePrd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSCodePrd_KeyDown);
            // 
            // FrmEximProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 705);
            this.ControlBox = false;
            this.Controls.Add(this.txtSCodePrd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPayed);
            this.Controls.Add(this.txtTotalPay);
            this.Controls.Add(this.txtTotalMoney);
            this.Controls.Add(this.txtPromotionMoney);
            this.Controls.Add(this.txtPromotionPercent);
            this.Controls.Add(this.txtTotalPayed);
            this.Controls.Add(this.txtTotalBill);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridviewBillDetail);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridviewBill);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FrmEximProducts";
            this.Text = "FrmEximProducts";
            this.Load += new System.EventHandler(this.FrmEximProducts_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEximProducts_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewBillDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewBill;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSearchBillID;
        private System.Windows.Forms.DataGridView gridviewBillDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchPartner;
        private System.Windows.Forms.TextBox txtSearchAddress;
        private System.Windows.Forms.DateTimePicker dateSearchTo;
        private System.Windows.Forms.DateTimePicker dateSearchForm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeb;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DateTimePicker dateExim;
        private System.Windows.Forms.Button btnAddPartner;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.TextBox txtTotalPayed;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.TextBox txtPromotionMoney;
        private System.Windows.Forms.TextBox txtPromotionPercent;
        private System.Windows.Forms.TextBox txtTotalPay;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.TextBox txtPayed;
        public System.Windows.Forms.TextBox txtPartner;
        private System.Windows.Forms.ComboBox cboUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSCodePrd;
        private System.Windows.Forms.DateTimePicker dtNgayHen;
        private System.Windows.Forms.Label label11;
    }
}