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
    public class VideoHallDAL
    {
        public SqlDataReader GetVideoHallNO()
        {
            string sql = " select VideoHallId from VideoHall order by VideoHallId ";
            return Dao.ExecuteReader(sql, null);
        }
    }
}
