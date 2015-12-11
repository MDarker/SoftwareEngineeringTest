using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    /// <summary>
    /// 放映厅管理
    /// </summary>
    public partial class ManageVideoHall : Form
    {
        private SellTicket sellTicket;
        public ManageVideoHall(SellTicket sellTicket)
        {
            InitializeComponent();
            this.sellTicket = sellTicket;
        }

        private void ManageVideoHall_FormClosed(object sender, FormClosedEventArgs e)
        {
            sellTicket.Show();//窗口关闭时，主窗体显示
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            dgv_VideoHallM.ReadOnly = true;
            btn_Modify.Text = "保存更改";
            MessageBox.Show("可以在表格中修改数据了");
        }
    }
}
