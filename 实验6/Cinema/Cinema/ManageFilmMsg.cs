using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CinemaBLL;
using CinemaCommon;

namespace Cinema
{
    /// <summary>
    /// 片源管理
    /// </summary>
    public partial class ManageFilmMsg : Form
    {
        private FilmToExcelBLL filmToExcel = new FilmToExcelBLL();
        private FilmMsgBLL filmMsg = new FilmMsgBLL();
        Main m;
        public ManageFilmMsg(Main m)
        {
            InitializeComponent();
            this.m = m;
            this.Height = 380;
        }

        private void ManageFilmMsg_Load(object sender, EventArgs e)
        {
            GetFilmsMsg();
        }

        private void ManageFilmMsg_FormClosed(object sender, FormClosedEventArgs e)
        {
            m.Show();//窗口关闭时，主窗体显示
        }

        /// <summary>
        /// 刷新表格
        /// </summary>
        private void GetFilmsMsg()
        {
            //dgv_FilmSourceM.DataSource = null;
            DataTable dt = filmMsg.GetAllFilmsMsg();
            if (dt.Rows.Count > 0)
            {
                dgv_FilmSourceM.DataSource = dt;
                DataTableToControl();
            }
        }

        /// <summary>
        /// 添加电影
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (btn_Add.Text.Contains("要"))
            {
                CleanTxtControl();
                btn_Modify.Enabled = false;
                btn_Del.Enabled = false;
                btn_DownLine.Enabled = false;
                lbl_ImportExport.Enabled = false;
                txt_Country.Enabled = true;
                txt_Director.Enabled = true;
                txt_FilmId.Enabled = true;
                txt_FilmName.Enabled = true;
                txt_FilmTimes.Enabled = true;
                txt_FilmType.Enabled = true;
                txt_Producers.Enabled = true;
                txt_Protagonists.Enabled = true;
                btn_Add.Text = "保存添加";
                return;
            }
            FilmMsgCommon fmc = new FilmMsgCommon();
            fmc.FilmId = 0;
            try
            {
                fmc.FilmId = Convert.ToInt32(txt_FilmId.Text);
            }
            catch
            {
                MessageBox.Show("请输入正确的电影ID");
                return;
            }
            //将控件的值赋给数据库模型
            ControlToModel(fmc);
            fmc.FilmState = 1;
            fmc.ScheduleTime = 0;
            if (filmMsg.AddFilm(fmc))
            {
                GetFilmsMsg();
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            btn_Add.Text = "要添加";
            btn_Cancel_Click(sender, e);
        }

        /// <summary>
        /// 修改电影
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modify_Click(object sender, EventArgs e)
        {
            if (btn_Modify.Text.Contains("要"))
            {
                btn_Add.Enabled = false;
                btn_Del.Enabled = false;
                btn_DownLine.Enabled = false;
                lbl_ImportExport.Enabled = false;
                txt_Country.Enabled = true;
                txt_Director.Enabled = true;
                txt_FilmId.Enabled = true;
                txt_FilmName.Enabled = true;
                txt_FilmTimes.Enabled = true;
                txt_FilmType.Enabled = true;
                txt_Producers.Enabled = true;
                txt_Protagonists.Enabled = true;
                btn_Modify.Text = "保存修改";
                return;
            }
            FilmMsgCommon fmc = new FilmMsgCommon();
            int oldFilmId = 0;
            try
            {
                oldFilmId = Convert.ToInt32(lbl_OldFilmId.Text);
            }
            catch
            {
                MessageBox.Show("请选择影片");
                return;
            }
            //将控件的值赋给数据库模型
            ControlToModel(fmc);
            fmc.FilmState = (int)dgv_FilmSourceM.SelectedRows[0].Cells["FilmState"].Value;
            fmc.ScheduleTime = (int)dgv_FilmSourceM.SelectedRows[0].Cells["ScheduleTime"].Value;
            if (filmMsg.ModifyFilm(oldFilmId, fmc))
            {
                GetFilmsMsg();
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
            btn_Modify.Text = "要修改";
            btn_Cancel_Click(sender, e);
        }

        /// <summary>
        /// 删除电影
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            int filmId = 0;
            try
            {
                filmId = Convert.ToInt32(txt_FilmId.Text);
            }
            catch
            {
                MessageBox.Show("请选择电影");
                return;
            }
            DialogResult dr = MessageBox.Show("是否确认删除" + txt_FilmName.Text, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            filmMsg.DeleteFilm(filmId);
            GetFilmsMsg();
        }

        /// <summary>
        /// 电影下映
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DownLine_Click(object sender, EventArgs e)
        {
            int filmId = 0;
            try
            {
                filmId = Convert.ToInt32(txt_FilmId.Text);
            }
            catch
            {
                MessageBox.Show("请选择电影");
                return;
            }
            DialogResult dr = MessageBox.Show("是否确认下映" + txt_FilmName.Text, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            if (!filmMsg.FilmDownLine(filmId))
            {
                MessageBox.Show("下映失败");
                return;
            }
            GetFilmsMsg();
        }

        /// <summary>
        /// 取消添加修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Button button = null;
            if (sender is Button)
            {
                button = sender as Button;
            }
            if (button.Text.Contains("添加"))
            {
                btn_Add.Text = "要添加";
                btn_Modify.Enabled = true;
            }
            if (button.Text.Contains("修改"))
            {
                btn_Modify.Text = "要修改";
                btn_Add.Enabled = true;
            }
            if (button.Text.Contains("取消"))
            {
                btn_Add.Text = "要添加";
                btn_Modify.Text = "要修改";
                btn_Add.Enabled = true;
                btn_Modify.Enabled = true;
            }
            btn_Del.Enabled = true;
            btn_DownLine.Enabled = true;
            lbl_ImportExport.Enabled = true;
            txt_Country.Enabled = false;
            txt_Director.Enabled = false;
            txt_FilmId.Enabled = false;
            txt_FilmName.Enabled = false;
            txt_FilmTimes.Enabled = false;
            txt_FilmType.Enabled = false;
            txt_Producers.Enabled = false;
            txt_Protagonists.Enabled = false;
        }

        /// <summary>
        /// 将控件的值赋给数据库模型
        /// </summary>
        /// <param name="fmc"></param>
        private void ControlToModel(FilmMsgCommon fmc)
        {
            fmc.FilmId = Convert.ToInt32(txt_FilmId.Text);
            fmc.FilmName = txt_FilmName.Text;
            fmc.FilmTimes = txt_FilmTimes.Text;
            fmc.Director = txt_Director.Text;
            fmc.Protagonists = txt_Protagonists.Text;
            fmc.FilmType = txt_FilmType.Text;
            fmc.Producers = txt_Producers.Text;
            fmc.Country = txt_Country.Text;

            //fmc.Deadline = dtp_Deadline.Value;
            string deadline = Convert.ToString(dtp_Deadline.Value);
            //-*-*--*--*-*-*-*-*-*-*-*--*-*-*-*-*-**
            //日期转换问题
            fmc.Deadline = DateFormat.GetRightDateFormat(deadline);
        }

        /// <summary>
        /// 将数据表选中的数据赋值给控件
        /// </summary>
        private void DataTableToControl()
        {
            txt_FilmId.Text = dgv_FilmSourceM.SelectedRows[0].Cells["FilmId"].Value.ToString();
            lbl_OldFilmId.Text = txt_FilmId.Text;
            txt_FilmName.Text = dgv_FilmSourceM.SelectedRows[0].Cells["FilmName"].Value.ToString();
            txt_FilmTimes.Text = dgv_FilmSourceM.SelectedRows[0].Cells["FilmTimes"].Value.ToString();
            txt_Director.Text = dgv_FilmSourceM.SelectedRows[0].Cells["Director"].Value.ToString();
            txt_Protagonists.Text = dgv_FilmSourceM.SelectedRows[0].Cells["Protagonists"].Value.ToString();
            txt_FilmType.Text = dgv_FilmSourceM.SelectedRows[0].Cells["FilmType"].Value.ToString();
            txt_Producers.Text = dgv_FilmSourceM.SelectedRows[0].Cells["Producers"].Value.ToString();
            txt_Country.Text = dgv_FilmSourceM.SelectedRows[0].Cells["Country"].Value.ToString();
            string deadline = dgv_FilmSourceM.SelectedRows[0].Cells["Deadline"].Value.ToString();
            if (!string.IsNullOrEmpty(deadline))
            {
                dtp_Deadline.Text = deadline.Substring(0, deadline.LastIndexOf('/'));
            }
        }

        /// <summary>
        /// 点击dgv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_FilmSourceM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_FilmSourceM.DataSource == null)
            {
                return;
            }
            //将数据表选中的数据负责给控件
            DataTableToControl();
        }

