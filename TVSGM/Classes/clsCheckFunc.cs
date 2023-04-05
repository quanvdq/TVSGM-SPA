using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TVSSys;


namespace TVSGM.Classes
{
    class clsCheckFunc
    {
        #region CheckFreeze
        public bool CheckFreeze(string sIDPartnerRegis)
        {
            bool tmpValue = false;
            try
            {
                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand Cmd = sqlCon.CreateCommand();
                Cmd.CommandText = "SELECT * FROM TblPartnerRegis WHERE Freeze=1 AND IDPartnerRegis=@IDPartnerRegis";
                Cmd.Parameters.Add("IDPartnerRegis", SqlDbType.Int).Value = sIDPartnerRegis;
                SqlDataReader Rd = Cmd.ExecuteReader();
                while (Rd.Read())
                {
                    tmpValue = true;
                }
                Rd.Close();
                sqlCon.Close();
                sqlCon.Dispose();
            }
            catch
            {
            }
            return tmpValue;
        }
        #endregion
    }
}
