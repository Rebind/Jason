using UnityEngine;
using System.Collections;

public class Demo : MonoBehaviour {
	public int health;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		damagePlayer (1);
		//print ("health : " + health);
		if (health <= 0) {
			health = 0;
			Destroy (gameObject, 5.5f);
		}
	}

	void damagePlayer(int damage){
		health -= damage;
	}
}
