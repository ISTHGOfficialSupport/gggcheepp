using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavingThrowManager : MonoBehaviour {

    public Text Proficiency;
    public List<Text> StatModifiers;
    public List<Toggle> SavingThrows;

	// Use this for initialization
	void Start () {
        UpdateSavingThrows();
	}
	
	// Update is called once per frame
	void Update () {
        UpdateSavingThrows();
	}

    public void UpdateSavingThrows()
    {
        for(int i = 0; i < SavingThrows.Count; i++)
        {
            SavingThrows[i].GetComponentInChildren<Text>().text = StatModifiers[i].text;
            if (SavingThrows[i].isOn)
            {
                SavingThrows[i].GetComponentInChildren<Text>().text = SavingThrows[i].GetComponentInChildren<Text>().text + "+" + Proficiency.text;
            }
        }
    }
}
