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
    public partial class FrmUpdEmp : Form
    {
        public string sCodeEmp, sIDEmpGroup, sNameEmp, sIDGender, sBirthday, sAddress, sPhone, sIDValue;
        public bool fUpdate = false;
        Classes.clsUpdProducts objUpd = new TVSGM.Classes.clsUpdProducts();
        TVSSys.clsPublic obj = new TVSSys.clsPublic();

        public FrmUpdEmp()
        {
            InitializeComponent();
        }
        #region Load Form
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            cboIDEmpGroup.BackColor = Color.Aqua;
            Classes.clsGridViewInterface.LoadCbo(cboIDEmpGroup, cboIDEmpGroup.Name.Substring(3));
            Classes.clsGridViewInterface.LoadCbo(cboIDGender, cboIDGender.Name.Substring(3));
            if (fUpdate == true)
            {
                txtAddress.Text = sAddress;
                txtCodeEmp.Text = sCodeEmp;
                txtNameEmp.Text = sNameEmp;
                txtPhone.Text = sPhone;
                cboIDEmpGroup.Text = sIDEmpGroup;
                cboIDGender.Text = sIDGender;
                dateBirthday.Text = sBirthday;
            }
        }
        #endregion

        #region Add new
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //txtCodeEmp.Text = txtIDGender.Text = String.Empty;
            FrmDir.sIDValue = txtPhone.Text = "0";
        }
        #endregion

        #region Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(objUpd.UpdateEmp(Convert.ToInt32(sIDValue), txtCodeEmp.Text, Convert.ToInt32(cboIDEmpGroup.SelectedValue), txtNameEmp.Text, Convert.ToInt32(cboIDGender.SelectedValue), Convert.ToDateTime(dateBirthday.Text), txtAddress.Text, txtPhone.Text))
                {
                    Classes.clsMessage.Information("Bạn đã cập nhật thành công");
                    txtAddress.Text = txtCodeEmp.Text = txtNameEmp.Text = txtPhone.Text = "";
                    txtCodeEmp.Focus();
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

        

        private void btnAddEmpGroup_Click(object sender, EventArgs e)
        {
            FrmUpdDir frm = new FrmUpdDir();
            frm.sTableName = btnAddEmpGroup.Name.ToString().Substring(6);
            frm.ShowDialog();
            Classes.clsGridViewInterface.LoadCbo(cboIDEmpGroup, cboIDEmpGroup.Name.Substring(3));
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


    }
}
