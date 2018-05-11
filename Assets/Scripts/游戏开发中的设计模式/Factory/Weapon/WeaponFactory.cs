using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


public class WeaponFactory : IWeaponFactory
{
    public IWeapon CreateWeapon(WeaponType weaponType)
    {
        IWeapon weapon = null;
        string assetname = "";
        switch (weaponType)
        {
            case WeaponType.Gun:
                assetname = "WeaponGun";
                break;
            case WeaponType.Rifle:
                assetname = "WeaponRifle";
                break;
            case WeaponType.Rocket:
                assetname = "WeaponRocket";
                break;
        }
        GameObject weaponGo = FactoryManager.AssetFactory.LoadWeapon(assetname);
        switch (weaponType)
        {
            case WeaponType.Gun:
                weapon = new WeaponGun(20, 5, weaponGo);
                break;
            case WeaponType.Rifle:
                weapon = new WeaponRifle(30, 7, weaponGo);
                break;
            case WeaponType.Rocket:
                weapon = new WeaponRocket(40, 8, weaponGo);
                break;
        }
        return weapon;
    }
}

