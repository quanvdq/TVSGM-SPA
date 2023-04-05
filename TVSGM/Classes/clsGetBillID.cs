using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace TVSGM.Classes
{
    public class clsGetBillID
    {
        
        //public static string LayIDCuoi(string Tencot,string thang, string nam, string Bang)
        public static string GetLastID(string strField,string strTable,string strWhere)
        {
            TVSSys.Connection objFunc = new TVSSys.Connection();
            
            //string sql3 = "SELECT MAX(" + Tencot + ") FROM " + Bang + " WHERE MONTH(CreateDate)=" + thang + " AND YEAR(CreateDate)=" + nam + "";
            //return PNSSys.GlobalModule.objCon.Get_EXESelect(sql3);
            string sql3 = "SELECT TOP 1 " + strField + " FROM " + strTable;
            if (strWhere != string.Empty)
            {
                sql3 += " WHERE " + strWhere;
            }
            sql3 += "ORDER BY " + strField + " DESC";
            return objFunc.Get_EXESelect(sql3);
        }

        public static string NextID(string tiento,string sTencot,string sNgay, string sThang, string sNnam, string sBang, string strWhere)
        {
            string LastID = "";
            LastID = GetLastID(sTencot, sBang, strWhere);
            if (LastID == "")
            {
                return tiento + "001";
            }
            int IdKeTiep = int.Parse(LastID.Remove(0, tiento.Length)) + 1;
            int lengthNumerID = LastID.Length - tiento.Length;
            string zeroNumber = "";
            for (int i = 1; i <= lengthNumerID; i++)
            {
                if (IdKeTiep < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumerID - i; j++)
                    {
                        zeroNumber += "0";
                    }
                    return tiento + zeroNumber + IdKeTiep.ToString();
                }
            }
            return tiento + IdKeTiep;
        }

    }
}
