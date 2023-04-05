using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TVSGM.Classes
{
    class clsGetReports
    {
        #region GetRptSale
        public DataTable GetRptSale(string sIDEmp, string sDateSearch1, string sDateSearch2, string sIDInOut)
        {
            DataTable objTable = new DataTable();
            try
            {
                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "GetReportSale";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IDEmp", SqlDbType.VarChar).Value = sIDEmp;
                cmd.Parameters.Add("@DateSearch1", SqlDbType.VarChar).Value = sDateSearch1;
                cmd.Parameters.Add("@DateSearch2", SqlDbType.VarChar).Value = sDateSearch2;
                cmd.Parameters.Add("@IDInOut", SqlDbType.VarChar).Value = sIDInOut;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("Lỗi: " + exception.ToString());
            }
            return objTable;
        }
        #endregion

        #region GetReportEximDetail
        public DataTable GetReportEximDetail(string sbillID, string sUserCreate, string sNameProducts, string sNameSearch, string sDateSearch1, string sDateSearch2)
        {
            DataTable objTable = new DataTable();
            try
            {
                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "GetReportEximDetail";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@billID", SqlDbType.VarChar).Value = sbillID;
                cmd.Parameters.Add("@UserCreate", SqlDbType.VarChar).Value = sUserCreate;
                cmd.Parameters.Add("@NameProducts", SqlDbType.NVarChar).Value = sNameProducts;
                cmd.Parameters.Add("@NameSearch", SqlDbType.NVarChar).Value = sNameSearch;
                cmd.Parameters.Add("@DateSearch1", SqlDbType.VarChar).Value = sDateSearch1;
                cmd.Parameters.Add("@DateSearch2", SqlDbType.VarChar).Value = sDateSearch2;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("Lỗi: " + exception.ToString());
            }
            return objTable;
        }
        #endregion

        #region GetReportInventory
        public DataTable GetReportInventory(string sNameProducts, string sNameSearch, string sDateSearch1, string sDateSearch2)
        {
            DataTable objTable = new DataTable();
            try
            {
                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "GetReportInventory";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NameProducts", SqlDbType.NVarChar).Value = sNameProducts;
                cmd.Parameters.Add("@NameSearch", SqlDbType.NVarChar).Value = sNameSearch;
                cmd.Parameters.Add("@DateSearch1", SqlDbType.VarChar).Value = sDateSearch1;
                cmd.Parameters.Add("@DateSearch2", SqlDbType.VarChar).Value = sDateSearch2;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("Lỗi: " + exception.ToString());
            }
            return objTable;
        }
        #endregion

        #region GetReportWorkoutHistory
        public DataTable GetReportWorkoutHistory(string sNameSearch, DateTime DateSearch1, DateTime DateSearch2)
        {
            DataTable objTable = new DataTable();
            try
            {
                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "SELECT tblWorkoutHistory.IDWorkoutHistory,TblPartnerRegis.IDPartnerRegis,tblWorkoutHistory.IDPartner,TblPartnerGroup.IDPartnerGroup,TblPartnerGroup.NamePartnerGroup,TblPartnerType.IDPartnerType,"+
                                "TblPartnerType.NamePartnerType,tblWorkoutHistory.CodePartner,tblWorkoutHistory.NamePartner,TblGender.IDGender,TblGender.NameGender,tblWorkoutHistory.BirthDay,tblWorkoutHistory.Phone,"+
                                "tblWorkoutHistory.Address,TblGymRoom.IDGymRoom,tblWorkoutHistory.IDPackGym,TblPackGym.NamePackGym,TblGymRoom.NameGymRoom,TblWorkOut.IDWorkOut,"+
                                "tblWorkoutHistory.[Count],tblWorkoutHistory.DateIn,tblWorkoutHistory.DateSearch "+
                                "FROM tblWorkoutHistory "+
                                "LEFT JOIN TblPartner ON TblPartner.IDPartner=tblWorkoutHistory.IDPartner "+
                                "LEFT JOIN TblPartnerGroup ON TblPartnerGroup.IDPartnerGroup=tblWorkoutHistory.IDPartnerGroup "+
                                "LEFT JOIN TblPartnerType ON TblPartnerType.IDPartnerType=tblWorkoutHistory.IDPartnerType "+
                                "LEFT JOIN TblGender ON TblGender.IDGender=tblWorkoutHistory.IDGender "+
                                "LEFT JOIN TblGymRoom ON TblGymRoom.IDGymRoom=tblWorkoutHistory.IDGymRoom "+
                                "LEFT JOIN TblWorkOut ON TblWorkOut.IDWorkOut=tblWorkoutHistory.IDWorkOut "+
                                "LEFT JOIN TblPackGym ON TblPackGym.IDPackGym=tblWorkoutHistory.IDPackGym  "+
                                "LEFT JOIN TblPartnerRegis ON TblPartnerRegis.IDPartnerRegis=tblWorkoutHistory.IDPartnerRegis "+
                                "WHERE (tblWorkoutHistory.DateSearch BETWEEN @DateSearch1 AND @DateSearch2) "+
                                "AND ((tblWorkoutHistory.NamePartner LIKE N'%'+ @NameSearch +'%') OR (TblPartner.NameSearch LIKE N'%' + @NameSearch + '%')) " +
                                "ORDER BY tblWorkoutHistory.IDWorkoutHistory DESC";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@NameSearch", SqlDbType.NVarChar).Value = sNameSearch;
                cmd.Parameters.Add("@DateSearch1", SqlDbType.DateTime).Value = new DateTime(DateSearch1.Year, DateSearch1.Month, DateSearch1.Day,0,0,0);
                cmd.Parameters.Add("@DateSearch2", SqlDbType.DateTime).Value = new DateTime(DateSearch2.Year, DateSearch2.Month, DateSearch2.Day, 23, 59, 59);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("Lỗi: " + exception.ToString());
            }
            return objTable;
        }
        #endregion

        #region GetReportWorkoutHistory1
        public DataTable GetReportWorkoutHistory1(string Datetime, string NameSearch)
        {
            DataTable objTable = new DataTable();
            try
            {
                string sDateLimit="20201231";
                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "SELECT 0 AS STT, A.NamePartner, A.Phone, (SELECT TOP 1 EndDate FROM TblPartnerRegis C WHERE C.IDPartner = A.IDPartner) AS EndDate, " +
                                " (SELECT TOP 1 NamePackGym FROM TblPackGym WHERE IDPackGym = (SELECT TOP 1 IDPackGym FROM TblPartnerRegis  WHERE TblPartnerRegis.IDPartner = A.IDPartner)) AS NamePackGym, " +
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'01') != '') THEN 'X' ELSE '' END) AS '01', " +
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'02') != '') THEN 'X' ELSE '' END) AS '02', " +
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'03') != '') THEN 'X' ELSE '' END) AS '03', " +
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'04') != '') THEN 'X' ELSE '' END) AS '04', " +
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'05') != '') THEN 'X' ELSE '' END) AS '05', " +
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'06') != '') THEN 'X' ELSE '' END) AS '06', " +
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'07') != '') THEN 'X' ELSE '' END) AS '07', " +
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'08') != '') THEN 'X' ELSE '' END) AS '08', " +
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'09') != '') THEN 'X' ELSE '' END) AS '09', " +
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'10') != '') THEN 'X' ELSE '' END) AS '10', " +
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'11') != '') THEN 'X' ELSE '' END) AS '11', " +
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'12') != '') THEN 'X' ELSE '' END) AS '12', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'13') != '') THEN 'X' ELSE '' END) AS '13', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'14') != '') THEN 'X' ELSE '' END) AS '14', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'15') != '') THEN 'X' ELSE '' END) AS '15', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'16') != '') THEN 'X' ELSE '' END) AS '16', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'17') != '') THEN 'X' ELSE '' END) AS '17', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'18') != '') THEN 'X' ELSE '' END) AS '18', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'19') != '') THEN 'X' ELSE '' END) AS '19', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'20') != '') THEN 'X' ELSE '' END) AS '20', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'21') != '') THEN 'X' ELSE '' END) AS '21', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'22') != '') THEN 'X' ELSE '' END) AS '22', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'23') != '') THEN 'X' ELSE '' END) AS '23', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'24') != '') THEN 'X' ELSE '' END) AS '24', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'25') != '') THEN 'X' ELSE '' END) AS '25', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'26') != '') THEN 'X' ELSE '' END) AS '26', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'27') != '') THEN 'X' ELSE '' END) AS '27', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'28') != '') THEN 'X' ELSE '' END) AS '28', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'29') != '') THEN 'X' ELSE '' END) AS '29', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'30') != '') THEN 'X' ELSE '' END) AS '30', "+
                                " (CASE WHEN ((SELECT TOP 1 DateIn FROM tblWorkoutHistory B WHERE A.IDPartner = B.IDPartner AND CONVERT(NVARCHAR,DateIn,112) = '" + Datetime + "'+'31') != '') THEN 'X' ELSE '' END) AS '31'  "+
                                "  FROM TblPartner A WHERE A.NamePartner LIKE N'%'+ @NameSearch +'%' ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@NameSearch", SqlDbType.NVarChar).Value = NameSearch;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("Lỗi: " + exception.ToString());
            }
            return objTable;
        }
        #endregion

        #region GetReportSynInOutPartner
        public DataTable GetReportSynInOutPartner(string sNameSearch, string sDateSearch1, string sDateSearch2)
        {
            DataTable objTable = new DataTable();
            try
            {
                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "SELECT TblPartner.CodePartner, tblWorkoutHistory.IDPartnerRegis ,tblWorkoutHistory.IDPartner ,tblWorkoutHistory.IDPartnerGroup ,tblWorkoutHistory.IDPartnerType ,tblWorkoutHistory.NamePartner " +
                Environment.NewLine + " ,TblGender.NameGender,tblWorkoutHistory.BirthDay ,tblWorkoutHistory.Phone ,tblWorkoutHistory.Address ,sum(tblWorkoutHistory.Count) as Count,TblPartner.NameSearch "+
                Environment.NewLine + " FROM tblWorkoutHistory "+
                Environment.NewLine + " LEFT JOIN TblGender ON TblGender.IDGender = tblWorkoutHistory.IDGender "+
                Environment.NewLine + " LEFT JOIN TblPartner ON TblPartner.IDPartner = tblWorkoutHistory.IDPartner "+
                Environment.NewLine + " GROUP BY TblPartner.CodePartner,tblWorkoutHistory.IDPartnerRegis,tblWorkoutHistory.IDPartner,tblWorkoutHistory.IDPartnerGroup,tblWorkoutHistory.IDPartnerType,tblWorkoutHistory.NamePartner " +
                Environment.NewLine + " ,TblGender.NameGender ,tblWorkoutHistory.Phone ,tblWorkoutHistory.Address,tblWorkoutHistory.BirthDay ,tblWorkoutHistory.NamePartner,TblPartner.NameSearch "+
                Environment.NewLine + " ORDER BY Count DESC";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@NameSearch", SqlDbType.NVarChar).Value = sNameSearch;
                cmd.Parameters.Add("@DateSearch1", SqlDbType.VarChar).Value = sDateSearch1;
                cmd.Parameters.Add("@DateSearch2", SqlDbType.VarChar).Value = sDateSearch2;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("Lỗi: " + exception.ToString());
            }
            return objTable;
        }
        #endregion


        #region GetReportParnterStatus
        public DataTable GetReportParnterStatus(string sNamePartner, string sNameSearch)
        {
            DataTable objTable = new DataTable();
            try
            {

                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "GetReportParnterStatus";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NamePartner", SqlDbType.NVarChar).Value = sNamePartner;
                cmd.Parameters.Add("@NameSearch", SqlDbType.NVarChar).Value = sNameSearch;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("lỗi: " + exception.ToString());
            }
            return objTable;
        }
        #endregion

        #region GetReportParnterNotRegis
        public DataTable GetReportParnterNotRegis(string sNamePartner, string sNameSearch)
        {
            DataTable objTable = new DataTable();
            try
            {

                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "GetReportPartnerNotRegis";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NamePartner", SqlDbType.NVarChar).Value = sNamePartner;
                cmd.Parameters.Add("@NameSearch", SqlDbType.NVarChar).Value = sNameSearch;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("lỗi: " + exception.ToString());
            }
            return objTable;
        }
        #endregion

        #region GetReportDebtSupplier
        public DataTable GetReportDebtSupplier(string sNamePartner, string sNameSearch, int sIDTypeInOut)
        {
            DataTable objTable = new DataTable();
            try
            {

                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "GetReportDebtSupplier";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NamePartner", SqlDbType.NVarChar).Value = sNamePartner;
                cmd.Parameters.Add("@NameSearch", SqlDbType.NVarChar).Value = sNameSearch;
                cmd.Parameters.Add("@IDTypeInOut", SqlDbType.NVarChar).Value = sIDTypeInOut;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("lỗi: " + exception.ToString());
            }
            return objTable;
        }
        #endregion

        #region GetReportArising
        public DataTable GetReportArising(string sDateSearch1, string sDateSearch2, int sIDPartner)
        {
            DataTable objTable = new DataTable();
            try
            {

                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "GetReportArising";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@DateSearch1", SqlDbType.NVarChar).Value = sDateSearch1;
                cmd.Parameters.Add("@IDPartner", SqlDbType.Int).Value = sIDPartner;
                cmd.Parameters.Add("@DateSearch2", SqlDbType.NVarChar).Value = sDateSearch2;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("lỗi: " + exception.ToString());
            }
            return objTable;
        }
        #endregion

        #region GetReportArising
        public DataTable GetReportSynExim(string sNameProducts, string sNameSearch, string sDateSearch1, string sDateSearch2)
        {
            DataTable objTable = new DataTable();
            try
            {

                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "GetReportSynExim";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NameProducts", SqlDbType.NVarChar).Value = sNameProducts;
                cmd.Parameters.Add("@NameSearch", SqlDbType.NVarChar).Value = sNameSearch;
                cmd.Parameters.Add("@DateSearch1", SqlDbType.NVarChar).Value = sDateSearch1;
                cmd.Parameters.Add("@DateSearch2", SqlDbType.NVarChar).Value = sDateSearch2;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("lỗi: " + exception.ToString());
            }
            return objTable;
        }
        #endregion

        #region GetReportPrdArising
        public DataTable GetReportPrdArising(int sIDProducts, string sDateSearch1, string sDateSearch2)
        {
            DataTable objTable = new DataTable();
            try
            {

                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "GetReportPrdArising";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IDProducts", SqlDbType.Int).Value = sIDProducts;
                cmd.Parameters.Add("@DateSearch1", SqlDbType.NVarChar).Value = sDateSearch1;
                cmd.Parameters.Add("@DateSearch2", SqlDbType.NVarChar).Value = sDateSearch2;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("lỗi: " + exception.ToString());
            }
            return objTable;
        }
        #endregion

        #region GetReportParnterRegis
        public DataTable GetReportParnterRegis(int IDPartner)
        {
            DataTable objTable = new DataTable();
            try
            {

                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "GetReportParnterRegis";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IDPartner", SqlDbType.Int).Value = IDPartner;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("lỗi: " + exception.ToString());
            }
            return objTable;
        }
        #endregion

        #region GetReportParnterExpiringInMonth
        public DataTable GetReportParnterExpiringInMonth(int EndDate)
        {
            DataTable objTable = new DataTable();
            try
            {

                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "SELECT TblPartnerRegis.IDPartnerRegis,TblPartnerRegis.IDPartner, TblPartner.CodePartner,TblPartner.NamePartner,TblGymRoom.NameGymRoom,TblPartnerRegis.IDTypeGym,TblPackGym.NamePackGym," +
	            Environment.NewLine + "TblPartnerRegis.Times,CONVERT(NVARCHAR(10),TblPartnerRegis.StartDate,103) AS StartDate,CONVERT(NVARCHAR(10),TblPartnerRegis.EndDate,103) AS EndDate,"+
	            Environment.NewLine + "TblPartnerRegis.Price, TblPartnerRegis.TotalPay,TblPartnerRegis.Payed,TblPartnerRegis.Active,TblPartnerRegis.Note "+
                Environment.NewLine + "FROM TblPartnerRegis "+
                Environment.NewLine + "LEFT JOIN TblGymRoom ON TblGymRoom.IDGymRoom=TblPartnerRegis.IDGymRoom "+
                Environment.NewLine + "LEFT JOIN TblPackGym ON TblPackGym.IDPackGym=TblPartnerRegis.IDPackGym "+
                Environment.NewLine + "LEFT JOIN TblPartner ON TblPartner.IDPartner=TblPartnerRegis.IDPartner "+
                Environment.NewLine + "WHERE MONTH(TblPartnerRegis.EndDate)=@EndDate";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@EndDate", SqlDbType.Int).Value = EndDate;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("lỗi: " + exception.ToString());
            }
            return objTable;
        }
        #endregion

        

        #region GetReportFreezeHistory
        public DataTable GetReportFreezeHistory(string sDateSearch1, string sDateSearch2, string sSearchName)
        {
            DataTable objTable = new DataTable();
            try
            {

                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "SELECT TblFreezeHistory.IdFreezeHistory ,TblFreezeHistory.IDPartnerRegis ,TblFreezeHistory.IDPartner, TblPartner.CodePartner,  "+
                Environment.NewLine + " TblPartner.NamePartner,TblPartnerRegis.IDPackGym, TblPackGym.NamePackGym,TblPartnerRegis.StartDate,TblFreezeHistory.DateFreezeHistory " +
                Environment.NewLine + " ,TblFreezeHistory.Freeze ,TblFreezeHistory.UserCreate "+
                Environment.NewLine + " FROM TblFreezeHistory "+
                Environment.NewLine + " LEFT JOIN TblPartner ON TblPartner.IDPartner=TblFreezeHistory.IDPartner "+
                Environment.NewLine + " LEFT JOIN TblPartnerRegis ON TblPartnerRegis.IDPartnerRegis=TblFreezeHistory.IDPartnerRegis "+
                Environment.NewLine + " LEFT JOIN TblPackGym ON TblPackGym.IDPackGym=TblPartnerRegis.IDPackGym WHERE ((Convert(nvarchar(8),TblFreezeHistory.DateFreezeHistory,112) BETWEEN @DateSearch1 AND @DateSearch2)) AND TblPartner.NamePartner LIKE N'%" + sSearchName + "%'";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@DateSearch1", SqlDbType.VarChar).Value = sDateSearch1;
                cmd.Parameters.Add("@DateSearch2", SqlDbType.VarChar).Value = sDateSearch2;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("lỗi: " + exception.ToString());
            }
            return objTable;
        }
        #endregion

        #region GetReportBillDelete
        public DataTable GetReportBillDelete(string sDateSearch1, string sDateSearch2, string sSearchName)
        {
            DataTable objTable = new DataTable();
            try
            {
                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "SELECT TblBillDelete.ID ,TblBillDelete.billID ,TblBillDelete.ReExIDM ,TblBillDelete.OriginalBill "+
                Environment.NewLine + " ,TblBillDelete.CreateDate ,TblBillDelete.IDInOut ,TblBillDelete.IDTypeInOut ,TblBillDelete.IDPartner,TblPartner.CodePartner "+
                Environment.NewLine + " ,TblPartner.NamePartner ,TblBillDelete.PromotionMoney ,TblBillDelete.PromotionPercent ,TblBillDelete.PromotionPercentMoney "+
                Environment.NewLine + " ,TblBillDelete.TotalMoney ,TblBillDelete.TotalPay ,TblBillDelete.Payed ,TblBillDelete.Note ,TblBillDelete.UserCreate "+
                Environment.NewLine + " ,TblBillDelete.IDStore ,TblBillDelete.DateSearch ,TblBillDelete.IDEmp,TblEmp.NameEmp "+
                Environment.NewLine + " FROM TblBillDelete "+
                Environment.NewLine + " LEFT JOIN TblPartner ON TblPartner.IDPartner=TblBillDelete.IDPartner "+
                Environment.NewLine + " LEFT JOIN TblEmp ON TblEmp.IDEmp=TblBillDelete.IDEmp WHERE ((Convert(nvarchar(8),TblBillDelete.DateSearch,112) BETWEEN @DateSearch1 AND @DateSearch2)) ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@DateSearch1", SqlDbType.VarChar).Value = sDateSearch1;
                cmd.Parameters.Add("@DateSearch2", SqlDbType.VarChar).Value = sDateSearch2;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                objTable = ds.Tables[0];
                sqlCon.Close();
                sqlCon.Dispose();

            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("lỗi: " + exception.ToString());
            }
            return objTable;
        }
        #endregion
    }
}
