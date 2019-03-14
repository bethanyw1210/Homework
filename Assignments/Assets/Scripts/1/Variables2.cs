using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables2 : MonoBehaviour {
    public int Sister1Age;
    public int Sister2Age;
    public int Sister3Age;
    public int MyAge;

	// Use this for initialization
	void Start () {

        Sister1Age = 30;
        Sister2Age = 28;
        Sister3Age = 26;
        MyAge = 21;

        print("My oldest sister is " + Sister1Age + ", my second oldest sister is " + Sister2Age + ", my third oldest sister is " + Sister3Age + " and I am " + MyAge + ".");
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Sister1Age,Sister2Age,Sister3Age);
	}
}
