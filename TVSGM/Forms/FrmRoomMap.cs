using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace TVSGM.Forms
{
    public partial class FrmRoomMap : Form
    {
        Classes.RoomButton roomItem;
        Classes.ProductGroup menuItem;
        public string sTableName, sReExIDM = String.Empty;
        public static string sText = String.Empty, sIDValue;
        public static bool fUpdate = false;
        public string sSQL ;
        string sIDProductGroup;
        Classes.clsRoom objRoom=new TVSGM.Classes.clsRoom();

        System.Data.DataTable objTable;
        private DataTable objTableProducts = new DataTable();
        private DataTable objTabPrdGrp = new DataTable();
        private DataTable objTabPrd = new DataTable();
        private DataTable objTabTimeInDay = new DataTable();
        private DataTable objTab = new DataTable();
        TVSSys.Connection objFunc = new TVSSys.Connection();
        Classes.clsUpdProducts objMember = new TVSGM.Classes.clsUpdProducts();
        
        int sTotal;
        string sEndDate, sStartDate;
        bool sCheck = false, sExpired, sFreeze;
        string sID, sIDRegis, sIDPartnerGroup, sIDPartnerType, sCodePartner, sNamePartner, sIDGender, sBirthday, sPhone, sAddress, sIDGymRoom, sIDPackGym, sIDTypeGym;
        private Color[] objColor = new Color[6];
        private Color[] objFontColor = new Color[6];
        private string currRoomId = "", currRoomName = "", currEmpName = "", tmpBillId = "", tmpReExIDM = "";
        private int currRoomRentId = 0, currPartnerId = 0, currType = 1, dgvServiceCurrIndex = -1, PersonNumber = 1, numPossInZone = 0, NumMonth = 1, currEmpId = 0, currTypeObject = 0;
        private DateTime TimeCheckIn = new DateTime();
        private DateTime TimeCheckOut = new DateTime();
        private double RoomMoney = 0, AdditionalMoney = 0, DiscountMoney = 0, ServiceMoney = 0, VatLevel = 0, VatMoney = 0, DepositMoney = 0, OtherMoney = 0, ForwardMoney = 0, TotalPaymented = 0, MoneyMakeVATBill = 0;
        
        private bool loadComplete = false;
        int colSpace, rowSpace, fWidth, fHeight, fNumRoom;
        public int dgvCurrIndex = -1;

        public FrmRoomMap()
        {
            InitializeComponent();

        }

        #region FrmRoomMap_Load
        private void FrmRoomMap_Load(object sender, EventArgs e)
        {
            DataTable objTable = new DataTable();
            //objTable = SystemConfig.getData();
            //fNumRoom = int.Parse(objTable.Rows[0]["CountColumn"].ToString());
            fNumRoom = 10;
            fWidth = 80;
            fHeight = 80;
            rowSpace = 10;
            colSpace = 10;
            LoadMap(false);
            LoadProductGroup();
        }
        #endregion        

        #region Load sơ đồ dịch vụ
        public void LoadMap(bool Reload)
        {
            try
            {
                Classes.RoomButton icoRoom;
                Classes.RoomGroupButton iconGroup;
                int fLeft = 10, fTop = 10, GroupId = 0, rowID = 0, fEmpty = 0, fSelected = 0, fBusing = 0;
                objTable = objRoom.getRoomInfo();

                if (Reload)
                {
                    for (int i = 0; i < objTable.Rows.Count; i++)
                    {
                        #region Thiet lap
                        icoRoom = (Classes.RoomButton)panelRoom.Controls["Room" + objTable.Rows[i]["Id"].ToString()];
                        icoRoom.StatusRoom = Convert.ToInt32(objTable.Rows[i]["State"].ToString());
                        icoRoom.IDRoom = objTable.Rows[i]["Id"].ToString();
                        icoRoom.Text = objTable.Rows[i]["NameRoom"].ToString();
                        icoRoom.NameRoom = objTable.Rows[i]["NameRoom"].ToString();
                        icoRoom.NameGroup = objTable.Rows[i]["NameFloor"].ToString();

                        #endregion

                        #region Thiết lập trạng thái
                        if (icoRoom.StatusRoom == 5)
                        {
                            SetButtonIcon(icoRoom);
                            fEmpty++;
                        }
                        if (icoRoom.StatusRoom == 4)
                        {
                            SetButtonIcon(icoRoom);
                            fSelected++;
                        }
                        else if (icoRoom.StatusRoom == 2)
                        {
                            SetButtonIcon(icoRoom);
                            fBusing++;
                        }

                        #endregion
                    }
                }
                else
                {
                    this.panelRoom.Controls.Clear();
                    fLeft = 0 + colSpace;
                    fTop = rowSpace;
                    for (int i = 0; i < objTable.Rows.Count; i++)
                    {

                        #region Khu vuc
                        if (GroupId != Convert.ToInt32(objTable.Rows[i]["IDGymRoom"].ToString()))
                        {
                            if (fLeft != 0 + colSpace)
                                fTop += fHeight + rowSpace;

                            GroupId = Convert.ToInt32(objTable.Rows[i]["IDGymRoom"].ToString());
                            iconGroup = new Classes.RoomGroupButton();
                            iconGroup.Text = objTable.Rows[i]["NameGymRoom"].ToString();
                            //groupIcon.Name = "Group_" + locatID.ToString();
                            iconGroup.Top = fTop;
                            iconGroup.Left = 0 + colSpace;
                            iconGroup.Height = 30;
                            iconGroup.Width = 80 * colSpace-10;
                            this.panelRoom.Controls.Add(iconGroup);

                            fTop += iconGroup.Height + rowSpace;
                            fLeft = iconGroup.Left;
                            rowID = 0;
                        }
                        #endregion

                        #region Thiet lap
                        icoRoom = new Classes.RoomButton();
                        icoRoom.StatusRoom = Convert.ToInt32(objTable.Rows[i]["State"].ToString());
                        icoRoom.Name = objTable.Rows[i]["IdBed"].ToString();
                        icoRoom.IDRoom = objTable.Rows[i]["IdBed"].ToString();
                        icoRoom.Text = objTable.Rows[i]["NameBed"].ToString();
                        icoRoom.NameRoom = objTable.Rows[i]["NameBed"].ToString();
                        icoRoom.NameGroup = objTable.Rows[i]["NameGymRoom"].ToString();
                        icoRoom.Width = fHeight;
                        icoRoom.Height = fWidth;
                        //icoRoom.Font = this.icoEmpty.Font;

                        #endregion

                        #region các sự kiện trên button icoRoom
                        icoRoom.ContextMenuStrip = this.contextMenu;
                        icoRoom.Click += new EventHandler(icoRoom_Click);
                        icoRoom.Click += new System.EventHandler(this.icoRoom_Click);
                        icoRoom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.icoRoom_MouseDown);
                        #endregion

                        #region Vi tri
                        icoRoom.Left = fLeft;
                        icoRoom.Top = fTop;
                        this.panelRoom.Controls.Add(icoRoom);
                        rowID++;
                        if ((rowID) % fNumRoom == 0)
                        {
                            fTop += fHeight + rowSpace;
                            fLeft = 0 + colSpace;
                        }
                        else
                        {
                            fLeft += icoRoom.Width + colSpace;
                        }
                        #endregion

                        SetButtonIcon(icoRoom);
                    }
                }
            }
            catch { }
        }
        #endregion

        #region SetButtonIcon
        public void SetButtonIcon(Classes.RoomButton RoomIcon)
        {
            if (RoomIcon.StatusRoom == 1)//Sử dụng
            {
                RoomIcon.Image = global::TVSGM.Properties.Resources.Used;
                return;
            }
            else if (RoomIcon.StatusRoom == 0)//trống
            {
                RoomIcon.Image = global::TVSGM.Properties.Resources.EmtyRoom;
                return;
            }

            
        }
        #endregion

        #region 
        public void LoadProductGroup()
        {
            Classes.ProductGroup icoGrpPrd;
            int MenuID = 0, fTopMenu = 0, fHeight = 0;
            //objTabPrdGrp = objProduct.getProductGroup();
            for (int i = 0; i < objTabPrdGrp.Rows.Count; i++)
            {
                MenuID = Convert.ToInt32(objTabPrdGrp.Rows[i]["IDProductGroup"].ToString());

                icoGrpPrd = new Classes.ProductGroup();
                icoGrpPrd.Text = objTabPrdGrp.Rows[i]["NameProductGroup"].ToString();
                icoGrpPrd.IDProductGroup = objTabPrdGrp.Rows[i]["IDProductGroup"].ToString();
                this.panelGroupPrd.Controls.Add(icoGrpPrd);

                icoGrpPrd.Height = 25;
                icoGrpPrd.Width = panelGroupPrd.Width;
                icoGrpPrd.Top = fHeight + fTopMenu;
                //iconMenu.Top = iconMenu.Height + fTopMenu;
                //fTopMenu = iconMenu.Height + fTopMenu + 1;
                fTopMenu = fHeight + fTopMenu + 1;
                fHeight = icoGrpPrd.Height;
                #region Khai báo sự kiện click vào nhóm thực đơn
                icoGrpPrd.Click += new EventHandler(icoGrpPrd_Click);
                #endregion
            }

        }
        #endregion

        #region Sự kiện click vào nhóm thực đơn
        private void icoGrpPrd_Click(object obj, EventArgs arg)
        {
            menuItem = (Classes.ProductGroup)obj;
            sIDProductGroup = menuItem.IDProductGroup;
            LoadMenu(int.Parse(sIDProductGroup));
        }
        #endregion

        #region method LoadMenu
        public void LoadMenu(int sIDProductGroup)
        {
            //objTabPrd = objProduct.getProduct(sIDProductGroup);
            gridProducts.DataSource = objTabPrd;
        }
        #endregion

        #region method icoRoom_Click
        private void icoRoom_Click(object sender, EventArgs arg)
        {
            //this.getRoomInfo(sender);
        }
        #endregion

        #region method objButton_MouseDown
        private void icoRoom_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //this.getRoomInfo(sender);
            }
        }
        #endregion

        #region method resetInformation
        private void resetInformation()
        {
            this.currRoomRentId = 0;
            this.nmrRoomMoney.Value = 0;
            this.nmrAdditionalMoney.Value = 0;
            this.nmrDiscountMoney.Value = 0;
            this.nmrServiceMoney.Value = 0;
            this.nmrVATLevel.Value = 0;
            this.nmrVatMoney.Value = 0;
            this.nmrDepositMoney.Value = 0;
            this.nmrTotalMoney.Value = 0;
            this.nmrOtherMoney.Value = 0;
            this.AdditionalMoney = 0;
            this.DiscountMoney = 0;
            this.ServiceMoney = 0;
            this.VatMoney = 0;
            this.DepositMoney = 0;
            this.OtherMoney = 0;
            this.txtCustomerName.Text = "";
            this.txtEmployeeName.Text = "";
            this.dgvService.DataSource = null;
            this.txtNumMonth.Text = "0";
            this.txtNumHours.Text = "";
            this.txtNumberPerson.Text = "1";
            this.dgvService.DataSource = null;
            this.dtpTimeCheckIn.Value = DateTime.Now;
            this.dtpTimeCheckOut.Value = DateTime.Now;
            this.txtTimeCheckIn.Text = "";
            this.nmrForwardMoney.Value = 0;
            this.nmrTotalPayment.Value = 0;
            this.nmrTotalPaymented.Value = 0;
        }
        #endregion

        #region method resetButtomEnable
        private void resetButtomEnable()
        {
            this.currRoomRentId = 0;
            this.btnUse.Enabled = false;
            //this.btnSelectService.Enabled = false;
            this.mnuCheckIn.Enabled = false;
            this.btnDel.Enabled = false;
            this.mnuDel.Enabled = false;
            this.btnGroup.Enabled = false;
            this.mnuGroup.Enabled = false;
            this.btnForward.Enabled = false;
            this.mnuForward.Enabled = false;
            this.mnuTmpBill.Enabled = false;
            this.btnCheckOut.Enabled = false;
            this.mnuCheckOut.Enabled = false;
            this.btnClear.Enabled = false;
            this.mnuService.Enabled = false;
            this.mnuCustomer.Enabled = false;
            this.btnSelectCustomer.Enabled = false;
            //this.btnSelectService.Enabled = false;
        }
        #endregion

        #region method TienVAT
        private void TienVAT()
        {
            double TotalMoneyBeforeTax = 0, VATMoney = 0;
            if (this.MoneyMakeVATBill == 0)
            {
                TotalMoneyBeforeTax = (double)((this.nmrRoomMoney.Value + this.nmrAdditionalMoney.Value + this.nmrServiceMoney.Value) - this.nmrDiscountMoney.Value);
            }
            else
            {
                TotalMoneyBeforeTax = MoneyMakeVATBill;
            }
            VATMoney = (TotalMoneyBeforeTax * (double)this.nmrVATLevel.Value) / 100;
            this.nmrVatMoney.Value = (decimal)VATMoney;
            this.nmrTotalMoney.Value = (((this.nmrRoomMoney.Value + this.nmrAdditionalMoney.Value + this.nmrServiceMoney.Value) - this.nmrDiscountMoney.Value) + this.nmrVatMoney.Value + this.nmrOtherMoney.Value + this.nmrForwardMoney.Value);
            this.nmrTotalPayment.Value = (((this.nmrRoomMoney.Value + this.nmrAdditionalMoney.Value + this.nmrServiceMoney.Value) - this.nmrDiscountMoney.Value) + this.nmrVatMoney.Value + this.nmrOtherMoney.Value + this.nmrForwardMoney.Value - this.nmrDepositMoney.Value - this.nmrTotalPaymented.Value);
        }
        #endregion

        #region method caculationTotalPayment
        private void caculationTotalPayment()
        {
            this.TienVAT();
            //double TotalMoneyBeforeTax = 0, VATMoney = 0;
            //TotalMoneyBeforeTax = (double)this.nmrRoomMoney.Value + (double)this.nmrAdditionalMoney.Value + (double)this.nmrServiceMoney.Value - (double)this.nmrDiscountMoney.Value;
            //VATMoney = (TotalMoneyBeforeTax * (double)this.nmrVATLevel.Value) / 100;
            //this.nmrVatMoney.Value = (decimal)VATMoney;
            //try
            //{
            //    this.nmrTotalMoney.Value = nmrRoomMoney.Value + nmrAdditionalMoney.Value - nmrDiscountMoney.Value + nmrServiceMoney.Value + nmrVatMoney.Value - nmrDepositMoney.Value;
            //}
            //catch
            //{
            //    this.nmrTotalMoney.Value = 0;
            //}
            //try
            //{
            //    this.nmrTotalPayment.Value = this.nmrTotalMoney.Value + nmrOtherMoney.Value + this.nmrForwardMoney.Value - this.nmrTotalPaymented.Value;
            //}
            //catch
            //{
            //    this.nmrTotalPayment.Value = 0;
            //}
            //if (this.nmrTotalPayment.Value < 0)
            //{
            //    this.nmrTotalPayment.Value = 0;
            //}
        }
        #endregion

        #region method SaveBill
        private void SaveBill(bool CheckOuted)
        {
            //this.objRoom.updateRoomRentDataFullNoTime(this.currRoomId, CheckOuted, (double)this.nmrRoomMoney.Value, (double)this.nmrAdditionalMoney.Value, (double)this.nmrDiscountMoney.Value, (double)this.nmrServiceMoney.Value, (double)this.nmrVATLevel.Value, (double)this.nmrVatMoney.Value, (double)this.nmrTotalMoney.Value, (double)this.nmrOtherMoney.Value, (double)this.nmrTotalPayment.Value, int.Parse(this.txtNumberPerson.Text), int.Parse(this.txtNumMonth.Text), (double)this.nmrForwardMoney.Value, this.currEmpId, this.currEmpName, "",MoneyMakeVATBill);
        }
        #endregion

        #region method updateService
        private double updateService()
        {
            if (this.currRoomRentId == 0)
                return 0;

            double tmpValue = 0;
            //for (int i = 0; i < this.dgvService.RowCount; i++)
            //{
            //    this.dgvService.Rows[i].Cells["dgvServiceMoney"].Value = float.Parse(this.dgvService.Rows[i].Cells["dgvServiceNumber"].Value.ToString()) * float.Parse(this.dgvService.Rows[i].Cells["dgvServicePrice"].Value.ToString());
            //    tmpValue += double.Parse(this.dgvService.Rows[i].Cells["dgvServiceMoney"].Value.ToString());
            //    if (float.Parse(this.dgvService.Rows[i].Cells["dgvServiceNumber"].Value.ToString()) >= 0)
            //    {
            //        this.objRoom.setRoomRentProductsDataCellEdit(this.currRoomRentId.ToString(), this.dgvService.Rows[i].Cells["dgvServiceId"].Value.ToString(), this.dgvService.Rows[i].Cells["dgvServiceNumber"].Value.ToString(), this.dgvService.Rows[i].Cells["dgvServicePrice"].Value.ToString());
            //        this.objRoom.settblBillDetailDataCellEdit(double.Parse(dgvService.Rows[i].Cells["dgvServiceNumber"].Value.ToString())
            //            , double.Parse(dgvService.Rows[i].Cells["dgvServicePrice"].Value.ToString())
            //            , int.Parse(dgvService.Rows[i].Cells["dgvServiceId"].Value.ToString())
            //            , this.currRoomRentId.ToString());


            //    }
            //}
            return tmpValue;
        } 
        #endregion

        #region btnCheckOut_Click
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //#region Goi form thanh toan nhom
            //if (this.objRoomRent.checkForRoomGroup(this.currRoomRentId.ToString()))
            //{
            //    frmRoomRentInMoneyGroup objRoomRentInMoneyGroup = new frmRoomRentInMoneyGroup();
            //    objRoomRentInMoneyGroup.RoomRentId = this.currRoomRentId;
            //    objRoomRentInMoneyGroup.ShowDialog();
            //    if (objRoomRentInMoneyGroup.Paymented)
            //    {
            //        // this.mnuTmpBill.PerformClick(); 

            //        Reports.frmReportViewer objRepView = new Reports.frmReportViewer();
            //        if (objRoomRentInMoneyGroup.sCoutRoomRentId >= 1)
            //        {
            //            objRepView.RoomMoneyTotal = objRoomRentInMoneyGroup.txtRoomMoney.Text;
            //            objRepView.ServiceMoneyTotal = objRoomRentInMoneyGroup.txtServiceMoney.Text;
            //            objRepView.DepositMoneyTotal = objRoomRentInMoneyGroup.txtDepositMoney.Text;
            //            objRepView.TotalPaymentTotal = objRoomRentInMoneyGroup.txtTotalPayment.Text;
            //            objRepView.TotalPaymentedTotal = objRoomRentInMoneyGroup.txtMoney.Text;

            //            objRepView.sListRoomRentId = objRoomRentInMoneyGroup.sListRoomRentId;
            //            objRepView.IndexTable = objRoomRentInMoneyGroup.sCoutRoomRentId;
            //        }
            //        else
            //        {
            //            objRepView.RoomMoneyTotal = "0";
            //            objRepView.ServiceMoneyTotal = "0";
            //            objRepView.DepositMoneyTotal = "0";
            //            objRepView.TotalPaymentTotal = "0";
            //            objRepView.TotalPaymentedTotal = "0";
            //            objRepView.sListRoomRentId = objRoomRentInMoneyGroup.sListRoomRentId;
            //            objRepView.IndexTable = objRoomRentInMoneyGroup.sCoutRoomRentId;
            //        }

            //        objRepView.srptTitle = "IN PHIẾU THANH TOÁN";
            //        objRepView.srptType = "frmRepPaymentBillGroup";
            //        objRepView.ShowDialog();


            //        int tmpRoomRentId = this.currRoomRentId;
            //        this.LoadMap(true);
            //        this.resetInformation();
            //        this.resetButtomEnable();
            //        if (tmpRoomRentId > 0)
            //        {
            //            //  this.PrintBill(tmpRoomRentId);
            //            tmpRoomRentId = 0;
            //        }
            //    }
            //}
            //else
            //#endregion

            //#region Goi form thanh toan phong le
            //{
            //    //if (this.nmrTotalPayment.Value > 0)
            //    //{
            //    frmRoomRentInMoney objRoomRentInMoney = new frmRoomRentInMoney();
            //    objRoomRentInMoney.nmrTotalPayment.Value = this.nmrTotalPayment.Value;
            //    objRoomRentInMoney.cbbUserName.Text = clsGeneral.fullName;
            //    objRoomRentInMoney.objectId = this.currPartnerId.ToString();
            //    objRoomRentInMoney.txtBillRoot.Text = this.currRoomRentId.ToString();
            //    objRoomRentInMoney.currRoomRentId = this.currRoomRentId;
            //    objRoomRentInMoney.txtPersonInput.Text = this.txtCustomerName.Text;
            //    objRoomRentInMoney.txtNote.Text = "Thanh toán tiền phòng " + this.txtRoomName.Text;

            //    objRoomRentInMoney.currRoomId = int.Parse(this.currRoomId);
            //    objRoomRentInMoney.tmpBillId = tmpBillId;
            //    objRoomRentInMoney.txtCustomerName.Text = this.txtCustomerName.Text;
            //    objRoomRentInMoney.txtRoomName.Text = this.txtRoomName.Text;
            //    objRoomRentInMoney.dtpTimeCheckIn.Value = this.dtpTimeCheckIn.Value;
            //    objRoomRentInMoney.dtpTimeCheckOut.Value = DateTime.Now;
            //    objRoomRentInMoney.txtEmployeeName.Text = this.txtEmployeeName.Text;
            //    objRoomRentInMoney.txtNumberPerson.Text = this.txtNumberPerson.Text;
            //    objRoomRentInMoney.txtNumMonth.Text = this.txtNumMonth.Text;
            //    objRoomRentInMoney.txtMoney.Text = this.nmrTotalPayment.Value.ToString();
            //    objRoomRentInMoney.ShowDialog();
            //    this.nmrDiscountMoney.Value = objRoomRentInMoney.nmrDiscountMoney.Value;
            //    if (objRoomRentInMoney.Paymented)
            //    {
            //        this.nmrAdditionalMoney.Value = objRoomRentInMoney.nmrAdditionalMoney.Value;

            //        this.mnuTmpBill.PerformClick();

            //        clsGeneral.setSystemLog("Thanh toán phòng " + this.currRoomName, clsGeneral.fullName + " [" + clsGeneral.userName + "]");
            //        int tmpRoomRentId = this.currRoomRentId;
            //        this.LoadMap(true);
            //        this.resetInformation();
            //        this.resetButtomEnable();
            //        if (tmpRoomRentId > 0)
            //        {
            //            //   this.PrintBill(tmpRoomRentId);
            //            tmpRoomRentId = 0;
            //        }
            //    }
            //    //}
            //    //else
            //    //{
            //    //    General.setSystemLog("Thanh toán phòng " + this.currRoomName, General.fullName + " [" + General.userName + "]");
            //    //    int tmpRoomRentId = this.currRoomRentId;
            //    //    this.objRoom.updateRoomRentDataFullNoTime(this.currRoomId.ToString(), true, (double)this.nmrRoomMoney.Value, (double)this.nmrAdditionalMoney.Value, (double)this.nmrDiscountMoney.Value, (double)this.nmrServiceMoney.Value, (double)this.nmrVATLevel.Value, (double)this.nmrVatMoney.Value, (double)this.nmrTotalMoney.Value, (double)this.nmrOtherMoney.Value, (double)this.nmrTotalPayment.Value, int.Parse(this.txtNumberPerson.Text), int.Parse(this.txtNumMonth.Text), (double)this.nmrForwardMoney.Value, this.currEmpId, this.currEmpName, "");
            //    //    this.objRoom.setPaymentState(this.currRoomId.ToString(), frmMain.Username);
            //    //    string RoomRentBillId = this.objRoom.getNextRoomRentBillId();
            //    //    this.objRoom.setRoomRentBillId(tmpRoomRentId.ToString(), RoomRentBillId);
            //    //    this.objDicRoomStatus = this.objRoom.getRoomStatus(this.cbbZone.SelectedValue.ToString());
            //    //    this.objDicRoomIdState = this.objRoom.getRoomIdStatus(this.cbbZone.SelectedValue.ToString());
            //    //    this.objDicRoomId = this.objRoom.getRoomId(this.cbbZone.SelectedValue.ToString());
            //    //    this.updateMaps();
            //    //    this.resetInformation();
            //    //    this.resetButtomEnable();
            //    //    if (tmpRoomRentId > 0)
            //    //    {
            //    //        if (tmpRoomRentId > 0)
            //    //        {
            //    //            this.PrintBill(tmpRoomRentId);
            //    //            tmpRoomRentId = 0;
            //    //        }
            //    //    }
            //    //}
            //}
            //#endregion

            //this.LoadMap(false);
        }
        #endregion

        #region method btnClear_Click
        private void btnClear_Click(object sender, EventArgs e)
        {
            //this.objRoom.setClearedState(this.currRoomId);
            //this.objDicRoomStatus = this.objRoom.getRoomStatus(this.cbbZone.SelectedValue.ToString());
            //this.objDicRoomIdState = this.objRoom.getRoomIdStatus(this.cbbZone.SelectedValue.ToString());
            //this.objDicRoomId = this.objRoom.getRoomId(this.cbbZone.SelectedValue.ToString());
            //this.updateMaps();
            this.LoadMap(false);
            this.resetInformation();
            this.resetButtomEnable();
        }
        #endregion

        #region method btnDel_Click
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy phòng " + btnRoomName.Text + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //this.objRoom.removeRoomRentItem(this.currRoomRentId.ToString());
                //this.objBill.removeBill(this.currRoomRentId.ToString(), tmpBillId);
                //this.objRoom.updateState(this.currRoomId, "0");
                //this.objBill.CancelRoomRentId(this.currPartnerId.ToString(), this.currRoomRentId.ToString());
                //clsGeneral.setSystemLog("Hủy phòng " + this.currRoomName, clsGeneral.fullName + " [" + clsGeneral.userName + "]");
                //this.objDicRoomStatus = this.objRoom.getRoomStatus(this.cbbZone.SelectedValue.ToString());
                //this.objDicRoomIdState = this.objRoom.getRoomIdStatus(this.cbbZone.SelectedValue.ToString());
                //this.objDicRoomId = this.objRoom.getRoomId(this.cbbZone.SelectedValue.ToString());
                //this.updateMaps();
                this.LoadMap(false);
            }
        }
        #endregion

        #region method btnForward_Click
        private void btnForward_Click(object sender, EventArgs e)
        {
            DateTime DateTimeForward = DateTime.Now;

            //frmSelectRoomForward objSelectRoomForward = new frmSelectRoomForward();
            //objSelectRoomForward.txtRoomName1.Text = this.txtRoomName.Text;

            //objSelectRoomForward.RoomId1 = int.Parse(this.currRoomId);
            //objSelectRoomForward.NumMonth = int.Parse(this.txtNumMonth.Text);
            //objSelectRoomForward.currRoomRentId = currRoomRentId.ToString();

            //objSelectRoomForward.dtpTimeCheckIn.Value = this.dtpTimeCheckIn.Value;
            //objSelectRoomForward.dtpTimeCheckOut.Value = DateTimeForward;

            //objSelectRoomForward.dtpTimeCheckIn1.Value = this.dtpTimeCheckIn.Value;
            //objSelectRoomForward.dtpTimeCheckOut1.Value = this.dtpTimeCheckOut.Value;

            //objSelectRoomForward.nmrRoomMoney.Value = this.nmrRoomMoney.Value;
            //objSelectRoomForward.nmrAdditionalMoney.Value = this.nmrAdditionalMoney.Value;
            //objSelectRoomForward.nmrDiscountMoney.Value = this.nmrDiscountMoney.Value;
            //objSelectRoomForward.nmrServiceMoney.Value = this.nmrServiceMoney.Value;
            //objSelectRoomForward.nmrVATLevel.Value = this.nmrVATLevel.Value;
            //objSelectRoomForward.nmrVatMoney.Value = this.nmrVatMoney.Value;
            //objSelectRoomForward.nmrDepositMoney.Value = this.nmrDepositMoney.Value;
            //objSelectRoomForward.nmrTotalMoney.Value = this.nmrTotalMoney.Value;
            //objSelectRoomForward.nmrOtherMoney.Value = this.nmrOtherMoney.Value;
            //objSelectRoomForward.nmrElecAndWate.Value = this.nmrForwardMoney.Value;
            //objSelectRoomForward.nmrTotalPaymented.Value = this.nmrTotalPaymented.Value;
            //objSelectRoomForward.nmrTotalPayment.Value = this.nmrTotalPayment.Value;

            //objSelectRoomForward.ShowDialog();
            //if (int.Parse(this.currRoomId) > 0 && objSelectRoomForward.RoomId2 > 0)
            //{
            //    int ForwardType = 0;
            //    if (objSelectRoomForward.rdbForward1.Checked)
            //    {
            //        ForwardType = 0;
            //    }
            //    else
            //    {
            //        ForwardType = 1;
            //    }

            //    string RoomRentIdForward = "0";

            //    if (objSelectRoomForward.rdbForward2.Checked)
            //    {
            //        this.objRoom.setRoomForward(this.currRoomId, objSelectRoomForward.RoomId2.ToString(), this.currRoomRentId.ToString(), ref RoomRentIdForward, DateTimeForward, double.Parse(objSelectRoomForward.txtMoneyForward.Text), ForwardType, objSelectRoomForward.txtRoomName1.Text, objSelectRoomForward.txtRoomName2.Text);
            //        #region Cap nhat thong tin cua phong duoc chuyen den
            //        this.currRoomRentId = int.Parse(RoomRentIdForward);
            //        this.currRoomId = objSelectRoomForward.RoomId2.ToString();
            //        this.dtpTimeCheckIn.Value = DateTimeForward;
            //        this.nmrRoomMoney.Value = (decimal)this.objFuncMoney.calRoomMoney(this.currRoomId, DateTimeForward, this.dtpTimeCheckOut.Value, this.txtNumMonth.Text, this.txtNumberPerson.Text, ref AdditionalMoney,this.currRoomRentId.ToString());
            //        this.nmrAdditionalMoney.Value = (decimal)AdditionalMoney;
            //        this.caculationTotalPayment();
            //        this.objRoom.updateRoomRentData(this.currRoomRentId.ToString(), this.currRoomId, DateTimeForward, this.dtpTimeCheckOut.Value);
            //        this.SaveBill(false);
            //        this.objRoom.setRoomRentCustomer(this.currRoomId, this.currPartnerId, this.currType);
            //        clsGeneral.setSystemLog("Chuyển phòng " + this.currRoomName + " - sang phòng " + objSelectRoomForward.RoomId2.ToString() + "(ID)", clsGeneral.fullName + " [" + clsGeneral.userName + "]");
            //        #endregion
            //    }
            //    else
            //    {
            //        this.dtpTimeCheckIn.Value = objSelectRoomForward.dtpTimeCheckIn1.Value;
            //        this.objRoom.setRoomForward(this.currRoomId, objSelectRoomForward.RoomId2.ToString(), this.currRoomRentId.ToString(), ref RoomRentIdForward, objSelectRoomForward.dtpTimeCheckIn1.Value, double.Parse(objSelectRoomForward.txtMoneyForward.Text), ForwardType, objSelectRoomForward.txtRoomName1.Text, objSelectRoomForward.txtRoomName2.Text);
            //        #region Cap nhat thong tin cua phong duoc chuyen den
            //        this.currRoomRentId = int.Parse(RoomRentIdForward);
            //        this.currRoomId = objSelectRoomForward.RoomId2.ToString();
            //        this.nmrRoomMoney.Value = (decimal)this.objFuncMoney.calRoomMoney(this.currRoomId, objSelectRoomForward.dtpTimeCheckIn1.Value, this.dtpTimeCheckOut.Value, this.txtNumMonth.Text, this.txtNumberPerson.Text, ref AdditionalMoney, this.currRoomRentId.ToString());
            //        this.nmrAdditionalMoney.Value = (decimal)AdditionalMoney;
            //        this.caculationTotalPayment();
            //        this.objRoom.updateRoomRentData(this.currRoomRentId.ToString(), this.currRoomId, objSelectRoomForward.dtpTimeCheckIn1.Value, this.dtpTimeCheckOut.Value);
            //        this.SaveBill(false);
            //        this.objRoom.setRoomRentCustomer(this.currRoomId, this.currPartnerId, this.currType);
            //        clsGeneral.setSystemLog("Chuyển phòng " + this.currRoomName + " - sang phòng " + objSelectRoomForward.RoomId2.ToString() + "(ID)", clsGeneral.fullName + " [" + clsGeneral.userName + "]");
            //        #endregion
            //    }

            //    //this.objDicRoomStatus = this.objRoom.getRoomStatus(this.cbbZone.SelectedValue.ToString());
            //    //this.objDicRoomIdState = this.objRoom.getRoomIdStatus(this.cbbZone.SelectedValue.ToString());
            //    //this.objDicRoomId = this.objRoom.getRoomId(this.cbbZone.SelectedValue.ToString());
            //    //this.updateMaps();
            //    this.LoadMap(true);
            //    this.resetButtomEnable();
            //}
            //this.resetInformation();
        }
        #endregion  

        #region method btnGroup_Click
        private void btnGroup_Click(object sender, EventArgs e)
        {
            //string sRoomName = TVSSYS.GlobalModule.objCon.Get_EXESelect("SELECT (SELECT RoomName FROM tblRoomRentGroup a WHERE a.RoomRentId=tblRoomRentGroup.RootRoomRentId) FROM tblRoomRentGroup WHERE (ISNULL(RootRoomRentId,0)<>ISNULL(RoomRentId,0)) AND RoomRentId=" + this.currRoomRentId.ToString());
            //if (sRoomName != "")
            //{
            //    MessageBox.Show("Phòng này đã được gộp sang phòng " + sRoomName.ToUpper(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //frmRoomRentGroup objRoomRentGroup = new frmRoomRentGroup();
            //objRoomRentGroup.RoomId = this.currRoomId;
            //objRoomRentGroup.btnRoomName.Text = " " + this.currRoomName;
            //objRoomRentGroup.RoomName = this.currRoomName;
            //objRoomRentGroup.RootRoomRentId = this.currRoomRentId.ToString();
            //objRoomRentGroup.ShowDialog();
        }
        #endregion

        #region method btnSelectCustomer_Click
        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            //frmRoomRentInfo.currEmpId = "";
            //frmRoomRentInfo objSelectPartner = new frmRoomRentInfo();

            //#region Thong tin ve tinh toan tien
            //objSelectPartner.nmrTotalPayment.Value = this.nmrTotalPayment.Value;
            //objSelectPartner.nmrRoomMoney.Value = this.nmrRoomMoney.Value;

            //objSelectPartner.nmrAdditionalMoney.Value = this.nmrAdditionalMoney.Value;
            //objSelectPartner.nmrServiceMoney.Value = this.nmrServiceMoney.Value;
            //objSelectPartner.nmrDiscountMoney.Value = this.nmrDiscountMoney.Value;
            //objSelectPartner.nmrVATLevel.Value = this.nmrVATLevel.Value;
            //objSelectPartner.nmrVatMoney.Value = this.nmrVatMoney.Value;
            //objSelectPartner.nmrTotalMoney.Value = this.nmrTotalMoney.Value;
            //objSelectPartner.nmrOtherMoney.Value = this.nmrOtherMoney.Value;
            //objSelectPartner.nmrForwardMoney.Value = this.nmrForwardMoney.Value;
            //objSelectPartner.nmrTotalPaymented.Value = this.nmrTotalPaymented.Value;
            //objSelectPartner.nmrTotalPayment.Value = this.nmrTotalPayment.Value;

            //objSelectPartner.currRoomRentId = this.currRoomRentId;
            //objSelectPartner.currRoomId = int.Parse(this.currRoomId);

            //#endregion

            //objSelectPartner.Text = "PHÒNG " + this.txtRoomName.Text.ToUpper() + " - THÔNG TIN KHÁCH HÀNG";
            //frmRoomRentInfo.currPartnerName = this.txtCustomerName.Text;
            //objSelectPartner.nmrNumberPerson.Value = decimal.Parse(this.txtNumberPerson.Text);
            //objSelectPartner.nmrNumMonth.Value = decimal.Parse(this.txtNumMonth.Text);
            //objSelectPartner.dtpTimeCheckIn.Value = this.dtpTimeCheckIn.Value;
            //objSelectPartner.dtpTimeCheckOut.Value = this.dtpTimeCheckOut.Value;
            //objSelectPartner.btnRoomName.Text = this.txtRoomName.Text.ToUpper() + " - " + this.txtCustomerName.Text.ToUpper();
            //objSelectPartner.dgvRoomEmty.AutoGenerateColumns = false;
            ////objSelectPartner.dgvRoomEmty.DataSource = this.dgvService.DataSource;
            //objSelectPartner.currRoomRentId = this.currRoomRentId;
            ////objSelectPartner.nmrDepositMoney.Value = this.nmrDepositMoney.Value;
            //objSelectPartner.nmrTotalDepositMoney.Value = this.nmrDepositMoney.Value;
            //objSelectPartner.currRoomName = this.currRoomName;
            //objSelectPartner.ShowDialog();
            //if (objSelectPartner.isSelectMode)
            //{
            //    this.currPartnerId = objSelectPartner.currPartnerId;
            //    this.currEmpId = int.Parse(objSelectPartner.cbbEmployess.SelectedValue.ToString());
            //    this.currTypeObject = objSelectPartner.cbbTypeObject.SelectedIndex;
            //    this.currEmpName = objSelectPartner.cbbEmployess.Text;
            //    this.txtEmployeeName.Text = objSelectPartner.cbbEmployess.Text;
            //    this.txtCustomerName.Text = objSelectPartner.txtName.Text;
            //    this.txtNumberPerson.Text = objSelectPartner.nmrNumberPerson.Value.ToString();
            //    this.txtNumMonth.Text = objSelectPartner.nmrNumMonth.Value.ToString();
            //    this.dtpTimeCheckIn.Value = objSelectPartner.dtpTimeCheckIn.Value;
            //    this.dtpTimeCheckOut.Value = objSelectPartner.dtpTimeCheckOut.Value;
            //    this.txtTimeCheckIn.Text = this.dtpTimeCheckIn.Value.ToString("HH:mm dd/MM/yyyy");// +"  -  " + this.dtpTimeCheckOut.Value.ToString("HH:mm dd/MM/yyyy");
            //    this.objRoom.setRoomRentData(this.currRoomId, 1, DateTime.Now, this.currType, int.Parse(this.txtNumberPerson.Text), frmMain.Username, ref this.currRoomRentId);
            //    //this.objDicRoomStatus = this.objRoom.getRoomStatus(this.cbbZone.SelectedValue.ToString());
            //    //this.objDicRoomIdState = this.objRoom.getRoomIdStatus(this.cbbZone.SelectedValue.ToString());
            //    //this.objDicRoomId = this.objRoom.getRoomId(this.cbbZone.SelectedValue.ToString());

            //    this.nmrRoomMoney.Value = (decimal)this.objFuncMoney.calRoomMoney(this.currRoomId, this.dtpTimeCheckIn.Value, this.dtpTimeCheckOut.Value, this.txtNumMonth.Text, this.txtNumberPerson.Text, ref AdditionalMoney, this.currRoomRentId.ToString());
            //    this.nmrAdditionalMoney.Value = (decimal)AdditionalMoney;
            //    this.caculationTotalPayment();
            //    this.objRoom.updateRoomRentData(this.currRoomRentId.ToString(), this.currRoomId, this.dtpTimeCheckIn.Value, this.dtpTimeCheckOut.Value);
            //    this.SaveBill(false);
            //    this.objRoom.setRoomRentCustomer(this.currRoomId, this.currPartnerId, this.currType);

            //    //int currId = objBill.getId(currRoomRentId.ToString());
            //    //tmpBillId = core.clsGetBillID.NextID("KD/" + this.dtpTimeCheckIn.Value.ToString("dd/MM/yyyy") + "-", "BillId", this.dtpTimeCheckIn.Value.ToString("dd"), this.dtpTimeCheckIn.Value.ToString("MM"), this.dtpTimeCheckIn.Value.ToString("yyyy"), "TblBill", "BillId LIKE N'%KD%' AND " +
            //    //                                                                "Convert(nvarchar,DateCreate,112)='" + this.dtpTimeCheckIn.Value.ToString("yyyyMMdd") + "'");

            //    //objBill.setData(currId.ToString(), tmpBillId, this.dtpTimeCheckIn.Value, this.nmrTotalPayment.Value.ToString(), frmMain.Username, "", this.currPartnerId.ToString(), 1, ref tmpBillId, tmpReExIDM, this.nmrTotalPayment.Value.ToString(), "0", "0", tmpBillId, 0, this.currRoomRentId.ToString());
                
            //    this.LoadMap(true);
            //}
            //else
            //{
            //    this.currPartnerId = 0;
            //}
        }
        #endregion

        #region method btnSelectService_Click
        private void btnSelectService_Click(object sender, EventArgs e)
        {
            //DataTable objTable = new DataTable();
            //frmSelectProducts objSelectProducts = new frmSelectProducts();
            //objSelectProducts.ShowDialog();

            //if (objSelectProducts.selectOK)
            //{
            //    objTable = (DataTable)objSelectProducts.dgvProducts.DataSource;
            //}
            //bool tmpForLog = false;
            //for (int i = 0; i < objTable.Rows.Count; i++)//TMP/Id/Name/Price1/Unit22
            //{
            //    if (objTable.Rows[i]["TMP"].ToString().ToUpper() == "TRUE")
            //    {
            //        this.objRoom.setRoomRentProductsData(this.currRoomRentId.ToString(), objTable.Rows[i]["Id"].ToString(), objTable.Rows[i]["Name"].ToString(), objTable.Rows[i]["Unit22"].ToString(), "1", objTable.Rows[i]["Price1"].ToString(), objTable.Rows[i]["Price1"].ToString(), objTable.Rows[i]["Unit2"].ToString());
            //        tmpForLog = true;
            //    }
            //}
            //if (tmpForLog)
            //{
            //    clsGeneral.setSystemLog("Gọi dịch vụ, hàng hóa " + this.currRoomName, clsGeneral.fullName + " [" + clsGeneral.userName + "]");
            //}
            //this.dgvService.AutoGenerateColumns = false;
            //this.dgvService.DataSource = this.objRoom.getRoomRentProductsData(this.currRoomRentId.ToString(), ref this.ServiceMoney);

            //this.ServiceMoney = 0;
            //for (int i = 0; i < this.dgvService.RowCount; i++)
            //{
            //    this.ServiceMoney += double.Parse(this.dgvService.Rows[i].Cells["dgvServiceMoney"].Value.ToString());
            //}

            //this.nmrServiceMoney.Value = (decimal)ServiceMoney;
            //this.caculationTotalPayment();
            //this.SaveBill(false);
        }
        #endregion

        #region method btnUse_Click
        private void btnUse_Click(object sender, EventArgs e)
        {
            //if (this.objRoom.checkRoomId(this.currRoomId))
            //{
            //    MessageBox.Show("Phòng được chọn đang có khách ở, xin hãy kiểm tra lại", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.LoadMap(true);
            //    this.resetInformation();
            //    this.resetButtomEnable();
            //    return;
            //}
            this.btnSelectCustomer.Enabled = true;
            this.btnSelectCustomer.PerformClick();
            if (this.currPartnerId == 0)
            {
                this.btnSelectCustomer.Enabled = false;
                return;
            }
            this.LoadMap(false);
        }
        #endregion

        #region method dgvService_CellEndEdit
        private void dgvService_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.nmrServiceMoney.Value = (decimal)this.updateService();
            }
            catch {
                MessageBox.Show("Kiểm tra giá trị nhập vào!");
                this.dgvService.AutoGenerateColumns = false;
                //this.dgvService.DataSource = this.objRoom.getRoomRentProductsData(this.currRoomRentId.ToString(), ref this.ServiceMoney);
            }
        }
        #endregion

        #region method dgvService_CellEnter
        private void dgvService_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvServiceCurrIndex = e.RowIndex;
        }
        #endregion

        #region method frmRoomMaps_KeyDown
        private void FrmRoomMap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion

        #region GetInfoPartner
        public void getInfoPartner(string sSearch)
        {
            string sQuery = String.Empty;
            double timCurrent = 0;
            double timStart = 0;
            double timFinish = 0;
            bool fTimeInDay = false;
            timCurrent = double.Parse(DateTime.Now.Hour.ToString()) + double.Parse(DateTime.Now.Minute.ToString()) / 60;


            string sTimeInDay = "SELECT TblTimeInDay.IDTimeInDay,TblTimeInDay.StartTime,TblTimeInDay.FinishTime,TblTimeInDay.IDPartnerRegis FROM TblTimeInDay " +
            Environment.NewLine + " LEFT JOIN TblPartnerRegis on TblPartnerRegis.IDPartnerRegis=TblTimeInDay.IDPartnerRegis " +
            Environment.NewLine + " LEFT JOIN TblPartner on TblPartner.IDPartner=TblPartnerRegis.IDPartner where CodePartner='" + sSearch + "'";
            objTabTimeInDay = objFunc.EXESelect(sTimeInDay);
            if (objTabTimeInDay.Rows.Count > 0)
            {
                for (int i = 0; i < objTabTimeInDay.Rows.Count; i++)
                {
                    timStart = double.Parse(objTabTimeInDay.Rows[i]["StartTime"].ToString().Substring(0, 2)) + double.Parse(objTabTimeInDay.Rows[i]["StartTime"].ToString().Substring(3, 2));
                    timFinish = double.Parse(objTabTimeInDay.Rows[i]["FinishTime"].ToString().Substring(0, 2)) + double.Parse(objTabTimeInDay.Rows[i]["FinishTime"].ToString().Substring(3, 2));
                    if (timStart <= timCurrent && timCurrent <= timFinish)
                    {
                        sQuery = "SELECT TblPartnerRegis.IDPartnerRegis,TblPartnerRegis.IDPartner,TblPartner.IDPartnerGroup,TblPartner.IDPartnerType," +
                         "TblPartnerRegis.IDPackGym,TblPackGym.NamePackGym,TblPartner.CodePartner,TblPartner.NamePartner,TblPartner.IDGender," +
                         "TblPartner.Birthday,TblPartner.Address,TblPartner.Phone,TblPartnerRegis.IDGymRoom,TblPartnerRegis.IDTypeGym," +
                         "TblPartnerRegis.IDWorkOut,TblPartnerRegis.Times,TblPartnerRegis.StartDate,TblPartnerRegis.EndDate,TblPartnerRegis.Active," +
                         "TblPartnerRegis.ReExIDM,TblPartnerRegis.OriginalBill,TblPartnerRegis.Note,TblPartnerRegis.Freeze FROM TblPartnerRegis  " +
                         "LEFT JOIN TblPartner ON TblPartner.IDPartner=TblPartnerRegis.IDPartner " +
                         "LEFT JOIN TblPackGym ON TblPackGym.IDPackGym=TblPartnerRegis.IDPackGym " +
                         "WHERE TblPartner.CodePartner='" + sSearch + "' AND TblPartnerRegis.Active='True'";
                        objTab = objFunc.EXESelect(sQuery);
                        fTimeInDay = true;
                    }
                }
            }
            else
            {
                sQuery = "SELECT TblPartnerRegis.IDPartnerRegis,TblPartnerRegis.IDPartner,TblPartner.IDPartnerGroup,TblPartner.IDPartnerType," +
                 "TblPartnerRegis.IDPackGym,TblPackGym.NamePackGym,TblPartner.CodePartner,TblPartner.NamePartner,TblPartner.IDGender," +
                 "TblPartner.Birthday,TblPartner.Address,TblPartner.Phone,TblPartnerRegis.IDGymRoom,TblPartnerRegis.IDTypeGym," +
                 "TblPartnerRegis.IDWorkOut,TblPartnerRegis.Times,TblPartnerRegis.StartDate,TblPartnerRegis.EndDate,TblPartnerRegis.Active," +
                 "TblPartnerRegis.ReExIDM,TblPartnerRegis.OriginalBill,TblPartnerRegis.Note,TblPartnerRegis.Freeze FROM TblPartnerRegis  " +
                 "LEFT JOIN TblPartner ON TblPartner.IDPartner=TblPartnerRegis.IDPartner " +
                 "LEFT JOIN TblPackGym ON TblPackGym.IDPackGym=TblPartnerRegis.IDPackGym " +
                 "WHERE TblPartner.CodePartner='" + sSearch + "' AND TblPartnerRegis.Active='True'";
                objTab = objFunc.EXESelect(sQuery);
                fTimeInDay = true;
            }
            if (fTimeInDay == false)
            {
                MessageBox.Show("Thẻ đã được giới hạn thời gian vào");
                return;
            }


            if (objTab.Rows.Count > 0)
            {
                if (objTab.Rows.Count > 1)
                {
                    Forms.FrmChoosePack frm = new FrmChoosePack();
                    frm.objData = objTab;
                    frm.ShowDialog();
                    if (frm.fCheck)
                    {
                        sID = frm.sIDPartner;
                        sIDRegis = frm.sIDPartnerRegis;
                        sIDPartnerGroup = frm.sIDPartnerGroup;
                        sIDPartnerType = frm.sIDPartnerType;
                        sCodePartner = frm.sCodePartner;
                        sNamePartner = frm.sNamePartner;
                        sIDGender = frm.sIDGender;
                        sBirthday = frm.sBirthday;
                        sPhone = frm.sPhone;
                        sAddress = frm.sAddress;
                        sIDGymRoom = frm.sIDGymRoom;
                        sIDTypeGym = frm.sIDTypeGym;
                        sIDPackGym = frm.sIDPackGym;
                    }
                    else sExpired = true;
                }
                else
                {
                    sID = objTab.Rows[0]["IDPartner"].ToString();
                    sIDRegis = objTab.Rows[0]["IDPartnerRegis"].ToString();
                    sIDPartnerGroup = objTab.Rows[0]["IDPartnerGroup"].ToString();
                    sIDPartnerType = objTab.Rows[0]["IDPartnerType"].ToString();
                    sCodePartner = objTab.Rows[0]["CodePartner"].ToString();
                    sNamePartner = objTab.Rows[0]["NamePartner"].ToString();
                    sIDGender = objTab.Rows[0]["IDGender"].ToString();
                    sBirthday = objTab.Rows[0]["Birthday"].ToString();
                    sPhone = objTab.Rows[0]["Phone"].ToString();
                    sAddress = objTab.Rows[0]["Address"].ToString();
                    sIDTypeGym = objTab.Rows[0]["IDTypeGym"].ToString();
                    sIDPackGym = objTab.Rows[0]["IDPackGym"].ToString();
                }
                if (objTab.Rows.Count > 0)
                {
                    sFreeze = Convert.ToBoolean(objFunc.Get_EXESelect("SELECT Freeze FROM TblPartnerRegis WHERE IDPartnerRegis='" + sIDRegis + "'"));
                    if (sFreeze == false)
                    {
                        sStartDate = objFunc.Get_EXESelect("SELECT Convert(nvarchar,StartDate,112) FROM TblPartnerRegis WHERE IDPartnerRegis='" + sIDRegis + "'");
                        if (Convert.ToInt32(sStartDate) > Convert.ToInt32(dateInOut.Value.ToString("yyyyMMdd")))//kiểm tra ngày bắt đầu
                        {
                            Classes.clsMessage.Warning("Thẻ này chưa đến ngày sử dụng. Xin vui lòng kiểm tra lại ngày sử dụng!");
                        }
                        else
                        {
                            if (sIDTypeGym == "1")//Nếu tập theo số lần
                            {

                                sTotal = objFunc.Get_EXESelectInt("SELECT ISNULL(sum(Times),0) FROM TblPartnerRegis WHERE IDPartnerRegis='" + sIDRegis + "'") - objFunc.Get_EXESelectInt("SELECT isnull(sum([Count]),0) FROM tblWorkoutHistory WHERE IDPartnerRegis='" + sIDRegis + "'");
                                if (sTotal <= 0)
                                {

                                    objFunc.EXEUpdate("UPDATE TblPartnerRegis SET Active='False' WHERE IDPartnerRegis='" + sIDRegis + "'");
                                    Classes.clsMessage.Warning("Thẻ này đã hết hạn!. Xin vui lòng gia hạn để tiếp tục sử dụng thẻ");
                                    sExpired = true;
                                }
                            }
                            else if (sIDTypeGym == "2")//Nếu tập theo thời gian
                            {
                                sEndDate = objFunc.Get_EXESelect("SELECT Convert(nvarchar,EndDate,112) FROM TblPartnerRegis WHERE IDPartnerRegis='" + sIDRegis + "'");
                                if (Convert.ToInt32(sEndDate) < Convert.ToInt32(dateInOut.Value.ToString("yyyyMMdd")))
                                {
                                    objFunc.EXEUpdate("UPDATE TblPartnerRegis SET Active='False' WHERE IDPartnerRegis='" + sIDRegis + "'");
                                    sExpired = true;
                                    Classes.clsMessage.Warning("Thẻ này đã hết hạn!. Xin vui lòng gia hạn để tiếp tục sử dụng thẻ");
                                }
                            }
                            if (!sExpired)
                            {
                                if (objMember.UpdateHistory(Convert.ToInt32(sID),
                                                    Convert.ToInt32(sIDRegis),
                                                    Convert.ToInt32(sIDPartnerGroup),
                                                    Convert.ToInt32(sIDPartnerType),
                                                    sCodePartner,
                                                    sNamePartner,
                                                    Convert.ToInt32(sIDGender),
                                                    Convert.ToDateTime(sBirthday),
                                                    sPhone,
                                                    sAddress,
                                                    1,
                                                    Convert.ToInt32(sIDGymRoom),
                                                    Convert.ToInt32(sIDPackGym),
                                                    Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")),
                                                    DateTime.Now))
                                {
                                    //objRoom.UpdateStatusBed(
                                }

                                //LoadForm();
                            }
                        }
                    }
                    else Classes.clsMessage.Error("Mã khách hàng đang bị đóng băng. Vui lòng kiểm tra lại");
                }
            }
            else
            {
                Classes.clsMessage.Error("Mã khách hàng không tồn tại hoặc chưa được kích hoạt. Vui lòng kiểm tra lại");
            }
            sExpired = false;
            sSearch = "";
        }
        #endregion

        #region method mnuCheckIn_Click
        private void mnuCheckIn_Click(object sender, EventArgs e)
        {
            Forms.FrmChoosePartner frm = new FrmChoosePartner();
            frm.ShowDialog();
            if (frm.fAction == true)
            {
                txtCodePartner.Text = frm.sCodePartner;
                txtCustomerName.Text = frm.sPartner;
                getInfoPartner(txtCodePartner.Text);

                txtCodePartner.Focus();

            }

           
        }
        #endregion

        #region method mnuCheckOut_Click
        private void mnuCheckOut_Click(object sender, EventArgs e)
        {
            this.btnCheckOut.PerformClick();
        }
        #endregion

        #region method mnuClear_Click
        private void mnuClear_Click(object sender, EventArgs e)
        {
            this.btnClear.PerformClick();
        }
        #endregion

        #region method mnuCustomer_Click
        private void mnuCustomer_Click(object sender, EventArgs e)
        {
            this.btnSelectCustomer.PerformClick();
        }
        #endregion

        #region method mnuDel_Click
        private void mnuDel_Click(object sender, EventArgs e)
        {
            this.btnDel.PerformClick();
        }
        #endregion

        #region method mnuForward_Click
        private void mnuForward_Click(object sender, EventArgs e)
        {
            this.btnForward.PerformClick();
            LoadMap(false);
        }
        #endregion

        #region method mnuGroup_Click
        private void mnuGroup_Click(object sender, EventArgs e)
        {
            this.btnGroup.PerformClick();
            LoadMap(false);
        }
        #endregion

        #region method mnuPrice_Click
        private void mnuPrice_Click(object sender, EventArgs e)
        {
            //frmRoomPriceOne objRoomPriceOne = new frmRoomPriceOne();
            //objRoomPriceOne.RoomId = this.currRoomId;
            //objRoomPriceOne.lblRoomName.Text = this.currRoomName.ToUpper();
            //objRoomPriceOne.ShowDialog();
        }
        #endregion

        #region method mnuService_Click
        private void mnuService_Click(object sender, EventArgs e)
        {
            this.btnSelectService.PerformClick();
        }
        #endregion

        #region method nmrAdditionalMoney_ValueChanged
        private void nmrAdditionalMoney_ValueChanged(object sender, EventArgs e)
        {
            this.TienVAT();
        }
        #endregion

        #region method nmrDepositMoney_KeyDown
        private void nmrDepositMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.caculationTotalPayment();
                this.SaveBill(false);
            }
        }
        #endregion

        #region method nmrDiscountMoney_KeyDown
        private void nmrDiscountMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.caculationTotalPayment();
                this.SaveBill(false);
            }
        }
        #endregion

        #region method nmrRoomMoney_ValueChanged
        private void nmrDiscountMoney_ValueChanged(object sender, EventArgs e)
        {
            //this.caculationTotalPayment(this.nmrDiscountMoney);
            this.TienVAT();
        }
        #endregion

        #region method nmrOtherMoney_KeyDown
        private void nmrOtherMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.caculationTotalPayment();
                this.SaveBill(false);
            }
        }
        #endregion

        #region method nmrRoomMoney_ValueChanged
        private void nmrRoomMoney_ValueChanged(object sender, EventArgs e)
        {
            this.TienVAT();
        }
        #endregion

        #region method nmrRoomMoney_ValueChanged
        private void nmrServiceMoney_ValueChanged(object sender, EventArgs e)
        {
            this.TienVAT();
        }
        #endregion

        #region method nmrVATLevel_KeyDown
        private void nmrVATLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.caculationTotalPayment();
                this.SaveBill(false);
            }
        }
        #endregion

        #region method nmrVATLevel_ValueChanged
        private void nmrVATLevel_ValueChanged(object sender, EventArgs e)
        {
            this.TienVAT();
        }
        #endregion

        #region method mnuTmpBill_Click
        private void mnuTmpBill_Click(object sender, EventArgs e)
        {
            //Reports.frmReportViewer objRepView = new Reports.frmReportViewer();
            //objRepView.sRoomRentId = this.currRoomRentId;
            //objRepView.srptTitle = "IN PHIẾU THANH TOÁN";
            //objRepView.srptType = "frmRepPaymentBill";
            //objRepView.ShowDialog();
        }
        #endregion

        #region method mnuRoomPriceUpdateAgain_Click
        private void mnuRoomPriceUpdateAgain_Click(object sender, EventArgs e)
        {
            //frmRoomPriceUpdateAgain objRoomPriceOne = new frmRoomPriceUpdateAgain();
            //objRoomPriceOne.RoomRentId = this.currRoomRentId.ToString();
            //objRoomPriceOne.lblRoomName.Text = this.currRoomName.ToUpper();
            //objRoomPriceOne.ShowDialog();
        }
        #endregion

        #region mothod gridProducts_DoubleClick
        private void gridProducts_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            //    if (currRoomRentId != 0)
            //    {
            //        this.objRoom.setRoomRentProductsData(this.currRoomRentId.ToString()
            //            , this.gridProducts.CurrentRow.Cells["colId"].Value.ToString()
            //            , this.gridProducts.CurrentRow.Cells["colNameProduct"].Value.ToString()
            //            , this.gridProducts.CurrentRow.Cells["colNameUnit"].Value.ToString()
            //            , "1"
            //            , this.gridProducts.CurrentRow.Cells["colPrice1"].Value.ToString()
            //            , this.gridProducts.CurrentRow.Cells["colPrice1"].Value.ToString()
            //            , this.gridProducts.CurrentRow.Cells["colUnit2"].Value.ToString());

            //        if (String.IsNullOrEmpty(tmpBillId))
            //        {
            //            tmpBillId = clsGetBillID.NextID("KD/" + this.dtpTimeCheckIn.Value.ToString("dd/MM/yyyy") + "-", "BillId", this.dtpTimeCheckIn.Value.ToString("dd"), this.dtpTimeCheckIn.Value.ToString("MM"), this.dtpTimeCheckIn.Value.ToString("yyyy"), "TblBill", "BillId LIKE N'%KD%' AND " +
            //                                                                        "Convert(nvarchar,DateCreate,112)='" + this.dtpTimeCheckIn.Value.ToString("yyyyMMdd") + "'");
            //            objBill.setData("0", tmpBillId, this.dtpTimeCheckIn.Value, this.nmrTotalPayment.Value.ToString(), frmMain.Username, "", this.currPartnerId.ToString(), 1, ref tmpBillId, tmpReExIDM, this.nmrTotalPayment.Value.ToString(), "0", "0", tmpBillId, 0, this.currRoomRentId.ToString());
            //        }
            //        this.objBill.setBillDetailProduct(tmpBillId
            //            , this.gridProducts.CurrentRow.Cells["colId"].Value.ToString()
            //            , this.gridProducts.CurrentRow.Cells["colNameProduct"].Value.ToString()
            //            , this.gridProducts.CurrentRow.Cells["colUnit2"].Value.ToString()
            //            , "1"
            //            , this.gridProducts.CurrentRow.Cells["colPrice1"].Value.ToString());
            //        //string tmpBillId = "";
            //        //string tmpReExIDM = "";
            //        //tmpBillId = core.clsGetBillID.NextID("KD/" + DateTime.Now.ToString("dd/MM/yyyy") + "-", "BillId", DateTime.Now.ToString("dd"), DateTime.Now.ToString("MM"), DateTime.Now.ToString("yyyy"), "TblBill", "BillId LIKE N'%KD%' AND " +
            //        //                                                                "Convert(nvarchar,DateCreate,112)='" + DateTime.Now.ToString("yyyyMMdd") + "'");
            //        //tmpReExIDM = core.clsGetBillID.NextID("PT/" + DateTime.Now.ToString("dd/MM/yyyy") + "-", "ReExIDM", DateTime.Now.ToString("dd"), DateTime.Now.ToString("MM"), DateTime.Now.ToString("yyyy"), "TblBill", "ReExIDM LIKE N'%PT%' AND " +
            //        //                                                                "Convert(nvarchar,DateCreate,112)='" + DateTime.Now.ToString("yyyyMMdd") + "'");
            //        //objBill.setData(currId.ToString(), tmpBillId, dtpDayBill.Value, this.nmrTotalPayment.Value.ToString(), frmMain.Username, this.txtNote.Text, this.currPartnerId.ToString(), 1, ref tmpBillId, tmpReExIDM, this.nmrTotalPayment.Value.ToString(), "0", this.txtMoney.Text, tmpBillId, 0);

            //        this.dgvService.AutoGenerateColumns = false;
            //        this.dgvService.DataSource = this.objRoom.getRoomRentProductsData(this.currRoomRentId.ToString(), ref this.ServiceMoney);
            //        this.nmrServiceMoney.Value = (decimal)this.ServiceMoney;
            //    }
            //    else {
            //        MessageBox.Show(" Bạn chưa mở phòng","TVS - Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //}
            //catch { }
            //this.dgvService.AutoGenerateColumns = false;
            //this.dgvService.DataSource = this.objRoom.getRoomRentProductsData(this.currRoomRentId.ToString(), ref this.ServiceMoney);
        }
        #endregion

        #region btnDelProducts_Click
        private void btnDelProducts_Click(object sender, EventArgs e)
        {
            //if (dgvService.RowCount > 0)
            //{
            //    this.objBill.removeProduct(tmpBillId, this.dgvService.CurrentRow.Cells["dgvServiceId"].Value.ToString());
            //    this.objRoom.removeRoomRentProductItem(this.dgvService.CurrentRow.Cells["dgvServiceId"].Value.ToString(), this.currRoomRentId.ToString());
            //    this.dgvService.AutoGenerateColumns = false;
            //    this.dgvService.DataSource = this.objRoom.getRoomRentProductsData(this.currRoomRentId.ToString(), ref this.ServiceMoney);
            //}
            //else
            //{
            //    MessageBox.Show("TVS - Không tồn tại hàng hóa dịch vụ để xóa!");
            //}
        }
        #endregion
    }

}
