using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlayM : MonoBehaviour {
	public GameObject Camera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		Camera.transform.position = new Vector3 (0, -20, -10);
	}
}
