using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketManager : MonoBehaviour
{
    public GameObject basketPrefab = null;
    [Range(1, 3)] public byte countBaskets = 3;

    private List<GameObject> basketList = null;

    void Awake()
    {
        basketList = new List<GameObject>();

        Vector2 pos = transform.position;
        float spacingX = Mathf.Abs(pos.x);

        for (int i = 0; i < countBaskets; i++)
        {
            GameObject newBasket = Instantiate(basketPrefab, pos, Quaternion.identity);
            newBasket.transform.parent = transform;
            pos.x = spacingX * i;

            basketList.Add(newBasket);
        }
    }
}
