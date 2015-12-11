using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaDAL;
using System.IO;
namespace CinemaBLL
{
    public class FileOperationBLLL
    {
        FileOperationDAL fod = new FileOperationDAL();


        #region 创建一个文本文件
        /// <summary>
        /// 创建一个文本文件
        /// </summary>
        /// <param name="filmName"></param>
        /// <param name="ticketMsg"></param>
        public void CreateTextFile(string filmName)
        {
            fod.CreateTextFile(filmName);
        }
        #endregion

        #region 打开文本文件
        /// <summary>
        /// 打开文本文件
        /// </summary>
        /// <param name="filmName"></param>
        public void OpenTextFile(string filmName)
        {

        } 
        #endregion

        #region 添加文本内容

        /// <summary>
        /// 添加文本内容
        /// </summary>
        /// <param name="sw"></param>
        /// <param name="ticketMsg"></param>
        public int AppendTicketsMsg(string filmName, List<string> ticketMsgs)
        {
            return fod.AppendTicketsMsg(filmName, ticketMsgs);
        }
        #endregion

        #region 得到文本中已有的座位信息
        /// <summary>
        /// 得到文本中已有的座位信息
        /// </summary>
        /// <param name="filmName"></param>
        public List<string> GetSeatsMsg(string filmName, string checkMsg)
        {
            string txtMsg = fod.GetSeatsMsg(filmName);
            string[] ticketMsg = txtMsg.Trim().Split('\r');
            List<string> seats = new List<string> ();
            if (string.IsNullOrEmpty(ticketMsg[0].Trim()))
            {
                return null;
            }

            for (int i = 0; i < ticketMsg.Length; i++)
            {
                if (ticketMsg[i].Contains(checkMsg))
                {
                    seats.Add(ticketMsg[i].Trim().Substring(ticketMsg[i].LastIndexOf(',')+1));
                }
            }


            return seats;
        }
        #endregion

        #region 判断指定文本是否存在
        /// <summary>
        /// 判断指定文本是否存在
        /// </summary>
        public Boolean JudgeFileExists(string filmName)
        {
            return fod.JudgeFileExists(filmName);
        }
        #endregion

        #region 关闭文本文件
        /// <summary>
        /// 关闭文本文件
        /// </summary>
        /// <param name="sw"></param>
        public void CloseFile(StreamWriter sw)
        {
            fod.CloseFile(sw);
        }
        #endregion

    }
}
