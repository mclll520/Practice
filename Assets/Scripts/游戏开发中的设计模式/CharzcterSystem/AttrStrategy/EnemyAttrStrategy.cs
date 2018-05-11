using System.Collections.Generic;
using UnityEngine;

public class EnemyAttrStrategy : IAttrStrategy
{
    public int GetCritDmgValue(float critRate)
    {
        float num = Random.Range(0, 1f);
        if (num<critRate)
        {
            return (int)(10 * Random.Range(0.5f, 1f));
        }
        return 0;
    }

    public int GetDmgDescValue(int lv)
    {
        return 0;
    }

    public int GetExtraHPValue(int lv)
    {
        return 0;
    }
}

