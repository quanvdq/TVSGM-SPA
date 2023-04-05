using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using zkemkeeper;

namespace TVSGM.Forms
{
    public partial class FrmRptTimeKeeper : Form
    {
        private DataTable objData, objDataOut, objDataDetail;
        TVSSys.Connection objFunc = new TVSSys.Connection();
        Classes.clsGetReports objRpt = new TVSGM.Classes.clsGetReports();
        zkemkeeper.CZKEM objCzkem = new CZKEM();
        Classes.clsUpdProducts objMember = new TVSGM.Classes.clsUpdProducts();

        public FrmRptTimeKeeper()
        {
            InitializeComponent();
        }
        #region LoadForm
        private void LoadForm()
        {
            string sWhere="", sWhere2="";
            string sQueryOut = "SELECT TblTimeKeeper.IdEmp ,TblTimeKeeper.TypeInOut ,Convert(nvarchar,TblTimeKeeper.TimeInOut,112) AS TimeInOut, Convert(nvarchar,TblTimeKeeper.TimeInOut,108) AS HourFinish ,TblEmp.CodeEmp,TblEmp.NameEmp,TblEmp.Birthday ,TblEmp.IDGender,TblEmp.Address,TblEmp.Phone,TblEmp.IDEmpGroup FROM TblTimeKeeper LEFT JOIN TblEmp ON TblEmp.CodeEmp=TblTimeKeeper.IdEmp " +
                            "WHERE Convert(nvarchar,TimeInOut,112) >= '" + dateSearch1.Value.ToString("yyyyMMdd") + "' AND  Convert(nvarchar,TimeInOut,112) <='" + dateSearch2.Value.ToString("yyyyMMdd") + "' AND TypeInOut=1";
            objDataOut = objFunc.EXESelect(sQueryOut);

            if(cboTypeKeeper.Text=="Chấm công theo ca")
            {
                objFunc.EXEUpdate("DELETE TblTmpTimeKeeper DBCC CHECKIDENT ('[TblTmpTimeKeeper]', RESEED, 0)");
                string sUpdate = "INSERT INTO TblTmpTimeKeeper" +
                                 "(IdEmp,CodeEmp,NameEmp,TimeKeeping,HourStart) " +
                                 "SELECT TblTimeKeeper.IdEmp, TblTimeKeeper.IdEmp ,TblEmp.NameEmp ,TblTimeKeeper.TimeInOut, Convert(nvarchar,TblTimeKeeper.TimeInOut,108) FROM TblTimeKeeper LEFT JOIN TblEmp ON TblEmp.CodeEmp=TblTimeKeeper.IdEmp " +
                                 "WHERE Convert(nvarchar,TimeInOut,112) >= '" + dateSearch1.Value.ToString("yyyyMMdd") + "' AND  "+
                                 "Convert(nvarchar,TimeInOut,112) <='" + dateSearch2.Value.ToString("yyyyMMdd") + "' AND TypeInOut=0";
                objFunc.EXEUpdate(sUpdate);

                for (int i = 0; i < objDataOut.Rows.Count; i++)
                {
                    string sUpdateOut = "UPDATE TblTmpTimeKeeper SET HourFinish= '" + objDataOut.Rows[i]["HourFinish"].ToString() + "' "+
                        "WHERE CodeEmp='" + objDataOut.Rows[i]["IdEmp"].ToString() + "' "+
                        "AND Convert(nvarchar,TblTmpTimeKeeper.TimeKeeping,112)='" + objDataOut.Rows[i]["TimeInOut"].ToString() + "'";
                    objFunc.EXEUpdate(sUpdateOut);
                }

                objMember.setTimeShift(Convert.ToInt32(cboIDEmp.SelectedValue), dateSearch1.Value.ToString("yyyyMMdd"), dateSearch2.Value.ToString("yyyyMMdd"));

            }
            else if(cboTypeKeeper.Text=="Chấm công theo HC"){

            }

            if (cboIDEmp.SelectedValue.ToString() != "0")
            {
                sWhere = "AND IdEmp = " + cboIDEmp.SelectedValue;
            }
            if (cboIDTimeShiftConfig.SelectedValue.ToString() != "0")
            {
                sWhere = "AND IDTimeShiftConfig = " + cboIDTimeShiftConfig.SelectedValue;
            }
            //string sQueryIn = "SELECT CodeEmp,NameEmp,Convert(nvarchar,TimeKeeping,103) AS TimeKeeping, HourStart, HourFinish, Delay FROM TblTmpTimeKeeper " +
            //                "WHERE Convert(nvarchar,TimeKeeping,112) >= '" + dateSearch1.Value.ToString("yyyyMMdd") + "' " +
            //                "AND  Convert(nvarchar,TimeKeeping,112) <='" + dateSearch2.Value.ToString("yyyyMMdd") + "'" + sWhere + sWhere2;
            string sQueryIn = "SELECT IdEmp,CodeEmp, NameEmp ,count(IdEmp) AS TotalTime FROM dbo.TblTmpTimeKeeper " +
                            "WHERE Convert(nvarchar,TimeKeeping,112) >= '" + dateSearch1.Value.ToString("yyyyMMdd") + "' " +
                            "AND  Convert(nvarchar,TimeKeeping,112) <='" + dateSearch2.Value.ToString("yyyyMMdd") + "'" + sWhere + sWhere2 + "  GROUP BY IdEmp,NameEmp,CodeEmp "; 
            objData = objFunc.EXESelect(sQueryIn);
            this.gridTimeKeeping.DataSource = objData;
            Classes.clsGridViewInterface.SetTimeKeeping(this.gridTimeKeeping);
        }

