using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


public class SoldierAttackState : ISoldierState
{
    public SoldierAttackState(SoldierFSMSytem fsm,ICharacter c) : base(fsm,c)
    {
        stateID = SoldierStateID.Attack;
        _attackTimer = _attackTime;
    }

    private float _attackTime = 1;
    private float _attackTimer = 1;


    public override void Act(List<ICharacter> targets)
    {
        if (targets == null || targets.Count == 0)
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
        if (targets == null || targets.Count == 0)
        {
            FSM.PerFormTransition(SoldierTransition.NoEnmey);
            return;
        }
        float distance = Vector3.Distance(character.position, targets[0].position);
        if (distance > character.atkRange)
        {
            FSM.PerFormTransition(SoldierTransition.SeeEnemy);
        }
    }
}

