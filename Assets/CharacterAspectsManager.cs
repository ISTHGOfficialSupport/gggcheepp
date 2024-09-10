using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterAspectsManager : MonoBehaviour {

    public Dropdown Race;
    public Dropdown Class;
    public InputField Level;
    public Dropdown Background;
    public InputField PlayerName;
    public InputField ExperiancePoints;
    public InputField CharacterName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GetLevelByExperiance()
    {
        int tempInt = 0;
        if (ExperiancePoints.text != "")
        {
            tempInt = int.Parse(ExperiancePoints.text);
        }

        if(tempInt < 300)
        {
            Level.text = "1";
        }
        else if (tempInt >= 300 && tempInt < 900)
        {
            Level.text = "2";
        }
        else if (tempInt >= 900 && tempInt < 2700)
        {
            Level.text = "3";
        }
        else if (tempInt >= 2700 && tempInt < 6500)
        {
            Level.text = "4";
        }
        else if (tempInt >= 6500 && tempInt < 14000)
        {
            Level.text = "5";
        }
        else if (tempInt >= 14000 && tempInt < 23000)
        {
            Level.text = "6";
        }
        else if (tempInt >= 23000 && tempInt < 34000)
        {
            Level.text = "7";
        }
        else if (tempInt >= 34000 && tempInt < 48000)
        {
            Level.text = "8";
        }
        else if (tempInt >= 48000 && tempInt < 64000)
        {
            Level.text = "9";
        }
        else if (tempInt >= 64000 && tempInt < 85000)
        {
            Level.text = "10";
        }
        else if (tempInt >= 85000 && tempInt < 100000)
        {
            Level.text = "11";
        }
        else if (tempInt >= 100000 && tempInt < 120000)
        {
            Level.text = "12";
        }
        else if (tempInt >= 120000 && tempInt < 140000)
        {
            Level.text = "13";
        }
        else if (tempInt >= 140000 && tempInt < 165000)
        {
            Level.text = "14";
        }
        else if (tempInt >= 165000 && tempInt < 195000)
        {
            Level.text = "15";
        }
        else if (tempInt >= 195000 && tempInt < 225000)
        {
            Level.text = "16";
        }
        else if (tempInt >= 225000 && tempInt < 265000)
        {
            Level.text = "17";
        }
        else if (tempInt >= 265000 && tempInt < 305000)
        {
            Level.text = "18";
        }
        else if (tempInt >= 305000 && tempInt < 355000)
        {
            Level.text = "19";
        }
        else if (tempInt >= 355000)
        {
            Level.text = "20";
        }
    }

    public void GetExperianceByLevel()
    {
        if (Level.text == "1")
        {
            ExperiancePoints.text = "0";
        }
        else if (Level.text == "2")
        {
            ExperiancePoints.text = "300";
        }
        else if (Level.text == "3")
        {
            ExperiancePoints.text = "900";
        }
        else if (Level.text == "4")
        {
            ExperiancePoints.text = "2700";
        }
        else if (Level.text == "5")
        {
            ExperiancePoints.text = "6500";
        }
        else if (Level.text == "6")
        {
            ExperiancePoints.text = "14000";
        }
        else if (Level.text == "7")
        {
            ExperiancePoints.text = "23000";
        }
        else if (Level.text == "8")
        {
            ExperiancePoints.text = "34000";
        }
        else if (Level.text == "9")
        {
            ExperiancePoints.text = "48000";
        }
        else if (Level.text == "10")
        {
            ExperiancePoints.text = "64000";
        }
        else if (Level.text == "11")
        {
            ExperiancePoints.text = "85000";
        }
        else if (Level.text == "12")
        {
            ExperiancePoints.text = "100000";
        }
        else if (Level.text == "13")
        {
            ExperiancePoints.text = "120000";
        }
        else if (Level.text == "14")
        {
            ExperiancePoints.text = "140000";
        }
        else if (Level.text == "15")
        {
            ExperiancePoints.text = "165000";
        }
        else if (Level.text == "16")
        {
            ExperiancePoints.text = "195000";
        }
        else if (Level.text == "17")
        {
            ExperiancePoints.text = "225000";
        }
        else if (Level.text == "18")
        {
            ExperiancePoints.text = "265000";
        }
        else if (Level.text == "19")
        {
            ExperiancePoints.text = "305000";
        }
        else if (Level.text == "20")
        {
            ExperiancePoints.text = "355000";
        }
    }
}
