using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public static float ScreenHeight { get; private set; }
    public static float ScreenWidth { get; private set; }

    private void Awake()
    {
        ScreenHeight = Camera.main.orthographicSize;
        ScreenWidth = ScreenHeight * Camera.main.aspect;
    }
}