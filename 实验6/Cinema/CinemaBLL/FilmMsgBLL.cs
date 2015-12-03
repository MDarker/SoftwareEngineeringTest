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

        public DataTable GetNoScheduleFilm()
        {
            DataTable dt = filmMsg.GetNoScheduleFilm();
            return dt;
        }
    }
}
