using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P105032013100_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)   //判断是否输入的是数字，允许输入删除键
                e.Handled = false;   //表示没处理过，系统会接收处理
            else
            {
                bool IsContainsDot = this.textBox1.Text.Contains('.');
                String a = this.textBox1.Text.Trim();
                if (e.KeyChar == '.' && IsContainsDot == false && a != "")
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)   //判断是否输入的是数字，允许输入删除键
                e.Handled = false;   //表示没处理过，系统会接收处理
            else
            {
                bool IsContainsDot = this.textBox2.Text.Contains('.');
                String a = this.textBox2.Text.Trim();    //代码复制过去注意改掉相关的文本框名字

                if (e.KeyChar == '.' && IsContainsDot == false && a != "")  //a!=""不是a!＝" " 对空格数是有要求
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)   //判断是否输入的是数字，允许输入删除键
                e.Handled = false;   //表示没处理过，系统会接收处理
            else
            {
                bool IsContainsDot = this.textBox3.Text.Contains('.');
                String a = this.textBox3.Text.Trim();
                if (e.KeyChar == '.' && IsContainsDot == false && a != "")
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Single Y = Convert.ToSingle(textBox2.Text) / 12;
            Single a = Convert.ToSingle(textBox1.Text) * Y * (1 + Y) / ((1 + Y) - 1);
            textBox6.Text = string.Format("{0:C}", a);
            TimeSpan ts = (dateTimePicker2.Value - dateTimePicker1.Value);
            double month = ts.TotalDays / 30;
            textBox4.Text = string.Format("{0:C}", a * month);
            textBox5.Text = string.Format("{0:C}", a * month - Convert.ToSingle(textBox1.Text));












        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)   //判断是否输入的是数字，允许输入删除键
                e.Handled = false;   //表示没处理过，系统会接收处理
            else
            {
                bool IsContainsDot = this.textBox7.Text.Contains('.');
                String a = this.textBox7.Text.Trim();
                if (e.KeyChar == '.' && IsContainsDot == false && a != "")
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)   //判断是否输入的是数字，允许输入删除键
                e.Handled = false;   //表示没处理过，系统会接收处理
            else
            {
                bool IsContainsDot = this.textBox7.Text.Contains('.');
                String a = this.textBox7.Text.Trim();
                if (e.KeyChar == '.' && IsContainsDot == false && a != "")
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeSpan ts = (dateTimePicker2.Value - dateTimePicker1.Value);
            double month = ts.TotalDays / 30;

            Single Y = Convert.ToSingle(textBox2.Text) / 12;
            double b = Convert.ToDouble(textBox7.Text) * ((1 + Y) * month - 1);
            textBox9.Text = string.Format("{0:C}", b);


        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


        