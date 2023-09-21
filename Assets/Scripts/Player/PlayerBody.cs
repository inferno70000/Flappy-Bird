using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBody : PlayerAbstract
{
    [Header("PlayerBody")]

    [SerializeField] protected float rotationSpeed = 5f;
    [SerializeField] private bool isDead = false;

    protected bool IsDead { get => isDead; }

    private void Update()
    {
        RotateModel();
    }

    protected virtual void RotateModel()
    {
        if (IsDead)
        {
            playerController.Model.rotation = Quaternion.Euler(0, 0, -90);
        }

        Vector3 rotation = new(0, 0, 45);

        if (playerController.Body2D.velocity.y <= 0)
        {
            playerController.Model.rotation = Quaternion.Lerp(playerController.Model.rotation, Quaternion.Euler(-rotation), rotationSpeed * Time.deltaTime);
        }
        else
        {
            playerController.Model.rotation = Quaternion.Lerp(playerController.Model.rotation, Quaternion.Euler(rotation), rotationSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            AudioManager.Instance.PlaySound(AudioManager.HitSound);

            Debug.Log("Game Over");

            Die();
        }

        if (collision.gameObject.CompareTag("Point"))
        {
            GameManager.Instance.AddPoint(1);

            AudioManager.Instance.PlaySound(AudioManager.ScoreSound);

            Debug.Log(GameManager.Instance.Point);
        }
    }

    protected virtual void Die()
    {
        isDead = true;
        GameManager.Instance.SetGameOver(true);

        playerController.Model.GetComponent<Animator>().enabled = false;
        playerController.Flap.gameObject.SetActive(false);
        this.gameObject.gameObject.SetActive(false);
    }
}
