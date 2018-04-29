using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextObject : MonoBehaviour {

	public Text channel1TextObject;
	public Text channel2TextObject;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void updateChannel1Text (string text) {
		channel1TextObject.text = "CH 1: " + text;
	}

	public void updateChannel2Text (string text) {
		channel2TextObject.text = "CH 2: " + text;
	}
}
