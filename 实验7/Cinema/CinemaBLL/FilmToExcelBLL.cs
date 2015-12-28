using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaDAL;
using System.Data;

namespace CinemaBLL
{
    public class FilmToExcelBLL
    {
        private FilmToExcelDAL filmSource = new FilmToExcelDAL();

        /// <summary>
        /// 将批量数据插入数据库（Excel)
        /// </summary>
        /// <param name="maplist"></param>
        /// <param name="tableName"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool SqlBulkCopyImport(IList<string> maplist, string tableName, DataTable dt)
        {
            return filmSource.SqlBulkCopyImport(maplist, tableName, dt);
        }

        /// <summary>
        /// 将Excel转化为Datatable
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataTable GetExcelDataTable(string fName, string tableName)
        {
            return filmSource.GetExcelDataTable(fName, tableName);
        }

        /// <summary>
        /// 获取列的信息
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public List<string> GetColumnInfo(string tableName)
        {
            return filmSource.GetColumnInfo(tableName);
        }

        /// <summary>
        /// 导出片源表信息
        /// </summary>
        /// <param name="SheetName"></param>
        /// <param name="filename"></param>
        /// <param name="sql"></param>
        public void Export(string SheetName, string filename, string sql)
        {
            filmSource.Export(SheetName, filename, sql);
        }
    }
}
