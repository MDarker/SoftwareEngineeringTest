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
            string sql = " select Id,Time from Schedule order by Id ";
            return Dao.ExecuteReader(sql, null);
        }

        /// <summary>
        /// 添加排好的影片信息
        /// </summary>
        public int AddFilmSchedule(CommonFilmSchedule cfilmSchedule)
        {
            string sql = " insert into dbo.FilmSchedule " +
                " values(@FilmId,@FilmName,@VideoHallId,@FilmBeginTime,@FilmEndTime) ";
            SqlParameter[] paras = {
                                       new SqlParameter("@FilmId",SqlDbType.Int,4),
                                       new SqlParameter("@FilmName",SqlDbType.VarChar,50),
                                       new SqlParameter("@VideoHallId",SqlDbType.Int,4),
                                       new SqlParameter("@FilmBeginTime",SqlDbType.VarChar,50),
                                       new SqlParameter("@FilmEndTime",SqlDbType.VarChar,50)
                                   };
            paras[0].Value = cfilmSchedule.FilmId;
            paras[1].Value = cfilmSchedule.FilmName;
            paras[2].Value = cfilmSchedule.VideoHallId;
            paras[3].Value = cfilmSchedule.FilmBeginTime;
            paras[4].Value = cfilmSchedule.FilmEndTime;

            return Dao.ExecuteNonQuery(sql, paras);
        }

        /// <summary>
        /// 修改排好的片信息
        /// </summary>
        /// <param name="cfilmSchedule"></param>
        /// <returns></returns>
        public int ModifyScheduledFilm(CommonFilmSchedule cfilmSchedule)
        {
            string sql = " update dbo.FilmSchedule " +
                " set VideoHallId=@VideoHallId, FilmBeginTime=@FilmBeginTime," +
                " FilmEndTime=@FilmEndTime " +
                " where FilmId=@filmId ";
            SqlParameter[] paras = {
                                       new SqlParameter("@VideoHallId",SqlDbType.Int,4),
                                       new SqlParameter("@FilmBeginTime",SqlDbType.VarChar,50),
                                       new SqlParameter("@FilmEndTime",SqlDbType.VarChar,50),
                                       new SqlParameter("@filmId",SqlDbType.Int,4)
                                   };
            paras[0].Value = cfilmSchedule.VideoHallId;
            paras[1].Value = cfilmSchedule.FilmBeginTime;
            paras[2].Value = cfilmSchedule.FilmEndTime;
            paras[3].Value = cfilmSchedule.FilmId;

            return Dao.ExecuteNonQuery(sql, paras);
        }

        /// <summary>
        /// 删除排好的影片
        /// </summary>
        /// <param name="filmId"></param>
        /// <returns></returns>
        public int DeletScheduledFilm(int filmId)
        {
            string sql = " delete from dbo.FilmSchedule " +
                " where FilmId=@filmId ";
            SqlParameter para = new SqlParameter("@filmId", SqlDbType.Int, 4);
            para.Value = filmId;

            return Dao.ExecuteNonQuery(sql, para);
        }
    }
}
