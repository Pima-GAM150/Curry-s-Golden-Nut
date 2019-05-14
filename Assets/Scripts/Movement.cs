using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    float horiz;
    float vert;
    public Rigidbody2D body;
    public Rigidbody2D curryBody;
    public bool levelDone;

    void Start()
    {
        levelDone = false;
    }
    
    void Update()
    {
        horiz = Input.GetAxis("Horizontal") * speed;
        vert = Input.GetAxis("Vertical") * speed;
    }

    private void FixedUpdate()
    {
        if(levelDone != true)
        {
            body.velocity = new Vector2(horiz * speed, vert * speed);
        }
        else
        {
            body.velocity = new Vector2(0f, 0f);
            curryBody.velocity = new Vector2(0f, 0f);
        }
    }
}
