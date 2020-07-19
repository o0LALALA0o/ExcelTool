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
    public partial class MatchResultsFrm : Form
    {
        public List<string> yList { get; set; }
        public List<string> nList { get; set; }
        public string yMsg { get; set; }
        public string nMsg { get; set; }

        public List<string> list { get; set; }
        public string msg { get; set; }

        public MatchResultsFrm()
        {
            //窗体居中
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void MatchResultsFrm_Load(object sender, EventArgs e)
        {
            string str = string.Join("\r\n", list);

            this.resultTxt.Text = str;

            this.msgLbl.Text = "共有" + list.Count.ToString() + "条数据" + msg;

            string yStr = string.Join("\r\n", yList);
            string nStr = string.Join("\r\n", nList);

            this.yLbl.Text = yMsg;
            this.nLbl.Text = nMsg;

            this.yTxt.Text = yStr;
            this.nTxt.Text = nStr;
        }

        private void yBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.yTxt.Text);
            MessageBox.Show("已复制到剪切板！", "提示");
        }

        private void nBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.nTxt.Text);
            MessageBox.Show("已复制到剪切板！", "提示");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.resultTxt.Text);
            MessageBox.Show("已复制到剪切板！", "提示");
        }
    }
}
