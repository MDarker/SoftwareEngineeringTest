using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CinemaSQLHelper;
using CinemaCommon;

namespace CinemaDAL
{
    public class FilmMsgDAL
    {
        /// <summary>
        /// 获取还没排的影片信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetNoScheduleFilm()
        {
            string sql = " select FilmId,FilmName,FilmTimes,ScheduleTime " +
                " from dbo.FilmsMsg " +
                " where FilmState=1 order by FilmId ";
            return SQLHelper.GetDataTable(sql);
        }

        /// <summary>
        /// 获取全部影片信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllFilmsMsg()
        {
            string sql = " select FilmId,FilmName,FilmTimes,Director,Protagonists," +
                " FilmType,Producers,Country,FilmState,ScheduleTime,Deadline " +
                " from dbo.FilmsMsg " +
                " where FilmState=1 order by FilmId ";
            return SQLHelper.GetDataTable(sql);
        }

        /// <summary>
        /// 添加电影
        /// </summary>
        /// <param name="fmc"></param>
        /// <returns></returns>
        public int AddFilm(FilmMsgCommon fmc)
        {
            if (IsReapt(fmc.FilmId))
            {
                return 0;
            }
            string sql = " insert into FilmsMsg(FilmId,FilmName,FilmTimes,Director,Protagonists," +
                "FilmType,Producers,Country,FilmState,ScheduleTime,Deadline) " +
                " values(@FilmId,@FilmName,@FilmTimes,@Director,@Protagonists," +
                "@FilmType,@Producers,@Country,@FilmState,@ScheduleTime,@Deadline) ";
            SqlParameter[] paras ={
                                     new SqlParameter("@FilmId",SqlDbType.Int,4),
                                     new SqlParameter("@FilmName",SqlDbType.VarChar,50),
                                     new SqlParameter("@FilmTimes",SqlDbType.VarChar,50),
                                     new SqlParameter("@Director",SqlDbType.VarChar,50),
                                     new SqlParameter("@Protagonists",SqlDbType.VarChar,50),
                                     new SqlParameter("@FilmType",SqlDbType.VarChar,50),
                                     new SqlParameter("@Producers",SqlDbType.VarChar,50),
                                     new SqlParameter("@Country",SqlDbType.VarChar,50),
                                     new SqlParameter("@FilmState",SqlDbType.Int,4),
                                     new SqlParameter("@ScheduleTime",SqlDbType.Int,4),
                                     new SqlParameter("@Deadline",SqlDbType.Date)
                                 };
            paras[0].Value = fmc.FilmId;
            paras[1].Value = fmc.FilmName;
            paras[2].Value = fmc.FilmTimes;
            paras[3].Value = fmc.Director;
            paras[4].Value = fmc.Protagonists;
            paras[5].Value = fmc.FilmType;
            paras[6].Value = fmc.Producers;
            paras[7].Value = fmc.Country;
            paras[8].Value = fmc.FilmState;
            paras[9].Value = fmc.ScheduleTime;
            paras[10].Value = fmc.Deadline;
            return SQLHelper.ExecuteNonQuery(sql, paras);
        }

        /// <summary>
        ///  删除电影
        /// </summary>
        /// <param name="filmId"></param>
        /// <returns></returns>
        public int DeleteFilm(int filmId)
        {
            string sql = " delete from FilmsMsg " +
                " where FilmId=@FilmId ";
            SqlParameter para = new SqlParameter("@FilmId", SqlDbType.Int, 4);
            para.Value = filmId;
            return SQLHelper.ExecuteNonQuery(sql, para);
        }

        /// <summary>
        /// 下映过期的电影
        /// </summary>
        /// <param name="nowDate"></param>
        /// <returns></returns>
        public int DownLineOverdueFilm(string nowDate)
        {
            string sql = " select FilmId from dbo.FilmsMsg " +
                " where Deadline<@nowDate ";
            SqlParameter para = new SqlParameter("@nowDate", SqlDbType.Date);
            para.Value = nowDate;
            object obj = SQLHelper.ExecuteScalar(sql, para);
            if (obj == null)
            {
                return 0;
            }
            int filmId = (int)obj;
            return this.FilmDownLine(filmId);
        }

