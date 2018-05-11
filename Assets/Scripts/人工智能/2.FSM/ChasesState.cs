using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasesState : FSMState {

    private Transform playerTransform;

    public ChasesState(FSMSystem fsm) : base(fsm) {
        stateID = StateID.Chases;
        playerTransform = GameObject.Find("Player").transform;
    }

    public override void Act(GameObject npc)
    {
        npc.transform.LookAt(playerTransform.position);
        npc.transform.Translate(Vector3.forward * Time.deltaTime * 2);
    }

    public override void Reason(GameObject npc)
    {
        if (Vector3.Distance(playerTransform.position, npc.transform.position) > 6)
        {
            fsm.PerformTransition(Transition.LostPlayer);
        }
    }

}
