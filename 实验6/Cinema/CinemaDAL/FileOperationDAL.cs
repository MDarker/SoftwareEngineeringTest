using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CinemaDAL
{
    public class FileOperationDAL
    {
        //文本路径
        private static string path = @"F:\影片售票信息\";

        #region 创建一个文本文件
        /// <summary>
        /// 创建一个文本文件
        /// </summary>
        /// <param name="filmName"></param>
        /// <param name="ticketMsg"></param>
        public void CreateTextFile(string filmName)
        {
            StreamWriter sw = null;
            string pathFileName = path + filmName + ".txt";
            sw = File.CreateText(pathFileName);
            sw.Close();
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
            StreamWriter sw = null;
            int addTicketCounts=0;
            string pathFileName = path + filmName + ".txt";
            using (sw = File.AppendText(@pathFileName))
            {
                for (int i = 0; i < ticketMsgs.Count; i++)
                {
                    sw.WriteLine(ticketMsgs[i]);
                    addTicketCounts++;
                    sw.Flush();
                }
            }
            return addTicketCounts;
            
        }
        #endregion

        #region 关闭文本文件
        /// <summary>
        /// 关闭文本文件
        /// </summary>
        /// <param name="sw"></param>
        public void CloseFile(StreamWriter sw)
        {
            sw.Close();
        }
        #endregion

        #region 得到文本中已有的座位信息
        /// <summary>
        /// 得到文本中已有的座位信息
        /// </summary>
        /// <param name="filmName"></param>
        public string GetSeatsMsg(string filmName)
        {
            string pathFileName = path + filmName + ".txt";
            string txtMsg = File.ReadAllText(pathFileName);
            return txtMsg;
        }
        #endregion

        #region 判断指定文本是否存在
        /// <summary>
        /// 判断指定文本是否存在
        /// </summary>
        public Boolean JudgeFileExists(string filmName)
        {
            string pathFileName = path + filmName + ".txt";
            if (File.Exists(pathFileName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

    }
}
