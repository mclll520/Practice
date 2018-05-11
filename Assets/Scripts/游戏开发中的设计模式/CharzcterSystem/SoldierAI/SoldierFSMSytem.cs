using System;
using System.Collections.Generic;
using UnityEngine;


public class SoldierFSMSytem
{
    private List<ISoldierState> _state = new List<ISoldierState>();
    //当前状态
    private ISoldierState _currentState;
    public ISoldierState CurrentState{get{ return _currentState; } }

    public void AddState(params ISoldierState[] states) {
        foreach (ISoldierState s in states)
        {
            AddState(s);
        }
    }

    public void AddState(ISoldierState state) {
        if (state == null)
        {
            Debug.LogError("要添加的状态为空");return;
        }
        if (_state.Count == 0)
        {
            _state.Add(state);
            _currentState = state;
            return;
        }
        foreach (ISoldierState s in _state)
        {
            if (s.StateID == state .StateID)
            {
                Debug.LogError("要添加的状态已经添加"+s.StateID); return;
            }
        }
        _state.Add(state);
    }

    public void DeleteState(SoldierStateID stateID)
    {
        if (stateID == SoldierStateID.NullState)
        {
            Debug.LogError("要删除的状态为空" + stateID);return;
        }
        foreach (ISoldierState s in _state)
        {
            if (s.StateID == stateID)
            {
                _state.Remove(s);
                return;
            }
        }
        Debug.LogError("要删除的状态不存在集合中" + stateID);
    }

    //执行转变的
    public void PerFormTransition(SoldierTransition trans) {
        if (trans ==SoldierTransition.NullTansition)
        {
            Debug.LogError("要执行转变的条件为空" + trans); return;
        }
        SoldierStateID stateID = _currentState.GetOutState(trans);
        if (stateID == SoldierStateID.NullState)
        {
            Debug.LogError("在执行转条件下，没有对应的转换状态" + trans);return;
        }
        foreach (ISoldierState s in _state)
        {
            _currentState.DoBeforLeaving();
            _currentState = s;
            _currentState.DoBeforEntering();
            return;
        }
    }
}

