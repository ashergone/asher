using UnityEngine;
using System.Collections;

public class WheatThrow : MonoBehaviour {
	public GameObject wheatThrow;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("LevelNo") == 4){
			wheatThrow.SetActive (true);
		}
		
	}
	void wait(){
		wheatThrow.SetActive (true);
	}
	void OnTriggerEnter(Collider collision){
		if (collision.transform.tag == "Trolleywheat") {
			timercheck = true;
			gameObject.transform.GetChild (0).gameObject.SetActive (true);
			Invoke ("wait", 1f);

		}
	}
	void OnTriggerExit(Collider collision){
		if (collision.transform.tag == "Trolleywheat") {
			timercheck = false;
			gameObject.transform.GetChild (0).gameObject.SetActive (false);
		//	wheatThrow.SetActive (false);
		}
	}
	// Update is called once per frame
	bool timercheck;
	float leveltime = 5f;
	void Update () {
		if(timercheck == true){
			leveltime -= Time.deltaTime;
			//timers = Convert.ToInt32(leveltime);
			//Debug.Log(timers);


			if (leveltime <= 0) {
				GameObject.FindWithTag ("Canvas").GetComponent<UIManager> ().LevelComplete ();
			}
	}
}
}
