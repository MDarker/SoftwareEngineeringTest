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
        /// 获取全部影片信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllFilmsMsg()
        {
            DateTime nowDate = DateTime.Now;
            string strDate = nowDate.ToString();
            strDate = DateFormat.GetRightDateFormat(strDate);
            //自动下映过期的电影
            filmMsg.DownLineOverdueFilm(strDate);

            return filmMsg.GetAllFilmsMsg();
        }

        /// <summary>
        /// 添加电影
        /// </summary>
        /// <param name="fmc"></param>
        /// <returns></returns>
        public bool AddFilm(FilmMsgCommon fmc)
        {
            if (filmMsg.AddFilm(fmc) > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 删除电影
        /// </summary>
        /// <param name="filmId"></param>
        /// <returns></returns>
        public bool DeleteFilm(int filmId)
        {
            if (filmMsg.DeleteFilm(filmId) > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 电影下映
        /// </summary>
        /// <param name="filmId"></param>
        /// <returns></returns>
        public bool FilmDownLine(int filmId)
        {
            if (filmMsg.FilmDownLine(filmId) > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 修改电影信息
        /// </summary>
        /// <param name="fmc"></param>
        /// <returns></returns>
        public bool ModifyFilm(int oldfilmId, FilmMsgCommon fmc)
        {
            fmc.Deadline = DateFormat.GetRightDateFormat(fmc.Deadline);
            if (filmMsg.ModifyFilm(oldfilmId, fmc) > 0)
            {
                return true;
            }
            return false;
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

        private string GetRightDateFormat(string oldDate)
        {
            string fDate = oldDate;
            if (fDate.Contains("星期"))
            {
                fDate = (Convert.ToDateTime(fDate.Substring(0, fDate.IndexOf("星") - 1)).ToShortDateString());
                fDate = fDate.Substring(0, fDate.IndexOf("星") - 1);
            }
            else
            {
                fDate = Convert.ToDateTime(fDate).ToShortDateString();
                fDate = fDate.Substring(0, fDate.LastIndexOf('/'));
            }
            return fDate;
        }

        #region 获取影片信息
        /// <summary>
        ///获取影片信息
        /// </summary>
        /// <param name="fileName"></param>
        public FilmMsgCommon GetFilmMsg(string filmName)
        {
            SqlDataReader sdr = filmMsg.GetFilmMsg(filmName);
            FilmMsgCommon fmc = new FilmMsgCommon();
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
        public DataTable GetFilmPlayList()
        {
            string date = DateTime.Now.ToShortDateString();
            date = DateFormat.GetRightDateFormat(date);
            return filmMsg.GetFilmPlayList(date);
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
            //将playTime 重新编程开始时间和截止时间
            string[] temps = playTimes.Split('-');
            string filmBeginTime = temps[0];
            string filmEndinTime = temps[1];
            return filmMsg.GetTicketCounts(ticketCounts, filmBeginTime, filmEndinTime, filmId);
        }
        #endregion

        #region 验证邀请码的正确性，正确则返回该邀请码的作用
        /// <summary>
        /// 验证邀请码的正确性，正确则返回该邀请码的作用
        /// </summary>
        /// <param name="invitationCode"></param>
        /// <returns></returns>
        public InvitationCodeMsgCommon CheckInvitationCode(string invitationCode)
        {
            SqlDataReader sdr = filmMsg.CheckInvitationCode(invitationCode);
            InvitationCodeMsgCommon icm = new InvitationCodeMsgCommon();
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
            return filmMsg.UpdateInvitationState(invitationCode);
        }
        #endregion

        #region 获取指定日期的电影放映信息
        /// <summary>
        /// 获取影片名、放映字段、放映号
        /// </summary>
        public DataTable GetFilmReleaseDate(string dateTime)
        {
            dateTime = DateFormat.GetRightDateFormat(dateTime);
            return filmMsg.GetFilmReleaseDate(dateTime);
        }
        #endregion

        #region  获取数据库中已有的指定日期的电影，指定厅的已售出的座位信息
        /// <summary>
        /// 获取数据库中已有的指定日期的电影，指定厅的已售出的座位信息
        /// </summary>
        /// <param name="situlationOfTickets"></param>
        public List<string> GetSitulationOfTickets(SitulationOfTickets ticketMsgs)
        {
            List<string> SeatsMsg = new List<string>();
            ticketMsgs.ReleaseDates = DateFormat.GetRightDateFormat(ticketMsgs.ReleaseDates);
            SqlDataReader sdr = filmMsg.GetSitulationOfTickets(ticketMsgs);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    SeatsMsg.Add(sdr[0].ToString());
                }
            }
            return SeatsMsg;
        }
        #endregion

        #region  获取数据库中已有的指定日期的电影，指定厅的指定座位状态的信息，还未应用
        /// <summary>
        /// 获取数据库中已有的指定日期的电影，指定厅的指定座位状态的信息
        /// </summary>
        /// <param name="situlationOfTickets"></param>
        public int GetSeatStates(SitulationOfTickets ticketMsgs)
        {
            ticketMsgs.ReleaseDates = DateFormat.GetRightDateFormat(ticketMsgs.ReleaseDates);
            SqlDataReader sdr = filmMsg.GetSeatStates(ticketMsgs);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    int seatsState = (int)sdr[0];
                    return seatsState;
                }
            }
            return 0;//错误
        }

        #endregion

        #region 更新座位的状态
        /// <summary>
        ///   更新座位的状态
        /// </summary>
        /// <param name="situlationOfTickets"></param>
        /// <returns></returns>
        public int UpdateSeatsState(SitulationOfTickets ticketMsgs)
        {
            ticketMsgs.ReleaseDates = DateFormat.GetRightDateFormat(ticketMsgs.ReleaseDates);
            return filmMsg.UpdateSeatsState(ticketMsgs);
        }
        #endregion

        #region 插入座位信息
        /// <summary>
        /// 插入座位信息
        /// </summary>
        /// <param name="ticketMsgs"></param>
        public int InsertSellTicetsMsg(SitulationOfTickets ticketMsgs)
        {
            ticketMsgs.ReleaseDates = DateFormat.GetRightDateFormat(ticketMsgs.ReleaseDates);
            return filmMsg.InsertSellTicetsMsg(ticketMsgs);
        }
        #endregion

        #region 删除锁定状态的电影票座位信息
        /// <summary>
        /// 删除锁定状态的电影票座位信息
        /// </summary>
        public int DeleteSeatMsg(SitulationOfTickets ticketMsgs)
        {
            ticketMsgs.ReleaseDates = DateFormat.GetRightDateFormat(ticketMsgs.ReleaseDates);
            return filmMsg.DeleteSeatMsg(ticketMsgs);
        }
        #endregion
    }
}
