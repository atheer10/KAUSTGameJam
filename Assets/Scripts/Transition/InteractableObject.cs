using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    TransitionController transitioned;
    Collider2D col;
    [SerializeField]
    public bool colliderOnWinter;
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

    // Update is called once per frame


    public void seasonChecker()
    {
        if(colliderOnSpring)
        {
            // original state is no trigger , winter 
            col.isTrigger = true;
            Debug.Log("here");

        }
        if (colliderOnWinter)
        {
            if(col.isTrigger == false)
            {
                col.isTrigger = true;
            }
        }

        else
        {
            col.isTrigger = false;
        }
    }

}
