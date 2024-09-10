using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedManager : MonoBehaviour {

    public Text Speed;
    public int Extra;
    int Base;
    public Dropdown Race;
    public Dropdown Class;
    public ArmorClassManager ACManager;
    public InputField Level;
    int ClassSpeed;

	// Use this for initialization
	void Start () {
        UpdateSpeed();
    }
	
	// Update is called once per frame
	void Update () {
        UpdateSpeed();
    }

    public void UpdateSpeed()
    {
        SetBase();
        ClassExtra();
        Speed.text = (Base + Extra + ClassSpeed).ToString() + "ft";
    }

    public void SetBase()
    {
        if(Race.captionText.text == "Hill Dwarf" || Race.captionText.text == "Mountain Dwarf" || Race.captionText.text == "Lightfoot Halfling" || Race.captionText.text == "Scout Halfling" || Race.captionText.text == "Forest Gnome" || Race.captionText.text == "Rock Gnome")
        {
            Base = 25;
        }
        else if (Race.captionText.text == "Wood Elf")
        {
            Base = 35;
        }
        else
        {
            Base = 30;
        }
    }

    public void ClassExtra()
    {
        ClassSpeed = 0;
        if (!ACManager.Armoured)
        {
            if (Class.captionText.text.Contains("Monk"))
            {
                if(Level.text == "")
                {
                    Level.text = "1";
                }
                if(int.Parse(Level.text) >= 2 && int.Parse(Level.text) < 6)
                {
                    ClassSpeed = 10;
                }
                else if (int.Parse(Level.text) >= 6 && int.Parse(Level.text) < 10)
                {
                    ClassSpeed = 15;
                }
                else if (int.Parse(Level.text) >= 10 && int.Parse(Level.text) < 14)
                {
                    ClassSpeed = 20;
                }
                else if (int.Parse(Level.text) >= 14 && int.Parse(Level.text) < 17)
                {
                    ClassSpeed = 25;
                }
                else if (int.Parse(Level.text) >= 17 && int.Parse(Level.text) <= 20)
                {
                    ClassSpeed = 30;
                }
            }
        }
    }
}
