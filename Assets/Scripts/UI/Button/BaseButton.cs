using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseButton : AbstractMonoBehaviour
{
    [SerializeField] protected Button button;

    protected override void LoadComponent()
    {
        if (button == null)
        {
            button = GetComponent<Button>();
        }

        AddListener();
    }

    protected virtual void AddListener()
    {
        button.onClick.AddListener(OnClick);
    }

    protected abstract void OnClick();
}
