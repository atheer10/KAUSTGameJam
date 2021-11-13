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

    void Initialize() {
        playerControl = FindObjectOfType<PlayerControl>();
        cineCam = GetComponentInChildren<CinemachineVirtualCamera>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (CinemachineVirtualCamera otherCam in FindObjectsOfType<CinemachineVirtualCamera>())
        {
            if (otherCam != this) {
                otherCam.Priority = 0;
            }
        }
        cineCam.Priority = 10;
    }

    private void OnTriggerExit2D(Collider2D other) {
        cineCam.Priority = 0;
    }
}
