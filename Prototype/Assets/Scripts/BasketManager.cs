using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasketManager : MonoBehaviour
{
    public GameObject basketPrefab = null;
    [Range(1, 3)] public byte countBaskets = 3;

    private Stack<GameObject> basketList = null;
    private ScoreCounter scoreCounter = null;

    void Awake()
    {
        scoreCounter = FindObjectOfType<ScoreCounter>();
        CreateaBaskets();
    }

    private void CreateaBaskets()
    {
        basketList = new Stack<GameObject>();

        Vector2 pos = transform.position;
        float spacingX = Mathf.Abs(pos.x);

        for (int i = 0; i < countBaskets; i++)
        {
            GameObject newBasket = Instantiate(basketPrefab, pos, Quaternion.identity);
            newBasket.transform.parent = transform;
            pos.x = spacingX * i;

            basketList.Push(newBasket);
        }
    }

    public void RemoveBasket()
    {
        GameObject removedBasket = basketList.Pop();
        Destroy(removedBasket);
        if (basketList.Count == 0)
        {
            scoreCounter.AddHighScore();
            SceneManager.LoadScene(0);
        }
    }
}
