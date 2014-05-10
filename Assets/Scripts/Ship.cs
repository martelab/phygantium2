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
		// stop landing start mining!
		print ("toccato");
		speedLanding = 0;
		rigidbody2D.velocity = Vector2.zero;
		GameObject obj=GameObject.Find("pianeta");
		// attach a to b
		transform.parent=obj.transform;
		GameObject trivella=GameObject.Find("trivella");
		trivella.transform.position = new Vector3(transform.position.x, (transform.position.y-1f),0);
		trivella.renderer.enabled = true;
		trivella.SendMessage ("Mina", 5f);
	}

}