using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlanetGravity : MonoBehaviour {

	List<Asteroid> objects;

	void Awake () {
		objects = new List<Asteroid>();
	}

	void FixedUpdate () {
		for (int i = 0; i < objects.Count; i++) {
			objects[i].AddForce(transform.position, -1000);
		}
	}

	void OnTriggerEnter(Collider col) {
		if (col.tag == "FreeObject") {
			objects.Add(col.gameObject.GetComponent<Asteroid>());
		}
	}

	void OnTriggerExit(Collider col) {
		if (col.tag == "FreeObject") {
			objects.Remove(col.gameObject.GetComponent<Asteroid>());
		}
	}
}
 