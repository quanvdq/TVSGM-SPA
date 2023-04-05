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
    public partial class FrmUpdPackGym : Form
    {
        public string sIDPackGym, sCodePackGym, sNamePackGym, sTypePackGym, sTimes, sPrice, sTotalMoney;
        public bool fUpdate = false;
        Classes.clsUpdProducts objUpd = new TVSGM.Classes.clsUpdProducts();
        TVSSys.clsPublic obj = new TVSSys.clsPublic();

        public FrmUpdPackGym()
        {
            InitializeComponent();
        }
        #region Load Form
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            txtCodePackGym.BackColor = Color.Aqua;
            Classes.clsGridViewInterface.LoadCbo(cboIDTypeGym, cboIDTypeGym.Name.Substring(3));
            if (fUpdate == true)
            {
                txtPrice.Text = sPrice;
                txtTimes.Text = sTimes;
                txtTotalMoney.Text = sTotalMoney;
                txtCodePackGym.Text = sCodePackGym;
                txtNamePackGym.Text = sNamePackGym;
                cboIDTypeGym.SelectedValue = sTypePackGym;
            }
        }
        #endregion

        #region Add new
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCodePackGym.Text = txtNamePackGym.Text = "";
            sIDPackGym = txtTimes.Text = "0";
        }
        #endregion

        #region Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (objUpd.UpdatePackGym(Convert.ToInt32(sIDPackGym), txtCodePackGym.Text, txtNamePackGym.Text, Convert.ToInt32(cboIDTypeGym.SelectedValue), Convert.ToInt32(txtTimes.Text), Convert.ToDouble(txtPrice.Text), Convert.ToDouble(txtTotalMoney.Text)))
                {
                    Classes.clsMessage.Information("Bạn đã cập nhật thành công");
                    txtCodePackGym.Text = txtNamePackGym.Text = "";
                    txtPrice.Text = txtTimes.Text = txtTotalMoney.Text = "0";
                    txtNamePackGym.Focus();
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

        //private void cboIDTypeGym_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (Convert.ToInt32(cboIDTypeGym.SelectedValue) == 2)
        //    {
        //        txtTimes.Text = "0";
        //        txtTimes.Enabled = false;
        //        txtTotalMoney.Text = "0";
        //        txtTotalMoney.Enabled = false;
        //    }
        //    else
        //    {
        //        txtTimes.Enabled = true;
        //        txtTotalMoney.Enabled = true;
        //    }
        //}

        #region TextChanged
        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CalMoney();
        }
        #endregion

        double dblTotalMoney, dblPrice, dblTimes;
        #region Calculation MoneyPay
        private void CalMoney()
        {
            try
            {
                if (String.IsNullOrEmpty(txtTimes.Text)) return;
                if (String.IsNullOrEmpty(txtPrice.Text)) return;
                if (String.IsNullOrEmpty(txtTotalMoney.Text)) return;
                dblTotalMoney = double.Parse(txtTotalMoney.Text);
                dblPrice = double.Parse(txtPrice.Text);
                dblTimes = double.Parse(txtTimes.Text);
                dblTotalMoney = dblPrice * dblTimes;
                txtTotalMoney.Text = dblTotalMoney.ToString(TVSSys.GlobalModule.objFormatMoney);
            }
            catch {
                Classes.clsMessage.Error("Kiểm tra lại giá trị đầu vào!");
            }
        }
        #endregion

        private void txtTotalMoney_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (String.IsNullOrEmpty(txtTimes.Text)) return;
            //    if (String.IsNullOrEmpty(txtPrice.Text)) return;
            //    if (String.IsNullOrEmpty(txtTotalMoney.Text)) return;
            //    dblTotalMoney = double.Parse(txtTotalMoney.Text);
            //    dblPrice = double.Parse(txtPrice.Text);
            //    dblTimes = double.Parse(txtTimes.Text);
            //    dblPrice = dblTotalMoney / dblTimes;
            //    txtPrice.Text = dblPrice.ToString(TVSSys.GlobalModule.objFormatMoney);
            //}
            //catch
            //{
            //    Classes.clsMessage.Error("Kiểm tra lại giá trị đầu vào!");
            //}
        }

    }
}
