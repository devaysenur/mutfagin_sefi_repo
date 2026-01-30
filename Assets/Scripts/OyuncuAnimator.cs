using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuAnimator : MonoBehaviour

{
    private const string IS_WALKING = "IsWalking";

    [SerializeField] private Oyuncu oyuncu;

    private Animator animator;
    private void Awake() {
        animator = GetComponent<Animator>();
        animator.SetBool(IS_WALKING, oyuncu.IsWalking());
    }

    private void Update() {
        animator.SetBool(IS_WALKING, oyuncu.IsWalking());
    }
}
