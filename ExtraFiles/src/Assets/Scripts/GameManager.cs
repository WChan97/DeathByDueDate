using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject spawnPoint;
    public string nextLevel;

    private PlayerControl player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerControl>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RespawnPlayer()
    {
        Debug.Log("Player Respawn");
        player.transform.position = spawnPoint.transform.position;
    }

   public void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
