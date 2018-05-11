using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


public static class FactoryManager
{
    private static IAssetFactory _assetFactory = null;
    private static ICharacterFactory _SoldierFactory = null;
    private static ICharacterFactory _EnemyFactory = null;
    private static IWeaponFactory _weaponFactory = null;

    public static IAssetFactory AssetFactory
    {
        get
        {
            if (_assetFactory ==null)
            {
                _assetFactory = new ResourcesAssetFactory();
            }
            return _assetFactory;
        }
    }

    public static ICharacterFactory SoldierFactory
    {
        get
        {
            if (_SoldierFactory == null)
            {
                _SoldierFactory = new SoldierFactory();
            }
            return _SoldierFactory;
        }
    }

    public static ICharacterFactory EnemyFactory
    {
        get
        {
            if (_EnemyFactory == null)
            {
                _EnemyFactory = new EnemyFactory();
            }
            return _EnemyFactory;
        }
    }

    public static IWeaponFactory WeaponFactory
    {
        get
        {
            if (_weaponFactory == null)
            {
                _weaponFactory = new WeaponFactory();
            }
            return _weaponFactory;
        }
    }
}

