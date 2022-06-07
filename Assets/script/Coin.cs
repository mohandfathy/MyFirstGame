using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    float maxSpeed;
    float speed1;
    public static float extraspeed1;

    void Start()
    {
        extraspeed1 = 0.01f;
        maxSpeed = 4f;
        speed1 = 1f;
        StartCoroutine(speedUp1());
    }

    // Update is called once per frame
    void Update()
    {
        if (Text1.isPaused == false)
        {
            if (winGame.TimeToWin == false)
            {
                transform.Translate(Vector3.down * speed1 * Time.deltaTime);
                if (speed1 >= maxSpeed)
                {
                    speed1 = maxSpeed;
                }
            }
            if (transform.position.y <= -6)
                Destroy(gameObject);
        }
    }
    public IEnumerator speedUp1()
    {
        while (true)
        {
            speed1 += extraspeed1;
            yield return new WaitForSeconds(0.5f);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            BackGroundManager.InitialcoinNum += 50;
            Destroy(gameObject);
        }
    }
}
