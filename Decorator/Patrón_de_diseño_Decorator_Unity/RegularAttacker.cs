using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularAttacker : IAttacker{
 
 private readonly int _damage;

 public void RegularAttacker(int damage){
   _damage = damage;
 }

 public void Attack(IDamageReceiver damageReceiver){
  damageReceiver.ReceiveDamage(_damage, Color.white);
 }
}
