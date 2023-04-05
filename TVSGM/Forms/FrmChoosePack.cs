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
    public partial class FrmChoosePack : Form
    {
        public string sTableName, sIDPartner, sIDPartnerRegis, sIDPartnerGroup, sIDPartnerType, sCodePartner, sNamePartner, sIDGender, sBirthday, sPhone, sAddress, sIDGymRoom, sIDTypeGym, sIDPackGym;
        public string sSQL ;
        public DataTable objData;
        TVSSys.Connection objFunc = new TVSSys.Connection();
        public bool fCheck=false;

        public FrmChoosePack()
        {
            InitializeComponent();
        }

        

        #region LoadForm
        private void LoadForm()
        {
            this.gridviewDir.DataSource = objData;
            Classes.clsGridViewInterface.SetChosePack(this.gridviewDir);
        }

        private void FrmChoosePack_Load(object sender, EventArgs e)
        {
            LoadForm();
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

        private void gridviewDir_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sIDPartner = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDPartner"].Value.ToString();
            sIDPartnerRegis = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDPartnerRegis"].Value.ToString();
            sIDPartnerGroup = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDPartnerGroup"].Value.ToString();
            sIDPartnerType = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDPartnerType"].Value.ToString();
            sCodePartner = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["CodePartner"].Value.ToString();
            sNamePartner = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["NamePartner"].Value.ToString();
            sIDGender = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDGender"].Value.ToString();
            sBirthday = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["Birthday"].Value.ToString();
            sPhone = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["Phone"].Value.ToString();
            sAddress = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["Address"].Value.ToString();
            sIDGymRoom = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDGymRoom"].Value.ToString();
            sIDTypeGym = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDTypeGym"].Value.ToString();
            sIDPackGym = gridviewDir.Rows[gridviewDir.CurrentCell.RowIndex].Cells["IDPackGym"].Value.ToString();
            fCheck = true;
            this.Close();
        }

        

    }
}
