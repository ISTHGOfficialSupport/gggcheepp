using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsCreationManager : MonoBehaviour {

    public List<Toggle> SkillToggle;
    public Dropdown Race;
    public Dropdown Subrace;
    public Dropdown Background;
    public Dropdown Class;
    List<int> Allowed;
    int NumAllowed = 0;
    int NumRaceAllowed = 0;
    public GameObject RaceSkillsContainer;
    public List<Toggle> RaceSkillToggle;
    public Text ChoicesLeft;
    public Text RaceChoicesLeft;

	// Use this for initialization
	void Start () {
        ResetToggles();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ResetToggles()
    {
        for(int i = 0; i < 18; i++)
        {
            SkillToggle[i].isOn = false;
            SkillToggle[i].interactable = false;
            RaceSkillToggle[i].isOn = false;
            RaceSkillToggle[i].interactable = false;
        }
        RaceStuff();
        BackgroundUpdate();
        ClassAllow();
    }

    public void ClassAllow()
    {
        if(Class.captionText.text == "Barbarian")
        {
            NumAllowed = 2;
            Allowed = new List<int>(6);
            Allowed.Add(1); //Animal Handling
            Allowed.Add(3); //Athletics
            Allowed.Add(7); //Intimidation
            Allowed.Add(10); //Nature
            Allowed.Add(11); //Perception
            Allowed.Add(17); //Survival
        }
        else if(Class.captionText.text == "Bard")
        {
            NumAllowed = 3;
            Allowed = new List<int>(18);
            for (int i = 0; i < 18; i++)
            {
                Allowed.Add(i);
            }
        }
        else if(Class.captionText.text == "Cleric")
        {
            NumAllowed = 2;
            Allowed = new List<int>(5);
            Allowed.Add(5); //History
            Allowed.Add(6); //Insight
            Allowed.Add(9); //Medicine
            Allowed.Add(13); //Persuasion
            Allowed.Add(14); //Religion
        }
        else if (Class.captionText.text == "Druid")
        {
            NumAllowed = 2;
            Allowed = new List<int>(8);
            Allowed.Add(1); //Animal Handling
            Allowed.Add(2); //Arcana
            Allowed.Add(6); //Insight
            Allowed.Add(9); //Medicine
            Allowed.Add(10); //Nature
            Allowed.Add(11); //Perception
            Allowed.Add(14); //Religion
            Allowed.Add(17); //Survival
        }
        else if (Class.captionText.text == "Fighter")
        {
            NumAllowed = 2;
            Allowed = new List<int>(8);
            Allowed.Add(0); //Acrobatics
            Allowed.Add(1); //Animal Handling
            Allowed.Add(3); //Athletics
            Allowed.Add(5); //History
            Allowed.Add(6); //Insight
            Allowed.Add(7); //Intimidation
            Allowed.Add(11); //Perception
            Allowed.Add(17); //Survival
        }
        else if (Class.captionText.text == "Monk")
        {
            NumAllowed = 2;
            Allowed = new List<int>(6);
            Allowed.Add(0); //Acrobatics
            Allowed.Add(3); //Athletics
            Allowed.Add(5); //History
            Allowed.Add(6); //Insight
            Allowed.Add(14); //Religion
            Allowed.Add(16); //Stealth
        }
        else if (Class.captionText.text == "Paladin")
        {
            NumAllowed = 2;
            Allowed = new List<int>(6);
            Allowed.Add(3); //Athletics
            Allowed.Add(6); //Insight
            Allowed.Add(7); //Intimidation
            Allowed.Add(9); //Medicine
            Allowed.Add(13); //Persuasion
            Allowed.Add(14); //Religion
        }
        else if (Class.captionText.text == "Ranger")
        {
            NumAllowed = 3;
            Allowed = new List<int>(8);
            Allowed.Add(1); //Animal Handling
            Allowed.Add(3); //Athletics
            Allowed.Add(6); //Insight
            Allowed.Add(8); //Investigation
            Allowed.Add(10); //Nature
            Allowed.Add(11); //Perception
            Allowed.Add(16); //Stealth
            Allowed.Add(17); //Survival
        }
        else if (Class.captionText.text == "Rogue")
        {
            NumAllowed = 4;
            Allowed = new List<int>(11);
            Allowed.Add(0); //Acrobatics
            Allowed.Add(3); //Athletics
            Allowed.Add(4); //Deception
            Allowed.Add(6); //Insight
            Allowed.Add(7); //Intimidation
            Allowed.Add(8); //Investigation
            Allowed.Add(11); //Perception
            Allowed.Add(12); //Performance
            Allowed.Add(13); //Persuasion
            Allowed.Add(15); //Sleight of Hand
            Allowed.Add(16); //Stealth
        }
        else if (Class.captionText.text == "Sorcerer")
        {
            NumAllowed = 2;
            Allowed = new List<int>(6);
            Allowed.Add(2); //Arcana
            Allowed.Add(4); //Deception
            Allowed.Add(6); //Insight
            Allowed.Add(7); //Intimidation
            Allowed.Add(13); //Persuasion
            Allowed.Add(14); //Religion
        }
        else if (Class.captionText.text == "Warlock")
        {
            NumAllowed = 2;
            Allowed = new List<int>(7);
            Allowed.Add(2); //Arcana
            Allowed.Add(4); //Deception
            Allowed.Add(5); //History
            Allowed.Add(7); //Intimidation
            Allowed.Add(8); //Investigation
            Allowed.Add(10); //Nature
            Allowed.Add(14); //Religion
        }
        else if (Class.captionText.text == "Wizard")
        {
            NumAllowed = 2;
            Allowed = new List<int>(6);
            Allowed.Add(2); //Arcana
            Allowed.Add(5); //History
            Allowed.Add(6); //Insight
            Allowed.Add(8); //Investigation
            Allowed.Add(9); //Medicine
            Allowed.Add(14); //Religion
        }
        for(int i = 0; i < Allowed.Count; i++)
        {
            SkillToggle[Allowed[i]].interactable = true;
        }
        ChoicesLeft.text = NumAllowed + "";
    }

    public void RaceStuff()
    {
        for(int i = 0; i < 18; i++)
        {
            SkillToggle[i].isOn = false;
            SkillToggle[i].interactable = false;
        }
        RaceSkillsContainer.SetActive(false);
        if(Race.captionText.text == "Elf")
        {
            SkillToggle[11].isOn = true;
            SkillToggle[11].interactable = false;
        }
        else if(Race.captionText.text == "Human" && Subrace.captionText.text == "Variant")
        {
            NumRaceAllowed = 2;
            RaceSkillsContainer.SetActive(true);
            for(int i = 0; i < 18; i++)
            {
                RaceSkillToggle[i].interactable = true;
            }
        }
        else if(Race.captionText.text == "Half-Elf")
        {
            NumRaceAllowed = 2;
            RaceSkillsContainer.SetActive(true);
            for (int i = 0; i < 18; i++)
            {
                RaceSkillToggle[i].interactable = true;
            }
        }
        else if(Race.captionText.text == "Half-Orc")
        {
            SkillToggle[7].isOn = true;
            SkillToggle[7].interactable = false;
        }
        RaceChoicesLeft.text = NumRaceAllowed + "";
    }
    
    public void BackgroundUpdate()
    {
        if(Background.captionText.text == "Acolyte")
        {
            RaceSkillToggle[6].isOn = true;
            SkillToggle[6].isOn = true;
            RaceSkillToggle[6].interactable = false;
            SkillToggle[6].interactable = false;
            RaceSkillToggle[14].isOn = true;
            SkillToggle[14].isOn = true;
            RaceSkillToggle[14].interactable = false;
            SkillToggle[14].interactable = false;
        }
        else if (Background.captionText.text == "Charlatan")
        {
            RaceSkillToggle[4].isOn = true;
            SkillToggle[4].isOn = true;
            RaceSkillToggle[4].interactable = false;
            SkillToggle[4].interactable = false;
            RaceSkillToggle[15].isOn = true;
            SkillToggle[15].isOn = true;
            RaceSkillToggle[15].interactable = false;
            SkillToggle[15].interactable = false;
        }
        else if (Background.captionText.text == "Criminal")
        {
            RaceSkillToggle[4].isOn = true;
            SkillToggle[4].isOn = true;
            RaceSkillToggle[4].interactable = false;
            SkillToggle[4].interactable = false;
            RaceSkillToggle[16].isOn = true;
            SkillToggle[16].isOn = true;
            RaceSkillToggle[16].interactable = false;
            SkillToggle[16].interactable = false;
        }
        else if (Background.captionText.text == "Entertainer")
        {
            RaceSkillToggle[0].isOn = true;
            SkillToggle[0].isOn = true;
            RaceSkillToggle[0].interactable = false;
            SkillToggle[0].interactable = false;
            RaceSkillToggle[12].isOn = true;
            SkillToggle[12].isOn = true;
            RaceSkillToggle[12].interactable = false;
            SkillToggle[12].interactable = false;
        }
        else if (Background.captionText.text == "Folk Hero")
        {
            RaceSkillToggle[1].isOn = true;
            SkillToggle[1].isOn = true;
            RaceSkillToggle[1].interactable = false;
            SkillToggle[1].interactable = false;
            RaceSkillToggle[17].isOn = true;
            SkillToggle[17].isOn = true;
            RaceSkillToggle[17].interactable = false;
            SkillToggle[17].interactable = false;
        }
        else if (Background.captionText.text == "Guild Artisan")
        {
            RaceSkillToggle[6].isOn = true;
            SkillToggle[6].isOn = true;
            RaceSkillToggle[6].interactable = false;
            SkillToggle[6].interactable = false;
            RaceSkillToggle[13].isOn = true;
            SkillToggle[13].isOn = true;
            RaceSkillToggle[13].interactable = false;
            SkillToggle[13].interactable = false;
        }
        else if (Background.captionText.text == "Hermit")
        {
            RaceSkillToggle[9].isOn = true;
            SkillToggle[9].isOn = true;
            RaceSkillToggle[9].interactable = false;
            SkillToggle[9].interactable = false;
            RaceSkillToggle[14].isOn = true;
            SkillToggle[14].isOn = true;
            RaceSkillToggle[14].interactable = false;
            SkillToggle[14].interactable = false;
        }
        else if (Background.captionText.text == "Noble")
        {
            RaceSkillToggle[5].isOn = true;
            SkillToggle[5].isOn = true;
            RaceSkillToggle[5].interactable = false;
            SkillToggle[5].interactable = false;
            RaceSkillToggle[13].isOn = true;
            SkillToggle[13].isOn = true;
            RaceSkillToggle[13].interactable = false;
            SkillToggle[13].interactable = false;
        }
        else if (Background.captionText.text == "Outlander")
        {
            RaceSkillToggle[3].isOn = true;
            SkillToggle[3].isOn = true;
            RaceSkillToggle[3].interactable = false;
            SkillToggle[3].interactable = false;
            RaceSkillToggle[17].isOn = true;
            SkillToggle[17].isOn = true;
            RaceSkillToggle[17].interactable = false;
            SkillToggle[17].interactable = false;
        }
        else if (Background.captionText.text == "Sage")
        {
            RaceSkillToggle[2].isOn = true;
            SkillToggle[2].isOn = true;
            RaceSkillToggle[2].interactable = false;
            SkillToggle[2].interactable = false;
            RaceSkillToggle[5].isOn = true;
            SkillToggle[5].isOn = true;
            RaceSkillToggle[5].interactable = false;
            SkillToggle[5].interactable = false;
        }
        else if (Background.captionText.text == "Sailor")
        {
            RaceSkillToggle[3].isOn = true;
            SkillToggle[3].isOn = true;
            RaceSkillToggle[3].interactable = false;
            SkillToggle[3].interactable = false;
            RaceSkillToggle[11].isOn = true;
            SkillToggle[11].isOn = true;
            RaceSkillToggle[11].interactable = false;
            SkillToggle[11].interactable = false;
        }
        else if (Background.captionText.text == "Soldier")
        {
            RaceSkillToggle[3].isOn = true;
            SkillToggle[3].isOn = true;
            RaceSkillToggle[3].interactable = false;
            SkillToggle[3].interactable = false;
            RaceSkillToggle[7].isOn = true;
            SkillToggle[7].isOn = true;
            RaceSkillToggle[7].interactable = false;
            SkillToggle[7].interactable = false;
        }
        else if (Background.captionText.text == "Urchin")
        {
            RaceSkillToggle[15].isOn = true;
            SkillToggle[15].isOn = true;
            RaceSkillToggle[15].interactable = false;
            SkillToggle[15].interactable = false;
            RaceSkillToggle[16].isOn = true;
            SkillToggle[16].isOn = true;
            RaceSkillToggle[16].interactable = false;
            SkillToggle[16].interactable = false;
        }
    }

    public void SkillsUpdate()
    {
        for(int i = 0; i < 18; i++)
        {
            if (SkillToggle[i].isOn && SkillToggle[i].interactable == true)
            {
                RaceSkillToggle[i].interactable = false;
                RaceSkillToggle[i].isOn = true;
            }
            else if (!SkillToggle[i].isOn)
            {
                RaceSkillToggle[i].interactable = true;
                RaceSkillToggle[i].isOn = false;
            }
            if (RaceSkillToggle[i].isOn && RaceSkillToggle[i].interactable == true)
            {
                SkillToggle[i].interactable = false;
                SkillToggle[i].isOn = true;
            }
        }
        BackgroundUpdate();
        FinishToggle();
    }

    public void RaceSkillsUpdate()
    {
        if (RaceSkillsContainer.activeInHierarchy)
        {
            for (int i = 0; i < 18; i++)
            {
                if (RaceSkillToggle[i].isOn && RaceSkillToggle[i].interactable == true)
                {
                    SkillToggle[i].interactable = false;
                    SkillToggle[i].isOn = true;
                }
                else if (!RaceSkillToggle[i].isOn && Allowed.Contains(i))
                {
                    SkillToggle[i].interactable = true;
                    SkillToggle[i].isOn = false;
                }
                else if (!RaceSkillToggle[i].isOn && !Allowed.Contains(i))
                {
                    SkillToggle[i].interactable = false;
                    SkillToggle[i].isOn = false;
                }
                if (SkillToggle[i].isOn && SkillToggle[i].interactable == true)
                {
                    RaceSkillToggle[i].interactable = false;
                    RaceSkillToggle[i].isOn = true;
                }
            }
            BackgroundUpdate();
            FinishToggle();
        }
    }

    public void FinishToggle()
    {
        int raceUsed = 0;
        for (int i = 0; i < 18; i++)
        {
            if (RaceSkillToggle[i].isOn && RaceSkillToggle[i].interactable == true)
            {
                raceUsed++;
            }
        }
        if (raceUsed >= NumAllowed)
        {
            for (int i = 0; i < 18; i++)
            {
                if (!RaceSkillToggle[i].isOn && RaceSkillToggle[i].interactable)
                {
                    RaceSkillToggle[i].interactable = false;
                }
            }
        }
        RaceChoicesLeft.text = NumRaceAllowed - raceUsed + "";
        int skillsUsed = 0;
        for (int i = 0; i < 18; i++)
        {
            if (SkillToggle[i].isOn && SkillToggle[i].interactable == true)
            {
                skillsUsed++;
            }
        }
        if (skillsUsed >= NumAllowed)
        {
            for (int i = 0; i < 18; i++)
            {
                if (!SkillToggle[i].isOn && SkillToggle[i].interactable)
                {
                    SkillToggle[i].interactable = false;
                }
            }
        }
        ChoicesLeft.text = NumAllowed - skillsUsed + "";
    }
}
