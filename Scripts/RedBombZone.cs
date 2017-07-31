using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBombZone : MonoBehaviour {
	public static bool BlueBombZoneEnteredR;
	public static bool RedBombZoneEnteredR;

	void OnTriggerStay2D(Collider2D other){
		if (other.gameObject.name == "BlueRobot") {
			if (BlueBombZoneEnteredR == false) {

				BlueBombZoneEnteredR = true;
			}
		}
		if (other.gameObject.name == "RedRobot") {
			if (RedBombZoneEnteredR == false) {
				
				RedBombZoneEnteredR = true;

			}
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.name == "BlueRobot") {
			BlueBombZoneEnteredR = false;
		}
		if (other.gameObject.name == "RedRobot") {
			RedBombZoneEnteredR = false;
		}
	}
}
