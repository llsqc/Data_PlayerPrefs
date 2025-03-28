using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInfo
{
    public int age;
    public string name;
    public float height;
    public bool isMale;

    public List<int> list;

    public Dictionary<int, string> dic;

    public ItemInfo itemInfo;

    public List<ItemInfo> itemList;

    public Dictionary<int, ItemInfo> itemDic;
}

public class ItemInfo
{
    public int id;
    public int num;

    public ItemInfo()
    {
    }

    public ItemInfo(int id, int num)
    {
        this.id = id;
        this.num = num;
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();

        PlayerInfo playerInfo = PlayerPrefsDataMgr.Instance.LoadData(typeof(PlayerInfo), "player1") as PlayerInfo;

        /*
         * 存储数据
         */
        
        PlayerPrefsDataMgr.Instance.SaveData(playerInfo, "player1");
    }

    // Update is called once per frame
    void Update()
    {
    }
}