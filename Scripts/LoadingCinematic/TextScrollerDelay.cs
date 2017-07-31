using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TextScrollerDelay : MonoBehaviour {
	public TextMesh StartText;
	public AudioSource Boom;
	public float ScrollSpeed = .01f;
	float TextMoved = -4.25f;
	bool LameJokeMade;
	// Use this for initialization
	void Start () {
		StartCoroutine (joke());


	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (LameJokeMade == true) {
			TextMoved += ScrollSpeed;
			gameObject.transform.position = new Vector3 (-4.67f, TextMoved, 0f);
		}
		if (Input.anyKey) {
			Time.timeScale = 2f;
		} else {
			Time.timeScale = 1f;
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene (1);
		}


	}
	IEnumerator joke(){
		yield return new WaitForSeconds (0.2f);
		StartText.text += " The";
		yield return new WaitForSeconds (0.2f);
		StartText.text += " Year";
		yield return new WaitForSeconds (0.2f);
		StartText.text += "2";
		yield return new WaitForSeconds (0.5f);
		//play a sound effect
		StartText.text += "X";
		Boom.Play ();
		yield return new WaitForSeconds (0.5f);
		StartText.text += "X";
		Boom.Play ();
		yield return new WaitForSeconds (0.5f);
		StartText.text += "X";
		Boom.Play ();
		yield return new WaitForSeconds (0.5f);
		StartText.text += "_D4RKKN1GHT1337_XXX2";
		//Comedic pause
		yield return new WaitForSeconds (.5f);
		StartText.text = "In The Year 2XXX";
		LameJokeMade = true;

	}
}
