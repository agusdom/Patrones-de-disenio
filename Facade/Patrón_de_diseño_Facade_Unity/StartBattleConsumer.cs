using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBattleConsumer : MonoBehaviour{
 [SerializeField] private BattleFacade _battleFacade;

 private void Update(){
  if(Input.GetKeyUp(KeyCode.F1)){
   _battleFacade.StartBattle();
  }
 }
}