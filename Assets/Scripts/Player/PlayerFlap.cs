using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlap : PlayerAbstract
{
    [Header("Player Flap")]

    [SerializeField] protected float strength = 2f;

    private void Update()
    {
        Flaps();
    }

    protected virtual void Flaps()
    {
        if (!InputManager.Instance.GetJumpButton()){ return; }

        playerController.Body2D.velocity = Vector2.up * strength;

        AudioManager.Instance.PlaySound(AudioManager.FlapSound);
    }
}
