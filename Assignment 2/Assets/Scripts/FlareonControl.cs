using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlareonControl : MonoBehaviour {
    private int movespeed = 2;
    private int jumpHeight = 5;
    private bool grounded;
    public Transform groundCheck;
    public float groundCheckRadius = 0;
    public LayerMask whatIsGround;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.Alpha1))
        {
            flareonControl();
            print("Flareon, I choose you!");
        }
    }

    void flareonControl()
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
        grounded = true;
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
    }
}
