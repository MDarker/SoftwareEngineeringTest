using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using CinemaBLL;
using CinemaCommon;

namespace Cinema
{
    public partial class SellTicket : Form
    {
        //创建对象
        FilmMsgBLL fmb = new FilmMsgBLL();
        FilmMsgCommon fmc = new FilmMsgCommon();
        InvitationCodeMsgCommon imc = new InvitationCodeMsgCommon();
        VideoHallBLL vhb = new VideoHallBLL();
        Hashtable ht = new Hashtable();
        int filmid = 0;
        int videoHallid = 0;
        DataView dv = null;
        Main m;
        public SellTicket(Main m)
        {
            InitializeComponent();
            this.m = m;
        }

        #region 初始化窗体信息
        /// <summary>
        /// 初始化窗体信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellTicket_Load(object sender, EventArgs e)
        {
            InitSeats();//初始化放映厅和座位表
            //初始化日期，默认索引为第一个日期
            InitReleaseDates();
            cboReleaseDate.SelectedIndex = 0;//默认日期为当天日期，此时textChange事件响应
            DataTable dt = fmb.GetFilmReleaseDate(cboReleaseDate.Text);
            this.tabcon_videoHall.SelectedIndex = 0;
            cbo_stuDiscount.Enabled = false;
        }

        /// <summary>
        /// 初始化座位表,动态增加
        /// </summary>
        private void InitSeats()
        {
            //获得每个放映厅的座位信息
            List<CommonVideoHall> list = vhb.GetVideoHallMsg();
            foreach (CommonVideoHall item in list)
            {
                TabPage tab = new TabPage();
                tab.Text = "放映厅" + item.StrId;
                tab.Name = "tp_videoHall" + item.StrId;
                tab.BackColor = Color.White;
                tab.Parent = tabcon_videoHall;
                int height = 23;
                int width = 54;
                int locationX = 39;
                int locationY = 13;
                List<LinkLabel> linklabels = new List<LinkLabel>();
                for (int rowCount = 1; rowCount <= item.RowSeatNum; rowCount++)
                {
                    locationX = 39;
                    for (int columnCount = 1; columnCount <= item.ColumnSeatNum; columnCount++)
                    {
                        LinkLabel newlinklable = new LinkLabel();
                        newlinklable.Parent = tab;
                        newlinklable.Text = rowCount + "—" + columnCount;
                        newlinklable.Click += linkLb5_8_Click;
                        newlinklable.MouseEnter += linkLb5_8_MouseEnter;
                        newlinklable.MouseLeave += linkLb5_8_MouseLeave;
                        newlinklable.VisitedLinkColor = Color.Red;
                        newlinklable.ActiveLinkColor = Color.Red;
                        newlinklable.DisabledLinkColor = Color.Gray;
                        newlinklable.Location = new Point(locationX, locationY);
                        newlinklable.Width = width;
                        newlinklable.Height = height;
                        linklabels.Add(newlinklable);
                        locationX += 60;
                    }
                    locationY += 30;
                }
                ht.Add(item.VideoHallId, linklabels);
            }
        }
        #endregion

        #region 确定按钮，获取取票信息
        /// <summary>
        /// 确定按钮，获取取票信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (this.trv1_movieList.SelectedNode.Parent == null)
            {
                MessageBox.Show("请选择想要观看的影片以及时段");
                return;
            }
            int choseSeats = GetChoseSeats();//返回判断的结果，是否可以开始购买票
            if (choseSeats == 0)
            {
                MessageBox.Show("请选择座位");
                return;
            }
            int ticketCounts = 0;
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
                //ticketCounts = GetTickets(ticketCounts);
                ticketCounts = InsertTickets();
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
                List<string> ticketMsgs = new List<string>();
                List<LinkLabel> ls = ht[videoHallid] as List<LinkLabel>;

                for (int i = 0, tickentCounts = 0; i < ls.Count; i++)
                {
                    if (ls[i].LinkVisited == true && ls[i].Enabled == true)
                    {
                        ls[i].Enabled = false;
                        ticketMsgs.Add(filmPlayMsg + ls[i].Text);
                        tickentCounts++;
                    }
                }
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

