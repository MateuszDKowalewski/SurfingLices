using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Manager : MonoBehaviour {

	private float m_TimeLeft;

	private int m_Lices;

	void Start () {
		m_TimeLeft = 32;
		m_Lices = 0;
	}

	void Update () {
		if (Input.GetKey (KeyCode.P)) {
			YouWin ();
		}
		if (Input.GetKey (KeyCode.O)) {
			YouLoose ();
		}
		m_TimeLeft -= Time.deltaTime;
		if (m_Lices <= 0) {
			YouWin ();
		}
		if (m_TimeLeft < 0) {
			YouLoose ();
		}
	}

	void YouWin(){
		int i = Application.loadedLevel;
		Application.LoadLevel(i + 1);
	}

	void YouLoose(){
		Application.LoadLevel ("LooseScreen");
	}

	public void AddLice(){
		m_Lices++;
	}

	public void RemoveLice(){
		m_Lices--;
	}
}
