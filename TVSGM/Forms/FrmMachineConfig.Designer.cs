namespace TVSGM.Forms
{
    partial class FrmMachineConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddressIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtNumberMachine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCheckTime = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.lblConnect = new System.Windows.Forms.Label();
            this.lblTimeSystem = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ IP máy chấm công:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cổng kết nối:";
            // 
            // txtAddressIP
            // 
            this.txtAddressIP.Location = new System.Drawing.Point(171, 12);
            this.txtAddressIP.Name = "txtAddressIP";
            this.txtAddressIP.Size = new System.Drawing.Size(301, 21);
            this.txtAddressIP.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(171, 39);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(301, 21);
            this.txtPort.TabIndex = 3;
            // 
            // txtNumberMachine
            // 
            this.txtNumberMachine.Location = new System.Drawing.Point(171, 66);
            this.txtNumberMachine.Name = "txtNumberMachine";
            this.txtNumberMachine.Size = new System.Drawing.Size(301, 21);
            this.txtNumberMachine.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số máy:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(166, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 26);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Ghi nhận";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(166, 150);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(148, 26);
            this.btnRestart.TabIndex = 10;
            this.btnRestart.Text = "Khởi động lại máy";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnPing
            // 
            this.btnPing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPing.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPing.Location = new System.Drawing.Point(12, 118);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(148, 26);
            this.btnPing.TabIndex = 12;
            this.btnPing.Text = "Kiểm tra kết nối";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(166, 118);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(148, 26);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCheckTime
            // 
            this.btnCheckTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckTime.Location = new System.Drawing.Point(13, 150);
            this.btnCheckTime.Name = "btnCheckTime";
            this.btnCheckTime.Size = new System.Drawing.Size(148, 26);
            this.btnCheckTime.TabIndex = 14;
            this.btnCheckTime.Text = "Kiểm tra giờ hệ thống";
            this.btnCheckTime.UseVisualStyleBackColor = true;
            this.btnCheckTime.Click += new System.EventHandler(this.btnCheckTime_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutdown.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdown.Location = new System.Drawing.Point(320, 150);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(148, 26);
            this.btnShutdown.TabIndex = 15;
            this.btnShutdown.Text = "Tắt máy";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.ForeColor = System.Drawing.Color.Red;
            this.lblConnect.Location = new System.Drawing.Point(13, 100);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(113, 15);
            this.lblConnect.TabIndex = 16;
            this.lblConnect.Text = "Mời kiểm tra kết nối";
            // 
            // lblTimeSystem
            // 
            this.lblTimeSystem.AutoSize = true;
            this.lblTimeSystem.ForeColor = System.Drawing.Color.Red;
            this.lblTimeSystem.Location = new System.Drawing.Point(168, 100);
            this.lblTimeSystem.Name = "lblTimeSystem";
            this.lblTimeSystem.Size = new System.Drawing.Size(78, 15);
            this.lblTimeSystem.TabIndex = 17;
            this.lblTimeSystem.Text = "Giờ hệ thống";
            this.lblTimeSystem.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(320, 182);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 26);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmMachineConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 221);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTimeSystem);
            this.Controls.Add(this.lblConnect);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.btnCheckTime);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.txtNumberMachine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtAddressIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(490, 250);
            this.MinimumSize = new System.Drawing.Size(490, 250);
            this.Name = "FrmMachineConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CẤU HÌNH MÁY CHẤM CÔNG";
            this.Load += new System.EventHandler(this.FrmTimeKeeperConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddressIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtNumberMachine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCheckTime;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.Label lblTimeSystem;
        private System.Windows.Forms.Button btnClose;
    }
}