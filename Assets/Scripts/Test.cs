using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInfo
{
    public string name = "myname";
    public int age = 10;
    public float height = 1.7f;
    public bool isMale = true;

    public List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerInfo playerInfo = new PlayerInfo();
        PlayerPrefsDataMgr.Instance.SaveData(playerInfo, "player1");
    }

    // Update is called once per frame
    void Update()
    {
    }
}