using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public enum EnemyTransition
{
    NullTansition = 0,
    CanAttack,
    LostSoldier
}

public enum EnemyStateID
{
    NullState,
    Chase,
    Attack
}

public abstract class IEnemyState
{
    protected Dictionary<EnemyTransition, EnemyStateID> map = new Dictionary<EnemyTransition, EnemyStateID>();
    protected EnemyStateID stateID;
    protected ICharacter character;
    protected EnemyFSMSystem FSM;

    public IEnemyState(EnemyFSMSystem fsm, ICharacter charac)
    {
        FSM = fsm;
        character = charac;
    }

    public EnemyStateID StateID { get { return stateID; } }

    public void AddTransition(EnemyTransition trans, EnemyStateID id)
    {
        if (trans == EnemyTransition.NullTansition)
        {
            Debug.LogError("trans不能为空"); return;
        }
        if (id == EnemyStateID.NullState)
        {
            Debug.LogError("id不能为空"); return;
        }
        if (map.ContainsKey(trans))
        {
            Debug.LogError(trans + "trans已经添加上了"); return;
        }
        map.Add(trans, id);
    }

    public void DeleteTransition(EnemyTransition trans)
    {
        if (map.ContainsKey(trans) == false)
        {
            Debug.LogError("删除转换的条件不存在" + trans); return;
        }
        map.Remove(trans);
    }

    public EnemyStateID GetOutState(EnemyTransition transition)
    {
        if (map.ContainsKey(transition) == false)
        {
            return EnemyStateID.NullState;
        }
        else
        {
            return map[transition];
        }
    }

    public virtual void DoBeforEntering() { }
    public virtual void DoBeforLeaving() { }

    public abstract void Reason(List<ICharacter> targets);
    public abstract void Act(List<ICharacter> targets);
}

