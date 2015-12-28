using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace CinemaSQLHelper
{
    public class OLEHelper
    {
        private static string conStr = "Data Source=localhost;Initial Catalog=影院售票系统;Integrated Security=True";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="tname"></param>
        /// <returns></returns>
        public static DataTable GetExcelDataTable(string path, string tname)
        {
            /*Office 2007*/
            string ace = "Microsoft.ACE.OLEDB.12.0";
            /*Office 97 - 2003*/
            string jet = "Microsoft.Jet.OLEDB.4.0";
            string xl2007 = "Excel 12.0 Xml";
            string xl2003 = "Excel 8.0";
            string imex = "IMEX=1";

            string hdr = "Yes";
            string conn = "Provider={0};Data Source={1};Extended Properties=\"{2};HDR={3};{4}\";";
            string select = string.Format("SELECT * FROM [{0}$]", tname);
            //string select = sql;
            string ext = Path.GetExtension(path);
            OleDbDataAdapter oda;
            DataTable dt = new DataTable("data");
            switch (ext.ToLower())
            {
                case ".xlsx":
                    conn = String.Format(conn, ace, Path.GetFullPath(path), xl2007, hdr, imex);
                    break;
                case ".xls":
                    conn = String.Format(conn, jet, Path.GetFullPath(path), xl2003, hdr, imex);
                    break;
                default:
                    throw new Exception("File Not Supported!");
            }
            OleDbConnection con = new OleDbConnection(conn);
            con.Open();
            //select = string.Format(select, sql);
            oda = new OleDbDataAdapter(select, con);
            oda.Fill(dt);
            con.Close();
            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public static List<string> GetColumnInfo(string TableName)
        {
            string[] restrictions = new string[] { null, null, TableName };
            DataTable tableinfo = GetSchema("Columns", restrictions);
            List<string> list = new List<string>();
            int count = tableinfo.Rows.Count;
            if (count > 0)
            {
                foreach (DataRow DataRowItem in tableinfo.Rows)
                {
                    list.Add(DataRowItem["Column_Name"].ToString());
                }
            }
            return list;
        }

        /// <summary>
        /// 返回指定名称的架构信息	
        /// </summary>
        /// <param name="collectionName">集合名称</param>
        /// <returns>DataTable</returns>
        public static DataTable GetSchema(string collectionName, string[] restictionValues)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                DataTable dt = new DataTable();
                try
                {
                    dt.Clear();
                    conn.Open();
                    dt = conn.GetSchema(collectionName, restictionValues);
                }
                catch
                {
                    dt = null;
                }
                return dt;
            }
        }

        /// <summary>
        /// 将批量数据插入数据库
        /// </summary>
        /// <param name="maplist">对应列</param>
        /// <param name="tableName">要插入的数据库表</param>
        /// <param name="dt">数据源</param>
        /// <returns></returns>
        public static bool SqlBulkCopyImport(IList<string> maplist, string tableName, DataTable dt)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                {
                    bulkCopy.DestinationTableName = tableName;
                    foreach (string a in maplist)
                    {
                        bulkCopy.ColumnMappings.Add(a, a);//dt对应数据库的列
                    }
                    try
                    {
                        bulkCopy.WriteToServer(dt);
                        return true;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 单个表格导出到一个excel工作簿 
        /// </summary>
        /// <param name="SheetName"></param>
        /// <param name="filename"></param>
        /// <param name="db"></param>
        /// <param name="sql"></param>
        public static void Export(string SheetName, string filename, string sql)
        {
            DataTable dt = new DataTable();
            FileInfo newFile = new FileInfo(filename);
            if (newFile.Exists)
            {
                newFile.Delete();
                newFile = new FileInfo(filename);
            }
            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                dt = ReturnDataTable(sql);
                SaveExcel(SheetName, dt, package);
                package.Save();
            }
        }

        /// <summary>
        /// 保存excel文件，覆盖相同文件名的文件
        /// </summary>
        /// <param name="SheetName"></param>
        /// <param name="dt"></param>
        /// <param name="package"></param>
        /// <returns></returns>
        public static bool SaveExcel(string SheetName, DataTable dt, ExcelPackage package)
        {
            try
            {
                ExcelWorksheet ws = package.Workbook.Worksheets.Add(SheetName);
                ws.Cells["A1"].LoadFromDataTable(dt, true);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 运行SQL语句,返回DataTable对象
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable ReturnDataTable(string sql)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                DataTable dt = new DataTable();
                try
                {
                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(sql, connection);
                    command.Fill(dt);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return dt;
            }
        }
    }
}
