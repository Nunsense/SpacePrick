using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	Rigidbody body;

	void Awake() {
		body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update() {
	
	}

	public void AddForce(Vector3 origin, float force) {
		body.AddForce(((transform.position - origin).normalized * force) / Vector3.Distance(transform.position, origin));
	}
}
