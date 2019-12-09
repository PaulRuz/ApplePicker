using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    private string targetTag = "Apple";

    private void OnMouseDrag()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 currentPosition = transform.position;
        currentPosition.x = mousePosition.x;
        transform.position = currentPosition;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject selectedApple = collision.gameObject;
        if (selectedApple.CompareTag(targetTag))
        {
            Destroy(selectedApple);
        }
    }
}
