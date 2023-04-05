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
    public partial class FrmRptEximDetail : Form
    {
        private DataTable objData;
        TVSSys.Connection objFunc = new TVSSys.Connection();
        Classes.clsGetReports objRpt = new TVSGM.Classes.clsGetReports();
        public string sTableName;
        public static string sText;
        public Classes.clsEnums.LoaiCuaSo sType;

        public FrmRptEximDetail()
        {
            InitializeComponent();
        }

        private void SumPayed()
        {
            double sumTotalPayed = 0;
            for (int i = 0; i < gridviewDir.Rows.Count; i++)
            {
                sumTotalPayed += Convert.ToDouble(gridviewDir.Rows[i].Cells["TotalMoney"].Value);
            }
            txtTotalPayed.Text = sumTotalPayed.ToString(TVSSys.GlobalModule.objFormatMoney);
        }

        #region LoadForm
        private void LoadForm()
        {
            switch (sTableName.ToUpper())
            {
                case "IMPORTDETAIL":
                    {
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO NHẬP HÀNG CHI TIẾT";
                        sType = Classes.clsEnums.LoaiCuaSo.NH;
                        break;
                    }
                case "EXPORTDETAIL":
                    {
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO XUẤT HÀNG CHI TIẾT";
                        sType = Classes.clsEnums.LoaiCuaSo.BH;
                        break;
                    }
            }

            objData = objRpt.GetReportEximDetail(sType.ToString(), cboUser.SelectedValue.ToString(), txtSearch.Text, txtSearch.Text, dateSearch1.Value.ToString("yyyyMMdd"), dateSearch2.Value.ToString("yyyyMMdd"));
            this.gridviewDir.DataSource = objData;
            Classes.clsGridViewInterface.SetRptEximDetail(gridviewDir);
            lblCount.Text = "Hiện có: " + objData.Rows.Count.ToString() + " bản ghi";
            SumPayed();
        }

        private void FrmRptEximDetail_Load(object sender, EventArgs e)
        {
            Classes.clsGridViewInterface.LoadCboSearch(cboUser, "FullName", "UserName", "TabUser");
            LoadForm();

        }
        #endregion

        #region Close
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        #region Hotkey
        private void FrmRptEximDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) btnExit.PerformClick();
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            switch (sTableName.ToUpper())
            {
                case "IMPORTDETAIL":
                    {
                        Reports.rptRepEximDetail.sText = "BÁO CÁO NHẬP HÀNG CHI TIẾT";
                        break;
                    }
                case "EXPORTDETAIL":
                    {
                        Reports.rptRepEximDetail.sText = "BÁO CÁO XUẤT HÀNG CHI TIẾT";                        
                        break;
                    }
            }

            Reports.rptRepEximDetail.objTable = objData;
            Reports.rptRepEximDetail.DateRep = "Từ ngày " + dateSearch1.Value.ToString("dd/MM/yyyy") + " đến ngày " + dateSearch2.Value.ToString("dd/MM/yyyy") + "";
            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptRepEximDetail";
            rpt.Show();
        }
    }

}
