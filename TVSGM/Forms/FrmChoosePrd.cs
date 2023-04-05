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
    public partial class FrmChoosePrd : Form
    {
        public string sTableName;
        public static string sText = String.Empty, sIDValue;
        public string sSQL ;
        string sQuery= "SELECT * FROM Tbl" ;
        private DataTable objData;
        public Classes.clsEnums.LoaiCuaSo sType;
        TVSSys.Connection objFunc = new TVSSys.Connection();


        public FrmChoosePrd()
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
                            //txtSearch.Focus = true;
                            this.gridviewDir.AllowUserToAddRows = false;
                            this.btnUpdate.Enabled = true;
                            this.btnDelete.Enabled = true;
                            this.btnSave.Enabled = false;
                            this.btnCancel.Enabled = false;
                            break;
                        }
                    case "Update":
                        {
                            this.gridviewDir.AllowUserToAddRows = true;
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
            sSQL = "SELECT TblProducts.IdProducts,TblProducts.CodeProducts,TblProducts.Barcode,TblProductGroup.NameProductGroup," +
                    "TblProducts.NameProducts,TblUnit.IDUnit,TblUnit.NameUnit,TblProducts.PriceIn,TblProducts.PriceOut,TblProducts.NumberMin," +
                    "TblProducts.NumberMax,TblProducts.Quantitative,TblProducts.Hide,TblProducts.IDStock,TblProducts.NameSearch " +
                    "FROM TblProducts " +
                    "LEFT JOIN TblUnit on TblUnit.IDUnit=TblProducts.IDUnit " +
                    "LEFT JOIN TblProductGroup on TblProductGroup.IDProductGroup=TblProducts.IDProductGroup"+
                    " WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%' OR TblProducts.NameSearch LIKE '%" + txtSearch.Text + "%'";
            objData = objFunc.EXESelect(sSQL);
            this.gridviewDir.DataSource = objData;
            Classes.clsGridViewInterface.SetPRODUCTS(this.gridviewDir);
        }

        private void FrmChoosePrd_Load(object sender, EventArgs e)
        {
            ModeButton("Load");
            LoadForm();
        }
        #endregion

        #region add new
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //fUpdate = false;
            sIDValue = "0";
            Forms.FrmUpdProduct frm = new FrmUpdProduct();
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
            Forms.FrmUpdProduct frm = new FrmUpdProduct();
            frm.sIDValue = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IdProducts"].Value.ToString();
            frm.sCodeProducts = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["CodeProducts"].Value.ToString();
            frm.sIDGroupPrd = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameProductGroup"].Value.ToString();
            frm.sIDUnit = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameUnit"].Value.ToString();
            frm.sNameProducts = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameProducts"].Value.ToString();
            frm.sPriceIn = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["PriceIn"].Value.ToString();
            frm.sPriceOut = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["PriceOut"].Value.ToString();
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
            FrmEximProducts.sIDValue = "";
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
            if (sType == Classes.clsEnums.LoaiCuaSo.NH)
            {
                FrmEximProducts.sIDValue = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IdProducts"].Value.ToString();
                FrmEximProducts.sNameProducts = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameProducts"].Value.ToString();
                FrmEximProducts.sIDUnit = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDUnit"].Value.ToString();
                FrmEximProducts.sNameUnit = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameUnit"].Value.ToString();
                FrmEximProducts.sPrice = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["PriceIn"].Value.ToString();
            }
            else if (sType == Classes.clsEnums.LoaiCuaSo.BH)
            {
                FrmEximProducts.sIDValue = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IdProducts"].Value.ToString();
                FrmEximProducts.sNameProducts = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameProducts"].Value.ToString();
                FrmEximProducts.sIDUnit = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDUnit"].Value.ToString();
                FrmEximProducts.sNameUnit = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameUnit"].Value.ToString();
                FrmEximProducts.sPrice = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["PriceOut"].Value.ToString();
            }
            else
            {
                FrmCancelProducts.sIDValue = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IdProducts"].Value.ToString();
                FrmCancelProducts.sNameProducts = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameProducts"].Value.ToString();
                FrmCancelProducts.sIDUnit = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDUnit"].Value.ToString();
                FrmCancelProducts.sNameUnit = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameUnit"].Value.ToString();
                FrmCancelProducts.sPrice = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["PriceIn"].Value.ToString();
            }
            this.Close();
        }

        private void gridviewDir_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ChooseCell();
        }

        private void FrmChoosePrd_KeyDown(object sender, KeyEventArgs e)
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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode==Keys.Down) SendKeys.Send("{TAB}");
        }

        private void gridviewDir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChooseCell();
            }
        }

    }
}
