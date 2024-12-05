using System.Collections;
using System.Collections.Generic;
using UnityEditor.Networking.PlayerConnection;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public const string IS_WALKING = "IsWalking";

    private Animator animator;

    [SerializeField] private Player player;

    private void Awake()
    {
        animator = GetComponent<Animator>(); 
    }

    private void Update()
    {
        animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