        /// <summary>
        /// 电影下映
        /// </summary>
        /// <param name="filmId"></param>
        /// <returns></returns>
        public int FilmDownLine(int filmId)
        {
            string sql = " update FilmsMsg " +
                " set FilmState=-1 " +
                " where FilmId=@FilmId ";
            SqlParameter para = new SqlParameter("@FilmId", SqlDbType.Int, 4);
            para.Value = filmId;
            return SQLHelper.ExecuteNonQuery(sql, para);
        }

        /// <summary>
        /// 修改电影信息
        /// </summary>
        /// <param name="fmc"></param>
        /// <returns></returns>
        public int ModifyFilm(int oldfilmId, FilmMsgCommon fmc)
        {
            if (oldfilmId != fmc.FilmId)
            {
                if (IsReapt(fmc.FilmId))
                {
                    return 0;
                }
            }
            string sql = " update FilmsMsg " +
                " set FilmId=@FilmId,FilmName=@FilmName,FilmTimes=@FilmTimes," +
                " Director=@Director,Protagonists=@Protagonists," +
                " FilmType=@FilmType,Producers=@Producers," +
                " Country=@Country,Deadline=@Deadline " +
                " where FilmId=@oldfilmId ";
            SqlParameter[] paras ={
                                     new SqlParameter("@FilmId",SqlDbType.Int,4),
                                     new SqlParameter("@FilmName",SqlDbType.VarChar,50),
                                     new SqlParameter("@FilmTimes",SqlDbType.VarChar,50),
                                     new SqlParameter("@Director",SqlDbType.VarChar,50),
                                     new SqlParameter("@Protagonists",SqlDbType.VarChar,50),
                                     new SqlParameter("@FilmType",SqlDbType.VarChar,50),
                                     new SqlParameter("@Producers",SqlDbType.VarChar,50),
                                     new SqlParameter("@Country",SqlDbType.VarChar,50),
                                     new SqlParameter("@Deadline",SqlDbType.Date),
                                     new SqlParameter("@oldfilmId",SqlDbType.Int,4)
                                 };
            paras[0].Value = fmc.FilmId;
            paras[1].Value = fmc.FilmName;
            paras[2].Value = fmc.FilmTimes;
            paras[3].Value = fmc.Director;
            paras[4].Value = fmc.Protagonists;
            paras[5].Value = fmc.FilmType;
            paras[6].Value = fmc.Producers;
            paras[7].Value = fmc.Country;
            paras[8].Value = fmc.Deadline;
            paras[9].Value = oldfilmId;
            return SQLHelper.ExecuteNonQuery(sql, paras);
        }

