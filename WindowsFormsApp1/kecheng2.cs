using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class kecheng2 : Form
    {
        public kecheng2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" )
            {
                stushujuku stu = new stushujuku();//数据库实例化
                string sql = $"insert into kecheng values ({textBox1.Text},'{textBox2.Text}','{textBox3.Text},');";
                int g = stu.Execute(sql);//将sql作为参数就可以执行sql语句
                if (g > 0)
                {
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("添加失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //清空上面的文本框
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                
            }
            else
            {
                MessageBox.Show("添加时不能有空");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
