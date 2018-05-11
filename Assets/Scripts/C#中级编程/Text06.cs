using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text06 : MonoBehaviour {

	void Start () {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(1, "张三");
        dic.Add(2, "李四");
        dic.Add(3, "王五");
        dic.Add(4, "刘二");
        dic[1] = "新来的";
        //第一种遍历
        //foreach (KeyValuePair<int,string> kv in dic)
        //{
        //    print(kv.Key + "----" + kv.Value);
        //}

        //第二种遍历
        //foreach (var item in dic.Keys)
        //{
        //    print(item + "----" + dic[item]);
        //}


        //ListText();
        //StringText("sd  fasdf  asdfa  dfas");
    }

    /// <summary>
    /// 讲一个数组  放到2集合里面  奇数数组集合 偶数数组集合
    /// 最后合并  奇数在左  偶数再右
    /// </summary>
    public void ListText() {
        int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        List<int> listOu = new List<int>();
        List<int> listJi = new List<int>();
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] % 2 == 0)
            {
                listOu.Add(num[i]);
            }
            else {
                listJi.Add(num[i]);
            }
        }
        //第一种
        listJi.AddRange(listOu);
        foreach (int item in listJi)
        {
            print(item);
        }
        //第二种
        //List<int> listSum = new List<int>();
        //listSum.AddRange(listJi);
        //listSum.AddRange(listOu);
        //foreach (int item in listSum)
        //{
        //    print(item + "  ");
        //}
    }

    /// <summary>
    /// 统计你所写的字符串的每个字符出现几次 
    /// </summary>
    public void StringText(string Write) {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        for (int i = 0; i < Write.Length; i++)
        {
            if (Write[i]==' ')
            {
                continue;
            }
            //如果此键已经包含当前字符
            if (dic.ContainsKey(Write[i]))
            {
                //值加一
                dic[Write[i]]++;
            }
            else//第一次（键）字符出现
            {
                dic[Write[i]] = 1;
            }
        }
        foreach (KeyValuePair<char,int> kv in dic)
        {
            print(kv.Key + "--出现次数为--" + kv.Value);
        }
    }
}
