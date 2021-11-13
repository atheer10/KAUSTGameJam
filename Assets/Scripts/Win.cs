using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject message;
    private void OnTriggerEnter2D(Collider2D other) {
        message.SetActive(true);
    }
}
