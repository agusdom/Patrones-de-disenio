using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : Monobehaviour{
  [SerializeField] private Button _startGameButton;
  [SerializeField] private Button _settingButton;
  [SerializeField] private CanvasGroup _canvasGroup;
  private void Awake(){
  _startGameButton.onClick.AddListener(() =>_mediator.StartGame());
  _settingButton.onClick.AddListener(() => _mediator.MoveToSetting());
 }
  
  public void Configure(MenuMediator menuMediator){
   _mediator = menuMediator
 }
}