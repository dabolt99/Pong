using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Paddles : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;

    private float movement;
 
    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new UnityEngine.Vector2(rb.velocity.x, movement * speed);
    }
}
