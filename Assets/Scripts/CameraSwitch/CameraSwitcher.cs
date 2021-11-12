using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    CinemachineVirtualCamera cineCam;
    PlayerControl playerControl;

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    void OnValidate() {
        Initialize();
    }

    void Initialize() {
        playerControl = FindObjectOfType<PlayerControl>();
        cineCam = GetComponentInChildren<CinemachineVirtualCamera>();
        cineCam.Follow = playerControl.transform;
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
