using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour {
	int score = 0;
	Text scoreText;

	void Start () {
		scoreText = GetComponent<Text>();
		UpdateScore();
	}
	
	public void OnScoreHit (int scoreByHit) {
		score += scoreByHit;
		UpdateScore();
	}

	void UpdateScore() {
		scoreText.text = score.ToString();
	}
}
