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
    public partial class FrmUpdProduct : Form
    {
        public string sIDGroupPrd, sCodeProducts, sNameProducts, sIDUnit, sPriceIn, sPriceOut, sIDValue, j;
        
        Classes.clsUpdProducts objUpd = new TVSGM.Classes.clsUpdProducts();
        public bool fUpdate = false;
        TVSSys.clsPublic obj = new TVSSys.clsPublic();
        public DataTable objData = new DataTable();

        public FrmUpdProduct()
        {
            InitializeComponent();
        }
        #region Load Form
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            cboIDProductGroup.BackColor = Color.Aqua;
            Classes.clsGridViewInterface.LoadCbo(cboIDProductGroup, cboIDProductGroup.Name.Substring(3));
            Classes.clsGridViewInterface.LoadCbo(cboIDUnit, cboIDUnit.Name.Substring(3));

            if (FrmMain.sHidePrice == false)
            {
                txtPriceIn.Visible = false;
                lblPriceIn.Visible = false;
            }
            else
            {
                txtPriceIn.Visible = true;
                lblPriceIn.Visible = true;
            }

            if (fUpdate == true)
            {
                txtCodeProducts.Text = sCodeProducts;
                txtNameProducts.Text = sNameProducts;
                txtPriceIn.Text = sPriceIn;
                txtPriceOut.Text = sPriceOut;
                cboIDProductGroup.Text = sIDGroupPrd;
                cboIDUnit.Text = sIDUnit;
            }
        }
        #endregion

        #region Add new
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCodeProducts.Text = txtNameProducts.Text = String.Empty;
            FrmDir.sIDValue = txtPriceIn.Text = txtPriceOut.Text = "0";
        }
        #endregion

        #region Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool sChkBarCode = false;
                for (int i = 0; i < objData.Rows.Count; i++)
                {
                    if (i.ToString().Trim() != j.Trim())
                    {
                        if (txtCodeProducts.Text.Trim() != "")
                        {
                            if (objData.Rows[i]["CodeProducts"].ToString().Trim() == txtCodeProducts.Text.Trim())
                            {
                                Classes.clsMessage.Warning("Mã vạch đã tồn tại xin vui lòng kiểm tra lại");
                                sChkBarCode = true;
                            }
                        }
                    }
                }
                if (!sChkBarCode)
                {
                    if(String.IsNullOrEmpty(txtPriceIn.Text)) txtPriceIn.Text="0";
                    if (String.IsNullOrEmpty(txtPriceOut.Text)) txtPriceOut.Text = "0";
                    if (objUpd.UpdatePrd(Convert.ToInt32(sIDValue), Convert.ToInt32(cboIDProductGroup.SelectedValue), txtCodeProducts.Text, txtNameProducts.Text,
                                    Convert.ToInt32(cboIDUnit.SelectedValue), Convert.ToDouble(txtPriceIn.Text), Convert.ToDouble(txtPriceOut.Text), obj.NameForSearch(txtNameProducts.Text)))
                    {
                        Classes.clsMessage.Information("Bạn đã cập nhật thành công");
                        txtCodeProducts.Text = txtNameProducts.Text = txtPriceIn.Text = txtPriceOut.Text = "";
                        cboIDProductGroup.Focus();
                    }
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
            Classes.clsGridViewInterface.LoadCbo(cboIDProductGroup, cboIDProductGroup.Name.Substring(3));
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            FrmUpdDir frm = new FrmUpdDir();
            frm.sTableName = btnAddUnit.Name.ToString().Substring(6);
            frm.ShowDialog();
            Classes.clsGridViewInterface.LoadCbo(cboIDUnit, cboIDUnit.Name.Substring(3));
        }
        
    }
}
