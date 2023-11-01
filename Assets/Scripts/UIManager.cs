using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
	public GameObject DisJointBtn;
	GameObject CameraC;
	public GameObject halanimaiton;
	int CameraChangecounter = 0;
	public GameObject WaterSpray;
	public GameObject Spray;
	public GameObject harvestnoselbtn;
	public GameObject LevelCompletepanel;
	public GameObject OutoffuelPanel;
	public GameObject pauseDialog;
	public GameObject messagepanel;
	public GameObject adsnotavai;
	private AsyncOperation async;
	public GameObject LevelFailed;
	GameObject tractor;
	GameObject harvestor;

	public void levelfailedDialog(){
		if (PlayerPrefs.GetInt ("LevelNo") - 1 == 4 || PlayerPrefs.GetInt ("LevelNo") - 1 == 10 || PlayerPrefs.GetInt ("LevelNo") - 1 == 20 || PlayerPrefs.GetInt ("LevelNo") - 1 == 25) {
			harvestor.SetActive (false);
		} else {
			tractor.SetActive (false);
		}
		LevelFailed.SetActive (true);
		Time.timeScale = 0f;
	}
	void Awake(){
		AudioListener.volume = 1f;
		tractor = GameObject.FindWithTag ("Tractor");
		harvestor= GameObject.FindWithTag ("harvesttruck");
	}
	IEnumerator LevelCoroutine ()
	{
		async = SceneManager.LoadSceneAsync ("GamePlay");
		async.allowSceneActivation = true;
		float perc = 0.01f;
		while (!async.isDone) {
			yield return null;
			//			perc = Mathf.Lerp (perc, 1f, 0.015f);
			//			loadimg.fillAmount = perc;
		}
	}
	IEnumerator LevelCoroutines ()
	{
		async = SceneManager.LoadSceneAsync ("MainMenu");
		async.allowSceneActivation = true;
		float perc = 0.01f;
		while (!async.isDone) {
			yield return null;
			//			perc = Mathf.Lerp (perc, 1f, 0.015f);
			//			loadimg.fillAmount = perc;
		}
	}
	public void ShowRewardedAd()
	{
		//if (Advertisement.IsReady("rewardedVideo"))
		//{
		//	var options = new ShowOptions { resultCallback = HandleShowResult };
		//	Advertisement.Show("rewardedVideo", options);
		//}else{
		//	adsnotavai.SetActive (true);
		//	Invoke ("waitforfalse", 3f);
		//}

	}
	public void GivefuelwithCash(){

		AdsManager.instance.showInterstitialAd();

		if (PlayerPrefs.GetInt ("earning") > 20) {
			PlayerPrefs.SetInt ("earning", PlayerPrefs.GetInt ("earning") - 20);
			GameObject.FindWithTag ("GasStation").GetComponent<GasstionScript> ().addfuelwithcash ();
			Time.timeScale = 1f;
			OutoffuelPanel.SetActive (false);
			if (PlayerPrefs.GetInt ("LevelNo") - 1 == 4 || PlayerPrefs.GetInt ("LevelNo") - 1 == 10 || PlayerPrefs.GetInt ("LevelNo") - 1 == 20 || PlayerPrefs.GetInt ("LevelNo") - 1 == 25) {
				harvestor.SetActive (true);
			} else {
				tractor.SetActive (true);
			}
		}
	}

	void waitforfalse(){
		adsnotavai.SetActive (false);
	}
	//private void HandleShowResult(ShowResult result)
	//{
	//	switch (result)
	//	{
	//	case ShowResult.Finished:{
	//			addSomeFuel ();
	//			Debug.Log ("The ad was successfully shown.");
	//			break;
	//		}
	//	case ShowResult.Skipped:
	//		Debug.Log("The ad was skipped before reaching the end.");
	//		break;
	//	case ShowResult.Failed:

	//		Debug.LogError("The ad failed to be shown.");
	//		break;
	//	}
	//}
	public void startmessage(){
		messagepanel.SetActive (false);
		Time.timeScale = 1f;
	}
	//public GameObject harvest;
	// Use this for initialization
	void Start () {
	//	PlayerPrefs.DeleteAll ();
		Time.timeScale = 1f;
		CameraC = GameObject.FindWithTag ("MainCamera");

		//PlayerPrefs.SetInt ("LevelNo", 0);
	//	harvestnoselbtn = GameObject.Find ("harvesttruck");
	//	harvestnoselbtn.SetActive (false);

	}

	public void UIButton(){
		
		GameObject.FindWithTag("Tractor").GetComponent<RCCCarControllerV2> ().useAccelerometerForSteer = false;
		GameObject.FindWithTag("Tractor").GetComponent<RCCCarControllerV2> ().steeringWheelControl = false;
		GameObject.FindWithTag("harvesttruck").GetComponent<RCCCarControllerV2> ().useAccelerometerForSteer = false;
		GameObject.FindWithTag("harvesttruck").GetComponent<RCCCarControllerV2> ().steeringWheelControl = false;
	}
	public void Steering(){
		GameObject.FindWithTag("Tractor").GetComponent<RCCCarControllerV2> ().useAccelerometerForSteer = false;
		GameObject.FindWithTag("Tractor").GetComponent<RCCCarControllerV2> ().steeringWheelControl = true;
		GameObject.FindWithTag("harvesttruck").GetComponent<RCCCarControllerV2> ().useAccelerometerForSteer = false;
		GameObject.FindWithTag("harvesttruck").GetComponent<RCCCarControllerV2> ().steeringWheelControl = true;
	}
	public void Home(){

		AdsManager.instance.showInterstitialAd();

		//Adds.instance.ShowUnityAd ();
		StartCoroutine (LevelCoroutines ());
	//	Application.LoadLevel ("MainMenu");
	}
	public void Reply(){

		AdsManager.instance.showInterstitialAd();

		//Adds.instance.ShowUnityAd ();
		StartCoroutine (LevelCoroutine ());

	}
	public void PauseBTN(){



		AdsManager.instance.showInterstitialAd();

		AudioListener.volume = 0f;
	//	Adds.instance.ShowUnityAd ();
		pauseDialog.SetActive (true);
		Time.timeScale = 0f;
	}
	public void ResumeBTN(){
		AudioListener.volume = 1f;
		Time.timeScale = 1f;
		pauseDialog.SetActive (false);

	}
	public void NexTBtn(){

		AdsManager.instance.showInterstitialAd();
		//	Adds.instance.ShowUnityAd ();
		PlayerPrefs.SetInt ("LevelNo", PlayerPrefs.GetInt("LevelNo") +1);
		if (PlayerPrefs.GetInt ("LevelNo") > 26) {
			PlayerPrefs.SetInt ("LevelNo", 1);
		}
		StartCoroutine (LevelCoroutine ());

	}
	public void gasbutton(){
		
		harvestcollider.harvestCutcheck = true;
	}
	public void breakbutton(){
		harvestcollider.harvestCutcheck = false;
	}
	// Update is called once per frame
	void Update () {
	
	}
	public void addSomeFuel(){
		
		GameObject.FindWithTag ("GasStation").GetComponent<GasstionScript> ().addfuel ();
		Time.timeScale = 1f;
		OutoffuelPanel.SetActive (false);
		if (PlayerPrefs.GetInt ("LevelNo") - 1 == 4 || PlayerPrefs.GetInt ("LevelNo") - 1 == 10 || PlayerPrefs.GetInt ("LevelNo") - 1 == 20 || PlayerPrefs.GetInt ("LevelNo") - 1 == 25) {
			harvestor.SetActive (true);
		} else {
			tractor.SetActive (true);
		}
	}
	public void OutofFuel(){

		if (PlayerPrefs.GetInt ("LevelNo") - 1 == 4 || PlayerPrefs.GetInt ("LevelNo") - 1 == 10 || PlayerPrefs.GetInt ("LevelNo") - 1 == 20 || PlayerPrefs.GetInt ("LevelNo") - 1 == 25) {
			harvestor.SetActive (false);
		} else {
			tractor.SetActive (false);
		}
		Time.timeScale = 0f;
		OutoffuelPanel.SetActive (true);
	}
	public void LevelComplete(){
		if (PlayerPrefs.GetInt ("LevelNo") - 1 == 4 || PlayerPrefs.GetInt ("LevelNo") - 1 == 10 || PlayerPrefs.GetInt ("LevelNo") - 1 == 20 || PlayerPrefs.GetInt ("LevelNo") - 1 == 25) {
			GameObject.FindWithTag ("harvesttruck").SetActive (false);
		} else {
			GameObject.FindWithTag ("Tractor").SetActive (false);
		}
		if (PlayerPrefs.GetInt ("unlock") <= PlayerPrefs.GetInt ("LevelNo")) {
			PlayerPrefs.SetInt ("unlock", PlayerPrefs.GetInt ("LevelNo")+1);
		}
		PlayerPrefs.SetInt ("earning", PlayerPrefs.GetInt("earning") + 100 );
		Time.timeScale = 0f;
		LevelCompletepanel.SetActive (true);
	}
	bool noselcheck;
	bool animcheck;
	void waitanimation(){
		animcheck = false;
	}

	public void harvestnosel(){
		if (animcheck == false) {
			animcheck = true;
			Invoke ("waitanimation", 2f);
			if (noselcheck == false) {
				GameObject.FindWithTag ("harvesttruck").GetComponent<Animation> ().Play ("harvestanimation");
				noselcheck = true;
			} else {
				GameObject.FindWithTag ("harvesttruck").GetComponent<Animation> ().Play ("harvestpackup");
				noselcheck = false;
			}
		}
	}
	public void CameraChange(){
		
		CameraChangecounter++;
		switch (CameraChangecounter) {
		case 1:
			{
				CameraC.GetComponent<RCCCarCamera> ().distance = 17;
				CameraC.GetComponent<RCCCarCamera> ().height = 17;
				break;
			}
		case 2:
			{
				if (Joints.TrolleyJointcheck == true) {
					CameraC.GetComponent<RCCCarCamera> ().distance = 17;
					CameraC.GetComponent<RCCCarCamera> ().height = 9;
				} else {
					CameraC.GetComponent<RCCCarCamera> ().distance = 11;
					CameraC.GetComponent<RCCCarCamera> ().height = 6;
				}
				CameraChangecounter = 0;
				break;
			}
		}

	}
	bool waterspraycheck;
	bool spraycheck;

	public void watertankfunc(){
		
		if (Joints.jointcounter == 5 || Joints.jointcounter == 6) {
			if (spraycheck == false) {
				SprayScript.spraycheck = true;
				Spray.SetActive (true);
				spraycheck = true;
			} else {
				SprayScript.spraycheck = false;
				Spray.SetActive (false);
				spraycheck = false;
			}
		} else {
		
		
			if (waterspraycheck == false) {
				waterScript.watercheck = true;
				WaterSpray.SetActive (true);
				waterspraycheck = true;
			} else {
				waterScript.watercheck = false;
				WaterSpray.SetActive (false);
				waterspraycheck = false;
			}

		}
	}
	public void jointbtn(){
		

		Destroy( GameObject.FindWithTag ("Arrow"));
		if (Joints.jointcounter == 1) {
			GameObject.FindWithTag ("TractorJoint").GetComponent<Joints> ().jointTrolley ();
		}
		if (Joints.jointcounter == 3) {
			
			RCCWheelCollider1.lastkidcheck = true;
			GameObject.FindWithTag ("TractorJoint").GetComponent<Joints> ().halljoint ();
		}

		if (Joints.jointcounter == 5) {
			GameObject.FindWithTag ("TractorJoint").GetComponent<Joints> ().SprayTankJoint ();
		}
		if (Joints.jointcounter == 7) {
			
			GameObject.FindWithTag ("TractorJoint").GetComponent<Joints> ().Watertankjoint ();
		}

		DisJointBtn.SetActive (true);
	}
	public void Disconnectjointbtn(){
		Debug.Log (Joints.jointcounter);
		if (Joints.jointcounter == 1) {
			
			GameObject.FindWithTag ("TractorJoint").GetComponent<Joints> ().DisconnectjointTrolley ();
		}
		if (Joints.jointcounter == 7) {

			GameObject.FindWithTag ("TractorJoint").GetComponent<Joints> ().DisconnectjointWatertank ();
		}
		if (Joints.jointcounter == 4) {
			
			GameObject.FindWithTag ("TractorJoint").GetComponent<Joints> ().hallunjoint ();
			//harvest.SetActive (false);
		}
		if (Joints.jointcounter == 6) {
			GameObject.FindWithTag ("TractorJoint").GetComponent<Joints> ().SprayTankUnJoint ();
		}
		DisJointBtn.SetActive (false);
	}
	bool haldowncheck;
	public void haldown(){
		if (haldowncheck == false) {
			RCCWheelCollider1.haldowncheck = true;
			RCCWheelCollider1.lastkidcheck = true;
			halanimaiton.GetComponent<Animation> ().Play ("HallDown");
			GameObject.FindWithTag ("Harvestcollider").GetComponent<BoxCollider> ().enabled = true;
			haldowncheck = true;
		} else {
			RCCWheelCollider1.haldowncheck = false;
			RCCWheelCollider1.lastkidcheck = true;
			halanimaiton.GetComponent<Animation> ().Play ("hallUp");
			GameObject.FindWithTag ("Harvestcollider").GetComponent<BoxCollider> ().enabled = false;
			haldowncheck = false;
		}

	}





}
