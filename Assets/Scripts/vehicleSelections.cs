using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class vehicleSelections : MonoBehaviour {

	public GameObject[] VehicleList;
	public GameObject[] VehicleDetails;
	public GameObject RighBtn;
	public GameObject LeftBtn;
	public Text [] vehiclePrice;
	public GameObject vehicleLock;
	public GameObject vehicleUnlock;
	public GameObject lockpic;
	public Text totalEarning;
	private AudioSource audiosource;
	public float x;
	// Use this for initialization
	public void backbtn(){
		//Adds.instance.ShowAdmobInterstitialAd ();
		Application.LoadLevel ("MainMenu");
	}
	public void ShowRewardedAd()
	{
        


		if(IronSource.Agent.isRewardedVideoAvailable())
        {
			AdsManager.instance.ShowIronSourceRewarded();
			PlayerPrefs.SetInt("earning", PlayerPrefs.GetInt("earning") + 100);
		}
    }





       
	//private void HandleShowResult(ShowResult result)
	//{
	//	switch (result)
	//	{
	//	case ShowResult.Finished:{
	//			PlayerPrefs.SetInt ("earning", PlayerPrefs.GetInt("earning")+ 100);
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
	void Start () {
		AudioListener.pause= false;
	

		//PlayerPrefs.DeleteAll ();
		//PlayerPrefs.SetInt ("earning", 0);
//		PlayerPrefs.SetInt ("UnlockVehicleNo1", 0);
//		PlayerPrefs.SetInt ("UnlockVehicleNo2", 0);
//		PlayerPrefs.SetInt ("UnlockVehicleNo3", 0);
//		PlayerPrefs.SetInt ("UnlockVehicleNo4", 0);
//		PlayerPrefs.SetInt ("UnlockVehicleNo5", 0);
//		PlayerPrefs.SetInt ("UnlockVehicleNo6", 0);
		//PlayerPrefs.SetInt ("earning", 6000);
		audiosource = GetComponent<AudioSource> ();
		if (PlayerPrefs.GetInt ("music") == 1) {
			
			audiosource.mute = true;
		}



		LeftBtn.SetActive (false);
	}

	int vehicleCount=0;
	public void RightButton(){

		LeftBtn.SetActive (true);
		vehicleCount = vehicleCount + 1;
		switch (vehicleCount) {
		case 1:
			{
				if (PlayerPrefs.GetInt ("UnlockVehicleNo1") == 1) {
					lockpic.SetActive (false);
				} else {
					lockpic.SetActive (true);

				}
				break;
			}
		case 2:
			{
				if (PlayerPrefs.GetInt ("UnlockVehicleNo2") == 1) {
					lockpic.SetActive (false);
				} else {

					lockpic.SetActive (true);
				}
				break;
			}
		case 3:
			{
				if (PlayerPrefs.GetInt ("UnlockVehicleNo3") == 1) {
					lockpic.SetActive (false);
				} else {

					lockpic.SetActive (true);
				}
				break;
			}
		case 4:
			{
				if (PlayerPrefs.GetInt ("UnlockVehicleNo4") == 1) {
					lockpic.SetActive (false);
				} else {
					lockpic.SetActive (true);
				}
				break;
			}
		case 5:
			{
				if (PlayerPrefs.GetInt ("UnlockVehicleNo5") == 1) {
					lockpic.SetActive (false);
				} else {
					lockpic.SetActive (true);
				}
				break;
			}
		case 6:
			{
				if (PlayerPrefs.GetInt ("UnlockVehicleNo6") == 1) {
					lockpic.SetActive (false);
				} else {
					lockpic.SetActive (true);
				}
				break;
			}
		}
		for (int counter = 0; VehicleList.Length > counter; counter++) {
			VehicleList [counter].SetActive (false);
			VehicleDetails [counter].SetActive (false);

		}
		if ( vehicleCount > VehicleList.Length-2 ) {
			RighBtn.SetActive (false);

		}

		VehicleList [vehicleCount].SetActive (true);
		VehicleDetails [vehicleCount].SetActive (true);
	}

	public void LeftButton(){
		

		vehicleCount = vehicleCount - 1;
		Debug.Log (vehicleCount);
		switch (vehicleCount) {
		case 0:
			{
				lockpic.SetActive (false);
				break;
			}
			case 1:
				{
					if (PlayerPrefs.GetInt ("UnlockVehicleNo1") == 1) {
						lockpic.SetActive (false);
					} else {
						lockpic.SetActive (true);
	
					}
					break;
				}
		case 2:
			{
				if (PlayerPrefs.GetInt ("UnlockVehicleNo2") == 1) {
					lockpic.SetActive (false);
				} else {

					lockpic.SetActive (true);
				}
				break;
			}
		case 3:
			{
				if (PlayerPrefs.GetInt ("UnlockVehicleNo3") == 1) {
					lockpic.SetActive (false);
				} else {

					lockpic.SetActive (true);
				}
				break;
			}
		case 4:
			{
				if (PlayerPrefs.GetInt ("UnlockVehicleNo4") == 1) {
					lockpic.SetActive (false);
				} else {
					lockpic.SetActive (true);
				}
				break;
			}
		case 5:
			{
				if (PlayerPrefs.GetInt ("UnlockVehicleNo5") == 1) {
					lockpic.SetActive (false);
				} else {
					lockpic.SetActive (true);
				}
				break;
			}
		case 6:
			{
				if (PlayerPrefs.GetInt ("UnlockVehicleNo6") == 1) {
					lockpic.SetActive (false);
				} else {
					lockpic.SetActive (true);
				}
				break;
			}
		}
		RighBtn.SetActive (true);


		for (int counter = 0; VehicleList.Length > counter; counter++) {
			VehicleList [counter].SetActive (false);
			VehicleDetails [counter].SetActive (false);
		}

		if ( vehicleCount ==0 ) {
			LeftBtn.SetActive (false);

		}

		VehicleList [vehicleCount].SetActive (true);
		VehicleDetails [vehicleCount].SetActive (true);
	}
	bool btnbool;
	public void unlockVehicleYes(){
		//Adds.instance.ShowAdmobInterstitialAd ();
		btnbool = true;

		SelectVehicle ();
		vehicleUnlock.SetActive (false);
	}
	public void unlockVehicleNo(){
		//Adds.instance.ShowAdmobInterstitialAd ();
		vehicleUnlock.SetActive (false);
	}
	int earning =0;

	public void SelectVehicle(){
		//Debug.Log ("selection");
		if (vehicleCount == 0) {
			PlayerPrefs.SetInt ("vehicle", vehicleCount);
			Application.LoadLevel ("LevelSelection");

		} else {


			earning = PlayerPrefs.GetInt ("earning");

			if (vehicleCount == 1 && PlayerPrefs.GetInt ("UnlockVehicleNo1") == 1) {
				
				PlayerPrefs.SetInt ("vehicle", vehicleCount);
				Application.LoadLevel ("LevelSelection");
			} else if (vehicleCount == 2 && PlayerPrefs.GetInt ("UnlockVehicleNo2") == 1) {
				PlayerPrefs.SetInt ("vehicle", vehicleCount);
				Application.LoadLevel ("LevelSelection");
			} else if (vehicleCount == 3 && PlayerPrefs.GetInt ("UnlockVehicleNo3") == 1) {
				PlayerPrefs.SetInt ("vehicle", vehicleCount);
				Application.LoadLevel ("LevelSelection");
			} else if (vehicleCount == 4 && PlayerPrefs.GetInt ("UnlockVehicleNo4") == 1) {
				PlayerPrefs.SetInt ("vehicle", vehicleCount);
				Application.LoadLevel ("LevelSelection");
			} else if (vehicleCount == 5 && PlayerPrefs.GetInt ("UnlockVehicleNo5") == 1) {
				PlayerPrefs.SetInt ("vehicle", vehicleCount);
				Application.LoadLevel ("LevelSelection");
			} else if (vehicleCount == 6 && PlayerPrefs.GetInt ("UnlockVehicleNo6") == 1) {
				PlayerPrefs.SetInt ("vehicle", vehicleCount);
				Application.LoadLevel ("LevelSelection");
			} else {
				
		


				string vehicleP;
				int vehiclePP = 0;



				vehicleP = vehiclePrice [vehicleCount].text;
				vehiclePP = int.Parse (vehicleP);

				if (earning >= vehiclePP) {
					
					vehicleUnlock.SetActive (true);
				} else {
					vehicleLock.SetActive (true);
				}

				if (earning >= vehiclePP && btnbool == true) {
					if (vehicleCount == 1) {
						PlayerPrefs.SetInt ("UnlockVehicleNo1", 1);

						earning =  vehiclePP - earning;
						PlayerPrefs.SetInt ("earning", -earning);
						lockpic.SetActive (false);
					}
					if (vehicleCount == 2) {
						PlayerPrefs.SetInt ("UnlockVehicleNo2", 1);
						earning = vehiclePP - earning;
						PlayerPrefs.SetInt ("earning", -earning);
						lockpic.SetActive (false);
					}
					if (vehicleCount == 3) {
						PlayerPrefs.SetInt ("UnlockVehicleNo3", 1);
						earning = vehiclePP - earning;
						PlayerPrefs.SetInt ("earning", -earning);
						lockpic.SetActive (false);
					}
					if (vehicleCount == 4) {
						PlayerPrefs.SetInt ("UnlockVehicleNo4", 1);
						earning = vehiclePP - earning;
						PlayerPrefs.SetInt ("earning", -earning);
						lockpic.SetActive (false);
					}
					if (vehicleCount == 5) {
						PlayerPrefs.SetInt ("UnlockVehicleNo5", 1);
						earning = vehiclePP - earning;
						PlayerPrefs.SetInt ("earning", -earning);
						lockpic.SetActive (false);
					}
					if (vehicleCount == 6) {
						PlayerPrefs.SetInt ("UnlockVehicleNo6", 1);
						earning = vehiclePP - earning;
						PlayerPrefs.SetInt ("earning", -earning);
						lockpic.SetActive (false);
					}
					btnbool = false;
					//vehicleUnlock.SetActive (true);
		
				} 
			}
		}
	}
	public void vehicleLockOk(){
		vehicleLock.SetActive (false);
	}
	public void BackButton(){
		Application.LoadLevel ("Main Menu");
	}


	
	// Update is called once per frame
	int earningV;
	void Update () {
	//	GameObject.FindWithTag ("CarRotation").transform.Rotate(0,x,0);

		earningV = PlayerPrefs.GetInt ("earning");
		totalEarning.text = earningV.ToString () + " $";
	}
}
