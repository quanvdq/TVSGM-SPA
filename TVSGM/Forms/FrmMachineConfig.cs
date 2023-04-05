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

namespace TVSGM.Forms
{
    public partial class FrmMachineConfig : Form
    {
        TVSTimeKeeper.clsCzkem objCZKEM = new TVSTimeKeeper.clsCzkem(); 
        TVSSys.clsConfigXML objConfigXML = new TVSSys.clsConfigXML();
        public FrmMachineConfig()
        {
            InitializeComponent();
            //if (System.Configuration.ConfigurationSettings.AppSettings["Using"].ToString() == "True")
            //{
            //    chkUsing.Checked = true;
            //}
            //else chkUsing.Checked = false;
            txtAddressIP.Text = TVSSys.GlobalModule.objXML.GetKey("AddressIP");
            txtPort.Text = TVSSys.GlobalModule.objXML.GetKey("Port");
            txtNumberMachine.Text =  TVSSys.GlobalModule.objXML.GetKey("MachineNumber");



            
        }

        private void FrmTimeKeeperConfig_Load(object sender, EventArgs e)
        {
            if (TVSSys.GlobalModule.objXML.GetKey("Using") == "True") 
                btnConnect.Text = "Ngắt kết nối";
            else 
                btnConnect.Text = "Kết nối";
        }

        public static bool ValidateIP(string addrString)
        {
            IPAddress address;
            if (IPAddress.TryParse(addrString, out address))
                return true;
            else
                return false;
        }

        public static bool PingTheDevice(string ipAdd)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse(ipAdd);

                Ping pingSender = new Ping();
                PingOptions options = new PingOptions();
                options.DontFragment = true;

                // Create a buffer of 32 bytes of data to be transmitted. 
                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 120;
                PingReply reply = pingSender.Send(ipAddress, timeout, buffer, options);

                if (reply.Status == IPStatus.Success)
                    return true;
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool isDeviceConnected = false;

        public bool IsDeviceConnected
        {
            get { return isDeviceConnected; }
            set
            {
                isDeviceConnected = value;
                if (isDeviceConnected)
                {
                    lblConnect.Text = "Kết nối thành công !!!";
                }
                else
                {
                    lblConnect.Text = "Kết nối không thành công !!!";
                }
            }
        }

        public string FetchDeviceInfo(int machineNumber)
        {
            StringBuilder sb = new StringBuilder();

            string returnValue = string.Empty;


            objCZKEM.GetFirmwareVersion(Convert.ToInt32(txtNumberMachine.Text), returnValue);
            if (returnValue.Trim() != string.Empty)
            {
                sb.Append("Firmware V: ");
                sb.Append(returnValue);
                sb.Append(",");
            }


            returnValue = string.Empty;
            objCZKEM.GetVendor(returnValue);
            if (returnValue.Trim() != string.Empty)
            {
                sb.Append("Vendor: ");
                sb.Append(returnValue);
                sb.Append(",");
            }

            string sWiegandFmt = string.Empty;
            objCZKEM.GetWiegandFmt(Convert.ToInt32(txtNumberMachine.Text), sWiegandFmt);

            returnValue = string.Empty;
            objCZKEM.GetSDKVersion(returnValue);
            if (returnValue.Trim() != string.Empty)
            {
                sb.Append("SDK V: ");
                sb.Append(returnValue);
                sb.Append(",");
            }

            returnValue = string.Empty;
            objCZKEM.GetSerialNumber(Convert.ToInt32(txtNumberMachine.Text), returnValue);
            if (returnValue.Trim() != string.Empty)
            {
                sb.Append("Serial No: ");
                sb.Append(returnValue);
                sb.Append(",");
            }

            returnValue = string.Empty;
            objCZKEM.GetDeviceMAC(Convert.ToInt32(txtNumberMachine.Text), returnValue);
            if (returnValue.Trim() != string.Empty)
            {
                sb.Append("Device MAC: ");
                sb.Append(returnValue);
            }

            return sb.ToString();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            string ipAddress = txtAddressIP.Text.Trim();

            bool isValidIpA = ValidateIP(ipAddress);
            if (!isValidIpA)
                throw new Exception("Lỗi địa chỉ IP !!");

            isValidIpA = PingTheDevice(ipAddress);
            if (isValidIpA) lblConnect.Text = "Thiết bị được kích hoạt!";
            else
                lblConnect.Text = "Lỗi kết nôi thiết bị!";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                //ShowStatusBar(string.Empty, true);

                if (IsDeviceConnected)
                {
                    IsDeviceConnected = false;
                    this.Cursor = Cursors.Default;
                    btnConnect.Text = "Ngắt kết nối";
                    return;
                }

                string ipAddress = txtAddressIP.Text.Trim();
                string port = txtPort.Text.Trim();
                if (ipAddress == string.Empty || port == string.Empty)
                    throw new Exception("Chưa nhập địa chỉ IP và Cổng kết nối !!");

                int portNumber = 4370;
                if (!int.TryParse(port, out portNumber))
                    throw new Exception("Lỗi cổng kết nối");

                bool isValidIpA = ValidateIP(ipAddress);
                if (!isValidIpA)
                    throw new Exception("Lỗi địa chỉ IP !!");

                isValidIpA = PingTheDevice(ipAddress);
                if (!isValidIpA)
                    throw new Exception("Thiết bị có địa chỉ " + ipAddress + ":" + port + " không phản hồi!!");

                //objZkeeper = new ZkemClient(RaiseDeviceEvent);
                IsDeviceConnected = objCZKEM.Connect_Net(ipAddress, portNumber);

                if (IsDeviceConnected)
                {
                    string deviceInfo = FetchDeviceInfo(int.Parse(txtNumberMachine.Text.Trim()));
                    btnConnect.Text = "Ngắt kết nối";
                }
                else
                {
                    btnConnect.Text = "Kết nối";
                }

            }
            catch (Exception ex)
            {
                lblConnect.Text = ex.ToString();
            }
            this.Cursor = Cursors.Default;
        }

        private void btnCheckTime_Click(object sender, EventArgs e)
        {
            int dwYear = 0;
            int dwMonth = 0;
            int dwDay = 0;
            int dwHour = 0;
            int dwMinute = 0;
            int dwSecond = 0;


            if (objCZKEM.GetDeviceTime(Convert.ToInt32(txtNumberMachine.Text), ref dwYear, ref dwMonth, ref dwDay, ref dwHour, ref dwMinute, ref dwSecond))
            {
                string inputDate = new DateTime(dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond).ToString();
                lblTimeSystem.Visible = true;
                lblTimeSystem.Text = inputDate;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (objCZKEM.RestartDevice(int.Parse(txtNumberMachine.Text)))
            {
                lblConnect.Text = "Đang khởi động lại thiết bị!";
            }
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            if (objCZKEM.RestartDevice(int.Parse(txtNumberMachine.Text)))
            {
                lblConnect.Text = "Đang tắt thiết bị!";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TVSSys.GlobalModule.objXML.UpdateKey("AddressIP", txtAddressIP.Text);
            TVSSys.GlobalModule.objXML.UpdateKey("Port", txtPort.Text);
            TVSSys.GlobalModule.objXML.UpdateKey("MachineNumber", txtNumberMachine.Text);
            TVSSys.GlobalModule.objXML.UpdateKey("Using", isDeviceConnected.ToString());

            Classes.clsMessage.Information("Cập nhật thành công.");   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbnDisConnect_Click(object sender, EventArgs e)
        {

        }
    }
}
