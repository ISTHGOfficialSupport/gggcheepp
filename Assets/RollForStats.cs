using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollForStats : MonoBehaviour {

    public List<Text> RaceModifier;
    public List<Text> Total;
    public List<Dropdown> RollSelect;
    public List<Toggle> RaceToggles;
    public Dropdown Race;
    public Dropdown Subrace;
    public Dropdown Type;
    int StatType = 1;
    public GameObject PointsLeftContainer;
    public Text PointsLeft;
    public Text StatsRolled;

	// Use this for initialization
	void Start () {
        RaceBonuses();
        Calculate();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Calculate()
    {
        if (StatType == 1 || StatType == 3 || StatType == 4)
        {
            for (int i = 0; i < 6; i++)
            {
                int tempInt = 0;
                if (RollSelect[i].captionText.text != "-")
                {
                    tempInt = int.Parse(RollSelect[i].captionText.text);
                }
                tempInt = tempInt + int.Parse(RaceModifier[i].text);
                Total[i].text = tempInt + "";
            }
        }
        else if(StatType == 2)
        {
            int pointsLeft = 27;
            for (int i = 0; i < 6; i++)
            {
                int tempInt = 0;
                if (RollSelect[i].captionText.text == "8:Cost=0")
                {
                    tempInt = 8;
                }
                else if (RollSelect[i].captionText.text == "9:Cost=1")
                {
                    tempInt = 9;
                    pointsLeft = pointsLeft - 1;
                }
                else if (RollSelect[i].captionText.text == "10:Cost=2")
                {
                    tempInt = 10;
                    pointsLeft = pointsLeft - 2;
                }
                else if (RollSelect[i].captionText.text == "11:Cost=3")
                {
                    tempInt = 11;
                    pointsLeft = pointsLeft - 3;
                }
                else if (RollSelect[i].captionText.text == "12:Cost=4")
                {
                    tempInt = 12;
                    pointsLeft = pointsLeft - 4;
                }
                else if (RollSelect[i].captionText.text == "13:Cost=5")
                {
                    tempInt = 13;
                    pointsLeft = pointsLeft - 5;
                }
                else if (RollSelect[i].captionText.text == "14:Cost=7")
                {
                    tempInt = 14;
                    pointsLeft = pointsLeft - 7;
                }
                else if (RollSelect[i].captionText.text == "15:Cost=9")
                {
                    tempInt = 15;
                    pointsLeft = pointsLeft - 9;
                }
                PointsLeft.text = pointsLeft + "";
                if(pointsLeft < 0)
                {
                    PointsLeft.color = Color.red;
                }
                else
                {
                    PointsLeft.color = Color.black;
                }
                tempInt = tempInt + int.Parse(RaceModifier[i].text);
                Total[i].text = tempInt + "";
            }
        }
        
    }

    public void ChangeStatType()
    {
        PointsLeftContainer.SetActive(false);
        StatsRolled.gameObject.SetActive(false);
        if (Type.captionText.text == "Standard Array")
        {
            StatType = 1;
        }
        else if(Type.captionText.text == "Point Buy")
        {
            StatType = 2;
            PointsLeftContainer.SetActive(true);
            PointsLeft.text = "27";
        }
        else if(Type.captionText.text == "Roll For Stats")
        {
            StatType = 3;
            StatsRolled.gameObject.SetActive(true);
        }
        else if(Type.captionText.text == "Stat Entry")
        {
            StatType = 4;
        }
        PopulateDropdowns();
    }

    public void PopulateDropdowns()
    {
        if(StatType == 1)
        {
            List<string> StandardArray = new List<string>();
            StandardArray.Add("-");
            StandardArray.Add("15");
            StandardArray.Add("14");
            StandardArray.Add("13");
            StandardArray.Add("12");
            StandardArray.Add("10");
            StandardArray.Add("8");
            for (int i = 0; i < 6; i++)
            {
                RollSelect[i].ClearOptions();
                RollSelect[i].AddOptions(StandardArray);
            }
        }
        else if (StatType == 2)
        {
            List<string> PointBuy = new List<string>();
            PointBuy.Add("-");
            PointBuy.Add("8:Cost=0");
            PointBuy.Add("9:Cost=1");
            PointBuy.Add("10:Cost=2");
            PointBuy.Add("11:Cost=3");
            PointBuy.Add("12:Cost=4");
            PointBuy.Add("13:Cost=5");
            PointBuy.Add("14:Cost=7");
            PointBuy.Add("15:Cost=9");
            for (int i = 0; i < 6; i++)
            {
                RollSelect[i].ClearOptions();
                RollSelect[i].AddOptions(PointBuy);
            }
        }
        else if(StatType == 3)
        {
            List<string> RollForStats = new List<string>();
            RollForStats.Add("-");
            StatsRolled.text = "Stats rolled: ";
            List<int> RolledStats = new List<int>();
            for(int i = 0; i < 6; i++)
            {
                int tempInt = 0;
                List<int> tempints = new List<int>();
                for (int j = 0; j < 4; j++)
                {
                    tempints.Add(Random.Range(1, 7));
                }
                tempints.Sort();
                tempInt = tempints[1] + tempints[2] + tempints[3];
                //Debug.Log(tempints[1] + "+" + tempints[2] + "+" + tempints[3] + "=" + tempInt);
                RolledStats.Add(tempInt);
            }
            RolledStats.Sort();
            for(int i = 0; i < 6; i++)
            {
                RollForStats.Add(RolledStats[i] + "");
            }
            for (int i = 0; i < 6; i++)
            {
                if (i != 5)
                {
                    StatsRolled.text = StatsRolled.text + RollForStats[i+1] + ", ";
                }
                else
                {
                    StatsRolled.text = StatsRolled.text + RollForStats[i+1];
                }
                RollSelect[i].ClearOptions();
                RollSelect[i].AddOptions(RollForStats);
            }
        }
        else if (StatType == 4)
        {
            List<string> StatEntry = new List<string>();
            StatEntry.Add("-");
            for (int i = 0; i < 21; i++)
            {
                StatEntry.Add(i + "");
            }
            for (int i = 0; i < 6; i++)
            {
                RollSelect[i].ClearOptions();
                RollSelect[i].AddOptions(StatEntry);
            }
        }
    }
    
    public void RaceBonuses()
    {
        for(int i = 0; i < 6; i++)
        {
            RaceModifier[i].text = "0";
            RaceModifier[i].gameObject.SetActive(true);
            RaceToggles[i].gameObject.SetActive(false);
        }
        if (Race.captionText.text == "Dwarf")
        {
            RaceModifier[2].text = "2";
            if (Subrace.captionText.text == "Hill")
            {
                RaceModifier[4].text = "1";
            }
            else if(Subrace.captionText.text == "Mountain")
            {
                RaceModifier[0].text = "2";
            }
        }
        else if (Race.captionText.text == "Elf")
        {
            RaceModifier[1].text = "2";
            if (Subrace.captionText.text == "High")
            {
                RaceModifier[3].text = "1";
            }
            else if (Subrace.captionText.text == "Wood")
            {
                RaceModifier[4].text = "1";
            }
            else if (Subrace.captionText.text == "Dark")
            {
                RaceModifier[5].text = "1";
            }
        }
        else if (Race.captionText.text == "Halfling")
        {
            RaceModifier[1].text = "2";
            if (Subrace.captionText.text == "Lightfoot")
            {
                RaceModifier[5].text = "1";
            }
            else if (Subrace.captionText.text == "Stout")
            {
                RaceModifier[2].text = "1";
            }
        }
        else if (Race.captionText.text == "Human")
        {
            if (Subrace.captionText.text == "Default")
            {
                RaceModifier[0].text = "1";
                RaceModifier[1].text = "1";
                RaceModifier[2].text = "1";
                RaceModifier[3].text = "1";
                RaceModifier[4].text = "1";
                RaceModifier[5].text = "1";
            }
            else if(Subrace.captionText.text == "Variant")
            {
                for (int i = 0; i < 6; i++)
                {
                    RaceModifier[i].gameObject.SetActive(false);
                    RaceToggles[i].gameObject.SetActive(true);
                    RaceToggles[i].isOn = false;
                }
                RaceToggleThings();
            }
        }
        else if (Race.captionText.text == "Dragonborn")
        {
            RaceModifier[0].text = "2";
            RaceModifier[5].text = "1";
        }
        else if (Race.captionText.text == "Gnome")
        {
            RaceModifier[3].text = "2";
            if (Subrace.captionText.text == "Forest")
            {
                RaceModifier[1].text = "1";
            }
            else if (Subrace.captionText.text == "Rock")
            {
                RaceModifier[5].text = "1";
            }
        }
        else if (Race.captionText.text == "Half-Elf")
        {
            RaceModifier[5].text = "2";
            for (int i = 0; i < 5; i++)
            {
                RaceModifier[i].gameObject.SetActive(false);
                RaceToggles[i].gameObject.SetActive(true);
                RaceToggles[i].isOn = false;
            }
            RaceToggleThings();
        }
        else if (Race.captionText.text == "Half-Orc")
        {
            RaceModifier[0].text = "2";
            RaceModifier[2].text = "1";
        }
        else if (Race.captionText.text == "Tiefling")
        {
            RaceModifier[3].text = "1";
            RaceModifier[5].text = "5";
        }
        Calculate();
    }

    public void RaceToggleThings()
    {
        int ToggleTotal = 0;
        for(int i = 0; i < 6; i++)
        {
            if (RaceToggles[i].isOn)
            {
                RaceModifier[i].text = "1";
                ToggleTotal++;
            }
            else if (!RaceToggles[i].isOn)
            {
                RaceModifier[i].text = "0";
            }
            RaceToggles[i].interactable = true;
        }
        if (ToggleTotal >= 2)
        {
            for (int i = 0; i < 6; i++)
            {
                if (!RaceToggles[i].isOn)
                {
                    RaceToggles[i].interactable = false;
                }
            }
        }
        if (Race.captionText.text == "Half-Elf")
        {
            RaceModifier[5].text = "2";
        }
        Calculate();
    }

}
