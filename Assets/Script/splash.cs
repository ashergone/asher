using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class splash : MonoBehaviour {
	public Image bar;
	float barint;
	//public GameObject splashs;
	//public GameObject MainMenu;
	// Use this for initialization
	void Start () {
	//PlayerPrefs.SetInt("earning",6000);
	//PlayerPrefs.DeleteAll ();
	}
	
	// Update is called once per frame
	void Update () {
		barint = barint + 0.03f;
		bar.fillAmount = barint;
		if (barint > 1f) {
			//SceneManagement.SceneManager.LoadScene("MainMenu");
			Application.LoadLevel ("MainMenu");
		}
	}
}
