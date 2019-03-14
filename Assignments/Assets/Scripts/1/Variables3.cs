using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables3 : MonoBehaviour {
    public int car1speed;
    public int car2speed;
    public int car3speed;

	// Use this for initialization
	void Start () {

        car1speed = 25;
        car2speed = 35;
        car3speed = 70;

        print("Car 1 is going the speed limit at " + car1speed + " miles an hour." + " Car 2 is going 10 over the speed limit at " + car2speed + " miles an hour." + " But car 3 is speeding at " + car3speed + " miles an hour!");
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(car1speed,car2speed,car3speed);
		
	}
}
