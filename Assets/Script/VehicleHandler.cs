using UnityEngine;
using System.Collections;

public class VehicleHandler : MonoBehaviour {
	public GameObject[] vehicle;
	//public GameObject [] EnemyVehicle;
	public GameObject[] Levels;
	GameObject pointer;
	int RandumNo;

	bool spawncheck;
	void Awake(){
		SpawnPlayerVehcile ();
	}
	// Use this for initialization
	void Start () {
		//Debug.Log (PlayerPrefs.GetInt ("vehicle"));
	//	PlayerPrefs.SetInt ("vehicle", 1);
	//	PlayerPrefs.SetInt ("Levelno", 1);
		LevelSelection ();
		



	}
void SpawnPlayerVehcile(){
	switch (PlayerPrefs.GetInt("vehicle")) {
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
			case 4:
			{
				Instantiate (vehicle [4]);
				
				break;
			}
	}
}
	// Update is called once per frame
	void Update () {

	}
	public void createLevel (){
		
		
		switch (Random.Range(1,13)) {
		case 1:
			{
				Instantiate (Levels [0]);
				
				break;
			}
		case 2:
			{
				Instantiate (Levels [1]);
				
				break;
			}
		case 3:
			{
				Instantiate (Levels [2]);
				
				break;
			}
		case 4:
			{
				Instantiate (Levels [3]);
				
				break;
			}
		case 5:
			{
				Instantiate (Levels [4]);
				
				break;
			}
			case 6:
			{
				Instantiate (Levels [5]);
				
				break;
			}
			case 7:
			{
				Instantiate (Levels [6]);
				
				break;
			}
			case 8:
			{
				Instantiate (Levels [7]);
				
				break;
			}
			case 9:
			{
				Instantiate (Levels [8]);
				
				break;
			}
			case 10:
			{
				Instantiate (Levels [9]);
				
				break;
			}
			case 11:
			{
				Instantiate (Levels [10]);
				
				break;
			}
			case 12:
			{
				Instantiate (Levels [11]);
				
				break;
			}

		}
	}
	void LevelSelection (){
		
		switch (PlayerPrefs.GetInt ("Levelno")) {
		case 1:
			{
				Instantiate (Levels [0]);
				
				break;
			}
		case 2:
			{
				Instantiate (Levels [1]);
				
				break;
			}
		case 3:
			{
				Instantiate (Levels [2]);
				
				break;
			}
		case 4:
			{
				Instantiate (Levels [3]);
				
				break;
			}
		case 5:
			{
				Instantiate (Levels [4]);
				
				break;
			}
			case 6:
			{
				Instantiate (Levels [5]);
				
				break;
			}
			case 7:
			{
				Instantiate (Levels [6]);
				
				break;
			}
			case 8:
			{
				Instantiate (Levels [7]);
				
				break;
			}
			case 9:
			{
				Instantiate (Levels [8]);
				
				break;
			}
			case 10:
			{
				Instantiate (Levels [9]);
				
				break;
			}
			case 11:
			{
				Instantiate (Levels [10]);
				
				break;
			}
			case 12:
			{
				Instantiate (Levels [11]);
				
				break;
			}
		}
	}
	//int counter;
	
	
	



	}




