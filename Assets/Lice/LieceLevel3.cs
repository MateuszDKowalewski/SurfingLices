using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LieceLevel3 : MonoBehaviour {

	[SerializeField] Sprite m_Death;

	private GameObject m_LevelManager;

	private Rigidbody2D m_Rigidbody;

	private Vector2 m_Target;

	private bool m_Allive = true;

	void Start () {
		m_LevelManager = GameObject.Find ("Level3Manager");
		m_LevelManager.GetComponent<Level3Manager> ().AddLice ();
		m_Rigidbody = GetComponent<Rigidbody2D> ();
		m_Target = new Vector2 (Random.Range (0f, 2f) - 1, Random.Range (0f, 2f) - 1);
		m_Target.Normalize ();
	}

	void Update () {
		if (m_Allive) {
			m_Rigidbody.velocity = m_Target;
			m_Target = new Vector2 (m_Target.x + Random.Range (0, 0.2f) - 0.1f, m_Target.y + Random.Range (0, 0.2f) - 0.1f);
			m_Target.Normalize ();
		} else {
			m_Rigidbody.velocity = new Vector2 (0, 0);
		}
	}

	void OnTriggerEnter2D (Collider2D m_col){
		if ((m_col.gameObject.tag == "GrassCutter")&&(m_Allive)) {
			GetComponent<Transform> ().position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 1);
			m_Allive = false;
			m_LevelManager.GetComponent<Level3Manager> ().RemoveLice ();
			GetComponent<SpriteRenderer> ().sprite = m_Death;
		}
	}

	void OnCollisionEnter2D (Collision2D m_col){
		m_Target = new Vector2 (Random.Range (0f, 2f) - 1, Random.Range (0f, 2f) - 1);
		m_Target.Normalize ();
	}
}
