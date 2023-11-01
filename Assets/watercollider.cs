using UnityEngine;
using System.Collections;

public class watercollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider other) {
		if (other.transform.tag == "water") {
			GameObject.FindWithTag ("Canvas").GetComponent<UIManager> ().levelfailedDialog ();
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
