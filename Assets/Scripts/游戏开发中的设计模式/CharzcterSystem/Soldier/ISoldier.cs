using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class ISoldier : ICharacter
{
    protected SoldierFSMSytem fSMSytem;

    public ISoldier():base(){
        MakeFSM();
    }

    public override void UpdateFSMAI( List <ICharacter> target) {
        fSMSytem.CurrentState.Reason(target);
        fSMSytem.CurrentState.Act(target);
    }

    private void MakeFSM() {
        fSMSytem = new SoldierFSMSytem();
        SoldierIdleState idleState = new SoldierIdleState(fSMSytem, this);
        idleState.AddTransition(SoldierTransition.SeeEnemy, SoldierStateID.Chase);

        SoldierChaseState ChaseState = new SoldierChaseState(fSMSytem, this);
        ChaseState.AddTransition(SoldierTransition.NoEnmey, SoldierStateID.Idle);
        ChaseState.AddTransition(SoldierTransition.CanAttack, SoldierStateID.Attack);

        SoldierAttackState AttackState = new SoldierAttackState(fSMSytem, this);
        AttackState.AddTransition(SoldierTransition.NoEnmey, SoldierStateID.Idle);
        AttackState.AddTransition(SoldierTransition.SeeEnemy, SoldierStateID.Chase);

        fSMSytem.AddState(idleState, ChaseState, AttackState);
    }
    public override void UnderAttack(int damage)
    {
        base.UnderAttack(damage);
        if (_characterAttr.CurrentHP<=0)
        {
            Killed();
        }
    }

    protected abstract void PlaySound();
    protected abstract void PlayEffect();
 
}

