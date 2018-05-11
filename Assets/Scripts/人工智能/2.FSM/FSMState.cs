using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Transition
{
    NullTransition =0,
    SeePlayer,
    LostPlayer
}

public enum StateID
{
    NullStateID=0,
    Patrol,
    Chases
}

public abstract class FSMState  {

    protected StateID stateID;
    public StateID ID { get { return stateID; } }

    protected Dictionary<Transition, StateID> map = new Dictionary<Transition, StateID>();

    protected FSMSystem fsm;
    //创建构造函数
    public FSMState(FSMSystem fsm) {
        this.fsm = fsm;
    }
    //添加
    public void AddTransition(Transition trans, StateID state) {
        if (trans == Transition.NullTransition)
        {
            Debug.LogError("不允许NullTransition");return;
        }
        if (state == StateID.NullStateID)
        {
            Debug.LogError("不允许NullStateID");return;
        }
        if (map.ContainsKey(trans))
        {
            Debug.LogError("添加得转换的条件" + trans + "已经存在与map中");return;
        }
        map.Add(trans, state);
    }

    //删除
    public void DeleteTransition(Transition trans) {
        if (trans == Transition.NullTransition)
        {
            Debug.LogError("不允许NullTransition"); return;
        }
        if (!map.ContainsKey(trans))
        {
            Debug.LogError("删除得转换的条件" + trans + "不存在与map中"); return;
        }
        map.Remove(trans);
    }

    public StateID GetOutputState(Transition trans) {
        if (map.ContainsKey(trans))
        {
            return map[trans];
        }
        return StateID.NullStateID;
    }

    //虚方法
    //进入状态
    public virtual void DoBeforeEntering() { }
    //离开状态
    public virtual void DoAfterLeaving() { }

    //抽象方法
    public abstract void Act(GameObject npc);
    public abstract void Reason(GameObject npc);//判断转换条件
}
