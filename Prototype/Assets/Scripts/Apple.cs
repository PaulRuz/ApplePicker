using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private static float bottomY = -10f;

    private BasketManager basketManager = null;

    private void Awake()
    {
        basketManager = FindObjectOfType<BasketManager>();
    }

    void LateUpdate()
    {
        Vector2 currentPosition = transform.position;
        if (currentPosition.y <= bottomY)
        {
            Destroy(gameObject);
            basketManager.RemoveBasket();
        }
    }
}
