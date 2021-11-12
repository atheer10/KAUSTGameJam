using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    CinemachineVirtualCamera cineCam;
    // Start is called before the first frame update
    void Start()
    {
        cineCam = GetComponentInChildren<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        cineCam.enabled = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        cineCam.enabled = false;
    }
}
