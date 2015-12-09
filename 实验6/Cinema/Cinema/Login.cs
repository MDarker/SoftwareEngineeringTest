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

namespace Cinema
{
    /// <summary>
    /// 使用 系统 功能需要登录
    /// </summary>
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        LoginBLL login = new LoginBLL();
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text.Trim();
            string pwd = txt_pwd.Text.Trim();
            if (!login.CheckLogin(id, pwd))
            {
                MessageBox.Show("用户名或密码错误!!");
                return;
            }
            this.DialogResult = DialogResult.Yes;
        }
    }
}
