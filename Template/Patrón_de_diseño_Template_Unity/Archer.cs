using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Hero{
 protected override bool CanAttack(){
    return true;
  }
 }

 protected override void DoAttack(){
   Debug.Log("Come flechas!!!");
 }

 protected override void DamageReceived(bool isDead){
   if(isDead){
    Debug.Log("Me muerooooo");
    return;
  }
   Debug.Log("Pues vale");
 }
}