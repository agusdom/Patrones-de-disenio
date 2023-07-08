using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Installer : MonoBehaviour
{
    [SerializeField] private Hero _heroPrefab;
    [SerializeField] private Sword swordPrefab;
    [SerializeField] private Bow _bowPrefab;

    [SerializeField] private bool _useSword;

    private void Awake()
    {
        var hero = Instantiate(_heroPrefab);
        var sword = GetWeapon(hero.transform);
        hero.SetWeapon(sword);
    }

    private Weapon GetWeapon(Transform parent)
    {
        if (_useSword)
        {
            return Instantiate(_swordPrefab, parent);
        }
        return Instantiate(_bowPrefab, parent);
    }
}
