using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    private static float _screenHeight;
    public static float ScreenHeight
    {
        get { return _screenHeight; }
    }
    private static float _screenWidth;
    public static float ScreenWidth
    {
        get { return _screenWidth; }
    }

    private void Awake()
    {
        _screenHeight = Camera.main.orthographicSize;
        _screenWidth = _screenHeight * Camera.main.aspect;
    }
}