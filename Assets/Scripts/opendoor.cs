using UnityEngine;
using System.Collections;

public class opendoor : MonoBehaviour {
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("LevelNo") == 3) {
		
		}
		//UIManager.harvestnoselbtn.SetActive (true);
		//GameObject.FindWithTag("Canvas").GetComponent<UIManager>().harvestnoselbtn.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate (5f, 0, 0);
	}
}
