using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LR : MonoBehaviour {

	private float m_Rotation;

	private int m_Direction;

	void Start () {
		m_Direction = 1;
		m_Rotation = 1;
	}

	void Update () {
		if (m_Rotation >= 2) {
			m_Rotation = 0;
			m_Direction = -m_Direction;
		}
		m_Rotation += Time.deltaTime;
		transform.Rotate (0, 0, Time.deltaTime * 10 * m_Direction);
	}
}
