using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SurvivalLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		SceneManager.LoadScene (3);
		BuildABomb.TwoPlayers = false;
	}
}
