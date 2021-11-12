using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    [SerializeField]
    private float speed;
    [SerializeField]
    private float jumpVelocity;

    private Rigidbody2D rb;
    private float horizontalInput;
    private bool isJumping;
    private float jumpTimeCounter;
    //jumpTime
    public float normalJumpTime = 0.15f;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        PlayerMove(horizontalInput);
        //Flip
        if (horizontalInput > 0)
        {
            gameObject.transform.localScale = new Vector2(1, gameObject.transform.localScale.y);
        }
        if (horizontalInput < 0)
        {
            gameObject.transform.localScale = new Vector2(-1, gameObject.transform.localScale.y);
        }

    }

    private void Update()
    {
        //Jump
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpVelocity;
            isJumping = true;
            jumpTimeCounter = normalJumpTime;
            isGrounded = false;
        }

        if (Input.GetButtonDown("Jump") && isGrounded == false && isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpVelocity;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }


        if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
        }
    }


    private void PlayerMove(float moveDir)
    {
        rb.velocity = new Vector2(moveDir * speed, rb.velocity.y);

    }
}