using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour {
	public GameObject SpeedBoost;
	public GameObject BombBoost;
	public GameObject Light;
	public GameObject SpeedBoostClone;
	public GameObject BombBoostClone;
	float MinimumRange;
	float MaxRange;
	float SpawnX;
	float SpawnY;
	bool Cooldown;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		MaxRange = Light.GetComponent<CircleCollider2D> ().radius - .1f;
		MinimumRange = Light.GetComponent<CircleCollider2D> ().radius / 5;
		if (Cooldown == false) {
			StartCoroutine (SpawnPowerups());
		}
	}

	IEnumerator SpawnPowerups(){
		Cooldown = true;
		SpawnX = Random.Range (-1 * MaxRange, MaxRange);
		// B = sqrt(C^2 - A^2)
		SpawnY = Random.Range (-1 * Mathf.Sqrt(MaxRange * MaxRange - SpawnX * SpawnX), Mathf.Abs(Mathf.Sqrt(MaxRange * MaxRange - SpawnX * SpawnX))); 
		int PowerChoice = Random.Range (0, 2);
		if (PowerChoice == 0) {
			SpeedBoostClone = Instantiate (SpeedBoost, new Vector3 (6 + SpawnX, 5 + SpawnY, 0f), Quaternion.identity);
		}
		else if (PowerChoice == 1) {
			BombBoostClone = Instantiate (BombBoost, new Vector3 (6 + SpawnX, 5 + SpawnY, 0f), Quaternion.identity);
		} else {
			print ("whoops");
		}
		yield return new WaitForSeconds (10f);
		Cooldown = false;
	}
}
