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
    public partial class stuji : Form
    {
        public stuji()
        {
            InitializeComponent();
        }

        private void stuji_Load(object sender, EventArgs e)
        {
            table();
        }
        public void table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            stushujuku stu = new stushujuku();
            string sql = "select * from stujibenxinxi";
            IDataReader xsxx = stu.read(sql);
            while (xsxx.Read())//对xsxx进行读行循环
            {
                dataGridView1.Rows.Add(xsxx[0].ToString(), xsxx[1].ToString(), xsxx[2].ToString(), xsxx[3].ToString(), xsxx[4].ToString());
            }
            xsxx.Close();
            stu.stushujukuClose();

        }
    }
}
