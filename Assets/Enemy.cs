using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	[SerializeField] Transform parent;
	[SerializeField] GameObject deathFx;
	BoxCollider boxCollider;

	void Start () {
		boxCollider = gameObject.AddComponent<BoxCollider>();
		boxCollider.isTrigger = false;
	}


	void OnParticleCollision(GameObject other) {
		GameObject fx = Instantiate(deathFx, transform.position, Quaternion.identity);
		fx.transform.parent = parent;
		Destroy(gameObject);
		Destroy(fx, 2f);
	}
}
