using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : AbstractMonoBehaviour
{
    [SerializeField] private Transform menu;

    protected override void LoadComponent()
    {
        if (menu == null)
        {
            menu = transform.Find("Menu");
        }
    }

    void Update()
    {
        if (GameManager.Instance.IsGameOver)
        {
            menu.gameObject.SetActive(true);
        }
    }
}
