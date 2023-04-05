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
    public partial class FrmUpdPartnerFreezen : Form
    {
        public string sIDPartnerRegis, sIDPartner, sCodePartner, sNamePartner, sIDTypGym, sPackGym, sGymRoom, sStartDate, sEndDate, sIDEmp, sCount, sPrice, sTotalPay, sPayed, sNote, sReExIDM = "", sOriginalBill = "", sDayLeft, sID;
        int fDayLeft = 0;
        public bool fUpdate, sActive, sFreeze;
        TVSSys.Connection objCon = new TVSSys.Connection();
        Classes.clsUpdProducts objUpd = new TVSGM.Classes.clsUpdProducts();
        Classes.clsCheckFunc objCheck = new TVSGM.Classes.clsCheckFunc();

        public FrmUpdPartnerFreezen()
        {
            InitializeComponent();
        }

        #region Load Form
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            txtPartner.BackColor = Color.Aqua;
            Classes.clsGridViewInterface.LoadCbo(cboIDTypeGym, cboIDTypeGym.Name.Substring(3));
            Classes.clsGridViewInterface.LoadCbo(cboIDGymRoom, cboIDGymRoom.Name.Substring(3));
            Classes.clsGridViewInterface.LoadCbo(cboIDEmp, cboIDEmp.Name.Substring(3));
            Classes.clsGridViewInterface.LoadCbo(cboIDPackGym,cboIDPackGym.Name.Substring(3));

            txtCodePartner.Text = sCodePartner;
            txtNote.Text = sNote;
            txtPartner.Text = sNamePartner;
            txtPayed.Text = sPayed;
            txtPrice.Text = sPrice;
            txtTimes.Text = sCount;
            txtTotalPay.Text = sTotalPay;
            cboIDEmp.SelectedValue = sIDEmp;
            cboIDGymRoom.SelectedValue = sGymRoom;
            cboIDPackGym.SelectedValue = sPackGym;
            cboIDTypeGym.SelectedValue = sIDTypGym;
            dateStart.Text = sStartDate;
            dateEnd.Text = sEndDate;
            dateEndNew.Text = sEndDate;
            dateStartNew.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if (objCheck.CheckFreeze(sIDPartnerRegis.ToString())) chkActive.Checked = true;
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
                if (objUpd.UpdatePartnerRegis(Convert.ToInt32(sIDPartnerRegis), Convert.ToInt32(sIDPartner), Convert.ToInt32(cboIDGymRoom.SelectedValue), Convert.ToInt32(cboIDTypeGym.SelectedValue), Convert.ToInt32(cboIDPackGym.SelectedValue),
                                        Convert.ToInt32(txtTimes.Text), Convert.ToDouble(txtPrice.Text), Convert.ToDouble(txtTotalPay.Text), Convert.ToDouble(txtPayed.Text), Convert.ToDateTime(dateStartNew.Value), Convert.ToDateTime(dateEndNew.Value), true, Convert.ToInt32(cboIDEmp.SelectedValue), sReExIDM, sReExIDM, txtNote.Text, fDayLeft, Convert.ToBoolean(chkActive.Checked), sID))
                {
                    objUpd.UpdateFreezeHistory(int.Parse(sIDPartnerRegis), int.Parse(sIDPartner), DateTime.Now, Convert.ToBoolean(chkActive.Checked), TVSSys.GlobalModule.objUserName);
                    Classes.clsMessage.Information("Đã cập nhật hoàn thành!");
                }
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

        private void dateStartNew_ValueChanged(object sender, EventArgs e)
        {
            if (sFreeze != true)
            {
                TimeSpan ts;
                ts = Convert.ToDateTime(dateEnd.Value.ToString("dd/MM/yyyy")) - Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                fDayLeft = Convert.ToInt32(ts.TotalDays);
            }
            else
            {
                fDayLeft = Convert.ToInt32(sDayLeft);
            }
            dateEndNew.Value = dateStartNew.Value.AddDays(fDayLeft);
        }

    }
}
