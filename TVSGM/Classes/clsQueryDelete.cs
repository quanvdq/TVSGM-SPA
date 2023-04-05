using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TVSGM.Classes
{
    public class clsQueryDelete
    {
        #region Method GymRoom
        public static bool GymRoom(string sIDValue, string sIDName, string sTab)
        {
            TVSSys.Connection objFunc = new TVSSys.Connection();
            try
            {
                string sSQL = "Select  " + sIDName + " from Tbl" + sTab + " WHERE " + sIDName + "=" + sIDValue +
                    //"  union Select  IDRoomGroup from TabRoom WHERE [IDRoomGroup]=" + sID + 
                    "";
                DataTable dt = objFunc.EXESelect(sSQL);
                if (dt.Rows.Count > 0) return true;
                else return false;
            }
            catch (Exception ex)
            {
                Classes.clsMessage.Error("Lỗi: " + ex.ToString());
                return false;
            }
        }
        #endregion

        #region Method GymRoom
        public static bool CheckPackGym(string sIDPartnerRegis)
        {
            TVSSys.Connection objFunc = new TVSSys.Connection();
            try
            {
                string sSQL = "Select  IDPartner from TblWorkoutHistory WHERE IDPartnerRegis='" + sIDPartnerRegis + "'";
                DataTable dt = objFunc.EXESelect(sSQL);
                if (dt.Rows.Count > 0) return true;
                else return false;
            }
            catch (Exception ex)
            {
                Classes.clsMessage.Error("Lỗi: " + ex.ToString());
                return false;
            }
        }
        #endregion

        //#region Method PartnerRegis
        //public static bool PartnerRegis(string sIDValue, string sIDName, string sTab)
        //{
        //    TVSSys.Connection objFunc = new TVSSys.Connection();
        //    try
        //    {
        //        string sSQL = "Select  " + sIDName + " from Tbl" + sTab + " WHERE " + sIDName + "=" + sIDValue +
        //            //"  union Select  IDRoomGroup from TabRoom WHERE [IDRoomGroup]=" + sID + 
        //            "";
        //        DataTable dt = objFunc.EXESelect(sSQL);
        //        if (dt.Rows.Count > 0) return true;
        //        else return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        Classes.clsMessage.Error("Lỗi: " + ex.ToString());
        //        return false;
        //    }
        //}
        //#endregion


        #region EXEDelete
        public static bool EXEDelete(string sTableName, string sIDName, string sValue)
        {
            bool flag;
            TVSSys.Connection objCon = new TVSSys.Connection();
            SqlConnection sqlCon = new SqlConnection(objCon.strConnectionString);
            sqlCon.Open();
            SqlCommand Cmd = sqlCon.CreateCommand();
            Cmd.CommandText = "DELETE Tbl" + sTableName + " WHERE " + sIDName + "='" + sValue + "'";
            Cmd.CommandType = CommandType.Text;
            Cmd.ExecuteNonQuery();

            try
            {
                flag = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi" + ex.ToString());
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

        #region InsertTblPartnerRegisDel
        public static bool InsertTblPartnerRegisDel(string sValue)
        {
            bool flag;
            TVSSys.Connection objCon = new TVSSys.Connection();
            SqlConnection SqlCon = new SqlConnection(objCon.strConnectionString);
            SqlCon.Open();
            try
            {
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = " INSERT INTO TblPartnerRegisDel(IDPartner ,IDGymRoom ,IDTypeGym ,IDPackGym ,IDWorkOut ,Times ,StartDate ,EndDate ,Active ," +
                                  " IDEmp ,ReExIDM ,OriginalBill ,Note ,Price ,TotalPay ,Payed ,Freeze ,DayLeft) " +
                                  " SELECT IDPartner ,IDGymRoom ,IDTypeGym ,IDPackGym ,IDWorkOut ,Times ,StartDate ,EndDate ,Active ," +
                                  " IDEmp ,ReExIDM ,OriginalBill ,Note ,Price ,TotalPay ,Payed ,Freeze ,DayLeft " +
                                  " FROM TblPartnerRegis "+
                                  " WHERE IDPartnerRegis=@IDPartnerRegis";
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@IDPartnerRegis", SqlDbType.VarChar).Value = sValue;
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

        #region InsertTblBillDelete
        public static bool InsertTblBillDelete(string sValue)
        {
            bool flag;
            TVSSys.Connection objCon = new TVSSys.Connection();
            SqlConnection SqlCon = new SqlConnection(objCon.strConnectionString);
            SqlCon.Open();
            try
            {
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = " INSERT INTO TblBillDelete (billID ,ReExIDM ,OriginalBill ,CreateDate ,IDInOut ,IDTypeInOut ,IDPartner ,PromotionMoney ,"+
                                  " PromotionPercent ,PromotionPercentMoney ,TotalMoney ,TotalPay ,Payed ,Note ,UserCreate ,IDStore ,DateSearch ,IDEmp) " +
                                  " SELECT billID ,ReExIDM ,OriginalBill ,getdate() ,IDInOut ,IDTypeInOut ,IDPartner ,PromotionMoney ," +
                                  " PromotionPercent ,PromotionPercentMoney ,TotalMoney ,TotalPay ,Payed ,Note ,'"+TVSSys.GlobalModule.objUserName+"' ,IDStore ,DateSearch ,IDEmp " +
                                  " FROM TblBill " +
                                  " WHERE OriginalBill='"+sValue+"'";
                Cmd.CommandType = CommandType.Text;
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

        #region InsertTblBillDeleteID
        public static bool InsertTblBillDeleteID(string sValue)
        {
            bool flag;
            TVSSys.Connection objCon = new TVSSys.Connection();
            SqlConnection SqlCon = new SqlConnection(objCon.strConnectionString);
            SqlCon.Open();
            try
            {
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = " INSERT INTO TblBillDelete (billID ,ReExIDM ,OriginalBill ,CreateDate ,IDInOut ,IDTypeInOut ,IDPartner ,PromotionMoney ," +
                                  " PromotionPercent ,PromotionPercentMoney ,TotalMoney ,TotalPay ,Payed ,Note ,UserCreate ,IDStore ,DateSearch ,IDEmp) " +
                                  " SELECT billID ,ReExIDM ,OriginalBill ,CreateDate ,IDInOut ,IDTypeInOut ,IDPartner ,PromotionMoney ," +
                                  " PromotionPercent ,PromotionPercentMoney ,TotalMoney ,TotalPay ,Payed ,Note ,UserCreate ,IDStore ,DateSearch ,IDEmp " +
                                  " FROM TblBill " +
                                  " WHERE ID=@ID";
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = sValue;
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

        #region InsertTblBillDetailDel
        public static bool InsertTblBillDetailDel(string sValue)
        {
            bool flag;
            TVSSys.Connection objCon = new TVSSys.Connection();
            SqlConnection SqlCon = new SqlConnection(objCon.strConnectionString);
            SqlCon.Open();
            try
            {
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = " INSERT INTO TblBillDetailDel (billID ,IDProducts ,IDUnit ,Number ,Price ,TotalMoney ,CreateDate ,UserName ,DateSearch ,"+
                                  " IDStore) " +
                                  " SELECT billID ,IDProducts ,IDUnit ,Number ,Price ,TotalMoney ,CreateDate ,UserName ,DateSearch ,"+
                                  " IDStore " +
                                  " FROM TblBillDetail " +
                                  " WHERE billID=@billID";
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@billID", SqlDbType.VarChar).Value = sValue;
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
    }
}
