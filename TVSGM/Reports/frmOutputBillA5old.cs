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
    public partial class frmOutputBillA5old : DataDynamics.ActiveReports.ActiveReport3
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
        //private TVSSys.clsConfigXML objConfig = new TVS2SSYS.clsConfigXML();
        #endregion

        #region method frmOutputBillA5old
        public frmOutputBillA5old()
        {
            InitializeComponent();
            bool tmp = false;
            for (int i = 0; i < objTableDetails.Rows.Count; i++)
            {
                if (double.Parse(objTableDetails.Rows[i]["Price"].ToString()) * double.Parse(objTableDetails.Rows[i]["Number"].ToString()) != double.Parse(objTableDetails.Rows[i]["TotalMoney"].ToString()))
                {
                    tmp = true;
                    break;
                }

            }
            if (!tmp)
            {
                #region method Tiêu đề
                this.label6.Visible = false;
                this.label29.Location = new PointF(this.label6.Location.X, this.label6.Location.Y);
                this.label29.Width = this.label29.Width + this.label6.Width;
                #endregion

                #region method data
                this.TxtPromote.Visible = false;
                this.TxtTotalMoney.Location = this.TxtPromote.Location;
                this.TxtTotalMoney.Width = this.TxtTotalMoney.Width + this.TxtPromote.Width;
                #endregion

            }

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
            //try
            //{
            //    if (System.Configuration.ConfigurationManager.AppSettings["UseLogo"].ToString() == "1")
            //    {
            //        this.picture1.Image = Image.FromFile(TVS2SSYS.GlobalModule.objLogoPath); 
            //    }
            //    else
            //    {
            //        this.picture1.Width = 0;
            //        this.lblComAddress.Location = new PointF((float)0, (float)0.25);
            //        this.lblComName.Location = new PointF((float)0, (float)0);
            //        this.lblComPhone.Location = new PointF((float)0, (float)0.44);
            //        this.lblComName.Width = this.lblComName.Width + 1;
            //        this.lblComPhone.Width = this.lblComPhone.Width + 1;
            //        this.lblComAddress.Width = this.lblComAddress.Width + 1;
            //    }
            //}
            //catch
            //{
            //    this.picture1.Width = 0;
            //    this.lblComAddress.Location = new PointF((float)0.19, (float)0.25);
            //    this.lblComName.Location = new PointF((float)0.19, (float)0);
            //    this.lblComPhone.Location = new PointF((float)0.19, (float)0.44);
            //    this.lblComName.Width = this.lblComName.Width + 1;
            //    this.lblComPhone.Width = this.lblComPhone.Width + 1;
            //    this.lblComAddress.Width = this.lblComAddress.Width + 1;
            //}
           // this.DataSource = objTableDetails;
           // this.lblComName.Text = TVS2SSYS.GlobalModule.sTabComName.ToUpper();
           // this.lblComAddress.Text = "Địa chỉ : " + TVS2SSYS.GlobalModule.sTabComAddress;
           // this.lblComPhone.Text = "Điện thoại : " + TVS2SSYS.GlobalModule.sTabComPhone;
           // this.lblBillID.Text ="SỐ : "+ objTable.Rows[IndexTable]["billID"].ToString();
           // DateTime objDate = DateTime.Parse(objTable.Rows[IndexTable]["CreateDate"].ToString());
           // this.lblBillDate.Text = "Ngày " + objDate.Day + " tháng " + objDate.Month + " năm " + objDate.Year;
           // this.lblProviderName.Text = objTable.Rows[IndexTable]["PartnerName"].ToString();
           // this.lblProviderPhone.Text = objTable.Rows[IndexTable]["PartnerPhone"].ToString();
           // this.lvlProviderAddress.Text = objTable.Rows[IndexTable]["PartnerAddress"].ToString();
           // this.lblBillNote.Text = objTable.Rows[IndexTable]["Note"].ToString();
           //// this.lblTotalMoney.Text = string.Format("{0:###,0}", double.Parse(objTable.Rows[IndexTable]["TotalMoney"].ToString()));
           // this.TxtTienKhuyenMai.Text = string.Format("{0:###,0}", double.Parse(objTable.Rows[IndexTable]["DiscountPercentMoney"].ToString()) + double.Parse(objTable.Rows[IndexTable]["DiscountMoney"].ToString()));
           // this.TxtTongThanhToan.Text = string.Format("{0:###,0}", double.Parse(objTable.Rows[IndexTable]["TotalMoney"].ToString()));
           // this.TxtTienThanhToan.Text = string.Format("{0:###,0}",double.Parse(objTable.Rows[IndexTable]["TotalPay"].ToString()));
           // this.TxtNoCu.Text = string.Format("{0:###,0}", MoneyDebt);
           // this.TxtTongNo.Text = string.Format("{0:###,0}", MoneyDebt + double.Parse(objTable.Rows[IndexTable]["TotalMoney"].ToString()));
           // this.TxtConNo.Text = string.Format("{0:###,0}", MoneyDebt + double.Parse(objTable.Rows[IndexTable]["TotalMoney"].ToString()) - double.Parse(objTable.Rows[IndexTable]["TotalPay"].ToString()));

           // string temp123 = "";
           // Font objF = new Font(new FontFamily("Times New Roman"), 10, FontStyle.Regular);
           // objFunc.getFontForRetail(ref objF, ref temp123);
           // this.lblEnd.Font = objF;
           // this.lblEnd.Text = temp123;

           // this.lblMoneyByWord.Text = "Số tiền bằng chữ : "+this.objFunc.changeNumberToWord1(Convert.ToInt64(string.Format("{0:###,0}", double.Parse(objTable.Rows[IndexTable]["TotalMoney"].ToString())).Replace(",","")));
           // this.lblPrintTime.Text = "In lúc " +DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString()+" Ngày "+ DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();

            //#region CustomerPay
            //if (objConfig.GetKey("OutputShowCalculator") == "0")
            //{
            //    double sAllMoney = 0, CustomerPay = 0;
            //    try
            //    {
            //        sAllMoney = double.Parse(objTable.Rows[IndexTable]["TotalPay"].ToString());
            //    }
            //    catch { }
            //    try
            //    {
            //        CustomerPay = double.Parse(objTable.Rows[IndexTable]["CustomerPay"].ToString());
            //    }
            //    catch { }
            //    this.TxtCustomerPay.Text = string.Format("{0:###,0}", CustomerPay);
            //    if (CustomerPay > sAllMoney)
            //    {
            //        this.TxtCustomerReturn.Text = string.Format("{0:###,0}", CustomerPay - sAllMoney);
            //    }
            //    else this.TxtCustomerReturn.Text = "0";
            //}
            //else
            //{
            //    this.label33.Visible = false;
            //    this.label34.Visible = false;
            //    this.TxtCustomerPay.Visible = false;
            //    this.TxtCustomerReturn.Visible = false;
            //}
            //#endregion


            //#region Discount
            //if (objConfig.GetKey("OutputBillDiscount") != "0")
            //{
            //    this.LblKhuyenMai.Visible = false;
            //    this.LblTongThanhToan.Visible = false;
            //    this.TxtTienKhuyenMai.Visible = false;
            //    this.TxtTongThanhToan.Visible = false;

            //    this.LblNoCu.Top -= 0.5F;
            //    this.LblTongNo.Top -= 0.5F; 
            //    this.LblDaThanhToan.Top -= 0.5F;
            //    this.LblConNo.Top -= 0.5F;
            //    this.TxtNoCu.Top -= 0.5F;
            //    this.TxtTongNo.Top -= 0.5F;
            //    this.TxtTienThanhToan.Top -= 0.5F;
            //    this.TxtConNo.Top -= 0.5F;

            //    this.label33.Top -= 0.5F;
            //    this.label34.Top -= 0.5F;
            //    this.TxtCustomerPay.Top -= 0.5F;
            //    this.TxtCustomerReturn.Top -= 0.5F;

            //    this.LblFooter00.Top -= 0.5F;
            //    this.LblFooter10.Top -= 0.5F;
            //    this.LblFooter20.Top -= 0.5F;
            //    this.LblFooter30.Top -= 0.5F;
            //    this.LblFooter11.Top -= 0.5F;
            //    this.LblFooter21.Top -= 0.5F;
            //    this.LblFooter31.Top -= 0.5F;
            //    this.LblFooter01.Top -= 0.5F;
            //    this.reportFooter1.Height -= 0.5F;
            //}
            //#endregion

            //#region OutputBillFooter
            //if (objConfig.GetKey("OutputBillFooter") != "0")
            //{
            //    this.LblFooter00.Visible = false;
            //    this.LblFooter10.Visible = false;
            //    this.LblFooter20.Visible = false;
            //    this.LblFooter30.Visible = false;
            //    this.LblFooter11.Visible = false;
            //    this.LblFooter21.Visible = false;
            //    this.LblFooter31.Visible = false;
            //    this.LblFooter01.Visible = false;
            //    this.reportFooter1.Height -= 0.6F;
            //}
            //#endregion

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
