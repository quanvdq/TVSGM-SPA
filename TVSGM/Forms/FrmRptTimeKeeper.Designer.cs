namespace TVSGM.Forms
{
    partial class FrmRptTimeKeeper
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
            this.gridTimeKeeping = new System.Windows.Forms.DataGridView();
            this.dateSearch1 = new System.Windows.Forms.DateTimePicker();
            this.dateSearch2 = new System.Windows.Forms.DateTimePicker();
            this.cboIDEmp = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.cboTypeKeeper = new System.Windows.Forms.ComboBox();
            this.cboIDTimeShiftConfig = new System.Windows.Forms.ComboBox();
            this.btnPrintDetail = new System.Windows.Forms.Button();
            this.gridTimeDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridTimeKeeping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTimeDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTimeKeeping
            // 
            this.gridTimeKeeping.AllowUserToAddRows = false;
            this.gridTimeKeeping.AllowUserToResizeRows = false;
            this.gridTimeKeeping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gridTimeKeeping.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridTimeKeeping.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTimeKeeping.ColumnHeadersHeight = 28;
            this.gridTimeKeeping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridTimeKeeping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridTimeKeeping.Location = new System.Drawing.Point(12, 39);
            this.gridTimeKeeping.Name = "gridTimeKeeping";
            this.gridTimeKeeping.ReadOnly = true;
            this.gridTimeKeeping.RowHeadersVisible = false;
            this.gridTimeKeeping.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridTimeKeeping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTimeKeeping.Size = new System.Drawing.Size(514, 571);
            this.gridTimeKeeping.TabIndex = 0;
            this.gridTimeKeeping.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTimeKeeping_CellEnter);
            // 
            // dateSearch1
            // 
            this.dateSearch1.Location = new System.Drawing.Point(72, 10);
            this.dateSearch1.Name = "dateSearch1";
            this.dateSearch1.Size = new System.Drawing.Size(104, 21);
            this.dateSearch1.TabIndex = 10;
            // 
            // dateSearch2
            // 
            this.dateSearch2.Location = new System.Drawing.Point(252, 10);
            this.dateSearch2.Name = "dateSearch2";
            this.dateSearch2.Size = new System.Drawing.Size(104, 21);
            this.dateSearch2.TabIndex = 11;
            // 
            // cboIDEmp
            // 
            this.cboIDEmp.FormattingEnabled = true;
            this.cboIDEmp.Location = new System.Drawing.Point(362, 8);
            this.cboIDEmp.Name = "cboIDEmp";
            this.cboIDEmp.Size = new System.Drawing.Size(164, 23);
            this.cboIDEmp.TabIndex = 14;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(93, 616);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 26);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Xem và in";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(913, 616);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(12, 616);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Xem công";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Đến ngày:";
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(863, 5);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(125, 26);
            this.btnDownload.TabIndex = 52;
            this.btnDownload.Text = "Tải công về máy";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // cboTypeKeeper
            // 
            this.cboTypeKeeper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeKeeper.FormattingEnabled = true;
            this.cboTypeKeeper.Items.AddRange(new object[] {
            "Chấm công theo ca",
            "Chấm công theo HC"});
            this.cboTypeKeeper.Location = new System.Drawing.Point(541, 8);
            this.cboTypeKeeper.Name = "cboTypeKeeper";
            this.cboTypeKeeper.Size = new System.Drawing.Size(154, 23);
            this.cboTypeKeeper.TabIndex = 53;
            // 
            // cboIDTimeShiftConfig
            // 
            this.cboIDTimeShiftConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDTimeShiftConfig.FormattingEnabled = true;
            this.cboIDTimeShiftConfig.Items.AddRange(new object[] {
            "Chấm công theo ca",
            "Chấm công theo HC"});
            this.cboIDTimeShiftConfig.Location = new System.Drawing.Point(701, 8);
            this.cboIDTimeShiftConfig.Name = "cboIDTimeShiftConfig";
            this.cboIDTimeShiftConfig.Size = new System.Drawing.Size(154, 23);
            this.cboIDTimeShiftConfig.TabIndex = 54;
            // 
            // btnPrintDetail
            // 
            this.btnPrintDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintDetail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDetail.Location = new System.Drawing.Point(174, 616);
            this.btnPrintDetail.Name = "btnPrintDetail";
            this.btnPrintDetail.Size = new System.Drawing.Size(130, 26);
            this.btnPrintDetail.TabIndex = 55;
            this.btnPrintDetail.Text = "Xem và in chi tiết";
            this.btnPrintDetail.UseVisualStyleBackColor = true;
            this.btnPrintDetail.Click += new System.EventHandler(this.btnPrintDetail_Click);
            // 
            // gridTimeDetail
            // 
            this.gridTimeDetail.AllowUserToAddRows = false;
            this.gridTimeDetail.AllowUserToResizeRows = false;
            this.gridTimeDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTimeDetail.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridTimeDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTimeDetail.ColumnHeadersHeight = 28;
            this.gridTimeDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridTimeDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridTimeDetail.Location = new System.Drawing.Point(541, 37);
            this.gridTimeDetail.Name = "gridTimeDetail";
            this.gridTimeDetail.ReadOnly = true;
            this.gridTimeDetail.RowHeadersVisible = false;
            this.gridTimeDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridTimeDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTimeDetail.Size = new System.Drawing.Size(447, 571);
            this.gridTimeDetail.TabIndex = 56;
            // 
            // FrmRptTimeKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.ControlBox = false;
            this.Controls.Add(this.gridTimeDetail);
            this.Controls.Add(this.btnPrintDetail);
            this.Controls.Add(this.cboIDTimeShiftConfig);
            this.Controls.Add(this.cboTypeKeeper);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cboIDEmp);
            this.Controls.Add(this.dateSearch2);
            this.Controls.Add(this.dateSearch1);
            this.Controls.Add(this.gridTimeKeeping);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FrmRptTimeKeeper";
            this.Text = "FrmRptTimeKeeper";
            this.Load += new System.EventHandler(this.FrmRptTimeKeeper_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRptTimeKeeper_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridTimeKeeping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTimeDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTimeKeeping;
        private System.Windows.Forms.DateTimePicker dateSearch1;
        private System.Windows.Forms.DateTimePicker dateSearch2;
        private System.Windows.Forms.ComboBox cboIDEmp;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ComboBox cboTypeKeeper;
        private System.Windows.Forms.ComboBox cboIDTimeShiftConfig;
        private System.Windows.Forms.Button btnPrintDetail;
        private System.Windows.Forms.DataGridView gridTimeDetail;
    }
}