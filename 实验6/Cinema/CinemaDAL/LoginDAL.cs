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
    public class LoginDAL
    {
        /// <summary>
        /// 检查是否登录成功
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        public void CheckLogin(string id, string pwd)
        {
            string sql = " select COUNT(*) from Admit " +
                " where id=@id and pwd=@pwd ";

            SqlParameter[] paras ={
                                      new SqlParameter("@id",SqlDbType.VarChar,10),
                                      new SqlParameter("@pwd",SqlDbType.VarChar,50)
                                 };

            Dao.ExecuteScalar(sql, paras);
        }
    }
}
