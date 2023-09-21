using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] protected float speed = 1f;

    private void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        transform.parent.Translate(speed * Time.deltaTime * Vector2.left);
    }
}
