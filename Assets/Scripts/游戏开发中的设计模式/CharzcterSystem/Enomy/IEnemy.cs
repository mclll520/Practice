using System;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 构建敌人的有限状态机
/// </summary>
public abstract class IEnemy : ICharacter
{
    EnemyFSMSystem FSMSystem;

    public IEnemy() {

    }

    public override void UpdateFSMAI(List <ICharacter> targets) {
        FSMSystem.CurrentState.Reason(targets);
        FSMSystem.CurrentState.Act(targets);
    }

    private void MakeFSM() {
        FSMSystem = new EnemyFSMSystem();

        EnemyChaseState chaseState = new EnemyChaseState(FSMSystem, this);
        chaseState.AddTransition(EnemyTransition.CanAttack, EnemyStateID.Attack);

        EnemyAttackState attackState = new EnemyAttackState(FSMSystem, this);
        attackState.AddTransition(EnemyTransition.LostSoldier, EnemyStateID.Chase);

        FSMSystem.AddState(chaseState, attackState);
    }
    public override void UnderAttack(int damage)
    {
        base.UnderAttack(damage);
        PlayEffect();
        if (_characterAttr.CurrentHP <=0)
        {
            Killed();
        }
    }
    protected abstract void PlayEffect();
   
    
}

