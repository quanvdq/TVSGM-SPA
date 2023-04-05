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
    public partial class FrmInOut : Form
    {
        #region ...
        int fTypeInOut;
        public string sTableName, sIDPartner, sID="0";
        public static Classes.clsEnums.LoaiCuaSo sTypeReExIDM;
        public static string sText = String.Empty, sIDValue;
        public static bool fUpdate = false;
        public string sSQL, sReExIDM;
        private DataTable objData;
        TVSSys.Connection objFunc = new TVSSys.Connection();
        Classes.clsInOutBill objBill = new TVSGM.Classes.clsInOutBill();
        #endregion

        public FrmInOut()
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
                            this.btnAddPartner.Enabled = false;
                            this.btnUpdate.Enabled = true;
                            this.btnDelete.Enabled = true;
                            this.btnSave.Enabled = false;
                            this.btnCancel.Enabled = false;
                            break;
                        }
                    case "Update":
                        {
                            this.btnAdd.Enabled = false;
                            this.btnAddPartner.Enabled = true;
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

        #region method DebtPartner
        private void DebtPartner(int sIDPartner)
        {
            txtDebt.Text = objFunc.Get_EXESelectDouble("select sum(isnull(TotalPay,0)-isnull(Payed,0)) AS Debs from dbo.TblBill where IDPartner=" + sIDPartner).ToString(TVSSys.GlobalModule.objFormatMoney);
        }
        #endregion

        #region LoadForm
        private void OptionLoad()
        {
            switch (sTableName.ToUpper())
            {
                case "INMONEY":
                    {
                        fTypeInOut = 1;
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - PHIẾU THU TIỀN";
                        sTypeReExIDM = Classes.clsEnums.LoaiCuaSo.PT;
                        break;
                    }
                case "OUTMONEY":
                    {
                        fTypeInOut = 2;
                        sText = "TVS - QUẢN LÝ PHÒNG GYM - PHIẾU CHI TIỀN";
                        sTypeReExIDM = Classes.clsEnums.LoaiCuaSo.PC;
                        label16.Text = "Người nhận:";
                        label9.Text = "Người chi:";
                        break;
                    }
            }
        }

        private void LoadForm()
        {
            objData = objBill.getInOutBill(txtSearch.Text, sTypeReExIDM.ToString(), Convert.ToDateTime(dateSearchFrom.Text).ToString("MM/dd/yyyy"), Convert.ToDateTime(dateSearchTo.Text).ToString("MM/dd/yyyy"));
            this.gridviewDir.DataSource = objData;
            Classes.clsGridViewInterface.SetBillInOut(this.gridviewDir);
        }

        private void FrmInOut_Load(object sender, EventArgs e)
        {
            OptionLoad();
            ModeButton("Load");
            Classes.clsGridViewInterface.LoadCbo(cboUser, "FullName", "UserName", "Tab" + cboUser.Name.Substring(3));
            Classes.clsGridViewInterface.LoadCboWhere(cboIDInOut, cboIDInOut.Name.Substring(3), "IDTypeInOut", fTypeInOut.ToString());
            Classes.clsGridViewInterface.LoadCboDefault(cboIDEmp, cboIDEmp.Name.Substring(3));
            LoadForm();
        }
        #endregion

        #region add new
        private void btnAdd_Click(object sender, EventArgs e)
        {
            sID = "0";
            txtAddress.Text =  txtNote.Text = txtOriginalBill.Text = txtPartner.Text = txtReExIDM.Text = "";
            txtPayed.Text = txtDebt.Text = "0";
            ModeButton("Update");
        }
        #endregion

        #region OptionUpdate
        private void OptionUpdate()
        {
            if(txtReExIDM.Text=="")
            {
                //sReExIDM = Classes.clsGetBillID.NextID(sTypeReExIDM + "/" + this.dateCreate.Value.ToString("dd/MM/yyyy") + "-", "ReExIDM", dateCreate.Value.ToString("dd"), dateCreate.Value.ToString("MM"), dateCreate.Value.ToString("yyyy"), "TblBill", "ReExIDM LIKE N'%" + sTypeReExIDM + "%' AND " +
                //                                                                    "Convert(nvarchar,CreateDate,112)='" + this.dateCreate.Value.ToString("yyyyMMdd") + "'");

                sReExIDM = Classes.clsGetBillID.NextID(sTypeReExIDM + "/" + DateTime.Now.ToString("dd/MM/yyyy") + "-", "ReExIDM", DateTime.Now.ToString("dd"), DateTime.Now.ToString("MM"), DateTime.Now.ToString("yyyy"), "TblBill", "ReExIDM LIKE N'%" + sTypeReExIDM + "%' AND " +
                                                                                    "Convert(nvarchar,CreateDate,112)='" + DateTime.Now.ToString("yyyyMMdd") + "'");

            }
            else
            {
                sReExIDM = txtReExIDM.Text;
            }
        }
        #endregion

        #region Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            ModeButton("Load");
            OptionUpdate();
            objBill.UpdateInOut(int.Parse(sID), sReExIDM, sReExIDM, "", Convert.ToDateTime(DateTime.Now.ToString()), Convert.ToInt32(cboIDInOut.SelectedValue), fTypeInOut, Convert.ToInt32(sIDPartner), 0, Convert.ToDouble(txtPayed.Text), txtNote.Text, cboUser.SelectedValue.ToString(), Convert.ToDateTime(dateCreate.Text), Convert.ToInt32(cboIDEmp.SelectedValue));
            LoadForm();
        }
        #endregion

        #region Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sID = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["ID"].Value.ToString();
            if (FrmMain.sEditInOut == true)
            {
                if (FrmMain.sEditInOutYes == true ||
                    (objFunc.Get_EXESelectInt("SELECT CONVERT(NVARCHAR, DateSearch, 112) FROM TblBill WHERE DateSearch='" + dateCreate.Value.ToString("yyyyMMdd") + "'") == Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"))))
                    //&& objFunc.Get_EXESelect("SELECT CONVERT(NVARCHAR, DateSearch, 112) FROM TblBill WHERE DateSearch='" + dateExim.Value.ToString("yyyyMMdd") + "'")==""))

                {
                    fUpdate = true;
                    if (gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["OriginalBill"].Value.ToString() != "")
                    {
                        Classes.clsMessage.Error("Không thể sửa chứng từ gốc");
                    }
                    else
                    {
                        ModeButton("Update");
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

        #region Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (FrmMain.sEditInOut == true)
            {
                if (FrmMain.sEditInOutYes == true ||
                    (objFunc.Get_EXESelectInt("SELECT CONVERT(NVARCHAR, DateSearch, 112) FROM TblBill WHERE DateSearch='" + dateCreate.Value.ToString("yyyyMMdd") + "'") == Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"))))
                    //&& objFunc.Get_EXESelect("SELECT CONVERT(NVARCHAR, DateSearch, 112) FROM TblBill WHERE DateSearch='" + dateExim.Value.ToString("yyyyMMdd") + "'")==""))

                {
                    if (gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["OriginalBill"].Value.ToString() != "")
                    {
                        Classes.clsMessage.Error("Không thể xóa chứng từ gốc");
                    }
                    else
                    {
                        if (Classes.clsMessage.Question("Bạn có muốn xóa hóa đơn số:" + gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["billID"].Value.ToString() + " không?") == DialogResult.Yes)
                        {
                            Classes.clsQueryDelete.InsertTblBillDeleteID(gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["ID"].Value.ToString());
                            Classes.clsQueryDelete.EXEDelete("Bill", "ID", gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["ID"].Value.ToString());
                            //Classes.clsQueryDelete.EXEDelete("BillDetail", "BillID", gridviewBill.Rows[gridviewBill.CurrentCell.RowIndex].Cells["billID"].Value.ToString());
                            Classes.clsMessage.Information("Bạn đã xóa thành công");
                            LoadForm();
                        }
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

        #region method txtSearch_TextChanged
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadForm();
        }
        #endregion

        #region method gridviewDir_CellEnter
        private void gridviewDir_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            sID = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["P_Address"].Value.ToString();
            txtAddress.Text = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["P_Address"].Value.ToString();
            txtNote.Text = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["Note"].Value.ToString();
            txtOriginalBill.Text = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["OriginalBill"].Value.ToString();
            txtPartner.Text = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["P_Name"].Value.ToString();
            txtPayed.Text = Convert.ToString(Convert.ToDouble(gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["Payed"].Value.ToString()).ToString(TVSSys.GlobalModule.objFormatMoney));
            txtReExIDM.Text = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["ReExIDM"].Value.ToString();
            cboUser.Text = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["U_FullName"].Value.ToString();
            cboIDInOut.SelectedValue = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["I_ID"].Value.ToString();
            if (!String.IsNullOrEmpty(gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDEmp"].Value.ToString()))
            {
                cboIDEmp.SelectedValue = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDEmp"].Value.ToString();
            }
            else cboIDEmp.SelectedValue = 0;
            cboIDInOut.SelectedValue = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["I_ID"].Value.ToString();

            dateCreate.Text = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["CreateDate"].Value.ToString();
            DebtPartner(Convert.ToInt32(gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["P_ID"].Value.ToString()));
        }
        #endregion

        #region method btnAddPartner_Click
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
            DebtPartner(Convert.ToInt32(sIDPartner));
            //txtPhone.Text = frm.sPhone;
        }
        #endregion

        #region method FrmInOut_KeyDown
        private void FrmInOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4) btnAdd.PerformClick();
            else if (e.KeyCode == Keys.F2) btnAddPartner.PerformClick();
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

        #region method dateSearchFrom_ValueChanged
        private void dateSearchFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadForm();
        }
        #endregion

        #region method btnPrint_Click
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.rptReceiveBill.sBillID = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["ReExIDM"].Value.ToString();
            Reports.frmRepViewer rpt = new Reports.frmRepViewer();
            rpt.srptType = "rptReceiveBill";
            rpt.Show();
        }
        #endregion
    }
}
