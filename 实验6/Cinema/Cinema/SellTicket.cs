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
        private bool isLogin = false;
        public SellTicket()
        {
            InitializeComponent();
        }

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
                Login login = new Login();
                if (DialogResult.Yes == login.ShowDialog())
                {
                    isLogin = true;
                    menu_videoHallManage.Visible = true;
                    menu_filmSourceManage.Visible = true;
                    menu_filmSchedule.Visible = true;
                }
            }

        }

        /// <summary>
        /// 放映厅管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_videoHallManage_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 片源管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_filmSourceManage_Click(object sender, EventArgs e)
        {

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
    }
}
