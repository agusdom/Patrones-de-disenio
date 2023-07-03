using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Weapon configuration")]

public class WeaponConfiguration : ScriptableObject{
[SerializeField] private Weapon[] weapons;
private Dictionary<string,Weapon> idToWeapon;

private void Awake(){
	idToHero = new Dictonary<string,Weapon>();
	foreach(var weapon in weapons){
	{
	idToWeapon.Add(weapon.Id,hero);
	}
   }


public Hero GetWeaponPrefabById(string id){
 if(!idToWeapon.TryGetValue(id,out var weapon)){
	throw new Exception($"Weapon with id {id} does not exit");
 }
return weapon;
}
}