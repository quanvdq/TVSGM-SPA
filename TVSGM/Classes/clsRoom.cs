using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TVSGM.Classes
{
    public class clsRoom
    {
        #region getRoomInfo
        public DataTable getRoomInfo()
        {
            DataTable objTable = new DataTable();


            string sSQL = "SELECT TblBed.IdBed,TblBed.CodeBed,TblBed.NameBed AS NameBed,TblBed.Poss,TblBed.State,TblBed.IDGymRoom,TblGymRoom.NameGymRoom as NameGymRoom "+
                          "FROM TblBed LEFT JOIN TblGymRoom ON TblGymRoom.IDGymRoom=TblBed.IDGymRoom";
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

        #region UpdateStatusBed
        public void UpdateStatusBed(int ID, int State)
        {
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                string sQuery = "UPDATE TblBed SET State=@State WHERE ID=@ID";
                Cmd.CommandText = sQuery;
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@State", SqlDbType.Int).Value = State;
                Cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                Cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Classes.clsMessage.Error("Lỗi: " + exception.ToString());
            }
            finally
            {
                sqlCon.Close();
                sqlCon.Dispose();
            }
        }
        #endregion
    }
}
