using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TVSGM.Forms
{
    public partial class frmLichHenChamSoc : Form
    {
        public frmLichHenChamSoc()
        {
            InitializeComponent();
        }
        DataTable dbtmp = new DataTable();
        DataTable dbtmp2 = new DataTable();
        string billId = "";
        private void frmLichHenChamSoc_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
             dbtmp2 = TVSSys.GlobalModule.objCon.EXESelect("select 0 as TT, (select top 1 NameProducts from TblProducts where IdProducts = TblBillDetail.IDProducts)  as NameProducts " +
                        " , TotalMoney from TblBillDetail where billID =  '" + dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells["billID1"].Value.ToString() + "'");

             for (int i = 0; i < dbtmp2.Rows.Count; i++)
            {
                dbtmp2.Rows[i]["TT"] = i + 1;
            }
            billId = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells["billID1"].Value.ToString();
            dataGridView2.DataSource = dbtmp2;

        }


        private void frmLichHenChamSoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                return;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (this.dataGridView.Rows[row.Index].Cells["Action"].Value.ToString() == "True")
                    {
                        SqlConnection Sqlcon = new SqlConnection(TVSSys.Connection.strConnection);
                        Sqlcon.Open();
                        SqlCommand cmd = Sqlcon.CreateCommand();
                        string sql = "";
                        sql = " UPDATE TblBill SET Action = '" + bool.Parse(this.dataGridView.Rows[row.Index].Cells["Action"].Value.ToString()) + "' WHERE billID = '" + this.dataGridView.Rows[row.Index].Cells["billID"].Value.ToString() + "' ";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TVSGM.Forms.frmActionCus objF = new frmActionCus();
            objF.BillId = this.billId;
            objF.ShowDialog();
            this.LoadData();
        }
        public void LoadData()
        {
            dbtmp = TVSSys.GlobalModule.objCon.EXESelect("select 0 as TT, A.billID, B.NamePartner,  B.Phone, B.Address, B.Birthday, isnull(Action,0) as Action from TblBill A left join TblPartner B " +
                                    " on A.IDPartner = B.IDPartner where convert(nvarchar,A.DateAp,112) between '" + dateSearchForm.Value.ToString("yyyyMMdd") + "' AND  '" + dateSearchTo.Value.ToString("yyyyMMdd") + "' AND B.NamePartner LIKE N'%" + txtSearch.Text.Trim() + "%' ");

            for (int i = 0; i < dbtmp.Rows.Count; i++)
            {
                dbtmp.Rows[i]["TT"] = i + 1;
            }

            dataGridView.DataSource = dbtmp;
        }

        private void dateSearchForm_ValueChanged(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void dateSearchTo_ValueChanged(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.LoadData();
        }
    }
}