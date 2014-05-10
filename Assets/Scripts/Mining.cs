using UnityEngine;
using System.Collections;

public class Mining : MonoBehaviour {

	public float miningSpeed = 0f;

	// Use this for initialization
	void Start () {
		renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		//rigidbody2D.velocity = new Vector2(0,-miningSpeed) * Time.deltaTime;
	}


	void Mina(float speed) {
		print ("mina!");
	}
}
