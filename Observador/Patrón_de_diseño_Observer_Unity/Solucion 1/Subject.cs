using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Subject{
  void Subscribe(Observer observer);
  void UnSubscribe(Observer observer);
  void Notify();
}