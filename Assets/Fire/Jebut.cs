using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jebut : MonoBehaviour {

	private float m_TimmeAllive;

	private bool m_FIre;

	void Start () {
		m_TimmeAllive = 5;
		m_FIre = false;
	}

	void Update () {
		m_TimmeAllive -= Time.deltaTime;
		if (m_TimmeAllive <= 0) {
			Destroy (gameObject);
		}
	}

	void OnTriggerStay2D (Collider2D m_col){
		if ((m_col.gameObject.tag == "Hair")) {
			m_FIre = true;
			GameObject.Find ("Leveel5Manager").GetComponent<Level5Manager> ().StartBigFire ();
		}
	}
}
