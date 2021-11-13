using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapSeasonSetup : MonoBehaviour
{
    [SerializeField]
    private GameObject seasonParent;

    private void Start() {
        foreach (TilemapRenderer mapRenderer in seasonParent.GetComponentsInChildren<TilemapRenderer>())
        {
            mapRenderer.maskInteraction = SpriteMaskInteraction.VisibleInsideMask;
        }
    }
}
