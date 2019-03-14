using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables1 : MonoBehaviour {
    public int FlightSpeed;
    public int AttackSpeed;
    public int RunSpeed;

	// Use this for initialization
	void Start () {
        FlightSpeed = 60;
        AttackSpeed = 45;
        RunSpeed = 40;

        print("Flight speed is " + FlightSpeed + ", attack speed is " + AttackSpeed + " and lastly, run speed is " + RunSpeed);
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(FlightSpeed,AttackSpeed,RunSpeed);
		
	}
}
