using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoops : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string[] type = new string[9];

        type[0] = "Normal: Eevee";
        type[1] = "Fire: Flareon";
        type[2] = "Water: Vaporeon";
        type[3] = "Electric: Jolteon";
        type[4] = "Psychic: Espeon";
        type[5] = "Dark: Umbreon";
        type[6] = "Grass: Leafeon";
        type[7] = "Ice: Glaceon";
        type[8] = "Fairy: Sylveon";

        foreach(string item in type)
        {
            print(item);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
