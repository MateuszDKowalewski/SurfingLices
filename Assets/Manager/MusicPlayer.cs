using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	private static bool m_FirstLoad = true;

	void Start () {
		if (m_FirstLoad) {
			m_FirstLoad = false;
		} else {
			Destroy (gameObject);
		}
		DontDestroyOnLoad (gameObject);
	}

	void Update () {
		
	}
}
