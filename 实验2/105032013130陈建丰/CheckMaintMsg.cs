using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuntMain
{
    public partial class CheckMaintMsg : Form
    {
        public CheckMaintMsg()
        {
            InitializeComponent();
        }

        private void CheckMaintMsg_Load(object sender, EventArgs e)
        {
            dgvState.ReadOnly = true;//初始时表中数据不能被编辑
            #region 在这里默认查询当前学生所在宿舍的报修情况
            //在这里默认查询当前学生所在宿舍的报修情况
            //Database db = new Database();
            //db.OpenDatabase();
            //string sqlDomNo="select domNO from tMaintenanceAppication where stuNameOfApplicaton='' "
            //SqlCommand cmd = new SqlCommand();

            #endregion 
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnAlter .Text =="保存")
            {
                if (MessageBox.Show("修改的信息还没有保存，是否需要保存？", "警告！！！",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    dgvState.ReadOnly = true;
                    SaveMsg();
                    this.Close();
                }
                else
                {
                    btnAlter.Text = "修改";
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
        #region 创建一个方法将修改后的信息存入数据库
        public  void SaveMsg()
        {
            Database db = new Database();
            db.OpenDatabase();//打开数据库
            sda = new SqlDataAdapter();
            //声明一些临时变量存储更改后的值
            string stuName = "";
            string stuTell = "";
            string goods = "";
            string reasons = "";
            string sqlAlter = "";
            int i = 0;
            for (i = 0; i < dgvState.Rows.Count; i++)
            {
                stuName = dgvState.Rows[i].Cells[2].Value.ToString();
                stuTell = dgvState.Rows[i].Cells[3].Value.ToString();
                goods = dgvState.Rows[i].Cells[4].Value.ToString();
                reasons = dgvState.Rows[i].Cells[5].Value.ToString();
                //将更改后的值传回到数据库中去  
                sqlAlter = "update tMaintenanceApplication set stuNameOfApplication='" + stuName.Trim() + "',stuTellOfApplication='"+ stuTell.Trim()
                    + "',goods='" + goods.Trim() + "',reasons='" + reasons.Trim() + "' where id=" + dgvState.Rows[i].Cells[0].Value.ToString();
                SqlCommand cmd = new SqlCommand(sqlAlter, db.sqlConn);
                sda.SelectCommand = cmd;
                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("第{}行及以后的行修改失败", i.ToString());
                    break;
                }
            }
                if (i == dgvState.Rows.Count)
                {
                    MessageBox.Show("修改成功");
                    btnAlter.Text = "修改";
                }
                db.CloseDatabase();
        }
        #endregion
        DataSet ds;//声明一个DataSet变量
        SqlDataAdapter sda;//声明一个sqlDataAdapter变量
        private void btnCheck_Click(object sender, EventArgs e)
        {
            #region 查询已报修信息
            //判断用户已是否输入查询的宿舍号，若无，则弹出提示
            if (txtDomNO.Text.Trim () =="")
            {
                MessageBox.Show("请输入要查询的宿舍号");
            }    
            else
            {
                Database db = new Database();
                db.OpenDatabase();//打开数据库
                string sqlCheckCondition = "select * from tMaintenanceApplication where domNO='"+txtDomNO .Text +"'";
                SqlCommand cmd = new SqlCommand(sqlCheckCondition,db.sqlConn);
                sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                ds = new DataSet();
                //填充前，清空原有的数据
                if (ds.Tables["domno"] != null)
                {
                    ds.Tables["domno"].Clear();
                }
                sda.Fill(ds, "tMaintenanceApplication");//用Fill方法填充数据集
                dgvState.DataSource = ds.Tables[0];//绑定dgvState的控件源     
                db.CloseDatabase();
            }
            #endregion
        }
        /// <summary>
        /// 修改报修的信息内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlter_Click(object sender, EventArgs e)
        {
            #region 修改数据库信息
            if (dgvState.ReadOnly == true)//提示可以修改数据了
            {
                MessageBox.Show("你现在可以通过修改表中数据来修改信息了");
                btnAlter.Text = "保存";
                dgvState.ReadOnly = false;
                dgvState.Columns[0].ReadOnly = true;//id号不可被编辑
                dgvState.Columns[1].ReadOnly = true;//宿舍号不可被编辑
            }//if else
            else// 修改数据以后存入数据库
            {
                SaveMsg();
            }
            #endregion
        }
    }
}
