using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

	public GameObject rotationReference;

	void Start() {
		Cursor.visible = false;
	}

	void Update () {
		if (Input.GetKeyDown("g")) {
			Physics.gravity = -Physics.gravity;
			rotationReference.SendMessage("changeGravity");
		}
	}
}
