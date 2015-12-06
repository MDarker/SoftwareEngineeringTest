using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaBLL;
using CinemaCommon;

namespace Cinema
{
    /// <summary>
    /// 排片
    /// </summary>
    public partial class ManageFilmSchedule : Form
    {
        private SellTicket sellTicket;

        FilmMsgBLL filmMsg = new FilmMsgBLL();
        VideoHallBLL videoHall = new VideoHallBLL();
        FilmScheduleBLL filmSchedule = new FilmScheduleBLL();

        public ManageFilmSchedule(SellTicket sellTicket)
        {
            InitializeComponent();
            this.sellTicket = sellTicket;
        }

        /// <summary>
        /// 加载窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageFilmSchedule_Load(object sender, EventArgs e)
        {
            //初始化控件
            GetNoScheduleFilm();
            InitVideoHallNO();
            InitFilmBeginTime();

            grp_schedule.Text = "还没排的影片：";
            rdo_unshelve.Enabled = false;
            //还没排的
            if (grp_schedule.Text.Contains("还没排"))
            {
                btn_confirm.Text = "上架";
            }
            //已经排的
            if (grp_schedule.Text.Contains("已经排"))
            {
                btn_confirm.Text = "更改";
            }
        }

        /// <summary>
        /// 还没排的影片信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NoSchedule_Click(object sender, EventArgs e)
        {
            //DataTable dt = (DataTable)dgv_filmSchedule.DataSource;
            //dt.Rows.Clear();
            //dgv_filmSchedule.DataSource = dt;

            grp_schedule.Text = "还没排的影片：";
            btn_confirm.Text = "上架";
            rdo_unshelve.Enabled = false;
            txt_filmName.Text = "";
            cbo_videoHallNO.SelectedIndex = 0;
            cbo_filmBeginTime.SelectedIndex = 0;
            txt_filmEndTime.Text = "";
            lbl_filmId.Text = "";

            GetNoScheduleFilm();
        }

        /// <summary>
        /// 已经排好的影片信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Scheduled_Click(object sender, EventArgs e)
        {
            //DataTable dt = (DataTable)dgv_filmSchedule.DataSource;
            //dt.Rows.Clear();
            //dgv_filmSchedule.DataSource = dt;

            grp_schedule.Text = "已经排的影片：";
            btn_confirm.Text = "更改";
            rdo_unshelve.Enabled = true;
            txt_filmName.Text = "";
            cbo_videoHallNO.Text = "";
            cbo_filmBeginTime.Text = "";
            txt_filmEndTime.Text = "";
            lbl_filmId.Text = "";

            GetScheduledFilm();
        }

        /// <summary>
        /// 点击确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            int filmId = Convert.ToInt32(lbl_filmId.Text);//电影Id
            //已排情况下,点击下架
            if (rdo_unshelve.Checked)
            {
                DialogResult dr = MessageBox.Show("是否确认下架" + txt_filmName.Text, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                //删除排片表中的信息
                bool rDel = filmSchedule.DeletScheduledFilm(filmId);
                //记录排片次数
                bool rTime = filmMsg.SubScheduleTime(filmId);
                if (rDel && rTime)
                {
                    MessageBox.Show("成功下架");
                    //刷新dgv控件
                    GetScheduledFilm();
                }
                else
                {
                    MessageBox.Show("下架失败");
                }
            }
            //将控件数据存入CommonFilmSchedule类
            CommonFilmSchedule cfilmSchedule = new CommonFilmSchedule();
            cfilmSchedule.FilmId = Convert.ToInt32(lbl_filmId.Text);
            cfilmSchedule.FilmName = txt_filmName.Text;
            cfilmSchedule.VideoHallId = (int)cbo_videoHallNO.SelectedValue;
            CommonSchedule schedule = (CommonSchedule)cbo_filmBeginTime.SelectedItem;
            cfilmSchedule.FilmBeginTime = schedule.Time;
            cfilmSchedule.FilmEndTime = txt_filmEndTime.Text;
            if (grp_schedule.Text.Contains("还没排的"))
            {
                //保存排好的信息
                bool rAdd = filmSchedule.AddFilmSchedule(cfilmSchedule);
                //记录排片次数
                bool rTime = filmMsg.AddScheduleTime(filmId);
                if (rAdd && rTime)
                {
                    //刷新dgv控件
                    GetNoScheduleFilm();
                    MessageBox.Show("影片已排好");
                }
            }
            if (grp_schedule.Text.Contains("已经排的"))
            {
                //更改排好影片的信息
                bool re = filmSchedule.ModifyScheduledFilm(cfilmSchedule);

                if (re)
                {
                    //刷新dgv控件
                    GetScheduledFilm();
                    MessageBox.Show("修改完成");
                }
            }
        }

