using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CollectibleImage : MonoBehaviour
{
    public void Activate() {
        GetComponent<Animator>().SetBool("Active", true);
    }
}
