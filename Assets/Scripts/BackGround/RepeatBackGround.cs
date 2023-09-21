using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RepeatBackGround : MonoBehaviour
{
    protected const float repeatWidth = 1.28f;
    protected float startPos;

    private void Start()
    {
        startPos = transform.parent.position.x;
    }

    private void Update()
    {
        Repeat();
    }

    protected virtual void Repeat()
    {
        if (transform.parent.position.x <= -repeatWidth)
        {
            Vector3 newPos = transform.parent.position;
            newPos.x = repeatWidth;
            transform.parent.position = newPos;
        }
    }
}
