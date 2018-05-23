using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour {

	void Start () {
	}

	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			int i = Application.loadedLevel;
			Application.LoadLevel(i + 1);
		}
	}

	public void Load(string m_Name){
		Application.LoadLevel (m_Name);
	}
}
