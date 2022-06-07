using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text1 : MonoBehaviour
{
    public Text timer;
    public GameObject timerObject;
    float currCountdownValue;
    //float countdownValue = 3;

    public static bool isPaused = true ;
    void Start()
    {
        currCountdownValue = 3;
        Time.timeScale = 1;
        timer.text = "3";
        StartCoroutine(StartCountdown());
    }
    
    // Update is called once per frame
    void Update()
    {
        //coinNumText.text = "nothing is wrong ";
        timer.text = "" + (int)currCountdownValue;
        if (currCountdownValue <= 0)
        {
            currCountdownValue = 0;
            isPaused = false;
            timerObject.SetActive(false); 
        }
    }
    public IEnumerator StartCountdown()
    {
        //currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            isPaused = true;
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
        }
    }
}
