using System;
using System.Collections.Generic;
using UnityEngine;

public enum SoldierTransition
{
    NullTansition = 0,
    SeeEnemy,
    NoEnmey,
    CanAttack
}

public enum SoldierStateID
{
    NullState,
    Idle,
    Chase,
    Attack
}
public abstract class ISoldierState
{
    protected Dictionary<SoldierTransition, SoldierStateID> map = new Dictionary<SoldierTransition, SoldierStateID>();
    protected SoldierStateID stateID;
    protected ICharacter character;
    protected SoldierFSMSytem FSM;

    public ISoldierState(SoldierFSMSytem fsm,ICharacter charac) {
        FSM = fsm;
        character =charac;
    }

    public SoldierStateID StateID { get { return stateID; }}

    public void AddTransition(SoldierTransition trans, SoldierStateID id) {
        if (trans == SoldierTransition.NullTansition)
        {
            Debug.LogError("trans不能为空");return;
        }
        if (id==SoldierStateID.NullState)
        {
            Debug.LogError("id不能为空"); return;
        }
        if (map.ContainsKey(trans))
        {
            Debug.LogError(trans+"trans已经添加上了"); return;
        }
        map.Add(trans, id);
    }

    public void DeleteTransition(SoldierTransition trans) {
        if (map.ContainsKey(trans) == false)
        {
            Debug.LogError("删除转换的条件不存在"+trans); return;
        }
        map.Remove(trans);
    }

    public SoldierStateID GetOutState(SoldierTransition transition) {
        if (map.ContainsKey(transition) ==false)
        {
            return SoldierStateID.NullState;
        }
        else
        {
            return map[transition];
        }
    }

    public virtual void DoBeforEntering() { }
    public virtual void DoBeforLeaving() { }

    public abstract void Reason(List <ICharacter> targets);
    public abstract void Act(List<ICharacter> targets);
}

