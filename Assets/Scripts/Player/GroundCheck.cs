using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    PlayerControl playerControl;
    // Start is called before the first frame update
    void Start()
    {
        playerControl = GetComponentInParent<PlayerControl>();
    }

    // Update is called once per fr
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            playerControl.isGrounded = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            playerControl.isGrounded = false;
        }
    }
}
