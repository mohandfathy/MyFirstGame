using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AllButton : MonoBehaviour
{
    public GameObject PauseMenu;
    string[] maps = { "Level_1","Level_2","Level_3","Level_4","Level_5",
        "Level_6","Level_7","Level_8","Level_9","Level_10",
        "Level_11", "Level_12", "Level_13", "Level_14", "Level_15",
        "Level_16", "Level_17", "Level_18", "Level_19", "Level_20"};
    static int mapNum;
    
    public void isPressed()
    {
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
    }
    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MenuB()
    {
        SceneManager.LoadScene("Menu 1");
        replay.gameOver = false;
        winGame.TimeToWin = false;
        Text1.isPaused = false;
    }
    public void StartB()
    {
        SceneManager.LoadScene("maps");
    }
    public void StoreB()
    {
        SceneManager.LoadScene("Store");
    }
    public void AGAINB()
    {
        winGame.TimeToWin = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        replay.gameOver = false;
        Text1.isPaused = false;
        Time.timeScale = 1;
    }
    public void NextB()
    {
        winGame.TimeToWin = false;
        replay.gameOver = false;
        Text1.isPaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(maps[mapNum]);    
        mapNum++;
    }
    public void map1()
    {
        mapNum = 1;
        SceneManager.LoadScene("Level_1");
        replay.bombnum = 5;
        Rocks.extraspeed = 0.02f; 
        winGame.extraspeed1 = 0.02f;
        Coin.extraspeed1 = 0.02f;
    }
    public void map2()
    {
        mapNum = 2;
        SceneManager.LoadScene("Level_2");
        replay.bombnum = 4.7f;
        Rocks.extraspeed = 0.04f;
        winGame.extraspeed1 = 0.04f;
        Coin.extraspeed1 = 0.04f;
    }
    public void map3()
    {
        mapNum = 3;
        SceneManager.LoadScene("Level_3");
        replay.bombnum = 4.4f;
        Rocks.extraspeed = 0.06f;
        winGame.extraspeed1 = 0.06f;
        Coin.extraspeed1 = 0.06f;
    }
    public void map4()
    {
        mapNum = 4;
        SceneManager.LoadScene("Level_4");
        replay.bombnum = 4.1f;
        Rocks.extraspeed = 0.08f;
        winGame.extraspeed1 = 0.08f;
        Coin.extraspeed1 = 0.08f;
    }
    public void map5()
    {
        mapNum = 5;
        SceneManager.LoadScene("Level_5");
        replay.bombnum = 3.8f;
        Rocks.extraspeed = 0.10f;
        winGame.extraspeed1 = 0.10f;
        Coin.extraspeed1 = 0.10f;
    }
    public void map6()
    {
        mapNum = 6;
        SceneManager.LoadScene("Level_6");
        replay.bombnum = 3.5f;
        Rocks.extraspeed = 0.12f;
        winGame.extraspeed1 = 0.12f;
        Coin.extraspeed1 = 0.12f;
    }
    public void map7()
    {
        mapNum = 7;
        SceneManager.LoadScene("Level_7");
        replay.bombnum = 3.2f;
        Rocks.extraspeed = 0.14f;
        winGame.extraspeed1 = 0.14f;
        Coin.extraspeed1 = 0.14f;
    }
    public void map8()
    {
        mapNum = 8;
        SceneManager.LoadScene("Level_8");
        replay.bombnum = 2.9f;
        Rocks.extraspeed = 0.16f;
        winGame.extraspeed1 = 0.16f;
        Coin.extraspeed1 = 0.16f;
    }
    public void map9()
    {
        mapNum = 9;
        SceneManager.LoadScene("Level_9");
        replay.bombnum = 2.6f;
        Rocks.extraspeed = 0.18f;
        winGame.extraspeed1 = 0.18f;
        Coin.extraspeed1 = 0.18f;
    }
    public void map10()
    {
        mapNum = 10;
        SceneManager.LoadScene("Level_10");
        replay.bombnum = 2.3f;
        Rocks.extraspeed = 0.20f;
        winGame.extraspeed1 = 0.20f;
        Coin.extraspeed1 = 0.20f;
    }
    public void map11()
    {
        mapNum = 11;
        SceneManager.LoadScene("Level_11");
        replay.bombnum = 2f;
        Rocks.extraspeed = 0.22f;
        winGame.extraspeed1 = 0.22f;
        Coin.extraspeed1 = 0.22f;
    }
    public void map12()
    {
        mapNum = 12;
        SceneManager.LoadScene("Level_12");
        replay.bombnum = 2f;
        Rocks.extraspeed = 0.24f;
        winGame.extraspeed1 = 0.24f;
        Coin.extraspeed1 = 0.24f;
    }
    public void map13()
    {
        mapNum = 13;
        SceneManager.LoadScene("Level_13");
        replay.bombnum = 2f;
        Rocks.extraspeed = 0.26f;
        winGame.extraspeed1 = 0.26f;
        Coin.extraspeed1 = 0.26f;
    }
    public void map14()
    {
        mapNum = 14;
        SceneManager.LoadScene("Level_14");
        replay.bombnum = 2f;
        Rocks.extraspeed = 0.28f;
        winGame.extraspeed1 = 0.28f;
        Coin.extraspeed1 = 0.28f;
    }
    public void map15()
    {
        mapNum = 15;
        SceneManager.LoadScene("Level_15");
        replay.bombnum = 2f;
        Rocks.extraspeed = 0.30f;
        winGame.extraspeed1 = 0.30f;
        Coin.extraspeed1 = 0.30f;
    }
    public void map16()
    {
        mapNum = 16;
        SceneManager.LoadScene("Level_16");
        replay.bombnum = 2f;
        Rocks.extraspeed = 0.32f;
        winGame.extraspeed1 = 0.32f;
        Coin.extraspeed1 = 0.32f;
    }
    public void map17()
    {
        mapNum = 17;
        SceneManager.LoadScene("Level_17");
        replay.bombnum = 2f;
        Rocks.extraspeed = 0.34f;
        winGame.extraspeed1 = 0.34f;
        Coin.extraspeed1 = 0.34f;
    }
    public void map18()
    {
        mapNum = 18;
        SceneManager.LoadScene("Level_18");
        replay.bombnum = 2f;
        Rocks.extraspeed = 0.36f;
        winGame.extraspeed1 = 0.36f;
        Coin.extraspeed1 = 0.36f;
    }
    public void map19()
    {
        mapNum = 19;
        SceneManager.LoadScene("Level_19");
        replay.bombnum = 2f;
        Rocks.extraspeed = 0.38f;
        winGame.extraspeed1 = 0.38f;
        Coin.extraspeed1 = 0.38f;
    }
    public void map20()
    {
        mapNum = 20;
        SceneManager.LoadScene("Level_20");
        replay.bombnum = 2f;
        Rocks.extraspeed = 0.4f;
        winGame.extraspeed1 = 0.4f;
        Coin.extraspeed1 = 0.4f;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
