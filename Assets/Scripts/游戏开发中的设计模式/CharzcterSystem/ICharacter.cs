using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class ICharacter
{
    protected ICharacterAttr _characterAttr;

    private GameObject _gameObject;
    protected NavMeshAgent _avMeshAgent;
    protected AudioSource _audioSource;
    protected Animation _animation;
    protected IWeapon _iWeapon;           //定义武器对象
    
    public IWeapon weapon { set {
            _iWeapon = value;
            _iWeapon.owner = this;
           // Transform  weapon = _gameObject.transform.Find("")
        } }

    public Vector3 position {
        get {
            if (_gameObject == null)
            {
                Debug.LogError("_gameObject为空");
                return Vector3.zero;
            }
            return _gameObject.transform.position;
        }
    }

    public float atkRange {
        get {
            return _iWeapon.AtkRange;
        }
    }

    public ICharacterAttr attr { set { _characterAttr = value; } }

    public GameObject GameObject
    {
        set
        {
            _gameObject = value;
            _avMeshAgent = _gameObject.GetComponent<NavMeshAgent>();
            _audioSource = _gameObject.GetComponent<AudioSource>();
            _animation = _gameObject.GetComponent<Animation>();
        }
    }


    //开火的功能
    public void Attack(ICharacter target) {
        _iWeapon.Fire(target.position);
        _gameObject.transform.LookAt(target.position);
        PlayAnim("attack");
        target.UnderAttack(_iWeapon.Atk + _characterAttr.critValue);
    }
    public virtual void UnderAttack(int damage) {
        _characterAttr.TakeDamage(damage);

        //被攻击攻击的效果  视效

        //死亡效果 音效 
    }
    public void Killed() {
        //TODO
    }

    public void PlayAnim(string animname) {
        _animation.CrossFade(animname);
    }
    public void MoveTo(Vector3 targetPosition) {
        _avMeshAgent.SetDestination(targetPosition);
    }

    public void Update() {
        _iWeapon.Update();
    }

    public abstract void UpdateFSMAI(List<ICharacter> target);

    protected void DoPLayEffect(string effectName)
    {
        //第一步 加载特效 TODO
        GameObject effectGo;
        //控制销毁 TODO

    }

    protected void DoPlaySound(string soundName)
    {
        AudioClip clip = null; //TODO
        _audioSource.clip = clip;
        _audioSource.Play();
    }
}

