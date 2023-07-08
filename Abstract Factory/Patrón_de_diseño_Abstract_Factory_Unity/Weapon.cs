using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour{

[SerializeField] protected string id;

public string Id => id;
}