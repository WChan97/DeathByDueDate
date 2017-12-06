using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{

    private GameManager gameManager;
    public string mainMenu;

    void start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void RestartGame()
    {
        gameManager.RespawnPlayer();
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(mainMenu);
    }

}


