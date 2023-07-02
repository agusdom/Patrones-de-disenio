using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Power up configuration")]
public class PowerUpConfiguration : ScriptableObject
{
    [SerializeField] private PowerUp[] powerUps;
    private Dictionary<string, PowerUp> _idToPowerUp;

    private void Awake()
    {
        _idToPowerUp = new Dictionary<string, PowerUp>();
        foreach (var powerUp in powerUps)
        {
            _idToPowerUp.Add(powerUp.Id, powerUp);
        }
    }

    public PowerUp GetPowerUpPrefabById(string id)
    {
        PowerUp powerUp;
        if (!_idToPowerUp.TryGetValue(id, out var powerUp))
        {
            throw new Exception($"PowerUp with id {id} does not exit");
        }

  
    }
}



