using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassiveWisdomManager : MonoBehaviour {

    public Text Modifier;
    public Text Passive;
    public int Extra;
    public Toggle PerceptionSkill;
    public Text Proficiancy;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        UpdatePassive();
    }

    public void UpdatePassive()
    {
        if (PerceptionSkill.isOn)
        {
            Passive.text = (10 + int.Parse(Modifier.text) + Extra + int.Parse(Proficiancy.text)).ToString();
        }
        else
        {
            Passive.text = (10 + (int.Parse(Modifier.text)) + Extra).ToString();
        }
    }
}
