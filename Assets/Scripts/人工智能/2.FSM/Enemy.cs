using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private FSMSystem fsm;


	void Start () {
        InitFSM();

    }

    //初始化
    void InitFSM()
    {
        fsm = new FSMSystem();
        FSMState patrolState = new PatronsState(fsm);
        patrolState.AddTransition(Transition.SeePlayer, StateID.Chases);

        FSMState chaseState = new ChasesState(fsm);
        chaseState.AddTransition(Transition.LostPlayer, StateID.Patrol);

        fsm.AddState(patrolState);
        fsm.AddState(chaseState);
    }

	void Update () {
        //更新状态机
        fsm.Update(this.gameObject);
	}
}
