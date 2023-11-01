using UnityEngine;
using System.Collections;

public class VehiclesHandler : MonoBehaviour {
	public GameObject []vehicle;
	public Material sunset;
	public Material Snow;

	public GameObject sunsetenviroment;
	public GameObject Snowenviroment;
	public GameObject snowfalling;

	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("levelskin", 2);
		Enviroment ();
		//PlayerPrefs.SetInt ("vehicle", 4);
		SpawnVehicle ();

	}
	void Enviroment(){
		switch (PlayerPrefs.GetInt ("levelskin")) {
		case 1:
			{
				Instantiate (sunsetenviroment);
				RenderSettings.skybox = sunset;
				break;
			}
		case 2:
			{
				Instantiate (Snowenviroment);
				snowfalling.SetActive (true);
				RenderSettings.skybox = Snow;
				break;
			}
		
		}
	}
	void SpawnVehicle(){
		switch (PlayerPrefs.GetInt ("vehicle")) {
		case 0:
			{

				Instantiate (vehicle [0]);


				break;	
			}
		case 1:
			{
				Instantiate (vehicle [1]);


				break;	
			}
		case 2:
			{
				Instantiate (vehicle [2]);

				break;	
			}
		case 3:
			{
				Instantiate (vehicle [3]);

				break;	
			}
		
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
