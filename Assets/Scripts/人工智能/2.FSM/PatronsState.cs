using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 巡逻状态
/// </summary>
public class PatronsState : FSMState
{
    //路径点
    private List<Transform> path = new List<Transform>();
    private int index = 0;
    private Transform playerTransform;

    public PatronsState(FSMSystem fsm) : base(fsm) {
        stateID = StateID.Patrol;
        Transform pathTransform = GameObject.Find("Path").transform;
        Transform[] childer = pathTransform.GetComponentsInChildren<Transform>();
        foreach (Transform child in childer)
        {
            if (child != pathTransform)
            {
                path.Add(child);
            }
        }
        playerTransform = GameObject.Find("Player").transform;
    }

    public override void Act(GameObject npc)
    {
        npc.transform.LookAt(path[index].position);
        npc.transform.transform.Translate(Vector3.forward * Time.deltaTime * 3);
        if (Vector3.Distance(npc.transform.position,path[index].position)<1)
        {
            index++;
            index %= path.Count;
        }
    }

    public override void Reason(GameObject npc)
    {
        if (Vector3.Distance(playerTransform.position,npc.transform.position )<3)
        {
            fsm.PerformTransition(Transition.SeePlayer);
        }
    }
}
