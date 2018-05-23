using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comb : MonoBehaviour {

	private Vector3 m_Position;

	void Start () {
		
	}

	void Update () {
		m_Position = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		m_Position = new Vector3 (m_Position.x, m_Position.y, -5);
		transform.position = m_Position;
	}
}
