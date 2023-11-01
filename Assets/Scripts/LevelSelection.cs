using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour {
	

	public GameObject [] Unlock;
	public GameObject levellockok;
	public GameObject exit;
	private AudioSource audiosource;
	int counterss=0;
	Transform Button;
	// Use this for initialization
	void Start () {
		
		audiosource = GetComponent<AudioSource> ();
		if (PlayerPrefs.GetInt ("music") == 1) {

			audiosource.mute = true;
		}
	

		int unlockcount;
	
		unlockcount = PlayerPrefs.GetInt ("unlock");
		int j;
		for (int i = 0; i <= Unlock.Length; i++) {
			j = i+1;
			//Button = Unlock [i].transform.parent;
			//Debug.Log (Button.name);
//			for(int k=0; k< PlayerPrefs.GetInt("LevelStar"+j); k++){
//				
//				Button.GetChild (k + 1).gameObject.SetActive (true);
//			}
			if (unlockcount > i ) {
				Unlock [i].SetActive (false);
			}
		}



		AdsManager.instance.showInterstitialAd();
        


	}
	public void LevelLockOk(){
		levellockok.SetActive (false);
	}

	public void backBtn (){
		SceneManager.LoadScene("VehicleSelection");
		//Application.LoadLevel("VehicleSelection");
	}

	public void exitYes(){
		Application.Quit ();
	}
	public void exitNo(){
		exit.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey ("escape")) {
			exit.SetActive (true);
		}
	}
}
