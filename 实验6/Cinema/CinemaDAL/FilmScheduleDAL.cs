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
            return Dao.ExecuteReader(sql, null);
        }

        /// <summary>
        /// 获取已经排的影片信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetScheduledFilm()
        {
            string sql = " select ScheduleId,FilmId,FilmName,VideoHallId,FilmBeginTime,FilmEndTime " +
                " from dbo.FilmSchedule ";
            return Dao.GetDataSet(sql);
        }

        /// <summary>
        /// 添加排好的影片信息
        /// </summary>
        public int AddFilmSchedule(CommonFilmSchedule cfilmSchedule)
        {
            string sql = " insert into dbo.FilmSchedule " +
                " values(@FilmId,@FilmName,@VideoHallId,@FilmBeginTime,@FilmEndTime,@FilmBeginId,@FilmEndId) ";
            SqlParameter[] paras = {
                                       new SqlParameter("@FilmId",SqlDbType.Int,4),
                                       new SqlParameter("@FilmName",SqlDbType.VarChar,50),
                                       new SqlParameter("@VideoHallId",SqlDbType.Int,4),
                                       new SqlParameter("@FilmBeginTime",SqlDbType.VarChar,50),
                                       new SqlParameter("@FilmEndTime",SqlDbType.VarChar,50),
                                       new SqlParameter("@FilmBeginId",SqlDbType.Int,4),
                                       new SqlParameter("@FilmEndId",SqlDbType.Int,4)
                                   };
            paras[0].Value = cfilmSchedule.FilmId;
            paras[1].Value = cfilmSchedule.FilmName;
            paras[2].Value = cfilmSchedule.VideoHallId;
            paras[3].Value = cfilmSchedule.FilmBeginTime;
            paras[4].Value = cfilmSchedule.FilmEndTime;
            paras[5].Value = cfilmSchedule.FilmBeginId;
            paras[6].Value = cfilmSchedule.FilmEndId;

            return Dao.ExecuteNonQuery(sql, paras);
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
                " FilmEndTime=@FilmEndTime, " +
                " FilmBeginId=@FilmBeginId,FilmEndId=@FilmEndId " +
                " where ScheduleId=@scheduleId ";
            SqlParameter[] paras = {
                                       new SqlParameter("@VideoHallId",SqlDbType.Int,4),
                                       new SqlParameter("@FilmBeginTime",SqlDbType.VarChar,50),
                                       new SqlParameter("@FilmEndTime",SqlDbType.VarChar,50),
                                       new SqlParameter("@FilmBeginId",SqlDbType.Int,4),
                                       new SqlParameter("@FilmEndId",SqlDbType.Int,4),                                       
                                       new SqlParameter("@scheduleId",SqlDbType.Int,4)
                                   };
            paras[0].Value = cfilmSchedule.VideoHallId;
            paras[1].Value = cfilmSchedule.FilmBeginTime;
            paras[2].Value = cfilmSchedule.FilmEndTime;
            paras[3].Value = cfilmSchedule.FilmBeginId;
            paras[4].Value = cfilmSchedule.FilmEndId;
            paras[5].Value = scheduleId;

            return Dao.ExecuteNonQuery(sql, paras);
        }

        /// <summary>
        /// 删除排好的影片
        /// </summary>
        /// <param name="filmId"></param>
        /// <returns></returns>
        public int DeletScheduledFilm(int scheduleId)
        {
            string sql = " delete from dbo.FilmSchedule " +
                " where ScheduleId=@scheduleId ";
            SqlParameter para = new SqlParameter("@scheduleId", SqlDbType.Int, 4);
            para.Value = scheduleId;

            return Dao.ExecuteNonQuery(sql, para);
        }

        /// <summary>
        /// 检查时间段是否重合
        /// </summary>
        /// <returns></returns>
        public Object IsScheduleTimeRepeat(int videoHallId, int filmBeginId, int filmEndId)
        {
            string sql = " select COUNT(*) from dbo.FilmSchedule " +
                " where VideoHallId=@videoHallId " +
                "and (FilmBeginId between @filmBeginId and @filmEndId " +
                " or FilmEndId between @filmBeginId and @filmEndId) ";
            SqlParameter[] paras = {
                                       new SqlParameter("@videoHallId",SqlDbType.Int,4),
                                       new SqlParameter("@filmBeginId",SqlDbType.Int,4),
                                       new SqlParameter("@filmEndId",SqlDbType.Int,4)
                                   };
            paras[0].Value = videoHallId;
            paras[1].Value = filmBeginId;
            paras[2].Value = filmEndId;
            return Dao.ExecuteScalar(sql, paras);
        }
    }
}
