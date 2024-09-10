using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatManager : MonoBehaviour {

    public List<InputField> Stats;
    public List<Text> StatTotals;
    public List<int> BaseScore;
    public List<Text> Modifiers;
    public List<int> extras;
    public List<int> RaceBonus;
    public Dropdown Race;

	// Use this for initialization
	void Start () {
        BaseScore.Add(0);
        BaseScore.Add(0);
        BaseScore.Add(0);
        BaseScore.Add(0);
        BaseScore.Add(0);
        BaseScore.Add(0);
        UpdateStats();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        UpdateStats();
    }

    public void ChangeExtras(int stat, int change)
    {
        extras[stat] = extras[stat] + change;
    }

    public void UpdateStats()
    {
        UpdateRaceBonus();
        for (int i = 0; i < Stats.Count; i++)
        {
            if (Stats[i].text == "")
            {
                int tempint = BaseScore[i];
                tempint = tempint + RaceBonus[i] + extras[i];
                if (extras[i] != 0)
                {
                    Modifiers[i].color = Color.cyan;
                }
                else
                {
                    Modifiers[i].color = Color.black;
                }
                Modifiers[i].text = ((tempint / 2) - 5).ToString();
                StatTotals[i].text = tempint + "";
            }
            else
            {
                Stats[i].text = "0";
            }
        }
    }

    public void SetStats(int value, int stat)
    {
        Stats[stat].text = value.ToString();
    }

    public void RollRandom()
    {
        for (int i = 0; i < 6; i++)
        {
            List<int> tempints = new List<int>();
            for(int j = 0; j < 4; j++)
            {
                tempints.Add(Random.Range(1, 7));
            }
            tempints.Sort();
            Stats[i].text = (tempints[1] + tempints[2] + tempints[3]).ToString();
        }
    }

    public void UpdateRaceBonus()
    {
        if(Race.captionText.text == "Hill Dwarf")
        {
            RaceBonus[0] = 0;
            RaceBonus[1] = 0;
            RaceBonus[2] = 2;
            RaceBonus[3] = 0;
            RaceBonus[4] = 0;
            RaceBonus[5] = 1;
        }
        else if(Race.captionText.text == "Mountain Dwarf")
        {
            RaceBonus[0] = 2;
            RaceBonus[1] = 0;
            RaceBonus[2] = 2;
            RaceBonus[3] = 0;
            RaceBonus[4] = 0;
            RaceBonus[5] = 0;
        }
        else if (Race.captionText.text == "High Elf")
        {
            RaceBonus[0] = 0;
            RaceBonus[1] = 2;
            RaceBonus[2] = 0;
            RaceBonus[3] = 1;
            RaceBonus[4] = 0;
            RaceBonus[5] = 0;
        }
        else if (Race.captionText.text == "Wood Elf")
        {
            RaceBonus[1] = 2;
            RaceBonus[4] = 1;
        }
        else if (Race.captionText.text == "Dark Elf")
        {
            RaceBonus[0] = 0;
            RaceBonus[1] = 2;
            RaceBonus[2] = 0;
            RaceBonus[3] = 0;
            RaceBonus[4] = 0;
            RaceBonus[5] = 1;
        }
        else if (Race.captionText.text == "Lightfoot Halfling")
        {
            RaceBonus[0] = 0;
            RaceBonus[1] = 2;
            RaceBonus[2] = 0;
            RaceBonus[3] = 0;
            RaceBonus[4] = 0;
            RaceBonus[5] = 1;
        }
        else if (Race.captionText.text == "Stout Halfling")
        {
            RaceBonus[0] = 0;
            RaceBonus[1] = 2;
            RaceBonus[2] = 1;
            RaceBonus[3] = 0;
            RaceBonus[4] = 0;
            RaceBonus[5] = 0;
        }
        else if (Race.captionText.text == "Human")
        {
            RaceBonus[0] = 1;
            RaceBonus[1] = 1;
            RaceBonus[2] = 1;
            RaceBonus[3] = 1;
            RaceBonus[4] = 1;
            RaceBonus[5] = 1;
        }
        else if (Race.captionText.text == "Dragonborn")
        {
            RaceBonus[0] = 2;
            RaceBonus[1] = 0;
            RaceBonus[2] = 0;
            RaceBonus[3] = 0;
            RaceBonus[4] = 0;
            RaceBonus[5] = 1;
        }
        else if (Race.captionText.text == "Forest Gnome")
        {
            RaceBonus[0] = 0;
            RaceBonus[1] = 1;
            RaceBonus[2] = 0;
            RaceBonus[3] = 2;
            RaceBonus[4] = 0;
            RaceBonus[5] = 0;
        }
        else if (Race.captionText.text == "Rock Gnome")
        {
            RaceBonus[0] = 0;
            RaceBonus[1] = 0;
            RaceBonus[2] = 1;
            RaceBonus[3] = 2;
            RaceBonus[4] = 0;
            RaceBonus[5] = 0;
        }
        else if (Race.captionText.text == "Half-Elf")
        {
            RaceBonus[5] = 2;
            RaceBonus[Random.Range(0, 5)] = 1;
            RaceBonus[Random.Range(0, 5)] = 1;
        }
        else if (Race.captionText.text == "Half-Orc")
        {
            RaceBonus[0] = 2;
            RaceBonus[1] = 0;
            RaceBonus[2] = 1;
            RaceBonus[3] = 0;
            RaceBonus[4] = 0;
            RaceBonus[5] = 0;
        }
        else if (Race.captionText.text == "Tiefling")
        {
            RaceBonus[0] = 0;
            RaceBonus[1] = 0;
            RaceBonus[2] = 0;
            RaceBonus[3] = 1;
            RaceBonus[4] = 0;
            RaceBonus[5] = 2;
            
        }
        else
        {
            RaceBonus[0] = 0;
            RaceBonus[1] = 0;
            RaceBonus[2] = 0;
            RaceBonus[3] = 0;
            RaceBonus[4] = 0;
            RaceBonus[5] = 0;
        }
    }

    public void UpdateBase()
    {
        for(int i = 0; i < 5; i++)
        {
            BaseScore[i] = int.Parse(Stats[i].text);
        }
    }
}
