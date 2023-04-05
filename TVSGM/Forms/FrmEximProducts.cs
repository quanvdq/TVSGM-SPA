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
    public partial class FrmEximProducts : Form
    {
        public int fTypeInOut;
        string sIDPartner, sID="0";
        public string sTableName;
        public static Classes.clsEnums.LoaiCuaSo sType, sTypeReExIDM;
        public static string sText = String.Empty, sIDValue, sNameProducts, sIDUnit, sNameUnit, sPrice;
        public static bool fUpdate = false;
        public string sSQL ;
        DataTable objDataBill =new DataTable();
        DataTable objDataBillDetail=new DataTable();
        DataTable objData = new DataTable();
        private bool sload = false;
        TVSSys.Connection objFunc = new TVSSys.Connection();
        Classes.clsEximPrd objBill = new TVSGM.Classes.clsEximPrd();


        public FrmEximProducts()
        {
            InitializeComponent();
        }
        double dblTotalMoney, dblPromotionMoney, dblPromotionPercent, dblTotalPay;
        #region Calculation MoneyPay
        private void CalMoney()
        {
            if (String.IsNullOrEmpty(txtTotalMoney.Text)) return;
            if (String.IsNullOrEmpty(txtPromotionMoney.Text)) return;
            if (String.IsNullOrEmpty(txtTotalPay.Text)) return;
            if (String.IsNullOrEmpty(txtPromotionPercent.Text)) return;
            dblTotalMoney = double.Parse(txtTotalMoney.Text);
            dblPromotionMoney = double.Parse(txtPromotionMoney.Text);
            dblPromotionPercent= double.Parse(txtPromotionPercent.Text);
            dblTotalPay = dblTotalMoney - (dblTotalMoney*dblPromotionPercent)/100 - dblPromotionMoney;
            txtTotalPay.Text = dblTotalPay.ToString(TVSSys.GlobalModule.objFormatMoney);
            txtPayed.Text = dblTotalPay.ToString(TVSSys.GlobalModule.objFormatMoney);
        }
        #endregion

        #region TextChanged
        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!this.sload)
            {
                this.CalMoney();
            }
        }
        #endregion

        #region OptionUpdate
        string sBillID, sReExIDM="";
        private void OptionUpdate()
        {
            if (fUpdate == false)
            {
                sBillID = Classes.clsGetBillID.NextID(sType + "/" + this.dateExim.Value.ToString("dd/MM/yyyy") + "-", "billID", dateExim.Value.ToString("dd"), dateExim.Value.ToString("MM"), dateExim.Value.ToString("yyyy"), "TblBill", "billID LIKE N'%" + sType + "%' AND " +
                                                                                    "Convert(nvarchar,CreateDate,112)='" + this.dateExim.Value.ToString("yyyyMMdd") + "'");

            }
            else
            {
                sBillID = txtBillID.Text;
            }
        }
        #endregion

        #region SumTotalMoney
        private void SumTotalMoney()
        {
            double sumTotalDetail = 0;

            for (int i = 0; i < gridviewBillDetail.Rows.Count; i++)
            {
                sumTotalDetail += Convert.ToDouble(gridviewBillDetail.Rows[i].Cells["TotalMoney"].Value);
            }
            txtTotalMoney.Text = sumTotalDetail.ToString(TVSSys.GlobalModule.objFormatMoney);

            double sumTotalPay = 0;

            for (int i = 0; i < gridviewBill.Rows.Count; i++)
            {
                sumTotalPay += Convert.ToDouble(gridviewBill.Rows[i].Cells["TotalPay"].Value);
            }
            txtTotalBill.Text = sumTotalPay.ToString(TVSSys.GlobalModule.objFormatMoney);

            double sumTotalPayed = 0;

            for (int i = 0; i < gridviewBill.Rows.Count; i++)
            {
                sumTotalPayed += Convert.ToDouble(gridviewBill.Rows[i].Cells["Payed"].Value);
            }
            txtTotalPayed.Text = sumTotalPayed.ToString(TVSSys.GlobalModule.objFormatMoney);
        }
        #endregion

        #region ModeButton
        private void ModeButton(string sOption)
        {
            try
            {
                switch (sOption)
                {
                    case "Load":
                        {
                            //this.btnAdd.Focus = true;
                            this.txtSCodePrd.Enabled = false;
                            this.btnAdd.Enabled = true;
                            this.btnUpdate.Enabled = true;
                            this.btnDelete.Enabled = true;
                            this.btnSave.Enabled = false;
                            this.btnCancel.Enabled = false;
                            this.btnAddProducts.Enabled = false;
                            break;
                        }
                    case "Update":
                        {
                            this.txtSCodePrd.Enabled = true;
                            this.btnAdd.Enabled = false;
                            this.btnUpdate.Enabled = false;
                            this.btnDelete.Enabled = false;
                            this.btnSave.Enabled = true;
                            this.btnCancel.Enabled = true;
                            this.btnAddProducts.Enabled = true;
                            break;
                        }
                }
            }
            catch { }
        }
        #endregion

        #region LoadBillDetail
        //gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["billID"].Value.ToString()
        private void LoadBillDetail(string sWhere)
        {
            objDataBillDetail = objBill.getDataBillDetail(sWhere);
            this.gridviewBillDetail.DataSource = objDataBillDetail;
            Classes.clsGridViewInterface.SetBillDetail(this.gridviewBillDetail);
        }
        #endregion

        #region LoadBill
        private void LoadBill()
        {
            switch (sTableName.ToUpper())
            {
                case "IMPORT":
                    {
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - NHẬP HÀNG";
                        sType = Classes.clsEnums.LoaiCuaSo.NH;
                        sTypeReExIDM = Classes.clsEnums.LoaiCuaSo.PC;
                        fTypeInOut = 2;
                        break;
                    }
                case "EXPORT":
                    {
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - BÁN HÀNG";
                        sType = Classes.clsEnums.LoaiCuaSo.BH;
                        sTypeReExIDM = Classes.clsEnums.LoaiCuaSo.PT;
                        fTypeInOut = 1;
                        break;
                    }
            }
            this.sload = true;
            objDataBill = objBill.getDataBill(txtPartner.Text, txtAddress.Text, txtSearchPartner.Text, txtSearchAddress.Text,
                                        Convert.ToDateTime(dateSearchForm.Text).ToString("MM/dd/yyyy"),
                                        Convert.ToDateTime(dateSearchTo.Text).ToString("MM/dd/yyyy"), sType.ToString(),"");
            this.gridviewBill.DataSource = objDataBill;
            Classes.clsGridViewInterface.SetBill(this.gridviewBill);

            SumTotalMoney();
            this.sload = false;
        }
        #endregion

        #region LoadForm
        private void LoadForm()
        {
            LoadBill();
        }

        private void DebtPartner(int sIDPartner)
        {
            txtDeb.Text = objFunc.Get_EXESelectDouble("SELECT SUM(isnull(TotalPay,0)-isnull(Payed,0)) AS Debs FROM TblBill WHERE IDPartner=" + sIDPartner).ToString();
        }

        private void FrmEximProducts_Load(object sender, EventArgs e)
        {
            cboUserName.Text = TVSSys.GlobalModule.objUserFullName.ToString();
            ModeButton("Load");
            LoadForm();
            
        }
        #endregion

        #region Add new
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModeButton("Update");
            LoadBillDetail("");
            this.btnAddPartner.PerformClick();
            fUpdate = false;
            txtBillID.Text = sReExIDM = "";
            txtPayed.Text = txtDeb.Text = txtPromotionMoney.Text = txtPromotionPercent.Text = txtTotalMoney.Text = txtTotalPay.Text = "0";
        }
        #endregion

        #region Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            ModeButton("Load");

            if (txtPartner.Text == String.Empty) Classes.clsMessage.Error("Bạn chưa chọn đối tác");
            if (gridviewBillDetail.Rows.Count < 1) Classes.clsMessage.Error("Bạn chưa chọn sản phẩm");
            OptionUpdate();
            if ((txtPayed.Text != "0") && (sReExIDM == ""))
            {
                sReExIDM = Classes.clsGetBillID.NextID(sTypeReExIDM + "/" + this.dateExim.Value.ToString("dd/MM/yyyy") + "-", "ReExIDM", this.dateExim.Value.ToString("dd"), this.dateExim.Value.ToString("MM"), this.dateExim.Value.ToString("yyyy"), "TblBill", "ReExIDM LIKE N'%" + sTypeReExIDM + "%' AND " +
                                                                                    "Convert(nvarchar,CreateDate,112)='" + this.dateExim.Value.ToString("yyyyMMdd") + "'");
            }
            objBill.EXEUpdateBill(int.Parse(sID), sBillID, sReExIDM, Convert.ToDateTime(DateTime.Now.ToString()), fTypeInOut, fTypeInOut, sBillID, Convert.ToInt32(sIDPartner), Convert.ToDouble(txtTotalMoney.Text), Convert.ToDouble(txtPromotionMoney.Text), Convert.ToDouble(txtPromotionPercent.Text), Convert.ToDouble(txtTotalPay.Text), Convert.ToDouble(txtPayed.Text), txtNote.Text, TVSSys.GlobalModule.objUserName, 1, Convert.ToDateTime(dateExim.Text));

            new Classes.clsInOutBill().UpdateDateAp(dtNgayHen.Value, sBillID);

            for (int i = 0; i < gridviewBillDetail.Rows.Count; i++)
            {
                objBill.EXEUpdateBillDetail(Convert.ToInt32(gridviewBillDetail.Rows[i].Cells["ID"].Value), sBillID, Convert.ToInt32(gridviewBillDetail.Rows[i].Cells["IDProducts"].Value), Convert.ToInt32(gridviewBillDetail.Rows[i].Cells["IDUnit"].Value), Convert.ToDouble(gridviewBillDetail.Rows[i].Cells["Number"].Value), Convert.ToDouble(gridviewBillDetail.Rows[i].Cells["Price"].Value), Convert.ToDouble(gridviewBillDetail.Rows[i].Cells["TotalMoney"].Value), Convert.ToDateTime(dateExim.Value.ToString()), Convert.ToDateTime(dateExim.Value.ToString()));
            }


            LoadForm();
        }
        #endregion

        #region Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (FrmMain.sEditExim == true)
            {
                if (FrmMain.sEditEximYes == true || 
                    (objFunc.Get_EXESelectInt("SELECT CONVERT(NVARCHAR, DateSearch, 112) FROM TblBill WHERE DateSearch='" + dateExim.Value.ToString("yyyyMMdd") + "'")==Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"))))
                    //&& objFunc.Get_EXESelect("SELECT CONVERT(NVARCHAR, DateSearch, 112) FROM TblBill WHERE DateSearch='" + dateExim.Value.ToString("yyyyMMdd") + "'")==""))

                {
                    fUpdate = true;
                    ModeButton("Update");
                }
                else
                {
                    Classes.clsMessage.Warning("Bạn không có quyền để thực hiện chức năng này");
                }
            }
            else
            {
                Classes.clsMessage.Warning("Bạn không có quyền để thực hiện chức năng này");
            }
        }
        #endregion

        #region Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (FrmMain.sEditExim == true)
            {
                if (FrmMain.sEditEximYes == true || 
                    (objFunc.Get_EXESelectInt("SELECT CONVERT(NVARCHAR, DateSearch, 112) FROM TblBill WHERE DateSearch='" + dateExim.Value.ToString("yyyyMMdd") + "'")==Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"))))
                    //&& objFunc.Get_EXESelect("SELECT CONVERT(NVARCHAR, DateSearch, 112) FROM TblBill WHERE DateSearch='" + dateExim.Value.ToString("yyyyMMdd") + "'")==""))

                {
                    if (Classes.clsMessage.Question("Bạn có muốn xóa hóa đơn số:" + gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["billID"].Value.ToString() + " không?") == DialogResult.Yes)
                    {
                        Classes.clsQueryDelete.InsertTblBillDeleteID(sID);
                        Classes.clsQueryDelete.InsertTblBillDetailDel(gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["billID"].Value.ToString());
                        Classes.clsQueryDelete.EXEDelete("Bill", "ID", sID);
                        Classes.clsQueryDelete.EXEDelete("BillDetail", "BillID", gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["billID"].Value.ToString());
                        Classes.clsMessage.Information("Bạn đã xóa thành công");
                        LoadBill();
                    }
                }
                else
                {
                    Classes.clsMessage.Warning("Bạn không có quyền để thực hiện chức năng này");
                }
            }
            else
            {
                Classes.clsMessage.Warning("Bạn không có quyền để thực hiện chức năng này");
            }
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

        #region btnAddProducts
        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            FrmChoosePrd frm = new FrmChoosePrd();
            frm.sTableName = "Products";
            frm.Text = "TVS - QUẢN LÝ PHÒNG GYM - CHỌN HÀNG HÓA SẢN PHẨM";
            frm.sType = sType;
            frm.ShowDialog();
            double dblNumber = 1;
            bool bolCheck = false;
            if (String.IsNullOrEmpty(sIDValue)==false)
            {
                if (gridviewBillDetail.RowCount > 0)
                {
                    for (int i = 0; i < gridviewBillDetail.RowCount; i++)
                    {
                        if (gridviewBillDetail.Rows[i].Cells["IdProducts"].Value.ToString() == sIDValue)
                        {
                            dblNumber = double.Parse(gridviewBillDetail.Rows[i].Cells["Number"].Value.ToString());
                            double dblPrice = double.Parse(gridviewBillDetail.Rows[i].Cells["Price"].Value.ToString());
                            gridviewBillDetail.Rows[i].Cells["Number"].Value = dblNumber + 1;
                            gridviewBillDetail.Rows[i].Cells["TotalMoney"].Value = (dblNumber + 1) * dblPrice;
                            bolCheck = true;
                            break;
                        }
                    }
                    if (!bolCheck)
                    {
                        objDataBillDetail.Rows.Add(0, txtBillID.Text, sIDValue, sNameProducts, sIDUnit, sNameUnit, 1, sPrice, sPrice, "");
                    }
                }
                else
                {
                    objDataBillDetail.Rows.Add(0, txtBillID.Text, sIDValue, sNameProducts, sIDUnit, sNameUnit, 1, sPrice, sPrice, "thong");
                }
            }
            this.gridviewBillDetail.DataSource = objDataBillDetail;
            SumTotalMoney();
            CalMoney();
        }
        #endregion

        #region AddPartner
        private void btnAddPartner_Click(object sender, EventArgs e)
        {
            FrmChoosePartner frm = new FrmChoosePartner();
            frm.sTableName = "Partner";
            frm.sTypeInOut = fTypeInOut;
            frm.Text = "TVS - QUẢN LÝ PHÒNG GYM - CHỌN KHÁCH HÀNG, NHÀ CUNG CẤP";
            frm.ShowDialog();
            
            sIDPartner = frm.sIDPartner;
            txtPartner.Text = frm.sPartner;
            txtAddress.Text = frm.sAddress;
            txtPhone.Text = frm.sPhone;
            DebtPartner(Convert.ToInt32(sIDPartner));
        }
        #endregion

        #region dateValueChanged
        private void dateValueChanged(object sender, EventArgs e)
        {
            LoadBill();
        }
        #endregion

        #region SearchTextChange
        private void Search_TextChanged(object sender, EventArgs e)
        {
            LoadBill();
        }
        #endregion

        #region gridviewBill_CellEnter
        private void gridviewBill_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                sID = gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["ID"].Value.ToString();
                sIDPartner = gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["IDPartner"].Value.ToString();
                txtPartner.Text = objFunc.Get_EXESelect("SELECT NamePartner FROM TblPartner WHERE IDPartner=" + sIDPartner);
                txtAddress.Text = gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["Address"].Value.ToString();
                txtBillID.Text = gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["billID"].Value.ToString();
                txtNote.Text = gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["Note"].Value.ToString();
                txtPartner.Text = gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["NamePartner"].Value.ToString();
                txtPayed.Text = Convert.ToString(Convert.ToDouble(gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["Payed"].Value.ToString()).ToString(TVSSys.GlobalModule.objFormatMoney));
                txtPhone.Text = gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["Phone"].Value.ToString();
                txtPromotionMoney.Text = Convert.ToString(Convert.ToDouble(gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["PromotionMoney"].Value.ToString()).ToString(TVSSys.GlobalModule.objFormatMoney));
                txtPromotionPercent.Text = Convert.ToString(Convert.ToDouble(gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["PromotionPercent"].Value.ToString()).ToString(TVSSys.GlobalModule.objFormatMoney));
                txtTotalMoney.Text = Convert.ToString(Convert.ToDouble(gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["TotalMoney"].Value.ToString()).ToString(TVSSys.GlobalModule.objFormatMoney));
                txtTotalPay.Text = Convert.ToString(Convert.ToDouble(gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["TotalPay"].Value.ToString()).ToString(TVSSys.GlobalModule.objFormatMoney));
                dateExim.Text = gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["CreateDate"].Value.ToString();

                try
                {
                    dtNgayHen.Value = DateTime.Parse(objFunc.Get_EXESelect("SELECT DateAp FROM TblBill WHERE billID='"+txtBillID.Text.Trim()+"'"));
                }
                catch { dtNgayHen.Value = DateTime.Now; }
                if (sIDPartner != "")
                DebtPartner(Convert.ToInt32(sIDPartner));
                LoadBillDetail(txtBillID.Text);
                SumTotalMoney();
                //CalMoney();
            }
            catch { }
        }
        #endregion

        #region HotKey
        private void FrmEximProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4) btnAdd.PerformClick();
            else if (e.KeyCode == Keys.F2) btnAddProducts.PerformClick();
            else if (e.KeyCode == Keys.F5) btnUpdate.PerformClick();
            else if (e.KeyCode == Keys.F6) btnSave.PerformClick();
            //else if (e.KeyCode == Keys.F7) btnPrint.PerformClick();
            else if (e.KeyCode == Keys.F8) btnDelete.PerformClick();
            else if (e.KeyCode == Keys.Escape)
            {
                if (btnSave.Enabled == true) btnCancel.PerformClick();
                else btnExit.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (btnUpdate.Enabled == false)
                {
                    if (Classes.clsMessage.Question("Bạn có muốn xóa sản phẩm này khỏi hóa đơn không?") == DialogResult.Yes)
                    {
                        if (txtBillID.Text != "")
                        {
                            Classes.clsQueryDelete.EXEDelete("BillDetail", "ID", gridviewBillDetail.Rows[gridviewBillDetail.CurrentCell.RowIndex].Cells["ID"].Value.ToString());
                            LoadBillDetail(txtBillID.Text);
                            SumTotalMoney();
                            CalMoney();
                        }
                        else
                        {
                            objDataBillDetail.Rows.RemoveAt(gridviewBillDetail.CurrentCell.RowIndex);
                        }
                    }
                }
            }
        }
        #endregion
       
        private void gridviewBillDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(6) || e.ColumnIndex.Equals(7))
                {
                    double TotalMoney = Convert.ToDouble(Convert.ToInt32(gridviewBillDetail["Number", e.RowIndex].Value) * Convert.ToDouble(gridviewBillDetail["Price", e.RowIndex].Value));
                    gridviewBillDetail["TotalMoney", e.RowIndex].Value = TotalMoney.ToString();
                    SumTotalMoney();
                    CalMoney();
                }
            }
            catch { }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.rptEximBillA5.objTable = objBill.getDataBill(txtPartner.Text, txtAddress.Text, txtSearchPartner.Text, txtSearchAddress.Text,
                                        Convert.ToDateTime(dateSearchForm.Text).ToString("MM/dd/yyyy"),
                                        Convert.ToDateTime(dateSearchTo.Text).ToString("MM/dd/yyyy"), sType.ToString(), this.txtBillID.Text.Trim());
            Reports.rptEximBillA5.objTableDetails = objDataBillDetail;
            if (sTableName.ToUpper() == "IMPORT") Reports.rptEximBillA5.srptTitle = "HÓA ĐƠN NHẬP HÀNG";
            else Reports.rptEximBillA5.srptTitle = "HÓA ĐƠN BÁN HÀNG";
            
            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptEximBillA5";
            rpt.Show();
        }

        private void txtSCodePrd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sQuery = String.Empty;
                sQuery = "SELECT TblProducts.IdProducts,TblProducts.NameProducts,TblProducts.IDUnit,TblUnit.NameUnit,TblProducts.PriceIn,TblProducts.PriceOut FROM TblProducts  LEFT JOIN TblUnit ON TblProducts.IDUnit=TblUnit.IDUnit WHERE TblProducts.CodeProducts= '" + txtSCodePrd.Text.Trim() +"'";
                objData = objFunc.EXESelect(sQuery);
                if (objData.Rows.Count > 0)
                {
                    if (sType == Classes.clsEnums.LoaiCuaSo.NH)
                    {
                        sPrice = objData.Rows[0]["PriceIn"].ToString();
                    }
                    else if (sType == Classes.clsEnums.LoaiCuaSo.BH)
                    {
                        sPrice = objData.Rows[0]["PriceOut"].ToString();
                    }
                    else
                    {
                        sPrice = objData.Rows[0]["PriceIn"].ToString();
                    }

                    double dblNumber = 1;
                    bool bolCheck = false;

                    if (gridviewBillDetail.RowCount > 0)
                    {
                        for (int i = 0; i < gridviewBillDetail.RowCount; i++)
                        {
                            if (gridviewBillDetail.Rows[i].Cells["IdProducts"].Value.ToString() == objData.Rows[0]["IdProducts"].ToString())
                            {
                                dblNumber = double.Parse(gridviewBillDetail.Rows[i].Cells["Number"].Value.ToString());
                                double dblPrice = double.Parse(gridviewBillDetail.Rows[i].Cells["Price"].Value.ToString());
                                gridviewBillDetail.Rows[i].Cells["Number"].Value = dblNumber + 1;
                                gridviewBillDetail.Rows[i].Cells["TotalMoney"].Value = (dblNumber + 1) * dblPrice;
                                bolCheck = true;
                                break;
                            }
                        }
                        if (!bolCheck)
                        {
                            objDataBillDetail.Rows.Add(0, txtBillID.Text, objData.Rows[0]["IdProducts"].ToString(), objData.Rows[0]["NameProducts"].ToString(), objData.Rows[0]["IDUnit"].ToString(), objData.Rows[0]["NameUnit"].ToString(), 1, sPrice, sPrice, "");
                        }
                    }
                    else
                    {
                        objDataBillDetail.Rows.Add(0, txtBillID.Text, objData.Rows[0]["IdProducts"].ToString(), objData.Rows[0]["NameProducts"].ToString(), objData.Rows[0]["IDUnit"].ToString(), objData.Rows[0]["NameUnit"].ToString(), 1, sPrice, sPrice, "thong");
                    }
                    this.gridviewBillDetail.DataSource = objDataBillDetail;
                    SumTotalMoney();
                    CalMoney();
                }
                else Classes.clsMessage.Error("Mã sản phẩm không tồn tại. Xin vui lòng kiểm tra lại!");
                txtSCodePrd.Text = "";
            }
        }

    }
}
