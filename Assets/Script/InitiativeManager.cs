using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitiativeManager : MonoBehaviour {

    public Text Initiative;
    public Text Score;
    public Text Modifier;
    public int Extras;

	// Use this for initialization
	void Start () {
        UpdateInitiative();
    }
	
	// Update is called once per frame
	void Update () {
        UpdateInitiative();
    }

    public void UpdateInitiative()
    {
        if (Score.text == "")
        {
            Initiative.text = "";
        }
        else
        {
            Initiative.text = (int.Parse(Modifier.text) + Extras).ToString() + "." + Score.text;
        }
    }
}
