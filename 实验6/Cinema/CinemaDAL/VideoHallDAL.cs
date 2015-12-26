using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CinemaSQLHelper;
using CinemaCommon;

namespace CinemaDAL
{
    public class VideoHallDAL
    {
        /// <summary>
        /// 获取放映厅号
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetVideoHallNO()
        {
            string sql = " select VideoHallId from VideoHall order by VideoHallId ";
            return SQLHelper.ExecuteReader(sql, null);
        }

        /// <summary>
        /// 获取放映厅全部信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllVideoHall()
        {
            string sql = " select VideoHallId,Seatings,RowSeatNum,ColumnSeatNum " +
                " from dbo.VideoHall " +
                " order by VideoHallId ";
            return SQLHelper.GetDataTable(sql);
        }

        /// <summary>
        /// 修改放映厅信息
        /// </summary>
        /// <param name="cvh"></param>
        /// <returns></returns>
        public int ModifyVideoHall(int oldHallId, CommonVideoHall cvh)
        {
            if (oldHallId != cvh.VideoHallId)
            {
                if (IsReapt(cvh.VideoHallId))
                {
                    return 0;
                }
            }
            string sql = " update VideoHall " +
                " set VideoHallId=@VideoHallId,Seatings=@Seatings, " +
                " RowSeatNum=@RowSeatNum,ColumnSeatNum=@ColumnSeatNum " +
                " where VideoHallId=@oldHallId ";
            SqlParameter[] paras = {
                                       new SqlParameter("@VideoHallId",SqlDbType.Int,4),
                                       new SqlParameter("@Seatings",SqlDbType.Int,4),
                                       new SqlParameter("@RowSeatNum",SqlDbType.Int,4),
                                       new SqlParameter("@ColumnSeatNum",SqlDbType.Int,4),
                                       new SqlParameter("@oldHallId",SqlDbType.Int,4)
                                   };
            paras[0].Value = cvh.VideoHallId;
            paras[1].Value = cvh.Seatings;
            paras[2].Value = cvh.RowSeatNum;
            paras[3].Value = cvh.ColumnSeatNum;
            paras[4].Value = oldHallId;
            return SQLHelper.ExecuteNonQuery(sql, paras);
        }

        /// <summary>
        /// 添加放映厅
        /// </summary>
        /// <param name="cvh"></param>
        /// <returns></returns>
        public int AddVideoHall(CommonVideoHall cvh)
        {
            if (IsReapt(cvh.VideoHallId))
            {
                return 0;
            }
            string sql = " insert into VideoHall(VideoHallId,Seatings,RowSeatNum,ColumnSeatNum) " +
                " values(@VideoHallId,@Seatings,@RowSeatNum,@ColumnSeatNum) ";
            SqlParameter[] paras = {
                                       new SqlParameter("@VideoHallId",SqlDbType.Int,4),
                                       new SqlParameter("@Seatings",SqlDbType.Int,4),
                                       new SqlParameter("@RowSeatNum",SqlDbType.Int,4),
                                       new SqlParameter("@ColumnSeatNum",SqlDbType.Int,4)
                                   };
            paras[0].Value = cvh.VideoHallId;
            paras[1].Value = cvh.Seatings;
            paras[2].Value = cvh.RowSeatNum;
            paras[3].Value = cvh.ColumnSeatNum;
            return SQLHelper.ExecuteNonQuery(sql, paras);
        }

        /// <summary>
        /// 删除放映厅
        /// </summary>
        /// <param name="videoHallId"></param>
        /// <returns></returns>
        public int DeleteVideoHall(int videoHallId)
        {
            string sql = " delete from dbo.VideoHall " +
                " where VideoHallId=@videoHallId ";
            SqlParameter para = new SqlParameter("@videoHallId", SqlDbType.Int, 4);
            para.Value = videoHallId;
            return SQLHelper.ExecuteNonQuery(sql, para);
        }

        /// <summary>
        /// 放映厅是否重复
        /// </summary>
        /// <param name="videoHallId"></param>
        /// <returns></returns>
        private bool IsReapt(int videoHallId)
        {
            string sql = " select COUNT(*) from VideoHall " +
                " where VideoHallId=@VideoHallId ";
            SqlParameter para = new SqlParameter("@VideoHallId", SqlDbType.Int, 4);
            para.Value = videoHallId;
            int obj = (int)SQLHelper.ExecuteScalar(sql, para);
            if (obj > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 放映厅当天是否在使用，已经排片
        /// </summary>
        /// <param name="videoHallId"></param>
        /// <returns></returns>
        public SqlDataReader IsVideoHallUsing(int videoHallId)
        {
            string sql = " select ReleaseDates " +
                " from FilmSchedule " +
                 " where VideoHallId=@VideoHallId ";
            SqlParameter para = new SqlParameter("@VideoHallId", SqlDbType.Int, 4);
            para.Value = videoHallId;
            return SQLHelper.ExecuteReader(sql, para);
        }

        #region 获取放映厅的信息
        /// <summary>
        /// 获取放映厅的信息
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetVideoHallMsg()
        {
            string sql = "select * from [dbo].[VideoHall]";
            return SQLHelper.ExecuteReader(sql, null);
        }
        #endregion
    }
}
