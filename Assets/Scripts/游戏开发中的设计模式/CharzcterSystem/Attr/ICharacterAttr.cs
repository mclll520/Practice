using System;
using System.Collections.Generic;
using System.Text;


public class ICharacterAttr
{
    protected string _name;
    protected int _MaxHP;
    protected float _MoveSpeed;
    protected string _IocnSprite;
    protected string _prefabName;

    private int _currentHP;  //当前血量
    protected int _lv;

    protected float _critRate;//0-1暴击率、
    protected int _dmgDescvalue;
    public ICharacterAttr(IAttrStrategy strategy,string name,int maxHP,float moveSpeed,string iconSprite,string prefabName) {
        _name = name;
        _MaxHP = maxHP;
        _MoveSpeed = moveSpeed;
        _IocnSprite = iconSprite;
        _prefabName = prefabName;

        _attrStrategy = strategy;
        _dmgDescvalue = _attrStrategy.GetDmgDescValue(_lv);
        _currentHP = _MaxHP + _attrStrategy.GetExtraHPValue(_lv);
    }

    public ICharacterAttr(IAttrStrategy strategy)
    {
        this.strategy = strategy;
    }

    //增加的最大血量  抵御得伤害值 暴击增加的伤害 

    protected IAttrStrategy _attrStrategy;
    private IAttrStrategy strategy;

    public int critValue { get { return _attrStrategy.GetCritDmgValue(_critRate); } }

    public int CurrentHP { get { return _currentHP; }  }

    public void TakeDamage(int damage) {
        damage -= _dmgDescvalue;
        if (damage < 5)
        {
            damage = 5;
        }
        _currentHP -= damage;
    }


}

