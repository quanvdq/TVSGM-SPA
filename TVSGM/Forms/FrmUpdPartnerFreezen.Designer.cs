namespace TVSGM.Forms
{
    partial class FrmUpdPartnerFreezen
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
            this.dateStartNew = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dateEndNew = new System.Windows.Forms.DateTimePicker();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(166, 421);
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
            this.btnClose.Location = new System.Drawing.Point(244, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboIDEmp
            // 
            this.cboIDEmp.Enabled = false;
            this.cboIDEmp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIDEmp.FormattingEnabled = true;
            this.cboIDEmp.Location = new System.Drawing.Point(124, 260);
            this.cboIDEmp.Name = "cboIDEmp";
            this.cboIDEmp.Size = new System.Drawing.Size(310, 23);
            this.cboIDEmp.TabIndex = 7;
            this.cboIDEmp.Leave += new System.EventHandler(this.cbo_Leave);
            this.cboIDEmp.Enter += new System.EventHandler(this.cbo_Enter);
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalPay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPay.Location = new System.Drawing.Point(124, 316);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.ReadOnly = true;
            this.txtTotalPay.Size = new System.Drawing.Size(92, 21);
            this.txtTotalPay.TabIndex = 10;
            this.txtTotalPay.Text = "0";
            this.txtTotalPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalPay.Leave += new System.EventHandler(this.txt_Leave);
            this.txtTotalPay.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // dateEnd
            // 
            this.dateEnd.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Enabled = false;
            this.dateEnd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Location = new System.Drawing.Point(329, 202);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(105, 21);
            this.dateEnd.TabIndex = 6;
            // 
            // dateStart
            // 
            this.dateStart.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Enabled = false;
            this.dateStart.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Location = new System.Drawing.Point(125, 202);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(105, 21);
            this.dateStart.TabIndex = 5;
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtNote.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(124, 343);
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(310, 21);
            this.txtNote.TabIndex = 12;
            this.txtNote.Leave += new System.EventHandler(this.txt_Leave);
            this.txtNote.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // cboIDGymRoom
            // 
            this.cboIDGymRoom.Enabled = false;
            this.cboIDGymRoom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIDGymRoom.FormattingEnabled = true;
            this.cboIDGymRoom.Location = new System.Drawing.Point(124, 170);
            this.cboIDGymRoom.Name = "cboIDGymRoom";
            this.cboIDGymRoom.Size = new System.Drawing.Size(310, 23);
            this.cboIDGymRoom.TabIndex = 4;
            this.cboIDGymRoom.Leave += new System.EventHandler(this.cbo_Leave);
            this.cboIDGymRoom.Enter += new System.EventHandler(this.cbo_Enter);
            // 
            // cboIDPackGym
            // 
            this.cboIDPackGym.Enabled = false;
            this.cboIDPackGym.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIDPackGym.FormattingEnabled = true;
            this.cboIDPackGym.Location = new System.Drawing.Point(124, 143);
            this.cboIDPackGym.Name = "cboIDPackGym";
            this.cboIDPackGym.Size = new System.Drawing.Size(310, 23);
            this.cboIDPackGym.TabIndex = 3;
            this.cboIDPackGym.Leave += new System.EventHandler(this.cbo_Leave);
            this.cboIDPackGym.Enter += new System.EventHandler(this.cbo_Enter);
            // 
            // txtTimes
            // 
            this.txtTimes.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimes.Location = new System.Drawing.Point(124, 289);
            this.txtTimes.Name = "txtTimes";
            this.txtTimes.ReadOnly = true;
            this.txtTimes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTimes.Size = new System.Drawing.Size(92, 21);
            this.txtTimes.TabIndex = 8;
            this.txtTimes.Text = "0";
            this.txtTimes.Leave += new System.EventHandler(this.txt_Leave);
            this.txtTimes.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtPartner
            // 
            this.txtPartner.BackColor = System.Drawing.SystemColors.Window;
            this.txtPartner.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartner.Location = new System.Drawing.Point(124, 87);
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.ReadOnly = true;
            this.txtPartner.Size = new System.Drawing.Size(310, 21);
            this.txtPartner.TabIndex = 1;
            this.txtPartner.Leave += new System.EventHandler(this.txt_Leave);
            this.txtPartner.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtCodePartner
            // 
            this.txtCodePartner.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodePartner.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodePartner.Location = new System.Drawing.Point(124, 60);
            this.txtCodePartner.Name = "txtCodePartner";
            this.txtCodePartner.ReadOnly = true;
            this.txtCodePartner.Size = new System.Drawing.Size(310, 21);
            this.txtCodePartner.TabIndex = 0;
            this.txtCodePartner.Leave += new System.EventHandler(this.txt_Leave);
            this.txtCodePartner.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(329, 289);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(105, 21);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.Text = "0";
            this.txtPrice.Leave += new System.EventHandler(this.txt_Leave);
            this.txtPrice.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtPayed
            // 
            this.txtPayed.BackColor = System.Drawing.SystemColors.Window;
            this.txtPayed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayed.Location = new System.Drawing.Point(329, 316);
            this.txtPayed.Name = "txtPayed";
            this.txtPayed.ReadOnly = true;
            this.txtPayed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPayed.Size = new System.Drawing.Size(105, 21);
            this.txtPayed.TabIndex = 11;
            this.txtPayed.Text = "0";
            this.txtPayed.Leave += new System.EventHandler(this.txt_Leave);
            this.txtPayed.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // cboIDTypeGym
            // 
            this.cboIDTypeGym.Enabled = false;
            this.cboIDTypeGym.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIDTypeGym.FormattingEnabled = true;
            this.cboIDTypeGym.Location = new System.Drawing.Point(124, 114);
            this.cboIDTypeGym.Name = "cboIDTypeGym";
            this.cboIDTypeGym.Size = new System.Drawing.Size(310, 23);
            this.cboIDTypeGym.TabIndex = 2;
            this.cboIDTypeGym.Leave += new System.EventHandler(this.cbo_Leave);
            this.cboIDTypeGym.Enter += new System.EventHandler(this.cbo_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 142;
            this.label11.Text = "Mã hội viên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 141;
            this.label9.Text = "Hội viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 140;
            this.label8.Text = "Kiểu gói tập:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 139;
            this.label7.Text = "Gói tập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 138;
            this.label6.Text = "Phòng tập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 137;
            this.label5.Text = "Ngày bắt đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 136;
            this.label4.Text = "Kinh doanh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 145;
            this.label1.Text = "Số lượt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 144;
            this.label2.Text = "Thành tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 143;
            this.label3.Text = "Mục tiêu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 148;
            this.label10.Text = "Kết thúc:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(269, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 15);
            this.label12.TabIndex = 147;
            this.label12.Text = "Đơn giá:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(251, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 15);
            this.label13.TabIndex = 146;
            this.label13.Text = "Thanh toán:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 15);
            this.label14.TabIndex = 150;
            this.label14.Text = "Ngày bắt đầu mới:";
            // 
            // dateStartNew
            // 
            this.dateStartNew.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStartNew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStartNew.Location = new System.Drawing.Point(124, 231);
            this.dateStartNew.Name = "dateStartNew";
            this.dateStartNew.Size = new System.Drawing.Size(105, 21);
            this.dateStartNew.TabIndex = 149;
            this.dateStartNew.ValueChanged += new System.EventHandler(this.dateStartNew_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(244, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 15);
            this.label15.TabIndex = 152;
            this.label15.Text = "Kết thúc mới:";
            // 
            // dateEndNew
            // 
            this.dateEndNew.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEndNew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEndNew.Location = new System.Drawing.Point(329, 230);
            this.dateEndNew.Name = "dateEndNew";
            this.dateEndNew.Size = new System.Drawing.Size(105, 21);
            this.dateEndNew.TabIndex = 151;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(124, 370);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(139, 19);
            this.chkActive.TabIndex = 153;
            this.chkActive.Text = "Kích hoạt đóng băng";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(459, 1);
            this.label16.TabIndex = 155;
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(459, 19);
            this.label17.TabIndex = 154;
            this.label17.Text = "ĐĂNG KÝ, CẬP NHẬT DỊCH VỤ KHÁCH HÀNG";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 406);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(459, 1);
            this.label18.TabIndex = 156;
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmUpdPartnerFreezen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateEndNew);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateStartNew);
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
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FrmUpdPartnerFreezen";
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
        private System.Windows.Forms.DateTimePicker dateStartNew;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateEndNew;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}