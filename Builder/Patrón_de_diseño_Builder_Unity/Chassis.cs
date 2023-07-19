using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chassis : MonoBehaviour{
  [SerializeField] 
  private Transform _frontRightTyrePosition;
  [SerializeField] 
  private Transform _frontLeftTyrePosition;
  [SerializeField] 
  private Transform _rearRightTyrePosition;
  [SerializeField] 
  private Transform _rearRightTyrePosition;

  public Transform GetTyrePosition(TyrePositions position){
   switch(position){
    case TyrePositions.FrontLeft:
    	 return _frontRightTyrePosition;
    case TyrePositions.FrontRight:
    	 return _frontLeftTyrePosition;
    case TyrePositions.RearLeft:
    	 return _rearRightTyrePosition;
    case TyrePositions.RearRight:
    	 return _rearRightTyrePosition;
  }
    throw new ArgumentOutOfRangeException(nameof(position),position,null);
 } 
   protected abstract void OnCollisionEnter(Collision other);
}