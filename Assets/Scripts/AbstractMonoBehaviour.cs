using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractMonoBehaviour : MonoBehaviour
{
    private void Awake()
    {
        LoadComponent();
    }

    private void Reset()
    {
        LoadComponent();
    }

    protected abstract void LoadComponent();
}
