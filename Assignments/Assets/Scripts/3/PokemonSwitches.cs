using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonSwitches : MonoBehaviour {

    public string eevee;
    public string Class;


	// Use this for initialization
	void Start () {
        PokemonType(eevee);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void PokemonType(string eeevee)
    {
        switch(eevee)
        {
            case "Flareon":
                print("Flareon is a fire type.");
                break;
            case "Vaporeon":
                print("Vaporeon is a water type.");
                break;
            case "Jolteon":
                print("Jolteon is a electric type.");
                break;
            case "Umbreon":
                print("Umbreon is a dark type.");
                break;
            case "Leafeon":
                print("Leafeon is a grass type.");
                break;
            case "Sylveon":
                print("Sylveon is a fairy type.");
                break;
            case "Glaceon":
                print("Glaceon is an ice type.");
                break;
            case "Espeon":
                print("Espeon is a psychic type.");
                break;
            default:
                print(eevee + " eeveelution doesn't exist yet!");
                PokemonType(eevee);
                break;
        }
    }
}
