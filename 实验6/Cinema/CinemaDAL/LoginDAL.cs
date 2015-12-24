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
        public Object CheckLogin(string id, string pwd)
        {
            string sql = " select COUNT(*) from AdminMsg " +
                " where AdminId=@id and AdminPwd=@pwd ";
            SqlParameter[] paras ={
                                      new SqlParameter("@id",SqlDbType.VarChar,10),
                                      new SqlParameter("@pwd",SqlDbType.VarChar,50)
                                 };
            paras[0].Value = id;
            paras[1].Value = pwd;
            return SQLHelper.ExecuteScalar(sql, paras);
        }
    }
}
