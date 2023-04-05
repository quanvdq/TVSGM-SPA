using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TVSGM.Forms
{
    public partial class FrmRptSynInOut : Form
    {
        private DataTable objSynIn, objSynOut;
        TVSSys.Connection objFunc = new TVSSys.Connection();
        Classes.clsInOutBill objBill = new TVSGM.Classes.clsInOutBill();
        public string sTableName, sText = String.Empty;
        int sIDInOut, sIDPartnerType2, sIDPartnerType1;
        public FrmRptSynInOut()
        {
            InitializeComponent();
        }

        #region Sum MoneyProducts from GridBillDetail
        private void CalMoneyProducts()
        {
            try
            {
                double fTotalMoney = 0;
                double fMoneyIn = 0;
                double fMoneyOut = 0;
                for (int i = 0; i < gridSynIn.RowCount; i++)
                {
                    fMoneyIn += Convert.ToDouble(gridSynIn.Rows[i].Cells["Payed"].Value);
                    txtMoneyIn.Text = fMoneyIn.ToString(TVSSys.GlobalModule.objFormatMoney);

                    //this.txtMoneyIn.Properties.DisplayFormat.FormatString = PNSGlobal.FormatString.objFomatMoney;
                    //this.txtMoneyIn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                }

                for (int i = 0; i < gridSynOut.RowCount; i++)
                {
                    fMoneyOut += Convert.ToDouble(gridSynOut.Rows[i].Cells["Payed"].Value);
                    txtMoneyOut.Text = fMoneyOut.ToString(TVSSys.GlobalModule.objFormatMoney);

                    //this.txtMoneyOut.Properties.DisplayFormat.FormatString = PNSGlobal.FormatString.objFomatMoney;
                    //this.txtMoneyOut.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                }

                fTotalMoney = fMoneyIn - fMoneyOut;
                txtTotalMoney.Text = fTotalMoney.ToString(TVSSys.GlobalModule.objFormatMoney);
                //this.txtTotalMoney.Properties.DisplayFormat.FormatString = PNSGlobal.FormatString.objFomatMoney;
                //this.txtTotalMoney.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            }
            catch { }
        }
        #endregion

        #region LoadForm
        private void LoadSynIn()
        {
            objSynIn = objBill.getInOutBill(txtSearch.Text, "PT", Convert.ToDateTime(dateSearch1.Text).ToString("MM/dd/yyyy"), Convert.ToDateTime(dateSearch2.Text).ToString("MM/dd/yyyy"));
            this.gridSynIn.DataSource = objSynIn;
            Classes.clsGridViewInterface.SetSynInOut(gridSynIn);
        }

        private void LoadSynOut()
        {
            objSynOut = objBill.getInOutBill(txtSearch.Text, "PC", Convert.ToDateTime(dateSearch1.Text).ToString("MM/dd/yyyy"), Convert.ToDateTime(dateSearch2.Text).ToString("MM/dd/yyyy"));
            this.gridSynOut.DataSource = objSynOut;
            Classes.clsGridViewInterface.SetSynInOut(gridSynOut);
        }

        private void FrmRptSynInOut_Load(object sender, EventArgs e)
        {
            LoadSynIn();
            LoadSynOut();
            CalMoneyProducts();
        }

        #endregion

        #region Close
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Hotkey
        private void FrmRptSynInOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) btnExit.PerformClick();
        }
        #endregion

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //LoadForm();
            LoadSynIn();
            LoadSynOut();
            CalMoneyProducts();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.rptRepSynInOut.sDateSearch1 = dateSearch1.Value.ToString("MM/dd/yyyy");
            Reports.rptRepSynInOut.sDateSearch2 = dateSearch2.Value.ToString("MM/dd/yyyy");
            Reports.rptRepSynInOut.sTotalMoney = txtTotalMoney.Text;
            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptRepSynInOut";
            rpt.Show();
        }

        private void dateSearch1_ValueChanged(object sender, EventArgs e)
        {
            LoadSynIn();
            LoadSynOut();
            CalMoneyProducts();
        }
    }

}
