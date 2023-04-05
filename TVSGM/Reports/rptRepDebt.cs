using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Reports
{
    public partial class rptRepDebt : DataDynamics.ActiveReports.ActiveReport3
    {
        #region method Declare ...
        public static DataTable objTable;
        public static string srptTitle = "";
        
        public static double TotalMoney = 0;
        public static string DateRep = "";
        #endregion

        public rptRepDebt()
        {
            InitializeComponent();
            srptTitle = this.label3.Text;
            //this.lblComName.Text = TVSSys.GlobalModule.sTabComName.ToUpper();
            //this.lblComAddress.Text = "Địa chỉ : " + TVSSys.GlobalModule.sTabComAddress;
            //this.lblComPhone.Text = "Điện thoại : " + TVSSys.GlobalModule.sTabComPhone;
            this.lblComName.Text = TVSSys.GlobalModule.objComName.ToUpper();
            this.lblComAddress.Text = "Địa chỉ : " + TVSSys.GlobalModule.objComAddress;
            this.lblComPhone.Text = "Điện thoại : " + TVSSys.GlobalModule.objComPhone;
           
            this.DataSource =objTable;
            this.lblTime.Text = DateRep;
            this.lblTotalMoney.Text = string.Format("{0:0,0}", TotalMoney);
            this.lblPrintTime.Text = "In lúc " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + " Ngày " + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
          //  this.lblPrint.Text = "Ngày " + DateTime.Now.Day.ToString() + " tháng " + DateTime.Now.Month.ToString() + " năm " + DateTime.Now.Year.ToString();
        }
    }
}
