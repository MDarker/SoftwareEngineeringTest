using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCommon
{
    public class DateFormat
    {
        /// <summary>
        /// 转换日期格式 -> yy/mm/dd
        /// </summary>
        /// <param name="strDate"></param>
        /// <returns></returns>
        public static string GetRightDateFormat(string strDate)
        {
            string fDate = strDate;
            if (fDate.Contains("星期"))
            {
                fDate = (Convert.ToDateTime(fDate.Substring(0, fDate.IndexOf("星") - 1)).ToShortDateString());
                fDate = fDate.Substring(0, fDate.IndexOf("星") - 1);
            }
            else
            {
                fDate = Convert.ToDateTime(fDate).ToShortDateString();
                if (fDate.Contains("星期"))
                {
                    fDate = fDate.Substring(0, fDate.LastIndexOf('/'));
                }
            }
            return fDate;
        }
    }
}
