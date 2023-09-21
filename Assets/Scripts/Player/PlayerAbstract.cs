using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbstract : AbstractMonoBehaviour
{
    [Header("Player Abstract")]

    [SerializeField] protected PlayerController playerController;

    protected override void LoadComponent()
    {
        if (playerController == null)
        {
            playerController = GetComponentInParent<PlayerController>();
        }
    }
}
