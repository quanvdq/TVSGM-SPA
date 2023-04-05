using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using Office_11 = Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
//using System.Data.OleDb;
using System.Threading;


namespace TVSGM.Forms
{
    public partial class FrmPartnerInfo : Form
    {
        public string sTableName, sReExIDM = String.Empty, sIDTypeGym;
        public static string sText = String.Empty, sIDValue, sIDPartnerRegis, sIdTimeInDay;
        public static bool fUpdate = false;
        public string sSQL;
        private System.Data.DataTable objData, objRegis, objTimeInDay;
        //TVSConnect.clsCONNECT objFunc = new TVSConnect.clsCONNECT();
        TVSSys.Connection objFunc = new TVSSys.Connection();
        Classes.clsInOutBill objInOut = new TVSGM.Classes.clsInOutBill();
        Classes.clsUpdProducts objMember = new TVSGM.Classes.clsUpdProducts();
        TVSSys.clsPublic obj = new TVSSys.clsPublic();
        Classes.clsImage objI = new Classes.clsImage();
        private bool IsAdd = false;
        public enum NhomKhachHang
        {
            KHBanBuon = 1,
            KHBanLe = 2,
            NhaCC = 3,
            KHvaNhaCC = 4
        }

        public FrmPartnerInfo()
        {
            InitializeComponent();
        }

        #region ModeButton
        private void ModeButton(string sOption)
        {
            try
            {
                switch (sOption)
                {
                    case "Load":
                        {
                            this.btnAdd.Enabled = true;
                            this.btnCancel.Enabled = false;
                            this.btnDelete.Enabled = true;
                            this.btnExit.Enabled = true;
                            this.btnRegis.Enabled = true;
                            this.btnSave.Enabled = false;
                            //this.btnUpdate.Enabled = true;
                            this.btnUpImage.Enabled = true;
                            IsAdd = false;
                            gridviewMembers.Enabled = true;
                            break;
                        }
                    case "Update":
                        {
                            this.btnAdd.Enabled = false;
                            this.btnCancel.Enabled = true;
                            this.btnDelete.Enabled = false;
                            this.btnExit.Enabled = false;
                            this.btnRegis.Enabled = false;
                            this.btnSave.Enabled = true;
                            this.btnUpdate.Enabled = false;
                            this.btnUpImage.Enabled = true;
                            gridviewMembers.Enabled = false;
                            break;
                        }
                }
            }
            catch { }
        }
        #endregion

        #region LoadForm
        private void LoadForm()
        {
            string sSqlHide = "AND TblPartner.Hide = 0";
            if (chkAll.Checked == true)
                sSqlHide = "";
            string sQuery = "SELECT 0 AS TT, TblPartner.IDPartner,TblPartner.IDPartnerGroup,TblPartnerGroup.NamePartnerGroup,TblPartner.IDPartnerType,TblPartner.CodePartner," +
                            "TblPartner.NamePartner,TblPartner.IDGender,TblGender.NameGender,TblPartner.Birthday,TblPartner.Phone,TblPartner.Address,TblPartner.Mobile," +
                            "TblPartner.Fax,TblPartner.CodeTax,TblPartner.Email,TblPartner.FirstBalancer,TblPartner.NameSearch,TblPartner.Note,TblPartner.[Active], TblPartner.[Hide], TblPartner.IDEmp, " +
                            "TblPartner.SoCMND,TblPartner.TenNguoiNha,TblPartner.SDTNguoiNha " +
                            "FROM TblPartner " +
                            "LEFT JOIN TblPartnerGroup ON TblPartnerGroup.IDPartnerGroup=TblPartner.IDPartnerGroup " +
                            "LEFT JOIN TblGender ON TblGender.IDGender=TblPartner.IDGender " +
                            "WHERE TblPartner.IDPartnerType != "+ (int)FrmPartnerInfo.NhomKhachHang.NhaCC +" " + sSqlHide;
            if (!string.IsNullOrEmpty(txtSearch.Text))
                sQuery += " AND TblPartner.Active = 1 AND (TblPartner.NamePartner LIKE N'%" + txtSearch.Text + "%' OR TblPartner.NameSearch LIKE N'%" + txtSearch.Text + "%' OR TblPartner.CodePartner ='" + txtSearch.Text.Trim() + "')";
            sQuery += " ORDER BY IDPartner DESC ";
            objData = objFunc.EXESelect(sQuery);

            for (int i = 0; i < objData.Rows.Count; i++)
            {
                objData.Rows[i]["TT"] = i + 1;
            }
            //gridviewMembers.AutoGenerateColumns = false;
            gridviewMembers.DataSource = objData;
            Classes.clsGridViewInterface.SetMEMBER(gridviewMembers);
        }

