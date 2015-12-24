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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_VideoHallM = new System.Windows.Forms.DataGridView();
            this.VideoHallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seatings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowSeatNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSeatNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lbl_ImportExport = new System.Windows.Forms.LinkLabel();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_OldHallId = new System.Windows.Forms.Label();
            this.btn_TP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VideoHallM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_VideoHallM
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VideoHallM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_VideoHallM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VideoHallM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VideoHallId,
            this.Seatings,
            this.RowSeatNum,
            this.ColumnSeatNum});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_VideoHallM.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_VideoHallM.Location = new System.Drawing.Point(12, 12);
            this.dgv_VideoHallM.Name = "dgv_VideoHallM";
            this.dgv_VideoHallM.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VideoHallM.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_VideoHallM.RowHeadersWidth = 20;
            this.dgv_VideoHallM.RowTemplate.Height = 23;
            this.dgv_VideoHallM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_VideoHallM.Size = new System.Drawing.Size(418, 150);
            this.dgv_VideoHallM.TabIndex = 0;
            this.dgv_VideoHallM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dgv_VideoHallM_CellClick);
            // 
            // VideoHallId
            // 
            this.VideoHallId.DataPropertyName = "VideoHallId";
            this.VideoHallId.HeaderText = "放映厅";
            this.VideoHallId.Name = "VideoHallId";
            this.VideoHallId.ReadOnly = true;
            // 
            // Seatings
            // 
            this.Seatings.DataPropertyName = "Seatings";
            this.Seatings.HeaderText = "座位数";
            this.Seatings.Name = "Seatings";
            this.Seatings.ReadOnly = true;
            // 
            // RowSeatNum
            // 
            this.RowSeatNum.DataPropertyName = "RowSeatNum";
            this.RowSeatNum.HeaderText = "行数";
            this.RowSeatNum.Name = "RowSeatNum";
            this.RowSeatNum.ReadOnly = true;
            // 
            // ColumnSeatNum
            // 
            this.ColumnSeatNum.DataPropertyName = "ColumnSeatNum";
            this.ColumnSeatNum.HeaderText = "列数";
            this.ColumnSeatNum.Name = "ColumnSeatNum";
            this.ColumnSeatNum.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "放映厅";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "座位数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "行数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "列数";
            // 
            // txt_VideoHallId
            // 
            this.txt_VideoHallId.Enabled = false;
            this.txt_VideoHallId.Location = new System.Drawing.Point(52, 233);
            this.txt_VideoHallId.Name = "txt_VideoHallId";
            this.txt_VideoHallId.Size = new System.Drawing.Size(100, 21);
            this.txt_VideoHallId.TabIndex = 6;
            // 
            // txt_Seatings
            // 
            this.txt_Seatings.Enabled = false;
            this.txt_Seatings.Location = new System.Drawing.Point(219, 233);
            this.txt_Seatings.Name = "txt_Seatings";
            this.txt_Seatings.Size = new System.Drawing.Size(100, 21);
            this.txt_Seatings.TabIndex = 7;
            // 
            // txt_Row
            // 
            this.txt_Row.Enabled = false;
            this.txt_Row.Location = new System.Drawing.Point(52, 280);
            this.txt_Row.Name = "txt_Row";
            this.txt_Row.Size = new System.Drawing.Size(100, 21);
            this.txt_Row.TabIndex = 8;
            // 
            // txt_Col
            // 
            this.txt_Col.Enabled = false;
            this.txt_Col.Location = new System.Drawing.Point(219, 280);
            this.txt_Col.Name = "txt_Col";
            this.txt_Col.Size = new System.Drawing.Size(100, 21);
            this.txt_Col.TabIndex = 10;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(34, 180);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "要添加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(234, 180);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(133, 180);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 23);
            this.btn_Modify.TabIndex = 14;
            this.btn_Modify.Text = "要修改";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // lbl_ImportExport
            // 
            this.lbl_ImportExport.AutoSize = true;
            this.lbl_ImportExport.Location = new System.Drawing.Point(366, 283);
            this.lbl_ImportExport.Name = "lbl_ImportExport";
            this.lbl_ImportExport.Size = new System.Drawing.Size(53, 12);
            this.lbl_ImportExport.TabIndex = 15;
            this.lbl_ImportExport.TabStop = true;
            this.lbl_ImportExport.Text = "导入导出";
            this.lbl_ImportExport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_ImportExport_LinkClicked);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(186, 363);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(100, 23);
            this.btn_Export.TabIndex = 28;
            this.btn_Export.Text = "导出放映厅数据";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(82, 363);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(75, 23);
            this.btn_Import.TabIndex = 27;
            this.btn_Import.Text = " 导入";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(126, 322);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(305, 21);
            this.txt_FilePath.TabIndex = 26;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(21, 322);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(99, 21);
            this.btn_Browse.TabIndex = 25;
            this.btn_Browse.Text = "浏览Excel文件";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(333, 180);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 34;
            this.btn_Cancel.Text = "取消操作";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_OldHallId
            // 
            this.lbl_OldHallId.AutoSize = true;
            this.lbl_OldHallId.Location = new System.Drawing.Point(336, 218);
            this.lbl_OldHallId.Name = "lbl_OldHallId";
            this.lbl_OldHallId.Size = new System.Drawing.Size(95, 12);
            this.lbl_OldHallId.TabIndex = 35;
            this.lbl_OldHallId.Text = "放映厅号-不可见";
            this.lbl_OldHallId.Visible = false;
            // 
            // btn_TP
            // 
            this.btn_TP.Location = new System.Drawing.Point(318, 363);
            this.btn_TP.Name = "btn_TP";
            this.btn_TP.Size = new System.Drawing.Size(75, 23);
            this.btn_TP.TabIndex = 36;
            this.btn_TP.Text = "导出表模板";
            this.btn_TP.UseVisualStyleBackColor = true;
            this.btn_TP.Click += new System.EventHandler(this.btn_TP_Click);
            // 
            // ManageVideoHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 401);
            this.Controls.Add(this.btn_TP);
            this.Controls.Add(this.lbl_OldHallId);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.txt_FilePath);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.lbl_ImportExport);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageVideoHall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "放映厅管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageVideoHall_FormClosed);
            this.Load += new System.EventHandler(this.ManageVideoHall_Load);
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
        private System.Windows.Forms.LinkLabel lbl_ImportExport;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoHallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seatings;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowSeatNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSeatNum;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_OldHallId;
        private System.Windows.Forms.Button btn_TP;
    }
}