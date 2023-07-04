using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBattleConsumer : MonoBehaviour{
 [SerializeField] private BattleFacade _battleFacade;

 private void Update(){
  if(Input.GetKeyUp(KeyCode.F2)){
   _battleFacade.EndBattle();
  }
 }
}