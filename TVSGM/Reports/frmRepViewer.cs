using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Reports
{
    public partial class frmRepViewer : Form
    {
        #region declare objects
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);
        public static string orgName, orgAddress, orgPhone;
        public string srptType = "";
        public string srptTitle = "";
        public string sBillID = "";
        private DataDynamics.ActiveReports.ActiveReport3 report = null;
        TVSSys.clsPublic clsPublic = new TVSSys.clsPublic();
        #endregion

        #region method frmRepViewer
        public frmRepViewer()
        {
            InitializeComponent();
        } 
        #endregion

        #region method frmRepViewer_Load
        private void frmRepViewer_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                switch (srptType)
                {
                    case "rptReceiveBill":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptReceiveBill();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                    case "rptEximBillA5":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptEximBillA5();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                    case "rptCancelBillA5":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptCancelBillA5();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                    case "rptRepDebt":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptRepDebt();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                    case "rptRepInventory":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptRepInventory();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                    case "rptRepPartnerNotRegis":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptRepPartnerNotRegis();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                    case "rptRepPartnerExpiringInMonth":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptRepPartnerExpiringInMonth();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                    case "rptRepPartnerStatus":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptRepPartnerStatus();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                    case "rptRepSynInOut":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptRepSynInOut();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                    case "rptRepSale":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptRepSale();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                    case "rptRepSynExim":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptRepSynExim();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                        case "rptRepEximDetail":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptRepEximDetail();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                        case "rptRepTimeShift":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptRepTimeShift();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                        case "rptRepWorkoutHistory":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptRepWorkoutHistory();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                        case "rptRepSynInOutPartner":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptRepSynInOutPartner();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                        case "rptRepTimeShiftDetail":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptRepTimeShiftDetail();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                        case "rptRepFreezeHistory":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptRepFreezeHistory();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                        case "rptRepBillDelete":
                        {
                            //this.clsPublic.
                            this.Text = this.srptTitle;
                            this.report = new Reports.rptRepBillDelete();
                            this.viewer1.Document = this.report.Document;
                            this.report.Run();
                            break;
                            //this.report=new rpt
                            //break;
                        }
                    default:
                        {
                            break;
                        }
                }
                viewer1.Document = report.Document;
                report.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Cursor.Current = Cursors.Default;
        } 
        #endregion

        #region method frmRepViewer_KeyDown
        private void frmRepViewer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        } 
        #endregion
    }
}