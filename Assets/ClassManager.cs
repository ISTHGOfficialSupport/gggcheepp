using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassManager : MonoBehaviour {

    public Dropdown Class;
    public Dropdown Subclass;
    public Dropdown Level;

	// Use this for initialization
	void Start () {
        UpdateSubclass();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateSubclass()
    {
        Subclass.value = 0;
        Subclass.ClearOptions();
        List<string> SubclassOptions = new List<string>();
        Subclass.gameObject.SetActive(false);
        if(Class.captionText.text == "Barbarian" && int.Parse(Level.captionText.text) >= 3){
            SubclassOptions.Add("Path of the Berserker");
            SubclassOptions.Add("Path of the Totem Warrior");
            Subclass.gameObject.SetActive(true);
        }
        else if (Class.captionText.text == "Bard" && int.Parse(Level.captionText.text) >= 3)
        {
            SubclassOptions.Add("College of Lore");
            SubclassOptions.Add("College of Valor");
            Subclass.gameObject.SetActive(true);
        }
        else if (Class.captionText.text == "Cleric")
        {
            SubclassOptions.Add("Knowledge Domain");
            SubclassOptions.Add("Life Domain");
            SubclassOptions.Add("Light Domain");
            SubclassOptions.Add("Nature Domain");
            SubclassOptions.Add("Tempest Domain");
            SubclassOptions.Add("Trickery Domain");
            SubclassOptions.Add("War Domain");
            Subclass.gameObject.SetActive(true);
        }
        else if (Class.captionText.text == "Druid" && int.Parse(Level.captionText.text) >= 2)
        {
            SubclassOptions.Add("Circle of the Land");
            SubclassOptions.Add("Circle of the Moon");
            Subclass.gameObject.SetActive(true);
        }
        else if (Class.captionText.text == "Fighter" && int.Parse(Level.captionText.text) >= 3)
        {
            SubclassOptions.Add("Champion");
            SubclassOptions.Add("Battle Master");
            SubclassOptions.Add("Eldritch Knight");
            Subclass.gameObject.SetActive(true);
        }
        else if (Class.captionText.text == "Monk" && int.Parse(Level.captionText.text) >= 3)
        {
            SubclassOptions.Add("Way of the Open Hand");
            SubclassOptions.Add("Way of the Shadow");
            SubclassOptions.Add("Way of the Four Elements");
            Subclass.gameObject.SetActive(true);
        }
        else if (Class.captionText.text == "Paladin" && int.Parse(Level.captionText.text) >= 3)
        {
            SubclassOptions.Add("Oath of Devotion");
            SubclassOptions.Add("Oath of the Ancients");
            SubclassOptions.Add("Oath of Vengeance");
            Subclass.gameObject.SetActive(true);
        }
        else if (Class.captionText.text == "Ranger" && int.Parse(Level.captionText.text) >= 3)
        {
            SubclassOptions.Add("Hunter");
            SubclassOptions.Add("Beast Master");
            Subclass.gameObject.SetActive(true);
        }
        else if (Class.captionText.text == "Rogue" && int.Parse(Level.captionText.text) >= 3)
        {
            SubclassOptions.Add("Thief");
            SubclassOptions.Add("Assassin");
            SubclassOptions.Add("Arcane Trickster");
            Subclass.gameObject.SetActive(true);
        }
        else if (Class.captionText.text == "Sorcerer")
        {
            SubclassOptions.Add("Draconic Bloodlone");
            SubclassOptions.Add("Wild Magic");
            Subclass.gameObject.SetActive(true);
        }
        else if (Class.captionText.text == "Warlock")
        {
            SubclassOptions.Add("Archfey");
            SubclassOptions.Add("Fiend");
            SubclassOptions.Add("Great Old One");
            Subclass.gameObject.SetActive(true);
        }
        else if (Class.captionText.text == "Wizard" && int.Parse(Level.captionText.text) >= 2)
        {
            SubclassOptions.Add("School of Abjuration");
            SubclassOptions.Add("School of Conjuration");
            SubclassOptions.Add("School of Divination");
            SubclassOptions.Add("School of Enchantment");
            SubclassOptions.Add("School of Evocation");
            SubclassOptions.Add("School of Illusion");
            SubclassOptions.Add("School of Necromancy");
            SubclassOptions.Add("School of Transmutation");
            Subclass.gameObject.SetActive(true);
        }
        if(SubclassOptions.Count > 0)
        {
            Subclass.AddOptions(SubclassOptions);
        }
    }
}
