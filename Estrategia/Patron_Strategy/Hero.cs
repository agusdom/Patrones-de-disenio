using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour, Damageable
{
    private Weapon _weapon;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _weapon.Attack();
        }
    }

    public void DoDamage(int damage)
    {
        Console.WriteLine("Damage Received");
    }

    public void SetWeapon(Weapon weapon)
    {
        _weapon = weapon;
    }
}
