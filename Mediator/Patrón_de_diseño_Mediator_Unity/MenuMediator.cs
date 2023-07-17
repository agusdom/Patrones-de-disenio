using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMediator : Monobehaviour{
  [SerializeField] private MainMenu _mainMenu;
  [SerializeField] private SettingsMenu _settingMenu;

  private void Awake(){
  _mainMenu.Configure(this);
  _settingMenu.Configure(this);

  _settingsMenu.Hide();
 }
 
  public void StartGame(){
   Debug.Log("¡A jugar!");
 }

  public void MoveToSettings(){
   _mainMenu.Hide();
   _settingsMenu.Show();
 }

  public void GoToMainMenu(){
   _settingsMenu.Hide();
   _mainMenu.Show();
 }
}