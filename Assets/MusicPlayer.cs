using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	void Awake() {
		int musicPlayerNumber = FindObjectsOfType<MusicPlayer>().Length;
		if (musicPlayerNumber > 1) {
			Destroy(gameObject);
		} else {
			DontDestroyOnLoad(gameObject);
		}
	}
}
