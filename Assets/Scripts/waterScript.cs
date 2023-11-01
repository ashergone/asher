using UnityEngine;
using System.Collections;

public class waterScript : MonoBehaviour {
	public Material grass;
	public static bool watercheck;
	int varacounter;
	public static int waterlevelcheck;
	// Use this for initialization
	void Start () {
		watercheck = false;
	}
	void OnTriggerExit(Collider other) {
		if (other.transform.tag == "Grass") {
			if (watercheck == true) {
				//Debug.Log ("ching");
				varacounter++;
				//Debug.Log ("watercheck");
				other.gameObject.GetComponent<MeshRenderer> ().material = grass;
				Destroy (other.gameObject.GetComponent<BoxCollider> ());
				if (varacounter >= waterlevelcheck) {
					GameObject.FindWithTag ("Canvas").GetComponent<UIManager> ().LevelComplete ();
				}
			}
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
