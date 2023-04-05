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
    public partial class FrmRptPartnerNotRegis : Form
    {
        private DataTable objData, objPartnerRegis;
        TVSSys.Connection objFunc = new TVSSys.Connection();
        Classes.clsGetReports objRpt = new TVSGM.Classes.clsGetReports();

        public FrmRptPartnerNotRegis()
        {
            InitializeComponent();
        }

        

        #region LoadForm
        private void LoadForm()
        {
            objData = objRpt.GetReportParnterNotRegis(txtSearch.Text, txtSearch.Text);
            this.gridviewDir.DataSource = objData;
            Classes.clsGridViewInterface.SetRptParnterStatus(gridviewDir);
        }

        private void LoadPartnerRegis(int sIDPartner)
        {
            objPartnerRegis = objRpt.GetReportParnterRegis(sIDPartner);
            this.gridPartnerRegis.DataSource = objPartnerRegis;
            Classes.clsGridViewInterface.SetRptParnterRegis(gridPartnerRegis);
        }

        private void FrmRptPartnerNotRegis_Load(object sender, EventArgs e)
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
        private void FrmRptPartnerNotRegis_KeyDown(object sender, KeyEventArgs e)
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
            Reports.rptRepPartnerNotRegis.objTable = objData;
            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptRepPartnerNotRegis";
            rpt.Show();
        }

        private void gridviewDir_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            LoadPartnerRegis(Convert.ToInt32(this.gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDPartner"].Value.ToString()));
        }
    }

}
