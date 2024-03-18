using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressedKeysReader : MonoBehaviour
{
    public static event Action OnRightKeyPressed;
    public static event Action OnLeftKeyPressed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            Debug.Log("RightKeyPressed");
            OnRightKeyPressed?.Invoke(); 
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            Debug.Log("RightKeyPressed");
            OnLeftKeyPressed?.Invoke(); 
        }
    }
}
