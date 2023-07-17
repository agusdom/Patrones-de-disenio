using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : Monobehaviour{
  [SerializeField] private Button _backButton;
  [SerializeField] private CanvasGroup _canvasGroup;

  private void Awake(){
  _backButton.onClick.AddListener(() =>_mediator.GoToMainMenu());
  
 }
  
  public void Configure(MenuMediator menuMediator){
   _mediator = menuMediator
 }

  public void Hide(){
   _canvasGroup.DOFade(0.0f,0.5f);
 }

  public void Show(){
   _canvasGroup.DOFade(1.0f,0.5f);
 }
}