        private void LoadPartnerRegis(int sIDValue)
        {
            string sQuery = "SELECT TblPartnerRegis.IDPartnerRegis,TblPartnerRegis.IDPartner,TblGymRoom.IDGymRoom,TblGymRoom.NameGymRoom,TblTypeGym.IDTypeGym,TblTypeGym.NameTypeGym," +
                            "TblPackGym.IDPackGym,TblPackGym.NamePackGym,TblPartnerRegis.IDWorkOut,TblPartnerRegis.Times,TblPartnerRegis.Price,TblPartnerRegis.TotalPay,TblPartnerRegis.Payed,TblPartnerRegis.StartDate," +
                            "TblPartnerRegis.EndDate,TblPartnerRegis.Active,TblPartnerRegis.IDEmp,TblPartnerRegis.ReExIDM,TblPartnerRegis.OriginalBill,TblPartnerRegis.Note, TblPartnerRegis.Freeze, TblPartnerRegis.DayLeft,TblPartnerRegis.IDRootBill " +
                            "FROM TblPartnerRegis " +
                            "LEFT JOIN TblGymRoom ON TblGymRoom.IDGymRoom=TblPartnerRegis.IDGymRoom " +
                            "LEFT JOIN TblPackGym ON TblPackGym.IDPackGym=TblPartnerRegis.IDPackGym " +
                            "LEFT JOIN TblTypeGym ON TblTypeGym.IDTypeGym=TblPartnerRegis.IDTypeGym WHERE TblPartnerRegis.IDPartner=" + sIDValue + " ORDER BY TblPartnerRegis.IDPartnerRegis DESC";
            objRegis = objFunc.EXESelect(sQuery);
            gridPartnerRegis.DataSource = objRegis;
            Classes.clsGridViewInterface.SetREGIS(gridPartnerRegis);
            btnDelPackGym.Enabled = false;
            btnFreeze.Enabled = false;
            if (objRegis.Rows.Count > 0)
            {
                btnFreeze.Enabled = true;
                btnDelPackGym.Enabled = true;
            }
            else
            {
                btnDelPackGym.Enabled = false;
                btnFreeze.Enabled = false;
            }

        }

        private void LoadTimeInDay(int sIDPartnerRegis)
        {
            string sQuery = "SELECT IDTimeInDay,StartTime,FinishTime,IDPartnerRegis FROM TblTimeInDay WHERE IDPartnerRegis=" + sIDPartnerRegis;
            objTimeInDay = objFunc.EXESelect(sQuery);
            gridTimeInDay.DataSource = objTimeInDay;
            Classes.clsGridViewInterface.SetTimeInDay(gridTimeInDay);
            if (objTimeInDay.Rows.Count > 0)
            {
                btnDelTimeInDay.Enabled = true;
            }
            else
            {
                btnDelTimeInDay.Enabled = false;
            }
        }

        private void FrmManagerInOut_Load(object sender, EventArgs e)
        {
            Classes.clsGridViewInterface.LoadCbo(cboIDPartnerGroup, cboIDPartnerGroup.Name.Substring(3));
            Classes.clsGridViewInterface.LoadCbo(cboIDGender, cboIDGender.Name.Substring(3));
            Classes.clsGridViewInterface.LoadCbo(cboIDEmp, cboIDEmp.Name.Substring(3));
            ModeButton("Load");
            LoadForm();
            if (gridviewMembers.RowCount > 0)
            {
                gridviewMembers_CellClick(gridviewMembers, new DataGridViewCellEventArgs(0, 1));
            }
            //lblCount.Text = "Hiện có: "+objData.Rows.Count.ToString()+" thành viên tham gia";
        }
        #endregion

        #region Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCodePartner.Focus();
            txtAddress.Text = txtCodePartner.Text = txtNamePartner.Text = txtNote.Text =
                txtPhone.Text = txtSearch.Text = txtSoCMND.Text = txtSDTNgNha.Text = txtTenNgNha.Text = "";
            LoadPartnerRegis(0);
            ModeButton("Update");
            gridviewMembers.ClearSelection();
            sIDValue = "0";
            IsAdd = true;
            fUpdate = false;
            btnFreeze.Enabled = false;
            btnDelPackGym.Enabled = false;
        }
        #endregion

