using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public public class CameraShakeCommand : ICommand{
  public async Task Execute(){
  Debug.Log("Camera shakeeeee");
  await Task.Delay(TimeSpan.FromSeconds(1));
 }
}