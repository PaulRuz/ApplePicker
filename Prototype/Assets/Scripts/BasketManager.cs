using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasketManager : MonoBehaviour
{
    public GameObject basketPrefab = null;
    [Range(1, 3)] public byte countBaskets = 3;

    private List<GameObject> basketList = null;
    private ScoreCounter scoreCounter = null;

    void Awake()
    {
        scoreCounter = FindObjectOfType<ScoreCounter>();

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

    public void RemoveBasket()
    {
        int numBaske = basketList.Count - 1;
        GameObject currentBasket = basketList[numBaske];
        basketList.Remove(currentBasket);
        Destroy(currentBasket);
        if (basketList.Count == 0)
        {
            scoreCounter.AddHighScore();
            SceneManager.LoadScene(0);
        }
    }
}
