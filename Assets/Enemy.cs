﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	BoxCollider boxCollider;

	void Start () {
		boxCollider = gameObject.AddComponent<BoxCollider>();
		boxCollider.isTrigger = false;
	}


	void OnParticleCollision(GameObject other) {
		Destroy(gameObject);
	}
}
