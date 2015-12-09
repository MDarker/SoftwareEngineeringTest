using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CinemaDAL;
using CinemaCommon;

namespace CinemaBLL
{
    public class VideoHallBLL
    {
        VideoHallDAL videoHall = new VideoHallDAL();

        public List<CommonVideoHall> GetVideoHallNO()
        {
            SqlDataReader sdr = videoHall.GetVideoHallNO();
            List<CommonVideoHall> list = new List<CommonVideoHall>();
            if (sdr != null)
            {
                while (sdr.Read())
                {
                    CommonVideoHall v = new CommonVideoHall();
                    v.Id = (int)sdr[0];//Id
                    list.Add(v);
                }
                sdr.Close();
            }
            return list;
        }
    }
}
