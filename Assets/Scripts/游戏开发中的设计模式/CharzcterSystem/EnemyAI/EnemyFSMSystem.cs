using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

/// <summary>
/// 开发敌人的有限状态机
/// </summary>
public class EnemyFSMSystem
{
    private List<IEnemyState> _state = new List<IEnemyState>();
    //当前状态
    private IEnemyState _currentState;
    public IEnemyState CurrentState { get { return _currentState; } }

    public void AddState(params IEnemyState[] states)
    {
        foreach (IEnemyState s in states)
        {
            AddState(s);
        }
    }

    public void AddState(IEnemyState state)
    {
        if (state == null)
        {
            Debug.LogError("要添加的状态为空"); return;
        }
        if (_state.Count == 0)
        {
            _state.Add(state);
            _currentState = state;
            _currentState.DoBeforEntering();
            return;
        }
        foreach (IEnemyState s in _state)
        {
            if (s.StateID == state.StateID)
            {
                Debug.LogError("要添加的状态已经添加" + s.StateID); return;
            }
        }
        _state.Add(state);
    }

    public void DeleteState(EnemyStateID stateID)
    {
        if (stateID == EnemyStateID.NullState)
        {
            Debug.LogError("要删除的状态为空" + stateID); return;
        }
        foreach (IEnemyState s in _state)
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
    public void PerFormTransition(EnemyTransition trans)
    {
        if (trans == EnemyTransition.NullTansition)
        {
            Debug.LogError("要执行转变的条件为空" + trans); return;
        }
        EnemyStateID stateID = _currentState.GetOutState(trans);
        if (stateID == EnemyStateID.NullState)
        {
            Debug.LogError("在执行转条件下，没有对应的转换状态" + trans); return;
        }
        foreach (IEnemyState s in _state)
        {
            _currentState.DoBeforLeaving();
            _currentState = s;
            _currentState.DoBeforEntering();
            return;
        }
    }
}

