using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private static float bottomY = -10f;

    void Update()
    {
        Vector2 currentPosition = transform.position;
        if (currentPosition.y <= bottomY)
        {
            Destroy(gameObject);
        }
    }
}
