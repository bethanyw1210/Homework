using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspeonControls:MonoBehaviour {
    private int movespeed = 2;
    private int jumpHeight = 5;
    public bool grounded = true;

    // Use this for initialization
    void Start()
    {
        grounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha8))
        {
            espeonControl();
            print("Espeon, I choose you!");
        }
    }

    void espeonControl()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed,GetComponent<Rigidbody2D>().velocity.y);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed,GetComponent<Rigidbody2D>().velocity.y);
        }
        else if(Input.GetKey(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
            grounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == ("Ground"))
        {
            grounded = true;
        }
    }

}
