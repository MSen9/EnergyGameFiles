using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombZone : MonoBehaviour {
	
	public static bool BlueBombZoneEntered;
	public static bool RedBombZoneEntered;


	void OnTriggerStay2D(Collider2D other){
		if (other.gameObject.name == "BlueRobot") {
			if (BlueBombZoneEntered == false) {
				
				BlueBombZoneEntered = true;
			}
		}
		if (other.gameObject.tag== "RobotR") {
			if (RedBombZoneEntered == false) {

				RedBombZoneEntered = true;
			}
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.name == "BlueRobot") {
			BlueBombZoneEntered = false;
		}
		if (other.gameObject.name == "RobotR") {
			RedBombZoneEntered = false;
		}
	}
		
}
