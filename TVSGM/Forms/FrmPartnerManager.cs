using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using TVSTimeKeeper;
using zkemkeeper;
using System.Threading;


namespace TVSGM.Forms
{
    public partial class FrmPartnerManager : Form
    {
        public string sTableName, sIDPartner, sFromWorkOut = "", sToWorkOut = "", sIDPartnerRegis;
        public static string sText = String.Empty, sIDValue;
        public static bool fUpdate = false, fConnect = false;
        public string sSQL, sAddressIP, sUsing;
        public int sPort;
        private DataTable objData, objWorkOut;
        DataTable objTabTime = new DataTable();
        DataTable objTab = new DataTable();
        DataTable objTabTimeInDay = new DataTable();
        TVSSys.Connection objFunc = new TVSSys.Connection();
        Classes.clsUpdProducts objMember = new TVSGM.Classes.clsUpdProducts();
        Classes.clsImage objI = new Classes.clsImage();
        TVSTimeKeeper.clsCzkem objTimeKeeper = new clsCzkem();
        zkemkeeper.CZKEM axCZKEM1 = new CZKEM();

        public FrmPartnerManager()
        {
            InitializeComponent();

            sAddressIP = TVSSys.GlobalModule.objXML.GetKey("AddressIP");
            sPort = int.Parse(TVSSys.GlobalModule.objXML.GetKey("Port"));
            sUsing = TVSSys.GlobalModule.objXML.GetKey("Using");
        }

        #region ModeButton
        private void ModeButton(string sOption)
        {
            //try
            //{
            //    switch (sOption)
            //    {
            //        case "Load":
            //            {
            //                this.gridviewDir.AllowUserToAddRows = false;
            //                this.btnUpdate.Enabled = true;
            //                this.btnDelete.Enabled = true;
            //                this.btnSave.Enabled = false;
            //                this.btnCancel.Enabled = false;
            //                break;
            //            }
            //        case "Update":
            //            {
            //                this.gridviewDir.ReadOnly = false;
            //                this.gridviewDir.AllowUserToAddRows = true;
            //                this.btnUpdate.Enabled = false;
            //                this.btnDelete.Enabled = false;
            //                this.btnSave.Enabled = true;
            //                this.btnCancel.Enabled = true;
            //                break;
            //            }
            //    }
            //}
            //catch { }
        }
        #endregion

        #region LoadForm
        private void LoadForm()
        {
            string sQuery = "SELECT tblWorkoutHistory.IDWorkoutHistory,TblPartnerRegis.IDPartnerRegis,TblPartner.IDPartner,TblPartnerGroup.IDPartnerGroup,TblPartnerGroup.NamePartnerGroup,TblPartnerType.IDPartnerType," +
                            "TblPartnerType.NamePartnerType,TblPartner.CodePartner,TblPartner.NamePartner,TblGender.IDGender,TblGender.NameGender,TblPartner.BirthDay,TblPartner.Phone," +
                            "TblPartner.Address,TblGymRoom.IDGymRoom,tblWorkoutHistory.IDPackGym,TblPackGym.NamePackGym,TblGymRoom.NameGymRoom,TblWorkOut.IDWorkOut," +
                            "tblWorkoutHistory.[Count],tblWorkoutHistory.DateIn,tblWorkoutHistory.DateSearch " +
                            "FROM tblWorkoutHistory " +
                            "LEFT JOIN TblPartner ON TblPartner.IDPartner=tblWorkoutHistory.IDPartner " +
                            "LEFT JOIN TblPartnerGroup ON TblPartnerGroup.IDPartnerGroup=tblWorkoutHistory.IDPartnerGroup " +
                            "LEFT JOIN TblPartnerType ON TblPartnerType.IDPartnerType=tblWorkoutHistory.IDPartnerType " +
                            "LEFT JOIN TblGender ON TblGender.IDGender=tblWorkoutHistory.IDGender " +
                            "LEFT JOIN TblGymRoom ON TblGymRoom.IDGymRoom=tblWorkoutHistory.IDGymRoom " +
                            "LEFT JOIN TblWorkOut ON TblWorkOut.IDWorkOut=tblWorkoutHistory.IDWorkOut " +
                            "LEFT JOIN TblPackGym ON TblPackGym.IDPackGym=tblWorkoutHistory.IDPackGym  " +
                            "LEFT JOIN TblPartnerRegis ON TblPartnerRegis.IDPartnerRegis=tblWorkoutHistory.IDPartnerRegis " +
                            "WHERE Convert(nvarchar,tblWorkoutHistory.DateSearch,103)='" + DateTime.Now.ToString("dd/MM/yyyy") + "' ";
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                sQuery += " AND (TblPartner.NamePartner LIKE '%" + txtSearch.Text + "%' OR TblPartner.NameSearch LIKE '%" + txtSearch.Text + "%')";
            sQuery += " ORDER BY tblWorkoutHistory.IDWorkoutHistory DESC";
            objData = objFunc.EXESelect(sQuery);
            gridviewMembers.Tag = objData;
            this.gridviewMembers.AutoGenerateColumns = false;
            gridviewMembers.DataSource = objData;
            gridviewMembers.Refresh();
            if (gridviewMembers.RowCount > 0)
                gridviewMembers_CellClick(gridviewMembers, new DataGridViewCellEventArgs(0, 1));

        }

