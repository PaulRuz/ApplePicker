using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private BasketManager basketManager = null;
    private float bottomY;

    private void Awake()
    {
        basketManager = FindObjectOfType<BasketManager>();
        bottomY = -Info.screenHeight;
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
