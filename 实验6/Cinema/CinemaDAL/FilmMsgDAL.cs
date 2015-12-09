using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CinemaSQLHelper;

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
                " where FilmState=1 ";
            return Dao.GetDataSet(sql);
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
            return Dao.ExecuteNonQuery(sql, para);
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
            return Dao.ExecuteNonQuery(sql, para);
        }
    }
}
