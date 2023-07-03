using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HeroesFactory{
  private readonly HeroesConfiguration heroesConfiguration;
	
  public HeroFactory(HeroesConfiguration heroesConfiguration){
   this.heroesConfiguration = heroesConfiguration;
 }

  public Hero Create(string id){
  var hero = heroesConfiguration.GetHeroPrefabById(id);
  return Object.Instantiate(hero);
 }
}