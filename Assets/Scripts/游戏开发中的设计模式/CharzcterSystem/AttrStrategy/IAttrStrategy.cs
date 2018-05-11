using System;
using System.Collections.Generic;

//创建策略模式
public interface IAttrStrategy
{
     int GetExtraHPValue(int lv);
     int GetDmgDescValue(int lv);
     int GetCritDmgValue(float critRate);
}

