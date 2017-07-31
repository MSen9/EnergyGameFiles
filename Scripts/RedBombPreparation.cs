using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBombPreparation : MonoBehaviour {
	public static bool RedBombPrepared;
	public static float RedBombGrowth = .1f;
	float yScale = RedBombGrowth;
	float xScale = RedBombGrowth;
	// Use this for initialization
	void Start () {
		gameObject.transform.localScale = new Vector3(.1f,.1f,1f);
		gameObject.GetComponent<SpriteRenderer>().color = Color.gray;
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (gameObject.transform.localScale.x <= 1f) {
			yScale += .01f;
			xScale += .01f;
			gameObject.transform.localScale = new Vector3 (xScale, yScale, 1f);
		} else {
			gameObject.GetComponent<SpriteRenderer>().color = Color.white;
			RedBombPrepared = true;
		}

	}
}