        /// <summary>
        /// 得到未排的影片
        /// </summary>
        private void GetNoScheduleFilm()
        {
            dgv_filmSchedule.DataSource = null;//清除之前绑定的数据表
            DataTable dt = filmMsg.GetNoScheduleFilm();
            if (dt.Rows.Count > 0)
            {
                dgv_filmSchedule.DataSource = dt;
                dgv_filmSchedule.Columns["filmId"].HeaderText = "电影Id";
                dgv_filmSchedule.Columns["filmName"].HeaderText = "电影名称";
                dgv_filmSchedule.Columns["filmTimes"].HeaderText = "电影时长";
                dgv_filmSchedule.Columns["scheduleTime"].HeaderText = "排片次数";
                dgv_filmSchedule.Columns["filmId"].DataPropertyName = "FilmId";
                dgv_filmSchedule.Columns["filmName"].DataPropertyName = "FilmName";
                dgv_filmSchedule.Columns["filmTimes"].DataPropertyName = "FilmTimes";
                dgv_filmSchedule.Columns["scheduleTime"].DataPropertyName = "ScheduleTime";
                int id = (int)dgv_filmSchedule.SelectedRows[0].Cells["filmId"].Value;
                string name = dgv_filmSchedule.SelectedRows[0].Cells["filmName"].Value.ToString();
                lbl_filmId.Text = id.ToString();
                txt_filmName.Text = name;
            }
            else
            {
                MessageBox.Show("没有还没排的影片");
            }
        }

        /// <summary>
        /// 得到已排的影片
        /// </summary>
        private void GetScheduledFilm()
        {
            dgv_filmSchedule.DataSource = null;//清除之前绑定的数据表
            DataTable dt = filmMsg.GetScheduledFilm();
            if (dt.Rows.Count > 0)
            {
                dgv_filmSchedule.DataSource = dt;
                dgv_filmSchedule.Columns["filmId"].HeaderText = "电影Id";
                dgv_filmSchedule.Columns["filmName"].HeaderText = "电影名称";
                dgv_filmSchedule.Columns["videoHallId"].HeaderText = "放映厅Id";
                dgv_filmSchedule.Columns["filmBeginTime"].HeaderText = "放映开始时间";
                dgv_filmSchedule.Columns["filmEndTime"].HeaderText = "放映结束时间";
                dgv_filmSchedule.Columns["filmId"].DataPropertyName = "FilmId";
                dgv_filmSchedule.Columns["filmName"].DataPropertyName = "FilmName";
                dgv_filmSchedule.Columns["videoHallId"].DataPropertyName = "VideoHallId";
                dgv_filmSchedule.Columns["filmBeginTime"].DataPropertyName = "FilmBeginTime";
                dgv_filmSchedule.Columns["filmEndTime"].DataPropertyName = "FilmEndTime";
                int id = (int)dgv_filmSchedule.SelectedRows[0].Cells["filmId"].Value;
                string name = dgv_filmSchedule.SelectedRows[0].Cells["filmName"].Value.ToString();
                int videoHallId = (int)dgv_filmSchedule.SelectedRows[0].Cells["videoHallId"].Value;//放映厅Id
                string filmBeginTime = dgv_filmSchedule.SelectedRows[0].Cells["filmBeginTime"].Value.ToString(); //放映开始时间
                string filmEndTime = dgv_filmSchedule.SelectedRows[0].Cells["filmEndTime"].Value.ToString();//放映结束时间
                lbl_filmId.Text = id.ToString();
                txt_filmName.Text = name;
                cbo_videoHallNO.Text = videoHallId.ToString();
                cbo_filmBeginTime.Text = filmBeginTime;
                txt_filmEndTime.Text = filmEndTime;
            }
            else
            {
                MessageBox.Show("没有已经排的影片");
            }
        }

