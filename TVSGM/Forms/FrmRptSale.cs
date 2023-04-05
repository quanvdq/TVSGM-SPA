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
    public partial class FrmRptSale : Form
    {
        private DataTable objData;
        TVSSys.Connection objFunc = new TVSSys.Connection();
        Classes.clsGetReports objRpt = new TVSGM.Classes.clsGetReports();

        public FrmRptSale()
        {
            InitializeComponent();
        }

        private void SumPayed()
        {
            double sumTotalPayed = 0;
            for (int i = 0; i < gridviewDir.Rows.Count; i++)
            {
                sumTotalPayed += Convert.ToDouble(gridviewDir.Rows[i].Cells["Payed"].Value);
            }
            txtTotalPayed.Text = sumTotalPayed.ToString(TVSSys.GlobalModule.objFormatMoney);
        }

        #region LoadForm
        private void LoadForm()
        {
            cboIDInOut.SelectedValue = "0";
            objData = objRpt.GetRptSale(cboIDEmp.SelectedValue.ToString(), Convert.ToString(dateSearch1.Value.ToString("yyyyMMdd")), Convert.ToString(dateSearch2.Value.ToString("yyyyMMdd")), cboIDInOut.SelectedValue.ToString());
            this.gridviewDir.DataSource = objData;
            Classes.clsGridViewInterface.SetRptSale(gridviewDir);
            lblCount.Text = "Hiện có: " + objData.Rows.Count.ToString() + " bản ghi";
            SumPayed();
        }

        private void FrmRptSale_Load(object sender, EventArgs e)
        {
            Classes.clsGridViewInterface.LoadSearchCbo(cboIDEmp, cboIDEmp.Name.Substring(3));
            //Classes.clsGridViewInterface.LoadSearchCbo(cboIDInOut, cboIDInOut.Name.Substring(3));
            Classes.clsGridViewInterface.LoadSearchCbo(cboIDInOut, cboIDInOut.Name.Substring(3), "IDTypeInOut", "1");
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
            LoadForm();
        }

        #region Hotkey
        private void FrmRptSale_KeyDown(object sender, KeyEventArgs e)
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
            Reports.rptRepSale.objTable = objData;
            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptRepSale";
            rpt.Show();
        }
    }

}
