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

    public Dictionary<int, string> dic = new Dictionary<int, string>() { { 1, "a" }, { 2, "b" } };

    public ItemInfo itemInfo = new ItemInfo(3, 30);

    public List<ItemInfo> itemList = new List<ItemInfo>() { new ItemInfo(1, 10), new ItemInfo(2, 20) };

    public Dictionary<int, ItemInfo> itemDic = new Dictionary<int, ItemInfo>()
    {
        { 1, new ItemInfo(1, 10) },
        { 2, new ItemInfo(2, 20) },
    };
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
        PlayerInfo playerInfo = new PlayerInfo();
        PlayerPrefsDataMgr.Instance.SaveData(playerInfo, "player1");
        
        PlayerInfo playerInfo2 = PlayerPrefsDataMgr.Instance.LoadData(typeof(PlayerInfo), "player1") as PlayerInfo;
    }

    // Update is called once per frame
    void Update()
    {
    }
}