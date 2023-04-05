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
    public partial class FrmBirthdayPartner : Form
    {
        public int sTypeInOut;
        public string sTableName, sIDPartner, sPartner, sAddress, sPhone, sCodePartner;
        public static string sText = String.Empty, sIDValue;
        public string sSQL ;
        private DataTable objData;
        TVSSys.Connection objFunc = new TVSSys.Connection();
        public enum NhomKhachHang
        {
            KHBanBuon = 1,
            KHBanLe = 2,
            NhaCC = 3,
            KHvaNhaCC = 4   
        }

        public FrmBirthdayPartner()
        {
            InitializeComponent();
        }

        
        #region LoadForm
        private void LoadForm()
        {
            sSQL = "SELECT TblPartner.IDPartner,TblPartner.CodePartner,TblPartnerGroup.NamePartnerGroup,TblPartnerType.NamePartnerType," +
                        "TblPartner.NamePartner,TblPartner.Birthday,TblPartner.Phone,TblPartner.Address,TblPartner.Mobile,TblPartner.Fax," +
                        "TblPartner.CodeTax,TblPartner.Email,TblPartner.FirstBalancer,TblPartner.NameSearch,TblPartner.[Root],TblPartner.Note " +
                        "FROM TblPartner " +
                        "LEFT JOIN TblPartnerGroup ON TblPartnerGroup.IDPartnerGroup=TblPartner.IDPartnerGroup " +
                        "LEFT JOIN TblPartnerType ON TblPartnerType.IDPartnerType=TblPartner.IDPartnerType " +
                        " WHERE (TblPartner.IDPartnerType!= "+ (int)FrmBirthdayPartner.NhomKhachHang.NhaCC +") AND (NamePartner LIKE N'%" + txtSearch.Text + "%' OR NameSearch LIKE N'%" + txtSearch.Text + "%') AND Convert(nvarchar(5),Birthday,103)='" + DateTime.Now.ToString("dd/MM") + "'";
             //1. KH bán buôn, 2. KH bán lẻ, 3. Nhà cung cấp, 4. KH và nhà cung cấp           
            objData = objFunc.EXESelect(sSQL);
            this.gridviewDir.DataSource = objData;
            Classes.clsGridViewInterface.SetPARTNER(this.gridviewDir);
        }

        private void FrmBirthdayPartner_Load(object sender, EventArgs e)
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

        private void FrmBirthdayPartner_KeyDown(object sender, KeyEventArgs e)
        {
            btnExit.PerformClick();
        }

    }
}
