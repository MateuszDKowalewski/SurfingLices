using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiceLevel1 : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		if (transform.position.x < 8) {
			transform.position = new Vector3 (transform.position.x + Time.deltaTime, transform.position.y, transform.position.z);
		}
	}
}
