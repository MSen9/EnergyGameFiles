using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VersusLoad : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown () {
		SceneManager.LoadScene (2);
		BuildABomb.TwoPlayers = true;
		ScoreSaver.RedScore = 0;
		ScoreSaver.BlueScore = 0;
		DyingLight.BluePowered = true;
		DyingLight.RedPowered = true;
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
