using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public public class UpdateHealthUiCommand : ICommand{
  public async Task Execute(){
  Debug.Log("Update UI");
  await Task.Delay(TimeSpan.FromSeconds(1));
 }
}