using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D rd;
    private float speed = 20f;
    public float jump = 10f;
    private float horizontalInput = 0f;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGrounded;
    public GameObject partical;

    private int extraJump;
    public int extraJumpValue;
    bool isTouch = false;
    private int jumpnum = 0;

    public Animator animator;

    float radius;
    void Start()
    {
        radius = transform.localScale.x;
        extraJump = extraJumpValue;
        rd = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        
        if (winGame.TimeToWin == true)
            jump = 11.5f;
        if (Text1.isPaused == false)
        {
            horizontalInput = Input.acceleration.x * speed;
            transform.position = new Vector2(Mathf.Clamp(transform.position.x, -2.5f, 2.5f), transform.position.y);

            isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGrounded);
            if (isGrounded == true)
            {
                extraJump = extraJumpValue;
                jumpnum = 1;
            }
            //////////////////////////////////////////////////////////////////////////jump code
            if (Input.touchCount > 0 && extraJump > 0 && isTouch == false && jumpnum == 1)
            {
                rd.velocity = Vector2.up * jump;
                extraJump--;
                isTouch = true;
                jumpnum--;
                Instantiate(partical, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
            }
            else if (Input.touchCount > 0 && extraJump == 0 && isGrounded == true)
            {
                rd.velocity = Vector2.up * jump;
            }
            if (Input.touchCount == 0)
            {
                isTouch = false;
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) && extraJump > 0)
            {
                rd.velocity = Vector2.up * jump;
                extraJump--;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJump == 0 && isGrounded == true)
            {
                rd.velocity = Vector2.up * jump;
            }
            //////////////////////////////////////////////////////////////////////////map hight & wight
            if (transform.position.x >= Screen.width)
            {
                transform.position = new Vector3(Screen.width, transform.position.y);
            }
            if (transform.position.x <= -Screen.width)
            {
                transform.position = new Vector3(-2.55f, transform.position.y);
            }
            if (transform.position.y >= 4.6)
            {
                transform.position = new Vector3(transform.position.x, 4.6f);
            }
            if (transform.position.y <= -5.6)
            {
                transform.position = new Vector3(transform.position.x, 4.6f);
            }
            if (rd.velocity.x > 0)
                transform.localScale = new Vector3(0.1f, transform.localScale.y);
            else if (rd.velocity.x < 0)
                transform.localScale = new Vector3(-0.1f, transform.localScale.y);
        }
    }
    private void FixedUpdate()
    {
        if (Text1.isPaused == false)
        {
            rd.velocity = new Vector2(horizontalInput, rd.velocity.y);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "flag")
        {
            replay.win = true;
        }
    }
}
