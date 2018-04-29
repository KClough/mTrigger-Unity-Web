using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class BluetoothWebEvents : MonoBehaviour {

	// NOTE cannot start bluetooth events from Unity due to web security standards
	// All bluetooth API must be started from a user action like a button click on a dom element.

	[DllImport("__Internal")]
	private static extern void startButtonClick();

	[DllImport("__Internal")]
	private static extern void stopButtonClick();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onStartButtonClick() {
		startButtonClick ();
	}

	public void onStopButtonClick() {
		stopButtonClick ();
	}
}
