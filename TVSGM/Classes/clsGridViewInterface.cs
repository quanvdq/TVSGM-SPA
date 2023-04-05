using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using TVSSys;
using System.Data;
using System.Data.SqlClient;

namespace TVSGM.Classes
{
    class clsGridViewInterface
    {
        public static System.Windows.Forms.ComboBox LoadCboWhere(System.Windows.Forms.ComboBox cbo, string sValue, string sWhere1, string sWhere2)
        {
            cbo.BindingContext = new System.Windows.Forms.BindingContext();
            TVSSys.Connection objConnect = new Connection();
            string sDisplay = "Name" + sValue.Substring(2);
            string sTab = "Tbl" + sValue.Substring(2);
            string sSql = "select " + sValue + "," + sDisplay + " from " + sTab + " where " + sWhere1 + "=" + sWhere2 + " order by " + sDisplay;
            try
            {
                cbo.DisplayMember = sDisplay;
                cbo.ValueMember = sValue;
                cbo.DataSource = objConnect.EXESelect(sSql);
            }
            catch (Exception Ex)
            {
                Classes.clsMessage.Error("Lỗi:" + Ex.ToString());
            }
            return cbo;
        }

        public static System.Windows.Forms.ComboBox LoadCboDefault(System.Windows.Forms.ComboBox cbo, string sValue)
        {
            cbo.BindingContext = new System.Windows.Forms.BindingContext();
            TVSSys.Connection objConnect = new Connection();
            DataTable objTab = new DataTable();
            string sDisplay = "Name" + sValue.Substring(2);
            string sTab = "Tbl" + sValue.Substring(2);
            string sSql = "select " + sValue + "," + sDisplay + " from " + sTab + " order by " + sValue;
            try
            {
                objTab = objConnect.EXESelect(sSql);
                objTab.Rows.Add("0", "Không chọn");
                cbo.DisplayMember = sDisplay;
                cbo.ValueMember = sValue;
                cbo.DataSource = objTab;
            }
            catch (Exception Ex)
            {
                Classes.clsMessage.Error("Lỗi:" + Ex.ToString());
            }
            return cbo;
        }


        public static System.Windows.Forms.ComboBox LoadCbo(System.Windows.Forms.ComboBox cbo ,string sValue)
        {
            cbo.BindingContext = new System.Windows.Forms.BindingContext();
            TVSSys.Connection objConnect = new Connection();
            string sDisplay = "Name"+sValue.Substring(2);
            string sTab = "Tbl"+sValue.Substring(2);
            string sSql = "select " + sValue + "," + sDisplay + " from " + sTab + " order by " + sDisplay;
            try
            {
                cbo.DisplayMember = sDisplay;
                cbo.ValueMember = sValue;
                cbo.DataSource = objConnect.EXESelect(sSql);
            }
            catch (Exception Ex){
                Classes.clsMessage.Error("Lỗi:" + Ex.ToString());
            }
            return cbo;
        }

        public static System.Windows.Forms.ComboBox LoadSearchCbo(System.Windows.Forms.ComboBox cbo, string sValue)
        {
            DataTable objTab = new DataTable();
            cbo.BindingContext = new System.Windows.Forms.BindingContext();
            TVSSys.Connection objConnect = new Connection();
            string sDisplay = "Name" + sValue.Substring(2);
            string sTab = "Tbl" + sValue.Substring(2);
            string sSql = "select " + sValue + "," + sDisplay + " from " + sTab + " order by " + sValue + " ASC";
            try
            {
                objTab = objConnect.EXESelect(sSql);
                objTab.Rows.Add(0, "Xem tất cả");
                cbo.DisplayMember = sDisplay;
                cbo.ValueMember = sValue;
                cbo.DataSource = objTab;
                cbo.SelectedValue = 0;
            }
            catch (Exception Ex)
            {
                Classes.clsMessage.Error("Lỗi:" + Ex.ToString());
            }
            return cbo;
        }

        public static System.Windows.Forms.ComboBox LoadSearchCbo(System.Windows.Forms.ComboBox cbo, string sValue, string sWhere1, string sWhere2)
        {
            DataTable objTab = new DataTable();
            cbo.BindingContext = new System.Windows.Forms.BindingContext();
            TVSSys.Connection objConnect = new Connection();
            string sDisplay = "Name" + sValue.Substring(2);
            string sTab = "Tbl" + sValue.Substring(2);
            string sSql = "select " + sValue + "," + sDisplay + " from " + sTab + " where " + sWhere1 + "=" + sWhere2 + " order by " + sValue + " ASC";
            try
            {
                objTab = objConnect.EXESelect(sSql);
                objTab.Rows.Add(0, "Xem tất cả");
                cbo.DisplayMember = sDisplay;
                cbo.ValueMember = sValue;              
                cbo.DataSource = objTab;
            }
            catch (Exception Ex)
            {
                Classes.clsMessage.Error("Lỗi:" + Ex.ToString());
            }
            return cbo;
        }

        public static System.Windows.Forms.ComboBox LoadCbo(System.Windows.Forms.ComboBox cbo, string sDisPlay, string sValue, string sTable)
        {
            cbo.BindingContext = new System.Windows.Forms.BindingContext();
            TVSSys.Connection objConnect = new Connection();
            string sSql = "select " + sValue + "," + sDisPlay + " from " + sTable + " where " + sValue + "!='tvs' order by " + sDisPlay;
            try
            {
                cbo.DisplayMember = sDisPlay;
                cbo.ValueMember = sValue;
                cbo.DataSource = objConnect.EXESelect(sSql);
            }
            catch (Exception Ex)
            {
                Classes.clsMessage.Error("Lỗi:" + Ex.ToString());
            }
            return cbo;
        }

        public static System.Windows.Forms.ComboBox LoadCboSearch(System.Windows.Forms.ComboBox cbo, string sDisPlay, string sValue, string sTable)
        {
            cbo.BindingContext = new System.Windows.Forms.BindingContext();
            DataTable objTab = new DataTable();
            TVSSys.Connection objConnect = new Connection();
            string sSql = "select " + sValue + "," + sDisPlay + " from " + sTable + " where " + sValue + "!='tvs' order by " + sDisPlay + " asc";
            try
            {
                objTab = objConnect.EXESelect(sSql);
                objTab.Rows.Add("0", "Xem tất cả");
                cbo.DisplayMember = sDisPlay;
                cbo.ValueMember = sValue;
                cbo.DataSource = objTab;
                cbo.SelectedValue = 0;
            }
            catch (Exception Ex)
            {
                Classes.clsMessage.Error("Lỗi:" + Ex.ToString());
            }
            return cbo;
        }

