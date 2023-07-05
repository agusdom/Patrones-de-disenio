using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHero{
  int Health {get;}
  void Subscribe(Observer observer);
  void UnSubscribe(Observer observer);
  void Notify();
}