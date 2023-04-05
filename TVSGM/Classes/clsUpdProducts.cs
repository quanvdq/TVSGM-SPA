using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using TVSSys;
using System.Data;
using System.Data.SqlClient;

namespace TVSGM.Classes
{
    public class clsUpdProducts
    {
        #region UpdatePrd
        public bool UpdatePrd(int fIdProducts, int fIDProductGroup, string sCodeProducts, string sNameProducts, int fIDUnit, double fPriceIn, double fPriceOut, string sNameSearch)
        {
            bool flag;
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                string sQuery = "IF EXISTS (SELECT * FROM TblProducts WHERE TblProducts.IdProducts=@IdProducts) " +
                                            " BEGIN UPDATE TblProducts SET IDProductGroup = @IDProductGroup " +
                                            "      ,CodeProducts = @CodeProducts" +
                                            "      ,NameProducts = @NameProducts" +
                                            "      ,IDUnit = @IDUnit" +
                                            "      ,PriceIn = @PriceIn" +
                                            "      ,PriceOut = @PriceOut" +
                                            "      ,NameSearch = @NameSearch" +
                                            " WHERE TblProducts.IdProducts=@IdProducts " +
                                            " END " +
                                            " ELSE BEGIN INSERT INTO TblProducts(IDProductGroup,CodeProducts,NameProducts,IDUnit,PriceIn,PriceOut,NameSearch) " +
                                            " VALUES(@IDProductGroup,@CodeProducts,@NameProducts,@IDUnit,@PriceIn,@PriceOut,@NameSearch) END";
                Cmd.CommandText = sQuery;
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@IdProducts", SqlDbType.Int).Value = fIdProducts;
                Cmd.Parameters.Add("@IDProductGroup", SqlDbType.Int).Value = fIDProductGroup;
                Cmd.Parameters.Add("@CodeProducts", SqlDbType.VarChar).Value = sCodeProducts;
                Cmd.Parameters.Add("@NameProducts", SqlDbType.NVarChar).Value = sNameProducts;
                Cmd.Parameters.Add("@NameSearch", SqlDbType.NVarChar).Value = sNameSearch;
                Cmd.Parameters.Add("@IDUnit", SqlDbType.Int).Value = fIDUnit;
                Cmd.Parameters.Add("@PriceIn", SqlDbType.Float).Value = fPriceIn;
                Cmd.Parameters.Add("@PriceOut", SqlDbType.Float).Value = fPriceOut;
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

        #region UpdateBed
        public bool UpdateBed(int fIdBed, int fIDGymRoom, string sCodeBed, string sNameBed, double fPriceDay, double fPriceNight)
        {
            bool flag;
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                string sQuery = "IF EXISTS (SELECT * FROM TblBed WHERE TblBed.IdBed=@IdBed) " +
                                            " BEGIN UPDATE TblBed SET IDGymRoom = @IDGymRoom " +
                                            "      ,CodeBed = @CodeBed" +
                                            "      ,NameBed = @NameBed" +
                                            "      ,PriceDay = @PriceDay" +
                                            "      ,PriceNight = @PriceNight" +
                                            " WHERE TblBed.IdBed=@IdBed " +
                                            " END " +
                                            " ELSE BEGIN INSERT INTO TblBed(IDGymRoom,CodeBed,NameBed,PriceDay,PriceNight) " +
                                            " VALUES(@IDGymRoom,@CodeBed,@NameBed,@PriceDay,@PriceNight) END";
                Cmd.CommandText = sQuery;
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@IdBed", SqlDbType.Int).Value = fIdBed;
                Cmd.Parameters.Add("@IDGymRoom", SqlDbType.Int).Value = fIDGymRoom;
                Cmd.Parameters.Add("@CodeBed", SqlDbType.VarChar).Value = sCodeBed;
                Cmd.Parameters.Add("@NameBed", SqlDbType.NVarChar).Value = sNameBed;
                Cmd.Parameters.Add("@PriceDay", SqlDbType.NVarChar).Value = fPriceDay;
                Cmd.Parameters.Add("@PriceNight", SqlDbType.Int).Value = fPriceNight;
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

        #region UpdateInstruments
        public bool UpdateInstruments(int fIDInstruments, string sCodeInstruments, string sNameInstruments, int fIDUnit, double fPriceIn, double fPriceOut, string sNameSearch)
        {
            bool flag;
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                string sQuery = "IF EXISTS (SELECT * FROM TblInstruments WHERE TblInstruments.IDInstruments=@IDInstruments) " +
                                            " BEGIN UPDATE TblInstruments SET CodeInstruments = @CodeInstruments " +
                                            "      ,NameInstruments = @NameInstruments" +
                                            "      ,IDUnit = @IDUnit" +
                                            "      ,PriceIn = @PriceIn" +
                                            "      ,PriceOut = @PriceOut" +
                                            "      ,NameSearch = @NameSearch" +
                                            " WHERE TblInstruments.IDInstruments=@IDInstruments " +
                                            " END " +
                                            " ELSE BEGIN INSERT INTO TblInstruments(CodeInstruments,NameInstruments,IDUnit,PriceIn,PriceOut,NameSearch) " +
                                            " VALUES(@CodeInstruments,@NameInstruments,@IDUnit,@PriceIn,@PriceOut,@NameSearch) END";
                Cmd.CommandText = sQuery;
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@IDInstruments", SqlDbType.Int).Value = fIDInstruments;
                Cmd.Parameters.Add("@CodeInstruments", SqlDbType.VarChar).Value = sCodeInstruments;
                Cmd.Parameters.Add("@NameInstruments", SqlDbType.NVarChar).Value = sNameInstruments;
                Cmd.Parameters.Add("@NameSearch", SqlDbType.NVarChar).Value = sNameSearch;
                Cmd.Parameters.Add("@IDUnit", SqlDbType.Int).Value = fIDUnit;
                Cmd.Parameters.Add("@PriceIn", SqlDbType.Float).Value = fPriceIn;
                Cmd.Parameters.Add("@PriceOut", SqlDbType.Float).Value = fPriceOut;
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

        #region UpdatePartner
        public bool UpdatePartner(int sIDPartner, int sIDGender, string sCodePartner, int sIDPartnerGroup, int fIDPartnerType, string sNamePartner, DateTime fBirthday, string sPhone, string sAddress, string sNameSearch, string sNote,  DateTime sStartDate, bool sActive, bool sHide, int sIDEmp, string sSoCMND, string sTenNgNha, string sSDTNgNha)
        {
            bool flag;
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                string sQuery = "IF EXISTS (SELECT * FROM TblPartner WHERE TblPartner.IDPartner=@IDPartner) " +
                                            " BEGIN UPDATE TblPartner SET CodePartner = @CodePartner " +
                                            "      ,IDGender = @IDGender" +
                                            "      ,IDPartnerGroup = @IDPartnerGroup" +
                                            "      ,IDPartnerType = @IDPartnerType" +
                                            "      ,NamePartner = @NamePartner" +
                                            "      ,Birthday = @Birthday" +
                                            "      ,Phone = @Phone" +
                                            "      ,Address = @Address " +
                                            "      ,NameSearch = @NameSearch " +
                                            "      ,Note = @Note " +
                                            "      ,StartDate = @StartDate " +
                                            "      ,Hide = @Hide " +
                                            "      ,IDEmp = @IDEmp " +
                                            "      ,SoCMND = @SoCMND,TenNguoiNha = @TenNguoiNha,SDTNguoiNha = @SDTNguoiNha "+
                                            " WHERE TblPartner.IDPartner=@IDPartner " +
                                            " END " +
                                            " ELSE BEGIN INSERT INTO TblPartner(CodePartner,IDGender,IDPartnerGroup,IDPartnerType,NamePartner,Birthday,Phone,Address,NameSearch,Note,StartDate,Active,Hide,IDEmp,SoCMND,TenNguoiNha,SDTNguoiNha) " +
                                            " VALUES(@CodePartner,@IDGender,@IDPartnerGroup,@IDPartnerType,@NamePartner,@Birthday,@Phone,@Address,@NameSearch,@Note,@StartDate,@Active,@Hide,@IDEmp,@SoCMND,@TenNguoiNha,@SDTNguoiNha) END";
                Cmd.CommandText = sQuery;
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@IDPartner", SqlDbType.Int).Value = sIDPartner;
                Cmd.Parameters.Add("@IDGender", SqlDbType.Int).Value = sIDGender;
                Cmd.Parameters.Add("@CodePartner", SqlDbType.VarChar).Value = sCodePartner;
                Cmd.Parameters.Add("@IDPartnerGroup", SqlDbType.Int).Value = sIDPartnerGroup;
                Cmd.Parameters.Add("@IDPartnerType", SqlDbType.Int).Value = fIDPartnerType;
                Cmd.Parameters.Add("@NamePartner", SqlDbType.NVarChar).Value = sNamePartner;
                Cmd.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = fBirthday;
                Cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = sPhone;
                Cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = sAddress;
                Cmd.Parameters.Add("@NameSearch", SqlDbType.NVarChar).Value = sNameSearch;
                Cmd.Parameters.Add("@Note", SqlDbType.NVarChar).Value = sNote;
                Cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = sStartDate;
                Cmd.Parameters.Add("@Active", SqlDbType.Bit).Value = sActive;
                Cmd.Parameters.Add("@Hide", SqlDbType.Bit).Value = sHide;
                Cmd.Parameters.Add("@IDEmp", SqlDbType.Int).Value = sIDEmp;
                Cmd.Parameters.Add("@SoCMND", SqlDbType.VarChar).Value = sSoCMND;
                Cmd.Parameters.Add("@TenNguoiNha", SqlDbType.NVarChar).Value = sTenNgNha;
                Cmd.Parameters.Add("@SDTNguoiNha", SqlDbType.VarChar).Value = sSDTNgNha;
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

        #region UpdatePartner
        public bool UpdatePartnerRegis(int sIDPartnerRegis, int sIDPartner, int sIDGymRoom, int sIDTypeGym, int sIDPackGym, int sTimes, double sPrice, double sTotalPay, double sPayed, DateTime sStartDate, DateTime sEndDate,
                                bool sActive, int sIDEmp, string sReExIDM, string sOriginalBill, string sNote, int sDayLeft, bool sFreeze, string sIDRootBill)
        {
            bool flag;
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                string sQuery = "IF EXISTS (SELECT * FROM TblPartnerRegis WHERE TblPartnerRegis.IDPartnerRegis=@IDPartnerRegis) " +
                                            " BEGIN UPDATE TblPartnerRegis SET IDGymRoom = @IDGymRoom " +
                                            "      ,IDTypeGym = @IDTypeGym" +
                                            "      ,IDPackGym = @IDPackGym" +
                                            "      ,Times = @Times" +
                                            "      ,Price = @Price" +
                                            "      ,TotalPay = @TotalPay" +
                                            "      ,Payed = @Payed" +
                                            "      ,StartDate = @StartDate" +
                                            "      ,EndDate = @EndDate" +
                                            "      ,Active = @Active" +
                                            "      ,IDEmp = @IDEmp" +
                                            "      ,Note = @Note" +
                                            "      ,DayLeft = @DayLeft" +
                                            "      ,Freeze = @Freeze" +
                                            " WHERE TblPartnerRegis.IDPartnerRegis=@IDPartnerRegis " +
                                            " END " +
                                "ELSE BEGIN INSERT INTO TblPartnerRegis(IDPartner ,IDGymRoom ,IDTypeGym ,IDPackGym ,Times, Price, TotalPay, Payed ,"+
                                "StartDate ,EndDate ,Active, IDEmp ,ReExIDM ,OriginalBill, Note, DayLeft, Freeze, IDRootBill) " +
                                " VALUES(@IDPartner ,@IDGymRoom ,@IDTypeGym ,@IDPackGym  ,@Times, @Price, @TotalPay, @Payed ,@StartDate ," +
                                "@EndDate ,@Active, @IDEmp ,@ReExIDM ,@OriginalBill, @Note, @DayLeft, @Freeze, @IDRootBill) END";
                Cmd.CommandText = sQuery;
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@IDPartnerRegis", SqlDbType.Int).Value = sIDPartnerRegis;
                Cmd.Parameters.Add("@IDPartner", SqlDbType.Int).Value = sIDPartner;
                Cmd.Parameters.Add("@IDGymRoom", SqlDbType.Int).Value = sIDGymRoom;
                Cmd.Parameters.Add("@IDTypeGym", SqlDbType.Int).Value = sIDTypeGym;
                Cmd.Parameters.Add("@IDPackGym", SqlDbType.Int).Value = sIDPackGym;
                Cmd.Parameters.Add("@Times", SqlDbType.Int).Value = sTimes;
                Cmd.Parameters.Add("@Price", SqlDbType.Int).Value = sPrice;
                Cmd.Parameters.Add("@TotalPay", SqlDbType.Int).Value = sTotalPay;
                Cmd.Parameters.Add("@Payed", SqlDbType.Int).Value = sPayed;
                Cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = sStartDate;
                Cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = sEndDate;
                Cmd.Parameters.Add("@Active", SqlDbType.Bit).Value = sActive;
                Cmd.Parameters.Add("@IDEmp", SqlDbType.Int).Value = sIDEmp;
                Cmd.Parameters.Add("@ReExIDM", SqlDbType.VarChar).Value = sReExIDM;
                Cmd.Parameters.Add("@OriginalBill", SqlDbType.VarChar).Value = sOriginalBill;
                Cmd.Parameters.Add("@Note", SqlDbType.NVarChar).Value = sNote;
                Cmd.Parameters.Add("@DayLeft", SqlDbType.Int).Value = sDayLeft;
                Cmd.Parameters.Add("@Freeze", SqlDbType.Bit).Value = sFreeze;
                Cmd.Parameters.Add("@IDRootBill", SqlDbType.Int).Value = sIDRootBill;
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

        #region UpdateFreezeHistory
        public bool UpdateFreezeHistory(int sIDPartnerRegis, int sIDPartner, DateTime sDateFreezeHistory, bool sFreeze, string sUserCreate)
        {
            bool flag;
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                string sQuery = "INSERT INTO TblFreezeHistory (IDPartnerRegis ,IDPartner ,DateFreezeHistory ,Freeze ,UserCreate) "+
                Environment.NewLine + " VALUES (@IDPartnerRegis, @IDPartner, @DateFreezeHistory, @Freeze, @UserCreate)";
                Cmd.CommandText = sQuery;
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@IDPartnerRegis", SqlDbType.Int).Value = sIDPartnerRegis;
                Cmd.Parameters.Add("@IDPartner", SqlDbType.Int).Value = sIDPartner;
                Cmd.Parameters.Add("@DateFreezeHistory", SqlDbType.DateTime).Value = sDateFreezeHistory;
                Cmd.Parameters.Add("@Freeze", SqlDbType.Bit).Value = sFreeze;
                Cmd.Parameters.Add("@UserCreate", SqlDbType.NVarChar).Value = sUserCreate;
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

        #region UpdateEmp
        public bool UpdateEmp(int fIdEmp,string sCodeEmp,int fIDEmpGroup,string sNameEmp,int fIDGender,DateTime fBirthday,string sAddress,string sPhone)
        {
            bool flag;
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                string sQuery = "IF EXISTS (SELECT * FROM TblEmp WHERE TblEmp.IdEmp=@IdEmp) " +
                                            " BEGIN UPDATE TblEmp SET CodeEmp = @CodeEmp " +
                                            "      ,IDEmpGroup = @IDEmpGroup" +
                                            "      ,NameEmp = @NameEmp" +
                                            "      ,Birthday = @Birthday" +
                                            "      ,IDGender = @IDGender" +
                                            "      ,Address = @Address" +
                                            "      ,Phone = @Phone " +
                                            " WHERE TblEmp.IdEmp=@IdEmp " +
                                            " END " +
                                            " ELSE BEGIN INSERT INTO TblEmp(CodeEmp,IDEmpGroup,NameEmp,IDGender,Birthday,Address,Phone) " +
                                            " VALUES(@CodeEmp,@IDEmpGroup,@NameEmp,@IDGender,@Birthday,@Address,@Phone) END";
                Cmd.CommandText = sQuery;
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@IdEmp", SqlDbType.Int).Value = fIdEmp;
                Cmd.Parameters.Add("@CodeEmp", SqlDbType.NVarChar).Value = sCodeEmp;
                Cmd.Parameters.Add("@IDEmpGroup", SqlDbType.Int).Value = fIDEmpGroup;
                Cmd.Parameters.Add("@NameEmp", SqlDbType.NVarChar).Value = sNameEmp;
                Cmd.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = fBirthday;
                Cmd.Parameters.Add("@IDGender", SqlDbType.Int).Value = fIDGender;
                Cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = sAddress;
                Cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = sPhone;
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

        #region UpdatePackGym
        public bool UpdatePackGym(int sIDPackGym, string sCodePackGym, string sNamePackGym, int sIDTypeGym, int sTimes,double sPrice, double sTotalMoney)
        {
            bool flag;
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                string sQuery = "IF EXISTS (SELECT * FROM TblPackGym WHERE TblPackGym.IDPackGym = @IDPackGym ) " +
                                            " BEGIN UPDATE TblPackGym SET CodePackGym = @CodePackGym " +
                                            "      ,NamePackGym = @NamePackGym" +
                                            "      ,IDTypeGym = @IDTypeGym" +
                                            "      ,Times = @Times" +
                                            "      ,Price = @Price" +
                                            "      ,TotalMoney = @TotalMoney" +
                                            " WHERE TblPackGym.IDPackGym = @IDPackGym " +
                                            " END " +
                                            " ELSE BEGIN INSERT INTO TblPackGym(CodePackGym,NamePackGym,IDTypeGym,Times,Price,TotalMoney) " +
                                            " VALUES(@CodePackGym,@NamePackGym,@IDTypeGym,@Times,@Price,@TotalMoney) END";
                Cmd.CommandText = sQuery;
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@IDPackGym", SqlDbType.Int).Value = sIDPackGym;
                Cmd.Parameters.Add("@CodePackGym", SqlDbType.NVarChar).Value = sCodePackGym;
                Cmd.Parameters.Add("@NamePackGym", SqlDbType.NVarChar).Value = sNamePackGym;
                Cmd.Parameters.Add("@IDTypeGym", SqlDbType.Int).Value = sIDTypeGym;
                Cmd.Parameters.Add("@Times", SqlDbType.Int).Value = sTimes;
                Cmd.Parameters.Add("@Price", SqlDbType.Int).Value = sPrice;
                Cmd.Parameters.Add("@TotalMoney", SqlDbType.Float).Value = sTotalMoney;
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

        #region UpdateMember
        public bool UpdateMember(int fIDPartner, string sCodePartner, int fIDPartnerGroup, int fIDPartnerType, string sNamePartner, DateTime fBirthday, string sPhone, string sAddress, string sNameSearch)
        {
            bool flag;
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                string sQuery = "IF EXISTS (SELECT * FROM TblPartner WHERE TblPartner.IDPartner=@IDPartner) " +
                                            " BEGIN UPDATE TblPartner SET CodePartner = @CodePartner " +
                                            "      ,NamePartner = @NamePartner" +
                                            "      ,Birthday = @Birthday" +
                                            "      ,Phone = @Phone" +
                                            "      ,Address = @Address" +
                                            "      ,Note = @Note" +
                                            "      ,NameGymRoom = @NameGymRoom" +
                                            "      ,NamePackGym = @NamePackGym" +
                                            " WHERE TblPartner.IDPartner=@IDPartner " +
                                            " END " +
                                            " ELSE BEGIN INSERT INTO TblPartner(CodePartner,NamePartner,Birthday,Phone,Birthday,Phone,Address,NameSearch) " +
                                            " VALUES(@CodePartner,@IDPartnerGroup,@IDPartnerType,@NamePartner,@Birthday,@Phone,@Address,@NameSearch) END";
                Cmd.CommandText = sQuery;
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@IDPartner", SqlDbType.Int).Value = fIDPartner;
                Cmd.Parameters.Add("@CodePartner", SqlDbType.VarChar).Value = sCodePartner;
                Cmd.Parameters.Add("@IDPartnerGroup", SqlDbType.Int).Value = fIDPartnerGroup;
                Cmd.Parameters.Add("@IDPartnerType", SqlDbType.Int).Value = fIDPartnerType;
                Cmd.Parameters.Add("@NamePartner", SqlDbType.NVarChar).Value = sNamePartner;
                Cmd.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = fBirthday;
                Cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = sPhone;
                Cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = sAddress;
                Cmd.Parameters.Add("@NameSearch", SqlDbType.NVarChar).Value = sNameSearch;
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

        #region UpdateMember
        public bool UpdateImge(int sIDPartner,string sImage)
        {
            bool flag;
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                string sQuery = "IF EXISTS (SELECT [Image] FROM TblPartner WHERE TblPartner.IDPartner=@IDPartner) " +
                                            " BEGIN UPDATE TblPartner SET [Image] = @Image " +
                                            " WHERE TblPartner.IDPartner=@IDPartner " +
                                            " END " +
                                            " ELSE BEGIN INSERT INTO TblPartner([Image]) " +
                                            " VALUES(@Image) END";
                Cmd.CommandText = sQuery;
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@IDPartner", SqlDbType.Int).Value = sIDPartner;
                Cmd.Parameters.Add("@Image", SqlDbType.NText).Value = sImage;
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

        #region UpdateTimeInDay
        public bool UpdateTimeInDay(string sIDTimeInDay, string sStartTime, string sFinishTime, string sIDPartnerRegis)
        {
            bool flag;
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                string sQuery = "IF EXISTS (SELECT IDTimeInDay FROM TblTimeInDay WHERE TblTimeInDay.IDTimeInDay=@IDTimeInDay) " +
                                            " BEGIN UPDATE TblTimeInDay SET StartTime = @StartTime,FinishTime = @FinishTime  " +
                                            " WHERE TblTimeInDay.IDTimeInDay=@IDTimeInDay " +
                                            " END " +
                                            " ELSE BEGIN INSERT INTO TblTimeInDay (StartTime,FinishTime,IDPartnerRegis) " +
                                            " VALUES(@StartTime,@FinishTime,@IDPartnerRegis) END";
                Cmd.CommandText = sQuery;
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@IDTimeInDay", SqlDbType.VarChar).Value = sIDTimeInDay;
                Cmd.Parameters.Add("@StartTime", SqlDbType.NVarChar).Value = sStartTime;
                Cmd.Parameters.Add("@FinishTime", SqlDbType.NVarChar).Value = sFinishTime;
                Cmd.Parameters.Add("@IDPartnerRegis", SqlDbType.Int).Value = sIDPartnerRegis;
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

        #region UpdateHistory
        public bool UpdateHistory(int sIDPartner, int sIDPartnerRegis, int sIDPartnerGroup, int sIDPartnerType, string sCodePartner, string sNamePartner, int sIDGender, DateTime sBirthDay, string sPhone, string sAddress, int sCount, int sIDGymRoom, int sIDPackGym, DateTime sDateSearch, DateTime DateIn)
        {
            bool flag;
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                //if (Device == false)
                //{
                //    string sQuery = "INSERT INTO tblWorkoutHistory(IDPartner,IDPartnerRegis,IDPartnerGroup,IDPartnerType,CodePartner,NamePartner,IDGender,BirthDay,Phone,Address,Count,IDGymRoom,IDPackGym,DateIn,DateSearch) " +
                //                                " VALUES(@IDPartner,@IDPartnerRegis,@IDPartnerGroup,@IDPartnerType,@CodePartner,@NamePartner,@IDGender,@BirthDay,@Phone,@Address,@Count,@IDGymRoom,@IDPackGym,@DateIn,@DateSearch)";
                //}
                //else
                //{
                string sQuery = "INSERT INTO tblWorkoutHistory(IDPartner,IDPartnerRegis,IDPartnerGroup,IDPartnerType,CodePartner,NamePartner,IDGender,BirthDay,Phone,Address,Count,IDGymRoom,IDPackGym,DateIn,DateSearch) " +
                    Environment.NewLine + " VALUES(@IDPartner,@IDPartnerRegis,@IDPartnerGroup,@IDPartnerType,@CodePartner,@NamePartner,@IDGender,@BirthDay,@Phone,@Address,@Count,@IDGymRoom,@IDPackGym,@DateIn,@DateSearch)";
                //}
                Cmd.CommandText = sQuery;
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@IDPartner", SqlDbType.Int).Value = sIDPartner;
                Cmd.Parameters.Add("@IDPartnerRegis", SqlDbType.Int).Value = sIDPartnerRegis;
                Cmd.Parameters.Add("@IDPartnerGroup", SqlDbType.Int).Value = sIDPartnerGroup;
                Cmd.Parameters.Add("@IDPartnerType", SqlDbType.Int).Value = sIDPartnerType;
                Cmd.Parameters.Add("@CodePartner", SqlDbType.VarChar).Value = sCodePartner;
                Cmd.Parameters.Add("@NamePartner", SqlDbType.NVarChar).Value = sNamePartner;
                Cmd.Parameters.Add("@IDGender", SqlDbType.Int).Value = sIDGender;
                Cmd.Parameters.Add("@BirthDay", SqlDbType.DateTime).Value = sBirthDay;
                Cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = sPhone;
                Cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = sAddress;
                Cmd.Parameters.Add("@Count", SqlDbType.Int).Value = sCount;
                Cmd.Parameters.Add("@IDGymRoom", SqlDbType.Int).Value = sIDGymRoom;
                Cmd.Parameters.Add("@IDPackGym", SqlDbType.Int).Value = sIDPackGym;
                Cmd.Parameters.Add("@DateIn", SqlDbType.DateTime).Value = DateIn;
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

        #region UpdateTimeKeeper
        public void UpdateTimeKeeper(int sIdEmp, int sTypeInOut, DateTime sTimeInOut)
        {
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                if (!checkIdEmp(sIdEmp, sTimeInOut.ToString("yyyyMMdd"), sTypeInOut))
                {
                    SqlCommand Cmd = sqlCon.CreateCommand();
                    string sQuery = "IF EXISTS (SELECT CodeEmp FROM TblEmp WHERE CodeEmp=@IdEmp AND CodeEmp<>'') "+
                                    "BEGIN INSERT INTO TblTimeKeeper (IdEmp ,TypeInOut ,TimeInOut) VALUES(@IdEmp ,@TypeInOut ,@TimeInOut) END";
                    Cmd.CommandText = sQuery;
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Parameters.Add("@IdEmp", SqlDbType.Int).Value = sIdEmp;
                    Cmd.Parameters.Add("@TypeInOut", SqlDbType.Int).Value = sTypeInOut;
                    Cmd.Parameters.Add("@TimeInOut", SqlDbType.DateTime).Value = sTimeInOut;
                    Cmd.ExecuteNonQuery();
                }
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

        #region method checkIdEmp
        public bool checkIdEmp(int IdEmp, string TimeInOut, int TypeInOut)
        {
            bool tmpValue = false;
            try
            {
                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand Cmd = sqlCon.CreateCommand();
                Cmd.CommandText = "SELECT * FROM TblTimeKeeper WHERE IdEmp = @IdEmp AND Convert(nvarchar,TimeInOut,112)=@TimeInOut AND TypeInOut=@TypeInOut";
                Cmd.Parameters.Add("IdEmp", SqlDbType.Int).Value = IdEmp;
                Cmd.Parameters.Add("TypeInOut", SqlDbType.Int).Value = TypeInOut;
                Cmd.Parameters.Add("TimeInOut", SqlDbType.NVarChar).Value = TimeInOut;
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

        #region method setTimeShift
        public bool setTimeShift(int IdEmp, string sDateSearch1, string sDateSearch2)
        {
            DataTable objTab=GetTimeShift();
            bool tmpValue = false;
            string sWhere="";
            try
            {
                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand Cmd = sqlCon.CreateCommand();
                if(IdEmp!=0) sWhere = " AND IdEmp = @IdEmp";
                Cmd.CommandText = "SELECT ID,CodeEmp,NameEmp,Convert(nvarchar,TimeKeeping,103) AS TimeKeeping, HourStart, HourFinish, Delay FROM TblTmpTimeKeeper " +
                            "WHERE Convert(nvarchar,TimeKeeping,112) >= '" + sDateSearch1 + "' " +
                            "AND  Convert(nvarchar,TimeKeeping,112) <='" + sDateSearch2 + "' " + sWhere;
                Cmd.Parameters.Add("IdEmp", SqlDbType.Int).Value = IdEmp;
                SqlDataReader Rd = Cmd.ExecuteReader();
                while (Rd.Read())
                {
                    for (int i = 0; i < objTab.Rows.Count; i++)
                    {
                        double sHourStart = double.Parse(Rd["HourStart"].ToString().Substring(0, 2)) + (double.Parse(Rd["HourStart"].ToString().Substring(3, 2)) / 60);
                        double fHourStart = double.Parse(objTab.Rows[i]["HourStart"].ToString().Substring(0, 2)) + (double.Parse(objTab.Rows[i]["HourStart"].ToString().Substring(0, 2)) / 60);
                        double sHourMorningStart = double.Parse(objTab.Rows[i]["HourMorningStart"].ToString().Substring(0, 2)) + (double.Parse(objTab.Rows[i]["HourMorningStart"].ToString().Substring(0, 2)) / 60);
                        double sHourMorningFinish = double.Parse(objTab.Rows[i]["HourMorningFinish"].ToString().Substring(0, 2)) + (double.Parse(objTab.Rows[i]["HourMorningFinish"].ToString().Substring(0, 2)) / 60);
                        double sDelay = double.Parse(objTab.Rows[i]["Delay"].ToString());
                        if (sHourStart >= sHourMorningStart && sHourStart <= sHourMorningFinish)
                        {
                            if (sHourStart - fHourStart >= sDelay) sDelay = sHourStart - fHourStart;
                            else sDelay = 0;
                            UpdateTmpTimeKeeper(int.Parse(Rd["ID"].ToString()), int.Parse(objTab.Rows[i]["IDTimeShiftConfig"].ToString()),sDelay);
                        }
                    }
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

        #region UpdateTmpTimeKeeper
        public void UpdateTmpTimeKeeper(int ID, int IDTimeShiftConfig, double Delay)
        {
            SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            sqlCon.Open();
            try
            {
                SqlCommand Cmd = sqlCon.CreateCommand();
                string sQuery = "UPDATE TblTmpTimeKeeper SET IDTimeShiftConfig=@IDTimeShiftConfig,Delay=@Delay WHERE ID=@ID";
                Cmd.CommandText = sQuery;
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add("@IDTimeShiftConfig", SqlDbType.Int).Value = IDTimeShiftConfig;
                Cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                Cmd.Parameters.Add("@Delay", SqlDbType.Float).Value = Delay;
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

        #region GetTimeShift
        public DataTable GetTimeShift()
        {
            DataTable objTable = new DataTable();
            try
            {
                SqlConnection sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandText = "SELECT * FROM TblTimeShiftConfig";
                cmd.CommandType = CommandType.Text;
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

    }
}
