using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataSaver
{
    void SetString(string key, string value);
    string GetString(string key,string defaultValue = default);
    void SetInt(string key, int value);
    string GetInt(string key, int defaultValue = default);
}
}
