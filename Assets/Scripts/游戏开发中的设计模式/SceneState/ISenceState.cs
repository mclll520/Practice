using System;
using System.Collections.Generic;
using System.Text;

//控制场景状态(场景状态的基础接口)
 public class ISenceState
{
    private string _SceneName;
    protected SceneStateController _controller;

    public string SceneName
    {
        get
        {
            return _SceneName;
        }
    }

    public ISenceState(string SceneName,SceneStateController sceneStateController) {
        _SceneName = SceneName;
        _controller = sceneStateController;
    }

    //虚方法(状态切换时调用)
    public virtual void StateStart()
    {

    }
    public virtual void StateEnd()
    {

    }
    public virtual void StateUpdate() {

    }
}

