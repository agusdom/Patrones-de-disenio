using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleFactory{
  private readonly HeroFactory heroFactory;
  private readonly WeaponFactory weaponFactory;
 
  public BattleFactory(HeroFactory heroFactory,WeaponFactory weaponFactory){
   this.heroFactory = heroFactory;
   this.weaponFactory = weaponFactory;
 }
  public Hero CreateHero(String heroId){
  return heroFactory.Create(heroId);
 }
  
  public Weapon CreateWeapon(string weaponId){
  return weaponFactory.Create(weaponId);
 }
}