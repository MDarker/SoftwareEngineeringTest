using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CinemaDAL;
using CinemaCommon;
using System.Data;

namespace CinemaBLL
{
    public class VideoHallBLL
    {
        VideoHallDAL videoHall = new VideoHallDAL();

        /// <summary>
        /// 获取放映厅号
        /// </summary>
        /// <returns></returns>
        public List<CommonVideoHall> GetVideoHallNO()
        {
            SqlDataReader sdr = videoHall.GetVideoHallNO();
            List<CommonVideoHall> list = new List<CommonVideoHall>();
            if (sdr != null)
            {
                while (sdr.Read())
                {
                    CommonVideoHall v = new CommonVideoHall();
                    v.VideoHallId = (int)sdr[0];//Id
                    list.Add(v);
                }
                sdr.Close();
            }
            return list;
        }

        /// <summary>
        /// 获取放映厅全部信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllVideoHall()
        {
            return videoHall.GetAllVideoHall();
        }

        /// <summary>
        /// 修改放映厅信息
        /// </summary>
        /// <param name="cvh"></param>
        /// <returns></returns>
        public bool ModifyVideoHall(int oldHallId, CommonVideoHall cvh)
        {
            if (videoHall.ModifyVideoHall(oldHallId, cvh) > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 添加放映厅
        /// </summary>
        /// <param name="cvh"></param>
        /// <returns></returns>
        public bool AddVideoHall(CommonVideoHall cvh)
        {
            if (videoHall.AddVideoHall(cvh) > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 删除放映厅
        /// </summary>
        /// <param name="videoHallId"></param>
        /// <returns></returns>
        public bool DeleteVideoHall(int videoHallId)
        {
            if (videoHall.DeleteVideoHall(videoHallId) > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 放映厅当天是否要使用，以后已经排片
        /// </summary>
        /// <param name="videoHallId"></param>
        /// <returns></returns>
        public bool IsVideoHallUsing(int videoHallId)
        {
            List<DateTime> list = new List<DateTime>();
            SqlDataReader sdr = videoHall.IsVideoHallUsing(videoHallId);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    list.Add(sdr.GetDateTime(0));
                }
            }
            sdr.Close();
            foreach (DateTime item in list)
            {
                if (item >= DateTime.Now.Date)
                {
                    return true;
                }
            }
            return false;
        }

        #region 获取放映厅的信息
        /// <summary>
        /// 获取放映厅的信息
        /// </summary>
        /// <returns></returns>
        public List<CommonVideoHall> GetVideoHallMsg()
        {
            SqlDataReader sdr = videoHall.GetVideoHallMsg();
            List<CommonVideoHall> list = new List<CommonVideoHall>();
            if (sdr != null)
            {
                while (sdr.Read())
                {
                    CommonVideoHall v = new CommonVideoHall();
                    v.VideoHallId = (int)sdr[0];//Id
                    v.RowSeatNum = (int)sdr[2];
                    v.ColumnSeatNum = (int)sdr[3];
                    list.Add(v);
                }
                sdr.Close();
            }
            return list;
        }
        #endregion
    }
}
