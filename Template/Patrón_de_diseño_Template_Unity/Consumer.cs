using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumer : MonoBehaviour{
  [SerializeField] private Hero hero1;
  [SerializeField] private Hero hero2;

 private void Awake(){
   Debug.Log("---------");
   Do(hero1,"Hero 1");
   Debug.Log("---------");
   Do(hero2,"Hero 2");
 }

 private static void Do(Hero hero, String heroName){
   hero.OnDamageReceived += () => {Debug.Log($"{heroName} recibe daño");};
   hero.ReceiveDamage(10);
   hero.Attack();
   hero.ReceiveDamage(70);
   hero.Attack();
   hero.ReceiveDamage(100);
   hero.Attack();
 }
}