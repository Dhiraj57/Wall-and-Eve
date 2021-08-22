using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    public float speed;
    public float startPosition;
    public float endPosition;

    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

        if(transform.position.x <= endPosition)
        {
            if(gameObject.tag == "Obstacle")
            {
                Destroy(gameObject);
            }
            else
            {
                transform.position = new Vector2(startPosition, transform.position.y);
            }
        }
    }
}
