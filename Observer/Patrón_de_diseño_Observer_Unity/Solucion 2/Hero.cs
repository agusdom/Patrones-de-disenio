using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : IHero{
 
 public int Health{get; set;}
 private event Action<int> OnHealthUpdated;
 
 public Hero(){
  Health = 100;
  Notify();
 }
 
 void Notify(){
   OnHealthUpdated?.Invoke(Health);
 }
  
 public void ApplyDamage(int damage){
   Health -= damage;
   Notify();
 }
}