using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour {

	private Vector3 m_Position;
	private Vector3 m_MouseScenePos;

	private Vector2 m_Distance;

	[SerializeField] float m_Radious;

	public bool m_Grab;

	void Start () {
		m_Grab = false;
	}
	
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			m_MouseScenePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			m_Distance = new Vector2 (transform.position.x - m_MouseScenePos.x, transform.position.y - m_MouseScenePos.y);
			if (Mathf.Sqrt (m_Distance.x * m_Distance.x + m_Distance.y * m_Distance.y) <= m_Radious) {
				m_Grab = true;
			}
		}

		if ((Input.GetMouseButton (0)) && (m_Grab)) {
			m_Position = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			m_Position = new Vector3 (m_Position.x + m_Distance.x, m_Position.y + m_Distance.y, transform.position.z);
			transform.position = m_Position;
		}

		if (Input.GetMouseButtonUp (0)) {
			m_Grab = false;
		}
	}
}