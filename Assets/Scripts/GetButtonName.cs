using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GetButtonName : MonoBehaviour {
	public GameObject levellock;
	public GameObject Loading;
	private AsyncOperation async;


	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt(("unlock"), 12);
	}
	public void LevelLockOk(){
		levellock.SetActive (false);
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

	public void GetName()
	{
		//Adds.instance.HideAdmobBannerAd ();
		string buttonName;
		buttonName = this.gameObject.name;

		int count;
		count = int.Parse (buttonName);

		if (count == 1) {

			PlayerPrefs.SetInt ("LevelNo", count);

			Loading.SetActive (true);
			StartCoroutine (LevelCoroutine ());
			//Application.LoadLevel ("GamePlay");


		} else if (PlayerPrefs.GetInt ("unlock") >= count) {
			PlayerPrefs.SetInt ("LevelNo", count);

			Loading.SetActive (true);
			StartCoroutine (LevelCoroutine ());
			//Application.LoadLevel ("GamePlay");
		} 
		else if (PlayerPrefs.GetInt ("unlock") <= 26){
			
			//levellock.SetActive (true);
		}


	}
	// Update is called once per frame
	void Update () {
	
	}
}
