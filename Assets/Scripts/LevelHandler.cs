using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LevelHandler : MonoBehaviour {
	public GameObject[] levels;
	public GameObject DummyHarvest;
	public GameObject dummytractor;
	public GameObject tractor;
	public Material green;
	public Material Red;
	public Material Blue;
	public Material yellow;
	public Text message; 
	public GameObject cutscenecamera;
	public GameObject cutscenecanvas;
	public GameObject Maincamera;
	public GameObject minimpa;
	public GameObject tractorsound;

	// Use this for initialization
	GameObject  Cameraassign;
	void Start () {
		
		switch (PlayerPrefs.GetInt ("vehicle")) {
		case 0:
			{
				tractor.GetComponent<MeshRenderer>().material = green;
				break;
			}
		case 1:
			{
				tractor.GetComponent<MeshRenderer>().material = Red;
				break;
			}
		case 2:
			{
				tractor.GetComponent<MeshRenderer>().material = Blue;
				break;
			}
		case 3:
			{
				tractor.GetComponent<MeshRenderer>().material = yellow;
				break;
			}
		}

		//PlayerPrefs.DeleteAll ();
		Cameraassign = GameObject.FindWithTag ("MainCamera");
		//PlayerPrefs.SetInt ("LevelNo", 20);
		if (PlayerPrefs.GetInt ("LevelNo")-1 == 4 || PlayerPrefs.GetInt ("LevelNo")-1 == 10 || PlayerPrefs.GetInt ("LevelNo")-1 == 20 || PlayerPrefs.GetInt ("LevelNo")-1 == 25) {
			Cameraassign.GetComponent<Camera>().GetComponent<RCCCarCamera> ().playerCar = GameObject.FindWithTag ("harvesttruck").transform;
			GameObject.FindWithTag ("Tractor").gameObject.SetActive (false);
			//dummytractor.SetActive (true);

		} else {
			//Debug.Log ("fdsfds");
			Cameraassign.GetComponent<Camera>().GetComponent<RCCCarCamera> ().playerCar = GameObject.FindWithTag ("Tractor").transform;
			GameObject.FindWithTag ("harvesttruck").SetActive (false);
			//DummyHarvest.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("LevelNo") - 1 == 0) {
			if (PlayerPrefs.GetInt ("Onlyonetime") == 0) {
				tractorsound.SetActive (false);
				Maincamera.GetComponent<Canvas> ().enabled = false;
				minimpa.GetComponent<Canvas> ().enabled = false;
				cutscenecamera.SetActive (true);
				cutscenecanvas.SetActive (true);

				Invoke ("cutscenewait", 40f);
				PlayerPrefs.SetInt ("Onlyonetime", 1);
			}
		}

		Instantiate (levels [PlayerPrefs.GetInt ("LevelNo")-1]);
		LevelDetail ();
	}
	public void cutsceneskip(){
		tractorsound.SetActive (true);
		Maincamera.GetComponent<Canvas> ().enabled = true;
		minimpa.GetComponent<Canvas> ().enabled = true;
		cutscenecamera.SetActive (false);
		cutscenecanvas.SetActive (false);
	}
	void cutscenewait(){
		tractorsound.SetActive (true);
		Maincamera.GetComponent<Canvas> ().enabled = true;
		minimpa.GetComponent<Canvas> ().enabled = true;
		cutscenecamera.SetActive (false);
		cutscenecanvas.SetActive (false);
	}
	void LevelDetail(){
		switch (PlayerPrefs.GetInt ("LevelNo")-1) {
		case 0:
			{
				
				message.text = "Drive to the nearest Gas station to get your vehicle fueled up. ";
				break;
			}
		case 1:
			{
				message.text = "Attach the Plough Machine to your Tractor and plow fields  for next season of crops";
				HallScript.hallcounter = 108;
				break;
			}
		case 2:
			{
				message.text = "Spray water on your Fields";
				waterScript.waterlevelcheck = 530;
				break;
			}
		case 3:
			{
				message.text = "Spray Insect Killer on your Fields";
				SprayScript.praycounter = 1320;

				break;
			}
		case 4:
			{
				message.text = "Attach the Harvester to your truck and start threshing your crops";
				harvestcollider.harvestcounter = 456;

				break;
			}
		case 5:
			{
				message.text = "Transport Wheat to your Warehouse";
				break;

			}
		case 6:
			{
				message.text = "Transport Wooden Boxes to your Warehouse";
				break;

			}
		case 7:
			{
				message.text = "Attach the Plough Machine to your Tractor and plow fields next season of crops";
				HallScript.hallcounter = 186;
				break;
			}
		case 8:
			{
				message.text = "Spray water on your Fields";
				waterScript.waterlevelcheck = 920;
				break;
			}
		case 9:
			{
				message.text = "Spray Insect Killer on your Fields";
				SprayScript.praycounter = 2030;

				break;
			}
		case 10:
			{
				message.text = "Attach the Harvester to your truck and start threshing your crops";
				harvestcollider.harvestcounter = 700;

				break;
			}
		case 11:
			{
				message.text = "Transport Wooden Barrels to your Warehouse";
				break;

			}
		case 12:
			{
				message.text = "Transport hay bales to your Warehouse";
				break;

			}
		case 13:
			{
				message.text = "Attach the Plough Machine to your Tractor and plow fields next season of crops";
				HallScript.hallcounter = 108;
				break;
			}
		case 14:
			{
				message.text = "Transport Oil Barrels to your Warehouse";
				break;

			}
		case 15:
			{
				message.text = "Spray water on your Fields";
				waterScript.waterlevelcheck = 530;
				break;
			}
		
		case 16:
			{
				message.text = "Transport cow to your FarmHouse";
				break;

			}
		case 17:
			{
				message.text = "Spray Insect Killer on your Fields";
				SprayScript.praycounter = 1320;

				break;
			}
		case 18:
			{
				message.text = "Transport cow to your FarmHouse";
				break;

			}
		case 19:
			{
				message.text = "Transport Goats to your FarmHouse";


				break;
			}
		case 20:
			{
				message.text = "Attach the Harvester to your truck and start threshing your crops";
				harvestcollider.harvestcounter = 456;

				break;
			}
		case 21:
			{
				message.text = "Transport Wheat to your Warehouse";
				break;

			}
		case 22:
			{
				message.text = "Attach the Plough Machine to your Tractor and plow fields next season of crops";
				HallScript.hallcounter = 186;
				break;
			}
		case 23:
			{
				message.text = "Spray water on your Fields";
				waterScript.waterlevelcheck = 920;
				break;
			}
		case 24:
			{
				message.text = "Spray Insect Killer on your Fields";
				SprayScript.praycounter = 2030;

				break;
			}
		case 25:
			{
				message.text = "Attach the Harvester to your truck and start threshing your crops";
				harvestcollider.harvestcounter = 700;

				break;
			}
		case 26:
			{
				message.text = "Transport Wheat to your Warehouse";
				break;

			}
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
