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
	
	// Update is called once per frame
	void Update () {
		
	}
}
