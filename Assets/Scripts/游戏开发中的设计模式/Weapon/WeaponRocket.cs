using System;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRocket : IWeapon
{

    public WeaponRocket(int atks, float atkRang, GameObject game) : base(atks, atkRang, game)
    {
    }

    protected override void PlayBulletEffect(Vector3 targetposition)
    {
        DoPlayBulletEffect(0.3f, targetposition);
    }

    protected override void PlaySound()
    {
        DoPlaySound("RocketShot");
    }

    protected override void SetDisPlayTime()
    {
        effectDisplayTime = 0.4f;
    }
}

