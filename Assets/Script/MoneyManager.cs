using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour {

    public List<InputField> Coinage;
    public float total;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < Coinage.Count; i++)
        {
            if (Coinage[i].text == "")
            {
                Coinage[i].text = "0";
            }
        }
    }

    public void ConvertCoinage()
    {
        total = (int.Parse(Coinage[1].text) / 100);
        total = total + (int.Parse(Coinage[1].text) / 10);
        total = total + (int.Parse(Coinage[2].text) / 2);
        total = total + (int.Parse(Coinage[3].text));
        Coinage[0].text = (int.Parse(Coinage[0].text) - ((int.Parse(Coinage[0].text) / 100)*100)).ToString();
        Coinage[1].text = (int.Parse(Coinage[1].text) - ((int.Parse(Coinage[1].text) / 10) * 10)).ToString();
        Coinage[2].text = (int.Parse(Coinage[2].text) - ((int.Parse(Coinage[2].text) / 2) * 2)).ToString();
        Coinage[3].text = total.ToString();
    }
}
