using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreFinal : AbstractMonoBehaviour
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
        text.text = "Score: " + GameManager.Instance.Point.ToString();
    }
}