        public static void SetGYMROOM(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDGymRoom"].Visible = false;
            sGrv.Columns["CodeGymRoom"].HeaderText = "Mã phòng tập";
            sGrv.Columns["NameGymRoom"].HeaderText = "Tên phòng tập";

            sGrv.Columns["CodeGymRoom"].Width = 182;    
            sGrv.Columns["NameGymRoom"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        public static void SetPACKGYM(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDPackGym"].Visible = false;
            sGrv.Columns["IDTypeGym"].Visible = false;
            sGrv.Columns["CodePackGym"].HeaderText = "Mã gói tập";
            sGrv.Columns["NamePackGym"].HeaderText = "Gói tập";
            sGrv.Columns["NameTypeGym"].HeaderText = "Loại gói";
            sGrv.Columns["Times"].HeaderText = "Số lần tập";
            sGrv.Columns["Price"].HeaderText = "Đơn giá";
            sGrv.Columns["TotalMoney"].HeaderText = "Thành tiền";

            sGrv.Columns["CodePackGym"].Width = 182;
            sGrv.Columns["Times"].Width = 100;
            sGrv.Columns["NameTypeGym"].Width = 150;
            sGrv.Columns["TotalMoney"].Width = 150;
            sGrv.Columns["NamePackGym"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["Times"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Price"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["TotalMoney"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["TotalMoney"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["Price"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
        }

        public static void SetTimeKeeping(System.Windows.Forms.DataGridView sGrv)
        {
            //sGrv.Columns["CodeEmp"].Visible = false;
            //sGrv.Columns["TimeKeeping"].HeaderText = "Ngày chấm công";
            //sGrv.Columns["HourStart"].HeaderText = "Giờ vào";
            //sGrv.Columns["HourFinish"].HeaderText = "Giờ ra";
            //sGrv.Columns["NameEmp"].HeaderText = "Họ và tên nhân viên";
            //sGrv.Columns["Delay"].HeaderText = "Đi trễ";

            //sGrv.Columns["TimeKeeping"].Width = 150;
            //sGrv.Columns["HourStart"].Width = 100;
            //sGrv.Columns["HourFinish"].Width = 100;
            //sGrv.Columns["Delay"].Width = 100;
            //sGrv.Columns["NameEmp"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            //sGrv.Columns["Delay"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

            sGrv.Columns["IdEmp"].Visible = false;
                sGrv.Columns["CodeEmp"].HeaderText = "Mã nhân viên";
            sGrv.Columns["NameEmp"].HeaderText = "Nhân viên";
            sGrv.Columns["TotalTime"].HeaderText = "Tổng công";

            sGrv.Columns["CodeEmp"].Width = 150;
            sGrv.Columns["TotalTime"].Width = 100;
            sGrv.Columns["NameEmp"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["TotalTime"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        }

        public static void SetTimeDetail(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["NameEmp"].Visible = false;
            sGrv.Columns["TimeKeeping"].HeaderText = "Ngày chấm công";
            sGrv.Columns["HourStart"].HeaderText = "Giờ vào";
            sGrv.Columns["HourFinish"].HeaderText = "Giờ ra";
            sGrv.Columns["Delay"].HeaderText = "Đi trễ";

            sGrv.Columns["TimeKeeping"].Width = 150;
            sGrv.Columns["HourStart"].Width = 100;
            sGrv.Columns["HourFinish"].Width = 100;
            sGrv.Columns["Delay"].Width = 100;
            sGrv.Columns["TimeKeeping"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["Delay"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

        }

        public static void SetWORKOUT(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDWorkOut"].Visible = false;
            sGrv.Columns["CodeWorkOut"].HeaderText = "Mã Buổi tập";
            sGrv.Columns["NameWorkOut"].HeaderText = "Buổi tập";
            sGrv.Columns["FromWorkOut"].HeaderText = "Từ";
            sGrv.Columns["ToWorkOut"].HeaderText = "Đến";

            sGrv.Columns["CodeWorkOut"].Width = 182;
            sGrv.Columns["NameWorkOut"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["FromWorkOut"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["ToWorkOut"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        }


        public static void SetSTORE(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDStore"].Visible = false;
            sGrv.Columns["CodeStore"].HeaderText = "Mã kho hàng";
            sGrv.Columns["NameStore"].HeaderText = "Tên kho hàng";
            sGrv.Columns["Manager"].HeaderText = "Quản lý";

            sGrv.Columns["CodeStore"].Width = 182;
            sGrv.Columns["NameStore"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        public static void SetUNIT(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDUnit"].Visible = false;
            sGrv.Columns["CodeUnit"].HeaderText = "Mã đơn vị";
            sGrv.Columns["NameUnit"].HeaderText = "Tên đơn vị";
            sGrv.Columns["Note"].HeaderText = "Ghi chú";

            sGrv.Columns["CodeUnit"].Width = 182;
            sGrv.Columns["NameUnit"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        public static void SetPRODUCTS(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IdProducts"].Visible = false;
            sGrv.Columns["IDUnit"].Visible = false;
            sGrv.Columns["CodeProducts"].HeaderText = "Mã sản phẩm";
            sGrv.Columns["NameProductGroup"].HeaderText = "Nhóm sản phẩm";
            sGrv.Columns["NameProducts"].HeaderText = "Tên sản phẩm";
            
            sGrv.Columns["NameUnit"].HeaderText = "Đơn vị tính";
            if (FrmMain.sHidePrice == false) sGrv.Columns["PriceIn"].Visible = false;
            else sGrv.Columns["PriceIn"].Visible = true;
            sGrv.Columns["PriceIn"].HeaderText = "Giá nhập";
            sGrv.Columns["PriceOut"].HeaderText = "Giá bán";

            sGrv.Columns["NameUnit"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            sGrv.Columns["PriceIn"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["PriceOut"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

            sGrv.Columns["PriceIn"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["PriceOut"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;

            sGrv.Columns["PriceOut"].HeaderText = "Giá bán";
            sGrv.Columns["NumberMin"].Visible = false;
            sGrv.Columns["NumberMax"].Visible = false;
            sGrv.Columns["Barcode"].Visible = false;
            sGrv.Columns["Quantitative"].Visible = false;
            sGrv.Columns["Hide"].Visible = false;
            sGrv.Columns["IDStock"].Visible = false;
            sGrv.Columns["NameSearch"].Visible = false;

            sGrv.Columns["NameUnit"].Width = 100;
            sGrv.Columns["PriceIn"].Width = 100;
            sGrv.Columns["PriceOut"].Width = 100;
            sGrv.Columns["CodeProducts"].Width = 120;
            sGrv.Columns["NameProductGroup"].Width = 120;
            sGrv.Columns["NameProducts"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        public static void SetPRODUCTGROUP(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDProductGroup"].Visible = false;
            sGrv.Columns["CodeProductGroup"].HeaderText = "Mã nhóm sản phẩm";
            sGrv.Columns["NameProductGroup"].HeaderText = "Nhóm sản phẩm";
            sGrv.Columns["IndexView"].Visible = false;
            sGrv.Columns["Note"].Visible = false;

            sGrv.Columns["CodeProductGroup"].Width = 182;
            sGrv.Columns["NameProductGroup"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        public static void SetINSTRUMENTS(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDInstruments"].Visible = false;
            sGrv.Columns["CodeInstruments"].HeaderText = "Mã dụng cụ";
            sGrv.Columns["Barcode"].Visible=false;
            sGrv.Columns["NameInstruments"].HeaderText="Tên dụng cụ";
            sGrv.Columns["NameUnit"].HeaderText = "Đơn vị tính";
            sGrv.Columns["PriceIn"].HeaderText="Giá nhập";
            sGrv.Columns["PriceOut"].HeaderText="Giá bán";
            sGrv.Columns["NameSearch"].Visible = false;

            sGrv.Columns["NameUnit"].Width = 120;
            sGrv.Columns["PriceIn"].Width=120;
            sGrv.Columns["PriceOut"].Width=120;
            sGrv.Columns["CodeInstruments"].Width = 182;
            sGrv.Columns["NameInstruments"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            sGrv.Columns["NameUnit"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            sGrv.Columns["PriceIn"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["PriceOut"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

            sGrv.Columns["PriceIn"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["PriceOut"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
        }

        public static void SetPARTNERGROUP(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDPartnerGroup"].Visible = false;
            sGrv.Columns["CodePartnerGroup"].HeaderText = "Mã nhóm khách hàng";
            sGrv.Columns["NamePartnerGroup"].HeaderText = "Tên nhóm khách hàng";

            sGrv.Columns["CodePartnerGroup"].Width = 182;
            sGrv.Columns["NamePartnerGroup"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        public static void SetPARTNER(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDPartner"].Visible = false;
            sGrv.Columns["CodePartner"].HeaderText = "Mã khách hàng";
            sGrv.Columns["NamePartnerGroup"].HeaderText = "Nhóm khách hàng";
            sGrv.Columns["NamePartnerType"].HeaderText = "Kiểu khách hàng";
            sGrv.Columns["NamePartner"].HeaderText = "Tên khách hàng";
            sGrv.Columns["Birthday"].HeaderText = "Sinh ngày";
            sGrv.Columns["Phone"].HeaderText = "Điện thoại";
            sGrv.Columns["Address"].HeaderText = "Địa chỉ";
            sGrv.Columns["Mobile"].Visible = false;
            sGrv.Columns["Fax"].Visible = false;
            sGrv.Columns["CodeTax"].Visible = false;
            sGrv.Columns["Email"].Visible = false;
            sGrv.Columns["FirstBalancer"].Visible = false;
            sGrv.Columns["NameSearch"].Visible = false;
            sGrv.Columns["Root"].Visible = false;
            sGrv.Columns["Note"].Visible = false;

            sGrv.Columns["CodePartner"].Width = 182;
            sGrv.Columns["NamePartnerGroup"].Width = 130;
            sGrv.Columns["NamePartnerType"].Width = 130;
            sGrv.Columns["Birthday"].Width = 80;
            sGrv.Columns["Phone"].Width = 80;
            sGrv.Columns["Address"].Width = 230;
            sGrv.Columns["NamePartner"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

        }

        public static void SetChosePack(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDPartnerRegis"].Visible = false;
            sGrv.Columns["IDPartner"].Visible = false;
            sGrv.Columns["IDPartnerType"].Visible = false;
            sGrv.Columns["IDPackGym"].Visible = false;
            sGrv.Columns["IDPartnerGroup"].Visible = false;
            sGrv.Columns["NamePackGym"].HeaderText = "Gói tập";
            sGrv.Columns["CodePartner"].HeaderText = "Mã khách hàng";
            sGrv.Columns["NamePartner"].HeaderText = "Tên khách hàng";
            sGrv.Columns["IDGender"].Visible = false;
            sGrv.Columns["Birthday"].HeaderText = "Sinh ngày";
            sGrv.Columns["Address"].HeaderText = "Địa chỉ";
            sGrv.Columns["Phone"].HeaderText = "Điện thoại";
            sGrv.Columns["IDGymRoom"].Visible = false;
            sGrv.Columns["IDTypeGym"].Visible = false;
            sGrv.Columns["IDWorkOut"].Visible = false;
            sGrv.Columns["Times"].Visible = false;
            sGrv.Columns["StartDate"].Visible = false;
            sGrv.Columns["EndDate"].Visible = false;
            sGrv.Columns["Active"].Visible = false;
            sGrv.Columns["ReExIDM"].Visible = false;
            sGrv.Columns["OriginalBill"].Visible = false;
            sGrv.Columns["Note"].HeaderText = "Ghi chú";

            sGrv.Columns["NamePackGym"].Width = 150;
            sGrv.Columns["CodePartner"].Width = 100;
            sGrv.Columns["NamePartner"].Width = 200;
            sGrv.Columns["IDGender"].Visible = false;
            sGrv.Columns["Birthday"].Width = 100;
            sGrv.Columns["Address"].Width = 250;
            sGrv.Columns["Phone"].Width = 150;
            sGrv.Columns["Note"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        public static void SetEMPGROUP(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDEmpGroup"].Visible = false;
            sGrv.Columns["CodeEmpGroup"].HeaderText = "Mã bộ phận";
            sGrv.Columns["NameEmpGroup"].HeaderText = "Bộ phận";
            sGrv.Columns["Note"].HeaderText = "Ghi chú";

            sGrv.Columns["CodeEmpGroup"].Width = 182;
            sGrv.Columns["Note"].Width = 350;
            sGrv.Columns["NameEmpGroup"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        public static void SetFLOOR(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IdFloor"].Visible = false;
            sGrv.Columns["CodeFloor"].HeaderText = "Mã Tầng, lầu";
            sGrv.Columns["NameFloor"].HeaderText = "Tầng lầu";
            sGrv.Columns["ZoneId"].Visible = false;

            sGrv.Columns["CodeFloor"].Width = 182;
            //sGrv.Columns["Note"].Width = 350;
            sGrv.Columns["NameFloor"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        public static void SetBED(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IdBed"].Visible = false;
            sGrv.Columns["CodeBed"].HeaderText = "Mã giường, ghế";
            sGrv.Columns["NameBed"].HeaderText = "Tên giường, ghế";
            sGrv.Columns["NameGymRoom"].HeaderText = "Phòng";
            sGrv.Columns["Poss"].HeaderText = "Vị trí";
            sGrv.Columns["State"].Visible = false;
            sGrv.Columns["PriceDay"].HeaderText = "Giá ngày";
            sGrv.Columns["PriceNight"].HeaderText = "Giá đêm";
            sGrv.Columns["PriceNight"].HeaderText = "Giá đêm";
            sGrv.Columns["IdFloor"].Visible = false;
            sGrv.Columns["IDGymRoom"].Visible = false;

            sGrv.Columns["CodeBed"].Width = 182;
            sGrv.Columns["NameBed"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["Poss"].Width = 182;
            sGrv.Columns["PriceDay"].Width = 182;
            sGrv.Columns["PriceNight"].Width = 182;
            sGrv.Columns["CodeBed"].Width = 182;
            sGrv.Columns["CodeBed"].Width = 182;

        }

        public static void SetEMP(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IdEmp"].Visible = false;
            sGrv.Columns["CodeEmp"].HeaderText = "Mã nhân viên";
            sGrv.Columns["NameEmpGroup"].HeaderText = "Bộ phận";
            sGrv.Columns["NameEmp"].HeaderText = "Tên nhân viên";
            sGrv.Columns["Birthday"].HeaderText = "Sinh ngày";
            sGrv.Columns["NameGender"].HeaderText = "Giới tính";
            sGrv.Columns["Address"].HeaderText = "Địa chỉ";
            sGrv.Columns["Phone"].HeaderText = "Điện thoại";

            sGrv.Columns["CodeEmp"].Width = 182;
            sGrv.Columns["NameEmp"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        public static void SetBill(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["ID"].Visible = false;
            sGrv.Columns["CreateDate"].Visible=false;
            sGrv.Columns["billID"].HeaderText = "Số hóa đơn";
            sGrv.Columns["IDPartner"].Visible = false;
            sGrv.Columns["ReExIDM"].Visible=false;
            sGrv.Columns["NamePartner"].Visible=false;
            sGrv.Columns["Address"].Visible=false;
            sGrv.Columns["Phone"].Visible=false;
            sGrv.Columns["TotalPay"].HeaderText="Tổng tiền";
            sGrv.Columns["PromotionMoney"].Visible=false;
            sGrv.Columns["PromotionPercent"].Visible=false;
            sGrv.Columns["PromotionPercentMoney"].Visible=false;
            sGrv.Columns["Payed"].Visible=false;
            sGrv.Columns["TotalMoney"].Visible = false;
            sGrv.Columns["IDStore"].Visible=false;
            sGrv.Columns["NameStore"].Visible = false;
            sGrv.Columns["UserName"].Visible=false;
            sGrv.Columns["Note"].Visible=false;
            

            sGrv.Columns["billID"].Width = 150;
            sGrv.Columns["TotalPay"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["TotalPay"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["TotalPay"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
        }

        public static void SetCancelBill(System.Windows.Forms.DataGridView sGrv)
        {
            //TblBill.ID,TblBill.CreateDate,TblBill.billID,TblBill.TotalMoney,TblBill.TotalPay,TblStore.IDStore, TblStore.NameStore,TabUser.UserName,TblBill.Note 

            sGrv.Columns["ID"].Visible = false;
            sGrv.Columns["CreateDate"].Visible = false;
            sGrv.Columns["billID"].HeaderText = "Số hóa đơn";
            sGrv.Columns["TotalPay"].Visible = false;
            sGrv.Columns["TotalMoney"].HeaderText = "Tổng tiền";
            
            sGrv.Columns["IDStore"].Visible = false;
            sGrv.Columns["NameStore"].Visible = false;
            sGrv.Columns["UserName"].Visible = false;
            sGrv.Columns["Note"].Visible = false;


            sGrv.Columns["billID"].Width = 150;
            sGrv.Columns["TotalMoney"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["TotalMoney"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["TotalMoney"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
        }

        public static void SetBillDetail(System.Windows.Forms.DataGridView sGrv)
        {
            try
            {
                sGrv.Columns["ID"].Visible = false;
                sGrv.Columns["billID"].Visible = false;
                sGrv.Columns["IDProducts"].Visible = false;
                sGrv.Columns["NameProducts"].HeaderText = "Tên sản phẩm";
                sGrv.Columns["IDUnit"].Visible = false;
                sGrv.Columns["NameUnit"].HeaderText = "Đơn vị tính";
                sGrv.Columns["Number"].HeaderText = "Số lượng";
                sGrv.Columns["Price"].HeaderText = "Đơn giá";
                sGrv.Columns["TotalMoney"].HeaderText = "Thành tiền";
                sGrv.Columns["FullName"].Visible = false;
                


                sGrv.Columns["NameUnit"].Width = 80;
                sGrv.Columns["Number"].Width = 80;
                //if (Forms.FrmEximProducts.sType == Classes.clsEnums.LoaiCuaSo.NH) 
                sGrv.Columns["Price"].Width = 100;
                //else


                sGrv.Columns["TotalMoney"].Width = 150;
                sGrv.Columns["NameProducts"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

                sGrv.Columns["NameUnit"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                sGrv.Columns["Number"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                sGrv.Columns["Price"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                sGrv.Columns["TotalMoney"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                sGrv.Columns["TotalMoney"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
                sGrv.Columns["Number"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
                sGrv.Columns["Price"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
                sGrv.Columns["NameUnit"].ReadOnly = true;
                sGrv.Columns["NameProducts"].ReadOnly = true;
            }
            catch (Exception ex) { }
        }



        public static void SetBillInOut(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["ID"].Visible = false;
            sGrv.Columns["billID"].Visible = false;
            sGrv.Columns["ReExIDM"].HeaderText = "Hóa đơn";
            sGrv.Columns["OriginalBill"].Visible = false;
            sGrv.Columns["CreateDate"].Visible = false;
            sGrv.Columns["I_ID"].Visible = false;
            sGrv.Columns["I_Name"].HeaderText = "Khoản thu/chi";
            sGrv.Columns["P_ID"].Visible = false;
            sGrv.Columns["P_Name"].HeaderText = "Đối tác";
            sGrv.Columns["P_Address"].Visible = false;
            sGrv.Columns["Payed"].HeaderText = "Tổng tiền";
            sGrv.Columns["U_UserName"].Visible = false;
            sGrv.Columns["U_FullName"].Visible = false;
            sGrv.Columns["Note"].HeaderText = "Ghi chú";
            sGrv.Columns["UserCreate"].Visible = false;
            sGrv.Columns["IDEmp"].Visible = false;

            sGrv.Columns["ReExIDM"].Width = 150;
            sGrv.Columns["I_Name"].Width = 200;
            sGrv.Columns["P_Name"].Width = 350;
            sGrv.Columns["Payed"].Width = 150;
            sGrv.Columns["Note"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["Payed"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Payed"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
        }

        public static void SetSynInOut(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["ID"].Visible = false;
            sGrv.Columns["billID"].Visible = false;
            sGrv.Columns["ReExIDM"].HeaderText = "Hóa đơn";
            sGrv.Columns["OriginalBill"].Visible = false;
            sGrv.Columns["CreateDate"].Visible = false;
            sGrv.Columns["I_ID"].Visible = false;
            sGrv.Columns["I_Name"].HeaderText = "Khoản thu/chi";
            sGrv.Columns["P_ID"].Visible = false;
            sGrv.Columns["P_Name"].HeaderText = "Đối tác";
            sGrv.Columns["P_Address"].Visible = false;
            sGrv.Columns["Payed"].HeaderText = "Tổng tiền";
            sGrv.Columns["U_UserName"].Visible = false;
            sGrv.Columns["U_FullName"].Visible = false;
            sGrv.Columns["Note"].HeaderText = "Ghi chú";
            sGrv.Columns["UserCreate"].Visible = false;
            sGrv.Columns["IDEmp"].Visible = false;


            sGrv.Columns["ReExIDM"].Width = 120;
            sGrv.Columns["I_Name"].Width = 150;
            sGrv.Columns["P_Name"].Width = 150;
            sGrv.Columns["Payed"].Width = 100;
            sGrv.Columns["Note"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["Payed"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Payed"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
        }

        public static void SetMEMBER(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDPartner"].Visible = false;
            sGrv.Columns["IDPartnerGroup"].Visible = false;
            sGrv.Columns["NamePartnerGroup"].Visible = false;
            sGrv.Columns["IDPartnerType"].Visible = false;            
            sGrv.Columns["TT"].HeaderText = "STT";
            sGrv.Columns["TT"].Width = 40;
            sGrv.Columns["CodePartner"].HeaderText = "Mã Khách hàng";
            sGrv.Columns["NamePartner"].HeaderText = "Tên Khách hàng";
            sGrv.Columns["IDGender"].Visible = false;
            sGrv.Columns["NameGender"].HeaderText = "Giới tính";
            sGrv.Columns["Birthday"].HeaderText = "Sinh ngày";
            sGrv.Columns["Phone"].HeaderText = "Điện thoại";
            sGrv.Columns["Address"].HeaderText = "Địa chỉ";
            sGrv.Columns["Mobile"].Visible = false;
          //  sGrv.Columns["Image"].Visible = false;
            sGrv.Columns["Fax"].Visible = false;
            sGrv.Columns["CodeTax"].Visible = false;
            sGrv.Columns["Email"].Visible = false;
            sGrv.Columns["FirstBalancer"].Visible = false;
            sGrv.Columns["NameSearch"].Visible = false;
            sGrv.Columns["Active"].Visible = false;
            sGrv.Columns["Hide"].Visible = false;
            sGrv.Columns["Note"].HeaderText = "Ghi chú";
            //sGrv.Columns["Image"].Visible = false;
            sGrv.Columns["IDEmp"].Visible = false;
            sGrv.Columns["SoCMND"].Visible = false;
            sGrv.Columns["TenNguoiNha"].Visible = false;
            sGrv.Columns["SDTNguoiNha"].Visible = false;

            sGrv.Columns["NamePartner"].Width = 350;
            sGrv.Columns["Address"].Width = 250;
            sGrv.Columns["Note"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["Birthday"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            sGrv.Columns["TT"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            sGrv.Columns["CodePartner"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            sGrv.Columns["NameGender"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
       }

        public static void SetPartner(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDPartner"].Visible = false;
            sGrv.Columns["IDPartnerGroup"].Visible = false;
            sGrv.Columns["NamePartnerGroup"].Visible = false;
            sGrv.Columns["IDPartnerType"].Visible = false;
            sGrv.Columns["TMP"].HeaderText = "Chọn";
            sGrv.Columns["TMP"].ReadOnly = false;
            sGrv.Columns["CodePartner"].HeaderText = "Mã Khách hàng";
            sGrv.Columns["CodePartner"].ReadOnly = true;
            sGrv.Columns["NamePartner"].HeaderText = "Tên Khách hàng";
            sGrv.Columns["NamePartner"].ReadOnly = true;
            sGrv.Columns["IDGender"].Visible = false;
            sGrv.Columns["NameGender"].HeaderText = "Giới tính";
            sGrv.Columns["NameGender"].ReadOnly = true;
            sGrv.Columns["Birthday"].HeaderText = "Sinh ngày";
            sGrv.Columns["Birthday"].ReadOnly = true;
            sGrv.Columns["Phone"].HeaderText = "Điện thoại";
            sGrv.Columns["Phone"].ReadOnly = true;
            sGrv.Columns["Address"].HeaderText = "Địa chỉ";
            sGrv.Columns["Address"].ReadOnly = true;
            sGrv.Columns["Mobile"].Visible = false;
            sGrv.Columns["Image"].Visible = false;
            sGrv.Columns["Fax"].Visible = false;
            sGrv.Columns["CodeTax"].Visible = false;
            sGrv.Columns["Email"].Visible = false;
            sGrv.Columns["FirstBalancer"].Visible = false;
            sGrv.Columns["NameSearch"].Visible = false;
            sGrv.Columns["Active"].Visible = false;
            sGrv.Columns["Note"].HeaderText = "Ghi chú";
            sGrv.Columns["Note"].ReadOnly = true;
            sGrv.Columns["Image"].Visible = false;
            sGrv.Columns["IDEmp"].Visible = false;

            sGrv.Columns["NamePartner"].Width = 350;
            sGrv.Columns["Address"].Width = 250;
            sGrv.Columns["Note"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["Birthday"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            sGrv.Columns["NameGender"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        }

        public static void SetREGIS(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDPartnerRegis"].Visible = false;
            sGrv.Columns["IDPartner"].Visible = false;
            sGrv.Columns["NameGymRoom"].Visible = false;
            sGrv.Columns["NameTypeGym"].Visible = false;
            sGrv.Columns["NamePackGym"].HeaderText = "Gói tập";
            sGrv.Columns["IDTypeGym"].Visible = false;
            sGrv.Columns["IDGymRoom"].Visible = false;
            sGrv.Columns["IDPackGym"].Visible = false;
            sGrv.Columns["IDWorkOut"].Visible = false;
            sGrv.Columns["Price"].Visible = false;
            sGrv.Columns["TotalPay"].Visible = false;
            sGrv.Columns["Payed"].Visible = false;
            sGrv.Columns["IDEmp"].Visible = false;
            sGrv.Columns["Times"].HeaderText = "Số lượt";
            sGrv.Columns["StartDate"].HeaderText = "Ngày bắt đầu";
            sGrv.Columns["EndDate"].HeaderText = "Ngày kết thúc";
            sGrv.Columns["Active"].HeaderText = "Kích hoạt";
            sGrv.Columns["ReExIDM"].Visible = false;
            sGrv.Columns["OriginalBill"].Visible = false;
            sGrv.Columns["Note"].Visible = false;
            sGrv.Columns["Freeze"].Visible = false;
            sGrv.Columns["DayLeft"].Visible = false;
            sGrv.Columns["IDRootBill"].Visible = false;


            sGrv.Columns["Times"].Width = 30;
            sGrv.Columns["Active"].Width = 50;
            sGrv.Columns["NamePackGym"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["Times"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        }

        public static void SetTimeInDay(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDTimeInDay"].Visible = false;
            sGrv.Columns["IDPartnerRegis"].Visible = false;

            sGrv.Columns["StartTime"].HeaderText = "Giờ bắt đầu";
            sGrv.Columns["FinishTime"].HeaderText = "Giờ kết thúc";


            sGrv.Columns["StartTime"].Width = 150;
            sGrv.Columns["FinishTime"].Width = 150;
        }

        public static void SetTimeShiftConfig(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDTimeShiftConfig"].Visible = false;
            sGrv.Columns["CodeShift"].Visible = false;
            sGrv.Columns["NameTimeShiftConfig"].HeaderText = "Tên ca";
            sGrv.Columns["HourStart"].HeaderText = "Vào ca";
            sGrv.Columns["HourFinish"].HeaderText = "Kết thúc ca";
            sGrv.Columns["NumHour"].HeaderText = "Tổng số giờ";
            sGrv.Columns["NumTimeKeeping"].HeaderText = "Số công";
            sGrv.Columns["HourMorningStart"].HeaderText = "Bắt đầu chấm";
            sGrv.Columns["HourMorningFinish"].HeaderText = "Kết thúc chấm";
            sGrv.Columns["Delay"].HeaderText = "Đi trễ";


            sGrv.Columns["NameTimeShiftConfig"].Width = 130;
            sGrv.Columns["HourStart"].Width = 60;
            sGrv.Columns["HourFinish"].Width = 60;
            sGrv.Columns["NumHour"].Width = 50;
            sGrv.Columns["NumTimeKeeping"].Width = 50;
            sGrv.Columns["HourMorningStart"].Width = 60;
            sGrv.Columns["HourMorningFinish"].Width = 60;
            sGrv.Columns["Delay"].Width = 50;

            sGrv.Columns["NameTimeShiftConfig"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["NumHour"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["NumTimeKeeping"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Delay"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["HourStart"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            sGrv.Columns["HourFinish"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            sGrv.Columns["HourMorningStart"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            sGrv.Columns["HourMorningFinish"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

        }

        public static void SetHistory(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDWorkoutHistory"].Visible = false;
            sGrv.Columns["IDPartnerRegis"].Visible = false;
            sGrv.Columns["IDPartner"].Visible = false;
            sGrv.Columns["IDPartnerGroup"].Visible = false;
            sGrv.Columns["NamePartnerGroup"].Visible = false;
            sGrv.Columns["IDPartnerType"].Visible = false;
            sGrv.Columns["NamePartnerType"].Visible = false;
            sGrv.Columns["IDPackGym"].Visible = false;
            sGrv.Columns["NamePackGym"].HeaderText = "Gói tập";
            sGrv.Columns["CodePartner"].HeaderText="Mã Khách hàng";
            sGrv.Columns["NamePartner"].HeaderText="Khách hàng";
            sGrv.Columns["IDGender"].Visible = false;
            sGrv.Columns["NameGender"].HeaderText="Giới tính";
            sGrv.Columns["BirthDay"].HeaderText="Sinh ngày";
            sGrv.Columns["Phone"].HeaderText="Điện thoại";
            sGrv.Columns["Address"].HeaderText="Địa chỉ";
            sGrv.Columns["IDGymRoom"].Visible = false;
            sGrv.Columns["NameGymRoom"].HeaderText="Phòng tập";
            sGrv.Columns["IDWorkOut"].Visible = false;
            sGrv.Columns["Count"].Visible = false;
            sGrv.Columns["DateIn"].HeaderText="Thời gian vào";
            sGrv.Columns["DateSearch"].Visible = false;

            sGrv.Columns["NamePartner"].Width = 150;
            sGrv.Columns["NamePackGym"].Width = 150;
            sGrv.Columns["NameGymRoom"].Width = 150;
            //sGrv.Columns["Address"].Width = 200;
            sGrv.Columns["DateIn"].Width = 150;
            sGrv.Columns["Address"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["BirthDay"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            
        }

        public static void SetSynInOutPartner(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDPartnerRegis"].Visible = false;
            sGrv.Columns["IDPartner"].Visible = false;
            sGrv.Columns["IDPartnerGroup"].Visible = false;
            sGrv.Columns["IDPartnerType"].Visible = false;
            sGrv.Columns["NameSearch"].Visible = false;
            sGrv.Columns["NamePartner"].HeaderText = "Khách hàng";
            sGrv.Columns["NameGender"].HeaderText = "Giới tính";
            sGrv.Columns["BirthDay"].HeaderText = "Sinh ngày";
            sGrv.Columns["Phone"].HeaderText = "Điện thoại";
            sGrv.Columns["Address"].HeaderText = "Địa chỉ";
            sGrv.Columns["Count"].HeaderText = "Lượt vào";
            sGrv.Columns["CodePartner"].HeaderText = "Mã khách hàng";


            sGrv.Columns["CodePartner"].Width = 150;
            sGrv.Columns["NamePartner"].Width = 250;
            sGrv.Columns["NameGender"].Width = 80;
            sGrv.Columns["BirthDay"].Width = 150;
            //sGrv.Columns["Address"].Width = 200;
            sGrv.Columns["Phone"].Width = 150;
            sGrv.Columns["Count"].Width = 150;
            sGrv.Columns["Address"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["BirthDay"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            sGrv.Columns["Count"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

        }

        public static void SetRptSale(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["ID"].Visible = false;
            sGrv.Columns["CreateDate"].HeaderText="Ngày tạo";
            sGrv.Columns["billID"].Visible = false;
            sGrv.Columns["IDPartner"].Visible = false;
            sGrv.Columns["OriginalBill"].HeaderText = "Chứng từ gốc";
            sGrv.Columns["IDInOut"].Visible = false;
            sGrv.Columns["IDPartner"].Visible = false;
            sGrv.Columns["UserCreate"].Visible = false;
            sGrv.Columns["DateSearch"].Visible = false;
            sGrv.Columns["IDEmp"].Visible = false;
            sGrv.Columns["ReExIDM"].HeaderText = "Số hóa đơn";
            sGrv.Columns["NamePartner"].HeaderText = "Tên khách hàng";
            sGrv.Columns["Address"].HeaderText = "Địa chỉ";
            sGrv.Columns["Phone"].HeaderText = "Điện thoại";
            sGrv.Columns["TotalMoney"].Visible = false;
            sGrv.Columns["PromotionMoney"].Visible = false;
            sGrv.Columns["PromotionPercent"].Visible = false;
            sGrv.Columns["PromotionPercentMoney"].Visible = false;
            sGrv.Columns["TotalPay"].Visible = false;
            sGrv.Columns["Payed"].HeaderText = "Đã thanh toán";
            sGrv.Columns["IDStore"].Visible = false;
            sGrv.Columns["Note"].HeaderText = "Ghi chú";
            sGrv.Columns["NameEmp"].HeaderText = "Kinh doanh";


            sGrv.Columns["ReExIDM"].Width = 150;
            sGrv.Columns["OriginalBill"].Width = 150;
            sGrv.Columns["NamePartner"].Width = 150;
            //sGrv.Columns["Note"].Width = 350;
            sGrv.Columns["NameEmp"].Width = 150;
            sGrv.Columns["Address"].Width = 250;
            sGrv.Columns["CreateDate"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            sGrv.Columns["Note"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["Payed"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Payed"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
        }

        public static void SetRptInventory(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IdProducts"].Visible = false;
            sGrv.Columns["CodeProducts"].Visible = false;
            sGrv.Columns["IDProductGroup"].Visible = false;
            sGrv.Columns["NameProductGroup"].Visible = false;
            sGrv.Columns["NameProducts"].HeaderText = "Tên sản phẩm";
            sGrv.Columns["NameUnit"].HeaderText = "Đơn vị tính";
            sGrv.Columns["NameSearch"].Visible = false;
            sGrv.Columns["FistExist"].HeaderText = "Tồn đầu";
            sGrv.Columns["ImPort"].HeaderText = "Nhập";
            sGrv.Columns["Export"].HeaderText = "Xuất";
            sGrv.Columns["LastEixst"].HeaderText = "Tồn cuối";


            sGrv.Columns["NameUnit"].Width = 150;
            sGrv.Columns["FistExist"].Width = 150;
            sGrv.Columns["ImPort"].Width = 150;
            sGrv.Columns["Export"].Width = 150;
            sGrv.Columns["LastEixst"].Width = 150;
            sGrv.Columns["NameProducts"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["FistExist"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["FistExist"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["ImPort"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["ImPort"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["Export"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Export"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["LastEixst"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["LastEixst"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
        }

        public static void SetRptParnterStatus(System.Windows.Forms.DataGridView sGrv)
        {
              sGrv.Columns["IDPartner"].Visible = false;
              sGrv.Columns["NamePartnerGroup"].HeaderText="Nhóm khách hàng";
              sGrv.Columns["NamePartnerType"].Visible = false;
              sGrv.Columns["CodePartner"].HeaderText="Mã khách hàng";
              sGrv.Columns["NamePartner"].HeaderText="Tên khách hàng";
              sGrv.Columns["NameGender"].HeaderText="Giới tính";
              sGrv.Columns["Birthday"].HeaderText="Sinh ngày";
              sGrv.Columns["Phone"].HeaderText="Điện thoại";
              sGrv.Columns["Address"].HeaderText="Địa chỉ";
              sGrv.Columns["Mobile"].Visible=false;
              sGrv.Columns["Fax"].Visible=false;
              sGrv.Columns["CodeTax"].Visible=false;
              sGrv.Columns["Email"].Visible=false;
              sGrv.Columns["FirstBalancer"].Visible=false;
              sGrv.Columns["NameSearch"].Visible=false;
              sGrv.Columns["Root"].Visible=false;
              sGrv.Columns["Note"].HeaderText="Ghi chú";
              sGrv.Columns["StartDate"].Visible=false;
              sGrv.Columns["Active"].HeaderText="Kích hoạt";
              sGrv.Columns["NameEmp"].HeaderText = "Kinh doanh";


              sGrv.Columns["CodePartner"].Width = 100;
              sGrv.Columns["NamePartner"].Width = 150;
              sGrv.Columns["NameGender"].Width = 100;
              sGrv.Columns["NameEmp"].Width = 150;
              sGrv.Columns["Address"].Width = 250;
              sGrv.Columns["Active"].Width = 80;
              sGrv.Columns["Birthday"].Width = 100;
              sGrv.Columns["Note"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        public static void SetRptParnterRegis(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDPartnerRegis"].Visible = false;
            sGrv.Columns["IDPartner"].Visible = false;
            sGrv.Columns["NameGymRoom"].HeaderText = "Phòng tập";
            sGrv.Columns["IDTypeGym"].Visible = false;
            sGrv.Columns["NamePackGym"].HeaderText = "Gói tập";
            sGrv.Columns["Times"].HeaderText = "Số lượt";
            sGrv.Columns["StartDate"].HeaderText = "Ngày bắt đầu";
            sGrv.Columns["EndDate"].HeaderText = "Ngày kết thúc";
            sGrv.Columns["Active"].HeaderText = "Tình trạng";
            sGrv.Columns["Note"].HeaderText = "Ghi chú";
            sGrv.Columns["Price"].HeaderText = "Đơn giá";
            sGrv.Columns["TotalPay"].HeaderText = "Thành tiền";
            sGrv.Columns["Payed"].HeaderText = "Đã thanh toán";


            sGrv.Columns["NameGymRoom"].Width = 100;
            sGrv.Columns["NamePackGym"].Width = 250;
            sGrv.Columns["Times"].Width = 100;
            sGrv.Columns["StartDate"].Width = 100;
            sGrv.Columns["EndDate"].Width = 100;
            sGrv.Columns["Active"].Width = 80;
            sGrv.Columns["Price"].Width = 100;
            sGrv.Columns["TotalPay"].Width = 150;
            sGrv.Columns["Payed"].Width = 150;
            sGrv.Columns["Note"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["Price"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Price"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["TotalPay"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["TotalPay"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["Payed"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Payed"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
        }

        public static void SetRptParnterExpiringInMonth(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDPartnerRegis"].Visible = false;
            sGrv.Columns["IDPartner"].Visible = false;
            sGrv.Columns["CodePartner"].HeaderText = "Mã thẻ";
            sGrv.Columns["NamePartner"].HeaderText = "Khách hàng";
            sGrv.Columns["NameGymRoom"].HeaderText = "Phòng tập";
            sGrv.Columns["IDTypeGym"].Visible = false;
            sGrv.Columns["NamePackGym"].HeaderText = "Gói tập";
            sGrv.Columns["Times"].HeaderText = "Số lượt";
            sGrv.Columns["StartDate"].HeaderText = "Ngày bắt đầu";
            sGrv.Columns["EndDate"].HeaderText = "Ngày kết thúc";
            sGrv.Columns["Active"].Visible = false;
            sGrv.Columns["Note"].HeaderText = "Ghi chú";
            sGrv.Columns["Price"].HeaderText = "Đơn giá";
            sGrv.Columns["TotalPay"].HeaderText = "Thành tiền";
            sGrv.Columns["Payed"].HeaderText = "Đã thanh toán";

            sGrv.Columns["NameGymRoom"].Width = 150;
            sGrv.Columns["NamePackGym"].Width = 150;
            sGrv.Columns["CodePartner"].Width = 100;
            sGrv.Columns["NamePartner"].Width = 200;
            sGrv.Columns["Times"].Width = 80;
            sGrv.Columns["StartDate"].Width = 100;
            sGrv.Columns["EndDate"].Width = 100;
            sGrv.Columns["Active"].Width = 80;
            sGrv.Columns["Price"].Width = 100;
            sGrv.Columns["TotalPay"].Width = 100;
            sGrv.Columns["Payed"].Width = 100;
            sGrv.Columns["Note"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["Price"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Price"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["TotalPay"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["TotalPay"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["Payed"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Payed"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
        }

        public static void SetRptFreezeHistory(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IdFreezeHistory"].Visible = false;        
            sGrv.Columns["IDPartnerRegis"].Visible = false;
            sGrv.Columns["IDPartner"].Visible = false;
            sGrv.Columns["IDPackGym"].Visible = false;
            sGrv.Columns["CodePartner"].HeaderText = "Mã thẻ";
            sGrv.Columns["NamePartner"].HeaderText = "Khách hàng";
            sGrv.Columns["NamePackGym"].HeaderText = "Gói tập";
            sGrv.Columns["StartDate"].HeaderText = "Ngày đăng ký";
            sGrv.Columns["DateFreezeHistory"].HeaderText = "Thời gian kích hoạt";
            sGrv.Columns["Freeze"].HeaderText = "Đóng băng";
            sGrv.Columns["UserCreate"].HeaderText = "Thao tác";

            sGrv.Columns["CodePartner"].Width = 150;
            //sGrv.Columns["NamePartner"].Width = 150;
            sGrv.Columns["NamePackGym"].Width = 150;
            sGrv.Columns["StartDate"].Width = 200;
            sGrv.Columns["DateFreezeHistory"].Width = 200;
            sGrv.Columns["Freeze"].Width = 80;
            sGrv.Columns["UserCreate"].Width = 150;
            sGrv.Columns["NamePartner"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        public static void SetRptBillDelete(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["ID"].Visible = false;
            sGrv.Columns["billID"].HeaderText = "Số hóa đơn";
            sGrv.Columns["ReExIDM"].Visible = false;
            sGrv.Columns["OriginalBill"].HeaderText = "Chứng từ gốc";
            sGrv.Columns["CreateDate"].HeaderText = "Ngày xóa";  
            sGrv.Columns["IDInOut"].Visible = false; 
            sGrv.Columns["IDTypeInOut"].Visible = false; 
            sGrv.Columns["IDPartner"].Visible = false;
            sGrv.Columns["CodePartner"].HeaderText = "Mã KH";
            sGrv.Columns["NamePartner"].HeaderText = "Tên KH"; 
            sGrv.Columns["PromotionMoney"].Visible = false; 
            sGrv.Columns["PromotionPercent"].Visible = false; 
            sGrv.Columns["PromotionPercentMoney"].Visible = false;
            sGrv.Columns["TotalMoney"].HeaderText = "Tổng tiền";
            sGrv.Columns["TotalPay"].HeaderText = "Thanh toán";
            sGrv.Columns["Payed"].HeaderText = "Đã thanh toán";
            sGrv.Columns["Note"].Visible = false;
            sGrv.Columns["UserCreate"].HeaderText = "Người xóa"; 
            sGrv.Columns["IDStore"].Visible = false; 
            sGrv.Columns["DateSearch"].Visible = false;
            sGrv.Columns["IDEmp"].Visible = false;
            sGrv.Columns["NameEmp"].HeaderText = "Kinh doanh"; 

            sGrv.Columns["billID"].Width = 120;
            sGrv.Columns["OriginalBill"].Width = 120;
            sGrv.Columns["CreateDate"].Width = 120;
            sGrv.Columns["CodePartner"].Width = 120;
            sGrv.Columns["TotalMoney"].Width = 100;
            sGrv.Columns["TotalPay"].Width = 100;
            sGrv.Columns["Payed"].Width = 100;
            sGrv.Columns["NameEmp"].Width = 150;
            sGrv.Columns["NamePartner"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["UserCreate"].Width = 150;

            sGrv.Columns["TotalMoney"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["TotalMoney"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["TotalPay"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["TotalPay"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["Payed"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Payed"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            
        }

        public static void SetRptDebtSupplier(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["IDPartner"].Visible = false;
            sGrv.Columns["NamePartner"].HeaderText = "Tên khách hàng";
            sGrv.Columns["NameSearch"].Visible = false;
            sGrv.Columns["Address"].HeaderText = "Địa chỉ";
            sGrv.Columns["Phone"].HeaderText = "Điện thoại";
            sGrv.Columns["Debs"].HeaderText = "Công nợ";



            sGrv.Columns["Phone"].Width = 150;
            sGrv.Columns["NamePartner"].Width = 250;
            sGrv.Columns["Debs"].Width = 80;
            sGrv.Columns["Address"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["Debs"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Debs"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
        }

        public static void SetRptArising(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["billID"].HeaderText = "Số hóa đơn chứng từ";
            sGrv.Columns["CreateDate"].HeaderText = "Ngày tạo";
            sGrv.Columns["TotalPay"].HeaderText = "Phát sinh";
            sGrv.Columns["Payed"].HeaderText = "Đã thanh toán";
            sGrv.Columns["Note"].HeaderText = "Diễn giải";
            sGrv.Columns["IDPartner"].Visible = false;



            sGrv.Columns["billID"].Width = 150;
            sGrv.Columns["CreateDate"].Width = 150;
            sGrv.Columns["TotalPay"].Width = 120;
            sGrv.Columns["Payed"].Width = 120;
            sGrv.Columns["Note"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["TotalPay"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["TotalPay"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["Payed"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Payed"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
        }

        public static void SetRptPrdArising(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["billID"].HeaderText = "Số hóa đơn chứng từ";
            sGrv.Columns["Number"].HeaderText = "Số lượng";
            sGrv.Columns["Price"].HeaderText = "Đơn giá";
            sGrv.Columns["TotalMoney"].HeaderText = "Thành tiền";



            sGrv.Columns["TotalMoney"].Width = 250;
            sGrv.Columns["Number"].Width = 150;
            sGrv.Columns["Price"].Width = 250;
            sGrv.Columns["billID"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["TotalMoney"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["TotalMoney"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["Number"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Number"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["Price"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Price"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
        }

        public static void SetRptEximDetail(System.Windows.Forms.DataGridView sGrv)
        {
            sGrv.Columns["ID"].Visible = false;
            sGrv.Columns["CreateDate"].Visible = false;
            sGrv.Columns["UserName"].Visible = false;
            sGrv.Columns["DateSearch"].Visible = false;
            sGrv.Columns["IDStore"].Visible = false;

            sGrv.Columns["billID"].HeaderText="Số hóa đơn";
            sGrv.Columns["NameProducts"].HeaderText="Tên sản phẩm";
            sGrv.Columns["NameUnit"].HeaderText="Tên đơn vị tính";
            sGrv.Columns["Number"].HeaderText="Số lượng";
            sGrv.Columns["Price"].HeaderText="Đơn giá";
            sGrv.Columns["TotalMoney"].HeaderText="Thành tiền";

            sGrv.Columns["billID"].Width = 150;
            sGrv.Columns["NameUnit"].Width = 120;
            sGrv.Columns["Number"].Width = 100;
            sGrv.Columns["Price"].Width = 120;
            sGrv.Columns["TotalMoney"].Width = 150;


            sGrv.Columns["NameProducts"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["Number"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Number"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["Price"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Price"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["TotalMoney"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["TotalMoney"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
        }

        public static void SetRptSynExim(System.Windows.Forms.DataGridView sGrv)
        { 
            sGrv.Columns["IdProducts"].Visible=false;
            sGrv.Columns["CodeProducts"].Visible=false;
            sGrv.Columns["IDProductGroup"].Visible=false;
            sGrv.Columns["NameProductGroup"].Visible=false;
            sGrv.Columns["NameProducts"].HeaderText="Tên sản phẩm";
            sGrv.Columns["NameUnit"].HeaderText="Đơn vị tính";
            sGrv.Columns["NameSearch"].Visible = false;
            sGrv.Columns["FistExist"].HeaderText="Tồn đầu";
            sGrv.Columns["FirstPrice"].HeaderText="Đơn giá";
            sGrv.Columns["FistMoney"].HeaderText="Thành tiền";
            sGrv.Columns["ImPort"].HeaderText="Nhập";
            sGrv.Columns["ImportPrice"].HeaderText="Đơn giá";
            sGrv.Columns["ImPortMoney"].HeaderText="Thành tiền";
            sGrv.Columns["Export"].HeaderText="Xuất";
            sGrv.Columns["ExportPrice"].HeaderText="Đơn giá";
            sGrv.Columns["ExportMoney"].HeaderText="Thành tiền";
            sGrv.Columns["LastEixst"].HeaderText="Tồn cuối";
            sGrv.Columns["LastPrice"].HeaderText="Đơn giá";
            sGrv.Columns["LastMoney"].HeaderText="Thành tiền";

            sGrv.Columns["FistExist"].Width = 60;
            sGrv.Columns["FirstPrice"].Width=80;
            sGrv.Columns["FistMoney"].Width=80;
            sGrv.Columns["ImPort"].Width=60;
            sGrv.Columns["ImportPrice"].Width=80;
            sGrv.Columns["ImPortMoney"].Width=80;
            sGrv.Columns["Export"].Width=50;
            sGrv.Columns["ExportPrice"].Width=80;
            sGrv.Columns["ExportMoney"].Width=80;
            sGrv.Columns["LastEixst"].Width=60;
            sGrv.Columns["LastPrice"].Width=80;
            sGrv.Columns["LastMoney"].Width=80;
            sGrv.Columns["NameUnit"].Width = 90;
            sGrv.Columns["NameProducts"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sGrv.Columns["FistExist"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

            sGrv.Columns["FirstPrice"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["FistMoney"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["ImPort"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["ImportPrice"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["ImPortMoney"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["Export"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["ExportPrice"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["ExportMoney"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["LastEixst"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["LastPrice"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            sGrv.Columns["LastMoney"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

            sGrv.Columns["FistExist"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["FirstPrice"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["FistMoney"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["ImPort"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["ImportPrice"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["ImPortMoney"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["Export"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["ExportPrice"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["ExportMoney"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["LastEixst"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["LastPrice"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
            sGrv.Columns["LastMoney"].DefaultCellStyle.Format = TVSSys.GlobalModule.objFormatPrice;
        }
    }
}
