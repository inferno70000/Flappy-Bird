using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : AbstractMonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI text;

    protected override void LoadComponent()
    {
        if (text == null)
        {
            text = GetComponent<TextMeshProUGUI>();
        }
    }

    private void Update()
    {
        text.text = GameManager.Instance.Point.ToString();

        if (GameManager.Instance.IsGameOver)
        {
            transform.gameObject.SetActive(false);
        }
    }
}