        private void CleanTxtControl()
        {
            txt_Country.Text = "";
            txt_Director.Text = "";
            txt_FilmId.Text = "";
            txt_FilmName.Text = "";
            txt_FilmTimes.Text = "";
            txt_FilmType.Text = "";
            txt_Producers.Text = "";
            txt_Protagonists.Text = "";
            dtp_Deadline.Value = DateTime.Now.AddDays(15);
        }

        #region Excel导入导出
        /// <summary>
        /// 展开导入数据功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_ImportExport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lbl_ImportExport.Text.Contains("导入导出"))
            {
                lbl_ImportExport.Text = "收起功能";
                this.Height = 464;
                return;
            }
            if (lbl_ImportExport.Text.Contains("收起"))
            {
                lbl_ImportExport.Text = "导入导出数据";
                this.Height = 380;
                return;
            }
        }

        /// <summary>
        /// 浏览Excel文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "EXCEL2007文件|*.xlsx|EXCEL2003文件|*.xls";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_FilePath.Text = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// 导入EXCEL文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Import_Click(object sender, EventArgs e)
        {
            if (txt_FilePath.Text.ToString() == "")
            {
                MessageBox.Show("请选择需要导入的文件和导入的表名！");
            }
            else
            {
                string fName = txt_FilePath.Text.ToString();
                IList<string> List = filmToExcel.GetColumnInfo("FilmsMsg");
                DataTable dt = filmToExcel.GetExcelDataTable(fName, "FilmsMsg");
                try
                {
                    filmToExcel.SqlBulkCopyImport(List, "FilmsMsg", dt);
                    GetFilmsMsg();
                    MessageBox.Show("导入成功");
                }
                catch (Exception ex) { throw ex; }
                GC.Collect();
            }
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "excel2007|*.xlsx";
            saveFileDialog.FileName = "片源表";
            saveFileDialog.DefaultExt = ".xlsx";
            string fileName = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                string SheetName = "FilmsMsg";
                string sql = "select * from  [FilmsMsg]";
                filmToExcel.Export(SheetName, fileName, sql);
                MessageBox.Show("导出成功");
            }
            GC.Collect();
        }

        /// <summary>
        /// 导出模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TP_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "excel2007|*.xlsx";
            saveFileDialog.FileName = "片源表模板";
            saveFileDialog.DefaultExt = ".xlsx";
            string fileName = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                string tname = "FilmsMsg";
                string sql = "select * from " + tname.ToString() + " where 1=2";
                filmToExcel.Export(tname, fileName, sql);
                MessageBox.Show("导出成功");
            }
            GC.Collect();
        }
        #endregion
    }
}
