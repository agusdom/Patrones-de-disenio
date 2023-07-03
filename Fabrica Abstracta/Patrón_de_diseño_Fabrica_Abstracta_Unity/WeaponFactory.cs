using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WeaponFactory{
  private readonly WeaponConfiguration weaponsConfiguration;
	
  public WeaponFactory(WeaponConfiguration weaponsConfiguration){
   this.weaponsConfiguration = weaponsConfiguration;
 }

  public Weapon Create(string id){
  var hero = weaponsConfiguration.GetWeaponPrefabById(id);
  return Object.Instantiate(weapon);
 }
}