using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiceLevel2 : MonoBehaviour {

	[SerializeField] Sprite m_Death;

	private GameObject m_LevelManager;

	[SerializeField] float m_Speed;

	private bool m_IsDeath;

	void Start () {
		m_LevelManager = GameObject.Find ("Level2Manager");
		m_IsDeath = false;
	}

	void Update () {
		transform.position = new Vector3 (transform.position.x, transform.position.y + m_Speed * Time.deltaTime, transform.position.z);
		if (transform.position.y > 6.5) {
			m_LevelManager.GetComponent<Level2Manager> ().Gone ();
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D m_col){
		if ((m_col.gameObject.tag == "Punch") && (m_IsDeath == false)) {
			m_IsDeath = true;
			m_Speed = 0;
			GetComponent<Transform> ().position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 1);
			m_LevelManager.GetComponent<Level2Manager> ().Kill ();
			GetComponent<SpriteRenderer> ().sprite = m_Death;
		}
	}
}
