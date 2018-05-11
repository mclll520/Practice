using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

/// <summary>
/// 开发敌人的追击状态
/// </summary>
public class EnemyChaseState : IEnemyState
{
    public EnemyChaseState(EnemyFSMSystem fsm, ICharacter charac) : base(fsm, charac)
    {
        stateID = EnemyStateID.Chase;
    }
    private Vector3 _targrtPosition;
    public override void DoBeforEntering()
    {
        _targrtPosition = GameFacade.Instance.GetEnemyTargetPosition();
    }

    public override void Act(List<ICharacter> targets)
    {
        if (targets != null && targets.Count > 0)
        {
            character.MoveTo(targets[0].position);
        }
        else {
            character.MoveTo(_targrtPosition);
        }
    }

    public override void Reason(List<ICharacter> targets)
    {
        if (targets != null && targets.Count > 0)
        {
            float distance = Vector3.Distance(character.position, targets[0].position);
            if (distance <= character.atkRange)
            {
                FSM.PerFormTransition(EnemyTransition.CanAttack);
            }
           
        }
    }
}

