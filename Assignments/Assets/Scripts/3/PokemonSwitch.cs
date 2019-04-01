using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonSwitch : MonoBehaviour {

    public string region;
    public string eevee;

    // Use this for initialization
    void Start()
    {
        PokemonType(eevee);

    }

    void PokemonRegion(string region)
    {
        switch(region)
        {
            case "Kanto":
                print("Kanto region has Eevee, Flareon, Vaporeon and Jolteon.");
                break;
            case "Johto":
                print("Johta region has Eevee, Flareon, Vaporeon, Jolteon, Espeon and Umbreon.");
                break;
            case "Hoenn":
                print("Sorry, Hoenn doesn't have any!");
                break;
            case "Sinnoh":
                print("Sinnoh region has Eevee, Leafeon and Glaceon.");
                break;
            case "Unova":
                print("Unova region has Eevee, Flareon, Vaporeon, Jolteon, Espeon, Umbreon, Leafeon and Glaceon.");
                break;
            case "Kalos":
                print("Kalos region has Eevee (Central), Vaporeon (Coastal), Jolteon (Coastal), Flareon (Mountain), Espeon (Coastal), Umbreon (Coastal), Leafeon (Coastal), Glaceon (Coastal) and Sylveon (Coastal).");
                break;
            case "Alola":
                print("Alola region has Eevee and all known evolutions.");
                break;
            default:
                print("I'm sorry, I don't think " + region + " is a region.");
                PokemonRegion(region);
                break;
        }
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
