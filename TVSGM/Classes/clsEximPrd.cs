using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TVSGM.Classes
{
    public class clsEximPrd
    {
        #region getDaTblill
        public DataTable getDataBill(string strPartner, string strAddress, string strSPartner, string strSAddress, string strDateSearch1, string strDateSearch2,string sType, string BillId)
        {
            DataTable objTable = new DataTable();

            string strWHERE = String.Empty;

            if (strPartner == String.Empty)
            {
                strWHERE = " ";
            }
            else if (strAddress == String.Empty)
            {
                strWHERE = " AND (TblPartner.NamePartner LIKE N'%" + strSPartner + "%') ";
            }
            else
            {
                strWHERE = "AND (TblPartner.NamePartner LIKE N'%" + strSPartner + "%') " +
                    "AND (TblPartner.Address LIKE N'%" + strSAddress + "%') ";
            }

            if (BillId != "")
            {
                strWHERE += " AND TblBill.billID = '" + BillId + "'";
            }
            string sSQL = "SELECT TblBill.ID,TblBill.CreateDate,TblBill.billID,TblBill.ReExIDM,TblPartner.IDPartner," +
                            "TblPartner.NamePartner,TblPartner.Address,TblPartner.Phone,TblBill.TotalMoney," +
                            "TblBill.PromotionMoney,TblBill.PromotionPercent,TblBill.PromotionPercentMoney,TblBill.TotalPay,TblBill.Payed," +
                            "TblStore.IDStore, TblStore.NameStore,TabUser.UserName,TblBill.Note " +
                            "FROM TblBill " +
                            "LEFT JOIN TblPartner ON TblBill.IDPartner=TblPartner.IDPartner " +
                            "LEFT JOIN TblStore ON TblBill.IDStore=TblStore.IDStore " +
                            "LEFT JOIN TabUser ON TblBill.UserCreate=TabUser.UserName " +
                            "WHERE (convert(datetime,TblBill.DateSearch,103) BETWEEN '" + strDateSearch1 + "' " +
                            "AND '" + strDateSearch2 + "') " +
                            "AND (TblBill.billID LIKE N'%"+sType+"%') " + strWHERE +
                            "ORDER BY TblBill.billID DESC ";
            try
            {
                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
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

        #region getDataBillDetail
        public DataTable getDataBillDetail(string sBill)
        {
            DataTable objDataTable = new DataTable();
            string sSQL = "SELECT TblBillDetail.ID,TblBillDetail.billID,TblProducts.IDProducts,TblProducts.NameProducts,TblUnit.IDUnit,TblUnit.NameUnit "+
                          ",TblBillDetail.Number,TblBillDetail.Price,TblBillDetail.TotalMoney "+ 
                          ",TabUser.FullName "+
                          "FROM TblBillDetail  "+
                          "LEFT JOIN TblProducts ON TblBillDetail.IDProducts=TblProducts.IDProducts  "+
                          "LEFT JOIN TblUnit ON TblBillDetail.IDUnit=TblUnit.IDUnit  "+
                          "LEFT JOIN TabUser ON TblBillDetail.UserName=TabUser.UserName " +
                          "WHERE TblBillDetail.billID='" + sBill + "'";
            try
            {
                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand Cmd = sqlCon.CreateCommand();
                Cmd.CommandText = sSQL;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objDataTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();
            }
            catch { }
            return objDataTable;
        }
        #endregion

        #region EXEUpdateBill
        public bool EXEUpdateBill(int sID, string sbillID, string sReExIDM, DateTime sCreateDate, int sIDInOut, int sIDTypeInOut, string sOriginalBill, int sIDPartner, double sTotalMoney, 
            double sPromotionMoney, double sPromotionPercent, double sTotalPay, double sPayed, string sNote, string sUserCreate, int sIDStore, 
            DateTime DateSearch)
        {
            bool flag;
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            SqlCon.Open();
            try
            {
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "ActionUpdateBill";
                Cmd.CommandType = CommandType.StoredProcedure;
                //Cmd.Parameters.Add("@ID", SqlDbType.Int).Value = sID;
                Cmd.Parameters.Add("@billID", SqlDbType.VarChar).Value = sbillID;
                Cmd.Parameters.Add("@ReExIDM", SqlDbType.VarChar).Value = sReExIDM;
                Cmd.Parameters.Add("@CreateDate", SqlDbType.DateTime).Value = sCreateDate;
                Cmd.Parameters.Add("@IDInOut", SqlDbType.Int).Value = sIDInOut;
                Cmd.Parameters.Add("@IDTypeInOut", SqlDbType.Int).Value = sIDTypeInOut;
                Cmd.Parameters.Add("@OriginalBill", SqlDbType.NVarChar).Value = sOriginalBill;
                Cmd.Parameters.Add("@IDPartner", SqlDbType.Int).Value = sIDPartner;
                Cmd.Parameters.Add("@TotalMoney", SqlDbType.Float).Value = sTotalMoney;
                Cmd.Parameters.Add("@PromotionMoney", SqlDbType.Float).Value = sPromotionMoney;
                Cmd.Parameters.Add("@PromotionPercent", SqlDbType.Float).Value = sPromotionPercent;
                Cmd.Parameters.Add("@TotalPay", SqlDbType.Float).Value = sTotalPay;
                Cmd.Parameters.Add("@Payed", SqlDbType.Float).Value = sPayed;
                Cmd.Parameters.Add("@Note", SqlDbType.NVarChar).Value = sNote;
                Cmd.Parameters.Add("@UserCreate", SqlDbType.NVarChar).Value = sUserCreate;
                Cmd.Parameters.Add("@IDStore", SqlDbType.Int).Value = sIDStore;
                Cmd.Parameters.Add("@DateSearch", SqlDbType.DateTime).Value = DateSearch;
                Cmd.ExecuteNonQuery();
                flag = true;
            }
            catch (Exception ex)
            {
                Classes.clsMessage.Error("Lỗi: " + ex.ToString());
                flag = false;
            }
            finally
            {
                SqlCon.Close();
                SqlCon.Dispose();
            }
            return flag;
        }
        #endregion 

        #region EXEUpdateBillDetail
        public bool EXEUpdateBillDetail(int sID, string sbillID, int sIDProducts, int sIDUnit, double sNumber, double sPrice, double sTotalMoney, DateTime sCreateDate, DateTime sDateSearch)
        {
            bool flag;
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                Cmd.CommandText = "ActionUpdateBillDetail";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@ID", SqlDbType.Int).Value = sID;
                Cmd.Parameters.Add("@billID", SqlDbType.NVarChar).Value = sbillID;
                Cmd.Parameters.Add("@IDProducts", SqlDbType.Int).Value = sIDProducts;
                Cmd.Parameters.Add("@IDUnit", SqlDbType.Int).Value = sIDUnit;
                Cmd.Parameters.Add("@Number", SqlDbType.Float).Value = sNumber;
                Cmd.Parameters.Add("@Price", SqlDbType.Float).Value = sPrice;
                Cmd.Parameters.Add("@TotalMoney", SqlDbType.Float).Value = sTotalMoney;
                Cmd.Parameters.Add("@CreateDate", SqlDbType.DateTime).Value = sCreateDate;
                Cmd.Parameters.Add("@DateSearch", SqlDbType.DateTime).Value = sDateSearch;
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

        #region getDaTblill
        public DataTable getDataCancelBill(string strDateSearch1, string strDateSearch2, string sType)
        {
            DataTable objTable = new DataTable();
            string sSQL = "SELECT TblBill.ID,TblBill.CreateDate,TblBill.billID,TblBill.TotalMoney,TblBill.TotalPay,TblStore.IDStore, TblStore.NameStore,TabUser.UserName,TblBill.Note "+
                          "FROM TblBill " +
                          "LEFT JOIN TblPartner ON TblBill.IDPartner=TblPartner.IDPartner "+
                          "LEFT JOIN TblStore ON TblBill.IDStore=TblStore.IDStore "+
                          "LEFT JOIN TabUser ON TblBill.UserCreate=TabUser.UserName "+
                          "WHERE (convert(datetime,TblBill.DateSearch,103) BETWEEN '" + strDateSearch1 + "' " +
                          "AND '" + strDateSearch2 + "') " +
                          "AND (TblBill.billID LIKE N'%" + sType + "%') " +
                          "ORDER BY TblBill.billID DESC ";
            try
            {
                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
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


    }
}
