using System;
using System.Collections.Generic;
using System.Diagnostics;
//using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
//using System.Management;
using System.Globalization;
using TVSSys;

namespace TVSGM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmMain());

            try
            {
                //Thread t = new Thread(new ThreadStart(TVSSys.frmWaitting));
                //t.Start();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                TVSSys.Connection objCon = new Connection();
                SqlConnection sCon = new SqlConnection(objCon.GetStrConnectionString());
                sCon.Open();
                Classes.ModifiData ModifiData = new TVSGM.Classes.ModifiData();

                //TVSSys.Regis obj = new Regis();
                //MessageBox.Show(obj.GetSerial());
                //string s = obj.GetSerial();

                if(1==1)
                {
                    TVSSys.GlobalModule.objColorEnter = System.Drawing.Color.Aqua;
                    TVSSys.GlobalModule onjGlobal = new GlobalModule();
                    TVSSys.GlobalModule.objProjectName = "TVS - PHẦN MỀM QUẢN LÝ PHÒNG TẬP GYM";
                    TVSSys.frmLogin fLogin = new TVSSys.frmLogin();
                    fLogin.ShowDialog();
                    if (fLogin.OK)
                    {
                        ModifiData.Modifi();
                        string instanceName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                        
                        Process[] processes = Process.GetProcessesByName(instanceName);
                        if (processes.Length > 5)
                        {
                            Classes.clsMessage.Error("Lỗi. Chương trình đang được sử dụng !.");
                            return;
                        }
                        Application.Run(new FrmMain());
                    }
                }
                else
                {
                    TVSSys.FrmRegister frm = new TVSSys.FrmRegister();
                    frm.ShowDialog();
                }
                sCon.Close();
                sCon.Dispose();
            }
            catch (Exception ex)
            {
                Classes.clsMessage.Error("Kiểm tra lại hệ thống " + ex.ToString());
                TVSSys.FrmConnectData frm = new TVSSys.FrmConnectData();
                frm.ShowDialog();
            }

        }
    }
}
