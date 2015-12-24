using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CinemaBLL;
using CinemaCommon;

namespace Cinema
{
    /// <summary>
    /// 放映厅管理
    /// </summary>
    public partial class ManageVideoHall : Form
    {
        private FilmToExcelBLL filmToExcel = new FilmToExcelBLL();
        private VideoHallBLL videoHall = new VideoHallBLL();
        Main m;
        public ManageVideoHall(Main m)
        {
            InitializeComponent();
            this.m = m;
            this.Height = 355;
        }

        private void ManageVideoHall_Load(object sender, EventArgs e)
        {
            GetVideoHall();
        }

        private void ManageVideoHall_FormClosed(object sender, FormClosedEventArgs e)
        {
            m.Show();//窗口关闭时，主窗体显示
        }

        static int oldHallId = 0;
        /// <summary>
        /// 修改放映厅信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modify_Click(object sender, EventArgs e)
        {
            if (btn_Modify.Text.Contains("要"))
            {
                btn_Add.Enabled = false;
                btn_Delete.Enabled = false;
                lbl_ImportExport.Enabled = false;
                txt_VideoHallId.Enabled = true;
                txt_Seatings.Enabled = true;
                txt_Row.Enabled = true;
                txt_Col.Enabled = true;
                btn_Modify.Text = "保存修改";
                return;
            }
            try
            {
                oldHallId = Convert.ToInt32(lbl_OldHallId.Text);
            }
            catch
            {
                MessageBox.Show("请选择影片");
                return;
            }
            CommonVideoHall cvh = new CommonVideoHall();
            cvh.VideoHallId = Convert.ToInt32(txt_VideoHallId.Text);
            cvh.Seatings = Convert.ToInt32(txt_Seatings.Text);
            cvh.RowSeatNum = Convert.ToInt32(txt_Row.Text);
            cvh.ColumnSeatNum = Convert.ToInt32(txt_Col.Text);
            if (videoHall.ModifyVideoHall(oldHallId, cvh))
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
            btn_Modify.Text = "要修改";
            GetVideoHall();
            btn_Cancel_Click(sender, e);
        }

        /// <summary>
        /// 添加放映厅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (btn_Add.Text.Contains("要"))
            {
                CleanTxtControl();
                btn_Modify.Enabled = false;
                btn_Delete.Enabled = false;
                lbl_ImportExport.Enabled = false;
                txt_VideoHallId.Enabled = true;
                txt_Seatings.Enabled = true;
                txt_Row.Enabled = true;
                txt_Col.Enabled = true;
                btn_Add.Text = "保存添加";
                return;
            }
            CommonVideoHall cvh = new CommonVideoHall();
            cvh.VideoHallId = 0;
            try
            {
                cvh.VideoHallId = Convert.ToInt32(txt_VideoHallId.Text);
            }
            catch
            {
                MessageBox.Show("请输入正确的电影ID");
                return;
            }
            cvh.Seatings = Convert.ToInt32(txt_Seatings.Text);
            cvh.RowSeatNum = Convert.ToInt32(txt_Row.Text);
            cvh.ColumnSeatNum = Convert.ToInt32(txt_Col.Text);

            if (videoHall.AddVideoHall(cvh))
            {
                GetVideoHall();
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            GetVideoHall();
            btn_Cancel_Click(sender, e);
        }

        /// <summary>
        /// 删除放映厅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            int videoHallId = 0;
            try
            {
                videoHallId = Convert.ToInt32(txt_VideoHallId.Text);
            }
            catch
            {
                MessageBox.Show("请选择电影");
                return;
            }
            DialogResult dr = MessageBox.Show("是否确认删除" + txt_VideoHallId.Text + "号放映厅", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            videoHall.DeleteVideoHall(videoHallId);
            GetVideoHall();
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
            btn_Delete.Enabled = true;
            lbl_ImportExport.Enabled = true;
            txt_VideoHallId.Enabled = false;
            txt_Seatings.Enabled = false;
            txt_Row.Enabled = false;
            txt_Col.Enabled = false;
        }

        /// <summary>
        /// 点击dgv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_dgv_VideoHallM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_VideoHallM.DataSource == null)
            {
                return;
            }
            DataTableToControl();
        }

        private void CleanTxtControl()
        {
            txt_VideoHallId.Text = "";
            txt_Seatings.Text = "";
            txt_Row.Text = "";
            txt_Col.Text = "";
        }

        /// <summary>
        /// 刷新表格
        /// </summary>
        private void GetVideoHall()
        {
            //dgv_VideoHallM.DataSource = null;
            DataTable dt = videoHall.GetAllVideoHall();
            if (dt.Rows.Count > 0)
            {
                dgv_VideoHallM.DataSource = dt;
                DataTableToControl();
            }
        }

        /// <summary>
        /// 将数据表选中的数据赋值给控件
        /// </summary>
        private void DataTableToControl()
        {
            txt_VideoHallId.Text = dgv_VideoHallM.SelectedRows[0].Cells["VideoHallId"].Value.ToString();
            txt_Seatings.Text = dgv_VideoHallM.SelectedRows[0].Cells["Seatings"].Value.ToString();
            txt_Row.Text = dgv_VideoHallM.SelectedRows[0].Cells["RowSeatNum"].Value.ToString();
            txt_Col.Text = dgv_VideoHallM.SelectedRows[0].Cells["ColumnSeatNum"].Value.ToString();
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
                this.Height = 450;
                return;
            }
            if (lbl_ImportExport.Text.Contains("收起"))
            {
                lbl_ImportExport.Text = "导入导出";
                this.Height = 355;
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
                IList<string> List = filmToExcel.GetColumnInfo("VideoHall");
                DataTable dt = filmToExcel.GetExcelDataTable(fName, "VideoHall");
                try
                {
                    filmToExcel.SqlBulkCopyImport(List, "VideoHall", dt);
                    GetVideoHall();
                    MessageBox.Show("导入成功");
                }
                catch (Exception ex) { throw ex; }
                GC.Collect();
            }
        }

        /// <summary>
        /// 导出放映厅表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "excel2007|*.xlsx";
            saveFileDialog1.FileName = "放映厅表";
            saveFileDialog1.DefaultExt = ".xlsx";
            string fileName = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                string SheetName = "VideoHall";
                string sqls = "select * from  [VideoHall]";
                filmToExcel.Export(SheetName, fileName, sqls);
                GC.Collect();
                MessageBox.Show("导出成功");
            }
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
            saveFileDialog.FileName = "放映厅表模板";
            saveFileDialog.DefaultExt = ".xlsx";
            string fileName = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                string tname = "VideoHall";
                string sql = "select * from " + tname.ToString() + " where 1=2";
                filmToExcel.Export(tname, fileName, sql);
                MessageBox.Show("导出成功");
            }
            GC.Collect();
        }

        #endregion
    }
}
