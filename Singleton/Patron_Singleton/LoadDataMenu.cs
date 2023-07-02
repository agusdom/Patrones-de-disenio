using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDataMenu : MonoBehaviour
{
    [SerializeField] private Text _storedValue;
    

    private IDataSaver _dataSaver;
    private const string ValueKey = "VALUE_KEY";

    public void Configure(IDataSaver dataSaver)
    {
        _dataSaver = dataSaver;
    }

    private void Start()
    {
        _storedValue.text = _dataSaver.GetString(ValueKey);
    }

}
