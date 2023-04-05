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
    public partial class FrmRptPartnerExpiringInMonth : Form
    {
        private DataTable objData, objPartnerRegis;
        TVSSys.Connection objFunc = new TVSSys.Connection();
        Classes.clsGetReports objRpt = new TVSGM.Classes.clsGetReports();

        public FrmRptPartnerExpiringInMonth()
        {
            InitializeComponent();
        }

        

        #region LoadForm

        private void LoadPartnerRegis(string sMonth)
        {
            objPartnerRegis = objRpt.GetReportParnterExpiringInMonth(int.Parse(sMonth));
            this.gridPartnerRegis.DataSource = objPartnerRegis;
            Classes.clsGridViewInterface.SetRptParnterExpiringInMonth(gridPartnerRegis);
        }

        private void FrmRptPartnerExpiringInMonth_Load(object sender, EventArgs e)
        {
            LoadPartnerRegis(dateSearch1.Value.ToString("MM"));
        }

        #endregion

        #region Close
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Hotkey
        private void FrmRptPartnerExpiringInMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) btnExit.PerformClick();
        }
        #endregion


        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.rptRepPartnerExpiringInMonth.objTable = objPartnerRegis;
            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptRepPartnerExpiringInMonth";
            rpt.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadPartnerRegis(dateSearch1.Value.ToString("MM"));
        }

        //private void gridviewDir_CellEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    LoadPartnerRegis(Convert.ToInt32(this.gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDPartner"].Value.ToString()));
        //}
    }

}
