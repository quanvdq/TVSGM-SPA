using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Configuration;
using System.Net;
using System.IO;
using System.IO.Ports;

namespace TVSGM.Forms
{
    public partial class FrmOptionOther : Form
    {
        SerialPort SerialPort1 = new SerialPort();
        private System.Data.DataTable objData, objTabFilter, objDataSelect;
        TVSSys.Connection objFunc = new TVSSys.Connection();
        TVSSys.clsConfigXML objConfigXML = new TVSSys.clsConfigXML();
        public FrmOptionOther()
        {
            InitializeComponent();
            //MessageBox.Show(System.Configuration.ConfigurationSettings.AppSettings["UsingRoomMap"].ToString());
            try
            {
                if (System.Configuration.ConfigurationSettings.AppSettings["UsingRoomMap"].ToString() == "True")
                {
                    chkRoomMap.Checked = true;
                }
                else chkRoomMap.Checked = false;
            }
            catch { chkRoomMap.Checked = false; }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            System.Configuration.ConfigurationSettings.AppSettings.Set("UsingRoomMap", chkRoomMap.Checked.ToString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOptionOther_Load(object sender, EventArgs e)
        {
            string sQuery = "SELECT CAST(0 as BIT) as TMP, TblPartner.IDPartner,TblPartner.IDPartnerGroup,TblPartnerGroup.NamePartnerGroup,TblPartner.IDPartnerType,TblPartner.CodePartner," +
                            "TblPartner.NamePartner,TblPartner.IDGender,TblGender.NameGender,TblPartner.Birthday,TblPartner.Phone,TblPartner.Address,TblPartner.Mobile,TblPartner.Image," +
                            "TblPartner.Fax,TblPartner.CodeTax,TblPartner.Email,TblPartner.FirstBalancer,TblPartner.NameSearch,TblPartner.Note,TblPartner.[Active],TblPartner.IDEmp " +
                            "FROM TblPartner " +
                            "LEFT JOIN TblPartnerGroup ON TblPartnerGroup.IDPartnerGroup=TblPartner.IDPartnerGroup " +
                            "LEFT JOIN TblGender ON TblGender.IDGender=TblPartner.IDGender " +
                            "WHERE TblPartner.IDPartnerType=0 ";
            //AND (TblPartner.NamePartner LIKE '%" + txtSearch.Text + "%' OR TblPartner.NameSearch LIKE '%" + txtSearch.Text + "%' OR TblPartner.CodePartner ='" + txtSearch.Text.Trim() + "') ORDER BY CodePartner DESC ";
            objData = objFunc.EXESelect(sQuery);
            gridPartner.DataSource = objData;
            Classes.clsGridViewInterface.SetPartner(gridPartner);


            try
            {
                string[] sPorts = SerialPort.GetPortNames();
                foreach (string sPort in sPorts)
                {
                    comboBox1.Items.Add(sPort);
                }
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void btnCheckPort_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort1.PortName = comboBox1.Text;
                SerialPort1.BaudRate = 9600;
                SerialPort1.Parity = Parity.None;
                SerialPort1.StopBits = StopBits.One;
                SerialPort1.DataBits = 8;
                SerialPort1.Handshake = Handshake.RequestToSend;
                SerialPort1.DtrEnable = true;
                SerialPort1.RtsEnable = true;
                SerialPort1.NewLine = "\r\n";
                SerialPort1.Open();
                MessageBox.Show("Cổng đã mở","TVS - Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (SerialPort1.IsOpen)
                {
                    SerialPort1.Write("AT" + "\r\n");
                    SerialPort1.Write("AT+CMGF=1" + "\r\n");
                    SerialPort1.Write("AT+CMGS=" + (char)(34) + "0946876686" + (char)(34) + "\r\n");
                    SerialPort1.Write(txtSMS.Text + (char)(26));


                    //objTabFilter = (DataTable)this.gridPartner.DataSource;
                    //if (objTabFilter.Rows.Count > 0)
                    //{
                    //    objTabFilter.DefaultView.RowFilter = "TMP=True";
                    //    objDataSelect = objTabFilter.DefaultView.ToTable();
                    //}
                    //for (int i = 0; i < objDataSelect.Rows.Count; i++)
                    //{
                    //    SerialPort1.Write("AT" + "\r\n");
                    //    SerialPort1.Write("AT+CMGF=1" + "\r\n");
                    //    //SerialPort1.Write("AT+CMGS=" + (char)(34) + this.gridPartner.GetRowCellValue(i, "Phone").ToString() + (char)(34) + "\r\n");
                    //    MessageBox.Show(objDataSelect.Rows[i]["Phone"].ToString().Trim().Replace(".", ""));
                    //    SerialPort1.Write("AT+CMGS=" + (char)(34) + objDataSelect.Rows[i]["Phone"].ToString().Trim().Replace(".", "") + (char)(34) + "\r\n");
                    //    SerialPort1.Write(txtSMS.Text + (char)(26));
                    //    //MessageBox.Show("Gửi thành công đến số:" + this.gridPartner.GetRowCellValue(i, "Phone").ToString());
                    //}
                    ////MessageBox.Show("Gửi thành công!");

                }
                else
                {
                    MessageBox.Show("Lỗi chọn cổng");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            SerialPort1.Close();
        }
    }
}
