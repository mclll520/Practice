using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

/// <summary>
///  场景状态的3个子类
/// </summary>
public class MainMenuState : ISenceState
{
    public MainMenuState(SceneStateController sceneStateController) : base("02MainMenuState", sceneStateController)
    {

    }

    public override void StateStart()
    {
        GameObject.Find("StarrtButton").GetComponent<Button>().onClick.AddListener(OnStartButtonOnClick);
    }

    private void OnStartButtonOnClick()
    {
        _controller.SetState(new BattleState(_controller));
    }
}

