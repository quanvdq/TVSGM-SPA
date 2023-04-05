using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data.SqlClient;
using System.Data;

namespace Reports
{
    public partial class rptRepSale : DataDynamics.ActiveReports.ActiveReport3
    {
        public static string  DateRep="",Note="";
        public static DataTable objTable;

        public rptRepSale()
        {
            InitializeComponent();
            this.label6.Text = Note;
            this.lblComName.Text = TVSSys.GlobalModule.objComName.ToUpper();
            this.lblComAddress.Text = "Địa chỉ : " + TVSSys.GlobalModule.objComAddress;
            this.lblComPhone.Text = "Điện thoại : " + TVSSys.GlobalModule.objComPhone;
            this.lblPrintTime.Text = "In lúc " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + " Ngày " + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            this.DataSource = objTable;
            this.label2.Text = DateRep;

            #region Load Logo
            try
            {
                //if (System.Configuration.ConfigurationManager.AppSettings["UseLogo"].ToString() == "1")
                //{
                //    this.PtrLogo.Image = Image.FromFile(TVS2SSYS.GlobalModule.objLogoPath); ;
                //}
                //else
                //{
                //    this.PtrLogo.Width = 0;
                //    this.lblComAddress.Left = 0;
                //    this.lblComName.Left = 0;
                //    this.lblComPhone.Left = 0;

                //    this.lblComName.Width = this.PrintWidth - 0.2F;
                //    this.lblComPhone.Width = this.PrintWidth - 0.2F;
                //    this.lblComAddress.Width = this.PrintWidth - 0.2F;
                //}
            }
            catch { }
            #endregion
        }

    }
}
