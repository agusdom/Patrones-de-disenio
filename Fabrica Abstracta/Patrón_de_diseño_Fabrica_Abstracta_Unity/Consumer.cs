using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumer : MonoBehaviur{
  private BattleFactory currentBattleFactory;
  
  public void Configure(BattleFactory battleFactory){
   currentBattleFactory = battleFactory;
}

  public void Update(){
  if(Input.GetKeyUp(KeyCode.F1)){
   currentBattleFactory.CreateHero("Warrior");
 }
  if(Input.GetKeyUp(KeyCode.F2)){
   currentBattleFactory.CreateHero("Paladin");
 }
  if(Input.GetKeyUp(KeyCode.F3)){
   currentBattleFactory.CreateWeapon("Sword");
 }
  if(Input.GetKeyUp(KeyCode.F4)){
   currentBattleFactory.CreateWeapon("Shield");
 }
}