using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaDAL;

namespace CinemaBLL
{
    public class LoginBLL
    {
        LoginDAL ld = new LoginDAL();

        /// <summary>
        /// 检查是否登录成功
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool CheckLogin(string id, string pwd)
        {
            ld.CheckLogin(id, pwd);
            return false;
        }
    }
}
