using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TVSGM.Forms
{
    public partial class FrmChoosePartner : Form
    {
        public int sTypeInOut;
        public string sTableName, sIDPartner, sPartner, sAddress, sPhone, sCodePartner;
        public static string sText = String.Empty,IdPartner , NamePartner, sIDValue;
        public string sSQL ;
        public bool fAction = false;
        private DataTable objData;
        TVSSys.Connection objFunc = new TVSSys.Connection();


        public FrmChoosePartner()
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
                            this.gridviewDir.AllowUserToAddRows = false;
                            this.btnAdd.Enabled = true;
                            this.btnUpdate.Enabled = true;
                            this.btnDelete.Enabled = true;
                            this.btnSave.Enabled = false;
                            this.btnCancel.Enabled = false;
                            break;
                        }
                    case "Update":
                        {
                            this.gridviewDir.AllowUserToAddRows = true;
                            this.btnAdd.Enabled = false;
                            this.btnUpdate.Enabled = false;
                            this.btnDelete.Enabled = false;
                            this.btnSave.Enabled = true;
                            this.btnCancel.Enabled = true;
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
            if (sTypeInOut == 2)
            {
                sSQL = "SELECT TblPartner.IDPartner,TblPartner.CodePartner,TblPartnerGroup.NamePartnerGroup,TblPartnerType.NamePartnerType," +
                        "TblPartner.NamePartner,TblPartner.Birthday,TblPartner.Phone,TblPartner.Address,TblPartner.Mobile,TblPartner.Fax," +
                        "TblPartner.CodeTax,TblPartner.Email,TblPartner.FirstBalancer,TblPartner.NameSearch,TblPartner.[Root],TblPartner.Note " +
                        "FROM TblPartner " +
                        "LEFT JOIN TblPartnerGroup ON TblPartnerGroup.IDPartnerGroup=TblPartner.IDPartnerGroup " +
                        "LEFT JOIN TblPartnerType ON TblPartnerType.IDPartnerType=TblPartner.IDPartnerType " +
                        " WHERE (TblPartner.IDPartnerType=3 OR TblPartner.IDPartnerType=4) AND (Name" + sTableName + " LIKE '%" + txtSearch.Text + "%' OR NameSearch LIKE N'%" + txtSearch.Text + "%' OR TblPartner.CodePartner LIKE '%" + txtSearch.Text + "%' OR  TblPartner.Phone LIKE '%" + txtSearch.Text + "%' OR TblPartner.Mobile LIKE '%" + txtSearch.Text + "%')";
            }
            //else if(FrmEximProducts.sType == Classes.clsEnums.LoaiCuaSo.BH)
            else if (sTypeInOut==1)
            {
                sSQL = "SELECT TblPartner.IDPartner,TblPartner.CodePartner,TblPartnerGroup.NamePartnerGroup,TblPartnerType.NamePartnerType," +
                        "TblPartner.NamePartner,TblPartner.Birthday,TblPartner.Phone,TblPartner.Address,TblPartner.Mobile,TblPartner.Fax," +
                        "TblPartner.CodeTax,TblPartner.Email,TblPartner.FirstBalancer,TblPartner.NameSearch,TblPartner.[Root],TblPartner.Note " +
                        "FROM TblPartner " +
                        "LEFT JOIN TblPartnerGroup ON TblPartnerGroup.IDPartnerGroup=TblPartner.IDPartnerGroup " +
                        "LEFT JOIN TblPartnerType ON TblPartnerType.IDPartnerType=TblPartner.IDPartnerType " +
                        " WHERE (TblPartner.IDPartnerType=1 OR TblPartner.IDPartnerType=2 OR TblPartner.IDPartnerType=0) AND (Name" + sTableName + " LIKE N'%" + txtSearch.Text + "%' OR NameSearch LIKE N'%" + txtSearch.Text + "%'OR TblPartner.CodePartner LIKE '%" + txtSearch.Text + "%' OR  TblPartner.Phone LIKE '%" + txtSearch.Text + "%' OR TblPartner.Mobile LIKE '%" + txtSearch.Text + "%')";
            }
            else
            {
                sSQL = "SELECT TblPartner.IDPartner,TblPartner.CodePartner,TblPartnerGroup.NamePartnerGroup,TblPartnerType.NamePartnerType," +
                        "TblPartner.NamePartner,TblPartner.Birthday,TblPartner.Phone,TblPartner.Address,TblPartner.Mobile,TblPartner.Fax," +
                        "TblPartner.CodeTax,TblPartner.Email,TblPartner.FirstBalancer,TblPartner.NameSearch,TblPartner.[Root],TblPartner.Note " +
                        "FROM TblPartner " +
                        "LEFT JOIN TblPartnerGroup ON TblPartnerGroup.IDPartnerGroup=TblPartner.IDPartnerGroup " +
                        "LEFT JOIN TblPartnerType ON TblPartnerType.IDPartnerType=TblPartner.IDPartnerType " +
                        " WHERE " +
                        //"(TblPartner.IDPartnerType!=" + (int)FrmBirthdayPartner.NhomKhachHang.KHBanBuon + " AND TblPartner.IDPartnerType!=" + (int)FrmBirthdayPartner.NhomKhachHang.KHBanLe + "" +
                        " TblPartner.IDPartnerType!=" + (int)FrmBirthdayPartner.NhomKhachHang.NhaCC + ""+
                        //" AND TblPartner.IDPartnerType!=" + (int)FrmBirthdayPartner.NhomKhachHang.KHvaNhaCC + " )" +
                        " AND (NamePartner LIKE N'%" + txtSearch.Text + "%' OR NameSearch LIKE N'%" + txtSearch.Text + "%'OR TblPartner.CodePartner LIKE '%" + txtSearch.Text + "%' OR  TblPartner.Phone LIKE '%" + txtSearch.Text + "%' OR TblPartner.Mobile LIKE '%" + txtSearch.Text + "%')";
            }
            objData = objFunc.EXESelect(sSQL);
            this.gridviewDir.DataSource = objData;
            Classes.clsGridViewInterface.SetPARTNER(this.gridviewDir);
        }

        private void FrmChoosePartner_Load(object sender, EventArgs e)
        {
            ModeButton("Load");
            LoadForm();
        }
        #endregion

        #region add new
        private void btnAdd_Click(object sender, EventArgs e)
        {
            sIDValue = "0";
            Forms.FrmUpdPartner frm = new FrmUpdPartner();
            frm.ShowDialog();
            LoadForm();
        }
        #endregion

        #region Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            ModeButton("Load");
            TVSSys.clsPublic obj = new TVSSys.clsPublic();
            if (objData.GetChanges() == null)
            {
                Classes.clsMessage.Warning("Dữ liệu của bạn chưa có sự thay đổi!.");
                return;
            }
            if (objFunc.EXEUpdate(sSQL, objData))
            {
                Classes.clsMessage.Information("Cập nhật dữ liệu thành công.");
            }
            else
            {
                Classes.clsMessage.Error("Lỗi. Cập nhật dữ liệu không thành công.");
            }
            LoadForm();
        }
        #endregion

        #region Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Forms.FrmUpdPartner frm = new FrmUpdPartner();
            frm.sIDValue = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDPartner"].Value.ToString();
            frm.sCodePartner = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["CodePartner"].Value.ToString();
            frm.sIDPartnerGroup = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NamePartnerGroup"].Value.ToString();
            frm.sIDPartnerType = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NamePartnerType"].Value.ToString();
            frm.sNamePartner = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NamePartner"].Value.ToString();
            frm.sBirthday = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["Birthday"].Value.ToString();
            frm.sPhone = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["Phone"].Value.ToString();
            frm.sAddress = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["Address"].Value.ToString();
            frm.sNameSearch = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameSearch"].Value.ToString();
            frm.fUpdate = true;
            frm.ShowDialog();
            LoadForm();
        }
        #endregion

        #region Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = gridviewDir.CurrentCell.RowIndex;
            string sTab = String.Empty;
            try
            {
                sIDValue = gridviewDir.Rows[rowIndex].Cells[0].Value.ToString();
                string sIDName = gridviewDir.Columns[0].Name.ToString() ;
                //string sSQLDelete = "";
                switch (sTableName.ToUpper())
                {
                    case "GYMROOM":
                        {
                            sTab = "Member";
                            break;
                        }
                    case "PACKGYM":
                        {
                            sTab = "Member";
                            break;
                        }
                    case "WORKOUT":
                        {
                            sTab = "Member";
                            break;
                        }
                    case "STORE":
                        {
                            sTab = "PRODUCTS";
                            break;
                        }
                    case "UNIT":
                        {
                            sTab = "PRODUCTS";
                            break;
                        }
                    case "PRODUCTGROUP":
                        {
                            sTab = "PRODUCTS";
                            break;
                        }
                    case "PRODUCTS":
                        {
                            //sTab = "PRODUCTS"; ĐANG ĐỢI LÀM PHẦN QUẢN LÝ NHẬP XUẤT HÀNG HÓA
                            break;
                        }
                    case "INSTRUMENTS":
                        {
                            //sTab = "PRODUCTS"; ĐANG ĐỢI LÀM PHẦN QUẢN LÝ NHẬP XUẤT DỤNG CỤ
                            break;
                        }
                    case "PARTNERGROUP":
                        {
                            sTab = "PARTNER";
                            break;
                        }
                    case "PARTNER":
                        {
                            //sTab = "PARTNER";ĐANG ĐỢI LÀM PHẦN QUẢN LÝ NHẬP XUẤT HÀNG HÓA
                            break;
                        }
                    case "EMPGROUP":
                        {
                            sTab = "Emp";
                            break;
                        }
                    case "EMP":
                        {
                            //sTab = "Emp";ĐANG ĐỢI LÀM PHẦN QUẢN LÝ HỘI VIÊN
                            break;
                        }
                }
                if (Classes.clsQueryDelete.GymRoom(sIDValue, sIDName, sTab))
                {
                    Classes.clsMessage.Error("Lỗi. Dữ liệu này đang được sử dụng");
                    return;
                }
                
                if (Classes.clsQueryDelete.EXEDelete(sTableName, sIDValue, sIDName))
                    Classes.clsMessage.Information("Loại bỏ dữ liệu thành công!.");
                else
                    Classes.clsMessage.Error("Lỗi. Loại bỏ dữ liệu không thành công.");
            }
            catch (Exception ex)
            {
                Classes.clsMessage.Error("Lỗi: " + ex.ToString());
                return;
            }
            LoadForm();

        }
        #endregion

        #region Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ModeButton("Load");
        }
        #endregion

        #region Close
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region txtSearch_TextChanged
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadForm();
        }
        #endregion

        private void ChooseCell()
        {
            sIDPartner = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDPartner"].Value.ToString();
            IdPartner = sIDPartner;
            sPartner = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NamePartner"].Value.ToString();
            NamePartner = sPartner;
            sAddress = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["Address"].Value.ToString();
            sPhone = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["Phone"].Value.ToString();
            sCodePartner = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["CodePartner"].Value.ToString();
            fAction = true;
            this.Close();
        }

        private void gridviewDir_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ChooseCell();
        }

        private void FrmChoosePartner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4) btnAdd.PerformClick();
            //else if (e.KeyCode == Keys.F2) btnAddProducts.PerformClick();
            else if (e.KeyCode == Keys.F5) btnUpdate.PerformClick();
            else if (e.KeyCode == Keys.F6) btnSave.PerformClick();
            //else if (e.KeyCode == Keys.F7) btnPrint.PerformClick();
            else if (e.KeyCode == Keys.F8) btnDelete.PerformClick();
            else if (e.KeyCode == Keys.Escape)
            {
                if (btnSave.Enabled == true) btnCancel.PerformClick();
                else btnExit.PerformClick();
            }
        }

        private void gridviewDir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChooseCell();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down) SendKeys.Send("{TAB}");
        }

    }
}
