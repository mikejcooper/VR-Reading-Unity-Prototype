using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

	public Camera MainCamera;
	public Transform Object;

	void Start() {
//		Object.transform.position.Set (MainCamera.transform.position.x, MainCamera.transform.position.y, MainCamera.transform.position.z);
		// Tie this to the camera, and do not keep the local orientation.
		Object.transform.SetParent(MainCamera.GetComponent<Transform>(), true);
	}
	
	private float time = 0.0f;
	public float interpolationPeriod = 3.0f;

	void Update () {
		time += Time.deltaTime;

		if (time >= interpolationPeriod) {
//			Debug.Log (time);
			time = time - interpolationPeriod;


			// execute block of code here
		}
	}
}
