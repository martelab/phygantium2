using UnityEngine;
using System.Collections;

public class PlanetControls : MonoBehaviour {
	
	public float rotationSpeed = 600f;

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
		// sarebbe più pulito catturare gli input come qui sotto
		// ovvero usando le etichette dell'input manager del progetto..
		//bool salto = Input.GetButton("Jump");
		
		// però lo faccio così..
		if (Input.GetKey(KeyCode.A)) {
			rigidbody2D.AddTorque(rotationSpeed * Time.deltaTime);
		}
		
		if (Input.GetKey(KeyCode.D)) {
			rigidbody2D.AddTorque(-1 * rotationSpeed * Time.deltaTime);
		}
		
		
		if (Input.GetKey(KeyCode.Escape)) {
			Application.Quit();
		}
		
	}
}
