using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocks : MonoBehaviour
{
    public static float extraspeed;
    float maxSpeed;
    public float speed;
    public static bool rockDes = false;

    void Start()
    {
        extraspeed = 0.01f;
        maxSpeed = 4f;
        speed = 1f; 
        StartCoroutine(speedUp());
    }

    // Update is called once per frame
    void Update()
    {
        if (Text1.isPaused == false)
        {
            if(winGame.TimeToWin == false)            
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
                if(speed >= maxSpeed)
                {
                    speed = maxSpeed;
                }
            }
            if (transform.position.y <= -6)
                Destroy(gameObject);
        }
    }
    public IEnumerator speedUp()
    {
        while (true)
        {
            speed += extraspeed;
            yield return new WaitForSeconds(0.5f);   
        }
    }
}
