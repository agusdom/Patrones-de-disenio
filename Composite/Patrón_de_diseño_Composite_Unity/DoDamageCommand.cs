using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public public class DoDamageCommand : ICommand{
  public async Task Execute(){
  Debug.Log("Damage");
  await Task.Delay(TimeSpan.FromSeconds(2));
 }
}