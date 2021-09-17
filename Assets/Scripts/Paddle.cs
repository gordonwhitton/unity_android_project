using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    Rigidbody2D rb;

    public float moveSpeed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        TouchMove(); // will automatically get called every frame
    }

    void TouchMove()
    {
        if (Input.GetMouseButton(0)) //will check if clicking on the screen
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //the position we have touched

            //centre of the screen is 0,0

            //if position we are clicking is -ve, want to move to the left, else if +ve move to the right

            if(touchPos.x < 0)
            {
                // move left
                rb.velocity = Vector2.left * moveSpeed;
            }
            else
            {
                // move right
                rb.velocity = Vector2.right * moveSpeed;

            }
        }
        else
        {
            rb.velocity = Vector2.zero;  //when we are not clicking anywhere, we want the veclocity to be zero
        }
    }
}
