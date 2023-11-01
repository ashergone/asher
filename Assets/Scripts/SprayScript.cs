using UnityEngine;
using System.Collections;

public class SprayScript : MonoBehaviour {
	public Material wheat;
	public static bool spraycheck;
	int varacounter;
	public static int praycounter;
	// Use this for initialization
	void Start () {
		spraycheck = false;
	
	}
	void OnTriggerExit(Collider other) {
		if (other.transform.tag == "wheat") {
			if (spraycheck == true) {
				//Debug.Log ("fdsfa");
				varacounter++;
				other.gameObject.GetComponent<MeshRenderer> ().material = wheat;
				Destroy (other.gameObject.GetComponent<BoxCollider> ());
				if (varacounter >= praycounter) {
					GameObject.FindWithTag ("Canvas").GetComponent<UIManager> ().LevelComplete ();
				}
			}
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
