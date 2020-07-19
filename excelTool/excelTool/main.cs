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
    public partial class main : Form
    {
        public main()
        {
            //窗体居中
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data1 = this.dataTxt1.Text;
            string data2 = this.dataTxt2.Text;

            if (string.IsNullOrEmpty(data1) || string.IsNullOrEmpty(data2))
            {

                MessageBox.Show("请输入数据！", "提示");
                return;
            }

            List<string> list1 = changeList(data1);
            List<string> list2 = changeList(data2);

            //去除空白数据
            list1 = list1.Where(x => !string.IsNullOrEmpty(x)).ToList();
            list2 = list2.Where(x => !string.IsNullOrEmpty(x)).ToList();

            List<string> listData = new List<string>();

            if (this.radRepeat.Checked)
            {
                listData = Helper.Repeat(list1, list2);
            }
            else
            {
                listData = Helper.Difference(list1, list2);
            }

            resultFrm frm = new resultFrm();
            frm.list = listData;

            frm.ShowDialog();

        }

        private void distinctBtn_Click(object sender, EventArgs e)
        {
            string data = this.distinctTxt.Text;

            if (string.IsNullOrEmpty(data))
            {

                MessageBox.Show("请输入数据！", "提示");
                return;
            }

            List<string> list = changeList(data);

            //去除空白数据
            list = list.Where(x => !string.IsNullOrEmpty(x)).ToList();

            List<string> dataList = Helper.Distinct(list);

            resultFrm frm = new resultFrm();
            frm.list = dataList;
            frm.msg = ",去除重复数据" + (list.Count - dataList.Count) + "条。";


            frm.ShowDialog();

        }        

        private void matchingBtn_Click(object sender, EventArgs e)
        {
            string data1 = this.matchingTxt.Text;
            string data2 = this.dataTxt.Text;

            //获取条件列
            int num = Convert.ToInt32(this.comboBox1.SelectedValue);

            if (string.IsNullOrEmpty(data1)|| string.IsNullOrEmpty(data2))
            {

                MessageBox.Show("请输入数据！", "提示");
                return;
            }

            List<string> list1 = changeList(data1);
            List<string> list2 = changeList(data2);

            List<TextModel> modelList = new List<TextModel>();

            //将数据源转换为集合
            foreach (var item in list2)
            {
                string[] d = item.Split(new string[] { "\t" }, StringSplitOptions.None);

                TextModel model = new TextModel();

                for (int i = 0; i < d.Length; i++)
                {
                    if (i == num)
                    {
                        model.name = d[i];
                    }
                    else
                    {
                        model.data = model.data+ "\t" + d[i];
                    }
                }

                modelList.Add(model);

            }

            //去除空白数据
            modelList = modelList.Where(x => !string.IsNullOrEmpty(x.name)).ToList();
            list1 = list1.Where(x => !string.IsNullOrEmpty(x)).ToList();


            //全部数据
            List<string> dataList = new List<string>();
            //匹配到的数据
            List<string> yList = new List<string>();
            //未匹配到的数据
            List<string> nList = new List<string>();

            foreach (var item in list1)
            {
                string a = item;
                TextModel m = (modelList.Where(x => x.name == item).FirstOrDefault()) as TextModel;
                if (m == null)
                {
                    dataList.Add(item);
                    nList.Add(item);
                }
                else
                {
                    dataList.Add(item + m.data);
                    yList.Add(item+ m.data);
                }

                
            }

            MatchResultsFrm frm = new MatchResultsFrm();
            frm.yList = yList;
            frm.nList = nList;
            frm.list = dataList;
            frm.yMsg = "已匹配的数据：" + yList.Count + "条";
            frm.nMsg = "未匹配的数据：" + nList.Count + "条。";


            frm.ShowDialog();

        }        

        private void dataTxt_TextChanged(object sender, EventArgs e)
        {
            string data = this.dataTxt.Text;
            string [] arr = changeList(data).ToArray() ;

            string[] d = arr[0].Split(new string[] { "\t" }, StringSplitOptions.None);

            DataTable dt = new DataTable();
            dt.Columns.Add("name");

            dt.Columns.Add("value");


            for (int i = 0; i < d.Length; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = "第" + (i + 1) + "列";
                dr[1] = i;
                dt.Rows.Add(dr);
            }              

            

            this.comboBox1.DataSource = dt;

            this.comboBox1.DisplayMember = "name";

            this.comboBox1.ValueMember = "value";

        }

        /// <summary>
        /// 根据换行符，将字符串转换为集合
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static List<string> changeList(string data)
        {
            List<string> list = new List<string>();

            list = data.Split(new string[] { "\r\n" }, StringSplitOptions.None).ToList();

            return list;
        }
    }
}
