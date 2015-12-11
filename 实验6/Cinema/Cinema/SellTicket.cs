using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using CinemaBLL;
using CinemaCommon;

namespace Cinema
{
    /// <summary>
    /// 售票
    /// </summary>
    public partial class SellTicket : DevExpress.XtraEditors.XtraForm
    {
        //创建对象
        FilmMsgBLL fmb = new FilmMsgBLL();
        FilmMsgCommon fmc = new FilmMsgCommon();
        FileOperationBLLL fob = new FileOperationBLLL();
        InvitationCodeMsg imc = new InvitationCodeMsg();
        Hashtable ht = new Hashtable();
        List<LinkLabel> lls = new List<LinkLabel>();
        int filmid;
        int videoHallid;
        DataView dv = null;
        public SellTicket()
        {
            InitializeComponent();
            menu_videoHallManage.Visible = false;
            menu_filmSourceManage.Visible = false;
            menu_filmSchedule.Visible = false;
        }

        #region 初始化窗体信息
        /// <summary>
        /// 初始化窗体信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellTicket_Load(object sender, EventArgs e)
        {
            //初始化日期，默认索引为第一个日期
            InitReleaseDates();
            cboReleaseDate.SelectedIndex = 0;//默认日期为当天日期，此时textChange事件响应
            //dv = new DataView(fmb.GetFilmReleaseDate(cboReleaseDate.Text));
            DataTable dt = fmb.GetFilmReleaseDate(cboReleaseDate.Text);
            List<LinkLabel> lls1 = new List<LinkLabel>();
            List<LinkLabel> lls2 = new List<LinkLabel>();
            InitControls(tp_videoHall1, 1, lls1);
            InitControls(tp_videoHall1, 2, lls2);
            this.tabcon_videoHall.SelectedIndex = 0;

        }
        #endregion

        private bool isLogin = false;
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

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    btn_confirm.Enabled = false;
                    btnGiver.Enabled = false;
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
                btn_confirm.Enabled = true;
                btnGiver.Enabled = true;
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

        #region 确定按钮，获取取票信息
        /// <summary>
        /// 确定按钮，获取取票信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            int choseSeats = CanBuyTickets();//返回判断的结果，是否可以开始购买票
            int ticketCounts = 0;
            if (choseSeats == 0)
            {
                return;
            }
            if (txt_giver.Enabled == true)//判断是否是使用邀请码购买
            {
                if (choseSeats != 1)
                {
                    MessageBox.Show("使用邀请码只能选择一个座位");
                    return;
                }
                GetTickets(ticketCounts);
                //兑换成功，邀请码失效,数据库操作更新验证码状态
                fmb.UpdateInvitationState(imc.InvitationCode);
                rdo_comTicket.Checked = true;//重新回到普通票按钮
            }
            else
            {
                ticketCounts = GetTickets(ticketCounts);
            }

        }
        #endregion

        #region 买票操作，获得指定票
        /// <summary>
        /// 买票操作
        /// </summary>
        /// <param name="ticketCounts"></param>
        /// <returns></returns>
        private int GetTickets(int ticketCounts)
        {
            DialogResult ds2 = MessageBox.Show("确定选择选中的座位？", "确认界面", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ds2 == DialogResult.Yes)
            {
                //得到要添加信息的电影名称，也是文件的名称
                string filmName = this.trv1_movieList.SelectedNode.Parent.Text;
                //得到添加进入文本文件的信息
                string filmPlayMsg = filmName + ',' + cboReleaseDate.Text.Substring(0, 9) + ',' + videoHallid + ','
                    + this.trv1_movieList.SelectedNode.Text.Trim() + ',';
                //string[] ticketMsgs = null;
                List<string> ticketMsgs = new List<string>();
                List<LinkLabel> ls = ht[videoHallid] as List<LinkLabel>;

                for (int i = 0, tickentCounts = 0; i < ls.Count; i++)
                {
                    if (ls[i].LinkVisited == true && ls[i].Enabled == true)
                    {
                        ls[i].Enabled = false;
                        //ticketMsgs.a
                        ticketMsgs.Add(filmPlayMsg + ls[i].Text);
                        tickentCounts++;
                    }
                }
                //将符合的信息传到文本中，并返回添加的票数
                ticketCounts = fob.AppendTicketsMsg(filmName, ticketMsgs);
                //将卖出的电影票数量传回数据库，返回受影响的行数
                int isSelledTickets = fmb.GetTicketCounts(ticketCounts, this.trv1_movieList.SelectedNode.Text.Trim(), filmid);
                if (isSelledTickets > 0)//如果大于0，则操作成功
                {
                    MessageBox.Show("操作成功,您已获得" + ticketCounts.ToString() + "张票", "购买成功");
                }
            }
            else
            {
                MessageBox.Show("您已取消操作，系统自动返回购票界面！！！");
            }
            return ticketCounts;
        }
        #endregion

