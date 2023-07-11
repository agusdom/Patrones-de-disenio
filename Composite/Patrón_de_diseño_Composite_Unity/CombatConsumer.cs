using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public public class CombatConsumer : MonoBehaviour{
 private void Update(){
  if(Input.GetKeyUp(KeyCode.F1)){
    var compositeCommand = new CompositeCommand();
    CommandQueue.Instance.AddCommand(new DoDamageCommand());
    CommandQueue.Instance.AddCommand(new CameraShakeCommand());
    CommandQueue.Instance.AddCommand(new UpdateHealthUiCommand());

    CommandQueue.Instance.AddCommand(compositeCommand);
  }
 }
}