using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


public class SoldierChaseState : ISoldierState
{
    public SoldierChaseState(SoldierFSMSytem fsm, ICharacter c) : base(fsm, c)
    {
        stateID = SoldierStateID.Chase;
    }

    public override void Act(List<ICharacter> targets)
    {
        if (targets != null && targets.Count > 0)
        {
            character.MoveTo(targets[0].position);
        }
    }

    public override void Reason(List<ICharacter> targets)
    {
         if (targets != null || targets.Count == 0)
        {
            FSM.PerFormTransition(SoldierTransition.NoEnmey);
            return;
        }
        float distance = Vector3.Distance(targets[0].position, character.position);
        if (distance <= character.atkRange)
        {
            FSM.PerFormTransition(SoldierTransition.CanAttack);
        }
    }
}

