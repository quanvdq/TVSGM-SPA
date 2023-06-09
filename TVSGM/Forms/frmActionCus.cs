using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TVSGM.Forms
{
    public partial class frmActionCus : Form
    {
        public frmActionCus()
        {
            InitializeComponent();
        }
        public string BillId = "";
        DataTable tmp = new DataTable();
        private void frmActionCus_Load(object sender, EventArgs e)
        {
            tmp = TVSSys.GlobalModule.objCon.EXESelect("SELECT ISNULL(Action,0) AS Action, NoteAction FROM TblBill WHERE billID = '" + BillId + "'");
            txtNote.Text = tmp.Rows[0]["NoteAction"].ToString();
            chkAction.Checked = bool.Parse(tmp.Rows[0]["Action"].ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TVSSys.GlobalModule.objCon.EXEUpdate("UPDATE TblBill SET Action = '" + chkAction.Checked + "', NoteAction = N'" + txtNote.Text.Trim() + "' WHERE billID = '" + BillId + "' ");
            MessageBox.Show("Cập nhật thành công","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}