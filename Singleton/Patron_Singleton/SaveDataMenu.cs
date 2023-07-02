using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataMenu : MonoBehaviour
{
    [SerializeField] private InputField _inputField;
    [SerializeField] private Button _button;

    private IDataSaver _dataSaver;
    private const string ValueKey = "VALUE_KEY";

    public void Configure(IDataSaver dataSaver)
    {
        _dataSaver = dataSaver;
    }

    private void Awake()
    {
        _button.onClick.AddListener(SaveValue);
    }

    private void SaveValue()
    {
        _dataSaver.SetString(ValueKey,_inputField.text);
    }
}
