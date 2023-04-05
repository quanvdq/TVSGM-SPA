namespace TVSGM.Forms
{
    partial class FrmRptDebtSupplier
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gridPartnerRegis = new System.Windows.Forms.DataGridView();
            this.dateSearch1 = new System.Windows.Forms.DateTimePicker();
            this.dateSearch2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridviewDir = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtDebs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPartnerRegis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDir)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(913, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(832, 7);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 26);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Xem và in";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSearch.Location = new System.Drawing.Point(591, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 21);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // gridPartnerRegis
            // 
            this.gridPartnerRegis.AllowUserToAddRows = false;
            this.gridPartnerRegis.AllowUserToResizeRows = false;
            this.gridPartnerRegis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPartnerRegis.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridPartnerRegis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPartnerRegis.ColumnHeadersHeight = 28;
            this.gridPartnerRegis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPartnerRegis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridPartnerRegis.Location = new System.Drawing.Point(6, 20);
            this.gridPartnerRegis.Name = "gridPartnerRegis";
            this.gridPartnerRegis.ReadOnly = true;
            this.gridPartnerRegis.RowHeadersVisible = false;
            this.gridPartnerRegis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPartnerRegis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPartnerRegis.Size = new System.Drawing.Size(964, 164);
            this.gridPartnerRegis.TabIndex = 12;
            // 
            // dateSearch1
            // 
            this.dateSearch1.Location = new System.Drawing.Point(93, 7);
            this.dateSearch1.Name = "dateSearch1";
            this.dateSearch1.Size = new System.Drawing.Size(104, 21);
            this.dateSearch1.TabIndex = 15;
            // 
            // dateSearch2
            // 
            this.dateSearch2.Location = new System.Drawing.Point(271, 7);
            this.dateSearch2.Name = "dateSearch2";
            this.dateSearch2.Size = new System.Drawing.Size(104, 21);
            this.dateSearch2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.Location = new System.Drawing.Point(203, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.Location = new System.Drawing.Point(474, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Thông tin tìm kiếm:";
            // 
            // gridviewDir
            // 
            this.gridviewDir.AllowUserToAddRows = false;
            this.gridviewDir.AllowUserToResizeRows = false;
            this.gridviewDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewDir.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridviewDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridviewDir.ColumnHeadersHeight = 28;
            this.gridviewDir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridviewDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridviewDir.Location = new System.Drawing.Point(6, 20);
            this.gridviewDir.Name = "gridviewDir";
            this.gridviewDir.ReadOnly = true;
            this.gridviewDir.RowHeadersVisible = false;
            this.gridviewDir.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridviewDir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewDir.Size = new System.Drawing.Size(964, 353);
            this.gridviewDir.TabIndex = 0;
            this.gridviewDir.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewDir_CellEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridPartnerRegis);
            this.groupBox2.Location = new System.Drawing.Point(12, 448);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(976, 190);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn chứng từ phát sinh trong ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtDebs);
            this.groupBox1.Controls.Add(this.gridviewDir);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 408);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách công nợ";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(692, 382);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 15);
            this.label22.TabIndex = 53;
            this.label22.Text = "Tổng tiền:";
            // 
            // txtDebs
            // 
            this.txtDebs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDebs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtDebs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebs.Location = new System.Drawing.Point(759, 379);
            this.txtDebs.Name = "txtDebs";
            this.txtDebs.ReadOnly = true;
            this.txtDebs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDebs.Size = new System.Drawing.Size(211, 21);
            this.txtDebs.TabIndex = 52;
            this.txtDebs.Text = "0";
            // 
            // FrmRptDebtSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateSearch2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateSearch1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FrmRptDebtSupplier";
            this.Text = "FrmRptDebtSupplier";
            this.Load += new System.EventHandler(this.FrmRptDebtSupplier_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRptDebtSupplier_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridPartnerRegis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDir)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView gridPartnerRegis;
        private System.Windows.Forms.DateTimePicker dateSearch1;
        private System.Windows.Forms.DateTimePicker dateSearch2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridviewDir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtDebs;
    }
}