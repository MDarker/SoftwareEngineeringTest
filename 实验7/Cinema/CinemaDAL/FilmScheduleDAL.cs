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
    public class FilmScheduleDAL
    {
        /// <summary>
        /// 获取排好的影片开始时间
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetFilmBeginTime()
        {
            string sql = " select top 32 Id,Time from Schedule order by Id ";
            return SQLHelper.ExecuteReader(sql, null);
        }

        /// <summary>
        /// 获取已经排的影片信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetScheduledFilm()
        {
            string sql = " select ScheduleId,FilmId,FilmName,VideoHallId,FilmBeginTime,FilmEndTime,ReleaseDates " +
                " from dbo.FilmSchedule order by ReleaseDates,FilmBeginId,VideoHallId ";
            return SQLHelper.GetDataTable(sql);
        }

        /// <summary>
        /// 添加排好的影片信息
        /// </summary>
        public int AddFilmSchedule(CommonFilmSchedule cfilmSchedule)
        {
            string sql = " insert into dbo.FilmSchedule " +
                " values(@FilmId,@FilmName,@VideoHallId,@FilmBeginTime,@FilmEndTime,@FilmBeginId,@FilmEndId,@ReleaseDates,@TicketPrice,@PreferentialPrice,@SellTickets) ";
            SqlParameter[] paras = {
                                       new SqlParameter("@FilmId",SqlDbType.Int,4),
                                       new SqlParameter("@FilmName",SqlDbType.VarChar,50),
                                       new SqlParameter("@VideoHallId",SqlDbType.Int,4),
                                       new SqlParameter("@FilmBeginTime",SqlDbType.VarChar,50),
                                       new SqlParameter("@FilmEndTime",SqlDbType.VarChar,50),
                                       new SqlParameter("@FilmBeginId",SqlDbType.Int,4),
                                       new SqlParameter("@FilmEndId",SqlDbType.Int,4),
                                       new SqlParameter("@ReleaseDates",SqlDbType.Date),
                                       new SqlParameter("@TicketPrice",SqlDbType.Int,4),
                                       new SqlParameter("@PreferentialPrice",SqlDbType.Int,4),
                                       new SqlParameter("@SellTickets",SqlDbType.Int,4)
                                   };
            paras[0].Value = cfilmSchedule.FilmId;
            paras[1].Value = cfilmSchedule.FilmName;
            paras[2].Value = cfilmSchedule.VideoHallId;
            paras[3].Value = cfilmSchedule.FilmBeginTime;
            paras[4].Value = cfilmSchedule.FilmEndTime;
            paras[5].Value = cfilmSchedule.FilmBeginId;
            paras[6].Value = cfilmSchedule.FilmEndId;
            paras[7].Value = cfilmSchedule.ReleaseDates;
            paras[8].Value = cfilmSchedule.TicketPrice;
            paras[9].Value = cfilmSchedule.PreferentialPrice;
            //电影票刚开始默认为0
            paras[10].Value = 0;
            return SQLHelper.ExecuteNonQuery(sql, paras);
        }

        /// <summary>
        /// 修改排好的片信息
        /// </summary>
        /// <param name="cfilmSchedule"></param>
        /// <returns></returns>
        public int ModifyScheduledFilm(int scheduleId, CommonFilmSchedule cfilmSchedule)
        {
            string sql = " update dbo.FilmSchedule " +
                " set VideoHallId=@VideoHallId, FilmBeginTime=@FilmBeginTime," +
                " FilmEndTime=@FilmEndTime,FilmBeginId=@FilmBeginId,FilmEndId=@FilmEndId, " +
                " ReleaseDates=@ReleaseDates,TicketPrice=@TicketPrice, " +
                " PreferentialPrice=@PreferentialPrice " +
                " where ScheduleId=@scheduleId ";
            SqlParameter[] paras = {
                                       new SqlParameter("@VideoHallId",SqlDbType.Int,4),
                                       new SqlParameter("@FilmBeginTime",SqlDbType.VarChar,50),
                                       new SqlParameter("@FilmEndTime",SqlDbType.VarChar,50),
                                       new SqlParameter("@FilmBeginId",SqlDbType.Int,4),
                                       new SqlParameter("@FilmEndId",SqlDbType.Int,4),
                                       new SqlParameter("@ReleaseDates",SqlDbType.Date),
                                       new SqlParameter("@scheduleId",SqlDbType.Int,4),
                                       new SqlParameter("@TicketPrice",SqlDbType.Int,4),
                                       new SqlParameter("@PreferentialPrice",SqlDbType.Int,4)
                                   };
            paras[0].Value = cfilmSchedule.VideoHallId;
            paras[1].Value = cfilmSchedule.FilmBeginTime;
            paras[2].Value = cfilmSchedule.FilmEndTime;
            paras[3].Value = cfilmSchedule.FilmBeginId;
            paras[4].Value = cfilmSchedule.FilmEndId;
            paras[5].Value = cfilmSchedule.ReleaseDates;
            paras[6].Value = scheduleId;
            paras[7].Value = cfilmSchedule.TicketPrice;
            paras[8].Value = cfilmSchedule.PreferentialPrice;
            return SQLHelper.ExecuteNonQuery(sql, paras);
        }

        /// <summary>
        /// 删除下映电影的排片
        /// </summary>
        /// <param name="strDate"></param>
        /// <returns></returns>
        public int DeleteDownlineFilm(string nowDate)
        {
            string sql = " delete from FilmSchedule " +
                " where FilmId in " +
                " (select FilmId from dbo.FilmsMsg " +
                " where Deadline<@nowDate) ";
            SqlParameter para = new SqlParameter("@nowDate", SqlDbType.Date);
            para.Value = nowDate;
            return SQLHelper.ExecuteNonQuery(sql, para);
        }
        /// <summary>
        /// 删除放映日期不是今天以及之后的排片（过期）的排片
        /// </summary>
        /// <param name="nowDate"></param>
        /// <returns></returns>
        public int DeleteOverdueSchedule(string nowDate)
        {
            string sql = " select ScheduleId from FilmSchedule " +
                " where ReleaseDates<@nowDate ";
            SqlParameter para = new SqlParameter("@nowDate", SqlDbType.Date);
            para.Value = nowDate;
            object obj = SQLHelper.ExecuteScalar(sql, para);
            if (obj == null)
            {
                return 0;
            }
            int scheduleId = (int)obj;
            return this.DeleteScheduledFilm(scheduleId);
        }

        /// <summary>
        /// 删除已经删除的影片
        /// </summary>
        public void DeleteFilm()
        {
            string sql = " delete from FilmSchedule " +
                " where FilmId not in (select FilmId " +
                " from FilmsMsg) ";
            SQLHelper.ExecuteNonQuery(sql, null);
        }

        /// <summary>
        /// 删除排好的影片
        /// </summary>
        /// <param name="filmId"></param>
        /// <returns></returns>
        public int DeleteScheduledFilm(int scheduleId)
        {
            string sql = " delete from dbo.FilmSchedule " +
                " where ScheduleId=@scheduleId ";
            SqlParameter para = new SqlParameter("@scheduleId", SqlDbType.Int, 4);
            para.Value = scheduleId;

            return SQLHelper.ExecuteNonQuery(sql, para);
        }

        /// <summary>
        /// 检查时间段是否重合
        /// </summary>
        /// <returns></returns>
        public Object IsScheduleTimeRepeat(int scheduleId, int videoHallId, string releaseDates, int filmBeginId, int filmEndId)
        {
            string sql = " select COUNT(*) from dbo.FilmSchedule " +
                " where VideoHallId=@videoHallId " +
                " and ReleaseDates=@releaseDates " +
                "and (FilmBeginId between @filmBeginId and @filmEndId " +
                " or FilmEndId between @filmBeginId and @filmEndId) " +
                " and ScheduleId<>@scheduleId ";
            SqlParameter[] paras = {
                                       new SqlParameter("@videoHallId",SqlDbType.Int,4),
                                       new SqlParameter("@releaseDates",SqlDbType.Date),
                                       new SqlParameter("@filmBeginId",SqlDbType.Int,4),
                                       new SqlParameter("@filmEndId",SqlDbType.Int,4),
                                       new SqlParameter("@scheduleId",SqlDbType.Int,4)
                                   };
            paras[0].Value = videoHallId;
            paras[1].Value = releaseDates;
            paras[2].Value = filmBeginId;
            paras[3].Value = filmEndId;
            paras[4].Value = scheduleId;
            return SQLHelper.ExecuteScalar(sql, paras);
        }
    }
}
