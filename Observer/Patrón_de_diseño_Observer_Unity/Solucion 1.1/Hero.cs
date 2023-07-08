using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : IHero{
 
 public int Health{get; private set;}
 private readonly List<Observer> _observer;
 
 public Hero(){
  _observers = new List<Observer>();
  Health = 100;
  Notify();
 }
 
 void Subscribe(Observer observer){
  _observers.Add(observer);
 }

 void UnSubscribe(Observer observer){
  _observers.Remove(observer);
 }

 void Notify(){
   foreach(var observer in _observers){
   observer.Updated(this);
  }
 }
  
 public void ApplyDamage(int damage){
   Health -= damage;
   Notify();
 }
}