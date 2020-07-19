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
    public partial class resultFrm : Form
    {
        public List<string> list { get; set; }
        public string msg { get; set; }
        public resultFrm()
        {
            //窗体居中
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();            
        }

        private void resultFrm_Load(object sender, EventArgs e)
        {
            string str = string.Join("\r\n", list);

            this.resultTxt.Text = str;

            this.msgLbl.Text = "共有" + list.Count.ToString() + "条数据" + msg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.resultTxt.Text);
            MessageBox.Show("已复制到剪切板！", "提示");
        }
    }
}
