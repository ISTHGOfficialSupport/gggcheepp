using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProficiencyManager : MonoBehaviour {

    public bool ProficiencyType;
    public List<InputField> Levels;
    public int LevelTotal;
    public Text Proficiency;


	// Use this for initialization
	void Start () {
        UpdateProficiency();
	}
	
	// Update is called once per frame
	void Update () {
        UpdateProficiency();
    }

    public void UpdateProficiency()
    {
        LevelTotal = 0;
        for(int i = 0; i < Levels.Count; i++)
        {
            if (Levels[i].text != "")
            {
                LevelTotal = LevelTotal + int.Parse(Levels[i].text);
            }
            else { LevelTotal++; }
        }
        if (!ProficiencyType)
        {
            if (1 <= LevelTotal && LevelTotal < 5)
            {
                Proficiency.text = "2";
            }
            else if (5 <= LevelTotal && LevelTotal < 9)
            {
                Proficiency.text = "3";
            }
            else if (9 <= LevelTotal && LevelTotal < 13)
            {
                Proficiency.text = "4";
            }
            else if (13 <= LevelTotal && LevelTotal < 17)
            {
                Proficiency.text = "5";
            }
            else
            {
                Proficiency.text = "6";
            }
        }
        else
        {
            if (1 <= LevelTotal && LevelTotal < 5)
            {
                Proficiency.text = "1d4";
            }
            else if (5 <= LevelTotal && LevelTotal < 9)
            {
                Proficiency.text = "1d6";
            }
            else if (9 <= LevelTotal && LevelTotal < 13)
            {
                Proficiency.text = "1d8";
            }
            else if (13 <= LevelTotal && LevelTotal < 17)
            {
                Proficiency.text = "1d10";
            }
            else
            {
                Proficiency.text = "1d12";
            }
        }
    }
}
