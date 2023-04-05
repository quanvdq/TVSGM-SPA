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
    public partial class FrmUpdInstruments : Form
    {
        public string sIDGroupPrd, sCodeProducts, sNameProducts, sIDUnit, sPriceIn, sPriceOut, sIDValue;
        public bool fUpdate = false;
        Classes.clsUpdProducts objUpd = new TVSGM.Classes.clsUpdProducts();
        TVSSys.clsPublic obj = new TVSSys.clsPublic();


        public FrmUpdInstruments()
        {
            InitializeComponent();
        }
        #region Load Form
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            Classes.clsGridViewInterface.LoadCbo(cboIDUnit, cboIDUnit.Name.Substring(3));
            if (FrmDir.fUpdate == true)
            {
                txtCodeProducts.Text = sCodeProducts;
                txtNameProducts.Text = sNameProducts;
                txtPriceIn.Text = sPriceIn;
                txtPriceOut.Text = sPriceOut;
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
                objUpd.UpdateInstruments(Convert.ToInt32(FrmDir.sIDValue), txtCodeProducts.Text, txtNameProducts.Text,
                                Convert.ToInt32(cboIDUnit.SelectedValue), Convert.ToDouble(txtPriceIn.Text), Convert.ToDouble(txtPriceOut.Text),obj.NameForSearch(txtNameProducts.Text));
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

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            FrmUpdDir frm = new FrmUpdDir();
            frm.sTableName = btnAddUnit.Name.ToString().Substring(6);
            frm.ShowDialog();
            Classes.clsGridViewInterface.LoadCbo(cboIDUnit, cboIDUnit.Name.Substring(3));
        }
        
    }
}
