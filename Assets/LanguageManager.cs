using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour {

    public List<Toggle> LanguageToggles;
    public Dropdown Race;
    public Dropdown Subrace;
    public Dropdown Background;
    public Text ChoicesText;
    int ChoicesLeft;

    // Use this for initialization
	void Start () {
        ResetToggles();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ResetToggles()
    {
        ChoicesLeft = 0;
        for(int i = 0; i < 16; i++)
        {
            LanguageToggles[i].isOn = false;
            LanguageToggles[i].interactable = false;
        }
        RaceUpdate();
        BackgroundUpdate();
        LanguageUpdate();
    }

    public void RaceUpdate()
    {
        if(Race.captionText.text == "Dwarf")
        {
            LanguageToggles[0].isOn = true;
            LanguageToggles[1].isOn = true;
            LanguageToggles[0].interactable = false;
            LanguageToggles[1].interactable = false;
        }
        else if (Race.captionText.text == "Elf")
        {
            LanguageToggles[0].isOn = true;
            LanguageToggles[2].isOn = true;
            if(Subrace.captionText.text == "High")
            {
                ChoicesLeft++;
            }
            LanguageToggles[0].interactable = false;
            LanguageToggles[2].interactable = false;
        }
        else if (Race.captionText.text == "Halfling")
        {
            LanguageToggles[0].isOn = true;
            LanguageToggles[6].isOn = true;
            LanguageToggles[0].interactable = false;
            LanguageToggles[6].interactable = false;
        }
        else if (Race.captionText.text == "Human")
        {
            LanguageToggles[0].isOn = true;
            LanguageToggles[0].interactable = false;
            ChoicesLeft++;
        }
        else if (Race.captionText.text == "Dragonborn")
        {
            LanguageToggles[0].isOn = true;
            LanguageToggles[11].isOn = true;
            LanguageToggles[0].interactable = false;
            LanguageToggles[11].interactable = false;
        }
        else if (Race.captionText.text == "Gnome")
        {
            LanguageToggles[0].isOn = true;
            LanguageToggles[4].isOn = true;
            LanguageToggles[0].interactable = false;
            LanguageToggles[4].interactable = false;
        }
        else if (Race.captionText.text == "Half-Elf")
        {
            LanguageToggles[0].isOn = true;
            LanguageToggles[2].isOn = true;
            ChoicesLeft++;
            LanguageToggles[0].interactable = false;
            LanguageToggles[2].interactable = false;
        }
        else if (Race.captionText.text == "Half-Orc")
        {
            LanguageToggles[0].isOn = true;
            LanguageToggles[7].isOn = true;
            LanguageToggles[0].interactable = false;
            LanguageToggles[7].interactable = false;
        }
        else if (Race.captionText.text == "Tiefling")
        {
            LanguageToggles[0].isOn = true;
            LanguageToggles[12].isOn = true;
            LanguageToggles[0].interactable = false;
            LanguageToggles[12].interactable = false;
        }
    }

    public void BackgroundUpdate()
    {
        if(Background.captionText.text == "Acolyte")
        {
            ChoicesLeft++;
            ChoicesLeft++;
        }
        else if (Background.captionText.text == "Guild Atrisan")
        {
            ChoicesLeft++;
        }
        else if (Background.captionText.text == "Hermit")
        {
            ChoicesLeft++;
        }
        else if (Background.captionText.text == "Noble")
        {
            ChoicesLeft++;
        }
        else if (Background.captionText.text == "Outlander")
        {
            ChoicesLeft++;
        }
        else if (Background.captionText.text == "Sage")
        {
            ChoicesLeft++;
            ChoicesLeft++;
        }
    }

    public void LanguageUpdate()
    {
        int ChoicesUsed = 0;
        for (int i = 0; i < 16; i++)
        {
            if (LanguageToggles[i].interactable)
            {
                if (LanguageToggles[i].isOn)
                {
                    ChoicesUsed++;
                }
            }
        }
        if (ChoicesUsed >= ChoicesLeft)
        {
            for (int i = 0; i < 16; i++)
            {
                if (LanguageToggles[i].interactable && !LanguageToggles[i].isOn)
                {
                    LanguageToggles[i].interactable = false;
                }
            }
        }
        else
        {
            for(int i = 0; i < 16; i++)
            {
                if (!LanguageToggles[i].isOn)
                {
                    LanguageToggles[i].interactable = true;
                }
            }
        }
        ChoicesText.text = "ChoicesLeft: " + (ChoicesLeft - ChoicesUsed);
    }
}
