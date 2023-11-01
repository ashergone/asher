using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class GasstionScript : MonoBehaviour {
	public Image fuelbar;
	public Text Payment;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("earning", 500 );

		earningcouner = PlayerPrefs.GetInt ("earning" );
		//PlayerPrefs.SetFloat ("Fuel", 0);
		fuelbar = GameObject.Find ("FuelBar").GetComponent<Image> ();
		Payment = GameObject.Find ("Payment").GetComponent<Text> ();
		Payment.text = PlayerPrefs.GetInt ("earning").ToString ();
		fuelbar.fillAmount = PlayerPrefs.GetFloat ("Fuel");
		InvokeRepeating ("timerfule", 3, 3);
	}
	void timerfule(){
		
		if (PlayerPrefs.GetFloat ("Fuel") < 0) {
			GameObject.FindWithTag ("Canvas").GetComponent<UIManager> ().OutofFuel ();
		} else {
			if (PlayerPrefs.GetFloat ("Fuel") < 0.25) {
				fuelbar.color = Color.red;
			} else {
				fuelbar.color = Color.white;
			}
			PlayerPrefs.SetFloat ("Fuel", PlayerPrefs.GetFloat ("Fuel") - 0.01f);
			fuelbar.fillAmount = PlayerPrefs.GetFloat ("Fuel");
		}
	}
	public void addfuel(){
		PlayerPrefs.SetFloat ("Fuel", 0.30f);
		fuelbar.fillAmount = PlayerPrefs.GetFloat ("Fuel");

	}
	public void addfuelwithcash(){
		PlayerPrefs.SetFloat ("Fuel", 0.30f);
		fuelbar.fillAmount = PlayerPrefs.GetFloat ("Fuel");
		Payment.text = PlayerPrefs.GetInt ("earning").ToString ();

	}
	float earningcouner;
	void OnTriggerStay(Collider other) {
		if (other.transform.tag == "Tractor") {
			if (PlayerPrefs.GetFloat ("Fuel") <= 1) {
				if (PlayerPrefs.GetInt ("earning") > 0) {
					PlayerPrefs.SetFloat ("Fuel", PlayerPrefs.GetFloat ("Fuel") + 0.001f);

					fuelbar.fillAmount = PlayerPrefs.GetFloat ("Fuel");
					earningcouner = earningcouner - 0.08f;
					PlayerPrefs.SetInt ("earning", (int)earningcouner);
					Payment.text = PlayerPrefs.GetInt ("earning").ToString ();
				}
			} else {
				if (PlayerPrefs.GetInt ("LevelNo") - 1 == 0) {
					GameObject.FindWithTag ("Canvas").GetComponent<UIManager> ().LevelComplete ();
				}

			}
		} 
	}
	// Update is called once per frame
	void Update () {
	
	}
}
