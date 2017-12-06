using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour {
	public int completionScore;
	public Text scoreText;

	private Rigidbody rb;


	// Use this for initialization
	void Start () {
		completionScore = 0;
		scoreText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTrigger(Collider other) {
		completionScore = completionScore + 1;
		SetScoreText ();
	}

	void SetScoreText () {
		scoreText.text = "Score: " + completionScore.ToString ();
	}
}
