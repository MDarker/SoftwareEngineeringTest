using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CinemaCommon;
using CinemaDAL;

namespace CinemaBLL
{
    public class FilmMsgBLL
    {
        FilmMsgDAL filmMsg = new FilmMsgDAL();

        /// <summary>
        /// 获取还没排的影片信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetNoScheduleFilm()
        {
            return filmMsg.GetNoScheduleFilm();
        }

        /// <summary>
        /// 记录排片次数  加 
        /// </summary>
        /// <param name="filmId"></param>
        /// <returns></returns>
        public bool AddScheduleTime(int filmId)
        {
            if (filmMsg.AddScheduleTime(filmId) > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 记录排片次数  减
        /// </summary>
        /// <param name="filmId"></param>
        /// <returns></returns>
        public bool SubScheduleTime(int filmId)
        {
            if (filmMsg.SubScheduleTime(filmId) > 0)
            {
                return true;
            }
            return false;
        }


        FilmMsgDAL fmd = new FilmMsgDAL();
        FilmMsgCommon fmc = new FilmMsgCommon();
        InvitationCodeMsg icm = new InvitationCodeMsg();

        #region 获取影片信息
        /// <summary>
        ///获取影片信息
        /// </summary>
        /// <param name="fileName"></param>
        public FilmMsgCommon GetFilmMsg(string filmName)
        {
            SqlDataReader sdr = fmd.GetFilmMsg(filmName);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    fmc.FilmId = Convert.ToInt32(sdr[0]);
                    fmc.FilmName = sdr.GetString(1);
                    fmc.Director = sdr.GetString(2);
                    fmc.FilmType = sdr.GetString(3);
                    fmc.Producers = sdr.GetString(4);
                    fmc.Country = sdr.GetString(5);
                    fmc.FilmTimes = sdr.GetString(6);
                    fmc.Protagonists = sdr.GetString(7);
                    fmc.FilmState = sdr.GetInt32(8);

                }
            }
            return fmc;
        }
        #endregion

        #region 获取影片名、放映字段、放映厅号
        /// <summary>
        /// 获取影片名、放映字段、放映号
        /// </summary>
        public DataTable GetFilmNamesAndShowtimes()
        {
            return fmd.GetFilmNamesAndShowtimes();
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
            return fmd.GetTicketCounts(ticketCounts, playTimes, filmId);
        }
        #endregion

        #region 验证邀请码的正确性，正确则返回该邀请码的作用
        /// <summary>
        /// 验证邀请码的正确性，正确则返回该邀请码的作用
        /// </summary>
        /// <param name="invitationCode"></param>
        /// <returns></returns>
        public InvitationCodeMsg CheckInvitationCode(string invitationCode)
        {
            SqlDataReader sdr = fmd.CheckInvitationCode(invitationCode);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    icm.InvitationCode = sdr.GetString(0);
                    icm.FilmId = sdr.GetInt32(1);
                    icm.Deadline = sdr.GetDateTime(2).ToString();
                    icm.CodeState = sdr.GetInt32(3);
                }
            }
            else
            {
                return null;
            }
            return icm;
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
            return fmd.UpdateInvitationState(invitationCode);
        }
        #endregion

        #region 获取指定日期的电影放映信息
        /// <summary>
        /// 获取影片名、放映字段、放映号
        /// </summary>
        public DataTable GetFilmReleaseDate(string dateTime)
        {
            dateTime = dateTime.Substring(0, 9);
            return fmd.GetFilmReleaseDate(dateTime);
        }
        #endregion
    }
}
