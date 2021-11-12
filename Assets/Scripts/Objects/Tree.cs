using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
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

    private void RevealBranch(Collectible collectible) {
        if (nextBranch < branches.Length) {
            branches[nextBranch].Show();
            nextBranch++;
        }
    }
}
