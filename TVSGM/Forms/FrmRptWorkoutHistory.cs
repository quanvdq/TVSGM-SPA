using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using TVSGM.Classes;

namespace TVSGM.Forms
{
    public partial class FrmRptWorkoutHistory : Form
    {
        #region declare objects
        private DataTable objData;
        private clsGetReports objRpt = new TVSGM.Classes.clsGetReports();
        private TVSSys.Connection objFunc = new TVSSys.Connection();
        #endregion

        #region method FrmRptWorkoutHistory
        public FrmRptWorkoutHistory()
        {
            InitializeComponent();
        }
        #endregion

        #region method LoadForm
        private void LoadForm()
        {
            objData = objRpt.GetReportWorkoutHistory(txtSearch.Text, dateSearch1.Value, dateSearch2.Value);
            this.gridviewDir.AutoGenerateColumns = false;
            this.gridviewDir.DataSource = objData;
            //Classes.clsGridViewInterface.SetHistory(gridviewDir);
        }

        private void FrmWorkoutHistory_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        #endregion

        #region method Close
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region method txtSearch_TextChanged
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadForm();
        }
        #endregion

        #region method dateSearch1_ValueChanged
        private void dateSearch1_ValueChanged(object sender, EventArgs e)
        {
            LoadForm();
        }
        #endregion

        #region method btnPrint_Click
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.rptRepWorkoutHistory.objTable = objData;
            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptRepWorkoutHistory";
            rpt.Show();
        }
        #endregion
    }
}
