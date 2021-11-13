using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class Treehouse : MonoBehaviour
{
    [SerializeField]
    private Branch[] branches;

    private int nextBranch = 0;
    private Collecter collecter;

    void Start()
    {
        foreach (Branch branch in branches)
        {
            branch.Hide();
        }

        collecter = FindObjectOfType<Collecter>();
        collecter.OnCollected.AddListener(RevealBranch);
    }

    [Button]
    private void RevealBranch(Collectible collectible) {
        if (nextBranch < branches.Length) {
            branches[nextBranch].Show();
            nextBranch++;
        }
    }
}
