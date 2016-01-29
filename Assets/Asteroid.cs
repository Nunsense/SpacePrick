using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	Rigidbody body;
	public float startingVelocity = 20f;

	void Awake() {
		body = GetComponent<Rigidbody>();
		body.velocity = body.transform.forward * startingVelocity;
	}
	
	// Update is called once per frame
	void Update() {
	
	}

	public void AddForce(Vector3 origin, float force) {
		body.AddForce(((transform.position - origin).normalized * force) / Vector3.Distance(transform.position, origin));
	}
}
