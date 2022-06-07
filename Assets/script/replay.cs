using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replay : MonoBehaviour
{
    public GameObject Bomb;
    public static bool win = false;
    public GameObject winnerMenu;

    public GameObject GameOver;
    public static bool gameOver = false;

    public static float bombnum = 5;

    void Start()
    {
        StartCoroutine(enemySpawn());
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(bombnum);
        if (win == true)
        {
            winnerMenu.SetActive(true);
            BackGroundManager.coinNum += BackGroundManager.InitialcoinNum;
            Time.timeScale = 0;
            win = false;
        }

        if (gameOver == true)
        {
            GameOver.SetActive(true);
        }
        else
        {
            GameOver.SetActive(false);
        }

    }

    public IEnumerator enemySpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(bombnum);
            Instantiate(Bomb, new Vector3(Random.Range(-1.7f, 1.7f), 6, 0), Quaternion.identity);
        }
    }
}
