using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public string startLevel;
	public string selectLevel;

    public void StartGame()
    {
		SceneManager.LoadScene(startLevel);
	
    }

    public void QuitGame()
    {

        Application.Quit();

    }
}