using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour {

	[SerializeField] float levelLoadDelay = 1f;
	[SerializeField] GameObject deathFX;


	void OnTriggerEnter(Collider other) {
		StartDeathSequence();
	}

	void StartDeathSequence() {
		deathFX.SetActive(true);
		SendMessage("OnPlayerDeath");
		Invoke("ReloadScene", levelLoadDelay);
	}

	void ReloadScene() {
		SceneManager.LoadScene(1);
	}

}
