using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthView : MonoBehaviour{
 [SerializeField] private TextMeshProUGUI _health;
 
 public void Configure(IHero hero){
  hero.Health.Subscribe(Updated);
 }
 
 public void Updated(int health){
    _health.SetText(health.ToString());
 }
}