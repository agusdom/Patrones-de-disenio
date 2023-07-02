using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Installer : MonoBehaviour
{
    [SerializeField] private LoadDataMenu _loadDataMenu;
    [SerializeField] private SaveDataMenu _saveDataMenu;

    private void Awake()
    {
        _loadDataMenu.Configure(PlayerPrefsAdapter.Instance);
        _saveDataMenu.Configure(PlayerPrefsMonoBehaviourAdapter.Instance);
    }
}
