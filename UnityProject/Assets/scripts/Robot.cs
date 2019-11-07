using UnityEngine;

public class Robot : MonoBehaviour
{
    [Header("對話")]
    public string say = "hello! 機器球 可以幫我尋找5個電池 拜託 不然我會沒電       ";
    public string saySpeed = "0.25";

    [Header("任務")]
    public bool complete;
    public string bateryFinish = "5";
    public string batery = "0";
}
