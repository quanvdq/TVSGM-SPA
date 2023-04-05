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
using Microsoft.VisualBasic;

namespace TVSGM.Forms
{
    public partial class FrmRptWorkoutHistoryV1 : Form
    {
        #region declare objects
        private DataTable objData;
        private clsGetReports objRpt = new TVSGM.Classes.clsGetReports();
        private TVSSys.Connection objFunc = new TVSSys.Connection();
        #endregion

        #region method FrmRptWorkoutHistory
        public FrmRptWorkoutHistoryV1()
        {
            InitializeComponent();
        }
        #endregion

        #region method LoadForm
        private void LoadForm()
        {
            
            TVSSys.ItemCombobox objItem = (TVSSys.ItemCombobox)cbbDate.SelectedItem;
            objData = objRpt.GetReportWorkoutHistory1(objItem.Value, txtSearch.Text.Trim());
            this.gridviewDir.AutoGenerateColumns = false;
            this.gridviewDir.DataSource = objData;
            //Classes.clsGridViewInterface.SetHistory(gridviewDir);
        }

        private void FrmWorkoutHistory_Load(object sender, EventArgs e)
        {
            Set_CbbDate(this.cbbDate);
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
            //LoadForm();
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
            LoadForm();
        }
        #endregion


        private void Set_CbbDate(ComboBox sDdlDate)
        {
            try
            {
                DateTime dtFrom = new DateTime(2019, 12, 31); // Thời điểm tính lương đầu tiên: 01/2012
                DateTime dtWork;
                long j = DateAndTime.DateDiff(DateInterval.Month, dtFrom, DateTime.Now, Microsoft.VisualBasic.FirstDayOfWeek.System, FirstWeekOfYear.System);
                for (long i = j; i > 0; i--)
                {
                    dtWork = DateAndTime.DateAdd(DateInterval.Month, i, dtFrom);
                    sDdlDate.Items.Add(new TVSSys.ItemCombobox("Tháng " + dtWork.Month.ToString("00") + " năm " + dtWork.Year.ToString("0000"), dtWork.Year.ToString("0000") + dtWork.Month.ToString("00")));
                }
                sDdlDate.SelectedIndex = 0;
            }
            catch { return; }
        }

    }
}
