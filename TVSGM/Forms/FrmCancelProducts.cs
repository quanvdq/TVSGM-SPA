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
    public partial class FrmCancelProducts : Form
    {
        int sTypeInOut;
        string sIDPartner, sID;
        public string sTableName;
        public static Classes.clsEnums.LoaiCuaSo sType, sTypeReExIDM;
        public static string sText = String.Empty, sIDValue, sNameProducts, sIDUnit, sNameUnit, sPrice;
        public static bool fUpdate = false;
        public string sSQL ;
        DataTable objDataBill =new DataTable();
        DataTable objDataBillDetail=new DataTable();
        TVSSys.Connection objFunc = new TVSSys.Connection();
        Classes.clsEximPrd objBill = new TVSGM.Classes.clsEximPrd();


        public FrmCancelProducts()
        {
            InitializeComponent();
        }

        #region TextChanged
        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
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
            double sum = 0;
            for (int i = 0; i < gridviewBillDetail.Rows.Count; i++)
            {
                sum += Convert.ToDouble(gridviewBillDetail.Rows[i].Cells["TotalMoney"].Value);
            }
            txtTotalMoney.Text = sum.ToString(TVSSys.GlobalModule.objFormatMoney);
            
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
                            this.btnUpdate.Enabled = true;
                            this.btnDelete.Enabled = true;
                            this.btnSave.Enabled = false;
                            this.btnCancel.Enabled = false;
                            break;
                        }
                    case "Update":
                        {
                            txtBillID.Text = txtNote.Text = String.Empty;
                            txtTotalMoney.Text = "0";
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
            Classes.clsGridViewInterface.LoadCbo(cboUserName, "FullName", "UserName", "TabUser");

            objDataBill = objBill.getDataCancelBill(Convert.ToDateTime(dateSearchForm.Text).ToString("MM/dd/yyyy"), Convert.ToDateTime(dateSearchTo.Text).ToString("MM/dd/yyyy"), sType.ToString());
            this.gridviewBill.DataSource = objDataBill;
            Classes.clsGridViewInterface.SetCancelBill(this.gridviewBill);
        }
        #endregion

        #region LoadForm
        private void LoadForm()
        {
            LoadBill();
        }

        private void FrmCancelProducts_Load(object sender, EventArgs e)
        {

            sType = Classes.clsEnums.LoaiCuaSo.XH;
            ModeButton("Load");
            LoadForm();
        }
        #endregion

        #region Add new
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fUpdate = false;
            LoadBillDetail("");
            ModeButton("Update");
        }
        #endregion

        #region Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            ModeButton("Load");

            if (gridviewBillDetail.Rows.Count < 1) Classes.clsMessage.Error("Bạn chưa chọn sản phẩm");
            OptionUpdate();
            objBill.EXEUpdateBill(int.Parse(gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["ID"].Value.ToString()), sBillID, sReExIDM, Convert.ToDateTime(dateExim.Text), sTypeInOut, 0, sBillID, Convert.ToInt32(sIDPartner), Convert.ToDouble(txtTotalMoney.Text), 0, 0, 0, 0, txtNote.Text, Convert.ToString(cboUserName.SelectedValue), 1, Convert.ToDateTime(dateExim.Text));

            for (int i = 0; i < gridviewBillDetail.Rows.Count; i++)
            {
                objBill.EXEUpdateBillDetail(Convert.ToInt32(gridviewBillDetail.Rows[i].Cells["ID"].Value), sBillID, Convert.ToInt32(gridviewBillDetail.Rows[i].Cells["IDProducts"].Value), Convert.ToInt32(gridviewBillDetail.Rows[i].Cells["IDUnit"].Value), Convert.ToDouble(gridviewBillDetail.Rows[i].Cells["Number"].Value), Convert.ToDouble(gridviewBillDetail.Rows[i].Cells["Price"].Value), Convert.ToDouble(gridviewBillDetail.Rows[i].Cells["TotalMoney"].Value),Convert.ToDateTime(dateExim.Value.ToString()),Convert.ToDateTime(dateExim.Value.ToString()));
            }


            LoadForm();
        }
        #endregion

        #region Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            fUpdate = true;
            ModeButton("Update");
        }
        #endregion

        #region Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Classes.clsMessage.Question("Bạn có muốn xóa hóa đơn số:" + gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["billID"].Value.ToString() + " không?") == DialogResult.Yes)
            {
                Classes.clsQueryDelete.EXEDelete("Bill", "ID", sID);
                Classes.clsQueryDelete.EXEDelete("BillDetail", "BillID", gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["billID"].Value.ToString());
                Classes.clsMessage.Information("Bạn đã xóa thành công");
                LoadBill();

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
            frm.ShowDialog();
            double dblNumber = 1;
            bool bolCheck = false;
            
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
            this.gridviewBillDetail.DataSource = objDataBillDetail;
            SumTotalMoney();
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
                txtBillID.Text = gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["billID"].Value.ToString();
                txtNote.Text = gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["Note"].Value.ToString();
                txtTotalMoney.Text = Convert.ToString(Convert.ToDouble(gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["TotalMoney"].Value.ToString()).ToString(TVSSys.GlobalModule.objFormatMoney));
                LoadBillDetail(txtBillID.Text);
            }
            catch { }
        }
        #endregion

        #region HotKey
        private void FrmCancelProducts_KeyDown(object sender, KeyEventArgs e)
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
                }
            }
            catch { }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.rptCancelBillA5.objTable = objDataBill;
            Reports.rptCancelBillA5.objTableDetails = objDataBillDetail;
            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptCancelBillA5";
            rpt.Show();
        }


    }
}
