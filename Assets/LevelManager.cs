using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public Dropdown Class1;
    public Dropdown Multiclass1;
    public Dropdown Multiclass2;
    public Dropdown Multiclass3;
    public GameObject Multiclass1Container;
    public GameObject Multiclass2Container;
    public GameObject Multiclass3Container;
    public Text TotalLevel;

    // Use this for initialization
    void Start () {
        List<string> tempList = new List<string>();
        tempList.Add("-");
        for (int i = 1; i <= 20; i++)
        {
            tempList.Add(i + "");
        }
        Multiclass1.ClearOptions();
        Multiclass2.ClearOptions();
        Multiclass3.ClearOptions();
        Multiclass1.AddOptions(tempList);
        Multiclass2.AddOptions(tempList);
        Multiclass3.AddOptions(tempList);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateLevels()
    {
        Multiclass1Container.SetActive(true);
        Multiclass2Container.SetActive(true);
        Multiclass3Container.SetActive(true);
        int LevelTotal = 0;
        int tempClass1 = int.Parse(Class1.captionText.text);
        int tempMulticlass1 = 0;
        if (Multiclass1.captionText.text != "-")
        {
            tempMulticlass1 = int.Parse(Multiclass1.captionText.text);
        }
        int tempMulticlass2 = 0;
        if (Multiclass2.captionText.text != "-")
        {
            tempMulticlass2 = int.Parse(Multiclass2.captionText.text);
        }
        int tempMulticlass3 = 0;
        if (Multiclass3.captionText.text != "-")
        {
            tempMulticlass3 = int.Parse(Multiclass3.captionText.text);
        }
        LevelTotal = tempClass1 + tempMulticlass1 + tempMulticlass2 + tempMulticlass3;
        TotalLevel.text = "Total Level: " + LevelTotal;
        if (LevelTotal > 20)
        {
            TotalLevel.color = Color.red;
        }
    }
}
