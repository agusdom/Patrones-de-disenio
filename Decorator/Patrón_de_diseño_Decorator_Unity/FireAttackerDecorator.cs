using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAttackerDecorator : AttackerDecorator{
 private readonly int _fireDamage;

public class FireAttackerDecorator : AttackerDecorator{
 private readonly int _fireDamage;
  
 public FireAttackerDecorator(IAttacker attacker,int fireDamage) : base(attacker){
   _fireDamage = fireDamage;
 }

 public override void Attack(IDamageReceiver damageReceiver){
  base.Attack(damageReceiver);
  damageReceiver.ReceiverDamage(_fireDamage,Color.red); 
 }
}