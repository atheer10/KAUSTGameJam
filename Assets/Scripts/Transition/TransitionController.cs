using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Sirenix.OdinInspector;

[RequireComponent(typeof(Animator))]
public class TransitionController : MonoBehaviour
{
    public UnityEvent OnWinter = new UnityEvent();
    public UnityEvent OnSpring = new UnityEvent();
    public bool IsWinter { get; private set; }
    public bool IsSpring { get; private set; }

    private Animator animator;

    public void Start() {
        animator = GetComponent<Animator>();
        Close();
    }

    [Button]
    public void Open() {
        IsWinter = false;
        IsSpring = true;
        OnSpring.Invoke();

        if (Application.isPlaying) {
            animator.SetBool("Open", true);
        } else {
            OpenNoAnimation();
        }
    }

    [Button]
    public void Close() {
        IsWinter = true;
        IsSpring = false;
        OnWinter.Invoke();

        if (Application.isPlaying) {
            animator.SetBool("Open", false);
        } else {
            CloseNoAnimation();
        }
    }

    [Button]
    public void Toggle() {
        if (IsWinter) {
            Open();
        } else {
            Close();
        }
    }

    private void OpenNoAnimation() {
        transform.localScale = 100f * Vector2.one;
    }

    private void CloseNoAnimation() {
        transform.localScale *= 0f;
    }
}
