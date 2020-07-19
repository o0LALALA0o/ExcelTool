using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excelTool
{
    public class Helper
    {
        /// <summary>
        /// 查找两个集合内相同的数据
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static List<string> Repeat(List<string> list1,List<string> list2)
        {
            List<string> list = new List<string>();

            //交集
            list= list1.Intersect(list2).ToList();

            //去除空白数据
            list = list.Where(x => !string.IsNullOrEmpty(x)).ToList();

            return list;
        }

        /// <summary>
        /// 查找两个集合内不同的数据
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static List<string> Difference(List<string> list1, List<string> list2)
        {
            List<string> list = new List<string>();


            //差集
            List<string> listA = list1.Except(list2).ToList();
            List<string> listB = list2.Except(list1).ToList();

            foreach (var item in listA)
            {
                list.Add(item);
            }

            foreach (var item in listB)
            {
                list.Add(item);
            }

            //去除空白数据
            list = list.Where(x => !string.IsNullOrEmpty(x)).ToList();

            list = Distinct(list);

            return list;
        }

        /// <summary>
        /// 去重
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<string> Distinct(List<string> list) {
            return list.Distinct().ToList();
        }

    }
}
