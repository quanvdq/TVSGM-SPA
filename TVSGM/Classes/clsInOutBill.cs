using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TVSGM.Classes
{
    public class clsInOutBill
    {
        #region getInOutBill
        public DataTable getInOutBill(string sSearchP_Name,string sPrefix, string sDateSearch1, string sDateSearch2)
        {
            DataTable objTable = new DataTable();
            string sWhere = String.Empty;
            if (sSearchP_Name == "")
            {
                sWhere = "";
            }
            else
            {
                sWhere = " AND TblPartner.NamePartner LIKE N'%" + sSearchP_Name + "%' ";
            }
            string sSQL = "SELECT TblBill.ID,TblBill.billID,TblBill.ReExIDM,TblBill.OriginalBill,TblBill.CreateDate,TblInOut.IDInOut AS I_ID,TblInOut.NameInOut AS I_Name," +
                        "TblBill.IDPartner AS P_ID,TblPartner.NamePartner AS P_Name,TblPartner.Address AS P_Address,TblBill.Payed,TabUser.UserName AS U_UserName,"+
                        "TabUser.FullName AS U_FullName ,TblBill.Note,TblBill.UserCreate,TblBill.IDEmp " +
                        "FROM TblBill "+
                        "LEFT JOIN TblInOut ON TblInOut.IDInOut=TblBill.IDInOut " +
                        "LEFT JOIN TblPartner ON TblPartner.IDPartner=TblBill.IDPartner "+
                        "LEFT JOIN TabUser ON TabUser.UserName=TblBill.UserCreate "+
                        "WHERE (TblBill.ReExIDM LIKE N'%" + sPrefix + "%') "+
                        "AND (convert(datetime,TblBill.DateSearch,103) BETWEEN '" + sDateSearch1 + "' AND '" + sDateSearch2 + "') " + sWhere +
                        "ORDER BY TblBill.CreateDate DESC";
            try
            {
                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = sSQL;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();
            }
            catch
            {

            }
            return objTable;
        }
        #endregion

        #region UpdateInOut
        public bool UpdateInOut(int sID, string sbillID, string sReExIDM, string sOriginalBill, DateTime sCreateDate, int sIDInOut, int sIDTypeInOut, int sIDPartner,double sTotalPay, double sPayed, string sNote, string sUserCreate, DateTime sDateSearch, int sIDEmp)
        {
            bool flag;
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                string sQuery = "IF EXISTS (SELECT * FROM TblBill WHERE ID=@ID) " +
                                            " BEGIN UPDATE TblBill SET " +
                                            "      TotalPay = @TotalPay" +
                                            "      ,Payed = @Payed" +
                                            "      ,Note = @Note" +
                                            "      ,UserCreate = @UserCreate" +
                                            "      ,IDEmp = @IDEmp" +
                                            " WHERE  ID=@ID" +
                                            " END " +
                                            " ELSE BEGIN INSERT INTO TblBill (billID,ReExIDM,OriginalBill,CreateDate,IDInOut,IDTypeInOut,IDPartner,TotalPay,Payed,Note,UserCreate,DateSearch,IDEmp)" +
                                            " VALUES(@billID,@ReExIDM,@OriginalBill,@CreateDate,@IDInOut,@IDTypeInOut,@IDPartner,@TotalPay,@Payed,@Note,@UserCreate,@DateSearch,@IDEmp) END";
                Cmd.CommandText = sQuery;
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@ID", SqlDbType.Int).Value = sID;
                Cmd.Parameters.Add("@billID", SqlDbType.VarChar).Value = sbillID;
                Cmd.Parameters.Add("@ReExIDM", SqlDbType.VarChar).Value = sReExIDM;
                Cmd.Parameters.Add("@OriginalBill", SqlDbType.VarChar).Value = sOriginalBill;
                Cmd.Parameters.Add("@CreateDate", SqlDbType.DateTime).Value = sCreateDate;
                Cmd.Parameters.Add("@IDInOut", SqlDbType.Int).Value = sIDInOut;
                Cmd.Parameters.Add("@IDTypeInOut", SqlDbType.Int).Value = sIDTypeInOut;
                Cmd.Parameters.Add("@IDPartner", SqlDbType.Int).Value = sIDPartner;
                Cmd.Parameters.Add("@TotalPay", SqlDbType.Float).Value = sTotalPay;
                Cmd.Parameters.Add("@Payed", SqlDbType.Float).Value = sPayed;
                Cmd.Parameters.Add("@Note", SqlDbType.NVarChar).Value = sNote;
                Cmd.Parameters.Add("@UserCreate", SqlDbType.VarChar).Value = sUserCreate;
                Cmd.Parameters.Add("@DateSearch", SqlDbType.DateTime).Value = sDateSearch;
                Cmd.Parameters.Add("@IDEmp", SqlDbType.Int).Value = sIDEmp;
                Cmd.ExecuteNonQuery();
                flag = true;

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("Lỗi: " + exception.ToString());
                flag = false;
            }
            finally
            {
                sqlCon.Close();
                sqlCon.Dispose();
            }
            return flag;
        }
        #endregion

        #region UpdateDateAp
        public bool UpdateDateAp(DateTime DateAp, string Billid)
        {
            bool flag;
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                string sQuery = "UPDATE TblBill SET DateAp = @DateAp WHERE billID = @billID";
                Cmd.CommandText = sQuery;
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@DateAp", SqlDbType.DateTime).Value = DateAp;
                Cmd.Parameters.Add("@billID", SqlDbType.VarChar).Value = Billid;
                Cmd.ExecuteNonQuery();
                flag = true;

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("Lỗi: " + exception.ToString());
                flag = false;
            }
            finally
            {
                sqlCon.Close();
                sqlCon.Dispose();
            }
            return flag;
        }
        #endregion
    }
}
