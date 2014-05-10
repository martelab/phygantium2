using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	public float speedLanding = 30f;
	bool landed = false;
	GameObject pianeta;
	GameObject trivella;

	void Start() {
		landed = false;
		pianeta = GameObject.Find("pianeta");
		trivella = GameObject.Find ("trivella");
	}


	void Update (){
		if(!landed){
			rigidbody2D.velocity = new Vector2(0,-speedLanding) * Time.deltaTime;
		}
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


	// non so perchè ma viene eseguito ad ogni frame, non solo quando Enter collider
	void OnTriggerEnter2D(Collider2D other) {
		// stop landing start mining!
		rigidbody2D.velocity = Vector2.zero;

		// attacco navicella al pianeta
		// se non viene eseguito ad ogni frame, fa un lagghettino antipatico..
		// quindi lo lascio fuori dal controllo seguente
		transform.parent=pianeta.transform;

		if(!landed){		
			landed = true;
			trivella.SendMessage ("Mina", new Vector3(transform.position.x, (transform.position.y-0.4f),0));
		}

	}

}