using UnityEngine;

public class SplashManage : MonoBehaviour
{
	public string MainMenuName;

	public GameObject TermsPanel;

	public GameObject PrivacyButton;

	public GameObject Background;

	private bool userConsent;

	private void Start()
	{
		if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 0)
		{
			
			
			
		}
		
		
	}

	public void pp()
    {

		Application.OpenURL("https://sites.google.com/view/flare-frost-studio/home?pli=1");
    }

	public void TermsOfService()
	{

		Application.OpenURL("https://flarefroststudio.com/");
	}

	public void YES()
    {
		Invoke("LoadNextScene", 2f);

	}

	public void OnClickYes()
	{
	
		if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 0)
		{
			Invoke("LoadNextScene", 0.5f);
		}
	}

	public void OnClickNo()
	{
	
		
		if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 0)
		{
			Invoke("LoadNextScene", 0.5f);
		}
	}


	public void LoadNextScene()
	{
        if (PlayerPrefs.GetInt("cutscene") == 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(MainMenuName);
        }
		else
		{
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
	}
    
        
}
