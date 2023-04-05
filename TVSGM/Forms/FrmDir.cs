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
    public partial class FrmDir : Form
    {
        public string sTableName;
        public static string sText = String.Empty, sIDValue;
        public static bool fUpdate = false;
        public string sSQL ;
        string sQuery= "SELECT * FROM Tbl" ;
        private DataTable objData;
        //TVSConnect.clsCONNECT objFunc = new TVSConnect.clsCONNECT();
        TVSSys.Connection objFunc = new TVSSys.Connection();


        public FrmDir()
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
                            this.btnCancel.Enabled = false;
                            break;
                        }
                    case "Update":
                        {
                            this.gridviewDir.ReadOnly = false;
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
            switch (sTableName.ToUpper())
            {
                case "GYMROOM":
                    {
                        sSQL = sQuery + sTableName + " WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%'";
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - KHAI BÁO PHÒNG TẬP";
                        Classes.clsGridViewInterface.SetGYMROOM(this.gridviewDir);
                        break;
                    }
                case "PACKGYM":
                    {
                        sSQL = "SELECT TblPackGym.IDPackGym,TblPackGym.CodePackGym,TblPackGym.NamePackGym,TblPackGym.IDTypeGym,TblTypeGym.NameTypeGym,TblPackGym.Times,TblPackGym.Price,TblPackGym.TotalMoney FROM TblPackGym " +
                               "LEFT JOIN TblTypeGym ON TblTypeGym.IDTypeGym=TblPackGym.IDTypeGym WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%'"; 
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - KHAI BÁO GÓI TẬP";
                        Classes.clsGridViewInterface.SetPACKGYM(this.gridviewDir);
                        break;
                    }
                case "WORKOUT":
                    {
                        sSQL = sQuery + sTableName + " WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%'"; 
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - KHAI BÁO BUỔI TẬP";
                        Classes.clsGridViewInterface.SetWORKOUT(this.gridviewDir);
                        break;
                    }
                case "STORE":
                    {
                        sSQL = sQuery + sTableName + " WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%'";
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - KHAI BÁO KHO HÀNG";
                        Classes.clsGridViewInterface.SetSTORE(this.gridviewDir);
                        break;
                    }
                case "UNIT":
                    {
                        sSQL = sQuery + sTableName + " WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%'";
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - KHAI BÁO ĐƠN VỊ TÍNH";
                        Classes.clsGridViewInterface.SetUNIT(this.gridviewDir);
                        break;
                    }
                case "PRODUCTS":
                    {
                        sSQL = "SELECT TblProducts.IdProducts,TblProducts.CodeProducts,TblProducts.Barcode,TblProductGroup.NameProductGroup," +
                                "TblProducts.NameProducts,TblUnit.IDUnit,TblUnit.NameUnit,TblProducts.PriceIn,TblProducts.PriceOut,TblProducts.NumberMin," +
                                "TblProducts.NumberMax,TblProducts.Quantitative,TblProducts.Hide,TblProducts.IDStock,TblProducts.NameSearch " +
                                "FROM TblProducts " +
                                "LEFT JOIN TblUnit on TblUnit.IDUnit=TblProducts.IDUnit " +
                                "LEFT JOIN TblProductGroup on TblProductGroup.IDProductGroup=TblProducts.IDProductGroup"+
                                " WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%' OR TblProducts.NameSearch LIKE '%" + txtSearch.Text + "%' OR TblProducts.CodeProducts ='"+txtSearch.Text+"'";
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;

                        sText = "TVS - QUẢN LÝ PHÒNG GYM - KHAI BÁO HÀNG HÓA SẢN PHẨM";
                        Classes.clsGridViewInterface.SetPRODUCTS(this.gridviewDir);
                        break;
                    }
                case "PRODUCTGROUP":
                    {
                        sSQL = sQuery + sTableName + " WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%'";
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - KHAI BÁO NHÓM HÀNG HÓA SẢN PHẨM::.";
                        Classes.clsGridViewInterface.SetPRODUCTGROUP(this.gridviewDir);
                        break;
                    }
                case "INSTRUMENTS":
                    {
                        sSQL = "SELECT TblInstruments.IDInstruments,TblInstruments.CodeInstruments,TblInstruments.Barcode,TblInstruments.NameInstruments,"+
                               " TblUnit.NameUnit,TblInstruments.PriceIn,TblInstruments.PriceOut,TblInstruments.NameSearch  FROM TblInstruments "+
                               " LEFT JOIN TblUnit ON TblUnit.IDUnit=TblInstruments.IDUnit " + " WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%'"; 
                        objData = objFunc.EXESelect(sSQL); ;
                        this.gridviewDir.DataSource = objData;
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - KHAI BÁO CÔNG CỤ, DỤNG CỤ TẬP LUYỆN";
                        Classes.clsGridViewInterface.SetINSTRUMENTS(this.gridviewDir);
                        break;
                    }
                case "PARTNERGROUP":
                    {
                        sSQL = sQuery + sTableName + " WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%'";
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - KHAI BÁO NHÓM KHÁCH HÀNG";
                        Classes.clsGridViewInterface.SetPARTNERGROUP(this.gridviewDir);
                        break;
                    }

                case "PARTNER":
                    {
                        sSQL = "SELECT TblPartner.IDPartner,TblPartner.CodePartner,TblPartnerGroup.NamePartnerGroup,TblPartnerType.NamePartnerType," +
                            "TblPartner.NamePartner,TblPartner.Birthday,TblPartner.Phone,TblPartner.Address,TblPartner.Mobile,TblPartner.Fax," +
                            "TblPartner.CodeTax,TblPartner.Email,TblPartner.FirstBalancer,TblPartner.NameSearch,TblPartner.[Root],TblPartner.Note " +
                            "FROM TblPartner " +
                            "LEFT JOIN TblPartnerGroup ON TblPartnerGroup.IDPartnerGroup=TblPartner.IDPartnerGroup " +
                            "LEFT JOIN TblPartnerType ON TblPartnerType.IDPartnerType=TblPartner.IDPartnerType " +
                            " WHERE TblPartner.IDPartnerType!=0 AND (Name" + sTableName + " LIKE '%" + txtSearch.Text + "%' OR NameSearch LIKE N'%" + txtSearch.Text + "%')";
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - KHAI BÁO KHÁCH HÀNG";
                        Classes.clsGridViewInterface.SetPARTNER(this.gridviewDir);
                        break;
                    }

                case "EMPGROUP":
                    {
                        sSQL = sQuery + sTableName + " WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%'";
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - KHAI BỘ PHẬN, PHÒNG BAN";
                        Classes.clsGridViewInterface.SetEMPGROUP(this.gridviewDir);
                        break;
                    }
                case "EMP":
                    {
                        sSQL = "SELECT TblEmp.IdEmp,TblEmp.CodeEmp,TblEmpGroup.NameEmpGroup,TblEmp.NameEmp,TblEmp.Birthday,TblGender.NameGender,TblEmp.Address,TblEmp.Phone "+
                               "FROM TblEmp "+
                               "LEFT JOIN TblGender ON TblGender.IDGender=TblEmp.IDGender "+
                               "LEFT JOIN TblEmpGroup ON TblEmpGroup.IDEmpGroup=TblEmp.IDEmpGroup WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%'";
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - KHAI BỘ PHẬN, PHÒNG BAN";
                        Classes.clsGridViewInterface.SetEMP(this.gridviewDir);
                        break;
                    }
                case "INOUT":
                    {
                        sSQL = sQuery + sTableName + " WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%'";
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - KHAI BÁO CÁC KHOẢN THU CHI";
                        Classes.clsGridViewInterface.SetEMPGROUP(this.gridviewDir);
                        break;
                    }
                case "FLOOR":
                    {
                        sSQL = sQuery + sTableName + " WHERE Name" + sTableName + " LIKE '%" + txtSearch.Text + "%'";
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - KHAI BÁO TẦNG, LẦU";
                        Classes.clsGridViewInterface.SetFLOOR(this.gridviewDir);
                        break;
                    }
                case "BED":
                    {
                        sSQL = "SELECT TblBed.IdBed,TblBed.CodeBed,TblBed.NameBed,TblGymRoom.NameGymRoom,TblBed.Poss,TblBed.State,TblBed.PriceDay ,TblBed.PriceNight,TblBed.IdFloor,TblBed.IDGymRoom FROM TblBed LEFT JOIN TblFloor ON TblFloor.IdFloor=TblBed.IdFloor LEFT JOIN TblGymRoom ON TblGymRoom.IDGymRoom=TblBed.IDGymRoom";
                        objData = objFunc.EXESelect(sSQL);
                        this.gridviewDir.DataSource = objData;
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - KHAI BÁO GIƯỜNG, GHẾ";
                        Classes.clsGridViewInterface.SetBED(this.gridviewDir);
                        break;
                    }
            }
        }

        private void FrmDir_Load(object sender, EventArgs e)
        {
            ModeButton("Load");
            LoadForm();
        }
        #endregion

        #region add new
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (sTableName.ToString().ToUpper() == "PRODUCTS")
            {
                sIDValue = "0";
                Forms.FrmUpdProduct frm = new FrmUpdProduct();
                frm.fUpdate = false;
                frm.objData = objData;
                frm.j = "";
                frm.ShowDialog();
                LoadForm();
            }
            if (sTableName.ToString().ToUpper() == "BED")
            {
                sIDValue = "0";
                Forms.FrmUpdBed frm = new FrmUpdBed();
                frm.fUpdate = false;
                frm.objData = objData;
                //frm.j = "";
                frm.ShowDialog();
                LoadForm();
            }
            else if (sTableName.ToString().ToUpper() == "INSTRUMENTS")
            {
                sIDValue = "0";
                Forms.FrmUpdInstruments frm = new FrmUpdInstruments();
                frm.fUpdate = false;
                frm.ShowDialog();
                LoadForm();
            }
            else if (sTableName.ToString().ToUpper() == "PARTNER")
            {
                sIDValue = "0";
                Forms.FrmUpdPartner frm = new FrmUpdPartner();
                frm.fUpdate = false;
                frm.ShowDialog();
                LoadForm();
            }
            else if (sTableName.ToString().ToUpper() == "EMP")
            {
                sIDValue = "0";
                Forms.FrmUpdEmp frm = new FrmUpdEmp();
                frm.fUpdate = false;
                frm.ShowDialog();
                LoadForm();
            }
            else if (sTableName.ToString().ToUpper() == "PACKGYM")
            {
                sIDValue = "0";
                Forms.FrmUpdPackGym frm = new FrmUpdPackGym();
                frm.fUpdate = false;
                frm.ShowDialog();
                LoadForm();
            }
            else
            {
                ModeButton("Update");
                if (gridviewDir.Rows.Count > 0)
                {
                    this.gridviewDir.CurrentCell = this.gridviewDir.Rows[this.gridviewDir.Rows.Count-1].Cells[1];
                }
            }
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
            try
            {
                if (sTableName.ToString().ToUpper() == "INSTRUMENTS")
                {
                    Forms.FrmUpdInstruments frm = new FrmUpdInstruments();
                    frm.sIDValue = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDInstruments"].Value.ToString();
                    frm.sCodeProducts = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["CodeInstruments"].Value.ToString();
                    frm.sIDUnit = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameUnit"].Value.ToString();
                    frm.sNameProducts = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameInstruments"].Value.ToString();
                    frm.sPriceIn = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["PriceIn"].Value.ToString();
                    frm.sPriceOut = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["PriceOut"].Value.ToString();
                    frm.fUpdate = true;
                    frm.ShowDialog();
                    LoadForm();
                }
                else if (sTableName.ToString().ToUpper() == "PRODUCTS")
                {
                    Forms.FrmUpdProduct frm = new FrmUpdProduct();
                    frm.sIDValue = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IdProducts"].Value.ToString();
                    frm.sCodeProducts = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["CodeProducts"].Value.ToString();
                    frm.sIDGroupPrd = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameProductGroup"].Value.ToString();
                    frm.sIDUnit = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameUnit"].Value.ToString();
                    frm.sNameProducts = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameProducts"].Value.ToString();
                    frm.sPriceIn = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["PriceIn"].Value.ToString();
                    frm.sPriceOut = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["PriceOut"].Value.ToString();
                    frm.j = gridviewDir.CurrentCell.RowIndex.ToString();
                    frm.fUpdate = true;
                    frm.ShowDialog();
                    LoadForm();
                }
                else if (sTableName.ToString().ToUpper() == "BED")
                {
                    Forms.FrmUpdBed frm = new FrmUpdBed();
                    frm.sIDValue = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IdBed"].Value.ToString();
                    frm.sCodeBed = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["CodeBed"].Value.ToString();
                    frm.sNameBed = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameBed"].Value.ToString();
                    
                    
                    frm.sPriceDay = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["PriceDay"].Value.ToString();
                    frm.sPriceNight = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["PriceNight"].Value.ToString();
                    frm.sIDGymRoom = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDGymRoom"].Value.ToString();
                    frm.sNameGymRoom = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameGymRoom"].Value.ToString();
                    
                    frm.fUpdate = true;
                    frm.ShowDialog();
                    LoadForm();
                }
                else if (sTableName.ToString().ToUpper() == "PARTNER")
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
                else if (sTableName.ToString().ToUpper() == "EMP")
                {
                    Forms.FrmUpdEmp frm = new FrmUpdEmp();
                    frm.sIDValue = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IdEmp"].Value.ToString();
                    frm.sCodeEmp = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["CodeEmp"].Value.ToString();
                    frm.sIDEmpGroup = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameEmpGroup"].Value.ToString();
                    frm.sNameEmp = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameEmp"].Value.ToString();
                    frm.sIDGender = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NameGender"].Value.ToString();
                    frm.sBirthday = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["Birthday"].Value.ToString();
                    frm.sAddress = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["Address"].Value.ToString();
                    frm.sPhone = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["Phone"].Value.ToString();
                    frm.fUpdate = true;
                    frm.ShowDialog();
                    LoadForm();
                }

                else if (sTableName.ToString().ToUpper() == "PACKGYM")
                {
                    Forms.FrmUpdPackGym frm = new FrmUpdPackGym();

                    frm.sIDPackGym = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDPackGym"].Value.ToString();
                    frm.sCodePackGym = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["CodePackGym"].Value.ToString();
                    frm.sNamePackGym = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NamePackGym"].Value.ToString();
                    frm.sTypePackGym = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDTypeGym"].Value.ToString();
                    frm.sTimes = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["Times"].Value.ToString();
                    frm.sPrice = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["Price"].Value.ToString();
                    frm.sTotalMoney = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["TotalMoney"].Value.ToString();
                    frm.fUpdate = true;
                    frm.ShowDialog();
                    LoadForm();
                }

                else
                {
                    ModeButton("Update");
                }
            }
            catch {
                Classes.clsMessage.Error("Bạn chưa chọn danh mục để sửa");
            }
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
                            sTab = "PARTNERREGIS";
                            break;
                        }
                    case "PACKGYM":
                        {
                            sTab = "PARTNERREGIS";
                            break;
                        }
                    case "WORKOUT":
                        {
                            sTab = "PARTNERREGIS";
                            break;
                        }
                    case "STORE":
                        {
                            sTab = "Bill";
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
                            sTab = "BillDetail";
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
                            sTab = "Bill";
                            break;
                        }
                    case "EMPGROUP":
                        {
                            sTab = "Emp";
                            break;
                        }
                    case "EMP":
                        {
                            sTab = "PARTNER";
                            break;
                        }
                }
                if (Classes.clsQueryDelete.GymRoom(sIDValue, sIDName, sTab))
                {
                    Classes.clsMessage.Error("Lỗi. Dữ liệu này đang được sử dụng");
                    return;
                }

                if (Classes.clsQueryDelete.EXEDelete(sTableName, sIDName, sIDValue))
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadForm();
        }

        #region Hotkey
        private void FrmDir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4) btnAdd.PerformClick();
            //else if (e.KeyCode == Keys.F2) btnChoose.PerformClick();
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
        #endregion

       
    }

}
