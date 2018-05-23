using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair : MonoBehaviour {

	private GameObject m_GameManager;

	[SerializeField] Sprite m_Sin10;
	[SerializeField] Sprite m_Sin9;
	[SerializeField] Sprite m_Sin8;
	[SerializeField] Sprite m_Sin7;
	[SerializeField] Sprite m_Sin6;
	[SerializeField] Sprite m_Sin5;
	[SerializeField] Sprite m_Sin4;
	[SerializeField] Sprite m_Sin3;
	[SerializeField] Sprite m_Sin2;
	[SerializeField] Sprite m_Sin1;
	[SerializeField] Sprite m_Sin0;

	private Color m_Color;

	private float m_HairWaves;

	void Start () {
		m_GameManager = GameObject.Find ("Lvl1Manager");
		m_GameManager.GetComponent<Level1Manager> ().AddWavedHair ();
		m_HairWaves = 100;
	}

	void Update () {
		if (m_HairWaves < 0) {
			GetComponent<SpriteRenderer> ().sprite = m_Sin0;
		} else if (m_HairWaves < 10) {
			GetComponent<SpriteRenderer> ().sprite = m_Sin1;
		} else if (m_HairWaves < 20) {
			GetComponent<SpriteRenderer> ().sprite = m_Sin2;
		} else if (m_HairWaves < 30) {
			GetComponent<SpriteRenderer> ().sprite = m_Sin3;
		} else if (m_HairWaves < 40) {
			GetComponent<SpriteRenderer> ().sprite = m_Sin4;
		} else if (m_HairWaves < 50) {
			GetComponent<SpriteRenderer> ().sprite = m_Sin5;
		} else if (m_HairWaves < 60) {
			GetComponent<SpriteRenderer> ().sprite = m_Sin6;
		} else if (m_HairWaves < 70) {
			GetComponent<SpriteRenderer> ().sprite = m_Sin7;
		} else if (m_HairWaves < 80) {
			GetComponent<SpriteRenderer> ().sprite = m_Sin8;
		} else if (m_HairWaves < 90) {
			GetComponent<SpriteRenderer> ().sprite = m_Sin9;
		}
	}

	void OnTriggerStay2D(Collider2D m_col){
		if ((m_col.gameObject.tag == "Comb") && (Input.GetMouseButton (0))) {

			if ((m_HairWaves >= 0) && (m_HairWaves + Input.GetAxis ("Mouse Y") < 0)) {
				m_GameManager.GetComponent<Level1Manager> ().RemoveWavedHair ();
			}

			if ((m_HairWaves < 0) && (m_HairWaves + Input.GetAxis ("Mouse Y") >= 0)) {
				m_GameManager.GetComponent<Level1Manager> ().AddWavedHair ();
			}

			m_HairWaves += Input.GetAxis ("Mouse Y");
		}
	}
}
