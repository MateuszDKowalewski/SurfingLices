using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchBox : MonoBehaviour {

	private GameObject m_LevelManager;

	void Start () {
		m_LevelManager = GameObject.Find ("Leveel5Manager");
	}

	void Update () {
		
	}

	void OnTriggerStay2D (Collider2D m_col) {
		if (m_col.gameObject.tag == "Match") {
			m_LevelManager.GetComponent<Level5Manager> ().FireUp ();
		}
	}
}
