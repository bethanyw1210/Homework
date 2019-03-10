using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaporeonControl : MonoBehaviour {
    private int movespeed = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.Alpha2))
        {
            vaporeonControl();
            print("Vaporeon, I choose you!");
        }

    }

    void vaporeonControl()
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
