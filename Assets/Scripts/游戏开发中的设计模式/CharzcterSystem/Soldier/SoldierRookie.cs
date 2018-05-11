using System;
using System.Collections.Generic;

public class SoldierRookie : ISoldier
{
    protected override void PlayEffect()
    {
        DoPLayEffect("RookieDeadEffect");
    }

    protected override void PlaySound()
    {
        DoPlaySound("RookieDeath");
    }
}

