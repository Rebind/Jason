using UnityEngine;
using System.Collections;

public class baseMovement : MonoBehaviour {
	public float moveSpeed;
	public float jumpHeight;
	public bool isJumping = false;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal") * moveSpeed;
		transform.Translate (Vector2.right * h * Time.deltaTime);
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (!isJumping) {
				GetComponent<Rigidbody2D> ().AddForce (Vector2.up * jumpHeight);
				isJumping = true;
			}
		}

	}
	//Three type collision on unity 2D
	void OnCollisionEnter2D (Collision2D col){
		
		if (col.gameObject.tag == "body") {
			print ("The player pick up the body");
			Destroy (col.gameObject);
		}

		if (col.gameObject.tag == "ground") {
			isJumping = false;
		}

	}

	void OnCollisionStay2D(Collision2D col){
		if (col.gameObject.tag == "stone") {
			print(" The player touching the stone");
		}

	}

	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.tag == "stone") {
			print (" The player left the stone");
		}
	}

}
