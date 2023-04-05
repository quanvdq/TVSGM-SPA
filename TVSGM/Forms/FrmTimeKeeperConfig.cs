using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TVSGM.Forms
{
    public partial class FrmTimeKeeperConfig : Form
    {
        TVSSys.Connection objFunc = new TVSSys.Connection();
        DataTable objData = new DataTable();
        DataTable objTable = new DataTable();
        string sQuery1;
        public FrmTimeKeeperConfig()
        {
            InitializeComponent();
        }

        private void FrmTimeKeeperConfig_Load(object sender, EventArgs e)
        {
            #region Load TimeKeeperConfig
            string sQuery = "SELECT TOP 1 * FROM TblTimeKeeperConfig";
            objData = objFunc.EXESelect(sQuery);
            for (int i = 0; i < objData.Rows.Count; i++)
            {
                txtDelay.Text = objData.Rows[i]["Delay"].ToString();
                txtHourAfternoonFinish.Text = objData.Rows[i]["HourAfternoonFinish"].ToString();
                txtHourAfternoonStart.Text = objData.Rows[i]["HourAfternoonStart"].ToString();
                txtHourFinish.Text = objData.Rows[i]["HourFinish"].ToString();
                txtHourLunchFinish.Text = objData.Rows[i]["HourLunchFinish"].ToString();
                txtHourLunchStart.Text = objData.Rows[i]["HourLunchStart"].ToString();
                txtHourMorningFinish.Text = objData.Rows[i]["HourMorningFinish"].ToString();
                txtHourMorningStart.Text = objData.Rows[i]["HourMorningStart"].ToString();
                txtHourStart.Text = objData.Rows[i]["HourStart"].ToString();
                txtNumHour.Text = objData.Rows[i]["NumHour"].ToString();
                txtNumTimekeeping.Text = objData.Rows[i]["NumTimekeeping"].ToString();
            }
            #endregion

            #region Load TimeShiftConfig
            sQuery1 = "SELECT * FROM TblTimeShiftConfig";
            objTable = objFunc.EXESelect(sQuery1);
            this.gridTimeShiftConfig.DataSource = objTable;
            Classes.clsGridViewInterface.SetTimeShiftConfig(gridTimeShiftConfig);
            #endregion
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sUpsdate = "UPDATE TblTimeKeeperConfig SET HourStart = '" + txtHourStart.Text + "' " +
                ",HourLunchStart = '" + txtHourLunchStart.Text + "' " +
                ",HourLunchFinish = '" + txtHourLunchFinish.Text + "' " +
                ",HourFinish = '" + txtHourFinish.Text + "'" +
                ",NumHour = '" + txtNumHour.Text + "' " +
                ",NumTimekeeping = '" + txtNumTimekeeping.Text + "' " +
                ",HourMorningStart = '" + txtHourMorningStart.Text + "' " +
                ",HourMorningFinish = '" + txtHourMorningFinish.Text + "' " +
                ",HourAfternoonStart = '" + txtHourAfternoonStart.Text + "' " +
                ",HourAfternoonFinish = '" + txtHourAfternoonFinish.Text + "' " +
                ",Delay = '" + txtDelay.Text + "' " +
                "WHERE ID=1";

            if (objFunc.EXEUpdate(sUpsdate) && objFunc.EXEUpdate(sQuery1, objTable)) MessageBox.Show("TVS - Cập nhật thành công!", "TVS Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
