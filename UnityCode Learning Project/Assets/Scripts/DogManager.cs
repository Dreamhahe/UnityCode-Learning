using UnityEngine;
/// <summary>
/// 繼承MonoBehaviour 類別
/// </summary>
public class DogManager : MonoBehaviour
{
    public Dog DogA = new Dog();
    public Dog DogB = new Dog();

    #region 事件
    /// <summary>
    /// start 
    /// </summary>
    private void Start()
    {
        DogA.name = "哥斯拉";
        DogA.weight = 42.9f;
        DogA.type = "黃金獵犬";
        DogA.sex = "母";
        DogA.color = "黃金";
        DogA.age = 9;

        DogB.name = "鵝莫拉";
        DogB.weight = 6888888.9f;
        DogB.type = "輻射變種狗";
        DogB.sex = "不明";
        DogB.color = "嘔吐色";

        Debug.Log(DogA.name + "品種:" + DogA.type + "顏色:" + DogA.color);
        Debug.Log(DogB.name + "品種:" + DogB.type + "顏色:" + DogB.color);

        

    }
    #endregion 
}
