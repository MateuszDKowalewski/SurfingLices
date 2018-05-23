using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4Manager : MonoBehaviour {

	void Start () {
	
	}

	void Update () {
		if (Input.GetKey (KeyCode.P)) {
			YouWin ();
		}
		if (Input.GetKey (KeyCode.O)) {
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
}
