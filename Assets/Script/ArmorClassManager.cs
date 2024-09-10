using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorClassManager : MonoBehaviour {

    public Text ArmorClass;
    public Text Modifier;
    public int Extras;
    public bool Armoured;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        UpdateArmorClass();
    }

    public void UpdateArmorClass()
    {
        ArmorClass.text = (8 + int.Parse(Modifier.text) + Extras).ToString(); 
    }
}
