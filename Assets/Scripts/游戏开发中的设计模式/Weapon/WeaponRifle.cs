using System;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRifle :IWeapon
{

    public WeaponRifle(int atks, float atkRang, GameObject game) : base(atks, atkRang, game)
    {
    }

    protected override void PlayBulletEffect(Vector3 targetposition)
    {
        DoPlayBulletEffect(0.1f, targetposition);
    }

    protected override void PlaySound()
    {
        DoPlaySound("RifleShot");
    }

    protected override void SetDisPlayTime()
    {
        effectDisplayTime = 0.3f;
    }
}

