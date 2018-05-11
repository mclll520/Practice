using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
///  场景状态的3个子类
/// </summary>
public class BattleState : ISenceState
{
    public BattleState(SceneStateController sceneStateController) : base("03BattleState", sceneStateController)
    {
    }

    public override void StateStart()
    {
        GameFacade.Instance.Init();
    }
    public override void StateUpdate()
    {
        if (GameFacade.Instance.IsGameOver)
        {
            //游戏结束 切换到主菜单 
            _controller.SetState(new MainMenuState(_controller));
        }
        GameFacade.Instance.Update();
    }
    public override void StateEnd()
    {
        GameFacade.Instance.Release();
    }
}

