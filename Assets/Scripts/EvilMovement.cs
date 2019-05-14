using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilMovement : MonoBehaviour
{
    public bool movingLeft;

    public int speed;

    public float leftBounds;
    public float rightBounds;

    public Rigidbody2D body;

    void Update()
    {
        if (body.position.x < leftBounds)
        {
            body.velocity = new Vector2(speed*Time.deltaTime, 0f);
        }
        if (body.position.x > rightBounds)
        {
            body.velocity = new Vector2(-speed * Time.deltaTime, 0f);
        }
    }
}
