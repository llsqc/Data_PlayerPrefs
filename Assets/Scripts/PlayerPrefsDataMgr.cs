using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;


public class PlayerPrefsDataMgr
{
    private static PlayerPrefsDataMgr _instance = new PlayerPrefsDataMgr();

    public static PlayerPrefsDataMgr Instance
    {
        get { return _instance; }
    }

    private PlayerPrefsDataMgr()
    {
    }

    public void SaveData(object data, string keyName)
    {
        Type dataType = data.GetType();
        FieldInfo[] infos = dataType.GetFields();
        FieldInfo info;

        for (int i = 0; i < infos.Length; i++)
        {
            info = infos[i];
            string saveKeyName = keyName + "_" + dataType.Name + "_" + info.FieldType.Name + "_" + info.Name;
            SaveValue(info.GetValue(data), saveKeyName);
        }
    }

    public void SaveValue(object value, string keyName)
    {
        Type fieldType = value.GetType();
        if (fieldType == typeof(int))
        {
            PlayerPrefs.SetInt(keyName, (int)value);
        }
        else if (fieldType == typeof(float))
        {
            PlayerPrefs.SetFloat(keyName, (float)value);
        }
        else if (fieldType == typeof(string))
        {
            PlayerPrefs.SetString(keyName, value.ToString());
        }
        else if (typeof(IList).IsAssignableFrom(fieldType))
        {
            IList list = value as IList;
            PlayerPrefs.SetInt(keyName, list.Count);
            int index = 0;
            foreach (object obj in list)
            {
                SaveValue(obj, keyName + index);
                ++index;
            }
        }
        else if (typeof(IDictionary).IsAssignableFrom(fieldType))
        {
            IDictionary dic = value as IDictionary;
            PlayerPrefs.SetInt(keyName, dic.Count);
            int index = 0;
            foreach (object key in dic.Keys)
            {
                SaveValue(key, keyName + "_key_" + index);
                SaveValue(dic[key], keyName + "_value_" + index);
                ++index;
            }
        }
    }

    public object LoadData(Type type, string keyName)
    {
        return null;
    }
}