        #region Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtCodePartner.Text))
            //    return;
            try
            {
                fUpdate = true;
                ModeButton("Update");
            }
            catch
            {
            }
        }
        #endregion

        #region Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Classes.clsMessage.Question("Bạn có muốn xóa hội viên " + gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["NamePartner"].Value.ToString() + " này không") == DialogResult.Yes)
                {
                    if (Classes.clsQueryDelete.GymRoom(sIDValue, "IDPartner", "PartnerRegis"))
                    {
                        Classes.clsMessage.Error("Lỗi. Dữ liệu này đang được sử dụng");
                    }
                    else
                    {
                        Classes.clsQueryDelete.EXEDelete("Partner", "IDPartner", sIDValue);
                    }
                    LoadForm();
                }
            }
            catch
            {
            }
        }
        #endregion

        #region Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            string sOriginalBill = String.Empty;
            bool sChkBarCode = false;
            if (string.IsNullOrEmpty(txtCodePartner.Text))
            {
                Classes.clsMessage.Warning("Mã vạch không được để trống xin vui lòng kiểm tra lại");
                return;
            }
            for (int i = 0; i < objData.Rows.Count; i++)
            {
                if (IsAdd)
                {
                    if (objData.Rows[i]["CodePartner"].ToString().Replace(" ", "") == txtCodePartner.Text.Replace(" ", ""))
                    {
                        Classes.clsMessage.Warning("Mã vạch đã tồn tại xin vui lòng kiểm tra lại");
                        sChkBarCode = true;
                        return;
                    }
                }
                if (i != Convert.ToInt32(gridviewMembers.CurrentCell.RowIndex.ToString()))
                {
                    if (objData.Rows[i]["CodePartner"].ToString().Replace(" ", "") == txtCodePartner.Text.Replace(" ", ""))
                    {
                        Classes.clsMessage.Warning("Mã vạch đã tồn tại xin vui lòng kiểm tra lại");
                        sChkBarCode = true;
                        return;
                    }
                }
            }
            if (!sChkBarCode)
            {
                objMember.UpdatePartner(Convert.ToInt32(sIDValue), Convert.ToInt32(cboIDGender.SelectedValue), txtCodePartner.Text, Convert.ToInt32(cboIDPartnerGroup.SelectedValue),
                                        0, txtNamePartner.Text, Convert.ToDateTime(dateBirthday.Text), txtPhone.Text, txtAddress.Text, obj.NameForSearch(txtNamePartner.Text),
                                        txtNote.Text, Convert.ToDateTime(DateTime.Now.ToString()), chkActive.Checked, chkHide.Checked, Convert.ToInt32(cboIDEmp.SelectedValue), txtSoCMND.Text, txtTenNgNha.Text, txtSDTNgNha.Text);
            }
            if (objTimeInDay != null)
            for (int i = 0; i < this.objTimeInDay.Rows.Count; i++)
            {
                objMember.UpdateTimeInDay(objTimeInDay.Rows[i]["IDTimeInDay"].ToString(), objTimeInDay.Rows[i]["StartTime"].ToString(), objTimeInDay.Rows[i]["FinishTime"].ToString(), sIDPartnerRegis);
            }
            Classes.clsMessage.Information("Ghi nhận thành công!");
            ModeButton("Load");
            LoadForm();
        }
        #endregion End

        #region Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (gridviewMembers.RowCount > 0)
            {
                gridviewMembers_CellClick(gridviewMembers, new DataGridViewCellEventArgs(0, 1));
            }
            txtCodePartner.Focus();
            txtAddress.Text = txtCodePartner.Text = txtNamePartner.Text = txtNote.Text =
                txtPhone.Text = txtSearch.Text = txtSoCMND.Text = txtSDTNgNha.Text = txtTenNgNha.Text = "";
            LoadPartnerRegis(0);
            LoadForm();
            ModeButton("Load");
        }
        #endregion

        #region Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region UpImage
        private void btnUpImage_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "image files (*.jpg)|*.jepg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        string sPathImage = openFileDialog1.FileName;
                        pictureBox1.Image = Image.FromFile(sPathImage);
                        string strImage = objI.UpLoad_StringImage(sPathImage);
                        objMember.UpdateImge(Convert.ToInt32(sIDValue), strImage);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        #endregion

        #region Hotkey
        private void FrmPartnerRegis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4) btnAdd.PerformClick();
            else if (e.KeyCode == Keys.F2) btnUpImage.PerformClick();
            else if (e.KeyCode == Keys.F5) btnUpdate.PerformClick();
            else if (e.KeyCode == Keys.F6) btnSave.PerformClick();
            else if (e.KeyCode == Keys.F8) btnDelete.PerformClick();
            else if (e.KeyCode == Keys.Escape)
            {
                if (btnSave.Enabled == true) btnCancel.PerformClick();
                else btnExit.PerformClick();
            }
        }
        #endregion

        #region txt_Enter_Leave
        private void txt_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
            txt.BackColor = TVSSys.GlobalModule.objColorEnter;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
            txt.BackColor = TVSSys.GlobalModule.objColorLeave;
        }

        private void cbo_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox txt = (System.Windows.Forms.ComboBox)sender;
            txt.BackColor = TVSSys.GlobalModule.objColorEnter;
        }

        private void cbo_Leave(object sender, EventArgs e)
        {
            ComboBox txt = (ComboBox)sender;
            txt.BackColor = TVSSys.GlobalModule.objColorLeave;
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{TAB}");
        }
        #endregion

        #region CellEnter
        private void gridviewMembers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        #region Create BarCode
        public bool IsNumber(string pValue)
        {
            foreach (char c in pValue)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btnCreateBarCode_Click(object sender, EventArgs e)
        {
            bool kt = false;
            Int64 FMax = 894800000001;
            Int64 FmaxBarCode = 0;
            for (int i = 0; i < objData.Rows.Count; i++)
            {
                if (objData.Rows[i]["CodePartner"].ToString() != String.Empty)
                {
                    if (IsNumber(objData.Rows[i]["CodePartner"].ToString()) == true)
                    {
                        FmaxBarCode = Convert.ToInt64(objData.Rows[i]["CodePartner"].ToString()) / 10;
                        FMax = Math.Max(FMax, FmaxBarCode);
                        kt = true;
                    }
                    //else i++;
                }
            }

            if (kt == false)
            {
                FMax = (FMax * 10);
            }
            else
            {
                FMax = (FMax + 1) * 10;
            }

            char[] cFmax;
            cFmax = Convert.ToString(FMax).ToCharArray();
            int SumParity = 0;
            int SumOdd = 0;
            for (int i = 0; i < cFmax.Length; i++)
            {
                if (i % 2 != 0)
                {
                    SumOdd = SumOdd + Convert.ToInt32(cFmax[i].ToString());
                }
                else
                {
                    SumParity = SumParity + Convert.ToInt32(cFmax[i].ToString());
                }
            }
            if ((SumParity + (SumOdd * 3)) % 10 == 0)
            {
                FMax = FMax;
            }
            else
            {
                double z = (10 - ((SumParity + (SumOdd * 3)) % 10));
                FMax = FMax + Convert.ToInt64(z);
            }
            txtCodePartner.Text = FMax.ToString();
        }
        #endregion

        #region Method Print
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.Show();
        }
        #endregion

        #region method txtSearch_TextChanged
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            System.Data.DataTable tbl = (System.Data.DataTable)gridviewMembers.DataSource; // = objData;
            tbl.DefaultView.RowFilter = "NamePartner LIKE '%" + txtSearch.Text + "%'";
            gridviewMembers.DataSource = tbl;
            Classes.clsGridViewInterface.SetMEMBER(gridviewMembers);
            if (gridviewMembers.RowCount == 1)
            {
                gridviewMembers_CellClick(gridviewMembers, new DataGridViewCellEventArgs(0, 1));
            }
            else
            {
                gridviewMembers.ClearSelection();
            }
            //LoadForm();
        }
        #endregion

        #region method btnRegis_Click
        private void btnRegis_Click(object sender, EventArgs e)
        {
            FrmUpdPartnerRegis frm = new FrmUpdPartnerRegis();
            frm.sID = "0";
            if (cboIDEmp.SelectedValue!= null)
                frm.sIDEmp = cboIDEmp.SelectedValue.ToString();
            frm.sIDPartnerRegis = "0";
            frm.sIDPartner = sIDValue;
            frm.sNamePartner = txtNamePartner.Text;
            frm.sCodePartner = txtCodePartner.Text;
            frm.fUpdate = false;
            frm.ShowDialog();
            if (gridviewMembers.CurrentRow != null)
                gridviewMembers_CellClick(gridviewMembers, new DataGridViewCellEventArgs(0, gridviewMembers.CurrentCell.RowIndex));

        }
        #endregion

        #region method gridPartnerRegis_DoubleClick
        private void gridPartnerRegis_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                FrmUpdPartnerRegis frm = new FrmUpdPartnerRegis();
                frm.sID = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDRootBill"].Value.ToString();
                frm.sIDPartnerRegis = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDPartnerRegis"].Value.ToString();
                frm.sIDPartner = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDPartner"].Value.ToString();
                frm.sNamePartner = txtNamePartner.Text;
                frm.sCodePartner = txtCodePartner.Text;
                frm.sIDTypGym = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDTypeGym"].Value.ToString();
                frm.sPackGym = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDPackGym"].Value.ToString();
                frm.sGymRoom = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDGymRoom"].Value.ToString();
                frm.sStartDate = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["StartDate"].Value.ToString();
                frm.sEndDate = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["EndDate"].Value.ToString();
                frm.sIDEmp = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDEmp"].Value.ToString();
                frm.sCount = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["Times"].Value.ToString();
                frm.sPrice = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["Price"].Value.ToString();
                frm.sTotalPay = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["TotalPay"].Value.ToString();
                frm.sPayed = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["Payed"].Value.ToString();
                frm.sNote = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["Note"].Value.ToString();
                frm.sReExIDM = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["ReExIDM"].Value.ToString();
                frm.sOriginalBill = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["OriginalBill"].Value.ToString();
                frm.sActive = Convert.ToBoolean(gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["Active"].Value.ToString());
                frm.fUpdate = true;
                frm.ShowDialog();

                gridviewMembers_CellClick(gridviewMembers, new DataGridViewCellEventArgs(0, gridviewMembers.CurrentCell.RowIndex));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detail error: " + ex.Message, "TVS-GYM: Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        #endregion

        #region method btnFreeze_Click
        private void btnFreeze_Click(object sender, EventArgs e)
        {
            FrmUpdPartnerFreezen frm = new FrmUpdPartnerFreezen();
            frm.sID = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDRootBill"].Value.ToString();
            frm.sIDPartnerRegis = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDPartnerRegis"].Value.ToString();
            frm.sIDPartner = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDPartner"].Value.ToString();
            frm.sNamePartner = txtNamePartner.Text;
            frm.sCodePartner = txtCodePartner.Text;
            frm.sIDTypGym = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDTypeGym"].Value.ToString();
            frm.sPackGym = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDPackGym"].Value.ToString();
            frm.sGymRoom = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDGymRoom"].Value.ToString();
            frm.sStartDate = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["StartDate"].Value.ToString();
            frm.sEndDate = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["EndDate"].Value.ToString();
            frm.sIDEmp = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDEmp"].Value.ToString();
            frm.sCount = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["Times"].Value.ToString();
            frm.sPrice = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["Price"].Value.ToString();
            frm.sTotalPay = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["TotalPay"].Value.ToString();
            frm.sPayed = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["Payed"].Value.ToString();
            frm.sNote = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["Note"].Value.ToString();
            frm.sReExIDM = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["ReExIDM"].Value.ToString();
            frm.sOriginalBill = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["OriginalBill"].Value.ToString();
            frm.sActive = Convert.ToBoolean(gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["Active"].Value.ToString());
            frm.sFreeze = Convert.ToBoolean(gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["Freeze"].Value.ToString());
            frm.sDayLeft = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["DayLeft"].Value.ToString();
            frm.fUpdate = true;
            frm.ShowDialog();
        }
        #endregion

        #region DelPackGym
        private void btnDelPackGym_Click(object sender, EventArgs e)
        {
            if (Classes.clsMessage.Question("Bạn có muốn xóa gói tập này của thành viên không") == DialogResult.Yes)
            {
                if (Classes.clsQueryDelete.CheckPackGym(gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDPartnerRegis"].Value.ToString()))//, "IDPartner", "WorkoutHistory"))
                {
                    Classes.clsMessage.Error("Lỗi. Dữ liệu này đang được sử dụng");
                }
                else
                {
                    //Classes.clsQueryDelete.EXEDelete("PartnerRegis", "IDPartnerRegis", Classes.clsQueryDelete.GymRoom(gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDPartnerRegis"].Value.ToString()));
                    Classes.clsQueryDelete.InsertTblPartnerRegisDel(gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDPartnerRegis"].Value.ToString());
                    Classes.clsQueryDelete.InsertTblBillDelete(gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["OriginalBill"].Value.ToString());
                    Classes.clsQueryDelete.EXEDelete("PartnerRegis", "IDPartnerRegis", gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDPartnerRegis"].Value.ToString());
                    Classes.clsQueryDelete.EXEDelete("Bill", "OriginalBill", gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["OriginalBill"].Value.ToString());
                }
                LoadForm();
            }
        }
        #endregion

        #region method CellFormat
        public void CellFormat(Excel.Worksheet xlWorkSheet, string Local1, string Local2, string sTitle, string sName, double sSize, bool sBool, bool sBool1, int sHorizontalAlignment, int sVerticalAlignment)
        {
            Excel.Range chartRange;
            xlWorkSheet.get_Range(Local1, Local2).Merge(false);
            chartRange = xlWorkSheet.get_Range(Local1, Local2);
            chartRange.FormulaR1C1 = sTitle;
            chartRange.Font.Name = sName;
            chartRange.Font.Size = sSize;
            chartRange.Font.Bold = sBool;
            chartRange.Font.Italic = sBool1;
            chartRange.HorizontalAlignment = sHorizontalAlignment;
            chartRange.VerticalAlignment = sVerticalAlignment;
            chartRange = xlWorkSheet.get_Range(Local1, Local2);
            chartRange.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);

        }
        #endregion

        #region method CellFormatNoneText
        public void CellFormatNoneText(Excel.Worksheet xlWorkSheet, string Local1, string Local2, string sName, double sSize, bool sBool, int sHorizontalAlignment, int sVerticalAlignment)
        {
            Excel.Range chartRange;
            xlWorkSheet.get_Range(Local1, Local2).Merge(false);
            chartRange = xlWorkSheet.get_Range(Local1, Local2);
            chartRange.Font.Name = sName;
            chartRange.Font.Size = sSize;
            chartRange.Font.Bold = sBool;
            chartRange.HorizontalAlignment = sHorizontalAlignment;
            chartRange.VerticalAlignment = sVerticalAlignment;
            chartRange.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
            //chartRange.RowHeight = 20;
            //chartRange.NumberFormat = "#,##0";
        }
        #endregion

        #region CellFormatNoneBorder
        public void CellFormatNoneBorder(Excel.Worksheet xlWorkSheet, string Local1, string Local2, string sTitle, string sName, double sSize, bool sBool, bool sBool1, int sHorizontalAlignment, int sVerticalAlignment)
        {
            Excel.Range chartRange;
            xlWorkSheet.get_Range(Local1, Local2).Merge(false);
            chartRange = xlWorkSheet.get_Range(Local1, Local2);
            chartRange.FormulaR1C1 = sTitle;
            chartRange.Font.Name = sName;
            chartRange.Font.Size = sSize;
            chartRange.Font.Bold = sBool;
            chartRange.Font.Italic = sBool1;
            chartRange.HorizontalAlignment = sHorizontalAlignment;
            chartRange.VerticalAlignment = sVerticalAlignment;
        }
        #endregion

        #region CellFormatContent
        public void CellFormatContent(Excel.Worksheet xlWorkSheet, string Local1, string Local2, string sName, double sSize, int sHorizontalAlignment, int sVerticalAlignment)
        {
            Excel.Range chartRange;
            chartRange = xlWorkSheet.get_Range(Local1, Local2);
            chartRange.Font.Name = sName;
            chartRange.Font.Size = sSize;
            chartRange.HorizontalAlignment = 1;
            chartRange.VerticalAlignment = 2;
            chartRange.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
        }
        #endregion

        #region Export
        //private void PrintPackage(int PackageID, string PackageName, string PackageNote, int STT, Excel.Workbook xlWorkBook)
        private void PrintPackage(int STT, Excel.Workbook xlWorkBook)
        {
            //Microsoft.Office.Interop.Excel.Application xlWorkSheet = new Microsoft.Office.Interop.Excel.Application();
            Excel.Worksheet xlWorkSheet = null;
            Excel.Range chartRange;
            Excel.Borders borders;

            try
            {
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(STT);
            }
            catch
            {
                try
                {
                    xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.Add(xlWorkBook.Worksheets[STT - 1], Type.Missing, Type.Missing, Type.Missing);
                    xlWorkSheet.Name = "Sheet" + STT;
                }
                catch
                {
                    MessageBox.Show("Lỗi khi tạo Sheet trong file Excel", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            xlWorkSheet.PageSetup.Orientation = XlPageOrientation.xlLandscape;

            ((Excel.Range)xlWorkSheet.Columns["A", Type.Missing]).ColumnWidth = 6;
            ((Excel.Range)xlWorkSheet.Columns["B", Type.Missing]).ColumnWidth = 18;
            ((Excel.Range)xlWorkSheet.Columns["C", Type.Missing]).ColumnWidth = 20;
            ((Excel.Range)xlWorkSheet.Columns["D", Type.Missing]).ColumnWidth = 6.3;
            ((Excel.Range)xlWorkSheet.Columns["E", Type.Missing]).ColumnWidth = 15;
            ((Excel.Range)xlWorkSheet.Columns["F", Type.Missing]).ColumnWidth = 12;
            ((Excel.Range)xlWorkSheet.Columns["G", Type.Missing]).ColumnWidth = 25;
            ((Excel.Range)xlWorkSheet.Columns["H", Type.Missing]).ColumnWidth = 25;


            CellFormatNoneBorder(xlWorkSheet, "A1", "H1", "DANH SÁCH KHÁCH HÀNG", "Times New Roman", 13, true, false, 3, 3);

            //CellFormatNoneBorder(xlWorkSheet, "A3", "R3", "Tên nhà thầu : " + m_BidderName, "Times New Roman", 11, true, false, 1, 3);

            //CellFormatNoneBorder(xlWorkSheet, "A4", "R4", "Tên gói thầu : " + PackageName, "Times New Roman", 11, true, false, 1, 3);

            CellFormat(xlWorkSheet, "A6", "A6", "STT", "Times New Roman", 10, true, false, 2, 2);
            CellFormat(xlWorkSheet, "B6", "B6", "Mã Khách hàng", "Times New Roman", 10, true, false, 3, 2);
            CellFormat(xlWorkSheet, "C6", "C6", "Tên Khách hàng", "Times New Roman", 10, true, false, 3, 2);
            CellFormat(xlWorkSheet, "D6", "D6", "Giới tính", "Times New Roman", 10, true, false, 6, 2);
            CellFormat(xlWorkSheet, "E6", "E6", "Sinh ngày", "Times New Roman", 10, true, false, 6, 2);
            CellFormat(xlWorkSheet, "F6", "F6", "Điện thoại", "Times New Roman", 10, true, false, 6, 2);
            CellFormat(xlWorkSheet, "G6", "G6", "Địa chỉ", "Times New Roman", 10, true, false, 6, 2);
            CellFormat(xlWorkSheet, "H6", "H6", "Ghi chú", "Times New Roman", 10, true, false, 6, 2);


            chartRange = xlWorkSheet.get_Range("A6", "H6");
            chartRange.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);

            CellFormat(xlWorkSheet, "A7", "A7", "'(1)", "Times New Roman", 10, false, true, 3, 2);
            CellFormat(xlWorkSheet, "B7", "B7", "'(2)", "Times New Roman", 10, false, true, 3, 2);
            CellFormat(xlWorkSheet, "C7", "C7", "'(3)", "Times New Roman", 10, false, true, 3, 2);
            CellFormat(xlWorkSheet, "D7", "D7", "'(4)", "Times New Roman", 10, false, true, 3, 2);
            CellFormat(xlWorkSheet, "E7", "E7", "'(5)", "Times New Roman", 10, false, true, 3, 2);
            CellFormat(xlWorkSheet, "F7", "F7", "'(6)", "Times New Roman", 10, false, true, 3, 2);
            CellFormat(xlWorkSheet, "G7", "G7", "'(7)", "Times New Roman", 10, false, true, 3, 2);
            CellFormat(xlWorkSheet, "H7", "H7", "'(8)", "Times New Roman", 10, false, true, 3, 2);



            int Number = 0, Amount = 0;
            for (int i = 0; i < objData.Rows.Count; i++)
            {

                xlWorkSheet.Cells[Number + 8, 1] = (Number + 1).ToString();
                CellFormatNoneText(xlWorkSheet, "A" + (Number + 8).ToString(), "A" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);


                xlWorkSheet.Cells[Number + 8, 2] = objData.Rows[i]["CodePartner"].ToString();
                CellFormatNoneText(xlWorkSheet, "B" + (Number + 8).ToString(), "B" + (Number + 8).ToString(), "Times New Roman", 10, false, 3, 2);


                xlWorkSheet.Cells[Number + 8, 3] = objData.Rows[i]["NamePartner"].ToString();
                CellFormatNoneText(xlWorkSheet, "C" + (Number + 8).ToString(), "C" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);

                xlWorkSheet.Cells[Number + 8, 4] = objData.Rows[i]["NameGender"].ToString();
                CellFormatNoneText(xlWorkSheet, "D" + (Number + 8).ToString(), "D" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);

                xlWorkSheet.Cells[Number + 8, 5] = objData.Rows[i]["Birthday"].ToString();
                CellFormatNoneText(xlWorkSheet, "E" + (Number + 8).ToString(), "E" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);

                xlWorkSheet.Cells[Number + 8, 6] = objData.Rows[i]["Phone"].ToString();
                CellFormatNoneText(xlWorkSheet, "F" + (Number + 8).ToString(), "F" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);

                xlWorkSheet.Cells[Number + 8, 7] = objData.Rows[i]["Address"].ToString();
                CellFormatNoneText(xlWorkSheet, "G" + (Number + 8).ToString(), "G" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);

                xlWorkSheet.Cells[Number + 8, 8] = objData.Rows[i]["Note"].ToString();
                CellFormatNoneText(xlWorkSheet, "H" + (Number + 8).ToString(), "H" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);

                //xlWorkSheet.Cells[Number + 8, 9] = SoDangKyPrint[i];
                //CellFormatNoneText(xlWorkSheet, "I" + (Number + 8).ToString(), "I" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);

                //xlWorkSheet.Cells[Number + 8, 10] = CoSoSanXuatPrint[i];
                //CellFormatNoneText(xlWorkSheet, "J" + (Number + 8).ToString(), "J" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);

                //xlWorkSheet.Cells[Number + 8, 11] = NuocSanXuatPrint[i];
                //CellFormatNoneText(xlWorkSheet, "K" + (Number + 8).ToString(), "K" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);

                //xlWorkSheet.Cells[Number + 8, 12] = DonViTinhPrint[i];
                //CellFormatNoneText(xlWorkSheet, "L" + (Number + 8).ToString(), "L" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);

                //xlWorkSheet.Cells[Number + 8, 13] = GiaBanBuonPrint[i];
                //CellFormatNoneText(xlWorkSheet, "M" + (Number + 8).ToString(), "M" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);

                //xlWorkSheet.Cells[Number + 8, 14] = GiaDuThauPrint[i];
                //CellFormatNoneText(xlWorkSheet, "N" + (Number + 8).ToString(), "N" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);

                //xlWorkSheet.Cells[Number + 8, 15] = SoLuongPrint[i];
                //CellFormatNoneText(xlWorkSheet, "O" + (Number + 8).ToString(), "O" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);

                //Amount++;
                //Money = GiaDuThauPrint[i] * SoLuongPrint[i];
                //xlWorkSheet.Cells[Number + 8, 16] = Money;
                //CellFormatNoneText(xlWorkSheet, "P" + (Number + 8).ToString(), "P" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);

                //xlWorkSheet.Cells[Number + 8, 17] = PhanLoaiPrint[i];
                //CellFormatNoneText(xlWorkSheet, "Q" + (Number + 8).ToString(), "Q" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);

                //if (UuTienPrint[i] == "True")
                //{
                //    xlWorkSheet.Cells[Number + 8, 18] = "Ưu tiên";
                //}
                //else
                //{
                //    xlWorkSheet.Cells[Number + 8, 18] = "Không ưu tiên";
                //}
                //    CellFormatNoneText(xlWorkSheet, "R" + (Number + 8).ToString(), "R" + (Number + 8).ToString(), "Times New Roman", 10, false, 6, 2);

                //TotalMoney += Money;
                Number++;
            }



            //chartRange = xlWorkSheet.get_Range("A10", "F" + Number + 10);
            //chartRange.Columns.HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify;
            //chartRange.Columns.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            //chartRange = xlWorkSheet.get_Range("A8", "J8");
            //chartRange.Columns.HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify;
            //chartRange.Columns.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            //xlWorkSheet.get_Range("I" + (Number + 11).ToString(), "M" + (Number + 11).ToString()).Merge(false);
            //chartRange = xlWorkSheet.get_Range("I" + (Number + 11).ToString(), "M" + (Number + 11).ToString());
            //chartRange.FormulaR1C1 = "Tổng số: " + string.Format("{0:###,0}", Amount) + " mặt hàng dự thầu";
            //chartRange.Font.Name = "Times New Roman";
            //chartRange.Font.Size = 10;
            //chartRange.Font.Bold = true;
            //chartRange.HorizontalAlignment = 3;
            //chartRange.VerticalAlignment = 2;
            //chartRange.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);

            //xlWorkSheet.get_Range("N" + (Number + 11).ToString(), "R" + (Number + 11).ToString()).Merge(false);
            //chartRange = xlWorkSheet.get_Range("N" + (Number + 11).ToString(), "R" + (Number + 11).ToString());
            //chartRange.FormulaR1C1 = "Tổng thành tiền: " + string.Format("{0:###,0}", TotalMoney);
            //chartRange.Font.Name = "Times New Roman";
            //chartRange.Font.Size = 10;
            //chartRange.Font.Bold = true;
            //chartRange.HorizontalAlignment = 3;
            //chartRange.VerticalAlignment = 2;
            //chartRange.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);

            //xlWorkSheet.get_Range("K" + (Number + 13).ToString(), "R" + (Number + 13).ToString()).Merge(false);
            //chartRange = xlWorkSheet.get_Range("K" + (Number + 13).ToString(), "R" + (Number + 13).ToString());
            //chartRange.FormulaR1C1 = "Đại diện hợp pháp của nhà thầu";
            //chartRange.Font.Name = "Times New Roman";
            //chartRange.HorizontalAlignment = 3;
            //chartRange.VerticalAlignment = 3;
            //chartRange.Font.Size = 11;
            //chartRange.Font.Bold = true;

            //xlWorkSheet.get_Range("K" + (Number + 14).ToString(), "R" + (Number + 14).ToString()).Merge(false);
            //chartRange = xlWorkSheet.get_Range("K" + (Number + 14).ToString(), "R" + (Number + 14).ToString());
            //chartRange.FormulaR1C1 = "(Ghi tên, chức danh, ký tên và đóng dấu)";
            //chartRange.Font.Name = "Times New Roman";
            //chartRange.HorizontalAlignment = 3;
            //chartRange.VerticalAlignment = 3;
            //chartRange.Font.Size = 11;
        }
        #endregion

        #region method releaseObject
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        #endregion

        #region method btnExportExcel_Click
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (FrmMain.sExportFile)
            {
                this.sfdExportToExcel.Filter = "Excel 2007 files (*.xlsx)|*.xlsx";
                this.sfdExportToExcel.FilterIndex = 1;
                this.sfdExportToExcel.RestoreDirectory = true;
                this.sfdExportToExcel.FileName = "";
                string strSaveFileName2 = "";
                if (this.sfdExportToExcel.ShowDialog() == DialogResult.OK && this.sfdExportToExcel.FileName != "")
                {
                    strSaveFileName2 = this.sfdExportToExcel.FileName;

                    try
                    {
                        Excel.Application xlApp;
                        Excel.Workbook xlWorkBook;
                        object misValue = System.Reflection.Missing.Value;
                        xlApp = new Excel.ApplicationClass();
                        xlWorkBook = xlApp.Workbooks.Add(misValue);
                        int STT = 1;
                        this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                        //for (int i = 0; i < objData.Rows.Count; i++)
                        //{
                        //    PrintPackage(STT, xlWorkBook);
                        //    STT++;
                        //}

                        PrintPackage(STT, xlWorkBook);


                        xlWorkBook.SaveCopyAs(@"" + strSaveFileName2);
                        xlWorkBook.Close(false, misValue, misValue);
                        xlApp.Quit();
                        releaseObject(xlWorkBook);
                        releaseObject(xlApp);

                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi xảy ra trong quá trình xuất dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xuất danh sách khách hàng ra file excel", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        #endregion

        private void gridPartnerRegis_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gridPartnerRegis.CurrentRow == null) return;

            DataRowView dr = (DataRowView)gridPartnerRegis.CurrentRow.DataBoundItem;
            if (dr["Freeze"].ToString() == "False")
                btnFreeze.Text = "Kích hoạt đóng băng";
            else
                btnFreeze.Text = "Mở đóng băng";
            sIDPartnerRegis = gridPartnerRegis.Rows[gridPartnerRegis.CurrentCell.RowIndex].Cells["IDPartnerRegis"].Value.ToString();
            LoadTimeInDay(int.Parse(sIDPartnerRegis));
        }

        private void btnDelTimeInDay_Click(object sender, EventArgs e)
        {
            objFunc.EXEUpdate("DELETE TblTimeInDay WHERE IDTimeInDay=" + sIdTimeInDay);
            LoadTimeInDay(int.Parse(sIDPartnerRegis));
        }

        private void gridTimeInDay_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            sIdTimeInDay = this.gridTimeInDay.Rows[this.gridTimeInDay.CurrentCell.RowIndex].Cells["IDTimeInDay"].Value.ToString();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void gridviewMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridviewMembers.CurrentCell == null) return;
            try
            {
                if (objData.Rows.Count > 0)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    sIDValue = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["IDPartner"].Value.ToString();
                    txtAddress.Text = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["Address"].Value.ToString();
                    txtCodePartner.Text = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["CodePartner"].Value.ToString();
                    txtNamePartner.Text = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["NamePartner"].Value.ToString();
                    dateBirthday.Text = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["Birthday"].Value.ToString();
                    txtPhone.Text = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["Phone"].Value.ToString();
                    cboIDGender.SelectedValue = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["IDGender"].Value.ToString();
                    cboIDPartnerGroup.SelectedValue = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["IDPartnerGroup"].Value.ToString();
                    cboIDEmp.SelectedValue = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["IDEmp"].Value.ToString();
                    txtNote.Text = gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["Note"].Value.ToString();
                    chkActive.Checked = Convert.ToBoolean(gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["Active"].Value.ToString());
                    chkHide.Checked = Convert.ToBoolean(gridviewMembers.Rows[gridviewMembers.CurrentCell.RowIndex].Cells["Hide"].Value.ToString());

                    DataRowView dr = (DataRowView)gridviewMembers.CurrentRow.DataBoundItem;
                    txtSoCMND.Text = dr["SoCMND"].ToString();
                    txtTenNgNha.Text = dr["TenNguoiNha"].ToString();
                    txtSDTNgNha.Text = dr["SDTNguoiNha"].ToString();
                    pictureBox1.Image = null;
                    string imgStr = TVSSys.GlobalModule.objCon.Get_EXESelect("SELECT [Image] FROM tblPartner WHERE IDPartner=" + sIDValue);
                    if (!string.IsNullOrEmpty(imgStr))
                        pictureBox1.Image = objI.GetImageFromByteArray(imgStr);
                    // pictureBox1.Image = objI.GetImageFromByteArray(TVSSys.GlobalModule.objCon.Get_EXESelect("SELECT [Image] FROM tblPartner WHERE IDPartner=" + sIDValue));

                    lblCount.Text = "Hiện có: " + objData.Rows.Count.ToString() + " thành viên tham gia";
                    LoadPartnerRegis(Convert.ToInt32(sIDValue));
                    Cursor.Current = Cursors.Default;
                    btnUpdate.Enabled = true;
                }
                else sIDValue = "0";
            }
            catch (Exception ex)
            {
                Classes.clsMessage.Error("Lỗi" + ex.ToString());
            }
        }
    }

}
