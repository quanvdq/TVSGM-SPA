namespace TVSGM.Forms
{
    partial class FrmRptSale
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
            this.gridviewDir = new System.Windows.Forms.DataGridView();
            this.dateSearch1 = new System.Windows.Forms.DateTimePicker();
            this.dateSearch2 = new System.Windows.Forms.DateTimePicker();
            this.cboIDEmp = new System.Windows.Forms.ComboBox();
            this.cboIDInOut = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtTotalPayed = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDir)).BeginInit();
            this.SuspendLayout();
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
            this.gridviewDir.Location = new System.Drawing.Point(12, 39);
            this.gridviewDir.Name = "gridviewDir";
            this.gridviewDir.ReadOnly = true;
            this.gridviewDir.RowHeadersVisible = false;
            this.gridviewDir.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridviewDir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewDir.Size = new System.Drawing.Size(976, 571);
            this.gridviewDir.TabIndex = 0;
            // 
            // dateSearch1
            // 
            this.dateSearch1.Location = new System.Drawing.Point(111, 10);
            this.dateSearch1.Name = "dateSearch1";
            this.dateSearch1.Size = new System.Drawing.Size(104, 21);
            this.dateSearch1.TabIndex = 10;
            // 
            // dateSearch2
            // 
            this.dateSearch2.Location = new System.Drawing.Point(291, 10);
            this.dateSearch2.Name = "dateSearch2";
            this.dateSearch2.Size = new System.Drawing.Size(104, 21);
            this.dateSearch2.TabIndex = 11;
            // 
            // cboIDEmp
            // 
            this.cboIDEmp.FormattingEnabled = true;
            this.cboIDEmp.Location = new System.Drawing.Point(572, 8);
            this.cboIDEmp.Name = "cboIDEmp";
            this.cboIDEmp.Size = new System.Drawing.Size(164, 23);
            this.cboIDEmp.TabIndex = 14;
            // 
            // cboIDInOut
            // 
            this.cboIDInOut.FormattingEnabled = true;
            this.cboIDInOut.Location = new System.Drawing.Point(414, 8);
            this.cboIDInOut.Name = "cboIDInOut";
            this.cboIDInOut.Size = new System.Drawing.Size(152, 23);
            this.cboIDInOut.TabIndex = 15;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(832, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 26);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Xem và in";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(913, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(751, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Đến ngày:";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.Color.Red;
            this.lblCount.Location = new System.Drawing.Point(12, 626);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(41, 15);
            this.lblCount.TabIndex = 41;
            this.lblCount.Text = "label1";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(710, 620);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 15);
            this.label22.TabIndex = 51;
            this.label22.Text = "Tổng tiền:";
            // 
            // txtTotalPayed
            // 
            this.txtTotalPayed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPayed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTotalPayed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPayed.Location = new System.Drawing.Point(777, 617);
            this.txtTotalPayed.Name = "txtTotalPayed";
            this.txtTotalPayed.ReadOnly = true;
            this.txtTotalPayed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalPayed.Size = new System.Drawing.Size(211, 21);
            this.txtTotalPayed.TabIndex = 50;
            this.txtTotalPayed.Text = "0";
            // 
            // FrmRptSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.ControlBox = false;
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtTotalPayed);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cboIDInOut);
            this.Controls.Add(this.cboIDEmp);
            this.Controls.Add(this.dateSearch2);
            this.Controls.Add(this.dateSearch1);
            this.Controls.Add(this.gridviewDir);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FrmRptSale";
            this.Text = "FrmRptSale";
            this.Load += new System.EventHandler(this.FrmRptSale_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRptSale_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewDir;
        private System.Windows.Forms.DateTimePicker dateSearch1;
        private System.Windows.Forms.DateTimePicker dateSearch2;
        private System.Windows.Forms.ComboBox cboIDEmp;
        private System.Windows.Forms.ComboBox cboIDInOut;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtTotalPayed;
    }
}