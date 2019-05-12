using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    float horiz;
    float vert;
    public Rigidbody2D body;
    
    void Update()
    {
        horiz = Input.GetAxis("Horizontal") * speed;
        vert = Input.GetAxis("Vertical") * speed;
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horiz * speed, vert * speed);
    }
}
