using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	void Update() {
		if (Input.GetKey(KeyCode.A))
			transform.Translate(5*Vector3.left * Time.deltaTime, Camera.main.transform);
		
		if (Input.GetKey(KeyCode.W))
			transform.Translate(5*Vector3.forward * Time.deltaTime);
		
		if (Input.GetKey(KeyCode.S))
			transform.Translate(5*Vector3.back * Time.deltaTime);
		
		if (Input.GetKey(KeyCode.D))
			transform.Translate(5*Vector3.right * Time.deltaTime, Camera.main.transform);

		transform.position = new Vector3(transform.position.x, 1.5f, transform.position.z);
	}
}