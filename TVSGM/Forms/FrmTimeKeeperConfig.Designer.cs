namespace TVSGM.Forms
{
    partial class FrmTimeKeeperConfig
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtHourLunchStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHourFinish = new System.Windows.Forms.TextBox();
            this.txtHourStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHourLunchFinish = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumHour = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumTimekeeping = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHourMorningStart = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHourMorningFinish = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHourAfternoonFinish = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHourAfternoonStart = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridTimeShiftConfig = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTimeShiftConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(457, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Ghi nhận";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtHourLunchStart
            // 
            this.txtHourLunchStart.Location = new System.Drawing.Point(137, 33);
            this.txtHourLunchStart.Name = "txtHourLunchStart";
            this.txtHourLunchStart.Size = new System.Drawing.Size(78, 21);
            this.txtHourLunchStart.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Giờ bắt đầu nghỉ trưa:";
            // 
            // txtHourFinish
            // 
            this.txtHourFinish.Location = new System.Drawing.Point(137, 87);
            this.txtHourFinish.Name = "txtHourFinish";
            this.txtHourFinish.Size = new System.Drawing.Size(78, 21);
            this.txtHourFinish.TabIndex = 23;
            // 
            // txtHourStart
            // 
            this.txtHourStart.Location = new System.Drawing.Point(137, 6);
            this.txtHourStart.Name = "txtHourStart";
            this.txtHourStart.Size = new System.Drawing.Size(78, 21);
            this.txtHourStart.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kết thúc giờ làm việc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Giờ vào làm việc:";
            // 
            // txtHourLunchFinish
            // 
            this.txtHourLunchFinish.Location = new System.Drawing.Point(137, 60);
            this.txtHourLunchFinish.Name = "txtHourLunchFinish";
            this.txtHourLunchFinish.Size = new System.Drawing.Size(78, 21);
            this.txtHourLunchFinish.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Giờ kết thúc nghỉ trưa:";
            // 
            // txtNumHour
            // 
            this.txtNumHour.Location = new System.Drawing.Point(137, 114);
            this.txtNumHour.Name = "txtNumHour";
            this.txtNumHour.Size = new System.Drawing.Size(78, 21);
            this.txtNumHour.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tổng số giờ:";
            // 
            // txtNumTimekeeping
            // 
            this.txtNumTimekeeping.Location = new System.Drawing.Point(137, 141);
            this.txtNumTimekeeping.Name = "txtNumTimekeeping";
            this.txtNumTimekeeping.Size = new System.Drawing.Size(78, 21);
            this.txtNumTimekeeping.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Quy đổi công:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Bắt đầu giờ vào buổi sáng:";
            // 
            // txtHourMorningStart
            // 
            this.txtHourMorningStart.Location = new System.Drawing.Point(450, 5);
            this.txtHourMorningStart.Name = "txtHourMorningStart";
            this.txtHourMorningStart.Size = new System.Drawing.Size(78, 21);
            this.txtHourMorningStart.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Kết thúc giờ vào buổi sáng:";
            // 
            // txtHourMorningFinish
            // 
            this.txtHourMorningFinish.Location = new System.Drawing.Point(450, 32);
            this.txtHourMorningFinish.Name = "txtHourMorningFinish";
            this.txtHourMorningFinish.Size = new System.Drawing.Size(78, 21);
            this.txtHourMorningFinish.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 15);
            this.label9.TabIndex = 41;
            this.label9.Text = "Kết thúc giờ vào buổi chiều:";
            // 
            // txtHourAfternoonFinish
            // 
            this.txtHourAfternoonFinish.Location = new System.Drawing.Point(450, 87);
            this.txtHourAfternoonFinish.Name = "txtHourAfternoonFinish";
            this.txtHourAfternoonFinish.Size = new System.Drawing.Size(78, 21);
            this.txtHourAfternoonFinish.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 15);
            this.label10.TabIndex = 39;
            this.label10.Text = "Bắt đầu giờ vào buổi chiều:";
            // 
            // txtHourAfternoonStart
            // 
            this.txtHourAfternoonStart.Location = new System.Drawing.Point(450, 60);
            this.txtHourAfternoonStart.Name = "txtHourAfternoonStart";
            this.txtHourAfternoonStart.Size = new System.Drawing.Size(78, 21);
            this.txtHourAfternoonStart.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(319, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 15);
            this.label11.TabIndex = 43;
            this.label11.Text = "Cho phép đi trễ(Phút):";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(450, 114);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(78, 21);
            this.txtDelay.TabIndex = 42;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(545, 202);
            this.tabControl1.TabIndex = 44;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtDelay);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtHourStart);
            this.tabPage1.Controls.Add(this.txtHourAfternoonFinish);
            this.tabPage1.Controls.Add(this.txtHourFinish);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtHourLunchStart);
            this.tabPage1.Controls.Add(this.txtHourAfternoonStart);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtHourLunchFinish);
            this.tabPage1.Controls.Add(this.txtHourMorningFinish);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtNumHour);
            this.tabPage1.Controls.Add(this.txtHourMorningStart);
            this.tabPage1.Controls.Add(this.txtNumTimekeeping);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(537, 174);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Theo giờ hành chính";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridTimeShiftConfig);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(537, 174);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Theo ca";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridTimeShiftConfig
            // 
            this.gridTimeShiftConfig.AllowUserToResizeColumns = false;
            this.gridTimeShiftConfig.AllowUserToResizeRows = false;
            this.gridTimeShiftConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTimeShiftConfig.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridTimeShiftConfig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTimeShiftConfig.ColumnHeadersHeight = 40;
            this.gridTimeShiftConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridTimeShiftConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridTimeShiftConfig.Location = new System.Drawing.Point(6, 5);
            this.gridTimeShiftConfig.Name = "gridTimeShiftConfig";
            this.gridTimeShiftConfig.RowHeadersVisible = false;
            this.gridTimeShiftConfig.RowHeadersWidth = 80;
            this.gridTimeShiftConfig.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridTimeShiftConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTimeShiftConfig.Size = new System.Drawing.Size(525, 164);
            this.gridTimeShiftConfig.TabIndex = 114;
            // 
            // FrmTimeKeeperConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 254);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTimeKeeperConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CẤU HÌNH THỜI GIAN CHẤM CÔNG";
            this.Load += new System.EventHandler(this.FrmTimeKeeperConfig_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTimeShiftConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtHourLunchStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHourFinish;
        private System.Windows.Forms.TextBox txtHourStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHourLunchFinish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumTimekeeping;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHourMorningStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHourMorningFinish;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHourAfternoonFinish;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHourAfternoonStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gridTimeShiftConfig;
    }
}