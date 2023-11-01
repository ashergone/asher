using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelText : MonoBehaviour {
	bool isMissionTyping;
	int l = 0;
	public Text missionText;


	public void StartMissionMessage (float showtime, string str)
	{
		StopAllCoroutines ();
		isMissionTyping = false;
		StartCoroutine (MissionCorutine (showtime, str));
	}

	IEnumerator MissionCorutine (float t, string str)
	{
		if (!isMissionTyping) {
			yield return new WaitForSeconds (t);
			//audio.PlayOneShot (clip);
			missionOne (str);
			StartCoroutine (MissionCorutine (t, str));
		} else {

		}
	}

	public void missionOne (string st)
	{
		if (l < st.Length) {
			missionText.text = string.Concat (missionText.text, st [l]);
			l++;

		} else {

			isMissionTyping = true;
		}

	}

	public void MissionText(){
		switch (PlayerPrefs.GetInt ("Levelno")) {
		case 1:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 2:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 3:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 4:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 5:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 6:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 7:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 8:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}

		case 9:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 10:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 11:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 12:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 13:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 14:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 15:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 16:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 17:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 18:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 19:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 20:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 21:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 22:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 23:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 24:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 25:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 26:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 27:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 28:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 29:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}
		case 30:
			{
				StartMissionMessage (.2f, "Take it to Drug shop");
				break;
			}


		}
	}

	public void Play(){
		Application.LoadLevel ("GamePlay");
	}
	// Use this for initialization
	void Start () {
		MissionText ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
