using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScroller : MonoBehaviour {
	bool Cue;
	public float ScrollSpeed = .01f;

	// Use this for initialization
	void Start () {
		StartCoroutine (WaitForCue ());
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Cue) {
			
			gameObject.transform.position = new Vector3 (transform.position.x, transform.position.y + ScrollSpeed, 0f);	
		}
		if (Input.anyKey) {
			Time.timeScale = 2f;
		} else {
			Time.timeScale = 1f;
		}
	}
	IEnumerator WaitForCue(){
		yield return new WaitForSeconds (3.8f);
		Cue = true;
	}
}
