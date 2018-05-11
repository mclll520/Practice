using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
/// <summary>
/// List 泛型集合
/// </summary>
public class Text04 : MonoBehaviour {

	void Start () {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);

        list.AddRange(new int[] { 4, 5, 6, 7, 8, 9 });
        //转数组
        int[] num = list.ToArray();
        List<int> list1 = num.ToList();


        char[] char1 = new char[] { 'a', 's', 'd', 'f' };
        List<char> listchar = char1.ToList();
        foreach (char item in listchar)
        {
            print(item);
        }


        for (int i = 0; i < list.Count; i++)
        {
            //print(list[i]);
            print(list1[i]);
        }
	}
	

}
