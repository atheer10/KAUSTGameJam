using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransitionControl : MonoBehaviour
{
    [SerializeField]
    private TransitionController transitionController;
    
    private void Update()
    {
        if (Input.GetButtonDown("Transition")) {
            transitionController.Toggle();
        }
    }
}
