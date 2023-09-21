using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExitButton : BaseButton
{
    protected override void OnClick()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #endif
            Application.Quit();
    }
}
