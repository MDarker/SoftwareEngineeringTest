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
    public class FilmToExcelDAL
    {
        /// <summary>
        /// 将批量数据插入数据库（Excel)
        /// </summary>
        /// <param name="maplist"></param>
        /// <param name="tableName"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool SqlBulkCopyImport(IList<string> maplist, string tableName, DataTable dt)
        {
            return OLEHelper.SqlBulkCopyImport(maplist, tableName, dt);
        }

        /// <summary>
        /// 将Excel转化为Datatable
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataTable GetExcelDataTable(string fName, string tableName)
        {
            return OLEHelper.GetExcelDataTable(fName, tableName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public List<string> GetColumnInfo(string tableName)
        {
            return OLEHelper.GetColumnInfo(tableName);
        }

        public void Export(string SheetName, string filename, string sql)
        {
            OLEHelper.Export(SheetName, filename, sql);
        }
    }
}
