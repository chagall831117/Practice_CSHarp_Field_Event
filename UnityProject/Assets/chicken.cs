using UnityEngine; //Unity API

public class chicken : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0,100)]
    [Header("移動速度")]
    public float Speed = 10; //移動速度
    [Range(0, 2000)]
    [Header("跳躍高度")]
    public int Jump = 200; //跳躍高度
    [Header("對話內容")]
    public string Talk = "咕咕咕~~~";//字串
    [Header("是否取得雞蛋")]
    public bool egg = false;//是否取得雞蛋
    void Start()
    {
        print("遊戲開始~~~");
    }

    // Update is called once per frame
    void Update()
    {
        print(Talk);
    }
}
