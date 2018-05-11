using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

/// <summary>
/// 开发敌人的攻击状态
/// </summary>
public class EnemyAttackState : IEnemyState
{
    public EnemyAttackState(EnemyFSMSystem fsm, ICharacter charac) : base(fsm, charac)
    {
        stateID = EnemyStateID.Attack;
        _attackTimer = _attackTime;
    }

    private float _attackTime = 1;
    private float _attackTimer = 1;

    public override void Act(List<ICharacter> targets)
    {
        if (targets ==null || targets.Count == 0)
        {
            return;
        }
        _attackTimer += Time.deltaTime;
        if (_attackTimer >= _attackTime)
        {
            character.Attack(targets[0]);
            _attackTimer = 0;
        }
    }

    public override void Reason(List<ICharacter> targets)
    {
        if (targets !=null && targets.Count == 0)
        {
            FSM.PerFormTransition(EnemyTransition.LostSoldier);
        }
        else
        {
            float distance = Vector3.Distance(character.position, targets[0].position);
            if (distance > character.atkRange)
            {
                FSM.PerFormTransition(EnemyTransition.LostSoldier);
            }
        }
    }
}

