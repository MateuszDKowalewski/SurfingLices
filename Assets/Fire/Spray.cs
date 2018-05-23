using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spray : MonoBehaviour {

	private GameObject m_LevelManager;

	[SerializeField] Sprite []m_Skins;

	private Collider2D m_Capsule;

	private int m_CurrentSkin;

	void Start () {
		m_LevelManager = GameObject.Find ("Leveel5Manager");
		m_CurrentSkin = 0;
		m_Capsule = GetComponent<CapsuleCollider2D> ();
	}

	void Update () {
		
	}

	void OnMouseDown () {
		if (m_CurrentSkin == 1) {
			m_CurrentSkin = 0;
			GetComponent<SpriteRenderer> ().sprite = m_Skins [1];
			m_Capsule.enabled = true;
		} else {
			m_CurrentSkin = 1;
			GetComponent<SpriteRenderer> ().sprite = m_Skins [0];
			m_Capsule.enabled = false;
		}
	}

	public void TurnOff () {
		m_CurrentSkin = 1;
		GetComponent<SpriteRenderer> ().sprite = m_Skins [0];
		m_Capsule.enabled = false;
	}

	void OnTriggerStay2D (Collider2D m_col) {
		m_LevelManager.GetComponent<Level5Manager> ().Jebut ();
	}
}
