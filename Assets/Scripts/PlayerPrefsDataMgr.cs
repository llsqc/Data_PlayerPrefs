using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerPrefsDataMgr
{
    private static PlayerPrefsDataMgr _instance = new PlayerPrefsDataMgr();
    
    public static PlayerPrefsDataMgr Instance
    {
        get
        {
            return _instance;
        }
    }
    
    private PlayerPrefsDataMgr()
    {
        
    }
}
