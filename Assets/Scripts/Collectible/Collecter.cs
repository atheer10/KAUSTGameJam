using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collecter : MonoBehaviour
{
    public UnityEvent<Collectible> OnCollected = new UnityEvent<Collectible>();

    public int Collected { get; private set; }
    
    public void Collect(Collectible collectible) {
        Collected++;
        OnCollected.Invoke(collectible);
    }
}
