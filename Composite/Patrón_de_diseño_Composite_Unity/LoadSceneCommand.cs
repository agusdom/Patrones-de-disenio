using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneCommand : ICommand{
  private readonly String _sceneName;

  public LoadSceneCommand(String sceneName){
   _sceneName = sceneName;
 }
 
 public async Task Execute(){
  var asyncOperation = SceneManager.LoadSceneAsync(_sceneName);
  while(!asyncOperation.isDone){
    await Task.Yield();
  }
 }
}