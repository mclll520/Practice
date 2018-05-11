using System;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    Gun,
    Rifle,
    Rocket
}
public abstract class IWeapon
{
    protected int atk;
    protected float atkRange;  //攻击范围
    protected int atkPluesValue;//暴击几率

    protected GameObject gameObject;
    protected ParticleSystem particle;
    protected LineRenderer line;
    protected Light light;
    protected AudioSource audio;

    protected ICharacter _owner;
    protected float effectDisplayTime = 0;  //特效显示时间

    public float AtkRange { get { return atkRange;} }

    public int Atk { get { return atk; } }

    public ICharacter owner { set { _owner = value; } }

    public IWeapon(int atks, float atkRang, GameObject game) {
        atk = atks;
        atkRange = atkRang;
        gameObject = game;
        Transform effect = gameObject.transform.Find("Effect");
        particle = effect.GetComponent<ParticleSystem>();
        line = effect.GetComponent<LineRenderer>();
        light = effect.GetComponent<Light>();
        audio = effect.GetComponent<AudioSource>();
    }

    public void Update() {
        if (effectDisplayTime > 0)
        {
            effectDisplayTime -= Time.deltaTime;
            if (effectDisplayTime <= 0)
            {
                DisableEffect();
            }
        }
    }

  
    public void Fire(Vector3 targetposition) {

        //显示枪口特效
        PlayMuzzleEffect();

        //显示子弹轨迹
        PlayBulletEffect(targetposition);

        //特效显示时间
        SetDisPlayTime();

        //播放声音
        PlaySound();
    }
    protected abstract void SetDisPlayTime();

    protected virtual void PlayMuzzleEffect() {
        particle.Stop();
        particle.Play();
        light.enabled = true;
    }

    protected abstract void PlayBulletEffect(Vector3 targetposition);

    protected void DoPlayBulletEffect(float width, Vector3 targetposition)
    {
        line.enabled = true;
        line.startWidth = width;
        line.endWidth = width;
        line.SetPosition(0, gameObject.transform.position);
        line.SetPosition(1, targetposition);
    }

    protected abstract void PlaySound();

    protected virtual void DoPlaySound(string clipName)
    {
        AudioClip clip = null; //TODO
        audio.clip = clip;
        audio.Play();
    }

    private void DisableEffect()
    {
        line.enabled = false;
        light.enabled = false;
    }

}
