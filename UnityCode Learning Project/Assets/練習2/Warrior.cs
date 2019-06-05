using UnityEngine;

[System.Serializable]
public class Warrior
{
    /// <summary>
    /// 取得與設定戰士的經驗值
    /// </summary>
    public int exp;
    public int lv;

    public int Exp
    {
        get
        {
            return lv * 10;
        }
        set
        {
            exp = value;
        }
    }

}