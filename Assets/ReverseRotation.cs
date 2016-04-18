using UnityEngine;
using System.Collections;

public class ReverseRotation : MonoBehaviour {
	
	private bool rotate = false;
	private int gravityDir;
	private float rotSpeed = 1000f;

	void Start () {
	
	}
	
	void Update () {
		gravityDir = (int)(-Physics.gravity.y / 9.81f);

		if (rotate) {
			if (gravityDir == 1) {
				if (transform.eulerAngles.z > 0 && transform.eulerAngles.z < 180) {
					transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0); 
					rotate = false;
				} else {
					transform.eulerAngles += Vector3.forward * rotSpeed * Time.deltaTime;
				}
			} else if (gravityDir == -1) {
				if (transform.eulerAngles.z < 180 && transform.eulerAngles.z > 0) {
					transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 180); 
					rotate = false;
				} else {
					transform.eulerAngles += Vector3.back * rotSpeed * Time.deltaTime;
				}
			}
		}
	}

	private void changeGravity() {
		rotate = true;
	}
}
