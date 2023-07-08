using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu2 : MonoBehaviour{
 [SerializeField] private Button _loadNextSceneButton;
 private List<ICommand> _loadNextSceneCommands;

 [SerializeField] private CanvasGroup _canvasGroup2;

private void Awake(){
  _loadNextSceneButton.onClick.AddListener(LoadNextMenu);
 }

private void LoadNextScene(){
  forearch(var command in _loadNextSceneCommands){
    CommandQueue.Instance.AddCommand(command);
  }
 }

 public void Configure(List<ICommand> showNextMenuCommands){
  _loadNextSceneCommands = loadNextSceneCommands
 }
}