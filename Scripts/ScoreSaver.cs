using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSaver : MonoBehaviour {
	public static float RedScore;
	public static float BlueScore;
	public TextMesh BlueText;
	public TextMesh RedText;
	// Use this for initialization
	void Awake () {
		
	}

	
	// Update is called once per frame
	void Update () {
		RedText.text = "" + RedScore;
		BlueText.text = "" + BlueScore;
	}
}
