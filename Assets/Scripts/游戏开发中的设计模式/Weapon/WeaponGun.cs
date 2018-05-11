using System;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGun : IWeapon
{
    public WeaponGun(int atks, float atkRang, GameObject game) : base(atks, atkRang, game)
    {
    }

    protected override void PlayBulletEffect(Vector3 targetposition)
    {
        DoPlayBulletEffect(0.05f, targetposition);
    }

    protected override void PlaySound()
    {
        DoPlaySound("GunShot");
    }

    protected override void SetDisPlayTime()
    {
        effectDisplayTime = 0.2f;
    }
}

