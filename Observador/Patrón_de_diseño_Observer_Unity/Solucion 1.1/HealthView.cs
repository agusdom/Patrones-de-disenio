using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthView : MonoBehaviour, HeroObserver{
 [SerializeField] private TextMeshProUGUI _health;

 public void Updated(IHero hero){

    _health.SetText(hero.Health.ToString());
  
 }
}