using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab = null;
    public float periodCreateApple = 1.2f;

    private float speedMove = 4f;
    private float distanceChangeDirection = 6f;
    private float chanceChangeDirection = 0.01f;

    private void Start()
    {
        RecursiveCreateApple();
    }

    private void Update()
    {
        Vector2 currentPosition = transform.position;
        currentPosition.x += speedMove * Time.deltaTime;
        transform.position = currentPosition;

        if (currentPosition.x <= -distanceChangeDirection)
        {
            speedMove = Mathf.Abs(speedMove);
        }
        else if (currentPosition.x >= distanceChangeDirection)
        {
            speedMove = -Mathf.Abs(speedMove);
        }
        if (Random.value < chanceChangeDirection)
        {
            speedMove *= -1;
        }
    }

    private void RecursiveCreateApple()
    {
        Instantiate(applePrefab, transform.position, Quaternion.identity);
        Invoke("RecursiveCreateApple", periodCreateApple);
    }

}
