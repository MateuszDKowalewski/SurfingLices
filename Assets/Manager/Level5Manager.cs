using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level5Manager : MonoBehaviour {

	[SerializeField] GameObject m_Fire;
	[SerializeField] GameObject m_Jebut;
	private GameObject m_Match;
	private GameObject m_MatchBox;
	private GameObject m_LittleFire;
	private GameObject m_BigFire;
	private GameObject m_MusicPlayer;
	private GameObject m_DiesIrae;

	private float m_JebutCoolown;
	private float m_MatchCoolDown;

	private bool m_CanFireUp;
	private bool m_IsBigFitre;

	void Start () {
		m_BigFire = GameObject.Find ("BIGFIRE");
		m_DiesIrae = GameObject.Find ("DiesIrtae");
		m_BigFire.SetActive (false);
		m_DiesIrae.SetActive (false);
		m_Match = GameObject.Find ("Match");
		m_MatchBox = GameObject.Find ("m_MatchBox");
		m_MusicPlayer = GameObject.Find ("MusicPlayer");
		Destroy (m_MusicPlayer);
		m_CanFireUp = true;
		m_MatchCoolDown = 5.1f;
		m_IsBigFitre = false;
	}

	void Update () {
		m_JebutCoolown -= Time.deltaTime;
		if (m_JebutCoolown <= 0) {
			m_Match.GetComponent<CircleCollider2D> ().enabled = true;
		}
		if (m_IsBigFitre) {
			m_MatchCoolDown -= Time.deltaTime;
		}
		if (m_MatchCoolDown <= 0) {
			Destroy (m_Match);
		}
	}

	public void FireUp(){
		if ((m_Match.GetComponent<Grab> ().m_Grab) && (Mathf.Abs(Input.GetAxis("Mouse X")) > 1f) && (m_CanFireUp)) {
			m_Match.GetComponent<CircleCollider2D> ().enabled = false;
			m_LittleFire = Instantiate (m_Fire, new Vector3 (m_Match.transform.position.x, m_Match.transform.position.y + 0.3f, -7f), Quaternion.identity, m_Match.GetComponent<Transform> ());
			m_CanFireUp = false;
		}
	}

	public void Jebut(){
		if (m_JebutCoolown <= 0) {
			GameObject.Find ("Spray").GetComponent<Spray> ().TurnOff ();
			Instantiate (m_Jebut, new Vector3 (m_Match.transform.position.x - 3.5f, m_Match.transform.position.y + 0.3f, -8f), Quaternion.identity, m_Match.GetComponent<Transform> ());
			Destroy (m_LittleFire);
			m_JebutCoolown = 5f;
			m_CanFireUp = true;
		}
	}

	public void StartBigFire(){
		m_IsBigFitre = true;
		m_BigFire.SetActive (true);
		m_DiesIrae.SetActive (true);
	}
}
