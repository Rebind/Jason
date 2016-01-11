using UnityEngine;
using System.Collections;

public class Otherdemo : MonoBehaviour {
	public GameObject player;
	private Demo playerScript;
	// Use this for initialization
	void Start () {
		playerScript = player.GetComponent<Demo>();
	
	}
	
	// Update is called once per frame
	void Update () {
		//print ("health2 : " + playerScript.health);
		if (playerScript.health <= 0) {
			//print ("health2 : " + playerScript.health);
		}
	}
}
