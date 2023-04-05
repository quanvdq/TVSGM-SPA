using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TVSGM.Classes
{
    public class clsMessage
    {
        private static string sMessageTittle = "TVS-Thông báo";
        public bool fShowDetail = false;
        public static void Error(string sMessage)
        {
            MessageBox.Show(sMessage, sMessageTittle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Information(string sMessage)
        {
            MessageBox.Show(sMessage, sMessageTittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult Question(string sMesseage)
        {
            return MessageBox.Show(sMesseage, sMessageTittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public static void Warning(string sMesseage)
        {
            MessageBox.Show(sMesseage, sMessageTittle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
