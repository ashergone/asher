using UnityEngine;
using System.Collections;

public class level : MonoBehaviour {
	public GameObject Loading;
	private AudioSource audiosource;
	// Use this for initialization
	void Start () {
		
		audiosource = GetComponent<AudioSource> ();
		if (PlayerPrefs.GetInt ("music") == 1) {
			
			audiosource.mute = true;
		}
	}
	public void level1(){
		//Adds.instance.HideAdmobBannerAd ();
		PlayerPrefs.SetInt ("levelskin", 1);
		Loading.SetActive (true);
		Application.LoadLevel ("GamePlayseen");

	}
	public void level2(){
		//Adds.instance.HideAdmobBannerAd ();
		PlayerPrefs.SetInt ("levelskin", 2);
		Loading.SetActive (true);
		Application.LoadLevel ("GamePlayseen");
	}
	// Update is called once per frame
	void Update () {
	
	}
}
