using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementR : MonoBehaviour {
	public GameObject BoosterN;
	public GameObject BoosterE;
	public GameObject BoosterS;
	public GameObject BoosterW;
	public static float BoostPower = .5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (BuildABomb.TwoPlayers == true && DyingLight.RedPowered == true) {


			
			if (Input.GetKey ("up")) {
				gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, BoostPower), ForceMode2D.Force);
				BoosterS.GetComponent<SpriteRenderer> ().enabled = true;
			} else {
				BoosterS.GetComponent<SpriteRenderer> ().enabled = false;
			}
			if (Input.GetKey ("right")) {
				gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (BoostPower, 0f), ForceMode2D.Force);
				BoosterW.GetComponent<SpriteRenderer> ().enabled = true;
			} else {
				BoosterW.GetComponent<SpriteRenderer> ().enabled = false;
			}
			if (Input.GetKey ("down")) {
				gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, BoostPower * -1f), ForceMode2D.Force);
				BoosterN.GetComponent<SpriteRenderer> ().enabled = true;
			} else {
				BoosterN.GetComponent<SpriteRenderer> ().enabled = false;
			}
			if (Input.GetKey ("left")) {
				gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (BoostPower * -1f, 0f), ForceMode2D.Force);
				BoosterE.GetComponent<SpriteRenderer> ().enabled = true;
			} else {
				BoosterE.GetComponent<SpriteRenderer> ().enabled = false;
			}
		}

	}
}
