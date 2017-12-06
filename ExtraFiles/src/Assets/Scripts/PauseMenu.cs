using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public string mainMenuScene;
    public bool isPaused;
    public GameObject pauseMenuCanvas;

    private void Update()
    {
       if(isPaused)
        {
            
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

       if(Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
       
        }
    }


    /*public void RestartGame()
    {
       
        FindObjectOfType<GameManager>().RespawnPlayer();
    }*/

    public void QuitGame()
    {
        
        SceneManager.LoadScene(mainMenuScene);
    }

}


