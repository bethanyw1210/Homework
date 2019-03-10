using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eveelutions : MonoBehaviour {

    public bool fire;
    public bool water;
    public bool electric;
    public bool dark;
    public bool grass;
    public bool fairy;
    public bool ice;
    public bool psychic;

    // Use this for initialization
    void Start () {
        print("Which eevee-lution do you want to pick?");

    }
	
	// Update is called once per frame
	void Update () {
        {
            if(fire == true)
            {
                print("Flareon, I choose you!");
            }
            else if(water == true)
            {
                print("Vaporeon, I choose you!");
            }
            else if(electric == true)
            {
                print("Jolteon, I choose you!");
            }
            else if(dark == true)
            {
                print("Umbreon, I choose you!");
            }
            else if(grass == true)
            {
                print("Leafeon, I choose you!");
            }
            else if(fairy == true)
            {
                print("Sylveon, I choose you!");
            }
            else if(ice == true)
            {
                print("Glaceon, I choose you!");
            }
            else if(psychic == true)
            {
                print("Espeon, I choose you!");
            }
        }
        {
            if(Input.GetKey(KeyCode.Alpha1))
            {
                print("Flareon, I choose you!");
            }
            else if(Input.GetKey(KeyCode.Alpha2))
            {
                print("Vaporeon, I choose you!");
            }
            else if(Input.GetKey(KeyCode.Alpha3))
            {
                print("Jolteon, I choose you!");
            }
            else if(Input.GetKey(KeyCode.Alpha4))
            {
                print("Umbreon, I choose you!");
            }
            else if(Input.GetKey(KeyCode.Alpha5))
            {
                print("Leafeon, I choose you!");
            }
            else if(Input.GetKey(KeyCode.Alpha6))
            {
                print("Sylveon, I choose you!");
            }
            else if(Input.GetKey(KeyCode.Alpha7))
            {
                print("Glaceon, I choose you!");
            }
            else if(Input.GetKey(KeyCode.Alpha8))
            {
                print("Espeon, I choose you!");
            }
        }

    }
    

}
