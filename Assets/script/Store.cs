using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    //PlayerManager player;s
    string[] PlayerUse = {"use", "used", "Buy"}; 
    int[] NamePlayers = {1,2,3,4,5,6,7,8,9};
    BackGroundManager back;
    public void Player_1()
    {
        PlayerManager.NamePlayer = NamePlayers[0];
    }
    public void Player_1B()
    {
        
        PlayerManager.NamePlayer = NamePlayers[1];
    }
    public void Player_1G()
    {
        PlayerManager.NamePlayer = NamePlayers[2];
    }
    public void Player_2()
    {
        PlayerManager.NamePlayer = NamePlayers[3];
    }
    public void Player_2B()
    {
        PlayerManager.NamePlayer = NamePlayers[4];
    }
    public void Player_2G()
    {
        PlayerManager.NamePlayer = NamePlayers[5];
    }
    public void Player_3()
    {
        PlayerManager.NamePlayer = NamePlayers[6];
    }
    public void Player_3B()
    {
        PlayerManager.NamePlayer = NamePlayers[7];
    }
    public void Player_3G()
    {
        PlayerManager.NamePlayer = NamePlayers[8];
    }
    void Start()
    {
        back = GetComponent<BackGroundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
