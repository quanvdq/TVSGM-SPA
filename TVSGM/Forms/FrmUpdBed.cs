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
    public partial class FrmUpdBed : Form
    {
        public string sIdBed, sCodeBed, sNameBed, sPoss, sState, sPriceDay, sPriceNight, sIdFloor, sIDGymRoom, sNameGymRoom, sIDValue;
        
        Classes.clsUpdProducts objUpd = new TVSGM.Classes.clsUpdProducts();
        public bool fUpdate = false;
        TVSSys.clsPublic obj = new TVSSys.clsPublic();
        public DataTable objData = new DataTable();

        public FrmUpdBed()
        {
            InitializeComponent();
        }
        #region Load Form
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            cboIDGymRoom.BackColor = Color.Aqua;
            Classes.clsGridViewInterface.LoadCbo(cboIDGymRoom, cboIDGymRoom.Name.Substring(3));

            if (FrmMain.sHidePrice == false)
            {
                txtPriceNight.Visible = false;
                lblPriceIn.Visible = false;
            }
            else
            {
                txtPriceNight.Visible = true;
                lblPriceIn.Visible = true;
            }

            if (fUpdate == true)
            {
                txtCodeBed.Text = sCodeBed;
                txtNameBed.Text = sNameBed;
                txtPriceNight.Text = sPriceNight;
                txtPriceDay.Text = sPriceDay;
                cboIDGymRoom.Text = sIDGymRoom;
            }
        }
        #endregion

        #region Add new
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCodeBed.Text = txtNameBed.Text = String.Empty;
            FrmDir.sIDValue = txtPriceNight.Text = txtPriceDay.Text = "0";
        }
        #endregion

        #region Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(txtPriceNight.Text)) txtPriceNight.Text="0";
                if (String.IsNullOrEmpty(txtPriceDay.Text)) txtPriceDay.Text = "0";
                if (objUpd.UpdateBed(Convert.ToInt32(sIDValue), Convert.ToInt32(cboIDGymRoom.SelectedValue), txtCodeBed.Text, txtNameBed.Text
                    , Convert.ToDouble(txtPriceNight.Text), Convert.ToDouble(txtPriceDay.Text)))
                {
                    Classes.clsMessage.Information("Bạn đã cập nhật thành công");
                    txtCodeBed.Text = txtNameBed.Text = txtPriceNight.Text = txtPriceDay.Text = "";
                    cboIDGymRoom.Focus();
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

        private void btnAddProductGroup_Click(object sender, EventArgs e)
        {
            FrmUpdDir frm = new FrmUpdDir();
            frm.sTableName = btnAddProductGroup.Name.ToString().Substring(6);
            frm.ShowDialog();
            Classes.clsGridViewInterface.LoadCbo(cboIDGymRoom, cboIDGymRoom.Name.Substring(3));
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{TAB}");
        }
        
    }
}
