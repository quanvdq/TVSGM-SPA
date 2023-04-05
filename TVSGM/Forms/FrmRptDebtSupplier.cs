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
    public partial class FrmRptDebtSupplier : Form
    {
        private DataTable objData, objPartnerRegis;
        TVSSys.Connection objFunc = new TVSSys.Connection();
        Classes.clsGetReports objRpt = new TVSGM.Classes.clsGetReports();
        public string sTableName;
        public static string sText;
        int sIDInOut, sIDPartnerType2, sIDPartnerType1;

        public FrmRptDebtSupplier()
        {
            InitializeComponent();
        }

        private void SumPayed()
        {
            double sumTotalPayed = 0;
            for (int i = 0; i < gridviewDir.Rows.Count; i++)
            {
                sumTotalPayed += Convert.ToDouble(gridviewDir.Rows[i].Cells["Debs"].Value);
            }
            txtDebs.Text = sumTotalPayed.ToString(TVSSys.GlobalModule.objFormatMoney);
        }

        #region LoadForm
        private void LoadForm()
        {
            objData = objRpt.GetReportDebtSupplier(txtSearch.Text, txtSearch.Text, sIDInOut);
            this.gridviewDir.DataSource = objData;
            Classes.clsGridViewInterface.SetRptDebtSupplier(gridviewDir);
            SumPayed();
        }

        private void LoadArising(int sIDPartner)
        {
            objPartnerRegis = objRpt.GetReportArising(dateSearch1.Value.ToString("yyyyMMdd"), dateSearch2.Value.ToString("yyyyMMdd"), sIDPartner);
            this.gridPartnerRegis.DataSource = objPartnerRegis;
            Classes.clsGridViewInterface.SetRptArising(gridPartnerRegis);
        }

        private void FrmRptDebtSupplier_Load(object sender, EventArgs e)
        {
            switch (sTableName.ToUpper())
            {
                case "RPTDEBTSUPPLIER":
                    {
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO CÔNG NỢ PHẢI TRẢ";
                        sIDInOut = 2;
                        break;
                    }
                case "RPTDEBTPARTNER":
                    {
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO CÔNG NỢ CẦN THU";
                        sIDInOut = 1;
                        break;
                    }
            }

            LoadForm();
        }

        #endregion

        #region Close
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Hotkey
        private void FrmRptDebtSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) btnExit.PerformClick();
        }
        #endregion

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.rptRepDebt.objTable = objData;
            Reports.rptRepDebt.TotalMoney = Convert.ToDouble(txtDebs.Text);
            if (sTableName.ToUpper() == "RPTDEBTSUPPLIER") Reports.rptRepDebt.srptTitle = "BÁO CÁO CÔNG NỢ PHẢI TRẢ";
            else Reports.rptRepDebt.srptTitle = "BÁO CÁO CÔNG NỢ CẦN THU";

            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptRepDebt";
            rpt.Show();
        }

        private void gridviewDir_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            LoadArising(Convert.ToInt32(this.gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDPartner"].Value.ToString()));
        }
    }

}