        /// <summary>
        /// 是否重复
        /// </summary>
        /// <param name="videoHallId"></param>
        /// <returns></returns>
        private bool IsReapt(int filmId)
        {
            string sql = " select COUNT(*) from FilmsMsg " +
                " where FilmId=@filmId ";
            SqlParameter para = new SqlParameter("@filmId", SqlDbType.Int, 4);
            para.Value = filmId;
            int obj = (int)SQLHelper.ExecuteScalar(sql, para);
            if (obj > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 影片是否排过
        /// </summary>
        /// <param name="filmId"></param>
        /// <returns></returns>
        public object IsSchedule(int filmId)
        {
            string sql = " select ScheduleTime from dbo.FilmsMsg " +
                " where FilmId=@Filmid ";
            SqlParameter para = new SqlParameter("@FilmId", SqlDbType.Int, 4);
            para.Value = filmId;
            return SQLHelper.ExecuteScalar(sql, para);
        }

        /// <summary>
        /// 记录排片次数  加 
        /// </summary>
        /// <param name="filmId"></param>
        /// <returns></returns>
        public int AddScheduleTime(int filmId)
        {
            string sql = " update dbo.FilmsMsg " +
                " set ScheduleTime=ScheduleTime+1 " +
                " where FilmId=@FilmId and FilmState=1 ";
            SqlParameter para = new SqlParameter("@FilmId", SqlDbType.Int, 4);
            para.Value = filmId;
            return SQLHelper.ExecuteNonQuery(sql, para);
        }

        /// <summary>
        /// 记录排片次数  减
        /// </summary>
        /// <param name="filmId"></param>
        /// <returns></returns>
        public int SubScheduleTime(int filmId)
        {
            string sql = " update dbo.FilmsMsg " +
                " set ScheduleTime=ScheduleTime-1 " +
                " where FilmId=@FilmId and FilmState=1 ";
            SqlParameter para = new SqlParameter("@FilmId", SqlDbType.Int, 4);
            para.Value = filmId;
            return SQLHelper.ExecuteNonQuery(sql, para);
        }


        #region 获取影片信息
        /// <summary>
        ///获取影片信息
        /// </summary>
        /// <param name="fileName"></param>
        public SqlDataReader GetFilmMsg(string filmName)
        {
            string sql = " select * from filmsMsg " +
            " where FilmName='" + filmName + "'";
            return SQLHelper.ExecuteReader(sql, null);
        }
        #endregion

        #region 获取放映列表
        /// <summary>
        /// 获取放映列表
        /// </summary>
        public DataTable GetFilmPlayList(string date)
        {
            string sql = " select * from [dbo].[FilmSchedule] " +
                " where ReleaseDates>='" + date + "' ";
            return SQLHelper.GetDataTable(sql);
        }
        #endregion

        #region 获取每场电影卖出的票数
        /// <summary>
        ///获取每场电影卖出的票数
        /// </summary>
        /// <param name="ticketCounts"></param>
        /// <param name="playTimes"></param>
        /// <param name="filmId"></param>
        public int GetTicketCounts(int ticketCounts, string filmBeginTime, string filmEndTime, int filmId)
        {
            string sql = "update FilmSchedule " +
                " set SellTickets+=@SellTickets " +
                " where FilmBeginTime=@FilmBeginTime and FilmId=@FilmId and FilmEndTime=@FilmEndTime";
            SqlParameter[] paras ={
                                     new SqlParameter("@SellTickets",SqlDbType.Int,4),
                                     new SqlParameter("@FilmBeginTime",SqlDbType.VarChar,50),
                                     new SqlParameter("@FilmId",SqlDbType.Int,4),
                                     new SqlParameter("@FilmEndTime",SqlDbType.VarChar,50),
                                 };
            paras[0].Value = ticketCounts;
            paras[1].Value = filmBeginTime;
            paras[2].Value = filmId;
            paras[3].Value = filmEndTime;
            return SQLHelper.ExecuteNonQuery(sql, paras);
        }
        #endregion


        #region  获取数据库中已有的指定日期的电影，指定厅的已的各座位的信息（根据已售出，被锁定，可买三中情况划分）
        /// <summary>
        /// 获取数据库中已有的指定日期的电影，指定厅的已的各座位的信息（已售出，被锁定，可买）
        /// </summary>
        /// <param name="situlationOfTickets"></param>
        public SqlDataReader GetSitulationOfTickets(SitulationOfTickets ticketMsgs)
        {
            string sql = "select SeatsNumber from [dbo].[SitulationOfTickets]";

            sql += "where ReleaseDates=@ReleaseDates  and VideoHallId =@VideoHallId "
                    + "and Playtimes=@Playtimes and FilmName=@FilmName and SeatsState=@SeatsState";
            SqlParameter[] paras ={
                                   new SqlParameter("@ReleaseDates",SqlDbType.VarChar,50 ),
                                   new SqlParameter("@VideoHallId",SqlDbType.Int,4 ),
                                   new SqlParameter("@Playtimes",SqlDbType.VarChar,50 ),
                                   new SqlParameter("@FilmName",SqlDbType.VarChar,50 ),
                                   new SqlParameter("@SeatsState",SqlDbType.Int,4  )
                                  };
            paras[0].Value = ticketMsgs.ReleaseDates;
            paras[1].Value = ticketMsgs.videoHallId;
            paras[2].Value = ticketMsgs.Playtime;
            paras[3].Value = ticketMsgs.FilmName;
            paras[4].Value = ticketMsgs.SeatsState;
            return SQLHelper.ExecuteReader(sql, paras);
        }
        #endregion

        #region  获取数据库中已有的指定日期的电影，指定厅的指定座位状态的信息
        /// <summary>
        /// 获取数据库中已有的指定日期的电影，指定厅的指定座位状态的信息
        /// </summary>
        /// <param name="situlationOfTickets"></param>
        public SqlDataReader GetSeatStates(SitulationOfTickets ticketMsgs)
        {
            string sql = "select SeatsState from [dbo].[SitulationOfTickets]";

            sql += "where ReleaseDates=@ReleaseDates  and VideoHallId =@VideoHallId "
                    + "and Playtimes=@Playtimes and FilmName=@FilmName and SeatsNumber=@SeatsNumber";
            SqlParameter[] paras ={
                                   new SqlParameter("@ReleaseDates",SqlDbType.VarChar,50 ),
                                   new SqlParameter("@VideoHallId",SqlDbType.Int,4 ),
                                   new SqlParameter("@Playtimes",SqlDbType.VarChar,50 ),
                                   new SqlParameter("@FilmName",SqlDbType.VarChar,50 ),
                                   new SqlParameter("@SeatsNumber",SqlDbType.VarChar,10  )
                                  };
            paras[0].Value = ticketMsgs.ReleaseDates;
            paras[1].Value = ticketMsgs.videoHallId;
            paras[2].Value = ticketMsgs.Playtime;
            paras[3].Value = ticketMsgs.FilmName;
            paras[4].Value = ticketMsgs.SeatsNumber;
            return SQLHelper.ExecuteReader(sql, paras);
        }
        #endregion

        #region 验证邀请码的正确性，正确则返回该邀请码的作用
        /// <summary>
        /// 验证邀请码的正确性，正确则返回该邀请码的作用
        /// </summary>
        /// <param name="invitationCode"></param>
        /// <returns></returns>
        public SqlDataReader CheckInvitationCode(string invitationCode)
        {
            string sql = "select * from [dbo].[InviteCode]" +
                "where InvitationCode=@InvitationCode";
            SqlParameter para = new SqlParameter("@InvitationCode", SqlDbType.VarChar, 50);
            para.Value = invitationCode;
            return SQLHelper.ExecuteReader(sql, para);
        }
        #endregion

        #region 更新验证码的状态，使用过验证码，失效
        /// <summary>
        /// 更新验证码的状态，使用过验证码，失效
        /// </summary>
        /// <param name="invitationCode"></param>
        /// <returns></returns>
        public int UpdateInvitationState(string invitationCode)
        {
            string sql = "update [dbo].[InviteCode] " +
                " set CodeState=0 " +
                " where InvitationCode='" + invitationCode + "'";
            return SQLHelper.ExecuteNonQuery(sql, null);
        }
        #endregion

        #region 获取指定日期的电影放映信息
        /// <summary>
        /// 获取影片名、放映字段、放映号
        /// </summary>
        public DataTable GetFilmReleaseDate(string dateTime)
        {
            string sql = " select * from FilmSchedule " +
                " where ReleaseDates='" + dateTime + "' ";
            return SQLHelper.GetDataTable(sql);
        }
        #endregion

        #region 更新座位的状态
        /// <summary>
        ///  更新座位的状态
        /// </summary>
        /// <param name="situlationOfTickets"></param>
        /// <returns></returns>
        public int UpdateSeatsState(SitulationOfTickets situlationOfTickets)
        {
            string sql = "update [dbo].[SitulationOfTickets] "
            + " set SeatsState=@SeatsState "
            + " where  ReleaseDates=@releasedates and VideoHallId =@videoHallId "
            + " and FilmName=@filmName and Playtimes=@playtimes and SeatsNumber=@seatsNumber";
            SqlParameter[] paras ={
                                     new SqlParameter("@SeatsState",SqlDbType.Int,4),
                                     new SqlParameter ("@ReleaseDates",SqlDbType.VarChar,50),
                                     new SqlParameter ("@VideoHallId",SqlDbType.Int,4),
                                     new SqlParameter ("@FilmName",SqlDbType.VarChar,50),
                                     new SqlParameter ("@Playtimes",SqlDbType.VarChar,50),
                                     new SqlParameter ("@SeatsNumber",SqlDbType.VarChar,10)
                                 };
            paras[0].Value = situlationOfTickets.SeatsState;
            paras[1].Value = situlationOfTickets.ReleaseDates;
            paras[2].Value = situlationOfTickets.videoHallId;
            paras[3].Value = situlationOfTickets.FilmName;
            paras[4].Value = situlationOfTickets.Playtime;
            paras[5].Value = situlationOfTickets.SeatsNumber;
            return SQLHelper.ExecuteNonQuery(sql, paras);
        }
        #endregion

        #region 插入座位信息
        /// <summary>
        /// 插入座位信息
        /// </summary>
        /// <param name="ticketMsgs"></param>
        public int InsertSellTicetsMsg(SitulationOfTickets ticketMsgs)
        {
            string sql = "insert into [dbo].[SitulationOfTickets] "
            + " values(@ReleaseDates,@VideoHallId,@FilmName,@Playtimes,@SeatsNumber,@SeatsState) ";
            SqlParameter[] paras ={
                                     new SqlParameter("@ReleaseDates",SqlDbType.VarChar,50),
                                     new SqlParameter("@VideoHallId",SqlDbType.Int,4),
                                     new SqlParameter("@FilmName",SqlDbType.VarChar,50),
                                     new SqlParameter("@Playtimes",SqlDbType.VarChar,50),
                                     new SqlParameter("@SeatsNumber",SqlDbType.VarChar,4),
                                     new SqlParameter("@SeatsState",SqlDbType.Int,4)
                                 };
            paras[0].Value = ticketMsgs.ReleaseDates;
            paras[1].Value = ticketMsgs.videoHallId;
            paras[2].Value = ticketMsgs.FilmName;
            paras[3].Value = ticketMsgs.Playtime;
            paras[4].Value = ticketMsgs.SeatsNumber;
            paras[5].Value = ticketMsgs.SeatsState;
            return SQLHelper.ExecuteNonQuery(sql, paras);
        }
        #endregion

        #region 删除锁定状态的电影票座位信息
        /// <summary>
        /// 删除锁定状态的电影票座位信息
        /// </summary>
        public int DeleteSeatMsg(SitulationOfTickets ticketMsgs)
        {
            string sql = "Delete [dbo].[SitulationOfTickets] "
            + " where ReleaseDates=@ReleaseDates and VideoHallId=@VideoHallId and FilmName=@FilmName "
            + " and Playtimes=@Playtimes and SeatsNumber=@SeatsNumber and SeatsState=@SeatsState";
            SqlParameter[] paras ={
                                     new SqlParameter("@ReleaseDates",SqlDbType.VarChar,50),
                                     new SqlParameter("@VideoHallId",SqlDbType.Int,4),
                                     new SqlParameter("@FilmName",SqlDbType.VarChar,50),
                                     new SqlParameter("@Playtimes",SqlDbType.VarChar,20),
                                     new SqlParameter("@SeatsNumber",SqlDbType.VarChar,10),
                                     new SqlParameter("@SeatsState",SqlDbType.Int,4)
                                 };
            paras[0].Value = ticketMsgs.ReleaseDates;
            paras[1].Value = ticketMsgs.videoHallId;
            paras[2].Value = ticketMsgs.FilmName;
            paras[3].Value = ticketMsgs.Playtime;
            paras[4].Value = ticketMsgs.SeatsNumber;
            paras[5].Value = 0;
            return SQLHelper.ExecuteNonQuery(sql, paras);
        }
        #endregion

        /// <summary>
        /// 判断座位的状态信息
        /// </summary>
        /// <param name="ticketMsg"></param>
        /// <returns></returns>
        public int GetTicketState(SitulationOfTickets ticketMsg)
        {
            string sql = "select COUNT(*) from [dbo].[SitulationOfTickets] ";
            sql += "where ReleaseDates=@ReleaseDates and VideoHallId=@VideoHallId and  ";
            sql += "Playtimes=@Playtimes and SeatsNumber=@SeatsNumber and SeatsState=0";
            SqlParameter[] paras ={
                                     new SqlParameter("@ReleaseDates",SqlDbType.VarChar,50),
                                     new SqlParameter("@VideoHallId",SqlDbType.Int,4),
                                     new SqlParameter("@FilmName",SqlDbType.VarChar,50),
                                     new SqlParameter("@Playtimes",SqlDbType.VarChar,50),
                                     new SqlParameter("@SeatsNumber",SqlDbType.VarChar,4),
                                     new SqlParameter("@SeatsState",SqlDbType.Int,4)
                                 };
            paras[0].Value = ticketMsg.ReleaseDates;
            paras[1].Value = ticketMsg.videoHallId;
            paras[2].Value = ticketMsg.FilmName;
            paras[3].Value = ticketMsg.Playtime;
            paras[4].Value = ticketMsg.SeatsNumber;
            paras[5].Value = ticketMsg.SeatsState;
            return (int)SQLHelper.ExecuteScalar(sql, paras);

        }

        #region 删除额外的座位状态
        /// <summary>
        /// 删除额外的座位状态
        /// </summary>
        /// <returns></returns>
        public int DeleteExtraTicketState()
        {
            string sql = "delete [dbo].[SitulationOfTickets] ";
            sql += "where SeatsState=0";
            return SQLHelper.ExecuteNonQuery(sql);
        }
        #endregion
    }
}
