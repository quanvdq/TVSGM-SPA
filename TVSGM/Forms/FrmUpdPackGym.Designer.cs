namespace TVSGM.Forms
{
    partial class FrmUpdPackGym
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
            this.txtCodePackGym = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTimes = new System.Windows.Forms.TextBox();
            this.txtNamePackGym = new System.Windows.Forms.TextBox();
            this.cboIDTypeGym = new System.Windows.Forms.ComboBox();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodePackGym
            // 
            this.txtCodePackGym.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodePackGym.Location = new System.Drawing.Point(89, 12);
            this.txtCodePackGym.Name = "txtCodePackGym";
            this.txtCodePackGym.Size = new System.Drawing.Size(467, 21);
            this.txtCodePackGym.TabIndex = 0;
            this.txtCodePackGym.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtCodePackGym.Leave += new System.EventHandler(this.txt_Leave);
            this.txtCodePackGym.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(93, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Ghi nhận";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 154);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(481, 154);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtTimes
            // 
            this.txtTimes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimes.Location = new System.Drawing.Point(89, 94);
            this.txtTimes.Name = "txtTimes";
            this.txtTimes.Size = new System.Drawing.Size(79, 21);
            this.txtTimes.TabIndex = 3;
            this.txtTimes.Text = "0";
            this.txtTimes.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtTimes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtTimes.Leave += new System.EventHandler(this.txt_Leave);
            this.txtTimes.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtNamePackGym
            // 
            this.txtNamePackGym.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamePackGym.Location = new System.Drawing.Point(89, 39);
            this.txtNamePackGym.Name = "txtNamePackGym";
            this.txtNamePackGym.Size = new System.Drawing.Size(467, 21);
            this.txtNamePackGym.TabIndex = 1;
            this.txtNamePackGym.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtNamePackGym.Leave += new System.EventHandler(this.txt_Leave);
            this.txtNamePackGym.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // cboIDTypeGym
            // 
            this.cboIDTypeGym.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIDTypeGym.FormattingEnabled = true;
            this.cboIDTypeGym.Location = new System.Drawing.Point(89, 66);
            this.cboIDTypeGym.Name = "cboIDTypeGym";
            this.cboIDTypeGym.Size = new System.Drawing.Size(467, 23);
            this.cboIDTypeGym.TabIndex = 2;
            this.cboIDTypeGym.Leave += new System.EventHandler(this.cbo_Leave);
            this.cboIDTypeGym.Enter += new System.EventHandler(this.cbo_Enter);
            this.cboIDTypeGym.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalMoney.Location = new System.Drawing.Point(89, 122);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.Size = new System.Drawing.Size(467, 21);
            this.txtTotalMoney.TabIndex = 5;
            this.txtTotalMoney.Text = "0";
            this.txtTotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalMoney.TextChanged += new System.EventHandler(this.txtTotalMoney_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Location = new System.Drawing.Point(397, 95);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(159, 21);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 15);
            this.label11.TabIndex = 138;
            this.label11.Text = "Mã gói tập:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 137;
            this.label9.Text = "Tên gói tập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 136;
            this.label8.Text = "Kiểu gói tập:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 135;
            this.label7.Text = "Số lần tập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 134;
            this.label6.Text = "Thành tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 139;
            this.label1.Text = "Đơn giá:";
            // 
            // FrmUpdPackGym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 189);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTotalMoney);
            this.Controls.Add(this.cboIDTypeGym);
            this.Controls.Add(this.txtNamePackGym);
            this.Controls.Add(this.txtTimes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCodePackGym);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FrmUpdPackGym";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CẬP NHẬT DANH SÁCH GÓI TẬP";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.Enter += new System.EventHandler(this.txt_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProduct_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodePackGym;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTimes;
        private System.Windows.Forms.TextBox txtNamePackGym;
        private System.Windows.Forms.ComboBox cboIDTypeGym;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}