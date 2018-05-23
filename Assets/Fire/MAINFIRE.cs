using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAINFIRE : MonoBehaviour {
	private Rigidbody2D m_Rigidbody;
	private float m_Time;
	private int m_Direction;

	void Start () {
		m_Rigidbody = GetComponent<Rigidbody2D> ();
		m_Time = 0;
		m_Direction = 1;
	}

	void Update () {
		m_Time += Time.deltaTime;
		if (m_Time > 1) {
			m_Direction = -m_Direction;
			m_Time = 0;
		}
		m_Rigidbody.velocity = new Vector2 (0, m_Direction * Time.deltaTime * 10);
	}
}
