using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Soldier SoldierA = new Soldier();
    public Warrior WarriorA = new Warrior();
    private void Start()
    {
        SoldierA.lv = 30;
        Debug.Log("士兵經驗值，取得:" + SoldierA.GetExp());

        SoldierA.SetExp(100);
        Debug.Log("士兵經驗值-設定:" + SoldierA.exp);

        WarriorA.lv = 50;
        Debug.Log("Warrior EXP - Get" + WarriorA.Exp);

        WarriorA.Exp = 777;
        Debug.Log("Warrior EXP - Set" + WarriorA.Exp);
    }
}
