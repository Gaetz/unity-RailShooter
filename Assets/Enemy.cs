using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	[SerializeField] Transform parent;
	[SerializeField] GameObject deathFx;
	[SerializeField] int scoreByHit = 12;

	BoxCollider boxCollider;
	ScoreHandler score;

	void Start () {
		boxCollider = gameObject.AddComponent<BoxCollider>();
		boxCollider.isTrigger = false;
		score = FindObjectOfType<ScoreHandler>();
	}


	void OnParticleCollision(GameObject other) {
		GameObject fx = Instantiate(deathFx, transform.position, Quaternion.identity);
		score.OnScoreHit(scoreByHit);
		fx.transform.parent = parent;
		Destroy(gameObject);
		Destroy(fx, 2f);
	}
}
