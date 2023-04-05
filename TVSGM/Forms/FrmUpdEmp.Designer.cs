namespace TVSGM.Forms
{
    partial class FrmUpdEmp
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
            this.txtCodeEmp = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboIDEmpGroup = new System.Windows.Forms.ComboBox();
            this.btnAddEmpGroup = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtNameEmp = new System.Windows.Forms.TextBox();
            this.cboIDGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodeEmp
            // 
            this.txtCodeEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeEmp.Location = new System.Drawing.Point(105, 12);
            this.txtCodeEmp.Name = "txtCodeEmp";
            this.txtCodeEmp.Size = new System.Drawing.Size(446, 21);
            this.txtCodeEmp.TabIndex = 0;
            this.txtCodeEmp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtCodeEmp.Leave += new System.EventHandler(this.txt_Leave);
            this.txtCodeEmp.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(105, 175);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(446, 21);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.Text = "\r\n";
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtPhone.Leave += new System.EventHandler(this.txt_Leave);
            this.txtPhone.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(93, 201);
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
            this.btnAdd.Location = new System.Drawing.Point(11, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(476, 201);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboIDEmpGroup
            // 
            this.cboIDEmpGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIDEmpGroup.FormattingEnabled = true;
            this.cboIDEmpGroup.Location = new System.Drawing.Point(105, 37);
            this.cboIDEmpGroup.Name = "cboIDEmpGroup";
            this.cboIDEmpGroup.Size = new System.Drawing.Size(416, 23);
            this.cboIDEmpGroup.TabIndex = 1;
            this.cboIDEmpGroup.Leave += new System.EventHandler(this.cbo_Leave);
            this.cboIDEmpGroup.Enter += new System.EventHandler(this.cbo_Enter);
            this.cboIDEmpGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // btnAddEmpGroup
            // 
            this.btnAddEmpGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEmpGroup.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmpGroup.Location = new System.Drawing.Point(527, 37);
            this.btnAddEmpGroup.Name = "btnAddEmpGroup";
            this.btnAddEmpGroup.Size = new System.Drawing.Size(24, 23);
            this.btnAddEmpGroup.TabIndex = 20;
            this.btnAddEmpGroup.Text = "+";
            this.btnAddEmpGroup.UseVisualStyleBackColor = true;
            this.btnAddEmpGroup.Click += new System.EventHandler(this.btnAddEmpGroup_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(105, 148);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(446, 21);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtAddress.Leave += new System.EventHandler(this.txt_Leave);
            this.txtAddress.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // dateBirthday
            // 
            this.dateBirthday.Location = new System.Drawing.Point(105, 93);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(446, 21);
            this.dateBirthday.TabIndex = 3;
            this.dateBirthday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txtNameEmp
            // 
            this.txtNameEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameEmp.Location = new System.Drawing.Point(105, 66);
            this.txtNameEmp.Name = "txtNameEmp";
            this.txtNameEmp.Size = new System.Drawing.Size(446, 21);
            this.txtNameEmp.TabIndex = 2;
            this.txtNameEmp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtNameEmp.Leave += new System.EventHandler(this.txt_Leave);
            this.txtNameEmp.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // cboIDGender
            // 
            this.cboIDGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIDGender.FormattingEnabled = true;
            this.cboIDGender.Location = new System.Drawing.Point(105, 120);
            this.cboIDGender.Name = "cboIDGender";
            this.cboIDGender.Size = new System.Drawing.Size(446, 23);
            this.cboIDGender.TabIndex = 4;
            this.cboIDGender.Leave += new System.EventHandler(this.cbo_Leave);
            this.cboIDGender.Enter += new System.EventHandler(this.cbo_Enter);
            this.cboIDGender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 121;
            this.label4.Text = "Điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 122;
            this.label5.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 123;
            this.label6.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 124;
            this.label7.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 125;
            this.label8.Text = "Tên nhân viên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 126;
            this.label9.Text = "Bộ phận:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 128;
            this.label11.Text = "Mã nhân viên:";
            // 
            // FrmUpdEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 236);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboIDGender);
            this.Controls.Add(this.txtNameEmp);
            this.Controls.Add(this.dateBirthday);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnAddEmpGroup);
            this.Controls.Add(this.cboIDEmpGroup);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCodeEmp);
            this.Controls.Add(this.txtPhone);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FrmUpdEmp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CẬP NHẬT DANH SÁCH NHÂN VIÊN";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.Enter += new System.EventHandler(this.txt_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProduct_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodeEmp;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboIDEmpGroup;
        private System.Windows.Forms.Button btnAddEmpGroup;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dateBirthday;
        private System.Windows.Forms.TextBox txtNameEmp;
        private System.Windows.Forms.ComboBox cboIDGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}