using UnityEngine;
using System.Collections;

public class FiledEnter : MonoBehaviour {
	GameObject haldown;
	// Use this for initialization
	void Start () {
		haldown = GameObject.Find ("HalDown");
		haldown.SetActive (false);
	}
	int counter;
	void OnTriggerEnter(Collider other) {
		
		if (other.tag == "filedEner") {
			if (RCCWheelCollider1.hallcheck == true) {
				haldown.SetActive (true);
			}

			RCCWheelCollider1.check = true;
		}

	}

	void OnTriggerExit(Collider other) {

		if (other.tag == "filedEner") {
			if (RCCWheelCollider1.hallcheck == true) {
				haldown.SetActive (false);
			}

			RCCWheelCollider1.check = false;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
