using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Water : MonoBehaviour
{
    //public bool playerHasDied;
    public UnityEvent onPlayerDeath = new UnityEvent();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            onPlayerDeath.Invoke();
        }
    }
}
