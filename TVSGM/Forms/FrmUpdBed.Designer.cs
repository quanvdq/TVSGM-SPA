namespace TVSGM.Forms
{
    partial class FrmUpdBed
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
            this.txtCodeBed = new System.Windows.Forms.TextBox();
            this.txtNameBed = new System.Windows.Forms.TextBox();
            this.txtPriceNight = new System.Windows.Forms.TextBox();
            this.txtPriceDay = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboIDGymRoom = new System.Windows.Forms.ComboBox();
            this.btnAddProductGroup = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPriceIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodeBed
            // 
            this.txtCodeBed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeBed.Location = new System.Drawing.Point(121, 39);
            this.txtCodeBed.Name = "txtCodeBed";
            this.txtCodeBed.Size = new System.Drawing.Size(431, 21);
            this.txtCodeBed.TabIndex = 1;
            this.txtCodeBed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtCodeBed.Leave += new System.EventHandler(this.txt_Leave);
            this.txtCodeBed.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtNameBed
            // 
            this.txtNameBed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameBed.Location = new System.Drawing.Point(121, 66);
            this.txtNameBed.Name = "txtNameBed";
            this.txtNameBed.Size = new System.Drawing.Size(431, 21);
            this.txtNameBed.TabIndex = 2;
            this.txtNameBed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtNameBed.Leave += new System.EventHandler(this.txt_Leave);
            this.txtNameBed.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtPriceNight
            // 
            this.txtPriceNight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriceNight.Location = new System.Drawing.Point(121, 120);
            this.txtPriceNight.Name = "txtPriceNight";
            this.txtPriceNight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPriceNight.Size = new System.Drawing.Size(431, 21);
            this.txtPriceNight.TabIndex = 4;
            this.txtPriceNight.Text = "0";
            this.txtPriceNight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtPriceNight.Leave += new System.EventHandler(this.txt_Leave);
            this.txtPriceNight.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtPriceDay
            // 
            this.txtPriceDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriceDay.Location = new System.Drawing.Point(121, 93);
            this.txtPriceDay.Name = "txtPriceDay";
            this.txtPriceDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPriceDay.Size = new System.Drawing.Size(431, 21);
            this.txtPriceDay.TabIndex = 5;
            this.txtPriceDay.Text = "0";
            this.txtPriceDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtPriceDay.Leave += new System.EventHandler(this.txt_Leave);
            this.txtPriceDay.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(93, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Ghi nhận";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 147);
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
            this.btnClose.Location = new System.Drawing.Point(477, 147);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboIDGymRoom
            // 
            this.cboIDGymRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIDGymRoom.FormattingEnabled = true;
            this.cboIDGymRoom.Location = new System.Drawing.Point(121, 12);
            this.cboIDGymRoom.Name = "cboIDGymRoom";
            this.cboIDGymRoom.Size = new System.Drawing.Size(401, 23);
            this.cboIDGymRoom.TabIndex = 0;
            this.cboIDGymRoom.Leave += new System.EventHandler(this.cbo_Leave);
            this.cboIDGymRoom.Enter += new System.EventHandler(this.cbo_Enter);
            this.cboIDGymRoom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // btnAddProductGroup
            // 
            this.btnAddProductGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProductGroup.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductGroup.Location = new System.Drawing.Point(528, 12);
            this.btnAddProductGroup.Name = "btnAddProductGroup";
            this.btnAddProductGroup.Size = new System.Drawing.Size(24, 23);
            this.btnAddProductGroup.TabIndex = 20;
            this.btnAddProductGroup.Text = "+";
            this.btnAddProductGroup.UseVisualStyleBackColor = true;
            this.btnAddProductGroup.Click += new System.EventHandler(this.btnAddProductGroup_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 15);
            this.label11.TabIndex = 231;
            this.label11.Text = "Nhóm Phòng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 230;
            this.label9.Text = "Mã giường, ghế:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 229;
            this.label8.Text = "Tên giường ghế:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 228;
            this.label7.Text = "Giá ngày:";
            // 
            // lblPriceIn
            // 
            this.lblPriceIn.AutoSize = true;
            this.lblPriceIn.Location = new System.Drawing.Point(58, 123);
            this.lblPriceIn.Name = "lblPriceIn";
            this.lblPriceIn.Size = new System.Drawing.Size(57, 15);
            this.lblPriceIn.TabIndex = 227;
            this.lblPriceIn.Text = "Giá đêm:";
            // 
            // FrmUpdBed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 182);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPriceIn);
            this.Controls.Add(this.btnAddProductGroup);
            this.Controls.Add(this.cboIDGymRoom);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCodeBed);
            this.Controls.Add(this.txtNameBed);
            this.Controls.Add(this.txtPriceNight);
            this.Controls.Add(this.txtPriceDay);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FrmUpdBed";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CẬP NHẬT DANH MỤC GIƯỜNG, GHẾ";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProduct_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodeBed;
        private System.Windows.Forms.TextBox txtNameBed;
        private System.Windows.Forms.TextBox txtPriceNight;
        private System.Windows.Forms.TextBox txtPriceDay;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboIDGymRoom;
        private System.Windows.Forms.Button btnAddProductGroup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPriceIn;
    }
}