        #region 判断条件，是否可以开始进行购票
        /// <summary>
        /// 判断条件，是否可以开始进行购票
        /// </summary>
        /// <returns></returns>
        private int CanBuyTickets()
        {
            int choseSeats = 0;
            //遍历座位表，查看用户是否已选择座位
            List<LinkLabel> ls = ht[videoHallid] as List<LinkLabel>;
            if (this.trv1_movieList.SelectedNode.Parent == null)
            {
                MessageBox.Show("请选择想要观看的影片以及时段");
                return choseSeats;
            }
            foreach (LinkLabel item in ls)
            {
                if (item.LinkVisited == true && item.Enabled == true)
                {
                    choseSeats++;
                }
            }
            if (choseSeats == 0)
            {
                MessageBox.Show("请选择座位");
            }
            return choseSeats;
        }
        #endregion

        #region 获取电影票出售情况
        /// <summary>
        /// 获取电影票出售情况
        /// </summary>
        private void GetSellTicketSeats(string filmName)
        {
            //判断指定电影的文本文件是否存在前还原（重置)控件属性
            foreach (LinkLabel item in (List<LinkLabel>)ht[videoHallid])
            {
                item.Enabled = true;
                item.LinkVisited = false;
            }
            //判断是否已存在存储该电影的电影票的文本文件，存在，得到已出售的电影票的信息，若不存在，则创建并向其中加入内容
            if (fob.JudgeFileExists(filmName))
            {
                string checkMsg = filmName + ',' + cboReleaseDate.Text.Substring(0, 9) + ',' + videoHallid + ',' + this.trv1_movieList.SelectedNode.Text.Trim();
                //打开并遍历文件，获取已卖出的电影票座位号字符串数组
                //判断是否存在座位信息
                List<string> seatsMsg = fob.GetSeatsMsg(filmName, checkMsg);
                if (seatsMsg != null)
                {
                    foreach (string seatMsg in seatsMsg)
                    {
                        foreach (LinkLabel item in (List<LinkLabel>)ht[videoHallid])
                        {
                            if (item.Text.Trim() == seatMsg.Trim())//如果存在，则设其控件属性enable为false
                            {
                                item.Enabled = false;
                            }
                        }
                    }
                }
                else
                {
                    //返回的数组为空，说明暂时还没有座位出售信息，不做操作
                }
            }
            else
            {
                //创建一个保存电影票的文本文件
                fob.CreateTextFile(filmName);
            }
        }

        #region 向文件中添加售票的信息
        /// <summary>
        /// 向文件中添加售票的信息
        /// </summary>
        /// <param name="sw"></param>
        private int AddTicketMsg(StreamWriter sw)
        {
            int ticketCounts = 0;
            List<LinkLabel> ls = ht[videoHallid] as List<LinkLabel>;
            foreach (LinkLabel item in ls)
            {
                if (item.LinkVisited == true && item.Enabled == true)
                {
                    item.Enabled = false;
                    sw.WriteLine(item.Text);
                    sw.Flush();
                    ticketCounts++;
                }
            }
            sw.Close();
            return ticketCounts;
        }
        #endregion
        #endregion

