using UnityEngine;
using System.Collections;

public class HallScript : MonoBehaviour {
	public static int hallcounter;
	// Use this for initialization
	void Start () {
		
	}
	int counter;
	void OnTriggerEnter(Collider other) {
		if (RCCWheelCollider1.haldowncheck == true) {
			if (other.tag == "FieldCollider") {
				
				counter++;	
				Destroy (other.gameObject);
				if (counter >= hallcounter) {
					GameObject.FindWithTag ("Canvas").GetComponent<UIManager> ().LevelComplete ();
				}
			}
		}

	}




	// Update is called once per frame
	void Update () {
	
	}
}
