using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour {

    public GameObject MainPrefab;
    public InputField TextInput;
    public GameObject ChatContainer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PostMessage(string input)
    {
        GameObject tempObject = Instantiate(MainPrefab, ChatContainer.transform);
        tempObject.GetComponentInChildren<Text>().text = input + "\n" + System.DateTime.Now;
    }

    public void ButtonSend()
    {
        if(TextInput.text != "")
        {
            PostMessage(TextInput.text);
            TextInput.text = "";
        }
    }
}