        #region 点击选中节点，获取影片信息
        /// <summary>
        /// 点击选中节点，获取影片信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trv1_movieList_AfterSelect(object sender, TreeViewEventArgs e)
        {

            string nodeName = trv1_movieList.SelectedNode.Text.Trim();
            if (e.Node.Parent == null)//父节点trv1_movieList.SelectedNode.Text.Trim()
            {
                fmc = fmb.GetFilmMsg(nodeName);
                lbl_filmName.Text = fmc.FilmName;
                lbl_director.Text = fmc.Director;
                lbl_protagonist.Text = fmc.Protagonists;
                lbl_filmType.Text = fmc.FilmType;
                lbl_filmTime.Text = fmc.FilmTimes;
                pic_filmImg.Image = imgLIst_FilmPic.Images[fmc.FilmId - 1];

            }
            else//子节点
            {
                //点击字节点，获取，优惠价，票价，和放映厅号信息
                string filmName = this.trv1_movieList.SelectedNode.Parent.Text;
                fmc = fmb.GetFilmMsg(filmName);
                lbl_filmName.Text = fmc.FilmName;
                lbl_director.Text = fmc.Director;
                lbl_protagonist.Text = fmc.Protagonists;
                lbl_filmType.Text = fmc.FilmType;
                lbl_filmTime.Text = fmc.FilmTimes;
                pic_filmImg.Image = imgLIst_FilmPic.Images[fmc.FilmId - 1];
                DataTable dt = fmb.GetFilmReleaseDate(cboReleaseDate.Text);
                dv = new DataView(dt);
                foreach (DataRowView drv in dv)
                {
                    if (Convert.ToString(drv["PlayTime"]) == e.Node.Text)
                    {
                        lbl_price.Text = drv["TicketPrice"].ToString();
                        lbl_bestPrice.Text = drv["PreferentialPrice"].ToString();
                        //得到当前电影id
                        filmid = Convert.ToInt32(drv["FilmId"]);
                        //得到放映厅号
                        videoHallid = Convert.ToInt32(drv["VideoHallId"]);
                        //切换放映厅
                        this.tabcon_videoHall.SelectedIndex = videoHallid - 1;//由于放映厅号id是从0开始，因此需要减1
                        break;

                    }
                }
                //判断文件里是否已经有这个信息了
                // string[] s = File.ReadAllText(fileName).Trim().Split('\r');
                //获取此时段该影片的售票信息
                // string fileName = nodeName + pnodeName;
                GetSellTicketSeats(filmName);
            }

        }
        #endregion

        #region 初始化片名列表,绑定TreeView（利用TreeNodeCollection）
        /// <summary>
        /// 初始化片名列表,绑定TreeView（利用TreeNodeCollection）
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="tnc"></param>
        /// <param name="parentId"></param>
        private void InitFilmNamelist(DataTable dt, TreeNodeCollection tnc, string parentId)
        {
            DataView dv = new DataView(dt);
            TreeNode tn;//建立TreeView的节点（TreeNode），以便将取出的数据添加到节点中
            //以下为三元运算符，如果父id为空，则为构建“父id字段 is null”的查询条件，否则构建“父id字段=父id字段值”的查询条件
            string filter = string.IsNullOrEmpty(parentId) ? "ParentId is null" : string.Format("ParentId='{0}'", parentId);
            dv.RowFilter = filter;//利用DataView将数据进行筛选，选出相同 父id值 的数据
            foreach (DataRowView drv in dv)
            {
                tn = new TreeNode();//建立一个新节点（学名叫：一个实例）
                tn.Tag = drv["ChildId"].ToString();//节点的Value值，一般为数据库的id值
                if (parentId == "0")
                {
                    tn.Text = drv["FilmName"].ToString();//如果父节点，则显示电影名称，节点的Text，节点的文本显示
                }
                else
                {
                    tn.Text = drv["PlayTime"].ToString();//若是子节点，则赋予放映时段
                }
                tnc.Add(tn);//将该节点加入到TreeNodeCollection（节点集合）中
                InitFilmNamelist(dt, tn.Nodes, tn.Tag.ToString());//递归（反复调用这个方法，直到把数据取完为止）
            }
        }
        #endregion

        #region 初始化LinkLablek控件
        /// <summary>
        /// 初始化LinkLablek控件
        /// </summary>
        public void InitControls(TabPage tp_videoHall, int VideoHallId, List<LinkLabel> lls1)
        {
            foreach (var item in tp_videoHall.Controls)
            {
                if (item is LinkLabel)
                {
                    lls1.Add(item as LinkLabel);
                }
            }
            ht.Add(VideoHallId, lls1);
        }

        #endregion

        #region 点击事件，判断座位是否被选中，通过颜色来判定，点击两次取消选中
        /// <summary>
        /// 点击事件，判断座位是否被选中，通过颜色来判定，点击两次取消选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLb5_8_Click(object sender, EventArgs e)
        {
            List<LinkLabel> llinkLables = ht[videoHallid] as List<LinkLabel>;
            LinkLabel l = sender as LinkLabel;
            foreach (LinkLabel item in llinkLables)
            {
                if (l.Text == item.Text)
                {
                    item.LinkVisited = !item.LinkVisited;
                }
            }
        }
        #endregion