        #region 向数据库中插入购买的票
        /// <summary>
        /// 向数据库中插入购买的票
        /// </summary>
        public int InsertTickets()
        {
            DialogResult ds2 = MessageBox.Show("确定选择选中的座位？", "确认界面", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int ticketCounts = 0;
            if (ds2 == DialogResult.Yes)
            {
                //得到要添加信息的电影名称
                string filmName = this.trv1_movieList.SelectedNode.Parent.Text;
                string releaseDates = cboReleaseDate.Text;
                SitulationOfTickets insertTicketMsg = new SitulationOfTickets();
                //操作转换日期的形式
                insertTicketMsg.ReleaseDates = releaseDates;
                insertTicketMsg.videoHallId = videoHallid;
                insertTicketMsg.FilmName = filmName;
                insertTicketMsg.Playtime = this.trv1_movieList.SelectedNode.Text.Trim();
                insertTicketMsg.SeatsState = -1;//插入信息设置票的状态为已购买（-1）
                //插入票
                List<LinkLabel> seats = ht[videoHallid] as List<LinkLabel>;
                for (int i = 0; i < seats.Count; i++)
                {
                    if (seats[i].LinkVisited == true && seats[i].Enabled == true)
                    {
                        seats[i].Enabled = false;
                        insertTicketMsg.SeatsNumber = seats[i].Text;
                        fmb.InsertSellTicetsMsg(insertTicketMsg);
                        fmb.DeleteSeatMsg(insertTicketMsg);
                        ticketCounts++;
                    }
                }
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
        private int GetChoseSeats()
        {
            int choseSeats = 0;
            //遍历座位表，查看用户是否已选择座位
            List<LinkLabel> ls = ht[videoHallid] as List<LinkLabel>;
            foreach (LinkLabel item in ls)
            {
                if (item.LinkVisited == true && item.Enabled == true)
                {
                    choseSeats++;
                }
            }
            return choseSeats;
        }
        #endregion

        #region 重置控件属性
        /// <summary>
        /// 重置控件属性
        /// </summary>
        private void ResetControls()
        {
            foreach (LinkLabel item in (List<LinkLabel>)ht[videoHallid])
            {
                item.Enabled = true;
                item.LinkVisited = false;
            }
        }
        #endregion

        #region 获取数据库里中电影票出售情况，实现多机互联
        /// <summary>
        /// 获取数据库里中电影票出售情况，实现多机互联。
        /// </summary>
        /// <param name="ticketsMsg"></param>
        public void GetSellTicketSeatsMsg(SitulationOfTickets ticketsMsg)
        {
            //在每一次获取已售出票的信息时，重置控件状态
            ResetControls();
            List<string> seatsMsg = fmb.GetSitulationOfTickets(ticketsMsg);
            if (seatsMsg != null)
            {
                foreach (string seatMsg in seatsMsg)
                {
                    foreach (LinkLabel item in (List<LinkLabel>)ht[ticketsMsg.videoHallId])
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
        #endregion

        #region 点击选中节点，获取影片信息
        /// <summary>
        /// 点击选中节点，获取影片信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trv1_movieList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DeleteExtraTicketState();//在节点改变的情况下，自动删除多余的座位信息
            this.trv1_movieList.SelectedNode.BackColor = Color.DarkTurquoise;
            string nodeName = trv1_movieList.SelectedNode.Text.Trim();
            //判断是不是使用邀请码跳转的影片信息
            if (txt_giver.Enabled == true)
            {
                int id = Convert.ToInt32(trv1_movieList.SelectedNode.Tag);
                if (!imc.FilmId.ToString().Equals(this.trv1_movieList.SelectedNode.Tag.ToString()))
                {
                    MessageBox.Show("对不起，该邀请码只能用于观看指定的电影,请返回重新选择！", "错误的操作");
                    this.trv1_movieList.Nodes[id - 1].Checked = true;
                    return;
                }
            }
            if (e.Node.Parent == null)//父节点trv1_movieList.SelectedNode.Text.Trim()
            {
                fmc = fmb.GetFilmMsg(nodeName);
                lbl_filmName.Text = fmc.FilmName;
                lbl_director.Text = fmc.Director;
                lbl_protagonist.Text = fmc.Protagonists;
                lbl_filmType.Text = fmc.FilmType;
                lbl_filmTime.Text = fmc.FilmTimes;
                pic_filmImg.Image = imgLIst_FilmPic.Images[fmc.FilmId - 1];
                // ResetControls();
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
                    //if (Convert.ToString(drv["PlayTime"]) == e.Node.Text)
                    string playTime = Convert.ToString(drv["FilmBeginTime"]).Trim() + "-" + drv["FilmEndTime"].ToString().Trim();
                    if (playTime == e.Node.Text)
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
                //从文本文件中获取此时段该影片的售票信息
                // GetSellTicketSeats(filmName);
                //从数据库中获取此时段该影片的售票信息并将获取结果显示在放映厅的座位状态上
                SitulationOfTickets tiketsMsg = new SitulationOfTickets();
                tiketsMsg.ReleaseDates = cboReleaseDate.Text;
                tiketsMsg.videoHallId = videoHallid;
                tiketsMsg.Playtime = this.trv1_movieList.SelectedNode.Text.Trim();
                tiketsMsg.FilmName = filmName;
                tiketsMsg.SeatsState = -1;// 
                //获取已售出的座位信息
                GetSellTicketSeatsMsg(tiketsMsg);
            }
        }
        #endregion

        #region 初始化放映列表
        /// <summary>
        /// 初始化放映列表
        /// </summary>
        public void InitFilmNamelist()
        {
            DataView dv = new DataView(fmb.GetFilmReleaseDate(cboReleaseDate.Text));
            if (dv.Count != 0)//判断是否有数据，有数据则进行添加操作
            {
                //添加父节点
                TreeNode pnode = new TreeNode();
                pnode.Text = dv[0]["filmName"].ToString();
                pnode.Tag = dv[0]["filmId"].ToString();
                pnode.Name = dv[0]["filmName"].ToString();
                this.trv1_movieList.Nodes.Add(pnode);
                for (int i = 0; i < dv.Count - 1; i++)
                {
                    Boolean isDifferent = false;
                    foreach (TreeNode node in this.trv1_movieList.Nodes)
                    {
                        if (node.Tag.ToString().Equals(dv[i + 1]["filmId"].ToString()))
                        {
                            isDifferent = false;
                            break;
                        }
                        isDifferent = true;
                    }
                    if (isDifferent)
                    {
                        pnode = new TreeNode();
                        pnode.Text = dv[i + 1]["filmName"].ToString();
                        pnode.Tag = dv[i + 1]["filmId"].ToString();
                        pnode.Name = dv[i + 1]["filmName"].ToString();
                        this.trv1_movieList.Nodes.Add(pnode);
                    }
                }
                //添加子节点
                TreeNode tn;
                for (int i = 0; i < dv.Count; i++)
                {
                    foreach (TreeNode node in this.trv1_movieList.Nodes)
                    {
                        if (dv[i]["filmId"].ToString().Equals(node.Tag.ToString()))
                        {
                            tn = new TreeNode();
                            tn.Text = dv[i]["FilmBeginTime"].ToString() + "-" + dv[i]["FilmEndTime"].ToString();
                            tn.Tag = dv[i]["filmId"].ToString();
                            tn.Name = dv[i]["filmName"].ToString();
                            node.Nodes.Add(tn);
                        }
                    }
                }
            }
        }
        #endregion

        #region 座位点击事件
        /// <summary>
        /// 座位点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLb5_8_Click(object sender, EventArgs e)
        {
            try
            {
                SitulationOfTickets tiketsMsg = new SitulationOfTickets();
                tiketsMsg.ReleaseDates = cboReleaseDate.Text;
                tiketsMsg.videoHallId = videoHallid;
                tiketsMsg.Playtime = this.trv1_movieList.SelectedNode.Text.Trim();
                tiketsMsg.FilmName = this.trv1_movieList.SelectedNode.Parent.Text.Trim();
                List<LinkLabel> llinkLables = ht[videoHallid] as List<LinkLabel>;
                LinkLabel l = sender as LinkLabel;
                tiketsMsg.SeatsNumber = l.Text;
                int i = fmb.GetTicketState(tiketsMsg);
                if (!l.LinkVisited && fmb.GetTicketState(tiketsMsg) > 0)
                {
                    MessageBox.Show("对不起，该座位被锁定，请稍后子再试");
                    return;
                }
                foreach (LinkLabel item in llinkLables)
                {
                    if (l.Text == item.Text)
                    {
                        //判断是否已经有人选择这个座位，防止重复购买的情况出现，待增。
                        //遍历数据库查询状态为0的座位信息
                        item.LinkVisited = !item.LinkVisited;
                        tiketsMsg.SeatsNumber = item.Text;
                        //选中，向数据库中插入此电影票的状态为0，既选定状态
                        if (item.LinkVisited)
                        {
                            tiketsMsg.SeatsState = 0;//该状态为锁定状态
                            fmb.InsertSellTicetsMsg(tiketsMsg);
                        }
                        else//取消选中,删除此电影票在数据库的信息
                        {
                            fmb.DeleteSeatMsg(tiketsMsg);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("请先选择影片和时段");
                return;
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
                this.trv1_movieList.SelectedNode.BackColor = Color.BlueViolet;
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
        }
        #endregion

        #region 点击赠票radiobutton时才可以填写邀请码
        /// <summary>
        /// 点击赠票radiobutton时才可以填写邀请码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoButton_CheckedChanged(object sender, EventArgs e)
        {
            btn_confirm.Enabled = true;
            txt_giver.Enabled = false;
            btnGiver.Visible = false;
            cbo_stuDiscount.Enabled = false;
            if (rdo_freeTicket.Checked)
            {
                txt_giver.Text = "";
                txt_giver.Enabled = true;
                btnGiver.Visible = true;
                btn_confirm.Enabled = false;
                lbl_bestPrice.Text = "无";
            }
            if (rdo_comTicket.Checked)
            {
                btn_confirm.Enabled = true;
                lbl_bestPrice.Text = "￥0.00";
            }
            if (rdo_stuTicket.Checked)
            {
                btn_confirm.Enabled = true;
                cbo_stuDiscount.Enabled = true;
                cbo_stuDiscount.SelectedIndex = 0;
            }

        }
        #endregion

        #region 初始化放映日期列表
        /// <summary>
        /// 初始化放映日期列表
        /// </summary>
        public void InitReleaseDates()
        {
            DataTable dt = fmb.GetFilmPlayList();
            DataView dv1 = new DataView(dt);
            List<string> releaseDates = new List<string>();
            if (dv1.Count != 0)
            {
                releaseDates.Add(dv1[0]["ReleaseDates"].ToString());
                for (int i = 0; i < dv1.Count - 1; i++)
                {
                    Boolean isNewDate = true;
                    for (int j = 0; j < releaseDates.Count; j++)
                    {
                        if (dv1[i]["ReleaseDates"].ToString().Contains(releaseDates[j]))
                        {
                            isNewDate = false;
                            break;
                        }
                    }
                    if (isNewDate == true)
                    {
                        releaseDates.Add(dv1[i]["ReleaseDates"].ToString());
                    }
                }
            }
            else
            {
                releaseDates.Add(DateTime.Now.ToShortDateString());
            }
            //将获取到的日期传到日期列表中
            foreach (string releaseDate in releaseDates)
            {
                cboReleaseDate.Items.Add(Convert.ToDateTime(releaseDate.Substring(0, releaseDate.LastIndexOf('/'))).ToLongDateString());
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
            //获取该天放映列表
            InitFilmNamelist();
            //默认展开所有节点和获得第一个树节点值
            this.trv1_movieList.ExpandAll();
            this.trv1_movieList.SelectedNode = this.trv1_movieList.TopNode;//默认显示第一条电影的信息
        }
        #endregion

        #region 在选中treeview控件之前发生，更改选定内容的颜色
        /// <summary>
        /// 在选中控件之前发生，更改选定内容的颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void trv1_movieList_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                if (this.trv1_movieList.SelectedNode != null)
                {
                    this.trv1_movieList.SelectedNode.BackColor = Color.White;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region 离开，鼠标返回原来的箭头
        /// <summary>
        /// 离开，鼠标返回原来的箭头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void linkLb5_8_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        #endregion

        #region 靠近,鼠标变为手的状态
        /// <summary>
        /// 靠近,鼠标变为手的状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLb5_8_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
        }
        #endregion

        #region 当售票界面退出时，显示主功能界面
        /// <summary>
        ///当售票界面退出时，显示主功能界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            m.Show();
        } 
        #endregion

        #region 删除额外的座位状态信息
        /// <summary>
        /// 删除额外的座位状态信息
        /// </summary>
        public void DeleteExtraTicketState()
        {
            fmb.DeleteExtraTicketState();
        } 
        #endregion
    }
}
