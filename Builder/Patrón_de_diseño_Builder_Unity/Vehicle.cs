using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour{
  private Dictionary<TyrePositions,Type> _tyres;
  private Chassis _chassis;

  public void SetComponents(Dictionary<TyrePositions,Tyre> tyre,Chassis chassis){
   _tyre = tyres;
   _chassis = chassis;
 }
}