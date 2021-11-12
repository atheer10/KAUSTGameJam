using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        Collecter collecter = other.GetComponent<Collecter>();
        if (collecter != null) {
            collecter.Collect(this);
            Collected(collecter);
        }
    }

    private void Collected(Collecter collecter) {
        Destroy(gameObject);
    }
}
