using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomIN : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Camera> ().orthographicSize = 7.9f;
	}

	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Camera> ().orthographicSize -= .007f;
	}

}
