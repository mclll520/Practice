using System;
using System.Collections.Generic;

public class EnemyElf : IEnemy
{
    protected override void PlayEffect()
    {
        DoPLayEffect("ElfHitEffect");
    }
}

