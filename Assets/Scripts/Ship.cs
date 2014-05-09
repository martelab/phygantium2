using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	public float speedLanding = 100f;
	bool landed = false;

	void Start() {
		landed = false;
	}

	void Update (){
		rigidbody2D.velocity = new Vector2(0,-speedLanding) * Time.deltaTime;
	}

	void OnBecameInvisible() {
		// funzionante
		//print ("invisibile");
		//transform.position = new Vector2(0, 4f );
	}
	
	void OnBecameVisible() {
		// funzionante
		//print ("visibile");
	}

	void OnTriggerEnter2D(Collider2D other) {
		print ("toccato");
		speedLanding = 0;
		rigidbody2D.velocity = Vector2.zero;
		GameObject obj=GameObject.Find("pianeta");
		// attach a to b
		transform.parent=obj.transform;
	}

}