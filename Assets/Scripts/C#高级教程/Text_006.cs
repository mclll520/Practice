/*              #########                       
              ############                     
              #############                    
             ##  ###########                   
            ###  ###### #####                  
            ### #######   ####                 
           ###  ########## ####                
          ####  ########### ####               
         ####   ###########  #####             
        #####   ### ########   #####           
       #####   ###   ########   ######         
      ######   ###  ###########   ######       
     ######   #### ##############  ######      
    #######  #####################  ######     
    #######  ######################  ######    
   #######  ###### #################  ######   
   #######  ###### ###### #########   ######   
   #######    ##  ######   ######     ######   
   #######        ######    #####     #####    
    ######        #####     #####     ####     
     #####        ####      #####     ###      
      #####       ###        ###      #        
        ###       ###        ###              
         ##       ###        ###               
__________#_______####_______####______________
    身是菩提树，心如明镜台，时时勤拂拭，勿使惹尘埃。
                我们的未来没有BUG              
* ==============================================================================
* Filename: Text_006
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Text_006 : MonoBehaviour {

	
	void Start ()
	{
	    //初始化武林高手
	    var master = new List<MartialArtsMaster>(){
	        new MartialArtsMaster(){ Id = 1, Name = "黄蓉",    Age = 18, Menpai = "丐帮", Kungfu = "打狗棒法",  Level = 9  },
	        new MartialArtsMaster(){ Id = 2, Name = "洪七公",  Age = 70, Menpai = "丐帮", Kungfu = "打狗棒法",  Level = 10 },
	        new MartialArtsMaster(){ Id = 3, Name = "郭靖",    Age = 22, Menpai = "丐帮", Kungfu = "降龙十八掌",Level = 10 },
	        new MartialArtsMaster(){ Id = 4, Name = "任我行",  Age = 50, Menpai = "明教", Kungfu = "葵花宝典",  Level = 1  },
	        new MartialArtsMaster(){ Id = 5, Name = "东方不败",Age = 35, Menpai = "明教", Kungfu = "葵花宝典",  Level = 10 },
	        new MartialArtsMaster(){ Id = 6, Name = "林平之",  Age = 23, Menpai = "华山", Kungfu = "葵花宝典",  Level = 7  },
	        new MartialArtsMaster(){ Id = 7, Name = "岳不群",  Age = 50, Menpai = "华山", Kungfu = "葵花宝典",  Level = 8  },
	        new MartialArtsMaster(){ Id = 8, Name = "令狐冲", Age = 23, Menpai = "华山", Kungfu = "独孤九剑", Level = 10 },
	        new MartialArtsMaster(){ Id = 9, Name = "梅超风", Age = 23, Menpai = "桃花岛", Kungfu = "九阴真经", Level = 8 },
	        new MartialArtsMaster(){ Id =10, Name = "黄药师", Age = 23, Menpai = "梅花岛", Kungfu = "弹指神通", Level = 10 },
	        new MartialArtsMaster(){ Id = 11, Name = "风清扬", Age = 23, Menpai = "华山", Kungfu = "独孤九剑", Level = 10 }
	    };
        //初始化武学
        var kongfu = new List<Kongfu>(){
            new Kongfu(){KongfuId=1, KongfuName="打狗棒法", Lethality=90},
            new Kongfu(){KongfuId=2, KongfuName="降龙十八掌", Lethality=95},
            new Kongfu(){KongfuId=3, KongfuName="葵花宝典", Lethality=100},
            new Kongfu() { KongfuId=  4, KongfuName = "独孤九剑", Lethality = 100 },
            new Kongfu() { KongfuId = 5, KongfuName = "九阴真经", Lethality = 100 },
            new Kongfu() { KongfuId = 6, KongfuName = "弹指神通", Lethality = 100 }
        };
	    print(kongfu);
        //var res =new List<MartialArtsMaster>();
        //foreach (var artsMaster in master)
        //{
        //    if (artsMaster.Level>8)
        //    {
        //        res.Add(artsMaster);
        //    }
        //}

        //使用LinQ做查询
        //var res = from m in master
        //             //from设置查询的集合
        //    where m.Level < 8
        //       //where 后面跟上查询的条件
        //    select m.Name; //表示m的结果返回
        //   foreach (var re in res)
        //{
        //    Debug.Log(re);
        //}
        //var res1 = from artsMaster in master
        //    where artsMaster.Age < 21
        //    select artsMaster;
        //foreach (var re in res1)
        //{
        //    Debug.Log(re.ToString());
        //}

        //扩展方法
        //var ress = master.Where(Text1);
        //foreach (var re in ress)
        //{
        //    Debug.Log(re.ToString());
        //}
        //var res1 = master.Where(m => m.Level > 8&&m.Menpai=="丐帮");
        //foreach (var re in res1)
        //{
        //    Debug.Log(re.ToString());
        //}

        //Linq联合查询
        //去的功夫杀伤力大于90的大侠
        //var re1 = from ma in master
        //    from ko in kongfu
        //    where ma.Kungfu == ko.KongfuName && ko.Lethality > 96
        //    //select new {mas = ma, kon = ko};
        //    select ma;
        //foreach (var n in re1)
        //{
        //    Debug.Log(n);
        //}
        //扩展方法
        //var res = master.SelectMany(m => kongfu, (m, k) => new
        //{
        //    mas = m,
        //    kon = k
        //}).Where(x => x.mas.Kungfu == x.kon.KongfuName && x.kon.Lethality>99);
        //foreach (var re in res)
        //{
        //    print(re);
        //}

        //对查询结果做排序 orderby
        //var res1 = from ma in master
        //    where ma.Level > 8 && ma.Menpai == "丐帮"
        //       //orderby ma.Age descending //descending 倒序排序
        //       orderby ma.Level descending ,ma.Age descending 
        //              select ma;
        //   foreach (var re in res1)
        //   {
        //       Debug.Log(re.ToString());
        //   }
        //var res = master.Where(m => m.Level > 8 && m.Menpai == "丐帮").OrderBy(m => m.Level).OrderBy(m => m.Age);
        //var res = master.Where(m => m.Level > 8).OrderBy(m => m.Level).ThenBy(m => m.Age);
        //   foreach (var re in res)
        //{
        //    print(re);
        //}


        //join on联合查询
        //var res123 = from m in master
        //    join k in kongfu on m.Kungfu equals k.KongfuName
        //    select new {ma = m, ko = k};
        //foreach (var re in res123)
        //   {
        //       print(re);
        //   }


        //分组查询into 
        //var re123 = from k in kongfu
        //    join m in master on k.KongfuName equals m.Kungfu
        //        into groups
        //           orderby groups.Count()
        //    select new {kou = k, count = groups.Count()};
        //foreach (var r in re123)
        //{
        //    print(r);
        //}


        //按照自身字段分组 group
        //var rew = from m in master
        //    group m by m.Menpai
        //    into g
        //    select new {count = g.Count(), key = g.Key};
        //foreach (var r in rew)
        //{
        //    print(r);
        //}


        //量词操作符 any all 判断集合中是否满足某条件
        bool reqw = master.Any(m => m.Menpai == "丐帮");//任意
	    print(reqw);

	    bool rewqw = master.All(m => m.Menpai == "丐帮");//所有
	    print(rewqw);



	}

    private bool Text1(MartialArtsMaster arg1)
    {
        if (arg1.Level>8)
        {
            return true;
        }
        return false;
    }

}
/// <summary>
/// 武林秘籍
/// </summary>
class Kongfu
{
    public int KongfuId;
    public string KongfuName;
    public int Lethality;

    public override string ToString()
    {
        return string.Format("KongfuId: {0}, KongfuName: {1}, Lethality: {2}", KongfuId, KongfuName, Lethality);
    }
}
/// <summary>
/// 武林高手
/// </summary>
class MartialArtsMaster
{
    public int Id;
    public string Name;
    public int Age;
    public string Menpai;
    public string Kungfu;
    public int Level;

    public override string ToString()
    {
        return string.Format("Id: {0}, Name: {1}, Age: {2}, Menpai: {3}, Kungfu: {4}, Level: {5}", Id, Name, Age, Menpai, Kungfu, Level);
    }
}
