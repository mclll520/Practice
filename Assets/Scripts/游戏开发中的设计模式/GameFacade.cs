using System;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

/// <summary>
/// 外观模式  中介者
/// </summary>
public class GameFacade
{
    private static GameFacade _instance = new GameFacade();
    private bool _IsGameOver = false;

    public bool IsGameOver
    {
        get{return _IsGameOver; }
    }

    public static GameFacade Instance
    {
        get{return _instance;}
    }
    private GameFacade() { }

    private ArchievementSystem archievementSystem;         //成就系统
    private CampSystem campSystem;                         //兵营系统
    private CharzcterSystem charzcterSystem;               //品质系统
    private EnergySystem energySystem;                     //能量系统
    private GameEventSystem gameEventSystem;               //游戏事件系统
    private StageSystem stageSystem;                       //游戏关卡系统

    private CampInfoUI campInfoUI;               //兵营界面
    private GamePauseUI gamePauseUI;             //游戏暂停
    private GameStateInfoUI gameStateInfoUI;     //游戏状态
    private SoldierInfoUI soldierInfoUI;         //战士信息

    //初始化
    public void Init() {
        archievementSystem = new ArchievementSystem();
        campSystem = new CampSystem();
        charzcterSystem = new CharzcterSystem();
        energySystem = new EnergySystem();
        gameEventSystem = new GameEventSystem();
        stageSystem = new StageSystem();

        campInfoUI = new CampInfoUI();
        gamePauseUI = new GamePauseUI();
        gameStateInfoUI = new GameStateInfoUI();
        soldierInfoUI = new SoldierInfoUI();

        archievementSystem.Init();
        campSystem.Init();
        charzcterSystem.Init();
        energySystem.Init();
        gameEventSystem.Init();
        stageSystem.Init();

        campInfoUI.Init(); 
        gamePauseUI.Init();
        gameStateInfoUI.Init();
        soldierInfoUI.Init();
    }
    //更新
    public void Update() {
        archievementSystem.Update();
        campSystem.Update();
        charzcterSystem.Update();
        energySystem.Update();
        gameEventSystem.Update();
        stageSystem.Update();

        campInfoUI.Update();
        gamePauseUI.Update();
        gameStateInfoUI.Update();
        soldierInfoUI.Update();
    }
    //结束
    public void Release() {
        archievementSystem.Release();
        campSystem.Release();
        charzcterSystem.Release();
        energySystem.Release();
        gameEventSystem.Release();
        stageSystem.Release();

        campInfoUI.Release();
        gamePauseUI.Release();
        gameStateInfoUI.Release();
        soldierInfoUI.Release();
    }

    public Vector3 GetEnemyTargetPosition() {
        //TODO
        return Vector3.zero;
    }
}
