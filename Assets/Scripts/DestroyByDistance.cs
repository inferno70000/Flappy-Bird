using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByDistance : MonoBehaviour
{
    [SerializeField] protected float distance = 3f;

    private void Update()
    {
        DestroyGameObject();
    }

    protected virtual void DestroyGameObject()
    {
        if (Vector2.Distance(Vector2.zero, (Vector2)transform.parent.position) < distance)
        {
            return;
        }

        Destroy(transform.parent.gameObject);
    }
}
