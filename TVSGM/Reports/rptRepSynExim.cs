﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data.SqlClient;
using System.Data;

namespace Reports
{
    public partial class rptRepSynExim : DataDynamics.ActiveReports.ActiveReport3
    {
        public static string Group = "", WareHouse = "",TypeDetail="";
        public static string DateRep="";
        public static DataTable objTable;

        public rptRepSynExim()
        {
            InitializeComponent();
            if(TypeDetail!="")
            {
                this.lblBillHeader.Text="TỔNG HỢP XUẤT NHẬP TỒN";
            }
            this.lblDateTime.Text =DateRep;
            //this.lblComName.Text = TVS2SSYS.GlobalModule.sTabComName.ToUpper();
            //this.lblComAddress.Text = "Địa chỉ : " + TVS2SSYS.GlobalModule.sTabComAddress;
            //this.lblComPhone.Text = "Điện thoại : " + TVS2SSYS.GlobalModule.sTabComPhone;
            this.lblComName.Text = TVSSys.GlobalModule.objComName.ToUpper();
            this.lblComAddress.Text = "Địa chỉ : " + TVSSys.GlobalModule.objComAddress;
            this.lblComPhone.Text = "Điện thoại : " + TVSSys.GlobalModule.objComPhone;
            this.lblPrintTime.Text = "In lúc " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + " Ngày " + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            this.DataSource = objTable;
        }

    }
}
