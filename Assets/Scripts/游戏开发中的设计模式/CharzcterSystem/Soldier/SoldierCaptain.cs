﻿using System;
using System.Collections.Generic;

public class SoldierCaptain : ISoldier
{
    protected override void PlayEffect()
    {
        DoPLayEffect("CaptainDeadEffect");
    }

    protected override void PlaySound()
    {
        DoPlaySound("CaptainDeath");
    }
}

