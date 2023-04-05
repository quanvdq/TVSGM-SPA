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
    public partial class FrmRptBillDelete : Form
    {
        private DataTable objData, objPartnerRegis;
        TVSSys.Connection objFunc = new TVSSys.Connection();
        Classes.clsGetReports objRpt = new TVSGM.Classes.clsGetReports();

        public FrmRptBillDelete()
        {
            InitializeComponent();
        }

        

        #region LoadForm

        private void LoadPartnerRegis()
        {
            objPartnerRegis = objRpt.GetReportBillDelete(dateSearch1.Value.ToString("yyyyMMdd"), dateSearch2.Value.ToString("yyyyMMdd"), txtSearch.Text);
            this.gridPartnerRegis.DataSource = objPartnerRegis;
            Classes.clsGridViewInterface.SetRptBillDelete(gridPartnerRegis);
        }

        private void FrmRptBillDelete_Load(object sender, EventArgs e)
        {
            LoadPartnerRegis();
        }

        #endregion

        #region Close
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Hotkey
        private void FrmRptBillDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) btnExit.PerformClick();
        }
        #endregion


        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.rptRepBillDelete.objTable = objPartnerRegis;
            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptRepBillDelete";
            rpt.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadPartnerRegis();
        }

        //private void gridviewDir_CellEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    LoadPartnerRegis(Convert.ToInt32(this.gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDPartner"].Value.ToString()));
        //}
    }

}
