using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject _enemyExplosionPrefab;
    private float speed = 5f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Text1.isPaused == false)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);

            if (transform.position.y < -5.75f)
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            player player1 = other.GetComponent<player>();
            Instantiate(_enemyExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Time.timeScale = 0;
            replay.gameOver = true;
        }
    }
}