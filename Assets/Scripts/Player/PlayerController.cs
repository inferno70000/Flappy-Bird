using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : AbstractMonoBehaviour
{
    [Header("Player Controller")]

    [SerializeField] private Transform model;
    [SerializeField] private Rigidbody2D body2D;
    [SerializeField] private CapsuleCollider2D playerCollider2D;
    [SerializeField] private PlayerFlap flap;
    [SerializeField] private Transform body;

    public Transform Model { get => model; }
    public Rigidbody2D Body2D { get => body2D; }
    public CapsuleCollider2D PlayerCollider2D { get => playerCollider2D; }
    public PlayerFlap Flap { get => flap; }
    public Transform Body { get => body; }

    protected override void LoadComponent()
    {
        if (model == null)
        {
            model = transform.Find("Model");
        }

        if (body2D == null)
        {
            body2D = GetComponent<Rigidbody2D>();
        }

        if (playerCollider2D == null)
        {
            playerCollider2D = GetComponentInChildren<CapsuleCollider2D>();
        }

        if (flap == null)
        {
            flap = GetComponentInChildren<PlayerFlap>();
        }

        if (body == null)
        {
            body = transform.Find("Body");
        }
    }
}
