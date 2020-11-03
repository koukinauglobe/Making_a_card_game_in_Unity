using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterCard", menuName = "CreateMonsterCard")]//  CreateからCreateShelterというメニューを表示し、Shelterを作成する
public class MonsterCardData : ScriptableObject
{
    [SerializeField]
    private Sprite card_back;

    [SerializeField]
    private string monster_name;

    [Header("草:0 超:1 雷:2 闘:3 水:4 鋼:5 炎:6 悪:7 妖:8")]
    [SerializeField]
    private List<int> costs;

    [SerializeField][Multiline]
    private string text;

    [Header("地:0 水:1 炎:2 風:3 光:4 闇:5")]
    [SerializeField]
    private int attribute;

    [SerializeField]
    private int level;

    [SerializeField]
    private bool has_star;

    public Sprite GetCardBack()//  アイコンを入力したら、
    {
        return card_back;//  iconに返す
    }

    public string GetMonsterName()//  避難場所の名前を入力したら、
    {
        return monster_name;//  shelterNameに返す
    }

    public List<int> GetCosts()
    {
        return costs;
    }

    public string GetText()//  情報を入力したら、
    {
        return text;//  informationに返す
    }

    public int GetAttribute()// 緯度を入力したら、
    {
        return attribute;//  latitude　に返す
    }

    public int GetLevel()//  経度を入力したら、
    {
        return level;//  longitudeに返す
    }

    public bool GetIsStar()//  経度を入力したら、
    {
        return has_star;//  longitudeに返す
    }
}
