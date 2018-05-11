using System;
using System.Collections.Generic;

public class EnemyTroll : IEnemy
{
    protected override void PlayEffect()
    {
        DoPLayEffect("TrollHitEffect");
    }
}

