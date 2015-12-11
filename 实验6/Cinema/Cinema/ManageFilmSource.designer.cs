namespace Cinema
{
    partial class ManageFilmSource
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
            this.dgv_FilmSourceM = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FilmSourceM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_FilmSourceM
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FilmSourceM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_FilmSourceM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_FilmSourceM.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_FilmSourceM.Location = new System.Drawing.Point(12, 12);
            this.dgv_FilmSourceM.Name = "dgv_FilmSourceM";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FilmSourceM.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_FilmSourceM.RowTemplate.Height = 23;
            this.dgv_FilmSourceM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_FilmSourceM.Size = new System.Drawing.Size(520, 150);
            this.dgv_FilmSourceM.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_FilmId
            // 
            this.txt_FilmId.Location = new System.Drawing.Point(22, 197);
            this.txt_FilmId.Name = "txt_FilmId";
            this.txt_FilmId.Size = new System.Drawing.Size(100, 21);
            this.txt_FilmId.TabIndex = 3;
            // 
            // txt_FilmName
            // 
            this.txt_FilmName.Location = new System.Drawing.Point(152, 199);
            this.txt_FilmName.Name = "txt_FilmName";
            this.txt_FilmName.Size = new System.Drawing.Size(100, 21);
            this.txt_FilmName.TabIndex = 4;
            // 
            // txt_FilmTimes
            // 
            this.txt_FilmTimes.Location = new System.Drawing.Point(288, 197);
            this.txt_FilmTimes.Name = "txt_FilmTimes";
            this.txt_FilmTimes.Size = new System.Drawing.Size(100, 21);
            this.txt_FilmTimes.TabIndex = 5;
            // 
            // btn_DownLine
            // 
            this.btn_DownLine.Location = new System.Drawing.Point(328, 297);
            this.btn_DownLine.Name = "btn_DownLine";
            this.btn_DownLine.Size = new System.Drawing.Size(75, 23);
            this.btn_DownLine.TabIndex = 6;
            this.btn_DownLine.Text = "下映";
            this.btn_DownLine.UseVisualStyleBackColor = true;
            // 
            // txt_Protagonists
            // 
            this.txt_Protagonists.Location = new System.Drawing.Point(25, 251);
            this.txt_Protagonists.Name = "txt_Protagonists";
            this.txt_Protagonists.Size = new System.Drawing.Size(100, 21);
            this.txt_Protagonists.TabIndex = 7;
            // 
            // txt_FilmType
            // 
            this.txt_FilmType.Location = new System.Drawing.Point(152, 251);
            this.txt_FilmType.Name = "txt_FilmType";
            this.txt_FilmType.Size = new System.Drawing.Size(100, 21);
            this.txt_FilmType.TabIndex = 8;
            // 
            // txt_Producers
            // 
            this.txt_Producers.Location = new System.Drawing.Point(288, 251);
            this.txt_Producers.Name = "txt_Producers";
            this.txt_Producers.Size = new System.Drawing.Size(100, 21);
            this.txt_Producers.TabIndex = 9;
            // 
            // txt_Director
            // 
            this.txt_Director.Location = new System.Drawing.Point(418, 199);
            this.txt_Director.Name = "txt_Director";
            this.txt_Director.Size = new System.Drawing.Size(100, 21);
            this.txt_Director.TabIndex = 10;
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(418, 251);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(100, 21);
            this.txt_Country.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "电影Id：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "电影名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "电影时长：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "导演：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "主演：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "类型：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "发行：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "国家：";
            // 
            // ManageFilmSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 334);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_FilmSourceM);
            this.MaximizeBox = false;
            this.Name = "ManageFilmSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "片源管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageFilmSource_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FilmSourceM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_FilmSourceM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
    }
}