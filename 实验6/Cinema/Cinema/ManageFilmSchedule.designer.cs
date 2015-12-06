namespace Cinema
{
    partial class ManageFilmSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grp_schedule = new System.Windows.Forms.GroupBox();
            this.btn_NoSchedule = new System.Windows.Forms.Button();
            this.btn_Scheduled = new System.Windows.Forms.Button();
            this.dgv_filmSchedule = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_videoHallNO = new System.Windows.Forms.ComboBox();
            this.txt_filmName = new System.Windows.Forms.TextBox();
            this.txt_filmEndTime = new System.Windows.Forms.TextBox();
            this.cbo_filmBeginTime = new System.Windows.Forms.ComboBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.rdo_onshelve = new System.Windows.Forms.RadioButton();
            this.rdo_unshelve = new System.Windows.Forms.RadioButton();
            this.lbl_filmId = new System.Windows.Forms.Label();
            this.grp_schedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_filmSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_schedule
            // 
            this.grp_schedule.Controls.Add(this.btn_NoSchedule);
            this.grp_schedule.Controls.Add(this.btn_Scheduled);
            this.grp_schedule.Controls.Add(this.dgv_filmSchedule);
            this.grp_schedule.Location = new System.Drawing.Point(12, 12);
            this.grp_schedule.Name = "grp_schedule";
            this.grp_schedule.Size = new System.Drawing.Size(506, 233);
            this.grp_schedule.TabIndex = 2;
            this.grp_schedule.TabStop = false;
            this.grp_schedule.Text = "排片：";
            // 
            // btn_NoSchedule
            // 
            this.btn_NoSchedule.Location = new System.Drawing.Point(119, 198);
            this.btn_NoSchedule.Name = "btn_NoSchedule";
            this.btn_NoSchedule.Size = new System.Drawing.Size(75, 23);
            this.btn_NoSchedule.TabIndex = 3;
            this.btn_NoSchedule.Text = "还没排的";
            this.btn_NoSchedule.UseVisualStyleBackColor = true;
            this.btn_NoSchedule.Click += new System.EventHandler(this.btn_NoSchedule_Click);
            // 
            // btn_Scheduled
            // 
            this.btn_Scheduled.Location = new System.Drawing.Point(294, 198);
            this.btn_Scheduled.Name = "btn_Scheduled";
            this.btn_Scheduled.Size = new System.Drawing.Size(75, 23);
            this.btn_Scheduled.TabIndex = 2;
            this.btn_Scheduled.Text = "已经排的";
            this.btn_Scheduled.UseVisualStyleBackColor = true;
            this.btn_Scheduled.Click += new System.EventHandler(this.btn_Scheduled_Click);
            // 
            // dgv_filmSchedule
            // 
            this.dgv_filmSchedule.AllowUserToAddRows = false;
            this.dgv_filmSchedule.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_filmSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_filmSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_filmSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_filmSchedule.Location = new System.Drawing.Point(17, 20);
            this.dgv_filmSchedule.Name = "dgv_filmSchedule";
            this.dgv_filmSchedule.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_filmSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_filmSchedule.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_filmSchedule.RowTemplate.Height = 23;
            this.dgv_filmSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_filmSchedule.Size = new System.Drawing.Size(472, 169);
            this.dgv_filmSchedule.TabIndex = 0;
            this.dgv_filmSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_filmSchedule_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "放映厅号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "影片开始时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "影片截至时间：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "影片名：";
            // 
            // cbo_videoHallNO
            // 
            this.cbo_videoHallNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_videoHallNO.FormattingEnabled = true;
            this.cbo_videoHallNO.Location = new System.Drawing.Point(392, 261);
            this.cbo_videoHallNO.Name = "cbo_videoHallNO";
            this.cbo_videoHallNO.Size = new System.Drawing.Size(100, 20);
            this.cbo_videoHallNO.TabIndex = 1;
            // 
            // txt_filmName
            // 
            this.txt_filmName.Location = new System.Drawing.Point(131, 261);
            this.txt_filmName.Name = "txt_filmName";
            this.txt_filmName.ReadOnly = true;
            this.txt_filmName.Size = new System.Drawing.Size(101, 21);
            this.txt_filmName.TabIndex = 9;
            // 
            // txt_filmEndTime
            // 
            this.txt_filmEndTime.Location = new System.Drawing.Point(392, 309);
            this.txt_filmEndTime.Name = "txt_filmEndTime";
            this.txt_filmEndTime.ReadOnly = true;
            this.txt_filmEndTime.Size = new System.Drawing.Size(100, 21);
            this.txt_filmEndTime.TabIndex = 10;
            // 
            // cbo_filmBeginTime
            // 
            this.cbo_filmBeginTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_filmBeginTime.FormattingEnabled = true;
            this.cbo_filmBeginTime.Location = new System.Drawing.Point(130, 304);
            this.cbo_filmBeginTime.Name = "cbo_filmBeginTime";
            this.cbo_filmBeginTime.Size = new System.Drawing.Size(100, 20);
            this.cbo_filmBeginTime.TabIndex = 2;
            this.cbo_filmBeginTime.SelectionChangeCommitted += new System.EventHandler(this.cbo_filmBeginTime_SelectionChangeCommitted);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(306, 356);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "确定";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(417, 356);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // rdo_onshelve
            // 
            this.rdo_onshelve.AutoSize = true;
            this.rdo_onshelve.Checked = true;
            this.rdo_onshelve.Location = new System.Drawing.Point(86, 356);
            this.rdo_onshelve.Name = "rdo_onshelve";
            this.rdo_onshelve.Size = new System.Drawing.Size(47, 16);
            this.rdo_onshelve.TabIndex = 15;
            this.rdo_onshelve.TabStop = true;
            this.rdo_onshelve.Text = "上架";
            this.rdo_onshelve.UseVisualStyleBackColor = true;
            // 
            // rdo_unshelve
            // 
            this.rdo_unshelve.AutoSize = true;
            this.rdo_unshelve.Location = new System.Drawing.Point(159, 356);
            this.rdo_unshelve.Name = "rdo_unshelve";
            this.rdo_unshelve.Size = new System.Drawing.Size(47, 16);
            this.rdo_unshelve.TabIndex = 16;
            this.rdo_unshelve.Text = "下架";
            this.rdo_unshelve.UseVisualStyleBackColor = true;
            // 
            // lbl_filmId
            // 
            this.lbl_filmId.AutoSize = true;
            this.lbl_filmId.Location = new System.Drawing.Point(223, 342);
            this.lbl_filmId.Name = "lbl_filmId";
            this.lbl_filmId.Size = new System.Drawing.Size(83, 12);
            this.lbl_filmId.TabIndex = 17;
            this.lbl_filmId.Text = "影片Id-不可见";
            // 
            // ManageFilmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 389);
            this.Controls.Add(this.lbl_filmId);
            this.Controls.Add(this.rdo_unshelve);
            this.Controls.Add(this.rdo_onshelve);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.cbo_filmBeginTime);
            this.Controls.Add(this.txt_filmEndTime);
            this.Controls.Add(this.txt_filmName);
            this.Controls.Add(this.cbo_videoHallNO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_schedule);
            this.Name = "ManageFilmSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "排片";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageFilmSchedule_FormClosed);
            this.Load += new System.EventHandler(this.ManageFilmSchedule_Load);
            this.grp_schedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_filmSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_schedule;
        private System.Windows.Forms.DataGridView dgv_filmSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_videoHallNO;
        private System.Windows.Forms.TextBox txt_filmName;
        private System.Windows.Forms.TextBox txt_filmEndTime;
        private System.Windows.Forms.ComboBox cbo_filmBeginTime;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_NoSchedule;
        private System.Windows.Forms.Button btn_Scheduled;
        private System.Windows.Forms.RadioButton rdo_onshelve;
        private System.Windows.Forms.RadioButton rdo_unshelve;
        private System.Windows.Forms.Label lbl_filmId;
    }
}