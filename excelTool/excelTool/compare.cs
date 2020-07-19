using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excelTool
{
    public partial class Excel小工具 : Form
    {
        public Excel小工具()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data1 = this.dataTxt1.Text;
            string data2 = this.dataTxt2.Text;

            if (string.IsNullOrEmpty(data1)|| string.IsNullOrEmpty(data2))
            {

                MessageBox.Show("请输入数据！", "提示");
                return;
            }

            List<string> list1 = data1.Split(new string[] { "\r\n" }, StringSplitOptions.None).ToList();
            List<string> list2 = data2.Split(new string[] { "\r\n" }, StringSplitOptions.None).ToList();

            Helper.Repeat(list1, list2);
        }

        private void dataTxt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataTxt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
