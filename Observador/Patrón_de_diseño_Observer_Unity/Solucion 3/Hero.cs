using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : IHero{
 
 public ReactiveProperty<int> Health {get;}

 
 public Hero(){
  Health = new IntReactiveProperty(100);
 }

 public void ApplyDamage(int damage){
   Health.Value -= damage;
 }
}