using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TVSGM.Forms
{
    public partial class FrmUpdPartnerRegis : Form
    {
        public string sID, sIDPartnerRegis, sIDPartner, sCodePartner, sNamePartner, sIDTypGym, sPackGym, sGymRoom, sStartDate, sEndDate, sIDEmp, sCount, sPrice, sTotalPay, sPayed, sNote, sReExIDM = "", sOriginalBill = "";
        public bool fUpdate, sActive, isLoad;
        Classes.clsUpdProducts objUpd = new TVSGM.Classes.clsUpdProducts();
        TVSSys.clsPublic obj = new TVSSys.clsPublic();
        TVSSys.Connection objCon = new TVSSys.Connection();
        Classes.clsInOutBill objBill = new TVSGM.Classes.clsInOutBill();

        public FrmUpdPartnerRegis()
        {
            InitializeComponent();
        }

        #region Load Form
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            isLoad = true;
            txtPartner.BackColor = Color.Aqua;
            Classes.clsGridViewInterface.LoadCbo(cboIDTypeGym, cboIDTypeGym.Name.Substring(3));
            Classes.clsGridViewInterface.LoadCbo(cboIDGymRoom, cboIDGymRoom.Name.Substring(3));
            Classes.clsGridViewInterface.LoadCbo(cboIDEmp, cboIDEmp.Name.Substring(3));
            Classes.clsGridViewInterface.LoadCbo(cboIDPackGym, cboIDPackGym.Name.Substring(3));
            if (fUpdate == false)
            {
                txtPartner.Text = sNamePartner;
                txtCodePartner.Text = sCodePartner;
                if (!string.IsNullOrEmpty(sIDEmp))
                    cboIDEmp.SelectedValue = sIDEmp;
            }
            else
            {
                txtCodePartner.Text = sCodePartner;
                txtNote.Text = sNote;
                txtPartner.Text = sNamePartner;
                cboIDGymRoom.SelectedValue = sGymRoom;
                cboIDTypeGym.SelectedValue = sIDTypGym;
                cboIDPackGym.SelectedValue = sPackGym;
                txtPayed.Text = sPayed;
                txtPrice.Text = sPrice;
                txtTimes.Text = sCount;
                txtTotalPay.Text = sTotalPay;
                dateStart.Text = sStartDate;
                dateEnd.Text = sEndDate;
                chkActive.Checked = sActive;
            }
        }
        #endregion

        #region Add new
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //txtCodePartner.Text = txtNamePartner.Text = String.Empty;
            //FrmDir.sIDValue = txtPhone.Text = "0";
        }
        #endregion

        #region Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //if ((txtPayed.Text != "0") && (sReExIDM == ""))
                //{
                sReExIDM = Classes.clsGetBillID.NextID("PT/" + DateTime.Now.ToString("dd/MM/yyyy") + "-", "ReExIDM", DateTime.Now.ToString("dd"), DateTime.Now.ToString("MM"), DateTime.Now.ToString("yyyy"), "TblBill", "ReExIDM LIKE N'%PT%' AND " +
                                                                                    "Convert(nvarchar,CreateDate,112)='" + DateTime.Now.ToString("yyyyMMdd") + "'");
                sOriginalBill = Classes.clsGetBillID.NextID("DK/" + DateTime.Now.ToString("dd/MM/yyyy") + "-", "OriginalBill", DateTime.Now.ToString("dd"), DateTime.Now.ToString("MM"), DateTime.Now.ToString("yyyy"), "TblBill", "OriginalBill LIKE N'%DK%' AND " +
                                                                                    "Convert(nvarchar,CreateDate,112)='" + DateTime.Now.ToString("yyyyMMdd") + "'");
                //}
                objBill.UpdateInOut(int.Parse(sID), sReExIDM, sReExIDM, sOriginalBill, Convert.ToDateTime(DateTime.Now.ToString()), 3, 1, Convert.ToInt32(sIDPartner), Convert.ToDouble(txtTotalPay.Text), Convert.ToDouble(txtPayed.Text), txtNote.Text, TVSSys.GlobalModule.objUserName, Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")), Convert.ToInt32(cboIDEmp.SelectedValue));
                if (sID == "0") sID = objCon.Get_EXESelect("SELECT TOP 1 ID FROM dbo.TblBill ORDER BY ID DESC");
                objUpd.UpdatePartnerRegis(Convert.ToInt32(sIDPartnerRegis), Convert.ToInt32(sIDPartner), Convert.ToInt32(cboIDGymRoom.SelectedValue), Convert.ToInt32(cboIDTypeGym.SelectedValue), Convert.ToInt32(cboIDPackGym.SelectedValue),
                                        Convert.ToInt32(txtTimes.Text), Convert.ToDouble(txtPrice.Text), Convert.ToDouble(txtTotalPay.Text), Convert.ToDouble(txtPayed.Text), Convert.ToDateTime(dateStart.Value), Convert.ToDateTime(dateEnd.Value), Convert.ToBoolean(chkActive.Checked), Convert.ToInt32(cboIDEmp.SelectedValue), sReExIDM, sOriginalBill, txtNote.Text, 0, false, sID);
                objCon.EXEUpdate("UPDATE TblPartner SET CodePartner='" + txtCodePartner.Text.Trim() + "' WHERE IDPartner=" + Convert.ToInt32(sIDPartner));
                Classes.clsMessage.Information("Đã cập nhật hoàn thành!");
                btnSave.Enabled = false;
            }
            catch
            {
                Classes.clsMessage.Error("Xin vui lòng kiểm tra lại dữ liệu đầu vào");
            }

        }
        #endregion

        #region Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region textchange enter change
        private void FrmProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6) btnSave.PerformClick();
            else if (e.KeyCode == Keys.Escape) btnClose.PerformClick();
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = TVSSys.GlobalModule.objColorEnter;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = TVSSys.GlobalModule.objColorLeave;
        }

        private void cbo_Enter(object sender, EventArgs e)
        {
            ComboBox txt = (ComboBox)sender;
            txt.BackColor = TVSSys.GlobalModule.objColorEnter;
        }

        private void cbo_Leave(object sender, EventArgs e)
        {
            ComboBox txt = (ComboBox)sender;
            txt.BackColor = TVSSys.GlobalModule.objColorLeave;
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{TAB}");
        }
        #endregion

        private void cboIDTypeGym_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classes.clsGridViewInterface.LoadSearchCbo(cboIDPackGym, cboIDPackGym.Name.Substring(3), "IDTypeGym", Convert.ToString(cboIDTypeGym.SelectedValue));
        }

        private void cboIDPackGym_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Text = Convert.ToString(objCon.Get_EXESelectDouble("SELECT Price FROM TblPackGym WHERE IDPackGym=" + Convert.ToInt32(cboIDPackGym.SelectedValue)).ToString(TVSSys.GlobalModule.objFormatMoney));
            txtTimes.Text = Convert.ToString(objCon.Get_EXESelectDouble("SELECT Times FROM TblPackGym WHERE IDPackGym=" + Convert.ToInt32(cboIDPackGym.SelectedValue)).ToString(TVSSys.GlobalModule.objFormatMoney));
            txtTotalPay.Text = Convert.ToString(objCon.Get_EXESelectDouble("SELECT TotalMoney FROM TblPackGym WHERE IDPackGym=" + Convert.ToInt32(cboIDPackGym.SelectedValue)).ToString(TVSSys.GlobalModule.objFormatMoney));
            if (Convert.ToInt32(cboIDTypeGym.SelectedValue) == 2)
            {
                dateEnd.Value = DateTime.Today.AddMonths(Convert.ToInt32(txtTimes.Text));
            }
        }

        #region TextChanged
        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CalMoney();
        }
        #endregion

        double dblTotalPay, dblPrice, dblTimes;

        #region Calculation MoneyPay
        private void CalMoney()
        {
            try
            {
                if (String.IsNullOrEmpty(txtTimes.Text)) return;
                if (String.IsNullOrEmpty(txtPrice.Text)) return;
                if (String.IsNullOrEmpty(txtTotalPay.Text)) return;
                dblTotalPay = double.Parse(txtTotalPay.Text);
                dblPrice = double.Parse(txtPrice.Text);
                dblTimes = double.Parse(txtTimes.Text);
                dblTotalPay = dblPrice * dblTimes;
                txtTotalPay.Text = dblTotalPay.ToString(TVSSys.GlobalModule.objFormatMoney);
                //txtPayed.Text = dblTotalPay.ToString(TVSSys.GlobalModule.objFormatMoney);
            }
            catch
            {
                Classes.clsMessage.Error("Kiểm tra lại giá trị đầu vào!");
            }
        }

        private void CalPrice()
        {
            try
            {
                if (String.IsNullOrEmpty(txtTimes.Text)) return;
                if (String.IsNullOrEmpty(txtPrice.Text)) return;
                if (String.IsNullOrEmpty(txtTotalPay.Text)) return;
                dblTotalPay = double.Parse(txtTotalPay.Text);
                dblPrice = double.Parse(txtPrice.Text);
                dblTimes = double.Parse(txtTimes.Text);
                dblPrice = dblTotalPay / dblTimes;
                txtPrice.Text = dblPrice.ToString(TVSSys.GlobalModule.objFormatMoney);
                //txtPayed.Text = dblTotalPay.ToString(TVSSys.GlobalModule.objFormatMoney);
            }
            catch
            {
                Classes.clsMessage.Error("Kiểm tra lại giá trị đầu vào!");
            }
        }
        #endregion

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.rptReceiveBill.sBillID = sReExIDM;
            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptReceiveBill";
            rpt.Show();
        }

        private void txtTotalPay_TextChanged(object sender, EventArgs e)
        {
            CalPrice();
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            dateEnd.Value = dateStart.Value.AddMonths(Convert.ToInt32(txtTimes.Text));
        }

        private void txtPayed_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPayed.Text.Trim())) return;
            try
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(txtPayed.Text, System.Globalization.NumberStyles.AllowThousands);
                txtPayed.Text = String.Format(culture, "{0:N0}", value);
                txtPayed.Select(txtPayed.Text.Length, 0);
            }
            catch
            {
            }

        }

    }
}
