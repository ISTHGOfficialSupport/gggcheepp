using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsManager : MonoBehaviour {

    public List<Toggle> Skills;
    public Text Proficiency;
    public List<Text> Stats;
    public Dropdown Race;

	// Use this for initialization
	void Start () {
        UpdateSkills();
    }
	
	// Update is called once per frame
	void Update () {
        UpdateSkills();
    }

    public void UpdateSkills()
    {
        for (int i = 0; i < Skills.Count; i++)
        {
            if (i == 3)
            {
                Skills[i].GetComponentInChildren<Text>().text = Stats[0].text;
            }
            if (Skills[i].isOn)
            {
                Skills[i].GetComponentInChildren<Text>().text = Stats[0].text + "+" + Proficiency.text;
            }
            else if (i == 0 || i == 15 || i == 16)
            {
                Skills[i].GetComponentInChildren<Text>().text = Stats[1].text;
            }
            if (Skills[i].isOn)
            {
                Skills[i].GetComponentInChildren<Text>().text = Stats[1].text + "+" + Proficiency.text;
            }
            else if (i == 2 || i == 5 || i == 8 || i == 10 || i == 14)
            {
                Skills[i].GetComponentInChildren<Text>().text = Stats[3].text;
            }
            if (Skills[i].isOn)
            {
                Skills[i].GetComponentInChildren<Text>().text = Stats[3].text + "+" + Proficiency.text;
            }
            else if (i == 1 || i == 6 || i == 9 || i == 11 || i == 17)
            {
                Skills[i].GetComponentInChildren<Text>().text = Stats[4].text;
            }
            if (Skills[i].isOn)
            {
                Skills[i].GetComponentInChildren<Text>().text = Stats[4].text + "+" + Proficiency.text;
            }
            else if (i == 4 || i == 7 || i == 12 || i == 13)
            {
                Skills[i].GetComponentInChildren<Text>().text = Stats[5].text;
            }
            if (Skills[i].isOn)
            {
                Skills[i].GetComponentInChildren<Text>().text = Stats[5].text + "+" + Proficiency.text;
            }
        }
    }


    public void RaceSkills()
    {
        if(Race.captionText.text == "High Elf")
        {
            Skills[11].isOn = true;
        }
        else if (Race.captionText.text == "Wood Elf")
        {
            Skills[11].isOn = true;
        }
        else if (Race.captionText.text == "Dark Elf")
        {
            Skills[11].isOn = true;
        }
        else if(Race.captionText.text == "Half-Orc")
        {
            Skills[7].isOn = true;
        }
    }
}
