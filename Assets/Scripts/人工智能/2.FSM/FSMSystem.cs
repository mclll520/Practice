using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 存储管理状态机里面所有的状态
/// </summary>
public class FSMSystem {

    private Dictionary<StateID, FSMState> states = new Dictionary<StateID, FSMState>();
    //当前状态
    private StateID currentStateID;
    private FSMState currentState;

    public void Update(GameObject npc) {
        currentState.Act(npc);
        currentState.Reason(npc);
    }


    //添加状态
    public void AddState(FSMState s) {
        if (s==null)
        {
            Debug.LogError("FSMState不能为空");return;
        }
        if (currentState == null)
        { 
            currentState = s;
            currentStateID = s.ID;
        }
        if (states.ContainsKey(s.ID))
        {
            Debug.LogError("状态" + s.ID + "已经存在，无法再次添加");return;
        }
        states.Add(s.ID,s);
    }

    //删除状态
    public void DeleteState(StateID id)
    {
        if (id == StateID.NullStateID)
        {
            Debug.LogError("无法删除该状态"); return;
        }
        if (!states.ContainsKey(id))
        {
            Debug.LogError("状态" + id+ "不存在，无法删除"); return;
        }
        states.Remove(id);
    }
    //执行转换条件
    public void PerformTransition(Transition trans) {
        if (trans == Transition.NullTransition)
        {
            Debug.LogError("无法执行空的转换条件");return;
        }
        StateID id = currentState.GetOutputState(trans);
        if (id==StateID.NullStateID)
        {
            Debug.LogWarning("当前状态" + currentStateID + "无法根据转换条件" + trans + "发生转换");return;
        }
        if (states.ContainsKey(id)==false)
        {
            Debug.LogError("在状态机里面不存在状态" + id + ",无法进项状态转换！");return;
        }
        FSMState state = states[id];
        currentState.DoAfterLeaving();
        currentState = state;
        currentStateID = id;
        currentState.DoBeforeEntering();
    }
}
