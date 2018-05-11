using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;
/// <summary>
/// 装箱 拆箱
/// </summary>
public class Text05 : MonoBehaviour {

	void Start () {
        int n = 10;
        object o = n;//装箱
        int nn = (int)o;//拆箱
        UnityEngine.Debug.Log(nn);

        //这地方没有发生 装拆箱
        string str = "123";
        int str1 = Convert.ToInt32(str);
        print(str1);

        int int1 = 11;
        IComparable i = int1;//装箱
	    print(i);
        //Encasement();

    }
    /// <summary>
    /// 装箱测试
    /// </summary>
    public void Encasement() {
        ArrayList list = new ArrayList();
        //List<int> list =new List<int> ();
        //这里面发生了1000次装箱操作
        Stopwatch sw = new Stopwatch();
        //00:00:00.0008463 (装箱)
        //00:00:00.0006876（未装箱）
        //装箱会消耗内存时耗 尽量避免装箱
        sw.Start();
        for (int i = 0; i < 10000; i++)
        {
            list.Add(i);
        }
        sw.Stop();
        print(sw.Elapsed);
    }
}
