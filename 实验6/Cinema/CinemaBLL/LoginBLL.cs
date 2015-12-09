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
            Object obj=ld.CheckLogin(id, pwd);
            if (obj != null)
            {
                int i = Convert.ToInt32(obj);
                if (i > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
