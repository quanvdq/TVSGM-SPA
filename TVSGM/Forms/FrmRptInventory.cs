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
    public partial class FrmRptInventory : Form
    {
        private DataTable objData;
        TVSSys.Connection objFunc = new TVSSys.Connection();
        Classes.clsGetReports objRpt = new TVSGM.Classes.clsGetReports();

        public FrmRptInventory()
        {
            InitializeComponent();
        }

        

        #region LoadForm
        private void LoadForm()
        {
            objData = objRpt.GetReportInventory(txtSearch.Text,txtSearch.Text,Convert.ToString(dateSearch1.Value.ToString("yyyyMMdd")),Convert.ToString(dateSearch2.Value.ToString("yyyyMMdd")));
            this.gridviewDir.DataSource = objData;
            Classes.clsGridViewInterface.SetRptInventory(gridviewDir);
        }

        private void FrmRptInventory_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        #endregion

        #region Hotkey
        private void FrmRptInventory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) btnExit.PerformClick();
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateSearch1_ValueChanged(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.rptRepInventory.objTable = objData;
            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptRepInventory";
            rpt.Show();
        }
    }

}
