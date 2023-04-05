namespace TVSGM.Forms
{
    partial class FrmUpdInstruments
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
            this.txtCodeProducts = new System.Windows.Forms.TextBox();
            this.txtNameProducts = new System.Windows.Forms.TextBox();
            this.txtPriceIn = new System.Windows.Forms.TextBox();
            this.txtPriceOut = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboIDUnit = new System.Windows.Forms.ComboBox();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodeProducts
            // 
            this.txtCodeProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeProducts.Location = new System.Drawing.Point(108, 12);
            this.txtCodeProducts.Name = "txtCodeProducts";
            this.txtCodeProducts.Size = new System.Drawing.Size(450, 21);
            this.txtCodeProducts.TabIndex = 0;
            this.txtCodeProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtCodeProducts.Leave += new System.EventHandler(this.txt_Leave);
            this.txtCodeProducts.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtNameProducts
            // 
            this.txtNameProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameProducts.Location = new System.Drawing.Point(108, 39);
            this.txtNameProducts.Name = "txtNameProducts";
            this.txtNameProducts.Size = new System.Drawing.Size(450, 21);
            this.txtNameProducts.TabIndex = 1;
            this.txtNameProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtNameProducts.Leave += new System.EventHandler(this.txt_Leave);
            this.txtNameProducts.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtPriceIn
            // 
            this.txtPriceIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriceIn.Location = new System.Drawing.Point(108, 93);
            this.txtPriceIn.Name = "txtPriceIn";
            this.txtPriceIn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPriceIn.Size = new System.Drawing.Size(450, 21);
            this.txtPriceIn.TabIndex = 3;
            this.txtPriceIn.Text = "0";
            this.txtPriceIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtPriceIn.Leave += new System.EventHandler(this.txt_Leave);
            this.txtPriceIn.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtPriceOut
            // 
            this.txtPriceOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriceOut.Location = new System.Drawing.Point(108, 121);
            this.txtPriceOut.Name = "txtPriceOut";
            this.txtPriceOut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPriceOut.Size = new System.Drawing.Size(450, 21);
            this.txtPriceOut.TabIndex = 4;
            this.txtPriceOut.Text = "0";
            this.txtPriceOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtPriceOut.Leave += new System.EventHandler(this.txt_Leave);
            this.txtPriceOut.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(99, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Ghi nhận";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(18, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(483, 148);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboIDUnit
            // 
            this.cboIDUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIDUnit.FormattingEnabled = true;
            this.cboIDUnit.Location = new System.Drawing.Point(108, 64);
            this.cboIDUnit.Name = "cboIDUnit";
            this.cboIDUnit.Size = new System.Drawing.Size(420, 23);
            this.cboIDUnit.TabIndex = 2;
            this.cboIDUnit.Leave += new System.EventHandler(this.cbo_Leave);
            this.cboIDUnit.Enter += new System.EventHandler(this.cbo_Enter);
            this.cboIDUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUnit.Location = new System.Drawing.Point(534, 64);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(24, 23);
            this.btnAddUnit.TabIndex = 8;
            this.btnAddUnit.Text = "+";
            this.btnAddUnit.UseVisualStyleBackColor = true;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 133;
            this.label11.Text = "Mã sản phẩm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 132;
            this.label9.Text = "Tên sản phẩm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 131;
            this.label8.Text = "Đơn vị tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 130;
            this.label7.Text = "Giá nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 129;
            this.label6.Text = "Giá bán:";
            // 
            // FrmUpdInstruments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 180);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddUnit);
            this.Controls.Add(this.cboIDUnit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCodeProducts);
            this.Controls.Add(this.txtNameProducts);
            this.Controls.Add(this.txtPriceIn);
            this.Controls.Add(this.txtPriceOut);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FrmUpdInstruments";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CẬP NHẬT CÔNG CỤ, DỤNG CỤ";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProduct_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodeProducts;
        private System.Windows.Forms.TextBox txtNameProducts;
        private System.Windows.Forms.TextBox txtPriceIn;
        private System.Windows.Forms.TextBox txtPriceOut;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboIDUnit;
        private System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}