using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    TransitionController transitioned;
    Collider2D col;
    [SerializeField]
    public bool colliderOnSpring;


    // Start is called before the first frame update
    void Awake()
    {
        col = GetComponent<Collider2D>();
        transitioned = FindObjectOfType<TransitionController>();
        transitioned?.OnWinter.AddListener(seasonChecker);
        transitioned?.OnSpring.AddListener(seasonChecker);
    }

    public void seasonChecker()
    {
        if (colliderOnSpring && transitioned.IsSpring)
        {
            col.isTrigger = false;
        }
        else if (!colliderOnSpring && transitioned.IsWinter)
        {
            col.isTrigger = false;
        }
        else
        {
            col.isTrigger = true;
        }
    }

}
