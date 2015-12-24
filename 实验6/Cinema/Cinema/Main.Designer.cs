namespace Cinema
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pic_Managment = new System.Windows.Forms.PictureBox();
            this.pic_SellTicket = new System.Windows.Forms.PictureBox();
            this.btn_VideoHall = new System.Windows.Forms.Button();
            this.btn_FilmMsg = new System.Windows.Forms.Button();
            this.btn_FilmShedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Managment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SellTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Managment
            // 
            this.pic_Managment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Managment.Image = ((System.Drawing.Image)(resources.GetObject("pic_Managment.Image")));
            this.pic_Managment.Location = new System.Drawing.Point(156, 12);
            this.pic_Managment.Name = "pic_Managment";
            this.pic_Managment.Size = new System.Drawing.Size(73, 68);
            this.pic_Managment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Managment.TabIndex = 1;
            this.pic_Managment.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_Managment, "点击进入管理系统");
            this.pic_Managment.Click += new System.EventHandler(this.pic_Managment_Click);
            // 
            // pic_SellTicket
            // 
            this.pic_SellTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_SellTicket.Image = ((System.Drawing.Image)(resources.GetObject("pic_SellTicket.Image")));
            this.pic_SellTicket.Location = new System.Drawing.Point(40, 12);
            this.pic_SellTicket.Name = "pic_SellTicket";
            this.pic_SellTicket.Size = new System.Drawing.Size(73, 72);
            this.pic_SellTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_SellTicket.TabIndex = 2;
            this.pic_SellTicket.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_SellTicket, "点击进入购票系统");
            this.pic_SellTicket.Click += new System.EventHandler(this.pic_SellTicket_Click);
            // 
            // btn_VideoHall
            // 
            this.btn_VideoHall.Enabled = false;
            this.btn_VideoHall.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_VideoHall.Location = new System.Drawing.Point(12, 98);
            this.btn_VideoHall.Name = "btn_VideoHall";
            this.btn_VideoHall.Size = new System.Drawing.Size(114, 50);
            this.btn_VideoHall.TabIndex = 3;
            this.btn_VideoHall.Text = "放映厅";
            this.btn_VideoHall.UseVisualStyleBackColor = true;
            this.btn_VideoHall.Click += new System.EventHandler(this.btn_VideoHall_Click);
            // 
            // btn_FilmMsg
            // 
            this.btn_FilmMsg.Enabled = false;
            this.btn_FilmMsg.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_FilmMsg.Location = new System.Drawing.Point(144, 98);
            this.btn_FilmMsg.Name = "btn_FilmMsg";
            this.btn_FilmMsg.Size = new System.Drawing.Size(114, 50);
            this.btn_FilmMsg.TabIndex = 4;
            this.btn_FilmMsg.Text = "片源";
            this.btn_FilmMsg.UseVisualStyleBackColor = true;
            this.btn_FilmMsg.Click += new System.EventHandler(this.btn_FilmMsg_Click);
            // 
            // btn_FilmShedule
            // 
            this.btn_FilmShedule.Enabled = false;
            this.btn_FilmShedule.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_FilmShedule.Location = new System.Drawing.Point(82, 155);
            this.btn_FilmShedule.Name = "btn_FilmShedule";
            this.btn_FilmShedule.Size = new System.Drawing.Size(114, 50);
            this.btn_FilmShedule.TabIndex = 5;
            this.btn_FilmShedule.Text = "排片";
            this.btn_FilmShedule.UseVisualStyleBackColor = true;
            this.btn_FilmShedule.Click += new System.EventHandler(this.btn_FilmShedule_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 211);
            this.Controls.Add(this.btn_FilmShedule);
            this.Controls.Add(this.btn_FilmMsg);
            this.Controls.Add(this.btn_VideoHall);
            this.Controls.Add(this.pic_SellTicket);
            this.Controls.Add(this.pic_Managment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "总控";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Managment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SellTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pic_Managment;
        private System.Windows.Forms.PictureBox pic_SellTicket;
        private System.Windows.Forms.Button btn_VideoHall;
        private System.Windows.Forms.Button btn_FilmMsg;
        private System.Windows.Forms.Button btn_FilmShedule;
    }
}