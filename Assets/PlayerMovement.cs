using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	Rigidbody body;

	void Awake() {
		body = GetComponent<Rigidbody>();
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			body.AddForce(transform.up * 3000);
		}
	}
}
