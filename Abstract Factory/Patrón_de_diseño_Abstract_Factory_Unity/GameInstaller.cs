using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstaller : MonoBehaviur{
  [SerializeField] private HeroesConfiguration heroesConfiguration;
  [SerializeField] private WeaponsConfiguration weaponsConfiguration;
  [SerializeField] private WeaponsConfiguration halloweenweaponsConfiguration;
  private Costumer consumer;
  private BattleFactory battleFactory;
  private BattleFactory halloweenbattleFactory;
public void Start(){
  var heroFactory = new HeroFactory(instantiate(heroesConfiguration));
  var weaponFactory = new WeaponFactory(instantiate(weaponsConfiguration));
  var halloweenweaponFactory = new WeaponFactory(instantiate(halloweenweaponsConfiguration));

  var consumerGameObject = new GameObject();
  consumer = consumerGameObject.AddComponent<Consumer>();
  battleFactory = new BattleFactory(heroFactory,weaponFactory);
  halloweenbattleFactory = new BattleFactory(heroFactory,halloweenweaponFactory);
  consumer.Configure(battleFactory);
 }

 private void Update(){
  if(Input.GetKeyDown(KeyCode.Q))
  consumer.Configure(halloweenbattleFactory);
 }
}