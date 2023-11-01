using UnityEngine;
using System.Collections;

public class harvestcollider : MonoBehaviour {
	
	GameObject trolley;
	public GameObject trollebtn;
	public static bool harvestCutcheck = false;
	public static int harvestcounter;
	// Use this for initialization
	void Start () {
		trolley = GameObject.FindWithTag ("Trolleywheat");
		trolley.SetActive(false);
		harvestCutcheck = false;

	}
	int counter;
	void OnTriggerExit(Collider collision)
	{
		if (collision.transform.tag == "wheat") {
			//if (harvestCutcheck == true) {
				//Debug.Log ("fsdafsda");
				counter = counter + 1;
				Destroy (collision.gameObject);
			if (counter >= harvestcounter) {
					
					trollebtn.SetActive (true);
					trolley.SetActive (true);
				}
			//}
		}
	
	}
	// Update is called once per frame
	void Update () {
	
	}
}
