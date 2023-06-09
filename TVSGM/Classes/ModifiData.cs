using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TVSGM.Classes
{
    public class ModifiData
    {
        public void Modifi()
        {
            try
            {
                SqlConnection Sqlcon = new SqlConnection(TVSSys.Connection.strConnection);
                Sqlcon.Open();
                SqlCommand cmd = Sqlcon.CreateCommand();
                string sql = "";


                #region TẠO BẢNG TblTimeKeeper
                sql = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE [table_name]='TblTimeKeeper') ";
                sql += " BEGIN CREATE TABLE [dbo].[TblTimeKeeper]( ";
	            sql += " [ID] [int] IDENTITY(1,1) NOT NULL, ";
	            sql += " [IdEmp] [int] NULL, ";
	            sql += " [TypeInOut] [int] NULL, ";
	            sql += " [TimeInOut] [datetime] NULL, ";
                sql += " CONSTRAINT [PK_TblTimeKeeper] PRIMARY KEY CLUSTERED ";
                sql += " ( ";
	            sql += " [ID] ASC ";
                sql += " )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ";
                sql += " ) ON [PRIMARY] ";
                sql += " END";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC TẠO BẢNG TblTimeKeeper

                #region TẠO BẢNG TblTimeKeeperConfig
                sql = " IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE [table_name]='TblTimeKeeperConfig') ";
                sql += " BEGIN CREATE TABLE [dbo].[TblTimeKeeperConfig]( ";
	            sql += " [ID] [int] NULL, ";
	            sql += " [HourStart] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [HourLunchStart] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [HourLunchFinish] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [HourFinish] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [NumHour] [float] NULL, ";
	            sql += " [NumTimekeeping] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [HourMorningStart] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [HourMorningFinish] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [HourAfternoonStart] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [HourAfternoonFinish] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [Delay] [float] NULL ";
                sql += " ) ON [PRIMARY]";
                sql += " END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC TẠO BẢNG TblTimeKeeperConfig

                #region TẠO BẢNG TblTmpTimeKeeper
                sql = " IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE [table_name]='TblTmpTimeKeeper') ";
                sql += " BEGIN CREATE TABLE [dbo].[TblTmpTimeKeeper]( ";
	            sql += " [ID] [int] IDENTITY(1,1) NOT NULL, ";
	            sql += " [IdEmp] [int] NULL, ";
	            sql += " [CodeEmp] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [NameEmp] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [TimeKeeping] [datetime] NULL, ";
	            sql += " [HourStart] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [HourLunchStart] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [HourLunchFinish] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [HourFinish] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
                sql += " [IDTimeShiftConfig] [int] NULL, ";
                sql += " [Delay] [float] NULL, ";
                sql += " CONSTRAINT [PK_TblTmpTimeKeeper] PRIMARY KEY CLUSTERED  ";
                sql += " ( ";
	            sql += " [ID] ASC ";
                sql += " )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ";
                sql += " ) ON [PRIMARY]";
                sql += " END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC TẠO BẢNG TblTmpTimeKeeper

                #region TẠO BẢNG TblTimeShiftConfig
                sql = " IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE [table_name]='TblTimeShiftConfig') ";
                sql += " BEGIN CREATE TABLE [dbo].[TblTimeShiftConfig]( ";
	            sql += " [IDTimeShiftConfig] [int] IDENTITY(1,1) NOT NULL, ";
	            sql += " [CodeShift] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [NameTimeShiftConfig] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [HourStart] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [HourFinish] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [NumHour] [float] NULL, ";
	            sql += " [NumTimeKeeping] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [HourMorningStart] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [HourMorningFinish] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [Delay] [float] NULL, ";
                sql += " CONSTRAINT [PK_TblTimeShiftConfig] PRIMARY KEY CLUSTERED  ";
                sql += " ( ";
	            sql += " [IDTimeShiftConfig] ASC ";
                sql += " )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ";
                sql += " ) ON [PRIMARY]";
                sql += " END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC TẠO BẢNG TblTimeShiftConfig

                #region TẠO BẢNG TblTimeInDay
                sql = " IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE [table_name]='TblTimeInDay') ";
                sql += " BEGIN CREATE TABLE [dbo].[TblTimeInDay]( ";
	            sql += " [IDTimeInDay] [int] IDENTITY(1,1) NOT NULL, ";
	            sql += " [StartTime] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [FinishTime] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [IDPartnerRegis] [int] NULL, ";
                sql += "CONSTRAINT [PK_TblTimeInDay] PRIMARY KEY CLUSTERED  ";
                sql += "( ";
	            sql += "[IDTimeInDay] ASC ";
                sql += ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ";
                sql += ") ON [PRIMARY]";
                sql += " END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC TẠO BẢNG TblTimeInDay

                #region TẠO BẢNG TblBed
                sql = " IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE [table_name]='TblBed') ";
                sql += " BEGIN CREATE TABLE [dbo].[TblBed]( ";
	            sql += " [IdBed] [int] IDENTITY(1,1) NOT NULL, ";
	            sql += " [CodeBed] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [NameBed] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [Poss] [int] NULL CONSTRAINT [DF_TblBed_Poss]  DEFAULT ((0)), ";
	            sql += " [State] [smallint] NULL CONSTRAINT [DF_TblBed_State]  DEFAULT ((0)), ";
	            sql += " [PriceDay] [float] NULL CONSTRAINT [DF_TblBed_PriceDay]  DEFAULT ((0)), ";
	            sql += " [PriceNight] [float] NULL CONSTRAINT [DF_TblBed_PriceNight]  DEFAULT ((0)), ";
                sql += " [IdFloor] [int] NULL, ";
                sql += " [IDGymRoom] [int] NULL, ";
                sql += " CONSTRAINT [PK_TblBed] PRIMARY KEY CLUSTERED  ";
                sql += " ( ";
                sql += " [IdBed] ASC ";
                sql += " )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ";
                sql += " ) ON [PRIMARY]";
                sql += " END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC TẠO BẢNG TblBed

                #region TẠO BẢNG TblFloor
                sql = " IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE [table_name]='TblFloor') ";
                sql += " BEGIN CREATE TABLE [dbo].[TblFloor]( ";
                sql += " [IdFloor] [int] IDENTITY(1,1) NOT NULL, ";
	            sql += " [CodeFloor] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [NameFloor] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
	            sql += " [ZoneId] [int] NULL, ";
                sql += " CONSTRAINT [PK_TblFloor] PRIMARY KEY CLUSTERED  ";
                sql += " ( ";
                sql += " [IdFloor] ASC ";
                sql += " )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ";
                sql += " ) ON [PRIMARY]";
                sql += " END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC TẠO BẢNG TblFloor

                #region TẠO BẢNG TblRoomState
                sql = " IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE [table_name]='TblRoomState') ";
                sql += " BEGIN CREATE TABLE [dbo].[TblRoomState]( ";
                sql += " [IdRoomState] [int] IDENTITY(0,1) NOT NULL, ";
                sql += " [NameRoomState] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
                sql += " CONSTRAINT [PK_TblRoomState] PRIMARY KEY CLUSTERED  ";
                sql += " ( ";
                sql += " [IdRoomState] ASC ";
                sql += " )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ";
                sql += " ) ON [PRIMARY]";
                sql += " END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC TẠO BẢNG TblRoomState

                #region TẠO BẢNG TblFreezeHistory
                sql = " IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE [table_name]='TblFreezeHistory') ";
                sql += " BEGIN CREATE TABLE [dbo].[TblFreezeHistory]( ";
                sql += " [IdFreezeHistory] [int] IDENTITY(0,1) NOT NULL, ";
                sql += " [IDPartnerRegis] [int] NULL, ";
                sql += " [IDPartner] [int] NULL, ";
                sql += " [DateFreezeHistory] [datetime] NULL, ";
                sql += " [Freeze] [bit] NULL, ";
                sql += " [UserCreate] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, ";
                sql += " CONSTRAINT [PK_TblFreezeHistory] PRIMARY KEY CLUSTERED  ";
                sql += " ( ";
                sql += " [IdFreezeHistory] ASC ";
                sql += " )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ";
                sql += " ) ON [PRIMARY]";
                sql += " END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC TẠO BẢNG TblRoomState

                #region TẠO CỘT CheckOut CHO BẢNG tblWorkoutHistory
                sql = " IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.columns WHERE [TABLE_NAME]='tblWorkoutHistory' AND COLUMN_NAME='CheckOut') ";
                sql += " BEGIN ALTER TABLE tblWorkoutHistory ADD CheckOut bit END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC TẠO CỘT CheckOut CHO BẢNG tblWorkoutHistory

                #region TẠO CỘT TimeOut CHO BẢNG tblWorkoutHistory
                sql = " IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.columns WHERE [TABLE_NAME]='tblWorkoutHistory' AND COLUMN_NAME='TimeOut') ";
                sql += " BEGIN ALTER TABLE tblWorkoutHistory ADD TimeOut DateTime END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC TẠO CỘT TimeOut CHO BẢNG tblWorkoutHistory

                #region TẠO CỘT IdBed CHO BẢNG tblWorkoutHistory
                sql = " IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.columns WHERE [TABLE_NAME]='tblWorkoutHistory' AND COLUMN_NAME='IdBed') ";
                sql += " BEGIN ALTER TABLE tblWorkoutHistory ADD IdBed int END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC TẠO CỘT IdBed CHO BẢNG tblWorkoutHistory

                #region TẠO CỘT DateAp CHO BẢNG TblBill
                sql = " IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.columns WHERE [TABLE_NAME]='TblBill' AND COLUMN_NAME='DateAp') ";
                sql += " BEGIN ALTER TABLE TblBill ADD DateAp datetime END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC TẠO CỘT IdBed CHO BẢNG tblWorkoutHistory

                #region TẠO CỘT DateAp CHO BẢNG TblBill
                sql = " IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.columns WHERE [TABLE_NAME]='TblBill' AND COLUMN_NAME='Action') ";
                sql += " BEGIN ALTER TABLE TblBill ADD Action bit END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC TẠO CỘT DateAp CHO BẢNG TblBill

                #region TẠO CỘT NoteAction CHO BẢNG TblBill
                sql = " IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.columns WHERE [TABLE_NAME]='TblBill' AND COLUMN_NAME='NoteAction') ";
                sql += " BEGIN ALTER TABLE TblBill ADD NoteAction ntext END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC TẠO CỘT TẠO CỘT NoteAction CHO BẢNG TblBill


                #region Insert into TblRoomState
                sql = " IF NOT EXISTS (SELECT IdRoomState FROM TblRoomState WHERE IdRoomState=0) BEGIN INSERT INTO TblRoomState(NameRoomState) VALUES(N'Trống') END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC Insert into TblRoomState

                #region Insert into TblRoomState
                sql = " IF NOT EXISTS (SELECT IdRoomState FROM TblRoomState WHERE IdRoomState=1) BEGIN INSERT INTO TblRoomState(NameRoomState) VALUES(N'Sử dụng') END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC Insert into TblRoomState

                #region Insert into TabPer
                sql = " IF NOT EXISTS (SELECT PerID FROM TabPer WHERE PerID=310) BEGIN INSERT INTO TabPer(PerID,PerName,PerDes,PStatus,IDgroup) VALUES(310,N'Cho phép xuất danh sách khách hàng ra excel',N'Cho phep xuat danh sach khach hang ra excel',1,3) END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC Insert into TabPer

                #region Insert into TabPer
                sql = " IF NOT EXISTS (SELECT PerID FROM TabPer WHERE PerID=511) BEGIN INSERT INTO TabPer(PerID,PerName,PerDes,PStatus,IDgroup) VALUES(511,N'Báo cáo thành viên sắp hết hạn trong tháng',N'Bao cao thanh vien sap het han trong thang',1,5) END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC Insert into TabPer

                #region Insert into TabPer
                sql = " IF NOT EXISTS (SELECT PerID FROM TabPer WHERE PerID=512) BEGIN INSERT INTO TabPer(PerID,PerName,PerDes,PStatus,IDgroup) VALUES(512,N'Báo cáo lịch sử đóng băng thẻ thành viên',N'Bao cao lich su dong bang the thanh vien',1,5) END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC Insert into TabPer

                #region Insert into TabPer
                sql = " IF NOT EXISTS (SELECT PerID FROM TabPer WHERE PerID=513) BEGIN INSERT INTO TabPer(PerID,PerName,PerDes,PStatus,IDgroup) VALUES(513,N'Báo cáo nhật ký sửa xóa hóa đơn',N'Bao cao nhat ky sua xoa hoa don',1,5) END ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                #endregion KẾT THÚC Insert into TabPer

                EXEQUERY_ALTERTABLE("TblPartner", "Hide", "bit");

                Sqlcon.Close();
                Sqlcon.Dispose();
            }
            catch { }

        }
        private static void EXEQUERY_ALTERTABLE(string sTable, string sColumn, string sType)
        {
            SqlConnection Sqlcon = new SqlConnection(TVSSys.Connection.strConnection);
            Sqlcon.Open();
            SqlCommand cmd = Sqlcon.CreateCommand();
            string sQuery = "";
            sQuery = "   IF NOT EXISTS (SELECT [column_name] FROM information_schema.columns WHERE [table_name] = '" + sTable + "' and column_name = '" + sColumn + "') " +
                    "   BEGIN   " +
                    "       ALTER TABLE " + sTable + " ADD " + sColumn + " " + sType + "  " +
                    "   END     ";
            cmd.CommandText = sQuery;
            cmd.ExecuteNonQuery();
            sQuery = "UPDATE TblPartner SET Hide = 0 WHERE Hide IS NULL";

            cmd.CommandText = sQuery;
            cmd.ExecuteNonQuery();

            Sqlcon.Close();
            Sqlcon.Dispose();
        }

    }
}
