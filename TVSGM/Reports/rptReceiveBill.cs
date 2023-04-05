using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Reports
{
    public partial class rptReceiveBill : DataDynamics.ActiveReports.ActiveReport3
    {
        #region method Declare ...
        private TVSSys.Connection objFunc = new TVSSys.Connection();
        TVSSys.clsPublic clsPublic = new TVSSys.clsPublic();
        DataTable objData = new DataTable();
        public string objectID = "", typeBill = "";
        public static string sBillID = "";
        #endregion

        #region method rptReceiveBill
        public rptReceiveBill()
        {
            InitializeComponent();
            try
            {
                //if (System.Configuration.ConfigurationManager.AppSettings["UseLogo"].ToString() == "1")
                //{
                //    this.picture1.Image = Image.FromFile(TVS2SSYS.GlobalModule.objLogoPath);
                //}
                //else
                //{
                //    this.picture1.Width = 0;
                    this.lblComAddress.Location = new PointF((float)0, (float)0.25);
                    this.lblComName.Location = new PointF((float)0, (float)0);
                    this.lblComPhone.Location = new PointF((float)0, (float)0.44);
                    this.lblComName.Width = this.lblComName.Width + (float)0.75;
                    this.lblComPhone.Width = this.lblComPhone.Width + (float)0.75;
                    this.lblComAddress.Width = this.lblComAddress.Width + (float)0.75;
                //}
            }
            catch
            {
                //this.picture1.Width = 0;
                this.lblComAddress.Location = new PointF((float)0, (float)0.25);
                this.lblComName.Location = new PointF((float)0, (float)0);
                this.lblComPhone.Location = new PointF((float)0, (float)0.44);
                this.lblComName.Width = this.lblComName.Width + (float)0.75;
                this.lblComPhone.Width = this.lblComPhone.Width + (float)0.75;
                this.lblComAddress.Width = this.lblComAddress.Width + (float)0.75;
            }
            this.lblComName.Text =TVSSys.GlobalModule.objComName.ToUpper();
            this.lblComAddress.Text = "Địa chỉ : " + TVSSys.GlobalModule.objComAddress;
            this.lblComPhone.Text = "Điện thoại : " + TVSSys.GlobalModule.objComPhone;

            this.lblBillID.Text = sBillID;
            objData = objFunc.EXESelect("SELECT TblBill.ReExIDM,Convert(nvarchar(10),TblBill.CreateDate,103) AS CreateDate,TblBill.ReExIDM,TblBill.Note,TblBill.Payed,TblPartner.NamePartner,TblPartner.Address  FROM TblBill LEFT JOIN TblPartner ON TblPartner.IDPartner=TblBill.IDPartner WHERE TblBill.ReExIDM='" + sBillID + "'");
            this.lblBillDate.Text = objData.Rows[0]["CreateDate"].ToString();
            this.lblBillHeader.Text = "PHIẾU THU";
            this.lblBillNote.Text = objData.Rows[0]["Note"].ToString();
            this.lblObjectName.Text = objData.Rows[0]["NamePartner"].ToString();
            this.lblPartner.Text = "Họ tên người nộp:";
            this.lvlAddress.Text = objData.Rows[0]["Address"].ToString();
            this.lblMoney.Text = objData.Rows[0]["Payed"].ToString();
            this.lblMoneyByWord.Text = TVSSys.clsPublic.MoneyToWord(Convert.ToInt64(lblMoney.Text));
        } 
        #endregion


    }
}
