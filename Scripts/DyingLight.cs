using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DyingLight : MonoBehaviour {
	float Xscale = 2.5f;
	float Yscale = 2.5f;
	float DecayRate = .0003f;
	public static bool BluePowered = true;
	public static bool RedPowered = true;
	public TextMesh VictoryText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (RedPowered == true && BluePowered == true) {
			if (Xscale >= .1f) {
				Xscale -= DecayRate;
				Yscale -= DecayRate;
				gameObject.transform.localScale = new Vector3 (Xscale, Yscale, 0f);
			}
		}
		if (RedPowered == false || BluePowered == false){
			if (Input.GetKeyDown("r")) {
				if (ScoreSaver.RedScore == 5 || ScoreSaver.BlueScore == 5) {
					ScoreSaver.RedScore = 0;
					ScoreSaver.BlueScore = 0;
				}
				BuildABomb.BlueExplosivePower = 3f;
				BuildABomb.RedExplosivePower = 3f;
				Movement.BoostPower = .5f;
				MovementR.BoostPower = .5f;
				SceneManager.LoadScene (2);
				RedPowered = true;
				BluePowered = true;
			}
			if (Input.GetKeyDown(KeyCode.Escape))	{
				SceneManager.LoadScene (1);
			}
		}
				
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.name == "BlueRobot") {
			print ("Blue is outta here");
			if (RedPowered == true) {
				BluePowered = false;
				ScoreSaver.RedScore += 1;
				VictoryText.text = "RED HAS THE POWER! \n Press R to play again \n Press esc To quit";
				BuildABomb.BlueExplosivePower = 3f;
				BuildABomb.RedExplosivePower = 3f;
				Movement.BoostPower = .5f;
				MovementR.BoostPower = .5f;
			}

		}
		if (other.gameObject.name == "RedRobot") {
			print ("red is outta here");
			if (BluePowered == true) {
				RedPowered = false;
				ScoreSaver.BlueScore += 1;
				VictoryText.text = "BLUE HAS THE POWER! \n Press R to play again \n Press esc To quit";
				BuildABomb.BlueExplosivePower = 3f;
				BuildABomb.RedExplosivePower = 3f;
				Movement.BoostPower = .5f;
				MovementR.BoostPower = .5f;
			}

		}

	}
}
