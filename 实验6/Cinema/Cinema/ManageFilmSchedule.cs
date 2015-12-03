using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CinemaBLL;

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

        public ManageFilmSchedule(SellTicket sellTicket)
        {
            InitializeComponent();
            InitFormControl();
            this.sellTicket = sellTicket;
        }

        private void ManageFilmSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            //窗口关闭时，主窗体显示
            sellTicket.Show();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //将排好的数据写入数据库
            //刷新dgv控件
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 初始化窗口需要从数据库更新数据的组件
        /// </summary>
        private void InitFormControl()
        {
            InitDataGridView();
            InitVideoHallNO();
            InitFilmBeginTime();
        }

        /// <summary>
        /// 初始化未排的影片
        /// </summary>
        private void InitDataGridView()
        {
            filmMsg.GetNoScheduleFilm();
        }

        /// <summary>
        /// 初始化放映厅号
        /// </summary>
        private void InitVideoHallNO()
        {
            videoHall.GetVideoHallNO();
        }

        /// <summary>
        /// 初始化影片开始时间段
        /// </summary>
        private void InitFilmBeginTime()
        {

        }
    }
}
