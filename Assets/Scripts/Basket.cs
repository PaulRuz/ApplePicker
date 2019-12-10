using UnityEngine;

public class Basket : MonoBehaviour
{
    private string targetTag = "Apple";
    private int appleScore = 100;
    private ScoreCounter scoreCounter = null;

    private void Awake()
    {
        scoreCounter = FindObjectOfType<ScoreCounter>();
    }

    private void OnMouseDrag()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 currentPosition = transform.position;
        currentPosition.x = Mathf.Clamp(mousePosition.x, -Info.ScreenWidth, Info.ScreenWidth);
        transform.position = currentPosition;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject selectedApple = collision.gameObject;
        if (selectedApple.CompareTag(targetTag))
        {
            scoreCounter.AddCurrentScore(appleScore);
            Destroy(selectedApple);          
        }
    }
}
