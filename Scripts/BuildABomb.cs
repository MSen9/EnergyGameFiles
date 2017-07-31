using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildABomb : MonoBehaviour {
	public static bool TwoPlayers = true; 
	public GameObject BlueRobot;
	public GameObject BlueBomb;
	public GameObject BombCore;
	public GameObject BombClone;
	public GameObject RedRobot;
	public GameObject RedBomb;
	public GameObject RedBombCore;
	public GameObject RedBombClone;
	private bool ZBombOut;
	private bool RedBombOut;
	static public float RedExplosivePower = 3f;
	static public float BlueExplosivePower = 3f;
	float Damper;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
		if ((Input.GetKeyDown ("e") && DyingLight.BluePowered == true)) {
			if (BombZone.BlueBombZoneEntered == false) {
				if (Input.GetKeyDown ("e") && ZBombOut == false) {
					BombClone = Instantiate (BlueBomb, BlueRobot.transform.position, Quaternion.identity);
					ZBombOut = true;
				}

		 
			} if (Input.GetKeyDown ("e") && ZBombOut == true && BombPreparation.BombPrepared == false) {
				// play error sound effect

			}

			if (Input.GetKeyDown ("e") && ZBombOut == true && BombPreparation.BombPrepared == true) {
				//BOOM



				if (BombZone.BlueBombZoneEntered) {
					
					Damper = 1 / (Mathf.Abs (BlueRobot.transform.position.x - BombClone.transform.position.x) + Mathf.Abs (BlueRobot.transform.position.y - BombClone.transform.position.y));
					BlueRobot.GetComponent<Rigidbody2D> ().AddForce (new Vector2((BlueRobot.transform.position.x - BombClone.transform.position.x) * BlueExplosivePower * Damper, (BlueRobot.transform.position.y - BombClone.transform.position.y) * BlueExplosivePower * Damper), ForceMode2D.Impulse); 
				}
				if (BombZone.RedBombZoneEntered) {
					
					Damper = 1 / (Mathf.Abs (RedRobot.transform.position.x - BombClone.transform.position.x) + Mathf.Abs (RedRobot.transform.position.y - BombClone.transform.position.y));
					RedRobot.GetComponent<Rigidbody2D> ().AddForce (new Vector2((RedRobot.transform.position.x - BombClone.transform.position.x) * BlueExplosivePower * Damper, (RedRobot.transform.position.y - BombClone.transform.position.y) * BlueExplosivePower * Damper), ForceMode2D.Impulse); 
				}
	
						
					

				BombClone.GetComponent<AudioSource> ().Play();
				Destroy (BombClone);
				ZBombOut = false;
				BombPreparation.BombPrepared = false;
			}

		}
		if ((Input.GetKeyDown (KeyCode.RightShift)) && TwoPlayers == true && DyingLight.RedPowered == true) {
			if (RedBombZone.RedBombZoneEnteredR == false) {
				if (Input.GetKeyDown (KeyCode.RightShift) && RedBombOut == false) {
					RedBombClone = Instantiate (RedBomb, RedRobot.transform.position, Quaternion.identity);
					RedBombOut = true;
				}


			} if (Input.GetKeyDown (KeyCode.RightShift) && RedBombOut == true && RedBombPreparation.RedBombPrepared == false) {
				// play error sound effect

			}

			if (Input.GetKeyDown (KeyCode.RightShift) && RedBombOut == true && RedBombPreparation.RedBombPrepared == true) {
				//BOOM

				if (RedBombZone.BlueBombZoneEnteredR) {
					
					Damper = 1 / (Mathf.Abs (BlueRobot.transform.position.x - RedBombClone.transform.position.x) + Mathf.Abs (BlueRobot.transform.position.y - RedBombClone.transform.position.y));
					BlueRobot.GetComponent<Rigidbody2D> ().AddForce (new Vector2((BlueRobot.transform.position.x - RedBombClone.transform.position.x) * RedExplosivePower * Damper, (BlueRobot.transform.position.y - RedBombClone.transform.position.y) * RedExplosivePower * Damper), ForceMode2D.Impulse); 
				}
				if (RedBombZone.RedBombZoneEnteredR) {
					
					Damper = 1 / (Mathf.Abs (RedRobot.transform.position.x - RedBombClone.transform.position.x) + Mathf.Abs (RedRobot.transform.position.y - RedBombClone.transform.position.y));
					RedRobot.GetComponent<Rigidbody2D> ().AddForce (new Vector2((RedRobot.transform.position.x - RedBombClone.transform.position.x) * RedExplosivePower * Damper, (RedRobot.transform.position.y - RedBombClone.transform.position.y) * RedExplosivePower * Damper), ForceMode2D.Impulse); 
				}




				RedBombClone.GetComponent<AudioSource> ().Play();
				Destroy (RedBombClone);
				RedBombOut = false;
				RedBombPreparation.RedBombPrepared = false;
			}

		}
	}


}
