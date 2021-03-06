using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : MonoBehaviour
{
    GameManager gameManager;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.lastPos = transform.position;
        }
    }
}