        /// <summary>
        /// 初始化放映厅号
        /// </summary>
        private void InitVideoHallNO()
        {
            cbo_videoHallNO.ValueMember = "Id";
            cbo_videoHallNO.DisplayMember = "StrId";
            List<CommonVideoHall> v = new List<CommonVideoHall>();
            v.Add(new CommonVideoHall(0, "请选择放映厅"));
            v.AddRange(videoHall.GetVideoHallNO());
            cbo_videoHallNO.DataSource = v;
        }

        /// <summary>
        /// 初始化影片开始时间段
        /// </summary>
        private void InitFilmBeginTime()
        {
            cbo_filmBeginTime.ValueMember = "Id";
            cbo_filmBeginTime.DisplayMember = "Time";
            List<CommonSchedule> s = new List<CommonSchedule>();
            s.Add(new CommonSchedule(0, "请选择影片开始时间"));
            s.AddRange(filmSchedule.GetFilmBeginTime());
            cbo_filmBeginTime.DataSource = s;
        }

        private void ManageFilmSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            sellTicket.Show();//窗口关闭时，主窗体显示
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 点击dgv,读取影片信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_filmSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            //还没排的,已经排的 公用
            int id = (int)dgv_filmSchedule.Rows[e.RowIndex].Cells["filmId"].Value;
            string name = dgv_filmSchedule.Rows[e.RowIndex].Cells["filmName"].Value.ToString();
            lbl_filmId.Text = id.ToString();
            txt_filmName.Text = name;
            //已经排的
            if (grp_schedule.Text.Contains("已经排"))
            {
                int videoHallId = (int)dgv_filmSchedule.Rows[e.RowIndex].Cells["videoHallId"].Value;//放映厅Id
                string filmBeginTime = dgv_filmSchedule.Rows[e.RowIndex].Cells["filmBeginTime"].Value.ToString(); //放映开始时间
                string filmEndTime = dgv_filmSchedule.Rows[e.RowIndex].Cells["filmEndTime"].Value.ToString();//放映结束时间
                //-----------这样做会有问题吗---------------------
                //更新：暂时没有
                cbo_videoHallNO.Text = videoHallId.ToString();
                cbo_filmBeginTime.Text = filmBeginTime;
                txt_filmEndTime.Text = filmEndTime;
            }
        }

        /// <summary>
        /// 只在界面点击下拉，选择之后发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_filmBeginTime_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CommonSchedule schedule = (CommonSchedule)cbo_filmBeginTime.SelectedItem;
            if (schedule.Time.Contains("请选择"))
            {
                txt_filmEndTime.Text = "";
                return;
            }
            txt_filmEndTime.Text = AddTime(schedule.Time, "2:30");
        }

        /// <summary>
        /// 将影片开始时间加上一定时间
        /// </summary>
        /// <param name="oldTime"></param>
        /// <param name="addTime"></param>
        /// <returns></returns>
        private string AddTime(string oldTime, string addTime)
        {
            //时间形式为2:00,14:30
            string[] time = oldTime.Split(':');
            string[] add = addTime.Split(':');
            int hour, min, addHour, addMin, carry = 0;
            string strMin = "";
            hour = Convert.ToInt32(time[0]);
            min = Convert.ToInt32(time[1]);
            addHour = Convert.ToInt32(add[0]);
            addMin = Convert.ToInt32(add[1]);
            min = min + addMin;
            strMin = min.ToString();
            if (min >= 60)
            {
                min -= 60;
                strMin = min.ToString();
                if (strMin.Length < 2)//将1->01
                    strMin = "0" + strMin;
                carry = 1;//进位，满60进1
            }
            hour += addHour + carry;
            hour %= 24;

            return hour.ToString() + ":" + strMin;
        }
    }
}
