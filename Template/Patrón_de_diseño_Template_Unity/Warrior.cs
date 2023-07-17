using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Hero{
 protected override bool CanAttack(){
   if(CurrentHealth >= 30){
    return true;
  }
   Debug.Log("Estoy muy debil, no puedo atacar);
   return false;
 }

 protected override void DoAttack(){
   Debug.Log("Ya veras el mazazo que te voy a dar....");
 }

 protected override void DamageReceived(bool isDead){
   Debug.Log("Bah! Eso no es nada");
   if(isDead){
    Debug.Log("O igual si...");
  }
 }
}