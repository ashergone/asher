using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Advertisements;
public class MainMenus : MonoBehaviour {

	public Text totalEarning;

	public GameObject SettingDialog;
	public GameObject soundoffbtn;
	public GameObject soundonbtn;
	public GameObject musicoffbtn;
	public GameObject musiconbtn;
	public GameObject QuitDialog;
	public GameObject ControlDia;
	private AudioSource audiosource;
	// Use this for initialization
	void Start () {

		AudioListener.pause= false;
		AudioListener.volume = 1f;
		Time.timeScale = 1f;
		//PlayerPrefs.DeleteAll ();
		if (PlayerPrefs.GetInt ("OneTime") == 0) {
			PlayerPrefs.SetInt ("OneTime", 1);
			PlayerPrefs.SetFloat ("Fuel", 0.40f);
			PlayerPrefs.SetInt("earning",300);
		}

		//PlayerPrefs.SetInt("earning",6000);

		audiosource = GetComponent<AudioSource> ();
		if (PlayerPrefs.GetInt ("music") == 1) {
			musicoffbtn.SetActive (true);
			musiconbtn.SetActive (false);
			audiosource.mute = true;
		}
		if (PlayerPrefs.GetInt ("sound") == 1) {
			soundonbtn.SetActive (false);
			soundoffbtn.SetActive (true);
		}
       
        //PlayerPrefs.DeleteAll ();
        //PlayerPrefs.SetInt ("unlock",30);
    }
//	private void HandleAdResult (ShowResult result) {
//		switch (result) {
//		case ShowResult.Finished:
//			{
//				Debug.Log ("finished");
//				break;
//			}
//		case ShowResult.Skipped:
//			{
//				Debug.Log ("Skipped");
//				break;
//			}
//		case ShowResult.Failed:
//			{
//				Debug.Log ("Failed");
//				break;
//			}
//		}
//	}
	
	// Update is called once per frame
	


	int earningV;
	void Update()
	{
		//	GameObject.FindWithTag ("CarRotation").transform.Rotate(0,x,0);

		earningV = PlayerPrefs.GetInt("earning");
		totalEarning.text = earningV.ToString() + " $";
	}
	public void controllbtn(){
		ControlDia.SetActive (true);
	}
	public void steering(){
		//Adds.instance.ShowAdmobInterstitialAd ();
		PlayerPrefs.SetInt ("vehicleController", 0);
		ControlDia.SetActive (false);
	}
	public void UIButton(){
		//Adds.instance.ShowAdmobInterstitialAd ();
		PlayerPrefs.SetInt ("vehicleController", 1);
		ControlDia.SetActive (false);
	}
	public void Tilte(){
		//Adds.instance.ShowAdmobInterstitialAd ();
		PlayerPrefs.SetInt ("vehicleController", 2);
		ControlDia.SetActive (false);
	}

	public void Play(){
		
		Application.LoadLevel ("Vehicle Selection");
	}
	public void MoreGames(){
		
		Application.OpenURL("https://apps.apple.com/my/developer/haroon-younas/id1587035435");
	}
	public void rateUs(){
		Application.OpenURL("https://apps.apple.com/my/app/strike-force-rpg-no-wifi-games/id6443582142");
	}
	public void FBPage(){
		
	}
	public void Setting(){
		
		SettingDialog.SetActive (true);
	}
	public void SettingBack(){
	//	Adds.instance.ShowAdmobInterstitialAd ();
		SettingDialog.SetActive (false);
	}
	public void SoundOff(){
		PlayerPrefs.SetInt ("sound", 0);
		soundonbtn.SetActive (true);
		soundoffbtn.SetActive (false);

	}
	public void SoundOn(){
		PlayerPrefs.SetInt ("sound", 1);
		soundonbtn.SetActive (false);
		soundoffbtn.SetActive (true);
	}
	public void MusicOff(){
		audiosource.mute = false;
		PlayerPrefs.SetInt ("music", 0);
		musicoffbtn.SetActive (false);
		musiconbtn.SetActive (true);

	}
	public void MusicOn(){
		audiosource.mute = true;
		PlayerPrefs.SetInt ("music", 1);
		musicoffbtn.SetActive (true);
		musiconbtn.SetActive (false);
	}
	public void Quit(){
		//	Adds.instance.unityads ();
		Application.Quit();
	}
	public void QuitYes(){
		Application.Quit ();
	}
	public void QuitNo(){
		QuitDialog.SetActive (false);
	}
	

}
