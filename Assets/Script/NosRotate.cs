using UnityEngine;
using System.Collections;

public class NosRotate : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate (0, 1, 0);
	}
}