        private void FrmRptTimeKeeper_Load(object sender, EventArgs e)
        {
            Classes.clsGridViewInterface.LoadSearchCbo(cboIDEmp, cboIDEmp.Name.Substring(3));
            Classes.clsGridViewInterface.LoadSearchCbo(cboIDTimeShiftConfig, cboIDTimeShiftConfig.Name.Substring(3));

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
        private void FrmRptTimeKeeper_KeyDown(object sender, KeyEventArgs e)
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
            Reports.rptRepTimeShift.objTable = objData;
            Reports.rptRepTimeShift.DateRep = "Từ ngày: " + dateSearch1.Value.ToString("dd/MM/yyyy") + "đến ngày:" + dateSearch2.Value.ToString("dd/MM/yyyy");
                
            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptRepTimeShift";
            rpt.Show();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (objCzkem.Connect_Net(FrmMain.sAddressIP, FrmMain.sPort) == true)
            {
                string dwEnrollNumber1 = "";
                int dwVerifyMode = 0;
                int dwInOutMode = 0;
                int dwYear = 0;
                int dwMonth = 0;
                int dwDay = 0;
                int dwHour = 0;
                int dwMinute = 0;
                int dwSecond = 0;
                int dwWorkCode = 0;

                //objCZKEM.ReadAllGLogData(int.Parse(txtNumberMachine.Text));

                while (objCzkem.SSR_GetGeneralLogData(1, out dwEnrollNumber1, out dwVerifyMode, out dwInOutMode, out dwYear, out dwMonth, out dwDay, out dwHour, out dwMinute, out dwSecond, ref dwWorkCode))
                {
                    string inputDate = new DateTime(dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond).ToString();
                    objMember.UpdateTimeKeeper(int.Parse(dwEnrollNumber1), dwInOutMode, DateTime.Parse(inputDate));
                }
                objCzkem.EnableDevice(1, true);
                Cursor = Cursors.Default;
                MessageBox.Show("TVS - Tải dữ liệu xuống máy thành công!");
            }
        }

        private void gridTimeKeeping_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string sQueryDetail = "SELECT NameEmp,Convert(nvarchar,TimeKeeping,103) AS TimeKeeping, HourStart, HourFinish, Delay FROM TblTmpTimeKeeper " +
                            "WHERE Convert(nvarchar,TimeKeeping,112) >= '" + dateSearch1.Value.ToString("yyyyMMdd") + "' " +
                            "AND  Convert(nvarchar,TimeKeeping,112) <='" + dateSearch2.Value.ToString("yyyyMMdd") + "' AND IdEmp =" + gridTimeKeeping.Rows[gridTimeKeeping.CurrentCell.RowIndex].Cells["IdEmp"].Value.ToString();
            objDataDetail = objFunc.EXESelect(sQueryDetail);
            this.gridTimeDetail.DataSource = objDataDetail;
            Classes.clsGridViewInterface.SetTimeDetail(this.gridTimeDetail);
        }

        private void btnPrintDetail_Click(object sender, EventArgs e)
        {
            Reports.rptRepTimeShiftDetail.objTable = objDataDetail;
            Reports.rptRepTimeShiftDetail.DateRep = "Từ ngày: " + dateSearch1.Value.ToString("dd/MM/yyyy") + "đến ngày:" + dateSearch2.Value.ToString("dd/MM/yyyy");

            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptRepTimeShiftDetail";
            rpt.Show();
        }
    }

}
