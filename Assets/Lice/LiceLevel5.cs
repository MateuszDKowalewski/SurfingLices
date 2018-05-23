using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiceLevel5 : MonoBehaviour {

	private Rigidbody2D m_Rigidbody;

	private Vector2 m_Target;

	void Start () {
		m_Rigidbody = GetComponent<Rigidbody2D> ();
		m_Target = new Vector2 (Random.Range (0f, 2f) - 1, Random.Range (0f, 2f) - 1);
		m_Target.Normalize ();
	}

	void Update () {
		m_Rigidbody.velocity = m_Target;
		m_Target = new Vector2 (m_Target.x + Random.Range (0, 0.2f) - 0.1f, m_Target.y + Random.Range (0, 0.2f) - 0.1f);
		m_Target.Normalize ();
	}

	void OnCollisionEnter2D (Collision2D m_col){
		m_Target = new Vector2 (Random.Range (0f, 2f) - 1, Random.Range (0f, 2f) - 1);
		m_Target.Normalize ();
	}
}
