using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TVSGM.Forms
{
    public partial class FrmUpdDir : Form
    {
        public string sTableName;
        public static string sText = String.Empty, sIDValue;
        public static bool fUpdate = false;
        public string sSQL;
        string sQuery = "SELECT * FROM Tbl";
        private DataTable objData;
        TVSSys.Connection objFunc = new TVSSys.Connection();

        public FrmUpdDir()
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
                            this.btnUpdate.Enabled = true;
                            this.btnDelete.Enabled = true;
                            this.btnSave.Enabled = false;
                            break;
                        }
                    case "Update":
                        {
                            this.gridviewDir.AllowUserToAddRows = true;
                            this.btnUpdate.Enabled = false;
                            this.btnDelete.Enabled = false;
                            this.btnSave.Enabled = true;
                            break;
                        }
                }
            }
            catch { }
        }
        #endregion

        #region Load Form
        private void LoadForm()
        {
            switch (sTableName.ToUpper())
            {
                case "UNIT":
                    {
                        sSQL = sQuery + sTableName + " WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%'";
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = ".:: KHAI BÁO ĐƠN VỊ TÍNH";
                        Classes.clsGridViewInterface.SetUNIT(this.gridviewDir);
                        break;
                    }
                case "PRODUCTGROUP":
                    {
                        sSQL = sQuery + sTableName + " WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%'";
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = ".:: KHAI BÁO NHÓM HÀNG HÓA SẢN PHẨM::.";
                        Classes.clsGridViewInterface.SetPRODUCTGROUP(this.gridviewDir);
                        break;
                    }
                case "PARTNERGROUP":
                    {
                        sSQL = sQuery + sTableName + " WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%'";
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = ".:: KHAI BÁO NHÓM KHÁCH HÀNG";
                        Classes.clsGridViewInterface.SetPARTNERGROUP(this.gridviewDir);
                        break;
                    }
                case "EMPGROUP":
                    {
                        sSQL = sQuery + sTableName + " WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%'";
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = ".:: KHAI BỘ PHẬN, PHÒNG BAN";
                        Classes.clsGridViewInterface.SetEMPGROUP(this.gridviewDir);
                        break;
                    }
            }
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        #endregion

        #region Add new
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModeButton("Update");
        }
        #endregion

        #region Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ModeButton("Update");
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
                string sIDName = gridviewDir.Columns[0].Name.ToString();
                //string sSQLDelete = "";
                switch (sTableName.ToUpper())
                {
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
                    case "PARTNERGROUP":
                        {
                            sTab = "PARTNER";
                            break;
                        }
                    case "EMPGROUP":
                        {
                            sTab = "Emp";
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

        #region Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void FrmProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4) btnAdd.PerformClick();
            else if (e.KeyCode == Keys.F6) btnSave.PerformClick();
            else if (e.KeyCode == Keys.Escape) btnClose.PerformClick();
        }

    }
}
