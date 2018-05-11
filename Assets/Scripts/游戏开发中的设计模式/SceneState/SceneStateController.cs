using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// 控制状态转变的
/// </summary>
public class SceneStateController
{
    private ISenceState _state;
    private AsyncOperation _ao;
    private bool _ISRunStatr = false;

    public void SetState(ISenceState state,bool isLoadScene = true) {
        if (_state != null)
        {
            _state.StateEnd();//让上一个场景状态做一下清理工作
        }
        _state = state;
        if (isLoadScene)
        {
            _ao = SceneManager.LoadSceneAsync(_state.SceneName);//异步加载
            _ISRunStatr = false;
        }
        else {
            _state.StateStart();
            _ISRunStatr = true;
        }
     
     
    }

    public void StateUpdate() {
        if (_ao!=null && _ao.isDone ==false)
        {
            return;
        }

        if (_ISRunStatr == false && _ao != null && _ao.isDone == true )
        {
            _state.StateStart();
            _ISRunStatr = true;
        }

        if (_state!=null)
        {
            _state.StateUpdate();
        }
    }
}

