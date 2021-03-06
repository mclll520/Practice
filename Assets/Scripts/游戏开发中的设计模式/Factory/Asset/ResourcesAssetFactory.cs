﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


public class ResourcesAssetFactory : IAssetFactory
{
    private const string SoldierPath = "IAssetFactory/Soldier/";
    private const string EnemyPath = "IAssetFactory/Enemy/";
    private const string WeaponPath = "Weapons/";
    private const string EffectPath = "Effects/";
    private const string AudioPath = "Audios/";
    private const string SpritePath = "Sprites/";

    public AudioClip LoadAuioClip(string name)
    {
        return LoadAsset(AudioPath + name) as AudioClip;
    }

    public GameObject LoadEffect(string name)
    {
        return InstantiateGameObject(EffectPath + name);
    }

    public GameObject LoadEnemy(string name)
    {
        return InstantiateGameObject(EnemyPath + name);
    }

    public GameObject LoadSoldier(string name)
    {
        return InstantiateGameObject(SoldierPath + name);
    }

    public Sprite LoadSprite(string name)
    {
        return LoadAsset(SpritePath + name) as Sprite;
    }

    public GameObject LoadWeapon(string name)
    {
        return InstantiateGameObject(WeaponPath + name);
    }

    private GameObject InstantiateGameObject(string path) {
        UnityEngine.Object o = Resources.Load(path);
        if (o==null)
        {
            Debug.LogError("无法加载路劲" + path); return null;
        }
        return UnityEngine.GameObject.Instantiate(o) as GameObject;
    }

    private UnityEngine.Object LoadAsset(string path) {
        UnityEngine.Object o = Resources.Load(path);
        if (o == null)
        {
            Debug.LogError("无法加载路劲" + path); return null;
        }
        return o;
    }
}

