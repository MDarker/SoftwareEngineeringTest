using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CinemaSQLHelper
{
    public class Dao
    {
        private static string conStr = "Data Source=DESKTOP-BK9I1VO;Initial Catalog=影院售票系统;Persist Security Info=True;User ID=sa;Password=123456";

        #region Prepare准备,进行通道连接,命令赋值
        /// <summary>
        /// 公共方法Prem(),进行通道连接,执行命令对象赋值
        /// </summary>
        /// <param name="conn">通道对象</param>
        /// <param name="cmd">执行命令对象</param>
        /// <param name="sql">sql语句</param>
        /// <param name="paras">查询参数</param>
        private static void Prepare(SqlConnection conn, SqlCommand cmd, string sql, params SqlParameter[] paras)
        {
            cmd.CommandText = sql;
            cmd.Connection = conn;
            if (paras != null)
            {
                foreach (SqlParameter item in paras)
                {
                    cmd.Parameters.Add(item);
                }
            }
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        #endregion

        #region ExecuteReader,查询数据
        /// <summary>
        /// ExecuteReader,查询数据
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="paras">查询参数</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] paras)
        {
            SqlConnection connReader = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            Prepare(connReader, cmd, sql, paras);//进行通道连接,执行命令对象赋值
            SqlDataReader sdr = null;
            //try
            //{
                sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            //}
            //catch (SqlException e) { }
            return sdr;
        }
        #endregion

        /// <summary>
        /// 执行查询，返回第一行第一列的值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static Object ExecuteScalar(string sql, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand();
                Prepare(conn, cmd, sql, paras);//进行通道连接,执行命令对象赋值
                Object obj = null;
                //try
                //{
                    obj = cmd.ExecuteScalar();
                //}
                //catch (SqlException e) { }
                return obj;
            }
        }

        /// <summary>
        /// 增删改,更新数据
        /// </summary>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand();
                Prepare(conn, cmd, sql, paras);
                int re = 0;
                //try
                //{
                    re = cmd.ExecuteNonQuery();
                //}
                //catch (SqlException e) { }
                return re;
            }
        }

        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetDataSet(string sql)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(ds, "Temp");
            }
            return ds.Tables["Temp"];
        }
    }
}
