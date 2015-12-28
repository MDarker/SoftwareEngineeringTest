namespace Cinema
{
    partial class SellTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellTicket));
            this.tabcon_showList = new System.Windows.Forms.TabControl();
            this.tabpage_films = new System.Windows.Forms.TabPage();
            this.cboReleaseDate = new System.Windows.Forms.ComboBox();
            this.trv1_movieList = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_bestPrice = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_filmTime = new System.Windows.Forms.Label();
            this.lbl_filmType = new System.Windows.Forms.Label();
            this.lbl_protagonist = new System.Windows.Forms.Label();
            this.pic_filmImg = new System.Windows.Forms.PictureBox();
            this.lbl_director = new System.Windows.Forms.Label();
            this.lbl_filmName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_giver = new System.Windows.Forms.TextBox();
            this.cbo_stuDiscount = new System.Windows.Forms.ComboBox();
            this.labelGiver = new System.Windows.Forms.Label();
            this.rdo_stuTicket = new System.Windows.Forms.RadioButton();
            this.rdo_freeTicket = new System.Windows.Forms.RadioButton();
            this.rdo_comTicket = new System.Windows.Forms.RadioButton();
            this.labelStu = new System.Windows.Forms.Label();
            this.tabcon_videoHall = new System.Windows.Forms.TabControl();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btnGiver = new System.Windows.Forms.Button();
            this.imgLIst_FilmPic = new System.Windows.Forms.ImageList(this.components);
            this.tabcon_showList.SuspendLayout();
            this.tabpage_films.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_filmImg)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcon_showList
            // 
            this.tabcon_showList.Controls.Add(this.tabpage_films);
            this.tabcon_showList.Location = new System.Drawing.Point(12, 11);
            this.tabcon_showList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabcon_showList.Name = "tabcon_showList";
            this.tabcon_showList.SelectedIndex = 0;
            this.tabcon_showList.Size = new System.Drawing.Size(161, 458);
            this.tabcon_showList.TabIndex = 2;
            // 
            // tabpage_films
            // 
            this.tabpage_films.Controls.Add(this.cboReleaseDate);
            this.tabpage_films.Controls.Add(this.trv1_movieList);
            this.tabpage_films.Location = new System.Drawing.Point(4, 22);
            this.tabpage_films.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabpage_films.Name = "tabpage_films";
            this.tabpage_films.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabpage_films.Size = new System.Drawing.Size(153, 432);
            this.tabpage_films.TabIndex = 0;
            this.tabpage_films.Text = "放映列表";
            this.tabpage_films.UseVisualStyleBackColor = true;
            // 
            // cboReleaseDate
            // 
            this.cboReleaseDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReleaseDate.FormattingEnabled = true;
            this.cboReleaseDate.Location = new System.Drawing.Point(-2, 2);
            this.cboReleaseDate.Name = "cboReleaseDate";
            this.cboReleaseDate.Size = new System.Drawing.Size(154, 20);
            this.cboReleaseDate.TabIndex = 1;
            this.cboReleaseDate.TextChanged += new System.EventHandler(this.cboReleaseDate_TextChanged);
            // 
            // trv1_movieList
            // 
            this.trv1_movieList.Location = new System.Drawing.Point(3, 24);
            this.trv1_movieList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trv1_movieList.Name = "trv1_movieList";
            this.trv1_movieList.Size = new System.Drawing.Size(147, 406);
            this.trv1_movieList.TabIndex = 0;
            this.trv1_movieList.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trv1_movieList_BeforeSelect);
            this.trv1_movieList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv1_movieList_AfterSelect);
            this.trv1_movieList.MouseEnter += new System.EventHandler(this.linkLb5_8_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_bestPrice);
            this.groupBox1.Controls.Add(this.lbl_price);
            this.groupBox1.Controls.Add(this.lbl_filmTime);
            this.groupBox1.Controls.Add(this.lbl_filmType);
            this.groupBox1.Controls.Add(this.lbl_protagonist);
            this.groupBox1.Controls.Add(this.pic_filmImg);
            this.groupBox1.Controls.Add(this.lbl_director);
            this.groupBox1.Controls.Add(this.lbl_filmName);
            this.groupBox1.Location = new System.Drawing.Point(179, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(367, 198);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详情";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(168, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "优惠价:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(177, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "票价:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "片长：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "类型: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "主演: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "导演: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "片名: ";
            // 
            // lbl_bestPrice
            // 
            this.lbl_bestPrice.AutoSize = true;
            this.lbl_bestPrice.Location = new System.Drawing.Point(221, 161);
            this.lbl_bestPrice.Name = "lbl_bestPrice";
            this.lbl_bestPrice.Size = new System.Drawing.Size(11, 12);
            this.lbl_bestPrice.TabIndex = 7;
            this.lbl_bestPrice.Text = " ";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(221, 135);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(11, 12);
            this.lbl_price.TabIndex = 6;
            this.lbl_price.Text = " ";
            // 
            // lbl_filmTime
            // 
            this.lbl_filmTime.AutoSize = true;
            this.lbl_filmTime.Location = new System.Drawing.Point(222, 110);
            this.lbl_filmTime.Name = "lbl_filmTime";
            this.lbl_filmTime.Size = new System.Drawing.Size(11, 12);
            this.lbl_filmTime.TabIndex = 5;
            this.lbl_filmTime.Text = " ";
            // 
            // lbl_filmType
            // 
            this.lbl_filmType.AutoSize = true;
            this.lbl_filmType.Location = new System.Drawing.Point(222, 81);
            this.lbl_filmType.Name = "lbl_filmType";
            this.lbl_filmType.Size = new System.Drawing.Size(11, 12);
            this.lbl_filmType.TabIndex = 4;
            this.lbl_filmType.Text = " ";
            // 
            // lbl_protagonist
            // 
            this.lbl_protagonist.AutoSize = true;
            this.lbl_protagonist.Location = new System.Drawing.Point(222, 51);
            this.lbl_protagonist.Name = "lbl_protagonist";
            this.lbl_protagonist.Size = new System.Drawing.Size(11, 12);
            this.lbl_protagonist.TabIndex = 3;
            this.lbl_protagonist.Text = " ";
            // 
            // pic_filmImg
            // 
            this.pic_filmImg.Location = new System.Drawing.Point(27, 47);
            this.pic_filmImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_filmImg.Name = "pic_filmImg";
            this.pic_filmImg.Size = new System.Drawing.Size(100, 131);
            this.pic_filmImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_filmImg.TabIndex = 2;
            this.pic_filmImg.TabStop = false;
            // 
            // lbl_director
            // 
            this.lbl_director.AutoSize = true;
            this.lbl_director.Location = new System.Drawing.Point(222, 23);
            this.lbl_director.Name = "lbl_director";
            this.lbl_director.Size = new System.Drawing.Size(11, 12);
            this.lbl_director.TabIndex = 1;
            this.lbl_director.Text = " ";
            // 
            // lbl_filmName
            // 
            this.lbl_filmName.AutoSize = true;
            this.lbl_filmName.Location = new System.Drawing.Point(69, 23);
            this.lbl_filmName.Name = "lbl_filmName";
            this.lbl_filmName.Size = new System.Drawing.Size(11, 12);
            this.lbl_filmName.TabIndex = 0;
            this.lbl_filmName.Text = " ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt_giver);
            this.groupBox2.Controls.Add(this.cbo_stuDiscount);
            this.groupBox2.Controls.Add(this.labelGiver);
            this.groupBox2.Controls.Add(this.rdo_stuTicket);
            this.groupBox2.Controls.Add(this.rdo_freeTicket);
            this.groupBox2.Controls.Add(this.rdo_comTicket);
            this.groupBox2.Controls.Add(this.labelStu);
            this.groupBox2.Location = new System.Drawing.Point(556, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(211, 198);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "电影票:";
            // 
            // txt_giver
            // 
            this.txt_giver.Enabled = false;
            this.txt_giver.Location = new System.Drawing.Point(106, 101);
            this.txt_giver.Name = "txt_giver";
            this.txt_giver.Size = new System.Drawing.Size(87, 21);
            this.txt_giver.TabIndex = 8;
            // 
            // cbo_stuDiscount
            // 
            this.cbo_stuDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_stuDiscount.FormattingEnabled = true;
            this.cbo_stuDiscount.Items.AddRange(new object[] {
            "5",
            "8"});
            this.cbo_stuDiscount.Location = new System.Drawing.Point(108, 154);
            this.cbo_stuDiscount.Name = "cbo_stuDiscount";
            this.cbo_stuDiscount.Size = new System.Drawing.Size(87, 20);
            this.cbo_stuDiscount.TabIndex = 7;
            // 
            // labelGiver
            // 
            this.labelGiver.AutoSize = true;
            this.labelGiver.Location = new System.Drawing.Point(49, 106);
            this.labelGiver.Name = "labelGiver";
            this.labelGiver.Size = new System.Drawing.Size(47, 12);
            this.labelGiver.TabIndex = 3;
            this.labelGiver.Text = "邀请码:";
            // 
            // rdo_stuTicket
            // 
            this.rdo_stuTicket.AutoSize = true;
            this.rdo_stuTicket.Location = new System.Drawing.Point(37, 131);
            this.rdo_stuTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_stuTicket.Name = "rdo_stuTicket";
            this.rdo_stuTicket.Size = new System.Drawing.Size(59, 16);
            this.rdo_stuTicket.TabIndex = 3;
            this.rdo_stuTicket.TabStop = true;
            this.rdo_stuTicket.Text = "学生票";
            this.rdo_stuTicket.UseVisualStyleBackColor = true;
            // 
            // rdo_freeTicket
            // 
            this.rdo_freeTicket.AutoSize = true;
            this.rdo_freeTicket.Location = new System.Drawing.Point(37, 65);
            this.rdo_freeTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_freeTicket.Name = "rdo_freeTicket";
            this.rdo_freeTicket.Size = new System.Drawing.Size(47, 16);
            this.rdo_freeTicket.TabIndex = 2;
            this.rdo_freeTicket.TabStop = true;
            this.rdo_freeTicket.Text = "赠票";
            this.rdo_freeTicket.UseVisualStyleBackColor = true;
            this.rdo_freeTicket.CheckedChanged += new System.EventHandler(this.rdoButton_CheckedChanged);
            // 
            // rdo_comTicket
            // 
            this.rdo_comTicket.AutoSize = true;
            this.rdo_comTicket.Checked = true;
            this.rdo_comTicket.Location = new System.Drawing.Point(37, 22);
            this.rdo_comTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_comTicket.Name = "rdo_comTicket";
            this.rdo_comTicket.Size = new System.Drawing.Size(59, 16);
            this.rdo_comTicket.TabIndex = 1;
            this.rdo_comTicket.TabStop = true;
            this.rdo_comTicket.Text = "普通票";
            this.rdo_comTicket.UseVisualStyleBackColor = true;
            this.rdo_comTicket.CheckedChanged += new System.EventHandler(this.rdoButton_CheckedChanged);
            // 
            // labelStu
            // 
            this.labelStu.AutoSize = true;
            this.labelStu.Location = new System.Drawing.Point(43, 159);
            this.labelStu.Name = "labelStu";
            this.labelStu.Size = new System.Drawing.Size(59, 12);
            this.labelStu.TabIndex = 3;
            this.labelStu.Text = "学生折扣:";
            // 
            // tabcon_videoHall
            // 
            this.tabcon_videoHall.Location = new System.Drawing.Point(179, 239);
            this.tabcon_videoHall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabcon_videoHall.Name = "tabcon_videoHall";
            this.tabcon_videoHall.SelectedIndex = 0;
            this.tabcon_videoHall.Size = new System.Drawing.Size(588, 211);
            this.tabcon_videoHall.TabIndex = 8;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirm.Location = new System.Drawing.Point(521, 455);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 9;
            this.btn_confirm.Text = "确定";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btnGiver
            // 
            this.btnGiver.BackColor = System.Drawing.Color.Transparent;
            this.btnGiver.Location = new System.Drawing.Point(645, 455);
            this.btnGiver.Name = "btnGiver";
            this.btnGiver.Size = new System.Drawing.Size(75, 23);
            this.btnGiver.TabIndex = 10;
            this.btnGiver.Text = "使用邀请码";
            this.btnGiver.UseVisualStyleBackColor = false;
            this.btnGiver.Visible = false;
            this.btnGiver.Click += new System.EventHandler(this.btnGiver_Click);
            // 
            // imgLIst_FilmPic
            // 
            this.imgLIst_FilmPic.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLIst_FilmPic.ImageStream")));
            this.imgLIst_FilmPic.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLIst_FilmPic.Images.SetKeyName(0, "钢铁侠.jpg");
            this.imgLIst_FilmPic.Images.SetKeyName(1, "蜘蛛侠3.jpg");
            this.imgLIst_FilmPic.Images.SetKeyName(2, "功夫熊猫.jpg");
            this.imgLIst_FilmPic.Images.SetKeyName(3, "火星救援.jpg");
            this.imgLIst_FilmPic.Images.SetKeyName(4, "怦然星动.jpg");
            this.imgLIst_FilmPic.Images.SetKeyName(5, "万万没想到.jpg");
            // 
            // SellTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 490);
            this.Controls.Add(this.btnGiver);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.tabcon_videoHall);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabcon_showList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SellTicket";
            this.Text = "影院售票系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SellTicket_FormClosed);
            this.Load += new System.EventHandler(this.SellTicket_Load);
            this.tabcon_showList.ResumeLayout(false);
            this.tabpage_films.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_filmImg)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcon_showList;
        private System.Windows.Forms.TabPage tabpage_films;
        private System.Windows.Forms.ComboBox cboReleaseDate;
        private System.Windows.Forms.TreeView trv1_movieList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_bestPrice;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_filmTime;
        private System.Windows.Forms.Label lbl_filmType;
        private System.Windows.Forms.Label lbl_protagonist;
        private System.Windows.Forms.PictureBox pic_filmImg;
        private System.Windows.Forms.Label lbl_director;
        private System.Windows.Forms.Label lbl_filmName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelGiver;
        private System.Windows.Forms.Label labelStu;
        private System.Windows.Forms.ComboBox cbo_stuDiscount;
        private System.Windows.Forms.RadioButton rdo_stuTicket;
        private System.Windows.Forms.RadioButton rdo_freeTicket;
        private System.Windows.Forms.RadioButton rdo_comTicket;
        private System.Windows.Forms.TabControl tabcon_videoHall;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btnGiver;
        private System.Windows.Forms.TextBox txt_giver;
        private System.Windows.Forms.ImageList imgLIst_FilmPic;
    }
}