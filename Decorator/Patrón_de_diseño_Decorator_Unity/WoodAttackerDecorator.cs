using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodAttackerDecorator : AttackerDecorator{
 private readonly int _woodDamage;
 
 public class WoodAttackerDecorator : AttackerDecorator{
 private readonly int _woodDamage;
  
 public FireAttackerDecorator(IAttacker attacker,int woodDamage) : base(attacker){
   _woodDamage = woodDamage;
 }

 public override void Attack(IDamageReceiver damageReceiver){
  base.Attack(damageReceiver);
  damageReceiver.ReceiverDamage(_woodDamage,Color.green); 
 }
}