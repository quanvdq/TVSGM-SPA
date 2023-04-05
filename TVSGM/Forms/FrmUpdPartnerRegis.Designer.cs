namespace TVSGM.Forms
{
    partial class FrmUpdPartnerRegis
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboIDEmp = new System.Windows.Forms.ComboBox();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cboIDGymRoom = new System.Windows.Forms.ComboBox();
            this.cboIDPackGym = new System.Windows.Forms.ComboBox();
            this.txtTimes = new System.Windows.Forms.TextBox();
            this.txtPartner = new System.Windows.Forms.TextBox();
            this.txtCodePartner = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPayed = new System.Windows.Forms.TextBox();
            this.cboIDTypeGym = new System.Windows.Forms.ComboBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(124, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Ghi nhận";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(374, 393);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 26);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboIDEmp
            // 
            this.cboIDEmp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIDEmp.FormattingEnabled = true;
            this.cboIDEmp.Location = new System.Drawing.Point(124, 226);
            this.cboIDEmp.Name = "cboIDEmp";
            this.cboIDEmp.Size = new System.Drawing.Size(310, 25);
            this.cboIDEmp.TabIndex = 7;
            this.cboIDEmp.Leave += new System.EventHandler(this.cbo_Leave);
            this.cboIDEmp.Enter += new System.EventHandler(this.cbo_Enter);
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalPay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPay.Location = new System.Drawing.Point(124, 280);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.Size = new System.Drawing.Size(92, 25);
            this.txtTotalPay.TabIndex = 10;
            this.txtTotalPay.Text = "0";
            this.txtTotalPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalPay.TextChanged += new System.EventHandler(this.txtTotalPay_TextChanged);
            this.txtTotalPay.Leave += new System.EventHandler(this.txt_Leave);
            this.txtTotalPay.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // dateEnd
            // 
            this.dateEnd.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Location = new System.Drawing.Point(302, 200);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(132, 25);
            this.dateEnd.TabIndex = 6;
            // 
            // dateStart
            // 
            this.dateStart.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Location = new System.Drawing.Point(124, 200);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(105, 25);
            this.dateStart.TabIndex = 5;
            this.dateStart.ValueChanged += new System.EventHandler(this.dateStart_ValueChanged);
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtNote.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(124, 306);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(310, 25);
            this.txtNote.TabIndex = 12;
            this.txtNote.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtNote.Leave += new System.EventHandler(this.txt_Leave);
            this.txtNote.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // cboIDGymRoom
            // 
            this.cboIDGymRoom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIDGymRoom.FormattingEnabled = true;
            this.cboIDGymRoom.Location = new System.Drawing.Point(124, 172);
            this.cboIDGymRoom.Name = "cboIDGymRoom";
            this.cboIDGymRoom.Size = new System.Drawing.Size(310, 25);
            this.cboIDGymRoom.TabIndex = 4;
            this.cboIDGymRoom.Leave += new System.EventHandler(this.cbo_Leave);
            this.cboIDGymRoom.Enter += new System.EventHandler(this.cbo_Enter);
            // 
            // cboIDPackGym
            // 
            this.cboIDPackGym.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIDPackGym.FormattingEnabled = true;
            this.cboIDPackGym.Location = new System.Drawing.Point(124, 144);
            this.cboIDPackGym.Name = "cboIDPackGym";
            this.cboIDPackGym.Size = new System.Drawing.Size(310, 25);
            this.cboIDPackGym.TabIndex = 3;
            this.cboIDPackGym.SelectedIndexChanged += new System.EventHandler(this.cboIDPackGym_SelectedIndexChanged);
            this.cboIDPackGym.Leave += new System.EventHandler(this.cbo_Leave);
            this.cboIDPackGym.Enter += new System.EventHandler(this.cbo_Enter);
            // 
            // txtTimes
            // 
            this.txtTimes.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimes.Location = new System.Drawing.Point(124, 254);
            this.txtTimes.Name = "txtTimes";
            this.txtTimes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTimes.Size = new System.Drawing.Size(92, 25);
            this.txtTimes.TabIndex = 8;
            this.txtTimes.Text = "0";
            this.txtTimes.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtTimes.Leave += new System.EventHandler(this.txt_Leave);
            this.txtTimes.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtPartner
            // 
            this.txtPartner.BackColor = System.Drawing.SystemColors.Window;
            this.txtPartner.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartner.Location = new System.Drawing.Point(124, 90);
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.Size = new System.Drawing.Size(310, 25);
            this.txtPartner.TabIndex = 1;
            this.txtPartner.Leave += new System.EventHandler(this.txt_Leave);
            this.txtPartner.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtCodePartner
            // 
            this.txtCodePartner.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodePartner.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodePartner.Location = new System.Drawing.Point(124, 64);
            this.txtCodePartner.Name = "txtCodePartner";
            this.txtCodePartner.Size = new System.Drawing.Size(310, 25);
            this.txtCodePartner.TabIndex = 0;
            this.txtCodePartner.Leave += new System.EventHandler(this.txt_Leave);
            this.txtCodePartner.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(303, 254);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(131, 25);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.Text = "0";
            this.txtPrice.Leave += new System.EventHandler(this.txt_Leave);
            this.txtPrice.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtPayed
            // 
            this.txtPayed.BackColor = System.Drawing.SystemColors.Window;
            this.txtPayed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayed.Location = new System.Drawing.Point(302, 280);
            this.txtPayed.Name = "txtPayed";
            this.txtPayed.Size = new System.Drawing.Size(132, 25);
            this.txtPayed.TabIndex = 11;
            this.txtPayed.Text = "0";
            this.txtPayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPayed.TextChanged += new System.EventHandler(this.txtPayed_TextChanged);
            this.txtPayed.Leave += new System.EventHandler(this.txt_Leave);
            this.txtPayed.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // cboIDTypeGym
            // 
            this.cboIDTypeGym.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIDTypeGym.FormattingEnabled = true;
            this.cboIDTypeGym.Location = new System.Drawing.Point(124, 116);
            this.cboIDTypeGym.Name = "cboIDTypeGym";
            this.cboIDTypeGym.Size = new System.Drawing.Size(310, 25);
            this.cboIDTypeGym.TabIndex = 2;
            this.cboIDTypeGym.SelectedIndexChanged += new System.EventHandler(this.cboIDTypeGym_SelectedIndexChanged);
            this.cboIDTypeGym.Leave += new System.EventHandler(this.cbo_Leave);
            this.cboIDTypeGym.Enter += new System.EventHandler(this.cbo_Enter);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(125, 337);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(91, 21);
            this.chkActive.TabIndex = 123;
            this.chkActive.Text = "Kích hoạt";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(205, 393);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(101, 26);
            this.btnPrint.TabIndex = 124;
            this.btnPrint.Text = "In phiếu thu";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 142;
            this.label11.Text = "Mã hội viên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 141;
            this.label9.Text = "Hội viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 140;
            this.label8.Text = "Kiểu gói tập:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 139;
            this.label7.Text = "Gói tập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 138;
            this.label6.Text = "Phòng tập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 137;
            this.label5.Text = "Ngày bắt đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 136;
            this.label4.Text = "Kinh doanh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 145;
            this.label1.Text = "Số lượt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 144;
            this.label2.Text = "Thành tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 143;
            this.label3.Text = "Mục tiêu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 148;
            this.label10.Text = "Kết thúc:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 147;
            this.label12.Text = "Đơn giá:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(225, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 146;
            this.label13.Text = "Thanh toán:";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(459, 19);
            this.label14.TabIndex = 149;
            this.label14.Text = "ĐĂNG KÝ, CẬP NHẬT DỊCH VỤ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(459, 1);
            this.label15.TabIndex = 150;
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 372);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(459, 1);
            this.label16.TabIndex = 151;
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmUpdPartnerRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 428);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.cboIDTypeGym);
            this.Controls.Add(this.txtPayed);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCodePartner);
            this.Controls.Add(this.txtPartner);
            this.Controls.Add(this.cboIDEmp);
            this.Controls.Add(this.txtTotalPay);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cboIDGymRoom);
            this.Controls.Add(this.cboIDPackGym);
            this.Controls.Add(this.txtTimes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(500, 475);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 475);
            this.Name = "FrmUpdPartnerRegis";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng ký dịch vụ";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProduct_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboIDEmp;
        private System.Windows.Forms.TextBox txtTotalPay;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cboIDGymRoom;
        private System.Windows.Forms.ComboBox cboIDPackGym;
        private System.Windows.Forms.TextBox txtTimes;
        private System.Windows.Forms.TextBox txtPartner;
        private System.Windows.Forms.TextBox txtCodePartner;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPayed;
        private System.Windows.Forms.ComboBox cboIDTypeGym;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}