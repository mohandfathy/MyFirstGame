using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winGame : MonoBehaviour
{
    float speed1;
    float maxSpeed;
    public static float extraspeed1;
    public static bool TimeToWin;
    void Start()
    {
        TimeToWin = false;
        maxSpeed = 4f;
        speed1 = 1;
        extraspeed1 = 0.01f;
        StartCoroutine(speedUp());
    }

    // Update is called once per frame
    void Update()
    {
        if (Text1.isPaused == false )
        {
            if (transform.position.y <= 2.6f)
            {
                transform.position = new Vector3(0, 2.6f);
                TimeToWin = true;
            }
            transform.Translate(Vector3.down * speed1 * Time.deltaTime);
            if (speed1 >= maxSpeed)
            {
                speed1 = maxSpeed;
            }
        }
    }
    public IEnumerator speedUp()
    {
        while (true)
        {
            speed1 += extraspeed1;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
