using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Manager : MonoBehaviour {

	[SerializeField] GameObject [] m_Spawnpoint;
	[SerializeField] GameObject m_LicePrefab;

	private float m_CoolDown;

	private int m_ToSpawn;
	private int m_Kill;
	private int m_NoKill;

	void Start () {
		m_ToSpawn = 19;
		m_Kill = 0;
		m_NoKill = 0;
		m_CoolDown = Random.Range (0.1f, 0.6f);
	}

	void Update () {
		if (Input.GetKey (KeyCode.P)) {
			YouWin ();
		}
		if (Input.GetKey (KeyCode.O)) {
			YouLoose ();
		}
		m_CoolDown -= Time.deltaTime;
		if ((m_CoolDown <= 0) && (m_ToSpawn > 0)) {
			int m_Rand = Random.Range (0, 3);
			m_CoolDown = Random.Range (0.6f, 1.6f);
			m_ToSpawn--;
			Instantiate (m_LicePrefab, new Vector3(m_Spawnpoint[m_Rand].transform.position.x, m_Spawnpoint[m_Rand].transform.position.y, m_Spawnpoint[m_Rand].transform.position.z), Quaternion.identity);
		}

		Debug.Log ("Kill: " + m_Kill);
		Debug.Log ("NoKill: " + m_NoKill);

		if(m_Kill + m_NoKill >= 20){
			if (m_NoKill > 5) {
				YouLoose ();
			} else {
				YouWin ();
			}
		}
	}

	public void Kill (){
		m_Kill++;
	}

	public void Gone (){
		m_NoKill++;
	}

	void YouWin(){
		int i = Application.loadedLevel;
		Application.LoadLevel(i + 1);
	}

	void YouLoose(){
		Application.LoadLevel ("LooseScreen");
	}
}
