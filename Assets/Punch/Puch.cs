using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puch : MonoBehaviour {

	[SerializeField] float m_Speed;

	bool m_InTour;
	bool m_InTarget;

	void Start () {
		m_InTour = false;
		m_InTarget = false;
	}

	void Update () {
		if ((m_InTour == false) && (Input.GetMouseButtonDown (0))) {
			m_InTour = true;
		}

		if (m_InTour == true) {
			if (m_InTarget == false) {
				transform.position = new Vector3 (transform.position.x + m_Speed * Time.deltaTime, transform.position.y, transform.position.z);
			} else {
				transform.position = new Vector3 (transform.position.x - m_Speed * Time.deltaTime, transform.position.y, transform.position.z);
			}
			if (transform.position.x >= 6) {
				m_InTarget = true;
			}

			if (transform.position.x <= -6) {
				m_InTour = false;
				m_InTarget = false;
			}
		}
	}
}
