using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TVSGM
{
    public partial class FrmMain : Form
    {
        public static bool sAddForm = false, sHidePrice = false, sEditExim = false, sEditInOut = false, sEditEximYes = false, sEditInOutYes = false, sExportFile = false;
        public static string sAddressIP = "", sUsing = "NO";
        public static int sPort, IsRegistEvent=0;

        TVSSys.Connection obj = new TVSSys.Connection();
        //TVSTimeKeeper.clsCzkem objTimeKeeper = new TVSTimeKeeper.clsCzkem();

        public FrmMain()
        {
            InitializeComponent();

            sAddressIP = TVSSys.GlobalModule.objXML.GetKey("AddressIP");

            if (TVSSys.GlobalModule.objXML.GetKey("Port") == "")
                TVSSys.GlobalModule.objXML.UpdateKey("Port", "4370");

            sPort = int.Parse(TVSSys.GlobalModule.objXML.GetKey("Port"));
            sUsing = TVSSys.GlobalModule.objXML.GetKey("Using");
            //try
            //{
            //    objTimeKeeper.Connect_Net(sAddressIP, sPort);
            //    fConnect = true;
            //}
            //catch
            //{
            //    fConnect = false;
            //}
        }

        #region Close form
        private void CloseForm(System.Windows.Forms.Panel pnct, string objName)
        {
            sAddForm = false;
            for (int i = 0; i < pnct.Controls.Count; i++)
            {
                if (pnct.Controls[i].Name.ToString().ToUpper() != objName.ToUpper())
                {
                    try
                    {
                        Form frm = (Form)pnct.Controls[i];
                        frm.Close();
                    }
                    catch
                    {
                        pnct.Controls.Remove(pnct.Controls[i]);//.RemoveAt(i);
                    }
                  
                   
                    //pnct.Controls.Clear();
                }
            }
            sAddForm = true;
        }
        #endregion

        #region panelControl1_ControlRemoved
        private void panel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            //if (sAddForm && (panel1.Controls.Count == 0))
            //{
            //    panel1.Controls.Add(pictureBox1);
            //}
            if (sAddForm && (panel1.Controls.Count == 0))
            {
                Forms.FrmPartnerManager Frm = new Forms.FrmPartnerManager();
                this.Text = "TVS - QUẢN LÝ PHÒNG GYM";
                Frm.TopLevel = false;
                Frm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(Frm);
                Frm.Show();
            }
        }
        #endregion

        #region SetPermission
        public void SetPermission()
        {
            TVSSys.GlobalModule.objPermission = TVSSys.GlobalModule.objCon.GetSysPerUser(TVSSys.GlobalModule.objUserName);

            #region Hệ thống
            if (TVSSys.GlobalModule.objPermission.Contains("100")) MnuSystem0.Enabled = true;
            else MnuSystem0.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("101")) MnuSystem1.Enabled = true;
            else MnuSystem1.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("102")) MnuSystem4.Enabled = true;
            else MnuSystem4.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("103")) MnuSystem5.Enabled = true;
            else MnuSystem5.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("104")) MnuSystem6.Enabled = true;
            else MnuSystem6.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("105")) MnuSystem7.Enabled = true;
            else MnuSystem7.Enabled = false;
            #endregion

            #region Khai báo
            if (TVSSys.GlobalModule.objPermission.Contains("200") == false) MnuGymRoom.Enabled = false;
            else MnuGymRoom.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("201") == false) MnuPackGym.Enabled = false;
            else MnuPackGym.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("202") == false) MnuStore.Enabled = false;
            else MnuStore.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("203") == false) MnuUnit.Enabled = false;
            else MnuUnit.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("204") == false) MnuProductGroup.Enabled = false;
            else MnuProductGroup.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("205") == false) MnuProducts.Enabled = false;
            else MnuProducts.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("206") == false) MnuPartnerGroup.Enabled = false;
            else MnuPartnerGroup.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("207") == false) MnuPartner.Enabled = false;
            else MnuPartner.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("208") == false) MnuEmpGroup.Enabled = false;
            else MnuEmpGroup.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("209") == false) MnuEmp.Enabled = false;
            else MnuEmp.Enabled = true;
            #endregion

            #region Quản lý nhập xuất
            if (TVSSys.GlobalModule.objPermission.Contains("300") == false) MnuImport.Enabled = false;
            else MnuImport.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("301") == false) MnuExport.Enabled = false;
            else MnuExport.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("302") == false) MnuCancel.Enabled = false;
            else MnuCancel.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("303") == false) MnuInMoney.Enabled = false;
            else MnuInMoney.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("304") == false) MnuOutMoney.Enabled = false;
            else MnuOutMoney.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("305") == false) sHidePrice = false;
            else sHidePrice = true;
            if (TVSSys.GlobalModule.objPermission.Contains("306") == false) sEditExim = false;
            else sEditExim = true;
            if (TVSSys.GlobalModule.objPermission.Contains("307") == false) sEditInOut = false;
            else sEditInOut = true;
            if (TVSSys.GlobalModule.objPermission.Contains("308") == false) sEditEximYes = false;
            else sEditEximYes = true;
            if (TVSSys.GlobalModule.objPermission.Contains("309") == false) sEditInOutYes = false;
            else sEditInOutYes = true;
            if (TVSSys.GlobalModule.objPermission.Contains("310") == false) sExportFile = false;
            else sExportFile = true;
            #endregion

            #region Nghiệp vụ
            if (TVSSys.GlobalModule.objPermission.Contains("400") == false) MnuMemberRegis.Enabled = false;
            else MnuMemberRegis.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("401") == false) MnuMemberManager.Enabled = false;
            else MnuMemberManager.Enabled = true;
            #endregion

            #region Báo cáo
            if (TVSSys.GlobalModule.objPermission.Contains("500") == false) MnuRptPartnerStatus.Enabled = false;
            else MnuRptPartnerStatus.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("501") == false) MnuWorkoutHistory.Enabled = false;
            else MnuWorkoutHistory.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("502") == false) MnuRptPartnerNotRegis.Enabled = false;
            else MnuRptPartnerNotRegis.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("503") == false) MnuRptSynExim.Enabled = false;
            else MnuRptSynExim.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("504") == false) MnuImportDetail.Enabled = false;
            else MnuImportDetail.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("505") == false) MnuExportDetail.Enabled = false;
            else MnuExportDetail.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("506") == false) MnuInventory.Enabled = false;
            else MnuInventory.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("507") == false) MnuRptSale.Enabled = false;
            else MnuRptSale.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("508") == false) MnuRptDebtSupplier.Enabled = false;
            else MnuRptDebtSupplier.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("509") == false) MnuRptDebtPartner.Enabled = false;
            else MnuRptDebtPartner.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("510") == false) MnuSynInOut.Enabled = false;
            else MnuSynInOut.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("511") == false) MnuRptPartnerExpiringInMonth.Enabled = false;
            else MnuRptPartnerExpiringInMonth.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("512") == false) MnuFreezeHistory.Enabled = false;
            else MnuFreezeHistory.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("513") == false) MnuRptBillDelete.Enabled = false;
            else MnuRptBillDelete.Enabled = true;
            #endregion

            #region Trợ giúp
            if (TVSSys.GlobalModule.objPermission.Contains("600") == false) MnuIntro.Enabled = false;
            else MnuIntro.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("601") == false) MnuHelp.Enabled = false;
            else MnuHelp.Enabled = true;
            if (TVSSys.GlobalModule.objPermission.Contains("602") == false) MnuRegis.Enabled = false;
            else MnuRegis.Enabled = true;
            #endregion

        }
        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TVSSys.frmProgressBarBK form = new TVSSys.frmProgressBarBK();
            form.ShowDialog();
            CloseForm(panel1, "objFrm");

            //int tmp = TVSSys.GlobalModule.objCon.Get_EXESelectInt("select top 1 IDPartner from TblPartner where IDPartner IN " +
            //        " (select IDPartner from TblBill where convert(nvarchar,DateAp,112) = '" + DateTime.Now.ToString("yyyyMMdd") + "')");
            //if (tmp > 0)
            //{
            //    TVSGM.Forms.frmLichHenChamSoc f = new TVSGM.Forms.frmLichHenChamSoc();
            //    f.ShowDialog();
            //}

            //CloseForm(panelControl1, "objFrm");
            //if (System.Configuration.ConfigurationSettings.AppSettings["UsingRoomMap"].ToString() == "True")
            //{
            //    Forms.FrmRoomMap frm = new Forms.FrmRoomMap();
            //    frm.Name = "objFrm1";
            //    frm.TopLevel = false;
            //    frm.Dock = DockStyle.Fill;
            //    panel1.Controls.Add(frm);
            //    frm.Show();
            //}
            //else 
            //{
            //this.toolExport.PerformClick();
            //Forms.FrmPartnerManager frm = new Forms.FrmPartnerManager();
            //frm.Name = "objFrm1";
            //frm.TopLevel = false;
            //frm.Dock = DockStyle.Fill;
            //panel1.Controls.Add(frm);
            //frm.Show();
            // }
            Forms.FrmPartnerManager frm = new Forms.FrmPartnerManager();
            frm.Name = "objFrm1";
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panel1.Controls.Add(frm);
            frm.Show();
            SetPermission();
            lblCompany.Text = TVSSys.GlobalModule.objComName.ToUpper();
            lblFullName.Text = TVSSys.GlobalModule.objUserFullName.ToUpper();
            string squery = "select count(Birthday) from TblPartner where Convert(nvarchar(5),Birthday,103)='" + DateTime.Now.ToString("dd/MM") + "'";
            lblBirthday.Text = "Có " + Convert.ToString(obj.Get_EXESelectDouble(squery)) + " thành viên sinh nhật vào hôm nay";

        }

        #region mnuSystem
        private void MnuSystem0_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - ĐĂNG NHẬP";
            TVSSys.frmLogin frm = new TVSSys.frmLogin();
            frm.ShowDialog();
        }

        private void MnuSystem1_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - THAY ĐỔI MẬT KHẨU";
            TVSSys.FrmChangePW frm = new TVSSys.FrmChangePW();
            frm.ShowDialog();
        }

        private void MnuSystem2_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - TẠO TÀI KHOẢN MỚI";
            TVSSys.FrmupdtUser frm = new TVSSys.FrmupdtUser();
            frm.ShowDialog();
        }

        private void MnuSystem3_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - NHÓM NGƯỜI DÙNG";
            TVSSys.frmPerGroup frm = new TVSSys.frmPerGroup();
            frm.ShowDialog();
        }

        private void MnuSystem4_Click(object sender, EventArgs e)
        {
            //Text = "TVS - QUẢN LÝ PHÒNG GYM - PHÂN QUYỀN NGƯỜI DÙNG";
            //this.CloseForm(panel1, "objFrm");
            //TVSSys.frmPerGroup objfrm = new TVSSys.frmPerGroup();
            //objfrm.TopLevel = false;
            //objfrm.Dock = DockStyle.Fill;
            ////objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            //panel1.Controls.Add(objfrm);
            //objfrm.Show();


            Text = "TVS - QUẢN LÝ PHÒNG GYM - PHÂN QUYỀN NGƯỜI DÙNG";
            TVSSys.frmPerGroup frm = new TVSSys.frmPerGroup();
            frm.ShowDialog();
        }

        private void MnuSystem5_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - ĐƠN VỊ SỬ DỤNG";
            TVSSys.FrmRootCompany frm = new TVSSys.FrmRootCompany();
            frm.ShowDialog();
        }

        private void MnuSystem6_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - CẤU HÌNH HỆ THỐNG";
            TVSSys.FrmConfig frm = new TVSSys.FrmConfig();
            frm.ShowDialog();
        }

        private void MnuSystem7_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - CẤU HÌNH KẾT NỐI CSDL";
            TVSSys.FrmConnectData frm = new TVSSys.FrmConnectData();
            frm.ShowDialog();
        }
        #endregion

        private void MnuDir_Click(object sender, EventArgs e)
        {
            this.CloseForm(panel1, "objFrm");
            Forms.FrmDir objfrm = new Forms.FrmDir();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);

            objfrm.Show();
            Text = Forms.FrmDir.sText;
            panel1.Controls.Add(objfrm);
        }

        private void MnuImport_Click(object sender, EventArgs e)
        {
            this.CloseForm(panel1, "objFrm");
            Forms.FrmEximProducts objfrm = new Forms.FrmEximProducts();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            panel1.Controls.Add(objfrm);
            objfrm.Show();
            Text = Forms.FrmEximProducts.sText;
        }

        private void MnuInMoney_Click(object sender, EventArgs e)
        {
            this.CloseForm(panel1, "objFrm");
            Forms.FrmInOut objfrm = new Forms.FrmInOut();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            panel1.Controls.Add(objfrm);
            objfrm.Show();
            Text = Forms.FrmInOut.sText;
        }

        private void MnuMemberManager_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - QUẢN LÝ THÀNH VIÊN";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmPartnerManager objfrm = new Forms.FrmPartnerManager();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            panel1.Controls.Add(objfrm);
            objfrm.Show();
        }

        private void MnuMemberRegis_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - ĐĂNG KÝ THÀNH VIÊN";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmPartnerInfo objfrm = new Forms.FrmPartnerInfo();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            panel1.Controls.Add(objfrm);
            objfrm.Show();
        }

        private void MnuIntro_Click(object sender, EventArgs e)
        {
            TVSSys.frmIntro frm = new TVSSys.frmIntro();
            frm.sNameApp = "TVSGM";
            frm.ShowDialog();
        }

        private void MnuRptSale_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO DOANH THU";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmRptSale objfrm = new Forms.FrmRptSale();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            panel1.Controls.Add(objfrm);
            objfrm.Show();
        }

        private void MnuRptPartnerStatus_Click(object sender, EventArgs e)
        {
            this.CloseForm(panel1, "objFrm");
            Text = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO HIỆN TRẠNG KHÁCH HÀNG";
            Forms.FrmRptPartnerStatus objfrm = new Forms.FrmRptPartnerStatus();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            panel1.Controls.Add(objfrm);
            objfrm.Show();
        }

        private void MnuCancel_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - XUẤT HỦY HÀNG";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmCancelProducts objfrm = new Forms.FrmCancelProducts();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            panel1.Controls.Add(objfrm);
            objfrm.Show();
        }

        private void MnuRptDebtSupplier_Click(object sender, EventArgs e)
        {
            //Text = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO CÔNG NỢ NHÀ CUNG CÂP";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmRptDebtSupplier objfrm = new Forms.FrmRptDebtSupplier();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;

            objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            panel1.Controls.Add(objfrm);
            objfrm.Show();
            Text = Forms.FrmRptDebtSupplier.sText;
        }

        private void toolMemberRegis_Click(object sender, EventArgs e)
        {
            MnuMemberRegis.PerformClick();
        }

        private void toolMemberManager_Click(object sender, EventArgs e)
        {
            MnuMemberManager.PerformClick();
        }

        private void toolImport_Click(object sender, EventArgs e)
        {
            MnuImport.PerformClick();

        }

        private void toolExport_Click(object sender, EventArgs e)
        {
            MnuExport.PerformClick();
        }

        private void toolInMoney_Click(object sender, EventArgs e)
        {
            MnuInMoney.PerformClick();
        }

        private void toolOutMoney_Click(object sender, EventArgs e)
        {
            MnuOutMoney.PerformClick();
        }

        private void MnuRptPartnerNotRegis_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO DANH SÁCH KHÁCH HÀNG CHƯA ĐĂNG KÝ, HẾT HẠN";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmRptPartnerNotRegis objfrm = new Forms.FrmRptPartnerNotRegis();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            //objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            panel1.Controls.Add(objfrm);
            objfrm.Show();
            //Text = Forms.FrmEximProducts.sText;
        }

        private void MnuSynInOut_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO TỔNG HỢP THU CHI";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmRptSynInOut objfrm = new Forms.FrmRptSynInOut();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            //objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            panel1.Controls.Add(objfrm);
            objfrm.Show();
            //Text = Forms.FrmEximProducts.sText;
        }

        private void MnuRegis_Click(object sender, EventArgs e)
        {
            TVSSys.FrmRegister frm = new TVSSys.FrmRegister();
            frm.ShowDialog();
        }

        private void MnuInventory_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO HÀNG HÓA TỒN KHO";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmRptInventory objfrm = new Forms.FrmRptInventory();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            //objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            panel1.Controls.Add(objfrm);
            objfrm.Show();
        }

        private void MnuWorkoutHistory_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO LỊCH SỬ HOẠT ĐỘNG KHÁCH HÀNG";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmRptWorkoutHistory objfrm = new Forms.FrmRptWorkoutHistory();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            panel1.Controls.Add(objfrm);
            objfrm.Show();
        }

        private void lblBirthday_Click(object sender, EventArgs e)
        {
            Forms.FrmBirthdayPartner frm = new TVSGM.Forms.FrmBirthdayPartner();
            frm.ShowDialog();
        }

        private void MnuRptSynExim_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO XUẤT NHẬP HÀNG HÓA TỔNG HỢP";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmRptSynExim objfrm = new Forms.FrmRptSynExim();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            //objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            panel1.Controls.Add(objfrm);
            objfrm.Show();
        }

        private void MnuImportDetail_Click(object sender, EventArgs e)
        {
            //Text = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO NHẬP HÀNG CHI TIẾT";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmRptEximDetail objfrm = new Forms.FrmRptEximDetail();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            panel1.Controls.Add(objfrm);
            objfrm.Show();
            Text = Forms.FrmRptEximDetail.sText;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            TVSSys.frmProgressBarBK frm = new TVSSys.frmProgressBarBK();
            frm.ShowDialog();
        }

        private void MnuHelp_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("TV.exe");
            }
            catch (Exception ex)
            {
                Classes.clsMessage.Error("Không tìm thấy file yêu cầu");
            }
        }

        private void tinhPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Forms.Form1 frm = new TVSGM.Forms.Form1();
            //frm.ShowDialog();
        }

        private void MnuRptDetailPartnerRegis_Click(object sender, EventArgs e)
        {

        }

        private void mnuTimeKeeper_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - CẤU HÌNH KẾT NỐI THIẾT BỊ MÁY CHẤM CÔNG";
            Forms.FrmMachineConfig frm = new TVSGM.Forms.FrmMachineConfig();
            frm.ShowDialog();
        }

        private void mnuTimeKeeperConfig_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - CẤU HÌNH THỜI GIAN CHẤM CÔNG";
            Forms.FrmTimeKeeperConfig frm = new TVSGM.Forms.FrmTimeKeeperConfig();
            frm.ShowDialog();
        }

        private void MnuRptTimeKeeper_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO TỔNG SỐ CÔNG LÀM VIỆC TRONG THÁNG";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmRptTimeKeeper objfrm = new Forms.FrmRptTimeKeeper();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            panel1.Controls.Add(objfrm);
            objfrm.Show();
        }

        private void mnuOptionPrivate_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - TÙY CHỌN RIÊNG";
            Forms.FrmOptionOther frm = new TVSGM.Forms.FrmOptionOther();
            frm.ShowDialog();
        }

        private void mnuRoomMap_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - SƠ ĐỒ PHÒNG, BÀN";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmRoomMap objfrm = new Forms.FrmRoomMap();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            panel1.Controls.Add(objfrm);
            objfrm.Show();
        }

        private void mnuFloor_Click(object sender, EventArgs e)
        {
            this.CloseForm(panel1, "objFrm");
            Forms.FrmDir objfrm = new Forms.FrmDir();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);

            objfrm.Show();
            Text = Forms.FrmDir.sText;
            panel1.Controls.Add(objfrm);
        }

        private void mnuBed_Click(object sender, EventArgs e)
        {
            this.CloseForm(panel1, "objFrm");
            Forms.FrmDir objfrm = new Forms.FrmDir();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);

            objfrm.Show();
            Text = Forms.FrmDir.sText;
            panel1.Controls.Add(objfrm);
        }

        private void MnuSynInOutPartner_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO TỔNG HỢP LƯỢT VÀO RA CỦA KHÁCH HÀNG";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmRptSynInOutPartner objfrm = new Forms.FrmRptSynInOutPartner();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            //objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            panel1.Controls.Add(objfrm);
            objfrm.Show();
        }

        private void MnuRptPartnerExpiringInMonth_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO THÀNH VIÊN SẮP HẾT HẠN TRONG THÁNG";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmRptPartnerExpiringInMonth objfrm = new Forms.FrmRptPartnerExpiringInMonth();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            //objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            panel1.Controls.Add(objfrm);
            objfrm.Show();
        }

        private void MnuFreezeHistory_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO LỊCH SỬ ĐÓNG BĂNG THẺ THÀNH VIÊN";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmRptFreezeHistory objfrm = new Forms.FrmRptFreezeHistory();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            //objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            panel1.Controls.Add(objfrm);
            objfrm.Show();
        }

        private void MnuRptBillDelete_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - BÁO CÁO NHẬT KÝ SỬA XÓA HÓA ĐƠN";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmRptBillDelete objfrm = new Forms.FrmRptBillDelete();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            //objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            panel1.Controls.Add(objfrm);
            objfrm.Show();
        }

        private void MnuWorkoutHistory1_Click(object sender, EventArgs e)
        {
            Text = "TVS - QUẢN LÝ PHÒNG GYM - NHẬT KÝ ĐI TẬP CỦA KHÁCH HÀNG";
            this.CloseForm(panel1, "objFrm");
            Forms.FrmRptWorkoutHistoryV1 objfrm = new Forms.FrmRptWorkoutHistoryV1();
            objfrm.TopLevel = false;
            objfrm.Dock = DockStyle.Fill;
            //objfrm.sTableName = ((System.Windows.Forms.ToolStripMenuItem)sender).Name.Substring(3);
            panel1.Controls.Add(objfrm);
            objfrm.Show();
        }

        private void mnuLichHen_Click(object sender, EventArgs e)
        {
            Forms.frmLichHenChamSoc objfrm = new Forms.frmLichHenChamSoc();
            objfrm.ShowDialog();
        }

    }
}
