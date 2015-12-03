using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CinemaDAL;

namespace CinemaBLL
{
    public class VideoHallBLL
    {
        VideoHallDAL videoHall = new VideoHallDAL();

        public void GetVideoHallNO()
        {
            videoHall.GetVideoHallNO();
        }
    }
}
