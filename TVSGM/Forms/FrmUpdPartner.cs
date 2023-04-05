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
    public partial class FrmUpdPartner : Form
    {
        public string sCodePartner, sIDPartnerGroup, sIDPartnerType, sNamePartner, sBirthday, sPhone, sAddress, sNameSearch,sIDValue,sCMND,sTenNguoiNha,sDienThoaiNgNha;
        public bool fUpdate = false;
        Classes.clsUpdProducts objUpd = new TVSGM.Classes.clsUpdProducts();
        TVSSys.clsPublic obj = new TVSSys.clsPublic();

        public FrmUpdPartner()
        {
            InitializeComponent();
        }
        #region Load Form
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            cboIDPartnerGroup.BackColor = Color.Aqua;
            Classes.clsGridViewInterface.LoadCbo(cboIDPartnerGroup, cboIDPartnerGroup.Name.Substring(3));
            Classes.clsGridViewInterface.LoadCbo(cboIDPartnerType, cboIDPartnerType.Name.Substring(3));
            cboIDPartnerType.SelectedIndex = 1;
            if (fUpdate == true)
            {
                txtAddress.Text = sAddress;
                txtCodePartner.Text = sCodePartner;
                txtNamePartner.Text = sNamePartner;
                txtPhone.Text = sPhone;
                cboIDPartnerGroup.Text = sIDPartnerGroup;
                cboIDPartnerType.Text = sIDPartnerType;
                dateBirthday.Text = sBirthday;
            }
        }
        #endregion

        #region Add new
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCodePartner.Text = txtNamePartner.Text = String.Empty;
            FrmDir.sIDValue = txtPhone.Text = "0";
        }
        #endregion

        #region Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //if (objUpd.UpdatePartner(Convert.ToInt32(sIDValue), 0, txtCodePartner.Text, "", Convert.ToInt32(cboIDPartnerGroup.SelectedValue), 
                //    Convert.ToInt32(cboIDPartnerType.SelectedValue), txtNamePartner.Text, Convert.ToDateTime(dateBirthday.Text), txtPhone.Text,
                //    txtAddress.Text, obj.NameForSearch(txtNamePartner.Text), "", 0,0, 0, 0,0, Convert.ToDateTime("01/01/1900"), Convert.ToDateTime("01/01/1900"), false, "", "", 0))
                if (objUpd.UpdatePartner(Convert.ToInt32(sIDValue),0,txtCodePartner.Text,Convert.ToInt32(cboIDPartnerGroup.SelectedValue),Convert.ToInt32(cboIDPartnerType.SelectedValue),
                    txtNamePartner.Text, Convert.ToDateTime(dateBirthday.Text), txtPhone.Text, txtAddress.Text, obj.NameForSearch(txtNamePartner.Text), "", Convert.ToDateTime(DateTime.Now.ToString()), false, false,0,txtSoCMND.Text,txtTenNgNha.Text,txtSDTNgNha.Text))
                {
                    Classes.clsMessage.Information("Bạn đã cập nhật thành công");
                    txtAddress.Text = txtCodePartner.Text = txtNamePartner.Text = txtPhone.Text = "";
                    cboIDPartnerGroup.Focus();
                }
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

        private void FrmProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4) btnAdd.PerformClick();
            else if (e.KeyCode == Keys.F6) btnSave.PerformClick();
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

        private void btnAddPartnerGroup_Click(object sender, EventArgs e)
        {
            FrmUpdDir frm = new FrmUpdDir();
            frm.sTableName = btnAddPartnerGroup.Name.ToString().Substring(6);
            frm.ShowDialog();
            Classes.clsGridViewInterface.LoadCbo(cboIDPartnerGroup, cboIDPartnerGroup.Name.Substring(3));
        }
    }
}