        private void FrmManagerInOut_Load(object sender, EventArgs e)
        {
            ModeButton("Load");
            LoadForm();

            txtSCodePartner.Focus();
        }
        #endregion

        #region Close
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Hotkey
        private void FrmManagerInOut_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F4) btnAdd.PerformClick();
            ////else if (e.KeyCode == Keys.F2) btnChoose.PerformClick();
            //else if (e.KeyCode == Keys.F5) btnUpdate.PerformClick();
            //else if (e.KeyCode == Keys.F6) btnSave.PerformClick();
            ////else if (e.KeyCode == Keys.F7) btnPrint.PerformClick();
            //else if (e.KeyCode == Keys.F8) btnDelete.PerformClick();
            //else if (e.KeyCode == Keys.Escape)
            //{
            //    if (btnSave.Enabled == true) btnCancel.PerformClick();
            //    else btnExit.PerformClick();
            //}

        }
        #endregion

        #region txtSBarCode_KeyDown
        int sTotal;
        string sEndDate, sStartDate;
        bool sCheck = false, sExpired, sFreeze;
        string sID, sIDRegis, sIDPartnerGroup, sIDPartnerType, sCodePartner, sNamePartner, sIDGender, sBirthday, sPhone, sAddress, sIDGymRoom, sIDPackGym, sIDTypeGym;

        #region GetInfoPartner
        public void getInfoPartner(string sSearch)
        {
            try
            {
                string sQuery = String.Empty;
                string IdPartner = FrmChoosePartner.IdPartner;
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
                             "WHERE TblPartner.CodePartner='" + sSearch + "' AND CONVERT(NVARCHAR,TblPartnerRegis.EndDate,112) >= '" + DateTime.Now.ToString("yyyyMMdd") + "' AND TblPartnerRegis.Active='True'";
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
                     "WHERE TblPartner.CodePartner='" + sSearch + "' AND CONVERT(NVARCHAR,TblPartnerRegis.EndDate,112) >= '" + DateTime.Now.ToString("yyyyMMdd") + "' AND TblPartnerRegis.Active='True'";
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
                                    objMember.UpdateHistory(Convert.ToInt32(sID),
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
                                                        DateTime.Now);

                                }
                            }
                        }
                        else
                        {
                            Classes.clsMessage.Error("Mã khách hàng đang bị đóng băng. Vui lòng kiểm tra lại");
                            return;
                        }
                    }
                }
                else
                {
                    Classes.clsMessage.Error("Mã khách hàng không tồn tại, quá hạn hoặc chưa được kích hoạt. Vui lòng kiểm tra lại");
                    return;
                }
            }
            catch
            {
                Classes.clsMessage.Error("Mã khách hàng không tồn tại, quá hạn hoặc chưa được kích hoạt. Vui lòng kiểm tra lại");
                sExpired = false;
                sSearch = "";
                return;
            }

            sExpired = false;
            sSearch = "";
        }
        #endregion

        private void txtSBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getInfoPartner(txtSCodePartner.Text);
                LoadForm();
                txtSCodePartner.Text = "";
            }
        }
        #endregion


        #region txtSearchName_KeyDown
        private void txtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            Forms.FrmChoosePartner frm = new FrmChoosePartner();
            frm.ShowDialog();
            txtSCodePartner.Text = frm.sCodePartner;
            txtSearchName.Text = frm.sPartner;
            txtSCodePartner.Focus();
        }
        #endregion

        #region txtSearch_TextChanged
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //LoadForm();
            System.Data.DataTable tbl = (System.Data.DataTable)gridviewMembers.DataSource; // = objData;
            tbl.DefaultView.RowFilter = "NamePartner LIKE '%" + txtSearch.Text + "%'";
            gridviewMembers.DataSource = tbl;
            //    Classes.clsGridViewInterface.SetMEMBER(gridviewMembers);
            if (gridviewMembers.RowCount == 1)
            {
                gridviewMembers_CellClick(gridviewMembers, new DataGridViewCellEventArgs(0, 1));
            }
            else
            {
                gridviewMembers.ClearSelection();
            }
        }
        #endregion

        #region btnRegis_Click
        private void btnRegis_Click(object sender, EventArgs e)
        {
            FrmUpdPartnerRegis frm = new FrmUpdPartnerRegis();
            frm.sIDPartnerRegis = "0";
            frm.sIDPartner = sIDPartner;
            frm.sNamePartner = txtNamePartner.Text;
            frm.sCodePartner = txtCodePartner.Text;
            frm.fUpdate = false;
            frm.ShowDialog();
        }
        #endregion

        #region btnDel_Click
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (Classes.clsMessage.Question("Bạn có muốn xóa thông tin không?") == DialogResult.Yes)
            {
                Classes.clsQueryDelete.EXEDelete("WorkoutHistory", "IDWorkoutHistory", gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["IDWorkoutHistory"].Value.ToString());
                LoadForm();
            }
        }
        #endregion

        #region method axCZKEM1_OnAttTransactionEx

        private void axCZKEM1_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode)
        {
            // string inputDate = new DateTime(iYear, iMonth, iDay, iHour, iMinute, iSecond).ToString();
            // getInfoPartner(sEnrollNumber);
            //  string inputDate = new DateTime(iYear, iMonth, iDay, iHour, iMinute, iSecond).ToString();
            DataTable tblCheck = (DataTable)gridviewMembers.Tag;
            DateTime d1 = new DateTime(iYear, iMonth, iDay, iHour, iMinute, 0);
            DateTime d2 = d1.AddMinutes(1);

            string myfilter = "CodePartner='" + sEnrollNumber + "' AND ( DateIn < #" + d2.ToString("yyyy/MM/dd hh:mm:ss tt") + "# AND DateIn >=#" + d1.ToString("yyyy/MM/dd hh:mm:ss tt") + "#)";
            DataRow[] dr = tblCheck.Select(myfilter);
            if (dr.Length == 0)
            {
                getInfoPartner(sEnrollNumber);
            }
            LoadForm();

            txtSCodePartner.Focus();
            Thread.Sleep(1000);
        }
        #endregion

        private void FrmPartnerManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.IsRegistEvent = 0;
            axCZKEM1.Disconnect();
            //axCZKEM1.OnAttTransactionEx -= new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(axCZKEM1_OnAttTransactionEx);
        }
        #region Máy chấm vân tay
        private void FrmPartnerManager_Shown(object sender, EventArgs e)
        {
            //if (FrmMain.IsRegistEvent == 0)
            //{

            //    fConnect = axCZKEM1.Connect_Net(FrmMain.sAddressIP, FrmMain.sPort);
            //    if (fConnect == true)
            //    {
            //        if (axCZKEM1.RegEvent(1, 65535))
            //        {
            //            axCZKEM1.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(axCZKEM1_OnAttTransactionEx);
            //        }
            //        //axCZKEM1.RegEvent(1, 65535);
            //        FrmMain.IsRegistEvent = 1;
            //    }
            //}
        }
        #endregion


        private void gridviewMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridviewMembers.CurrentRow == null) return;

            sIDPartner = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["IDPartner"].Value.ToString();
            sIDPartnerRegis = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["IDPartnerRegis"].Value.ToString();
            txtAddress.Text = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["Address"].Value.ToString();
            txtCodePartner.Text = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["CodePartner"].Value.ToString();
            txtNamePartner.Text = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["NamePartner"].Value.ToString();
            txtPackGym.Text = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["NamePackGym"].Value.ToString();
            txtPhone.Text = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["Phone"].Value.ToString();
            txtRoomGym.Text = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["NameGymRoom"].Value.ToString();
            dateBirthday.Text = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["Birthday"].Value.ToString();

            pictureBox1.Image = null;
            string imgStr = TVSSys.GlobalModule.objCon.Get_EXESelect("SELECT [Image] FROM tblPartner WHERE IDPartner=" + sIDPartner);
            if (!string.IsNullOrEmpty(imgStr))
                pictureBox1.Image = objI.GetImageFromByteArray(imgStr);

            if (objTab.Rows.Count >= 0)
            {
                if (objFunc.Get_EXESelect("SELECT IDTypeGym FROM TblPartnerRegis WHERE IDPartnerRegis=" + sIDPartnerRegis) == "1")//Nếu tập theo số lần
                {

                    lblDateEnd.Visible = dateEndUse.Visible = false;
                    lblCount.Visible = txtCount.Visible = true;
                    sTotal = objFunc.Get_EXESelectInt("SELECT ISNULL(sum(Times),0) FROM TblPartnerRegis WHERE IDPartnerRegis='" + sIDPartnerRegis + "'") - objFunc.Get_EXESelectInt("SELECT isnull(sum([Count]),0) FROM tblWorkoutHistory WHERE IDPartnerRegis='" + sIDPartnerRegis + "'");
                    txtCount.Text = sTotal.ToString();
                }
                else if (objFunc.Get_EXESelect("SELECT IDTypeGym FROM TblPartnerRegis WHERE IDPartnerRegis=" + sIDPartnerRegis) == "2")//Nếu tập theo thời gian
                {
                    lblDateEnd.Visible = dateEndUse.Visible = true;
                    lblCount.Visible = txtCount.Visible = false;
                    sEndDate = objFunc.Get_EXESelect("SELECT Convert(nvarchar,EndDate,103) FROM TblPartnerRegis WHERE IDPartnerRegis='" + sIDPartnerRegis + "' ");
                    dateEndUse.Value = Convert.ToDateTime(sEndDate);
                }
            }
            Count.Text = "Hiện có: " + objData.Rows.Count.ToString() + " thành viên đang tập";
        }
    }
}
