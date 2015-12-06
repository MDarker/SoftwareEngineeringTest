using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cinema
{
    /// <summary>
    /// 售票
    /// </summary>
    public partial class SellTicket : DevExpress.XtraEditors.XtraForm
    {
        public SellTicket()
        {
            InitializeComponent();
            menu_videoHallManage.Visible = false;
            menu_filmSourceManage.Visible = false;
            menu_filmSchedule.Visible = false;
        }

        private bool isLogin = false;

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        /// <summary>
        /// 使用 系统 功能需要登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_system_Click(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                MessageBox.Show("请先登录");
                return;
            }
        }

        /// <summary>
        /// 放映厅管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_videoHallManage_Click(object sender, EventArgs e)
        {
            ManageVideoHall mvh = new ManageVideoHall(this);
            mvh.Show();
            this.Hide();
        }

        /// <summary>
        /// 片源管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_filmSourceManage_Click(object sender, EventArgs e)
        {
            ManageFilmSource mfs = new ManageFilmSource(this);
            mfs.Show();
            this.Hide();
        }

        /// <summary>
        /// 排片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_filmSchedule_Click(object sender, EventArgs e)
        {
            ManageFilmSchedule mfs = new ManageFilmSchedule(this);
            mfs.Show();
            this.Hide();
        }

        private void menu_login_Click(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                Login login = new Login();
                if (DialogResult.Yes == login.ShowDialog())
                {
                    isLogin = true;
                    tabcon_showList.Enabled = false;
                    tabcon_videoHall.Enabled = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    menu_login.Text = "注销";
                    menu_videoHallManage.Visible = true;
                    menu_filmSourceManage.Visible = true;
                    menu_filmSchedule.Visible = true;
                }
            }
            else
            {
                isLogin = false;
                tabcon_showList.Enabled = true;
                tabcon_videoHall.Enabled = true;
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                menu_login.Text = "登录";
                menu_videoHallManage.Visible = false;
                menu_filmSourceManage.Visible = false;
                menu_filmSchedule.Visible = false;
            }
        }

        private void menu_buyTicket_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                MessageBox.Show("请先注销");
            }
        }
    }
}
