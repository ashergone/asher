using UnityEngine;
using System.Collections;

public class WheatShop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider collision){
		if (collision.transform.tag == "Trolleywheat") {
			GameObject.FindWithTag ("Canvas").GetComponent<UIManager> ().LevelComplete ();
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
