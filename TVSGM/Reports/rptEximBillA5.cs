using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data;
using System.IO;
using System.Data.SqlClient;

namespace Reports
{
    public partial class rptEximBillA5 : DataDynamics.ActiveReports.ActiveReport3
    {
        #region method Declare ...
        private TVSSys.Connection objFunc = new TVSSys.Connection();
        public static DataTable objTable;
        public static DataTable objTableDetails;
        public static string FullName = "";
        public static string srptTitle = "";
        public static string srptTitleDescription = "";
        public static int IndexTable = 0;
        public static double MoneyDebt = 0;
        //private clsReports clsR = new clsReports();
        private TVSSys.clsConfigXML objConfig = new TVSSys.clsConfigXML();
        #endregion

        #region method rptEximBillA5
        public rptEximBillA5()
        {
            InitializeComponent();
            //bool tmp = false;
            //for (int i = 0; i < objTableDetails.Rows.Count; i++)
            //{
            //    if (double.Parse(objTableDetails.Rows[i]["Price"].ToString()) * double.Parse(objTableDetails.Rows[i]["Number"].ToString()) != double.Parse(objTableDetails.Rows[i]["TotalMoney"].ToString()))
            //    {
            //        tmp = true;
            //        break;
            //    }

            //}
            //if (!tmp)
            //{
            //    #region method Tiêu đề
            //    this.label6.Visible = false;
            //    this.label29.Location = new PointF(this.label6.Location.X, this.label6.Location.Y);
            //    this.label29.Width = this.label29.Width + this.label6.Width;
            //    #endregion

            //    #region method data
            //    this.TxtPromote.Visible = false;
            //    this.TxtTotalMoney.Location = this.TxtPromote.Location;
            //    this.TxtTotalMoney.Width = this.TxtTotalMoney.Width + this.TxtPromote.Width;
            //    #endregion

            //}

            //try
            //{
            //    DataColumn DVT = new DataColumn(); DVT.ColumnName = "DVT";
            //    DVT.DataType = typeof(string);

            //    objTableDetails.Columns.Add(DVT);
            //    for (int i = 0; i < objTableDetails.Rows.Count; i++)
            //    {
            //        objTableDetails.Rows[i]["DVT"] = TVSUtil.XML.clsXML.Get_XMLParams("Unit", "Name", "ID='" + objTableDetails.Rows[i]["UnitID"].ToString() + "'");   
            //    }
            //}
            //catch
            //{

            //}
            try
            {
                //if (System.Configuration.ConfigurationManager.AppSettings["UseLogo"].ToString() == "1")
                //{
                //    this.picture1.Image = Image.FromFile(TVSSys.GlobalModule.objLogoPath); 
                //}
                //else
                //{
                    this.picture1.Width = 0;
                    this.lblComAddress.Location = new PointF((float)0, (float)0.25);
                    this.lblComName.Location = new PointF((float)0, (float)0);
                    this.lblComPhone.Location = new PointF((float)0, (float)0.44);
                    this.lblComName.Width = this.lblComName.Width + 1;
                    this.lblComPhone.Width = this.lblComPhone.Width + 1;
                    this.lblComAddress.Width = this.lblComAddress.Width + 1;
                //}
            }
            catch
            {
                this.picture1.Width = 0;
                this.lblComAddress.Location = new PointF((float)0.19, (float)0.25);
                this.lblComName.Location = new PointF((float)0.19, (float)0);
                this.lblComPhone.Location = new PointF((float)0.19, (float)0.44);
                this.lblComName.Width = this.lblComName.Width + 1;
                this.lblComPhone.Width = this.lblComPhone.Width + 1;
                this.lblComAddress.Width = this.lblComAddress.Width + 1;
            }

            this.lblTitle.Text = srptTitle;
            this.lblComName.Text = TVSSys.GlobalModule.objComName.ToUpper();
            this.lblComAddress.Text = "Địa chỉ : " + TVSSys.GlobalModule.objComAddress;
            this.lblComPhone.Text = "Điện thoại : " + TVSSys.GlobalModule.objComPhone;
            this.lblBillID.Text = "SỐ : " + objTable.Rows[IndexTable]["billID"].ToString();
            DateTime objDate = DateTime.Parse(objTable.Rows[IndexTable]["CreateDate"].ToString());
            this.lblBillDate.Text = "Ngày " + objDate.Day + " tháng " + objDate.Month + " năm " + objDate.Year;
            this.lblProviderName.Text = objTable.Rows[IndexTable]["NamePartner"].ToString();
            this.lblProviderPhone.Text = objTable.Rows[IndexTable]["Phone"].ToString();
            this.lvlProviderAddress.Text = objTable.Rows[IndexTable]["Address"].ToString();
            this.lblBillNote.Text = objTable.Rows[IndexTable]["Note"].ToString();

            this.lblTotalMoney.Text = string.Format("{0:###,0}", double.Parse(objTable.Rows[IndexTable]["TotalMoney"].ToString()));
            this.lblTotalPay.Text = string.Format("{0:###,0}", double.Parse(objTable.Rows[IndexTable]["TotalPay"].ToString()));
            this.lblPayed.Text = string.Format("{0:###,0}", double.Parse(objTable.Rows[IndexTable]["Payed"].ToString()));
            this.lblPromotionPercent.Text = string.Format("{0:###,0}", double.Parse(objTable.Rows[IndexTable]["PromotionPercent"].ToString()));
            this.lblPromotionMoney.Text = string.Format("{0:###,0}", double.Parse(objTable.Rows[IndexTable]["PromotionMoney"].ToString()));

             objTableDetails.Columns.Add("Poss");

            for(int i = 0; i < objTableDetails.Rows.Count; i ++)
            {
                objTableDetails.Rows[i]["Poss"] = i + 1;
            }

             this.DataSource = objTableDetails;


            

            //string temp123 = "";
            //Font objF = new Font(new FontFamily("Times New Roman"), 10, FontStyle.Regular);
            //objFunc.getFontForRetail(ref objF, ref temp123);
            //this.lblEnd.Font = objF;
            //this.lblEnd.Text = temp123;

            this.lblMoneyByWord.Text = "Số tiền bằng chữ : " + TVSSys.clsPublic.MoneyToWord(Convert.ToInt64(string.Format("{0:###,0}", double.Parse(objTable.Rows[IndexTable]["TotalMoney"].ToString())).Replace(",", "")));
            this.lblPrintTime.Text = "In lúc " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + " Ngày " + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();

            this.lblEnd.Text = "Chân thành cảm ơn quý khách đã tới với " + TVSSys.GlobalModule.objComTax + " , hẹn gặp lại ! ";


            //#region OutputFormat
            //clsR.FormatStringDetail( ref this.TxtPrice,ref this.TxtNumber, ref this.TxtPromote, ref this.TxtTotalMoney);
            //clsR.FormatStringMoney(ref this.TxtTienHang, ref this.TxtTienKhuyenMai
            //                        , ref this.TxtTongThanhToan, ref this.TxtNoCu, ref this.TxtTongNo);
            //clsR.FormatStringMoney(ref this.TxtCustomerPay, ref this.TxtCustomerReturn
            //            , ref this.TxtTienThanhToan, ref this.TxtConNo);
            //#endregion
        } 
        #endregion

    }
}
