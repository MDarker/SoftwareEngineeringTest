using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CinemaDAL;
using CinemaCommon;

namespace CinemaBLL
{
    public class FilmScheduleBLL
    {
        FilmScheduleDAL filmSchedule = new FilmScheduleDAL();
        /// <summary>
        /// 获取排好的影片开始时间
        /// </summary>
        /// <returns></returns>
        public List<CommonSchedule> GetFilmBeginTime()
        {
            SqlDataReader sdr = filmSchedule.GetFilmBeginTime();
            List<CommonSchedule> list = new List<CommonSchedule>();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    CommonSchedule s = new CommonSchedule();
                    s.Id = (int)sdr[0];//Id
                    s.Time = sdr[1].ToString();//Time
                    list.Add(s);
                }
            }
            sdr.Close();
            return list;
        }

        /// <summary>
        /// 添加排好的影片信息
        /// </summary>
        public bool AddFilmSchedule(CommonFilmSchedule cfilmSchedule)
        {
            if (filmSchedule.AddFilmSchedule(cfilmSchedule) > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 修改排好的片信息
        /// </summary>
        /// <param name="cfilmSchedule"></param>
        /// <returns></returns>
        public bool ModifyScheduledFilm(CommonFilmSchedule cfilmSchedule)
        {
            if (filmSchedule.ModifyScheduledFilm(cfilmSchedule) > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 删除排好的影片
        /// </summary>
        /// <param name="filmId"></param>
        /// <returns></returns>
        public bool DeletScheduledFilm(int filmId)
        {
            if (filmSchedule.DeletScheduledFilm(filmId) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