        #region 邀请码兑换电影票处理
        /// <summary>
        /// 邀请码兑换电影票处理
        /// </summary>
        /// <param name="invitationCode"></param>
        public Boolean HandleCodeMsg(string invitationCode)
        {
            imc = fmb.CheckInvitationCode(invitationCode);
            if (imc == null)
            {
                MessageBox.Show("你的邀请码有错,请重新输入");
                txt_giver.Text = "";
                txt_giver.Select();
                return false;
            }
            else if (imc.CodeState == 0)
            {
                DialogResult ds = MessageBox.Show("不好意思，您的邀请码已过期，是否输入新的邀请码？", "过期提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //可以做一个功能，选择是返回继续输入邀请码，否的话，底下取票按钮变成购买按钮，用户可以就自己选择的座位购买票
                if (ds == DialogResult.Yes)
                {
                    txt_giver.Text = "";//清空邀请码框内容
                    txt_giver.Select();//焦点返回输入邀请码控件
                }
                else
                {
                    txt_giver.Enabled = false;
                    txt_giver.Text = "";
                    btn_confirm.Select();
                }
                return false;
            }
            else//进行确定操作
            {
                //根据邀请码跳转到相应的电影处
                this.trv1_movieList.SelectedNode = trv1_movieList.Nodes[imc.FilmId - 1];
                this.trv1_movieList.SelectedNode.BackColor = Color.Wheat;
                return true;
            }
        }
        #endregion

        #region 使用邀请码
        /// <summary>
        /// 使用邀请码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGiver_Click(object sender, EventArgs e)
        {
            btn_confirm.Enabled = true;
            HandleCodeMsg(txt_giver.Text.Trim());
            //{
            //    int canBuyTickets = CanBuyTickets();//返回判断的结果，是否可以开始购买票
            //    if (!canBuyTickets)
            //    {
            //        return;
            //    }
            //    else
            //    {
            //        DialogResult ds = MessageBox.Show("确定选择选中的座位？", "确认提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (ds == DialogResult.Yes)
            //        {
            //            //得到文件路径
            //            string fileName = path + this.trv1_movieList.SelectedNode.Text.Trim() + this.trv1_movieList.SelectedNode.Parent.Text.Trim() + ".txt";
            //            StreamWriter sw = null;
            //            using (sw = File.AppendText(@fileName))
            //            {
            //                //添加信息并返回添加电影票的数量
            //                AddTicketMsg(sw);
            //            }
            //            //将卖出的电影票数量传回数据库，返回受影响的行数
            //            int isSelledTickets = fmb.GetTicketCounts(1, this.trv1_movieList.SelectedNode.Text.Trim(), filmid);
            //            if (isSelledTickets > 0)//如果大于0，则购买成功
            //            {
            //                MessageBox.Show("您已成功兑换一张票", "兑换成功提示");
            //            }
            //        }
            //    }
            //}
            ////HandleCodeMsg(txt_giver.Text.Trim());
            ////选择时段，座位
        }
        #endregion

        #region 点击赠票radiobutton时才可以填写邀请码
        /// <summary>
        /// 点击赠票radiobutton时才可以填写邀请码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_freeTicket_CheckedChanged(object sender, EventArgs e)
        {
            txt_giver.Enabled = false;
            if (rdo_freeTicket.Checked)
            {
                txt_giver.Text = "";
                txt_giver.Enabled = true;
                btnGiver.Visible = true;
                btn_confirm.Enabled = false;
            }
        }
        #endregion

        #region 初始化放映日期列表
        /// <summary>
        /// 初始化放映日期列表
        /// </summary>
        public void InitReleaseDates()
        {
            DataTable dt = fmb.GetFilmNamesAndShowtimes();
            DataView dv1 = new DataView(dt);
            cboReleaseDate.Items.Add(dv1[0]["ReleaseDates"].ToString());
            for (int i = 0; i < dv1.Count - 1; i++)
            {
                if (!dv1[i]["ReleaseDates"].ToString().Equals(dv1[i + 1]["ReleaseDates"].ToString()))
                {
                    cboReleaseDate.Items.Add(dv1[i + 1]["ReleaseDates"].ToString());
                }
            }

        }
        #endregion

        #region cboReleaseDate_TextChanged事件，日期改变，电影放映列表也随之改变
        /// <summary>
        /// cboReleaseDate_TextChanged事件，日期改变，电影放映列表也随之改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboReleaseDate_TextChanged(object sender, EventArgs e)
        {
            this.trv1_movieList.Nodes.Clear();
            DataTable dt = fmb.GetFilmReleaseDate(cboReleaseDate.Text);
            //获取放映电影的数量、名称、时段、放映厅号、影片信息
            InitFilmNamelist(dt, this.trv1_movieList.Nodes, "0");
            //默认展开所有节点和获得第一个树节点值
            this.trv1_movieList.ExpandAll();
            this.trv1_movieList.SelectedNode = this.trv1_movieList.TopNode;//默认显示第一条电影的信息
        }
        #endregion
    }
}
