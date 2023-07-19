using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackToTargetState : IEnemyState{
  private readonly float _damageToApply;
  
  public AttackToTargetState(float damageToApply){
   _damageToApply = damageToApply;
 }

  public Task<StateResult> DoAction(object data){
   var target = dat as Enemy;
   Assert.IsNotNull(target);

   target.DoDamage(_damageToApply);
   return Task.FromResult(new StateResult(EnemyStatesConfiguration.IdleState));
 }
}