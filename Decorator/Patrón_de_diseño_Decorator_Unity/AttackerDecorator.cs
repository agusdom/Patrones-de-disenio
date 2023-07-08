using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackerDecorator : IAttacker{
 private readonly IAttacker _attakcer;
 
 protected AttackerDecorator(IAttacker attacker){
  _attacker = attacker;
 }

 public virtual void Attack(IDamageReceiver damageReceiver){
   _attacker.Attack(damageReceiver);
 }
}


