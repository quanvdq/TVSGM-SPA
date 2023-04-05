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
    public partial class FrmRptSynInOutPartner : Form
    {
        private DataTable objData;
        Classes.clsGetReports objRpt = new TVSGM.Classes.clsGetReports();
        TVSSys.Connection objFunc = new TVSSys.Connection();


        public FrmRptSynInOutPartner()
        {
            InitializeComponent();
        }

        

        #region LoadForm
        private void LoadForm()
        {
            objData = objRpt.GetReportSynInOutPartner(txtSearch.Text, Convert.ToString(dateSearch1.Value.ToString("yyyyMMdd")), Convert.ToString(dateSearch2.Value.ToString("yyyyMMdd")));
            this.gridviewDir.DataSource = objData;
            Classes.clsGridViewInterface.SetSynInOutPartner(gridviewDir);
        }

        private void FrmWorkoutHistory_Load(object sender, EventArgs e)
        {
            //LoadForm();
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
            LoadForm();
        }

        private void dateSearch1_ValueChanged(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.rptRepSynInOutPartner.objTable = objData;
            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptRepSynInOutPartner";
            rpt.Show();
        }

       
    }

}
