using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Installer : MonoBehaviour{
 [SerializeField] private HealthView _healthView;

 private Hero _hero;
 
 private void Awake(){
  _hero = new Hero();
  _hero.Subscribe(_healthView);
  _hero.Notify();
 }

 private void Update(){ 
  if(Input.GetKeyUp(KeyCode.Q)){
   _hero.ApplyDamage(10);
  }
 } 
}