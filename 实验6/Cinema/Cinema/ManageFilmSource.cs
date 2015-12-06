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
    /// 片源管理
    /// </summary>
    public partial class ManageFilmSource : Form
    {
        private SellTicket sellTicket;
        public ManageFilmSource(SellTicket sellTicket)
        {
            InitializeComponent();
            this.sellTicket = sellTicket;
        }

        private void ManageFilmSource_FormClosed(object sender, FormClosedEventArgs e)
        {
            sellTicket.Show();//窗口关闭时，主窗体显示
        }
    }
}
