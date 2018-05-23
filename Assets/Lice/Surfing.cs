using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surfing : MonoBehaviour {

	private float m_Rotation;

	private int m_Direction;

	private bool m_GoDown;

	void Start () {
		m_GoDown = true;
		m_Direction = 1;
		m_Rotation = 1;
	}

	void Update () {
		if (m_GoDown == true) {
			transform.position = new Vector3 (transform.position.x, transform.position.y - 0.2f * Time.deltaTime, transform.position.z);
			if (GetComponent<Transform>().localPosition.y <= -0.2f) {
				m_GoDown = false;
			}
		} else {
			transform.position = new Vector3 (transform.position.x, transform.position.y + 0.2f * Time.deltaTime, transform.position.z);
			if (GetComponent<Transform>().localPosition.y >= 0.2f) {
				m_GoDown = true;
			}
		}
		if (m_Rotation >= 2) {
			m_Rotation = 0;
			m_Direction = -m_Direction;
		}
		m_Rotation += Time.deltaTime;
		transform.Rotate (0, 0, Time.deltaTime * 20 * m_Direction);
	}
}
