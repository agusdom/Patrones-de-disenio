using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour,Weapon
{

    [Serializable] private GameObject _arrowPrefab;
    [Serializable] private Transform _spawnReference;


    public void Attack()
    {
        var arrow = Instantiate(_arrowPrefab, _spawnReference.position, _spawnReference.rotation);

    }
}
