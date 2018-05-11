using System;
using System.Collections.Generic;

public class SoldierSergeant : ISoldier
{
    protected override void PlayEffect()
    {
        DoPLayEffect("SergeantDeadEffect");
    }

    protected override void PlaySound()
    {
        DoPlaySound("SergeantDeath");
    }
}

