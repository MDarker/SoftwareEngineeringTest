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
                " where FilmState=1 order by FilmId ";
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

        #region 获取影片信息
        /// <summary>
        ///获取影片信息
        /// </summary>
        /// <param name="fileName"></param>
        public SqlDataReader GetFilmMsg(string filmName)
        {
            string sql = "select * from filmsMsg ";
            sql += "where FilmName='" + filmName + "'";
            return Dao.ExecuteReader(sql, null);
        }
        #endregion

        #region 获取影片名、放映字段、放映号
        /// <summary>
        /// 获取影片名、放映字段、放映号
        /// </summary>
        public DataTable GetFilmNamesAndShowtimes()
        {
            string sql = "select * from [dbo].[FilmPlay]";
            return Dao.GetDataSet(sql);
        }
        #endregion

        #region 获取每场电影卖出的票数
        /// <summary>
        ///获取每场电影卖出的票数
        /// </summary>
        /// <param name="ticketCounts"></param>
        /// <param name="playTimes"></param>
        /// <param name="filmId"></param>
        public int GetTicketCounts(int ticketCounts, string playTimes, int filmId)
        {
            string sql = "update [dbo].[FilmPlay] ";
            sql += "set SellTickets+=@SellTickets ";
            sql += " where PlayTime =@PlayTime and FilmId=@FilmId ";
            SqlParameter[] paras ={
                                     new SqlParameter("@SellTickets",SqlDbType.Int,4),
                                     new SqlParameter("@PlayTime",SqlDbType.VarChar,50),
                                     new SqlParameter("@FilmId",SqlDbType.Int,4)
                                 };
            paras[0].Value = ticketCounts;
            paras[1].Value = playTimes;
            paras[2].Value = filmId;
            return Dao.ExecuteNonQuery(sql, paras);
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
            string sql = "select * from [dbo].[InviteCode]";
            sql += "where InvitationCode=@InvitationCode";
            SqlParameter para = new SqlParameter("@InvitationCode", SqlDbType.VarChar, 50);
            para.Value = invitationCode;
            return Dao.ExecuteReader(sql, para);
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
            string sql = "update [dbo].[InviteCode] ";
            sql += "Set CodeState=0";
            sql += " where InvitationCode='" + invitationCode + "'";
            return Dao.ExecuteNonQuery(sql, null);
        }
        #endregion

        #region 获取指定日期的电影放映信息
        /// <summary>
        /// 获取影片名、放映字段、放映号
        /// </summary>
        public DataTable GetFilmReleaseDate(string dateTime)
        {
            string sql = "select * from [dbo].[FilmPlay]";
            sql += "where ReleaseDates='" + dateTime + "' ";
            return Dao.GetDataSet(sql);
        }
        #endregion
    }
}
