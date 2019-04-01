using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeballLoops : MonoBehaviour {

    public int pokeballs = 20;

	// Use this for initialization
	void Start () {
        for(int i=1; i<=pokeballs; i++)
        {
            print(pokeballs + " pokeballs in your bag.");
        }

        for(int i=1; i>pokeballs; i--)
        {
            print(pokeballs + " pokeballs in your bag.");
        }

        while(pokeballs <= 20)
        {
            print(pokeballs + " pokeballs in your bag.");
            pokeballs++;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
