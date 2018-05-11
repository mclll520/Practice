using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 场景状态的3个子类
/// </summary>
public class StartState : ISenceState
{
    public StartState(SceneStateController sceneStateController) : base("01StartState", sceneStateController)
    {

    }

    private Image _logo;
    private float _smoothingSpeed = 1;
    private float _waitTime = 2;
    public override void StateStart()
    {
        _logo = GameObject.Find("Logo").GetComponent<Image>();
        _logo.color = Color.black;
    }

    public override void StateUpdate()
    {
        _logo.color = Color.Lerp(_logo.color, Color.white, _smoothingSpeed * Time.deltaTime);
        _waitTime -= Time.deltaTime;
        if (_waitTime <=0)
        {
            _controller.SetState(new MainMenuState(_controller));
        }
    }
}

