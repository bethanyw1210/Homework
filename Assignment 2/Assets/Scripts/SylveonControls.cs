﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SylveonControls : MonoBehaviour {
    private int movespeed = 2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha6))
        {
            sylveonControl();
            print("Sylveon, I choose you!");
        }
    }

    void sylveonControl()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed,GetComponent<Rigidbody2D>().velocity.y);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed,GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
