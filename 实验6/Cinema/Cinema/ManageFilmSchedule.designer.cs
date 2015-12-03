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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_filmSchedule = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_videoHallNO = new System.Windows.Forms.ComboBox();
            this.txt_filmName = new System.Windows.Forms.TextBox();
            this.txt_sellBeginTime = new System.Windows.Forms.TextBox();
            this.txt_filmEndTime = new System.Windows.Forms.TextBox();
            this.cbo_filmBeginTime = new System.Windows.Forms.ComboBox();
            this.txt_sellEndTime = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_filmSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_filmSchedule);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "需要排的影片：";
            // 
            // dgv_filmSchedule
            // 
            this.dgv_filmSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_filmSchedule.Location = new System.Drawing.Point(17, 20);
            this.dgv_filmSchedule.Name = "dgv_filmSchedule";
            this.dgv_filmSchedule.RowTemplate.Height = 23;
            this.dgv_filmSchedule.Size = new System.Drawing.Size(472, 159);
            this.dgv_filmSchedule.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "放映厅号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "影片开始时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "影片截至时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "售票开始时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "售票截至时间：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "影片名：";
            // 
            // cbo_videoHallNO
            // 
            this.cbo_videoHallNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_videoHallNO.FormattingEnabled = true;
            this.cbo_videoHallNO.Location = new System.Drawing.Point(384, 228);
            this.cbo_videoHallNO.Name = "cbo_videoHallNO";
            this.cbo_videoHallNO.Size = new System.Drawing.Size(45, 20);
            this.cbo_videoHallNO.TabIndex = 8;
            // 
            // txt_filmName
            // 
            this.txt_filmName.Location = new System.Drawing.Point(122, 228);
            this.txt_filmName.Name = "txt_filmName";
            this.txt_filmName.ReadOnly = true;
            this.txt_filmName.Size = new System.Drawing.Size(101, 21);
            this.txt_filmName.TabIndex = 9;
            // 
            // txt_sellBeginTime
            // 
            this.txt_sellBeginTime.Location = new System.Drawing.Point(123, 304);
            this.txt_sellBeginTime.Name = "txt_sellBeginTime";
            this.txt_sellBeginTime.ReadOnly = true;
            this.txt_sellBeginTime.Size = new System.Drawing.Size(100, 21);
            this.txt_sellBeginTime.TabIndex = 10;
            // 
            // txt_filmEndTime
            // 
            this.txt_filmEndTime.Location = new System.Drawing.Point(384, 267);
            this.txt_filmEndTime.Name = "txt_filmEndTime";
            this.txt_filmEndTime.ReadOnly = true;
            this.txt_filmEndTime.Size = new System.Drawing.Size(100, 21);
            this.txt_filmEndTime.TabIndex = 10;
            // 
            // cbo_filmBeginTime
            // 
            this.cbo_filmBeginTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_filmBeginTime.FormattingEnabled = true;
            this.cbo_filmBeginTime.Location = new System.Drawing.Point(123, 267);
            this.cbo_filmBeginTime.Name = "cbo_filmBeginTime";
            this.cbo_filmBeginTime.Size = new System.Drawing.Size(100, 20);
            this.cbo_filmBeginTime.TabIndex = 11;
            // 
            // txt_sellEndTime
            // 
            this.txt_sellEndTime.Location = new System.Drawing.Point(384, 308);
            this.txt_sellEndTime.Name = "txt_sellEndTime";
            this.txt_sellEndTime.ReadOnly = true;
            this.txt_sellEndTime.Size = new System.Drawing.Size(100, 21);
            this.txt_sellEndTime.TabIndex = 10;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(298, 343);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 12;
            this.btn_confirm.Text = "确定";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(409, 343);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // ManageFilmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 378);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.cbo_filmBeginTime);
            this.Controls.Add(this.txt_filmEndTime);
            this.Controls.Add(this.txt_sellEndTime);
            this.Controls.Add(this.txt_sellBeginTime);
            this.Controls.Add(this.txt_filmName);
            this.Controls.Add(this.cbo_videoHallNO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageFilmSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "排片";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageFilmSchedule_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_filmSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_filmSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_videoHallNO;
        private System.Windows.Forms.TextBox txt_filmName;
        private System.Windows.Forms.TextBox txt_sellBeginTime;
        private System.Windows.Forms.TextBox txt_filmEndTime;
        private System.Windows.Forms.ComboBox cbo_filmBeginTime;
        private System.Windows.Forms.TextBox txt_sellEndTime;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
    }
}