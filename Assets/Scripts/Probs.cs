using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Probs : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Floor") {
			Invoke ("wait", 2f);
		}
	}
	void OnTriggerEnter( Collider theCollision ) // C#, type first, name in second
	{    
		if (theCollision.gameObject.tag == "Floor") {
			Invoke ("wait", 2f);
		}
	}
	void wait(){
		GameObject.FindWithTag ("Canvas").GetComponent<UIManager> ().LevelComplete ();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
