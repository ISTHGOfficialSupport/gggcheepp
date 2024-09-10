using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubraceManager : MonoBehaviour {

    public Dropdown Race;
    public Dropdown Subrace;
    public RollForStats StatsScript;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateSubrace()
    {
        Subrace.ClearOptions();
        Subrace.gameObject.SetActive(false);
        if(Race.captionText.text == "Dwarf")
        {
            Subrace.gameObject.SetActive(true);
            List<string> subraces = new List<string>();
            subraces.Add("Hill");
            subraces.Add("Mountain");
            Subrace.AddOptions(subraces);
        }
        else if (Race.captionText.text == "Elf")
        {
            Subrace.gameObject.SetActive(true);
            List<string> subraces = new List<string>();
            subraces.Add("High");
            subraces.Add("Wood");
            subraces.Add("Dark");
            Subrace.AddOptions(subraces);
        }
        else if (Race.captionText.text == "Halfling")
        {
            Subrace.gameObject.SetActive(true);
            List<string> subraces = new List<string>();
            subraces.Add("Lightfoot");
            subraces.Add("Stout");
            Subrace.AddOptions(subraces);
        }
        else if (Race.captionText.text == "Human")
        {
            Subrace.gameObject.SetActive(true);
            List<string> subraces = new List<string>();
            subraces.Add("Default");
            subraces.Add("Variant");
            Subrace.AddOptions(subraces);
        }
        else if (Race.captionText.text == "Dragonborn")
        {
            Subrace.gameObject.SetActive(true);
            List<string> subraces = new List<string>();
            subraces.Add("Black");
            subraces.Add("Blue");
            subraces.Add("Brass");
            subraces.Add("Bronze");
            subraces.Add("Copper");
            subraces.Add("Gold");
            subraces.Add("Green");
            subraces.Add("Red");
            subraces.Add("Silver");
            subraces.Add("White");
            Subrace.AddOptions(subraces);
        }
        else if (Race.captionText.text == "Gnome")
        {
            Subrace.gameObject.SetActive(true);
            List<string> subraces = new List<string>();
            subraces.Add("Forest");
            subraces.Add("Rock");
            Subrace.AddOptions(subraces);
        }
        Subrace.value = 0;
        StatsScript.RaceBonuses();
    }
}
