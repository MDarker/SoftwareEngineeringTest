namespace Cinema
{
    partial class ManageFilmMsg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_FilmSourceM = new System.Windows.Forms.DataGridView();
            this.FilmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protagonists = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.txt_FilmId = new System.Windows.Forms.TextBox();
            this.txt_FilmName = new System.Windows.Forms.TextBox();
            this.txt_FilmTimes = new System.Windows.Forms.TextBox();
            this.btn_DownLine = new System.Windows.Forms.Button();
            this.txt_Protagonists = new System.Windows.Forms.TextBox();
            this.txt_FilmType = new System.Windows.Forms.TextBox();
            this.txt_Producers = new System.Windows.Forms.TextBox();
            this.txt_Director = new System.Windows.Forms.TextBox();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_ImportExport = new System.Windows.Forms.LinkLabel();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.dtp_Deadline = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_OldFilmId = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_TP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FilmSourceM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_FilmSourceM
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FilmSourceM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_FilmSourceM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FilmSourceM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilmId,
            this.FilmName,
            this.FilmTimes,
            this.Director,
            this.Protagonists,
            this.FilmType,
            this.Producers,
            this.Country,
            this.FilmState,
            this.ScheduleTime,
            this.Deadline});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_FilmSourceM.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_FilmSourceM.Location = new System.Drawing.Point(12, 12);
            this.dgv_FilmSourceM.Name = "dgv_FilmSourceM";
            this.dgv_FilmSourceM.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FilmSourceM.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_FilmSourceM.RowTemplate.Height = 23;
            this.dgv_FilmSourceM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_FilmSourceM.Size = new System.Drawing.Size(520, 150);
            this.dgv_FilmSourceM.TabIndex = 0;
            this.dgv_FilmSourceM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FilmSourceM_CellClick);
            // 
            // FilmId
            // 
            this.FilmId.DataPropertyName = "FilmId";
            this.FilmId.HeaderText = "电影Id";
            this.FilmId.Name = "FilmId";
            this.FilmId.ReadOnly = true;
            // 
            // FilmName
            // 
            this.FilmName.DataPropertyName = "FilmName";
            this.FilmName.HeaderText = "电影名";
            this.FilmName.Name = "FilmName";
            this.FilmName.ReadOnly = true;
            // 
            // FilmTimes
            // 
            this.FilmTimes.DataPropertyName = "FilmTimes";
            this.FilmTimes.HeaderText = "电影时长";
            this.FilmTimes.Name = "FilmTimes";
            this.FilmTimes.ReadOnly = true;
            // 
            // Director
            // 
            this.Director.DataPropertyName = "Director";
            this.Director.HeaderText = "导演";
            this.Director.Name = "Director";
            this.Director.ReadOnly = true;
            // 
            // Protagonists
            // 
            this.Protagonists.DataPropertyName = "Protagonists";
            this.Protagonists.HeaderText = "主演";
            this.Protagonists.Name = "Protagonists";
            this.Protagonists.ReadOnly = true;
            // 
            // FilmType
            // 
            this.FilmType.DataPropertyName = "FilmType";
            this.FilmType.HeaderText = "类型";
            this.FilmType.Name = "FilmType";
            this.FilmType.ReadOnly = true;
            // 
            // Producers
            // 
            this.Producers.DataPropertyName = "Producers";
            this.Producers.HeaderText = "发行";
            this.Producers.Name = "Producers";
            this.Producers.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "国家";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // FilmState
            // 
            this.FilmState.DataPropertyName = "FilmState";
            this.FilmState.HeaderText = "电影状态";
            this.FilmState.Name = "FilmState";
            this.FilmState.ReadOnly = true;
            // 
            // ScheduleTime
            // 
            this.ScheduleTime.DataPropertyName = "ScheduleTime";
            this.ScheduleTime.HeaderText = "排片次数";
            this.ScheduleTime.Name = "ScheduleTime";
            this.ScheduleTime.ReadOnly = true;
            // 
            // Deadline
            // 
            this.Deadline.DataPropertyName = "Deadline";
            this.Deadline.HeaderText = "截止放映日期";
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(28, 176);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "要添加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(230, 176);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 2;
            this.btn_Del.Text = "删除";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // txt_FilmId
            // 
            this.txt_FilmId.Enabled = false;
            this.txt_FilmId.Location = new System.Drawing.Point(22, 227);
            this.txt_FilmId.Name = "txt_FilmId";
            this.txt_FilmId.Size = new System.Drawing.Size(100, 21);
            this.txt_FilmId.TabIndex = 3;
            // 
            // txt_FilmName
            // 
            this.txt_FilmName.Enabled = false;
            this.txt_FilmName.Location = new System.Drawing.Point(152, 229);
            this.txt_FilmName.Name = "txt_FilmName";
            this.txt_FilmName.Size = new System.Drawing.Size(100, 21);
            this.txt_FilmName.TabIndex = 4;
            // 
            // txt_FilmTimes
            // 
            this.txt_FilmTimes.Enabled = false;
            this.txt_FilmTimes.Location = new System.Drawing.Point(288, 227);
            this.txt_FilmTimes.Name = "txt_FilmTimes";
            this.txt_FilmTimes.Size = new System.Drawing.Size(100, 21);
            this.txt_FilmTimes.TabIndex = 5;
            // 
            // btn_DownLine
            // 
            this.btn_DownLine.Location = new System.Drawing.Point(328, 176);
            this.btn_DownLine.Name = "btn_DownLine";
            this.btn_DownLine.Size = new System.Drawing.Size(75, 23);
            this.btn_DownLine.TabIndex = 6;
            this.btn_DownLine.Text = "下映";
            this.btn_DownLine.UseVisualStyleBackColor = true;
            this.btn_DownLine.Click += new System.EventHandler(this.btn_DownLine_Click);
            // 
            // txt_Protagonists
            // 
            this.txt_Protagonists.Enabled = false;
            this.txt_Protagonists.Location = new System.Drawing.Point(25, 281);
            this.txt_Protagonists.Name = "txt_Protagonists";
            this.txt_Protagonists.Size = new System.Drawing.Size(100, 21);
            this.txt_Protagonists.TabIndex = 7;
            // 
            // txt_FilmType
            // 
            this.txt_FilmType.Enabled = false;
            this.txt_FilmType.Location = new System.Drawing.Point(152, 281);
            this.txt_FilmType.Name = "txt_FilmType";
            this.txt_FilmType.Size = new System.Drawing.Size(100, 21);
            this.txt_FilmType.TabIndex = 8;
            // 
            // txt_Producers
            // 
            this.txt_Producers.Enabled = false;
            this.txt_Producers.Location = new System.Drawing.Point(288, 281);
            this.txt_Producers.Name = "txt_Producers";
            this.txt_Producers.Size = new System.Drawing.Size(100, 21);
            this.txt_Producers.TabIndex = 9;
            // 
            // txt_Director
            // 
            this.txt_Director.Enabled = false;
            this.txt_Director.Location = new System.Drawing.Point(418, 229);
            this.txt_Director.Name = "txt_Director";
            this.txt_Director.Size = new System.Drawing.Size(100, 21);
            this.txt_Director.TabIndex = 10;
            // 
            // txt_Country
            // 
            this.txt_Country.Enabled = false;
            this.txt_Country.Location = new System.Drawing.Point(418, 281);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(100, 21);
            this.txt_Country.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "电影Id：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "电影名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "电影时长：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "导演：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "主演：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "类型：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "发行：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "国家：";
            // 
            // lbl_ImportExport
            // 
            this.lbl_ImportExport.AutoSize = true;
            this.lbl_ImportExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ImportExport.Location = new System.Drawing.Point(366, 319);
            this.lbl_ImportExport.Name = "lbl_ImportExport";
            this.lbl_ImportExport.Size = new System.Drawing.Size(77, 12);
            this.lbl_ImportExport.TabIndex = 20;
            this.lbl_ImportExport.TabStop = true;
            this.lbl_ImportExport.Text = "导入导出数据";
            this.lbl_ImportExport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_ImportExport_LinkClicked);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(47, 352);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(99, 21);
            this.btn_Browse.TabIndex = 21;
            this.btn_Browse.Text = "浏览Excel文件";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(152, 352);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(305, 21);
            this.txt_FilePath.TabIndex = 22;
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(107, 395);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(75, 23);
            this.btn_Import.TabIndex = 23;
            this.btn_Import.Text = " 导入";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(219, 395);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(86, 23);
            this.btn_Export.TabIndex = 24;
            this.btn_Export.Text = "导出片源表数据";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(130, 176);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 23);
            this.btn_Modify.TabIndex = 25;
            this.btn_Modify.Text = "要修改";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // dtp_Deadline
            // 
            this.dtp_Deadline.Location = new System.Drawing.Point(181, 313);
            this.dtp_Deadline.Name = "dtp_Deadline";
            this.dtp_Deadline.Size = new System.Drawing.Size(102, 21);
            this.dtp_Deadline.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 30;
            this.label10.Text = "截止放映日期：";
            // 
            // lbl_OldFilmId
            // 
            this.lbl_OldFilmId.AutoSize = true;
            this.lbl_OldFilmId.Location = new System.Drawing.Point(10, 395);
            this.lbl_OldFilmId.Name = "lbl_OldFilmId";
            this.lbl_OldFilmId.Size = new System.Drawing.Size(89, 12);
            this.lbl_OldFilmId.TabIndex = 32;
            this.lbl_OldFilmId.Text = "点击时的电影Id";
            this.lbl_OldFilmId.Visible = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(425, 176);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 33;
            this.btn_Cancel.Text = "取消操作";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_TP
            // 
            this.btn_TP.Location = new System.Drawing.Point(355, 395);
            this.btn_TP.Name = "btn_TP";
            this.btn_TP.Size = new System.Drawing.Size(75, 23);
            this.btn_TP.TabIndex = 34;
            this.btn_TP.Text = "导出表模板";
            this.btn_TP.UseVisualStyleBackColor = true;
            this.btn_TP.Click += new System.EventHandler(this.btn_TP_Click);
            // 
            // ManageFilmMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 425);
            this.Controls.Add(this.btn_TP);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_OldFilmId);
            this.Controls.Add(this.dtp_Deadline);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.txt_FilePath);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.lbl_ImportExport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.txt_Director);
            this.Controls.Add(this.txt_Producers);
            this.Controls.Add(this.txt_FilmType);
            this.Controls.Add(this.txt_Protagonists);
            this.Controls.Add(this.btn_DownLine);
            this.Controls.Add(this.txt_FilmTimes);
            this.Controls.Add(this.txt_FilmName);
            this.Controls.Add(this.txt_FilmId);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_FilmSourceM);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageFilmMsg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "片源管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageFilmMsg_FormClosed);
            this.Load += new System.EventHandler(this.ManageFilmMsg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FilmSourceM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_FilmSourceM;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.TextBox txt_FilmId;
        private System.Windows.Forms.TextBox txt_FilmName;
        private System.Windows.Forms.TextBox txt_FilmTimes;
        private System.Windows.Forms.Button btn_DownLine;
        private System.Windows.Forms.TextBox txt_Protagonists;
        private System.Windows.Forms.TextBox txt_FilmType;
        private System.Windows.Forms.TextBox txt_Producers;
        private System.Windows.Forms.TextBox txt_Director;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel lbl_ImportExport;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.DateTimePicker dtp_Deadline;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protagonists;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.Label lbl_OldFilmId;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_TP;
    }
}