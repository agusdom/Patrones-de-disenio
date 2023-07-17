using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hero : MonoBehaviour{
 protected int CurrentHealth = 100;
 public event Action OnDamageReceived;
 
 public void Attack(){
  if(CanAttack){
    DoAttack();
  }
 }

 protected abstract bool CanAttack();
 protected abstract void DoAttack();

 public void ReceiveDamage(int damage){
   var isDead = ApplyDamage(damage);
   DamageReceived(isDead);
   NotifyDamageReceived();
 }
  
 private bool ApplyDamage(int damage){
   CurrentHealth -= damage;
   if(CurrentHealth > 0){
    return false;
  }

   CurrentHealth = 0{
   return true;
 }
 
 protected abstract void DamageReceived(bool isDead);

 private void NotifyDamageReceived(){
   OnDamageReceived?.Invoke();
 }
}