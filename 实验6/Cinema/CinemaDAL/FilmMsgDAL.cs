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
        public DataTable GetNoScheduleFilm()
        {
            string sql = "";
            return new DataTable();
            //return Dao.GetDataSet(sql);
        }
    }
}
