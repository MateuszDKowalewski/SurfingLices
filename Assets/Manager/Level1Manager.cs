using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Manager : MonoBehaviour {

	private float m_TimeLeft;

	private int m_WavedHairs;

	void Start () {
		m_WavedHairs = 0;
		m_TimeLeft = 16;
	}

	void Update () {
		if (Input.GetKey (KeyCode.P)) {
			YouWin ();
		}
		if (Input.GetKey (KeyCode.O)) {
			YouLoose ();
		}
		m_TimeLeft -= Time.deltaTime;
		if (m_WavedHairs <= 0) {
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

	public void AddWavedHair(){
		m_WavedHairs++;
	}

	public void RemoveWavedHair(){
		m_WavedHairs--;
	}
}
