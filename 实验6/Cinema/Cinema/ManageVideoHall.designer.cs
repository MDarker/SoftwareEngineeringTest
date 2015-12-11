namespace Cinema
{
    partial class ManageVideoHall
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
            this.dgv_VideoHallM = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_VideoHallId = new System.Windows.Forms.TextBox();
            this.txt_Seatings = new System.Windows.Forms.TextBox();
            this.txt_Row = new System.Windows.Forms.TextBox();
            this.txt_Col = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.VideoHallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seatings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowSeatNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSeatNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VideoHallM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_VideoHallM
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VideoHallM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_VideoHallM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VideoHallM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VideoHallId,
            this.Seatings,
            this.RowSeatNum,
            this.ColumnSeatNum});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_VideoHallM.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_VideoHallM.Location = new System.Drawing.Point(12, 12);
            this.dgv_VideoHallM.Name = "dgv_VideoHallM";
            this.dgv_VideoHallM.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VideoHallM.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_VideoHallM.RowTemplate.Height = 23;
            this.dgv_VideoHallM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_VideoHallM.Size = new System.Drawing.Size(418, 150);
            this.dgv_VideoHallM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "放映厅";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "座位数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "行数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "列数";
            // 
            // txt_VideoHallId
            // 
            this.txt_VideoHallId.Location = new System.Drawing.Point(76, 185);
            this.txt_VideoHallId.Name = "txt_VideoHallId";
            this.txt_VideoHallId.Size = new System.Drawing.Size(100, 21);
            this.txt_VideoHallId.TabIndex = 6;
            // 
            // txt_Seatings
            // 
            this.txt_Seatings.Location = new System.Drawing.Point(253, 185);
            this.txt_Seatings.Name = "txt_Seatings";
            this.txt_Seatings.Size = new System.Drawing.Size(100, 21);
            this.txt_Seatings.TabIndex = 7;
            // 
            // txt_Row
            // 
            this.txt_Row.Location = new System.Drawing.Point(253, 232);
            this.txt_Row.Name = "txt_Row";
            this.txt_Row.Size = new System.Drawing.Size(100, 21);
            this.txt_Row.TabIndex = 8;
            // 
            // txt_Col
            // 
            this.txt_Col.Location = new System.Drawing.Point(76, 232);
            this.txt_Col.Name = "txt_Col";
            this.txt_Col.Size = new System.Drawing.Size(100, 21);
            this.txt_Col.TabIndex = 10;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(56, 288);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "增加";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(175, 288);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(300, 288);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 23);
            this.btn_Modify.TabIndex = 14;
            this.btn_Modify.Text = "修改";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // VideoHallId
            // 
            this.VideoHallId.HeaderText = "放映厅";
            this.VideoHallId.Name = "VideoHallId";
            this.VideoHallId.ReadOnly = true;
            // 
            // Seatings
            // 
            this.Seatings.HeaderText = "座位数";
            this.Seatings.Name = "Seatings";
            this.Seatings.ReadOnly = true;
            // 
            // RowSeatNum
            // 
            this.RowSeatNum.HeaderText = "行数";
            this.RowSeatNum.Name = "RowSeatNum";
            this.RowSeatNum.ReadOnly = true;
            // 
            // ColumnSeatNum
            // 
            this.ColumnSeatNum.HeaderText = "列数";
            this.ColumnSeatNum.Name = "ColumnSeatNum";
            this.ColumnSeatNum.ReadOnly = true;
            // 
            // ManageVideoHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 316);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Col);
            this.Controls.Add(this.txt_Row);
            this.Controls.Add(this.txt_Seatings);
            this.Controls.Add(this.txt_VideoHallId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_VideoHallM);
            this.Name = "ManageVideoHall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "放映厅管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageVideoHall_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VideoHallM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_VideoHallM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_VideoHallId;
        private System.Windows.Forms.TextBox txt_Seatings;
        private System.Windows.Forms.TextBox txt_Row;
        private System.Windows.Forms.TextBox txt_Col;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoHallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seatings;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowSeatNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSeatNum;
    }
}