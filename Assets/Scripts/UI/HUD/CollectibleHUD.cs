using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleHUD : MonoBehaviour
{
    [SerializeField]
    private CollectibleImage[] images;

    private int nextIndex;

    private void Start() {
        FindObjectOfType<Collecter>().OnCollected.AddListener(ActivateOne);
    }

    private void ActivateOne(Collectible collectible) {
        if (nextIndex <= images.Length) {
            images[nextIndex].Activate();
            nextIndex++;
        }
    }
}
