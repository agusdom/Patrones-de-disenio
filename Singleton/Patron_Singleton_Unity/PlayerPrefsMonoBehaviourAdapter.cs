using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsMonoBehaviourAdapter : MonoBehaviour,IDataSaver
{
    private static PlayerPrefsAdapter _instance;
    private static IData _instance;

    public static IDataSaver Instance(
    {
        get{

            if (_instance == null)
            {
                var auxGameObject = new GameObject();
                _instance = auxGameObject.AddComponent<PlayerPrefsMonoBehaviourAdapter>();
            }
            return _instance;
        }
       
    }



    public void SetString(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
        PlayerPrefs.Save();
    }

    public string GetString(string key, string defaultValue = default)
    {
        return PlayerPrefs.GetString(key, defaultValue);
    }

    public void SetInt(string key, int value)
    {
        PlayerPrefs.SetInt(key, value);
        PlayerPrefs.Save();
    }

    public string GetInt(string key, int defaultValue = default)
    {
        return PlayerPrefs.GetString(key, defaultValue);
    }
}
