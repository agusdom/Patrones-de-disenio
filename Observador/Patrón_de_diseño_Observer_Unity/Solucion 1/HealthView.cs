using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthView : MonoBehaviour, Observer{
 [SerializeField] private TextMeshProUGUI _health;

 public void Updated(Subject subject){
  if(subject is Hero hero){
    _health.SetText(hero.Health.ToString());
  }
 }
}