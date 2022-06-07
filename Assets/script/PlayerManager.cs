using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject[] Players;
    public static int NamePlayer = 1;
    void Start()
    {
        Camera.main.projectionMatrix = Matrix4x4.Ortho(-1.8f * 1.6f, 1.8f * 1.6f, -5.0f, 5.0f, 0.2f, 1000f);
        if (NamePlayer == 1) {
            Instantiate(Players[0], new Vector3(-1, -4.15f), Quaternion.identity);
        }
        if (NamePlayer == 2)
        {
            Instantiate(Players[1], new Vector3(-1, -4.15f), Quaternion.identity);
        }
        if (NamePlayer == 3)
        {
            Instantiate(Players[2], new Vector3(-1, -4.15f), Quaternion.identity);
        }
        if (NamePlayer == 4)
        {
            Instantiate(Players[3], new Vector3(-1, -4.15f), Quaternion.identity);
        }
        if (NamePlayer == 5)
        {
            Instantiate(Players[4], new Vector3(-1, -4.15f), Quaternion.identity);
        }
        if (NamePlayer == 6)
        {
            Instantiate(Players[5], new Vector3(-1, -4.15f), Quaternion.identity);
        }
        if (NamePlayer == 7)
        {
            Instantiate(Players[6], new Vector3(-1, -4.15f), Quaternion.identity);
        }
        if (NamePlayer == 8)
        {
            Instantiate(Players[7], new Vector3(-1, -4.15f), Quaternion.identity);
        }
        if (NamePlayer == 9)
        {
            Instantiate(Players[8], new Vector3(-1, -4.15f), Quaternion.identity);
        }
    }

    void Update()
    {
       
    }
}
