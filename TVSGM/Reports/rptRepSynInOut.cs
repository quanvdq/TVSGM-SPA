using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data;

namespace Reports
{
    public partial class rptRepSynInOut : DataDynamics.ActiveReports.ActiveReport3
    {
        #region method Declare ...
        public DataTable objTable;
        public static string sDateSearch1, sDateSearch2, sTotalMoney;
        TVSSys.Connection objFunc = new TVSSys.Connection();
        #endregion

        #region method rptRepSynInOut
        public rptRepSynInOut()
        {
            string sQuery = "SELECT TblBill.ReExIDM,TblInOut.IDInOut AS I_ID,TblInOut.NameInOut AS I_Name, TblPartner.NamePartner AS P_Name," +
                                            "TblBill.Payed, TblTypeInOut.NameTypeInOut FROM TblBill " +
                                            "LEFT JOIN TblInOut ON TblInOut.IDInOut=TblBill.IDInOut " +
                                            "LEFT JOIN TblPartner ON TblPartner.IDPartner=TblBill.IDPartner " +
                                            "LEFT JOIN TabUser ON TabUser.UserName=TblBill.UserCreate " +
                                            "LEFT JOIN TblTypeInOut ON TblTypeInOut.IDTypeInOut=TblBill.IDTypeInOut "+
                                            "WHERE (convert(datetime,TblBill.DateSearch,103) BETWEEN '" + sDateSearch1 + "' AND '" + sDateSearch2 + "')  and Payed!=0 ORDER BY TblBill.ReExIDM DESC";
            InitializeComponent();
            objTable = objFunc.EXESelect(sQuery);
            this.DataSource = objTable;
            this.lblTime.Text = "Từ " + sDateSearch1 + " đến " + sDateSearch2;
            this.lblComName.Text = TVSSys.GlobalModule.objComName.ToUpper();
            this.lblComAddress.Text = "Địa chỉ : " + TVSSys.GlobalModule.objComAddress;
            this.lblComPhone.Text = "Điện thoại : " + TVSSys.GlobalModule.objComPhone;
            this.txtTotalMoney.Text = sTotalMoney;
            this.lblPrintTime.Text = "In lúc " +DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString()+" Ngày "+ DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
        } 
        #endregion
    }
}

