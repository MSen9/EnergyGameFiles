using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour {
	public float AIForce = 1f;
	public GameObject MainChar;
	public GameObject BoosterN;
	public GameObject BoosterE;
	public GameObject BoosterS;
	public GameObject BoosterW;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (MainChar.transform.position.x > gameObject.transform.position.x) {
			//If MC is to the right
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(AIForce, 0f),ForceMode2D.Force);
			BoosterW.GetComponent<SpriteRenderer> ().enabled = true;
		} else {
			BoosterW.GetComponent<SpriteRenderer> ().enabled = false;

		}
		if (MainChar.transform.position.x < gameObject.transform.position.x) {
			//If MC is to the left
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(AIForce * -1, 0f),ForceMode2D.Force);
			BoosterE.GetComponent<SpriteRenderer> ().enabled = true;
		} else {
			BoosterE.GetComponent<SpriteRenderer> ().enabled = false;
		}
		if (MainChar.transform.position.y > gameObject.transform.position.y) {
			//If MC is to the above
			gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, AIForce), ForceMode2D.Force);
			BoosterS.GetComponent<SpriteRenderer> ().enabled = true;
		} else {
			BoosterS.GetComponent<SpriteRenderer> ().enabled = false;
		}
		if (MainChar.transform.position.y < gameObject.transform.position.y) {
			//If MC is to the below
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -1 * AIForce),ForceMode2D.Force);
			BoosterN.GetComponent<SpriteRenderer> ().enabled = true;
		} else {
			BoosterN.GetComponent<SpriteRenderer> ().enabled = false;
		}

	}
}
