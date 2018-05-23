using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiceLevel3Timmer : MonoBehaviour {

	void Start () {

	}

	void Update () {
		if (transform.position.x < 8) {
			transform.position = new Vector3 (transform.position.x + Time.deltaTime / 2, transform.position.y, transform.position.z);
		}
	}
}
