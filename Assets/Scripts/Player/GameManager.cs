using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector2 lastPos;
    Water water;
    PlayerControl player;
    Color invisablePlayer;
    TransitionController transitioned;

    void Start()
    {
        transitioned = FindObjectOfType<TransitionController>();
        transitioned?.OnWinter.AddListener(particlesPlay);
        transitioned?.OnSpring.AddListener(particlesPlay);
        player = FindObjectOfType<PlayerControl>();
        invisablePlayer = player.GetComponent<SpriteRenderer>().color;
        foreach (Water water in FindObjectsOfType<Water>())
        {
            water?.onPlayerDeath.AddListener(playerHasDied);
        }
    }



    private void playerHasDied()
    {
        invisablePlayer.a = 0f;
        StartCoroutine(Respawn());
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(0.2f);
        player.transform.position = lastPos;
        invisablePlayer.a = 1f;
    }

    private void particlesPlay()
    {
        if (transitioned.IsSpring)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);

        }
        if (transitioned.IsWinter)
        {
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
