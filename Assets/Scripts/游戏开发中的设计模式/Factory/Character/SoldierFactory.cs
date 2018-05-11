using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


public class SoldierFactory : ICharacterFactory
{
    public ICharacter CreateCharacter<T>(WeaponType weaponType, Vector3 spawnPosition, int lv = 1) where T : ICharacter,new ()
    {
        ICharacter character = new T();
       
        string name ="";
        int MaxHP = 0;
        float MoveSpeed = 0;
        string IocnSprite = "";
        string prefabName = "";
        System.Type t = typeof(T);
        if (t == typeof(SoldierCaptain))
        {
            name = "上尉";
            MaxHP = 100;
            MoveSpeed = 3;
            IocnSprite = "CaptainIcon";
            prefabName = "Soldier1";
        }
        else if (t==typeof(SoldierSergeant))
        {
            name = "中士士兵";
            MaxHP = 90;
            MoveSpeed = 3;
            IocnSprite = "SergeantIcon";
            prefabName = "Soldier3";
        }
        else if (t == typeof(SoldierRookie))
        {
            name = "中士士兵";
            MaxHP = 80;
            MoveSpeed = 2.5f;
            IocnSprite = "RookieIcon";
            prefabName = "Soldier2";
        }
        else
        {
            Debug.LogError("类型" + t + "不属于ISoldier，无法创建战士");
        }
        ICharacterAttr attr = new ICharacterAttr(new SoldierAttrStrategy(), name, MaxHP, MoveSpeed, IocnSprite, prefabName);
        character.attr = attr;

        //创建游戏物体
        //1. 加载  2 实例化 TODO
        GameObject characterGO = FactoryManager.AssetFactory.LoadSoldier(prefabName);
        characterGO.transform.position = spawnPosition;
        character.GameObject = characterGO;

        //添加武器 TODO
        IWeapon weapon = FactoryManager.WeaponFactory.CreateWeapon(weaponType);
        character.weapon = weapon;


        return null;
    }
}

