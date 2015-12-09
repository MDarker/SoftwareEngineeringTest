using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
    }
}
