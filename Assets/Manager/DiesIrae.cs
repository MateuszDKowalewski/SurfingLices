using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiesIrae : MonoBehaviour {

	private AudioSource m_DiesIrae;

	void Start () {
		m_DiesIrae = GetComponent<AudioSource> ();
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			TurnOn ();
		}
	}

	void TurnOn () {
		m_DiesIrae.enabled = true;
	}
}
