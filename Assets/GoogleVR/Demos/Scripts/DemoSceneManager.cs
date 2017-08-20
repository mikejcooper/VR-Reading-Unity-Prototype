// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;

// Ensures correct app and scene setup.
public class DemoSceneManager : MonoBehaviour {
	
	public GameObject PlaneObject;

	void Start() {
		Input.backButtonLeavesApp = true;
//		CreateMeshSph÷ere ();
	}

	void Update() {
		// Exit when (X) is tapped.
		if (Input.GetKeyDown(KeyCode.Escape)) {
		  Application.Quit();
		}
	}

	void CreateMeshSphere(){
		GameObject prevObj = PlaneObject;
		float rotation = 0;
		float rotationIncriment = 20;

		while (rotation <= 360) {
			rotation += rotationIncriment;
	
			GameObject currObj = Instantiate(prevObj, prevObj.transform);
			currObj.transform.parent = PlaneObject.transform; 
			currObj.transform.localScale = Vector3.one; 



			currObj.transform.eulerAngles = new Vector3(
				prevObj.transform.eulerAngles.x,
				prevObj.transform.eulerAngles.y,
				prevObj.transform.eulerAngles.z + rotationIncriment
			);

			currObj.transform.position = new Vector3(
				prevObj.transform.position.x + 1,
				prevObj.transform.position.y,
				prevObj.transform.position.z
			);



			prevObj = currObj;
		}

	}
}
