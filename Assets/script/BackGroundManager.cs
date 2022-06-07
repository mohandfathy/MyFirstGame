using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundManager : MonoBehaviour
{
    public Text coinNumText;
    public static int coinNum = 0;
    public static int InitialcoinNum;

    public Text text;

    void Start()
    {
        Camera.main.projectionMatrix = Matrix4x4.Ortho(-1.8f * 1.6f, 1.8f * 1.6f, -5.0f, 5.0f, 0.2f, 1000f);
        InitialcoinNum = 0;
        coinNum = PlayerPrefs.GetInt("coin");
        coinNumText.text = ": ";
    }

    void Update()
    {
        PlayerPrefs.SetInt("coin", coinNum);
        coinNumText.text = ": " + coinNum;
        if (coinNum >= 100000)
            coinNum = 100000;
    }
}
