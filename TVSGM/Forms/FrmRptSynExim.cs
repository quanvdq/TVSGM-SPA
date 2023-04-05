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
    public partial class FrmRptSynExim : Form
    {
        private DataTable objData, objBillDetail;
        TVSSys.Connection objFunc = new TVSSys.Connection();
        Classes.clsGetReports objRpt = new TVSGM.Classes.clsGetReports();
        public string sTableName, sText = String.Empty;
        public FrmRptSynExim()
        {
            InitializeComponent();
        }

        

        #region LoadForm
        private void LoadForm()
        {
            objData = objRpt.GetReportSynExim(txtSearch.Text, txtSearch.Text, dateSearch1.Value.ToString("yyyyMMdd"), dateSearch2.Value.ToString("yyyyMMdd"));
            this.gridviewDir.DataSource = objData;
            Classes.clsGridViewInterface.SetRptSynExim(gridviewDir);
        }

        private void LoadPrdArising(int sIDProducts)
        {
            objBillDetail = objRpt.GetReportPrdArising(sIDProducts, dateSearch1.Value.ToString("yyyyMMdd"), dateSearch2.Value.ToString("yyyyMMdd"));
            this.gridBillDeatail.DataSource = objBillDetail;
            Classes.clsGridViewInterface.SetRptPrdArising(gridBillDeatail);
        }

        private void FrmRptSynExim_Load(object sender, EventArgs e)
        {
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
        private void FrmRptSynExim_KeyDown(object sender, KeyEventArgs e)
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
            Reports.rptRepSynExim.objTable = objData;
            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptRepSynExim";
            rpt.Show();
        }

        private void gridviewDir_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            LoadPrdArising(Convert.ToInt32(this.gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDProducts"].Value.ToString()));
        }

        private void dateSearch1_ValueChanged(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void dateSearch2_ValueChanged(object sender, EventArgs e)
        {
            LoadForm();
        }
    }

}
