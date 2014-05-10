using UnityEngine;
using System.Collections;

public class Mining : MonoBehaviour {

	public float miningSpeed = 18f;
	bool mining = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (mining) {
			rigidbody2D.velocity = new Vector2 (0, -miningSpeed) * Time.deltaTime;
		}
	}


	void Mina(Vector3 deployPoint) {
		mining = true;
		transform.position = deployPoint;
	}


	void OnBecameInvisible() {
		// arrivato in fondo!
		// resetto il livello
		print ("arrivato!");
		Application.LoadLevel("livello1");
	}
}
