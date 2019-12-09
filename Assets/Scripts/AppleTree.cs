using UnityEngine;

public class AppleTree : MonoBehaviour
{
    #region Variables
    public GameObject applePrefab = null;
    public float periodCreateApple = 1.2f;

    private float speedMove = 4f;
    private float chanceChangeDirection = 0.01f;
    private float distanceChangeDirection;
    #endregion

    #region UnityFunction
    private void Start()
    {
        RecursiveCreateApple();
        distanceChangeDirection = Info.screenWidth;
    }

    private void Update()
    {
        MoveAppleTree();
    }

    private void FixedUpdate()
    {
        RandomChangeDirection();
    }
    #endregion

    private void RecursiveCreateApple()
    {
        Instantiate(applePrefab, transform.position, Quaternion.identity);
        Invoke("RecursiveCreateApple", periodCreateApple);
    }

    private void MoveAppleTree()
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
    }

    private void RandomChangeDirection()
    {
        float randomValue = Random.value;
        if (randomValue < chanceChangeDirection)
            speedMove *= -1;
    }
}
