using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	[Tooltip("In m/s")][SerializeField] float speed = 20.0f;
	[SerializeField] float xRange = 9f;
	[SerializeField] float yRange = 5f;
	[SerializeField] float positionPitchFactor = -5f;
	[SerializeField] float controlPitchFactor = -20f;
	[SerializeField] float positionYawFactor = -5f;
	[SerializeField] float controlRollFactor = -25f;

	float xThrow, yThrow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
		yThrow = CrossPlatformInputManager.GetAxis("Vertical");
		UpdatePosition();
		UpdateRotation();
	}

	void UpdatePosition() {
		float xOffset = xThrow * speed * Time.deltaTime;
		float yOffset = yThrow * speed * Time.deltaTime;
		Vector3 position = transform.localPosition;
		transform.localPosition = new Vector3(Mathf.Clamp(position.x + xOffset, -xRange, xRange), Mathf.Clamp(position.y + yOffset, -yRange, yRange), position.z);
	}

	void UpdateRotation() {
		float pitch = transform.localPosition.y * positionPitchFactor + yThrow * controlPitchFactor;
		float yaw = transform.localPosition.x * positionYawFactor;
		float roll = xThrow * controlRollFactor;
		transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
	}
}
