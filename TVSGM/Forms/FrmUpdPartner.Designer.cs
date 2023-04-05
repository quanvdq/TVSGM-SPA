namespace TVSGM.Forms
{
    partial class FrmUpdPartner
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
            this.txtCodePartner = new System.Windows.Forms.TextBox();
            this.txtNamePartner = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboIDPartnerGroup = new System.Windows.Forms.ComboBox();
            this.cboIDPartnerType = new System.Windows.Forms.ComboBox();
            this.btnAddPartnerGroup = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDTNgNha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNgNha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodePartner
            // 
            this.txtCodePartner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodePartner.Location = new System.Drawing.Point(120, 39);
            this.txtCodePartner.Name = "txtCodePartner";
            this.txtCodePartner.Size = new System.Drawing.Size(429, 25);
            this.txtCodePartner.TabIndex = 1;
            this.txtCodePartner.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtCodePartner.Leave += new System.EventHandler(this.txt_Leave);
            this.txtCodePartner.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtNamePartner
            // 
            this.txtNamePartner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamePartner.Location = new System.Drawing.Point(120, 93);
            this.txtNamePartner.Name = "txtNamePartner";
            this.txtNamePartner.Size = new System.Drawing.Size(429, 25);
            this.txtNamePartner.TabIndex = 3;
            this.txtNamePartner.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtNamePartner.Leave += new System.EventHandler(this.txt_Leave);
            this.txtNamePartner.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(372, 148);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(177, 25);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.Text = "\r\n";
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtPhone.Leave += new System.EventHandler(this.txt_Leave);
            this.txtPhone.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(90, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Ghi nhận";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(9, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(475, 304);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboIDPartnerGroup
            // 
            this.cboIDPartnerGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIDPartnerGroup.FormattingEnabled = true;
            this.cboIDPartnerGroup.Location = new System.Drawing.Point(120, 12);
            this.cboIDPartnerGroup.Name = "cboIDPartnerGroup";
            this.cboIDPartnerGroup.Size = new System.Drawing.Size(399, 25);
            this.cboIDPartnerGroup.TabIndex = 0;
            this.cboIDPartnerGroup.Leave += new System.EventHandler(this.cbo_Leave);
            this.cboIDPartnerGroup.Enter += new System.EventHandler(this.cbo_Enter);
            this.cboIDPartnerGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // cboIDPartnerType
            // 
            this.cboIDPartnerType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIDPartnerType.FormattingEnabled = true;
            this.cboIDPartnerType.Location = new System.Drawing.Point(120, 64);
            this.cboIDPartnerType.Name = "cboIDPartnerType";
            this.cboIDPartnerType.Size = new System.Drawing.Size(429, 25);
            this.cboIDPartnerType.TabIndex = 2;
            this.cboIDPartnerType.Leave += new System.EventHandler(this.cbo_Leave);
            this.cboIDPartnerType.Enter += new System.EventHandler(this.cbo_Enter);
            this.cboIDPartnerType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // btnAddPartnerGroup
            // 
            this.btnAddPartnerGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPartnerGroup.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPartnerGroup.Location = new System.Drawing.Point(525, 12);
            this.btnAddPartnerGroup.Name = "btnAddPartnerGroup";
            this.btnAddPartnerGroup.Size = new System.Drawing.Size(24, 23);
            this.btnAddPartnerGroup.TabIndex = 20;
            this.btnAddPartnerGroup.Text = "+";
            this.btnAddPartnerGroup.UseVisualStyleBackColor = true;
            this.btnAddPartnerGroup.Click += new System.EventHandler(this.btnAddPartnerGroup_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(120, 179);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(429, 25);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtAddress.Leave += new System.EventHandler(this.txt_Leave);
            this.txtAddress.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // dateBirthday
            // 
            this.dateBirthday.Location = new System.Drawing.Point(120, 120);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(431, 25);
            this.dateBirthday.TabIndex = 4;
            this.dateBirthday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 17);
            this.label11.TabIndex = 135;
            this.label11.Text = "Nhóm khách hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 134;
            this.label9.Text = "Mã khách hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 133;
            this.label8.Text = "Kiểu khách hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 132;
            this.label7.Text = "Tên khách hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 131;
            this.label6.Text = "Sinh ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 130;
            this.label5.Text = "Điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 129;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoCMND.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCMND.Location = new System.Drawing.Point(120, 149);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(169, 25);
            this.txtSoCMND.TabIndex = 136;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 137;
            this.label10.Text = "CCCD/CMT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 142;
            this.label1.Text = "Điện thoại:";
            // 
            // txtSDTNgNha
            // 
            this.txtSDTNgNha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSDTNgNha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTNgNha.Location = new System.Drawing.Point(89, 266);
            this.txtSDTNgNha.Name = "txtSDTNgNha";
            this.txtSDTNgNha.Size = new System.Drawing.Size(462, 25);
            this.txtSDTNgNha.TabIndex = 141;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 140;
            this.label2.Text = "Họ và tên:";
            // 
            // txtTenNgNha
            // 
            this.txtTenNgNha.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenNgNha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNgNha.Location = new System.Drawing.Point(89, 235);
            this.txtTenNgNha.Name = "txtTenNgNha";
            this.txtTenNgNha.Size = new System.Drawing.Size(462, 25);
            this.txtTenNgNha.TabIndex = 139;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 18);
            this.label3.TabIndex = 138;
            this.label3.Text = "Thông tin liên hệ khi cần";
            // 
            // FrmUpdPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSDTNgNha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenNgNha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoCMND);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateBirthday);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnAddPartnerGroup);
            this.Controls.Add(this.cboIDPartnerType);
            this.Controls.Add(this.cboIDPartnerGroup);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCodePartner);
            this.Controls.Add(this.txtNamePartner);
            this.Controls.Add(this.txtPhone);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FrmUpdPartner";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CẬP NHẬT DANH SÁCH KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProduct_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodePartner;
        private System.Windows.Forms.TextBox txtNamePartner;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboIDPartnerGroup;
        private System.Windows.Forms.ComboBox cboIDPartnerType;
        private System.Windows.Forms.Button btnAddPartnerGroup;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dateBirthday;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDTNgNha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNgNha;
        private System.Windows.Forms.Label label3;
    }
}