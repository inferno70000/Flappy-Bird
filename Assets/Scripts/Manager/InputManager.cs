using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;

    public static InputManager Instance { get => instance; }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Only 1 Input Manager exists");
        }

        instance = this;
    }

    public bool GetJumpButton()
    {
        return Input.GetButtonDown("Jump");
    }
}
