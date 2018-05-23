using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrasCutter : MonoBehaviour {
	
	private Rigidbody2D m_Rigidbody;

	private Vector3 m_MousePos;

	private Vector2 m_Target;

	[SerializeField] float m_Speed;
	private float m_AngleRad;
	private float m_AngleDeg;

	void Start () {
		m_Rigidbody = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		m_MousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		m_AngleRad = Mathf.Atan2 (m_MousePos.y - transform.position.y, m_MousePos.x - transform.position.x);
		m_AngleDeg = (180 / Mathf.PI) * m_AngleRad;
		this.transform.rotation = Quaternion.Euler (0, 0, m_AngleDeg - 90f);
		m_Target = new Vector2 (m_MousePos.x - transform.position.x, m_MousePos.y - transform.position.y);
		m_Target.Normalize ();
		m_Rigidbody.velocity = m_Target * m_Speed * Time.deltaTime * 10;
		if ((transform.position.y >= 3.45f) && (m_Rigidbody.velocity.y > 0)) {
			m_Rigidbody.velocity = new Vector2 (m_Rigidbody.velocity.x, 0f);
		}
	}
}