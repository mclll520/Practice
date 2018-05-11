using System;
using System.Collections.Generic;

public class EnemyOgre : IEnemy
{
    protected override void PlayEffect()
    {
        DoPLayEffect("OgreHitEffect");
    }
}

